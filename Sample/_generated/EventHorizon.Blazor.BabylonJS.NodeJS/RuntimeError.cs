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

    [JsonConverter(typeof(CachedEntityConverter<RuntimeError>))]
    public class RuntimeError : BaseError
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
        private ErrorCodes __errorCode;
        public ErrorCodes errorCode
        {
            get
            {
                if (__errorCode == null)
                {
                    __errorCode = EventHorizonBlazorInterop.GetClass<ErrorCodes>(
                        this.___guid,
                        "errorCode",
                        (entity) =>
                        {
                            return new ErrorCodes() { ___guid = entity.___guid };
                        }
                    );
                }
                return __errorCode;
            }
            set
            {
                __errorCode = null;
                EventHorizonBlazorInterop.Set(this.___guid, "errorCode", value);
            }
        }

        private Error __innerError;
        public Error innerError
        {
            get
            {
                if (__innerError == null)
                {
                    __innerError = EventHorizonBlazorInterop.GetClass<Error>(
                        this.___guid,
                        "innerError",
                        (entity) =>
                        {
                            return new Error() { ___guid = entity.___guid };
                        }
                    );
                }
                return __innerError;
            }
            set
            {
                __innerError = null;
                EventHorizonBlazorInterop.Set(this.___guid, "innerError", value);
            }
        }
        #endregion

        #region Constructor
        public RuntimeError()
            : base() { }

        public RuntimeError(ICachedEntity entity)
            : base(entity) { }

        public RuntimeError(string message, ErrorCodes errorCode, Error innerError = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RuntimeError" },
                message,
                errorCode,
                innerError
            );
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods

        #endregion
    }
}
