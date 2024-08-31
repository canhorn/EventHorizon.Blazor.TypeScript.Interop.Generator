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

        public string[] defines
        {
            get { return EventHorizonBlazorInterop.GetArray<string>(this.___guid, "defines"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "defines", value);
            }
        }

        public CachedEntity indexParameters
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "indexParameters",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "indexParameters", value);
            }
        }

        public bool isFragment
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isFragment"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isFragment", value);
            }
        }

        public bool shouldUseHighPrecisionShader
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "shouldUseHighPrecisionShader"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shouldUseHighPrecisionShader", value);
            }
        }

        public bool supportsUniformBuffers
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "supportsUniformBuffers");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "supportsUniformBuffers", value);
            }
        }

        public string shadersRepository
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "shadersRepository"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shadersRepository", value);
            }
        }

        public CachedEntity includesShadersStore
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "includesShadersStore",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "includesShadersStore", value);
            }
        }

        private IShaderProcessorCachedEntity __processor;
        public IShaderProcessorCachedEntity processor
        {
            get
            {
                if (__processor == null)
                {
                    __processor = EventHorizonBlazorInterop.GetClass<IShaderProcessorCachedEntity>(
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
            set
            {
                __processor = null;
                EventHorizonBlazorInterop.Set(this.___guid, "processor", value);
            }
        }

        public string version
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "version"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "version", value);
            }
        }

        public string platformName
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "platformName"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "platformName", value);
            }
        }

        public bool lookForClosingBracketForUniformBuffer
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "lookForClosingBracketForUniformBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lookForClosingBracketForUniformBuffer",
                    value
                );
            }
        }

        private ShaderProcessingContextCachedEntity __processingContext;
        public ShaderProcessingContextCachedEntity processingContext
        {
            get
            {
                if (__processingContext == null)
                {
                    __processingContext =
                        EventHorizonBlazorInterop.GetClass<ShaderProcessingContextCachedEntity>(
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
            set
            {
                __processingContext = null;
                EventHorizonBlazorInterop.Set(this.___guid, "processingContext", value);
            }
        }

        public bool isNDCHalfZRange
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isNDCHalfZRange"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isNDCHalfZRange", value);
            }
        }

        public bool useReverseDepthBuffer
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useReverseDepthBuffer");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useReverseDepthBuffer", value);
            }
        }

        public ActionResultCallback<
            ActionResultCallback<string, string, string[], string>
        > processCodeAfterIncludes
        {
            get
            {
                return EventHorizonBlazorInterop.Get<
                    ActionResultCallback<ActionResultCallback<string, string, string[], string>>
                >(this.___guid, "processCodeAfterIncludes");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "processCodeAfterIncludes", value);
            }
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
