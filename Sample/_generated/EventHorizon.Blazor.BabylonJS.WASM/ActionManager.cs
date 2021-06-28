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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ActionManager>))]
    public class ActionManager : AbstractActionManager
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal NothingTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.NothingTrigger"
                );
            }
        }

        
        public static decimal OnPickTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPickTrigger"
                );
            }
        }

        
        public static decimal OnLeftPickTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnLeftPickTrigger"
                );
            }
        }

        
        public static decimal OnRightPickTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnRightPickTrigger"
                );
            }
        }

        
        public static decimal OnCenterPickTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnCenterPickTrigger"
                );
            }
        }

        
        public static decimal OnPickDownTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPickDownTrigger"
                );
            }
        }

        
        public static decimal OnDoublePickTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnDoublePickTrigger"
                );
            }
        }

        
        public static decimal OnPickUpTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPickUpTrigger"
                );
            }
        }

        
        public static decimal OnPickOutTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPickOutTrigger"
                );
            }
        }

        
        public static decimal OnLongPressTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnLongPressTrigger"
                );
            }
        }

        
        public static decimal OnPointerOverTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPointerOverTrigger"
                );
            }
        }

        
        public static decimal OnPointerOutTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPointerOutTrigger"
                );
            }
        }

        
        public static decimal OnEveryFrameTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnEveryFrameTrigger"
                );
            }
        }

        
        public static decimal OnIntersectionEnterTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnIntersectionEnterTrigger"
                );
            }
        }

        
        public static decimal OnIntersectionExitTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnIntersectionExitTrigger"
                );
            }
        }

        
        public static decimal OnKeyDownTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnKeyDownTrigger"
                );
            }
        }

        
        public static decimal OnKeyUpTrigger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnKeyUpTrigger"
                );
            }
        }
        #endregion

        #region Static Methods
        public static void Parse(object parsedActions, AbstractMesh @object, Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "ActionManager", "Parse" }, parsedActions, @object, scene
                }
            );
        }

        public static string GetTriggerName(decimal trigger)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "BABYLON", "ActionManager", "GetTriggerName" }, trigger
                }
            );
        }
        #endregion

        #region Accessors
        
        public bool hasPointerTriggers
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasPointerTriggers"
                );
            }
        }

        
        public bool hasPickTriggers
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasPickTriggers"
                );
            }
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

        public ActionManager(
            Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ActionManager" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        public bool hasSpecificTriggers(decimal[] triggers)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasSpecificTriggers" }, triggers
                }
            );
        }

        public bool hasSpecificTriggers2(decimal triggerA, decimal triggerB)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasSpecificTriggers2" }, triggerA, triggerB
                }
            );
        }

        public bool hasSpecificTrigger(decimal trigger, ActionResultCallback<object, bool> parameterPredicate = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasSpecificTrigger" }, trigger, parameterPredicate
                }
            );
        }

        public IActionCachedEntity registerAction(IAction action)
        {
            return EventHorizonBlazorInterop.FuncClass<IActionCachedEntity>(
                entity => new IActionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "registerAction" }, action
                }
            );
        }

        public bool unregisterAction(IAction action)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "unregisterAction" }, action
                }
            );
        }

        public void processTrigger(decimal trigger, IActionEvent evt = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "processTrigger" }, trigger, evt
                }
            );
        }

        public CachedEntity serialize(string name)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }, name
                }
            );
        }
        #endregion
    }
}