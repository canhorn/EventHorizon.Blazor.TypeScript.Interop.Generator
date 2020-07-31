/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    public interface IInspectable : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IInspectableCachedEntity>))]
    public class IInspectableCachedEntity : CachedEntityObject, IInspectable
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
        
        public string label
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "label"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "label",
                    value
                );
            }
        }

        
        public string propertyName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "propertyName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "propertyName",
                    value
                );
            }
        }

        private InspectableType __type;
        public InspectableType type
        {
            get
            {
            if(__type == null)
            {
                __type = EventHorizonBlazorInterop.GetClass<InspectableType>(
                    this.___guid,
                    "type",
                    (entity) =>
                    {
                        return new InspectableType() { ___guid = entity.___guid };
                    }
                );
            }
            return __type;
            }
            set
            {
__type = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public decimal min
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "min"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "min",
                    value
                );
            }
        }

        
        public decimal max
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "max"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "max",
                    value
                );
            }
        }

        
        public decimal step
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "step"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "step",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IInspectableCachedEntity() : base() { }

        public IInspectableCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}