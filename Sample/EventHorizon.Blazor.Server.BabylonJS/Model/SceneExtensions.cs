namespace EventHorizon.Blazor.Server.BabylonJS.Model;

using System.Threading.Tasks;
using BABYLON;
using EventHorizon.Blazor.Server.Interop;

public static class SceneExtensions
{
    public static async ValueTask enablePhysics(
        this Scene scene,
        Vector3 gravity,
        IPhysicsEnginePluginV2 plugin
    )
    {
        await EventHorizonBlazorInterop.Func<bool>(
            new object[] { new string[] { scene.___guid, "enablePhysics" }, gravity, plugin }
        );
    }
}
