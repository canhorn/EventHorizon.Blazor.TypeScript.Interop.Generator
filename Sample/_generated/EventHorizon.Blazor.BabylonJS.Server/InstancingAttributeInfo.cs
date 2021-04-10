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

    public interface InstancingAttributeInfo : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<InstancingAttributeInfoCachedEntity>))]
    public class InstancingAttributeInfoCachedEntity : CachedEntityObject, InstancingAttributeInfo
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
        
        public async ValueTask<string> get_attributeName()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "attributeName"
                );
        }
        public ValueTask set_attributeName(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attributeName",
                    value
                );
        }

        
        public async ValueTask<decimal> get_index()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "index"
                );
        }
        public ValueTask set_index(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "index",
                    value
                );
        }

        
        public async ValueTask<decimal> get_attributeSize()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "attributeSize"
                );
        }
        public ValueTask set_attributeSize(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attributeSize",
                    value
                );
        }

        
        public async ValueTask<decimal> get_offset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "offset"
                );
        }
        public ValueTask set_offset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_divisor()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "divisor"
                );
        }
        public ValueTask set_divisor(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "divisor",
                    value
                );
        }

        
        public async ValueTask<decimal> get_attributeType()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "attributeType"
                );
        }
        public ValueTask set_attributeType(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attributeType",
                    value
                );
        }

        
        public async ValueTask<bool> get_normalized()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "normalized"
                );
        }
        public ValueTask set_normalized(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normalized",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public InstancingAttributeInfoCachedEntity() : base() { }

        public InstancingAttributeInfoCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}