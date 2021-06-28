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
        
        public decimal trigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "trigger"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "trigger",
                    value
                );
            }
        }

        
        public CachedEntity triggerOptions
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "triggerOptions",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "triggerOptions",
                    value
                );
            }
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
        public CachedEntity getTriggerParameter()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getTriggerParameter" }
                }
            );
        }

        public CachedEntity serialize(object parent)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }, parent
                }
            );
        }

        public IActionCachedEntity then(IAction action)
        {
            return EventHorizonBlazorInterop.FuncClass<IActionCachedEntity>(
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