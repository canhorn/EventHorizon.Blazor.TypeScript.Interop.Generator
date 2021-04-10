using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;

namespace EventHorizon.Blazor.Interop
{
    public static class CachedEntityExtensions
    {
        public static T ToEntity<T>(
            this CachedEntity entity
        ) where T : CachedEntity, new()
        {
            return new T() { ___guid = entity.___guid };
        }
    }
}

namespace BABYLON
{
    public static class BabylonjsNodeExtensions
    {
        public static async ValueTask setParent(
            this Node node,
            string elementId
        )
        {
            await EventHorizonBlazorInterop.FuncClass<CachedEntity>(
                entity => new CachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { node.___guid, "setParent" },
                    elementId
                }
            );
        }

        public static async Task<T> clone<T>(
            this Node node,
            string name
        ) where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { node.___guid, "clone" },
                    name
                }
            );
        }
    }
}
