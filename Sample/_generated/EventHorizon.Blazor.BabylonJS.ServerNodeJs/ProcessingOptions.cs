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

    public interface ProcessingOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<ProcessingOptionsCachedEntity>))]
    public class ProcessingOptionsCachedEntity : CachedEntityObject, ProcessingOptions
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

        public async ValueTask<string[]> get_defines()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(this.___guid, "defines");
        }

        public ValueTask set_defines(string[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "defines", value);
        }

        public async ValueTask<CachedEntity> get_indexParameters()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "indexParameters",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_indexParameters(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "indexParameters", value);
        }

        public async ValueTask<bool> get_isFragment()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isFragment");
        }

        public ValueTask set_isFragment(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isFragment", value);
        }

        public async ValueTask<bool> get_shouldUseHighPrecisionShader()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "shouldUseHighPrecisionShader"
            );
        }

        public ValueTask set_shouldUseHighPrecisionShader(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "shouldUseHighPrecisionShader",
                value
            );
        }

        public async ValueTask<bool> get_supportsUniformBuffers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "supportsUniformBuffers"
            );
        }

        public ValueTask set_supportsUniformBuffers(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "supportsUniformBuffers", value);
        }

        public async ValueTask<string> get_shadersRepository()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "shadersRepository");
        }

        public ValueTask set_shadersRepository(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shadersRepository", value);
        }

        public async ValueTask<CachedEntity> get_includesShadersStore()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "includesShadersStore",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_includesShadersStore(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "includesShadersStore", value);
        }

        private IShaderProcessorCachedEntity __processor;

        public async ValueTask<IShaderProcessorCachedEntity> get_processor()
        {
            if (__processor == null)
            {
                __processor =
                    await EventHorizonBlazorInterop.GetClass<IShaderProcessorCachedEntity>(
                        this.___guid,
                        "processor",
                        (entity) =>
                        {
                            return new IShaderProcessorCachedEntity() { ___guid = entity.___guid };
                        }
                    );
            }
            return __processor;
        }

        public ValueTask set_processor(IShaderProcessorCachedEntity value)
        {
            __processor = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "processor", value);
        }

        public async ValueTask<string> get_version()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "version");
        }

        public ValueTask set_version(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "version", value);
        }

        public async ValueTask<string> get_platformName()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "platformName");
        }

        public ValueTask set_platformName(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "platformName", value);
        }

        public async ValueTask<bool> get_lookForClosingBracketForUniformBuffer()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "lookForClosingBracketForUniformBuffer"
            );
        }

        public ValueTask set_lookForClosingBracketForUniformBuffer(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "lookForClosingBracketForUniformBuffer",
                value
            );
        }

        private ShaderProcessingContextCachedEntity __processingContext;

        public async ValueTask<ShaderProcessingContextCachedEntity> get_processingContext()
        {
            if (__processingContext == null)
            {
                __processingContext =
                    await EventHorizonBlazorInterop.GetClass<ShaderProcessingContextCachedEntity>(
                        this.___guid,
                        "processingContext",
                        (entity) =>
                        {
                            return new ShaderProcessingContextCachedEntity()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
            }
            return __processingContext;
        }

        public ValueTask set_processingContext(ShaderProcessingContextCachedEntity value)
        {
            __processingContext = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "processingContext", value);
        }

        public async ValueTask<bool> get_isNDCHalfZRange()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isNDCHalfZRange");
        }

        public ValueTask set_isNDCHalfZRange(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isNDCHalfZRange", value);
        }

        public async ValueTask<bool> get_useReverseDepthBuffer()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "useReverseDepthBuffer");
        }

        public ValueTask set_useReverseDepthBuffer(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useReverseDepthBuffer", value);
        }

        public async ValueTask<
            ActionResultCallback<ActionResultCallback<string, string, string[], string>>
        > get_processCodeAfterIncludes()
        {
            return await EventHorizonBlazorInterop.Get<
                ActionResultCallback<ActionResultCallback<string, string, string[], string>>
            >(this.___guid, "processCodeAfterIncludes");
        }

        public ValueTask set_processCodeAfterIncludes(
            ActionResultCallback<ActionResultCallback<string, string, string[], string>> value
        )
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "processCodeAfterIncludes", value);
        }
        #endregion

        #region Constructor
        public ProcessingOptionsCachedEntity()
            : base() { }

        public ProcessingOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
