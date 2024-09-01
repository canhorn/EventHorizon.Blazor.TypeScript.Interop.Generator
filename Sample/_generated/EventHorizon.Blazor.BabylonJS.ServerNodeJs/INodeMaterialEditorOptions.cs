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

    public interface INodeMaterialEditorOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<INodeMaterialEditorOptionsCachedEntity>))]
    public class INodeMaterialEditorOptionsCachedEntity
        : CachedEntityObject,
            INodeMaterialEditorOptions
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

        public async ValueTask<string> get_editorURL()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "editorURL");
        }

        public ValueTask set_editorURL(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "editorURL", value);
        }

        public async ValueTask<CachedEntity> get_nodeEditorConfig()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "nodeEditorConfig",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_nodeEditorConfig(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "nodeEditorConfig", value);
        }
        #endregion

        #region Constructor
        public INodeMaterialEditorOptionsCachedEntity()
            : base() { }

        public INodeMaterialEditorOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
