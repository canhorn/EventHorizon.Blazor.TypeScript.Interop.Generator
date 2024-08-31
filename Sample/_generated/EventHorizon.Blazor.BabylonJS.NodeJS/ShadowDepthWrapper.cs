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

    [JsonConverter(typeof(CachedEntityConverter<ShadowDepthWrapper>))]
    public class ShadowDepthWrapper : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public bool standalone
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "standalone"); }
        }

        private Material __baseMaterial;
        public Material baseMaterial
        {
            get
            {
                if (__baseMaterial == null)
                {
                    __baseMaterial = EventHorizonBlazorInterop.GetClass<Material>(
                        this.___guid,
                        "baseMaterial",
                        (entity) =>
                        {
                            return new Material() { ___guid = entity.___guid };
                        }
                    );
                }
                return __baseMaterial;
            }
        }

        public bool doNotInjectCode
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "doNotInjectCode"); }
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public ShadowDepthWrapper()
            : base() { }

        public ShadowDepthWrapper(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public ShadowDepthWrapper(
            Material baseMaterial,
            Scene scene = null,
            IIOptionShadowDepthMaterial options = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ShadowDepthWrapper" },
                baseMaterial,
                scene,
                options
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public DrawWrapper getEffect(
            SubMesh subMesh,
            ShadowGenerator shadowGenerator,
            decimal passIdForDrawWrapper
        )
        {
            return EventHorizonBlazorInterop.FuncClass<DrawWrapper>(
                entity => new DrawWrapper() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEffect" },
                    subMesh,
                    shadowGenerator,
                    passIdForDrawWrapper
                }
            );
        }

        public bool isReadyForSubMesh(
            SubMesh subMesh,
            string[] defines,
            ShadowGenerator shadowGenerator,
            bool useInstances,
            decimal passIdForDrawWrapper
        )
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReadyForSubMesh" },
                    subMesh,
                    defines,
                    shadowGenerator,
                    useInstances,
                    passIdForDrawWrapper
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
