namespace EventHorizon.Blazor.BabylonJS.Model;

using BABYLON;
using EventHorizon.Blazor.Interop;

public static class SceneExtensions
{
    public static void enablePhysics(
        this Scene scene,
        Vector3 gravity,
        IPhysicsEnginePluginV2 plugin
    )
    {
        EventHorizonBlazorInterop.Func<bool>(
            new object[] { new string[] { scene.___guid, "enablePhysics" }, gravity, plugin }
        );
    }
}
