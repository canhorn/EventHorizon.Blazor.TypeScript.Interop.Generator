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

    public interface IActionEvent : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IActionEventCachedEntity>))]
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
        
        public async ValueTask<CachedEntity> get_source()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "source",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_source(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "source",
                    value
                );
        }

        
        public async ValueTask<decimal> get_pointerX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pointerX"
                );
        }
        public ValueTask set_pointerX(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointerX",
                    value
                );
        }

        
        public async ValueTask<decimal> get_pointerY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pointerY"
                );
        }
        public ValueTask set_pointerY(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointerY",
                    value
                );
        }

        private AbstractMesh __meshUnderPointer;
        public async ValueTask<AbstractMesh> get_meshUnderPointer()
        {
            if(__meshUnderPointer == null)
            {
                __meshUnderPointer = await EventHorizonBlazorInterop.GetClass<AbstractMesh>(
                    this.___guid,
                    "meshUnderPointer",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __meshUnderPointer;
        }
        public ValueTask set_meshUnderPointer(AbstractMesh value)
        {
__meshUnderPointer = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "meshUnderPointer",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_sourceEvent()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "sourceEvent",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_sourceEvent(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sourceEvent",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_additionalData()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "additionalData",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_additionalData(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "additionalData",
                    value
                );
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