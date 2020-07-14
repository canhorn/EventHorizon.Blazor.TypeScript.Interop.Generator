/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IAction { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "trigger"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "triggerOptions"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getTriggerParameter" }
                }
            );
        }

        public CachedEntity serialize(object parent)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, parent
                }
            );
        }

        public IAction then(IAction action)
        {
            return EventHorizonBlazorInteropt.FuncClass<IAction>(
                entity => new IActionCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "then" }, action
                }
            );
        }
        #endregion
    }
}