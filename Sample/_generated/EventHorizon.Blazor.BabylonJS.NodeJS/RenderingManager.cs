/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<RenderingManager>))]
    public class RenderingManager : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static decimal MAX_RENDERINGGROUPS
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "RenderingManager.MAX_RENDERINGGROUPS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "RenderingManager.MAX_RENDERINGGROUPS",
                    value
                );
            }
        }

        public static decimal MIN_RENDERINGGROUPS
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "RenderingManager.MIN_RENDERINGGROUPS"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "RenderingManager.MIN_RENDERINGGROUPS",
                    value
                );
            }
        }

        public static bool AUTOCLEAR
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>("BABYLON", "RenderingManager.AUTOCLEAR");
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "RenderingManager.AUTOCLEAR", value);
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public bool maintainStateBetweenFrames
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "maintainStateBetweenFrames"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "maintainStateBetweenFrames", value);
            }
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

        public RenderingManager(Scene scene)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderingManager" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void restoreDispachedFlags()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "restoreDispachedFlags" } }
            );
        }

        public RenderingGroup getRenderingGroup(decimal id)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderingGroup>(
                entity => new RenderingGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRenderingGroup" }, id }
            );
        }

        public void render(
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
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }

        public void resetSprites()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "resetSprites" } }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public void freeRenderingGroups()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "freeRenderingGroups" } }
            );
        }

        public void dispatchSprites(ISpriteManager spriteManager)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispatchSprites" }, spriteManager }
            );
        }

        public void dispatchParticles(IParticleSystem particleSystem)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispatchParticles" }, particleSystem }
            );
        }

        public void dispatch(SubMesh subMesh, AbstractMesh mesh = null, Material material = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispatch" }, subMesh, mesh, material }
            );
        }

        public void setRenderingOrder(
            decimal renderingGroupId,
            ActionResultCallback<SubMesh, SubMesh, decimal> opaqueSortCompareFn = null,
            ActionResultCallback<SubMesh, SubMesh, decimal> alphaTestSortCompareFn = null,
            ActionResultCallback<SubMesh, SubMesh, decimal> transparentSortCompareFn = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void setRenderingAutoClearDepthStencil(
            decimal renderingGroupId,
            bool autoClearDepthStencil,
            System.Nullable<bool> depth = null,
            System.Nullable<bool> stencil = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public IRenderingManagerAutoClearSetupCachedEntity getAutoClearDepthStencilSetup(
            decimal index
        )
        {
            return EventHorizonBlazorInterop.FuncClass<IRenderingManagerAutoClearSetupCachedEntity>(
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
