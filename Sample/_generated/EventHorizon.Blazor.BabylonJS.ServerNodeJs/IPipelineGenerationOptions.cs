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

    public interface IPipelineGenerationOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPipelineGenerationOptionsCachedEntity>))]
    public class IPipelineGenerationOptionsCachedEntity
        : CachedEntityObject,
            IPipelineGenerationOptions
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

        public async ValueTask<string> get_shaderNameOrContent()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "shaderNameOrContent");
        }

        public ValueTask set_shaderNameOrContent(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shaderNameOrContent", value);
        }

        public async ValueTask<string> get_key()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "key");
        }

        public ValueTask set_key(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "key", value);
        }

        public async ValueTask<string[]> get_defines()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(this.___guid, "defines");
        }

        public ValueTask set_defines(string[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "defines", value);
        }

        public async ValueTask<bool> get_addGlobalDefines()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "addGlobalDefines");
        }

        public ValueTask set_addGlobalDefines(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "addGlobalDefines", value);
        }

        public async ValueTask<int> get_shaderLanguage()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "shaderLanguage");
        }

        public ValueTask set_shaderLanguage(int value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shaderLanguage", value);
        }

        public async ValueTask<string> get_platformName()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "platformName");
        }

        public ValueTask set_platformName(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "platformName", value);
        }

        private ProcessingOptionsCachedEntity __extendedProcessingOptions;

        public async ValueTask<ProcessingOptionsCachedEntity> get_extendedProcessingOptions()
        {
            if (__extendedProcessingOptions == null)
            {
                __extendedProcessingOptions =
                    await EventHorizonBlazorInterop.GetClass<ProcessingOptionsCachedEntity>(
                        this.___guid,
                        "extendedProcessingOptions",
                        (entity) =>
                        {
                            return new ProcessingOptionsCachedEntity() { ___guid = entity.___guid };
                        }
                    );
            }
            return __extendedProcessingOptions;
        }

        public ValueTask set_extendedProcessingOptions(ProcessingOptionsCachedEntity value)
        {
            __extendedProcessingOptions = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "extendedProcessingOptions", value);
        }

        private ICreateAndPreparePipelineContextOptionsCachedEntity __extendedCreatePipelineOptions;

        public async ValueTask<ICreateAndPreparePipelineContextOptionsCachedEntity> get_extendedCreatePipelineOptions()
        {
            if (__extendedCreatePipelineOptions == null)
            {
                __extendedCreatePipelineOptions =
                    await EventHorizonBlazorInterop.GetClass<ICreateAndPreparePipelineContextOptionsCachedEntity>(
                        this.___guid,
                        "extendedCreatePipelineOptions",
                        (entity) =>
                        {
                            return new ICreateAndPreparePipelineContextOptionsCachedEntity()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
            }
            return __extendedCreatePipelineOptions;
        }

        public ValueTask set_extendedCreatePipelineOptions(
            ICreateAndPreparePipelineContextOptionsCachedEntity value
        )
        {
            __extendedCreatePipelineOptions = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "extendedCreatePipelineOptions",
                value
            );
        }
        #endregion

        #region Constructor
        public IPipelineGenerationOptionsCachedEntity()
            : base() { }

        public IPipelineGenerationOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
