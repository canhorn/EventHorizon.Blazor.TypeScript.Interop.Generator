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

    public interface IRenderTargetTexture : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IRenderTargetTextureCachedEntity>))]
    public class IRenderTargetTextureCachedEntity : CachedEntityObject, IRenderTargetTexture
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        private RenderTargetWrapper __renderTarget;
        public RenderTargetWrapper renderTarget
        {
            get
            {
                if (__renderTarget == null)
                {
                    __renderTarget = EventHorizonBlazorInterop.GetClass<RenderTargetWrapper>(
                        this.___guid,
                        "renderTarget",
                        (entity) =>
                        {
                            return new RenderTargetWrapper() { ___guid = entity.___guid };
                        }
                    );
                }
                return __renderTarget;
            }
            set
            {
                __renderTarget = null;
                EventHorizonBlazorInterop.Set(this.___guid, "renderTarget", value);
            }
        }
        #endregion

        #region Constructor
        public IRenderTargetTextureCachedEntity()
            : base() { }

        public IRenderTargetTextureCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
