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

    [JsonConverter(typeof(CachedEntityConverter<RenderingGroup>))]
    public class RenderingGroup : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static decimal defaultTransparentSortCompare(SubMesh a, SubMesh b)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "RenderingGroup", "defaultTransparentSortCompare" },
                    a,
                    b
                }
            );
        }

        public static decimal backToFrontSortCompare(SubMesh a, SubMesh b)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "RenderingGroup", "backToFrontSortCompare" },
                    a,
                    b
                }
            );
        }

        public static decimal frontToBackSortCompare(SubMesh a, SubMesh b)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "RenderingGroup", "frontToBackSortCompare" },
                    a,
                    b
                }
            );
        }

        public static decimal PainterSortCompare(SubMesh a, SubMesh b)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
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

        public decimal index
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "index"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "index", value);
            }
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

        public RenderingGroup(
            decimal index,
            Scene scene,
            ActionResultCallback<SubMesh, SubMesh, decimal> opaqueSortCompareFn = null,
            ActionResultCallback<SubMesh, SubMesh, decimal> alphaTestSortCompareFn = null,
            ActionResultCallback<SubMesh, SubMesh, decimal> transparentSortCompareFn = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RenderingGroup" },
                index,
                scene,
                opaqueSortCompareFn,
                alphaTestSortCompareFn,
                transparentSortCompareFn
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void onBeforeTransparentRendering()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "onBeforeTransparentRendering" } }
            );
        }

        public void render(
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
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void prepare()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "prepare" } }
            );
        }

        public void prepareSprites()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "prepareSprites" } }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public void dispatch(SubMesh subMesh, AbstractMesh mesh = null, Material material = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispatch" }, subMesh, mesh, material }
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
        #endregion
    }
}
