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

    public interface PrePassEffectConfiguration : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<PrePassEffectConfigurationCachedEntity>))]
    public class PrePassEffectConfigurationCachedEntity
        : CachedEntityObject,
            PrePassEffectConfiguration
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

        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "name");
        }

        public ValueTask set_name(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "name", value);
        }

        private PostProcess __postProcess;

        public async ValueTask<PostProcess> get_postProcess()
        {
            if (__postProcess == null)
            {
                __postProcess = await EventHorizonBlazorInterop.GetClass<PostProcess>(
                    this.___guid,
                    "postProcess",
                    (entity) =>
                    {
                        return new PostProcess() { ___guid = entity.___guid };
                    }
                );
            }
            return __postProcess;
        }

        public ValueTask set_postProcess(PostProcess value)
        {
            __postProcess = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "postProcess", value);
        }

        public async ValueTask<decimal[]> get_texturesRequired()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                this.___guid,
                "texturesRequired"
            );
        }

        public ValueTask set_texturesRequired(decimal[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "texturesRequired", value);
        }

        public async ValueTask<bool> get_enabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "enabled");
        }

        public ValueTask set_enabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "enabled", value);
        }

        public async ValueTask<bool> get_needsImageProcessing()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "needsImageProcessing");
        }

        public ValueTask set_needsImageProcessing(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "needsImageProcessing", value);
        }
        #endregion

        #region Constructor
        public PrePassEffectConfigurationCachedEntity()
            : base() { }

        public PrePassEffectConfigurationCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public async ValueTask<PostProcess> createPostProcess()
        {
            return await EventHorizonBlazorInterop.FuncClass<PostProcess>(
                entity => new PostProcess() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createPostProcess" } }
            );
        }
        #endregion
    }
}
