/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class ActionManager : AbstractActionManager
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal NothingTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.NothingTrigger"
                );
            }
        }

        
        public static decimal OnPickTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPickTrigger"
                );
            }
        }

        
        public static decimal OnLeftPickTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnLeftPickTrigger"
                );
            }
        }

        
        public static decimal OnRightPickTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnRightPickTrigger"
                );
            }
        }

        
        public static decimal OnCenterPickTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnCenterPickTrigger"
                );
            }
        }

        
        public static decimal OnPickDownTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPickDownTrigger"
                );
            }
        }

        
        public static decimal OnDoublePickTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnDoublePickTrigger"
                );
            }
        }

        
        public static decimal OnPickUpTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPickUpTrigger"
                );
            }
        }

        
        public static decimal OnPickOutTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPickOutTrigger"
                );
            }
        }

        
        public static decimal OnLongPressTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnLongPressTrigger"
                );
            }
        }

        
        public static decimal OnPointerOverTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPointerOverTrigger"
                );
            }
        }

        
        public static decimal OnPointerOutTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnPointerOutTrigger"
                );
            }
        }

        
        public static decimal OnEveryFrameTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnEveryFrameTrigger"
                );
            }
        }

        
        public static decimal OnIntersectionEnterTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnIntersectionEnterTrigger"
                );
            }
        }

        
        public static decimal OnIntersectionExitTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnIntersectionExitTrigger"
                );
            }
        }

        
        public static decimal OnKeyDownTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnKeyDownTrigger"
                );
            }
        }

        
        public static decimal OnKeyUpTrigger
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "ActionManager.OnKeyUpTrigger"
                );
            }
        }
        #endregion

        #region Static Methods
        public static void Parse(object parsedActions, AbstractMesh @object, Scene scene)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "ActionManager", "Parse" }, parsedActions, @object, scene
                }
            );
        }

        public static string GetTriggerName(decimal trigger)
        {
            return EventHorizonBlazorInteropt.Func<string>(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "hasPointerTriggers"
                );
            }
        }

        
        public bool hasPickTriggers
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
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
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "ActionManager" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        public bool hasSpecificTriggers(decimal[] triggers)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasSpecificTriggers" }, triggers
                }
            );
        }

        public bool hasSpecificTriggers2(decimal triggerA, decimal triggerB)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasSpecificTriggers2" }, triggerA, triggerB
                }
            );
        }

        #region hasSpecificTrigger TODO: Get Comments as metadata identification
        private bool _isHasSpecificTriggerEnabled = false;
        private readonly IDictionary<string, Func<Task>> _hasSpecificTriggerActionMap = new Dictionary<string, Func<Task>>();

        public string hasSpecificTrigger(
            Func<Task> callback
        )
        {
            SetupHasSpecificTriggerLoop();

            var handle = Guid.NewGuid().ToString();
            _hasSpecificTriggerActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupHasSpecificTriggerLoop()
        {
            if (_isHasSpecificTriggerEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "hasSpecificTrigger",
                "CallHasSpecificTriggerActions",
                _invokableReference
            );
            _isHasSpecificTriggerEnabled = true;
        }

        [JSInvokable]
        public async Task CallHasSpecificTriggerActions()
        {
            foreach (var action in _hasSpecificTriggerActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public IAction registerAction(IAction action)
        {
            return EventHorizonBlazorInteropt.FuncClass<IAction>(
                entity => new IActionCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "registerAction" }, action
                }
            );
        }

        public bool unregisterAction(IAction action)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "unregisterAction" }, action
                }
            );
        }

        public void processTrigger(decimal trigger, IActionEvent evt = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "processTrigger" }, trigger, evt
                }
            );
        }

        public CachedEntity serialize(string name)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, name
                }
            );
        }
        #endregion
    }
}