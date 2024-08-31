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

    public interface ShaderProcessingContext : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<ShaderProcessingContextCachedEntity>))]
    public class ShaderProcessingContextCachedEntity : CachedEntityObject, ShaderProcessingContext
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

        public async ValueTask<CachedEntity> get_vertexBufferKindToNumberOfComponents()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "vertexBufferKindToNumberOfComponents",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_vertexBufferKindToNumberOfComponents(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "vertexBufferKindToNumberOfComponents",
                value
            );
        }
        #endregion

        #region Constructor
        public ShaderProcessingContextCachedEntity()
            : base() { }

        public ShaderProcessingContextCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
