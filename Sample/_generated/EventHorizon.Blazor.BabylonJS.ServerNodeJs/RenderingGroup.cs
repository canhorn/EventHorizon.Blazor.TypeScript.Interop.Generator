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

    [JsonConverter(typeof(CachedEntityConverter<RenderingGroup>))]
    public class RenderingGroup : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<decimal> defaultTransparentSortCompare(SubMesh a, SubMesh b)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "RenderingGroup", "defaultTransparentSortCompare" },
                    a,
                    b
                }
            );
        }

        public static async ValueTask<decimal> backToFrontSortCompare(SubMesh a, SubMesh b)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "RenderingGroup", "backToFrontSortCompare" },
                    a,
                    b
                }
            );
        }

        public static async ValueTask<decimal> frontToBackSortCompare(SubMesh a, SubMesh b)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "RenderingGroup", "frontToBackSortCompare" },
                    a,
                    b
                }
            );
        }

        public static async ValueTask<decimal> PainterSortCompare(SubMesh a, SubMesh b)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "RenderingGroup", "PainterSortCompare" },
                    a,
                    b
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        public async ValueTask<decimal> get_index()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "index");
        }

        public ValueTask set_index(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "index", value);
        }
        #endregion

        #region Constructor
        public RenderingGroup()
            : base() { }

        public RenderingGroup(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<RenderingGroup> NewRenderingGroup(
            decimal index,
            Scene scene,
            ActionResultCallback<SubMesh, SubMesh, decimal> opaqueSortCompareFn = null,
            ActionResultCallback<SubMesh, SubMesh, decimal> alphaTestSortCompareFn = null,
            ActionResultCallback<SubMesh, SubMesh, decimal> transparentSortCompareFn = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderingGroup" },
                index,
                scene,
                opaqueSortCompareFn,
                alphaTestSortCompareFn,
                transparentSortCompareFn
            );

            return new RenderingGroup(entity);
        }
        #endregion

        #region Methods
        public async ValueTask onBeforeTransparentRendering()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "onBeforeTransparentRendering" } }
            );
        }

        public async ValueTask render(
            ActionCallback<
                SmartArray<SubMesh>,
                SmartArray<SubMesh>,
                SmartArray<SubMesh>,
                SmartArray<SubMesh>
            > customRenderFunction,
            bool renderSprites,
            bool renderParticles,
            AbstractMesh[] activeMeshes
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" },
                    customRenderFunction,
                    renderSprites,
                    renderParticles,
                    activeMeshes
                }
            );
        }

        public async ValueTask prepare()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "prepare" } }
            );
        }

        public async ValueTask prepareSprites()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "prepareSprites" } }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
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
        #endregion
    }
}
