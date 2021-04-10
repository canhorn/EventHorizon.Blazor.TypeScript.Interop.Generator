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

    public interface IAction : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IActionCachedEntity>))]
    public class IActionCachedEntity : CachedEntityObject, IAction
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
        
        public async ValueTask<decimal> get_trigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "trigger"
                );
        }
        public ValueTask set_trigger(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "trigger",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_triggerOptions()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "triggerOptions",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_triggerOptions(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "triggerOptions",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IActionCachedEntity() : base() { }

        public IActionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask<CachedEntity> getTriggerParameter()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getTriggerParameter" }
                }
            );
        }

        public async ValueTask<CachedEntity> serialize(object parent)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, parent
                }
            );
        }

        public async ValueTask<IActionCachedEntity> then(IAction action)
        {
            return await EventHorizonBlazorInterop.FuncClass<IActionCachedEntity>(
                entity => new IActionCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "then" }, action
                }
            );
        }
        #endregion
    }
}