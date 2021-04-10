/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<ReadFileError>))]
    public class ReadFileError : BaseError
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
        private File __file;
        public async ValueTask<File> get_file()
        {
            if(__file == null)
            {
                __file = await EventHorizonBlazorInterop.GetClass<File>(
                    this.___guid,
                    "file",
                    (entity) =>
                    {
                        return new File() { ___guid = entity.___guid };
                    }
                );
            }
            return __file;
        }
        public ValueTask set_file(File value)
        {
__file = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "file",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ReadFileError() : base() { }

        public ReadFileError(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<ReadFileError> NewReadFileError(
            string message, File file
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ReadFileError" },
                message, file
            );

            return new ReadFileError(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}