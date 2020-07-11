/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IActionEvent { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IActionEventCachedEntity : CachedEntityObject, IActionEvent
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
        
        public CachedEntity source
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "source"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "source",
                    value
                );
            }
        }

        
        public decimal pointerX
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "pointerX"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "pointerX",
                    value
                );
            }
        }

        
        public decimal pointerY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "pointerY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "pointerY",
                    value
                );
            }
        }

        private AbstractMesh __meshUnderPointer;
        public AbstractMesh meshUnderPointer
        {
            get
            {
            if(__meshUnderPointer == null)
            {
                __meshUnderPointer = EventHorizonBlazorInteropt.GetClass<AbstractMesh>(
                    this.___guid,
                    "meshUnderPointer",
                    (entity) =>
                    {
                        return new AbstractMesh(entity);
                    }
                );
            }
            return __meshUnderPointer;
            }
            set
            {
__meshUnderPointer = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "meshUnderPointer",
                    value
                );
            }
        }

        
        public CachedEntity sourceEvent
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "sourceEvent"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sourceEvent",
                    value
                );
            }
        }

        
        public CachedEntity additionalData
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "additionalData"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "additionalData",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IActionEventCachedEntity() : base() { }

        public IActionEventCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}