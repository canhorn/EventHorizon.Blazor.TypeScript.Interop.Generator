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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AbstractActionManager>))]
    public class AbstractActionManager : CachedEntityObject, _IDisposable
    {
        #region Static Accessors
        
        public static async ValueTask<bool> get_HasTriggers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "AbstractActionManager.HasTriggers"
                );
        }

        
        public static async ValueTask<bool> get_HasPickTriggers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "AbstractActionManager.HasPickTriggers"
                );
        }
        #endregion

        #region Static Properties
        
        public static async ValueTask<CachedEntity> get_Triggers()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    "BABYLON",
                    "AbstractActionManager.Triggers",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public static ValueTask set_Triggers(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "AbstractActionManager.Triggers",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<bool> HasSpecificTrigger(decimal trigger)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "AbstractActionManager", "HasSpecificTrigger" }, trigger
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_hasPointerTriggers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasPointerTriggers"
                );
        }

        
        public async ValueTask<bool> get_hasPickTriggers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasPickTriggers"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<string> get_hoverCursor()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "hoverCursor"
                );
        }
        public ValueTask set_hoverCursor(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hoverCursor",
                    value
                );
        }

        
        public async ValueTask<IActionCachedEntity[]> get_actions()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<IActionCachedEntity>(
                    this.___guid,
                    "actions",
                    (entity) =>
                    {
                        return new IActionCachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_actions(IActionCachedEntity[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "actions",
                    value
                );
        }

        
        public async ValueTask<bool> get_isRecursive()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRecursive"
                );
        }
        public ValueTask set_isRecursive(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isRecursive",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public AbstractActionManager() : base() { }

        public AbstractActionManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public async ValueTask processTrigger(decimal trigger, IActionEvent evt = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "processTrigger" }, trigger, evt
                }
            );
        }

        public async ValueTask<bool> hasSpecificTriggers(decimal[] triggers)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasSpecificTriggers" }, triggers
                }
            );
        }

        public async ValueTask<bool> hasSpecificTriggers2(decimal triggerA, decimal triggerB)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasSpecificTriggers2" }, triggerA, triggerB
                }
            );
        }

        public async ValueTask<bool> hasSpecificTrigger(decimal trigger, ActionCallback<object> parameterPredicate = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasSpecificTrigger" }, trigger, parameterPredicate
                }
            );
        }

        public async ValueTask<CachedEntity> serialize(string name)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, name
                }
            );
        }

        public async ValueTask<IActionCachedEntity> registerAction(IAction action)
        {
            return await EventHorizonBlazorInterop.FuncClass<IActionCachedEntity>(
                entity => new IActionCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "registerAction" }, action
                }
            );
        }

        public async ValueTask<bool> unregisterAction(IAction action)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "unregisterAction" }, action
                }
            );
        }
        #endregion
    }
}