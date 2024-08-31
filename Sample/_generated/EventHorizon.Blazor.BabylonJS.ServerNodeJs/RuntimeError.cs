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

        public async ValueTask<ErrorCodes> get_errorCode()
        {
            if (__errorCode == null)
            {
                __errorCode = await EventHorizonBlazorInterop.GetClass<ErrorCodes>(
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

        public ValueTask set_errorCode(ErrorCodes value)
        {
            __errorCode = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "errorCode", value);
        }

        private Error __innerError;

        public async ValueTask<Error> get_innerError()
        {
            if (__innerError == null)
            {
                __innerError = await EventHorizonBlazorInterop.GetClass<Error>(
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

        public ValueTask set_innerError(Error value)
        {
            __innerError = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "innerError", value);
        }
        #endregion

        #region Constructor
        public RuntimeError()
            : base() { }

        public RuntimeError(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<RuntimeError> NewRuntimeError(
            string message,
            ErrorCodes errorCode,
            Error innerError = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RuntimeError" },
                message,
                errorCode,
                innerError
            );

            return new RuntimeError(entity);
        }

        #endregion

        #region Methods

        #endregion
    }
}
