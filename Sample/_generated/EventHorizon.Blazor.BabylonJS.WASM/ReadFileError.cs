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
        public File file
        {
            get
            {
            if(__file == null)
            {
                __file = EventHorizonBlazorInterop.GetClass<File>(
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
            set
            {
__file = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "file",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ReadFileError() : base() { }

        public ReadFileError(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ReadFileError(
            string message, File file
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ReadFileError" },
                message, file
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}