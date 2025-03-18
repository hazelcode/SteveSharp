using SteveSharp.Core;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Utils;

public class Hitbox {
    public float Width = 1.0f;
    public float Height = 1.0f;

    public string Id { get; set; }
    public string Workspace;
    private FunctionContext _ctx;
    public (string x, string y, string z) coords;

    public Hitbox(string id, string workspace, FunctionContext ctx) {
        Id = id;
        Workspace = workspace;
        coords = XYZ.Vec3("~", "~", "~");
        _ctx = ctx;
    }

    public void Setup(Action<FunctionContext> onAttack, Action<FunctionContext> onRightClick) {
        _ctx.Project.FunctionIndex.Add($"{_ctx!.Namespace}:hitbox/{Workspace}/on_attack", OnAttack(onAttack));
        _ctx.Project.FunctionIndex.Add($"{_ctx!.Namespace}:hitbox/{Workspace}/on_right_click", OnRightClick(onRightClick));
    }

    public string Invoke() {
        return Function.Call($"{_ctx!.Namespace}:hitbox/{Workspace}/summon");
    }
    public Function OnAttack(Action<FunctionContext> body) {
        return new Function(
            name: $"{_ctx!.Namespace}:hitbox/{Workspace}/on_attack",
            body: (ctx) => {
                body(ctx);
                return FunctionBuilder.Collect();
            }
        );
    }
    private Function OnRightClick(Action<FunctionContext> body) {
        return new Function(
            name: $"{_ctx!.Namespace}:hitbox/{Workspace}/on_right_click",
            body: (ctx) => {
                body(ctx);
                return FunctionBuilder.Collect();
            }
        );
    }
    public Function SummonFunction() {
        return new Function(
            name: $"{_ctx!.Namespace}:hitbox/{Workspace}/summon",
            body: (ctx) => {
                Entity.Summon("interaction", [coords.x, coords.y, coords.y], "{Tags:[\"" + _ctx.Namespace + "." + Id + "\"],width:" + Width + ",height:" + Height + "}");
                Execute.Write(
                    Str.Execute.Asat(Entity.AllEntities("type=interaction,tag=" + _ctx.Namespace + "." + Id)) +
                    "on attacker ",
                    [Function.Call($"{_ctx.Namespace}:hitbox/{Workspace}/on_attack")]
                );
                Execute.Write(
                    Str.Execute.Asat(Entity.AllEntities("type=interaction,tag=" + _ctx.Namespace + "." + Id)) +
                    "on target ",
                    [Function.Call($"{_ctx.Namespace}:hitbox/{Workspace}/on_right_click")]
                );
                Entity.Kill(Entity.AllEntities("type=interaction,tag=" + _ctx.Namespace + "." + Id));
                return FunctionBuilder.Collect();
            }
        );
    }
}