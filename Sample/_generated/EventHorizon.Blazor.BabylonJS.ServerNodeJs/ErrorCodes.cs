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

    [JsonConverter(typeof(CachedEntityConverter<ErrorCodes>))]
    public class ErrorCodes : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<CachedEntity> get_MeshInvalidPositionsError()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                "BABYLON",
                "ErrorCodes.MeshInvalidPositionsError",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public static async ValueTask<CachedEntity> get_UnsupportedTextureError()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                "BABYLON",
                "ErrorCodes.UnsupportedTextureError",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public static async ValueTask<CachedEntity> get_GLTFLoaderUnexpectedMagicError()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                "BABYLON",
                "ErrorCodes.GLTFLoaderUnexpectedMagicError",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public static async ValueTask<CachedEntity> get_SceneLoaderError()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                "BABYLON",
                "ErrorCodes.SceneLoaderError",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public static async ValueTask<CachedEntity> get_LoadFileError()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                "BABYLON",
                "ErrorCodes.LoadFileError",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public static async ValueTask<CachedEntity> get_RequestFileError()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                "BABYLON",
                "ErrorCodes.RequestFileError",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public static async ValueTask<CachedEntity> get_ReadFileError()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                "BABYLON",
                "ErrorCodes.ReadFileError",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion

        #region Constructor
        public ErrorCodes()
            : base() { }

        public ErrorCodes(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods

        #endregion
    }
}
