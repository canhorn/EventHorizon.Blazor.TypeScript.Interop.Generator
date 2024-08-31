/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<RenderingManager>))]
    public class RenderingManager : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<decimal> get_MAX_RENDERINGGROUPS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "RenderingManager.MAX_RENDERINGGROUPS"
            );
        }

        public static ValueTask set_MAX_RENDERINGGROUPS(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "RenderingManager.MAX_RENDERINGGROUPS",
                value
            );
        }

        public static async ValueTask<decimal> get_MIN_RENDERINGGROUPS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "RenderingManager.MIN_RENDERINGGROUPS"
            );
        }

        public static ValueTask set_MIN_RENDERINGGROUPS(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "RenderingManager.MIN_RENDERINGGROUPS",
                value
            );
        }

        public static async ValueTask<bool> get_AUTOCLEAR()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "RenderingManager.AUTOCLEAR"
            );
        }

        public static ValueTask set_AUTOCLEAR(bool value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "RenderingManager.AUTOCLEAR", value);
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<bool> get_maintainStateBetweenFrames()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "maintainStateBetweenFrames"
            );
        }

        public ValueTask set_maintainStateBetweenFrames(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maintainStateBetweenFrames", value);
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public RenderingManager()
            : base() { }

        public RenderingManager(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<RenderingManager> NewRenderingManager(Scene scene)
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderingManager" },
                scene
            );

            return new RenderingManager(entity);
        }
        #endregion

        #region Methods
        public async ValueTask restoreDispachedFlags()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "restoreDispachedFlags" } }
            );
        }

        public async ValueTask<RenderingGroup> getRenderingGroup(decimal id)
        {
            return await EventHorizonBlazorInterop.FuncClass<RenderingGroup>(
                entity => new RenderingGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRenderingGroup" }, id }
            );
        }

        public async ValueTask render(
            ActionCallback<
                SmartArray<SubMesh>,
                SmartArray<SubMesh>,
                SmartArray<SubMesh>,
                SmartArray<SubMesh>
            > customRenderFunction,
            AbstractMesh[] activeMeshes,
            bool renderParticles,
            bool renderSprites
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" },
                    customRenderFunction,
                    activeMeshes,
                    renderParticles,
                    renderSprites
                }
            );
        }

        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }

        public async ValueTask resetSprites()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resetSprites" } }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public async ValueTask freeRenderingGroups()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "freeRenderingGroups" } }
            );
        }

        public async ValueTask dispatchSprites(ISpriteManager spriteManager)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispatchSprites" }, spriteManager }
            );
        }

        public async ValueTask dispatchParticles(IParticleSystem particleSystem)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispatchParticles" }, particleSystem }
            );
        }

        public async ValueTask dispatch(
            SubMesh subMesh,
            AbstractMesh mesh = null,
            Material material = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispatch" }, subMesh, mesh, material }
            );
        }

        public async ValueTask setRenderingOrder(
            decimal renderingGroupId,
            ActionResultCallback<SubMesh, SubMesh, decimal> opaqueSortCompareFn = null,
            ActionResultCallback<SubMesh, SubMesh, decimal> alphaTestSortCompareFn = null,
            ActionResultCallback<SubMesh, SubMesh, decimal> transparentSortCompareFn = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRenderingOrder" },
                    renderingGroupId,
                    opaqueSortCompareFn,
                    alphaTestSortCompareFn,
                    transparentSortCompareFn
                }
            );
        }

        public async ValueTask setRenderingAutoClearDepthStencil(
            decimal renderingGroupId,
            bool autoClearDepthStencil,
            System.Nullable<bool> depth = null,
            System.Nullable<bool> stencil = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRenderingAutoClearDepthStencil" },
                    renderingGroupId,
                    autoClearDepthStencil,
                    depth,
                    stencil
                }
            );
        }

        public async ValueTask<IRenderingManagerAutoClearSetupCachedEntity> getAutoClearDepthStencilSetup(
            decimal index
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<IRenderingManagerAutoClearSetupCachedEntity>(
                entity => new IRenderingManagerAutoClearSetupCachedEntity()
                {
                    ___guid = entity.___guid
                },
                new object[]
                {
                    new string[] { this.___guid, "getAutoClearDepthStencilSetup" },
                    index
                }
            );
        }
        #endregion
    }
}
