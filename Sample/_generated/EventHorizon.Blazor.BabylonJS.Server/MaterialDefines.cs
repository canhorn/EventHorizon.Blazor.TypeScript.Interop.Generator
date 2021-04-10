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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MaterialDefines>))]
    public class MaterialDefines : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_isDirty()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isDirty"
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public MaterialDefines() : base() { } 

        public MaterialDefines(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public async ValueTask markAsProcessed()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsProcessed" }
                }
            );
        }

        public async ValueTask markAsUnprocessed()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsUnprocessed" }
                }
            );
        }

        public async ValueTask markAllAsDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAllAsDirty" }
                }
            );
        }

        public async ValueTask markAsImageProcessingDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsImageProcessingDirty" }
                }
            );
        }

        public async ValueTask markAsLightDirty(System.Nullable<bool> disposed = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsLightDirty" }, disposed
                }
            );
        }

        public async ValueTask markAsAttributesDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsAttributesDirty" }
                }
            );
        }

        public async ValueTask markAsTexturesDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsTexturesDirty" }
                }
            );
        }

        public async ValueTask markAsFresnelDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsFresnelDirty" }
                }
            );
        }

        public async ValueTask markAsMiscDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsMiscDirty" }
                }
            );
        }

        public async ValueTask markAsPrePassDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsPrePassDirty" }
                }
            );
        }

        public async ValueTask rebuild()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "rebuild" }
                }
            );
        }

        public async ValueTask<bool> isEqual(MaterialDefines other)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isEqual" }, other
                }
            );
        }

        public async ValueTask cloneTo(MaterialDefines other)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "cloneTo" }, other
                }
            );
        }

        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public async ValueTask<string> toString()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }
        #endregion
    }
}