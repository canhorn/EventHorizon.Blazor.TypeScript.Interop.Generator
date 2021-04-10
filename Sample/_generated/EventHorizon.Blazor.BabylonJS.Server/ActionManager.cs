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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ActionManager>))]
    public class ActionManager : AbstractActionManager
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_NothingTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.NothingTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnPickTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPickTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnLeftPickTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnLeftPickTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnRightPickTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnRightPickTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnCenterPickTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnCenterPickTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnPickDownTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPickDownTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnDoublePickTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnDoublePickTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnPickUpTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPickUpTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnPickOutTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPickOutTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnLongPressTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnLongPressTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnPointerOverTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPointerOverTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnPointerOutTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPointerOutTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnEveryFrameTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnEveryFrameTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnIntersectionEnterTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnIntersectionEnterTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnIntersectionExitTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnIntersectionExitTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnKeyDownTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnKeyDownTrigger"
                );
        }

        
        public static async ValueTask<decimal> get_OnKeyUpTrigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnKeyUpTrigger"
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask Parse(object parsedActions, AbstractMesh @object, Scene scene)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "ActionManager", "Parse" }, parsedActions, @object, scene
                }
            );
        }

        public static async ValueTask<string> GetTriggerName(decimal trigger)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { "BABYLON", "ActionManager", "GetTriggerName" }, trigger
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

        #endregion
        
        #region Constructor
        public ActionManager() : base() { }

        public ActionManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<ActionManager> NewActionManager(
            Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ActionManager" },
                scene
            );

            return new ActionManager(entity);
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

        public async ValueTask<Scene> getScene()
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
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

        public async ValueTask processTrigger(decimal trigger, IActionEvent evt = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "processTrigger" }, trigger, evt
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
        #endregion
    }
}