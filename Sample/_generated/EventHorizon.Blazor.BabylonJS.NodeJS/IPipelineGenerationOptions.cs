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

        public string shaderNameOrContent
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(this.___guid, "shaderNameOrContent");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shaderNameOrContent", value);
            }
        }

        public string key
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "key"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "key", value);
            }
        }

        public string[] defines
        {
            get { return EventHorizonBlazorInterop.GetArray<string>(this.___guid, "defines"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "defines", value);
            }
        }

        public bool addGlobalDefines
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "addGlobalDefines"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "addGlobalDefines", value);
            }
        }

        public int shaderLanguage
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "shaderLanguage"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shaderLanguage", value);
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

        private ProcessingOptionsCachedEntity __extendedProcessingOptions;
        public ProcessingOptionsCachedEntity extendedProcessingOptions
        {
            get
            {
                if (__extendedProcessingOptions == null)
                {
                    __extendedProcessingOptions =
                        EventHorizonBlazorInterop.GetClass<ProcessingOptionsCachedEntity>(
                            this.___guid,
                            "extendedProcessingOptions",
                            (entity) =>
                            {
                                return new ProcessingOptionsCachedEntity()
                                {
                                    ___guid = entity.___guid
                                };
                            }
                        );
                }
                return __extendedProcessingOptions;
            }
            set
            {
                __extendedProcessingOptions = null;
                EventHorizonBlazorInterop.Set(this.___guid, "extendedProcessingOptions", value);
            }
        }

        private ICreateAndPreparePipelineContextOptionsCachedEntity __extendedCreatePipelineOptions;
        public ICreateAndPreparePipelineContextOptionsCachedEntity extendedCreatePipelineOptions
        {
            get
            {
                if (__extendedCreatePipelineOptions == null)
                {
                    __extendedCreatePipelineOptions =
                        EventHorizonBlazorInterop.GetClass<ICreateAndPreparePipelineContextOptionsCachedEntity>(
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
            set
            {
                __extendedCreatePipelineOptions = null;
                EventHorizonBlazorInterop.Set(this.___guid, "extendedCreatePipelineOptions", value);
            }
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
