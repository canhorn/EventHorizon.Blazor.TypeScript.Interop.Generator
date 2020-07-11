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
    public class AbstractActionManager : CachedEntityObject, IDisposable
    {
        #region Static Accessors
        
        public static bool HasTriggers
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "AbstractActionManager.HasTriggers"
                );
            }
        }

        
        public static bool HasPickTriggers
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "AbstractActionManager.HasPickTriggers"
                );
            }
        }
        #endregion

        #region Static Properties
        
        public static CachedEntity Triggers
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    "BABYLON",
                    ".AbstractActionManager.Triggers"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".AbstractActionManager.Triggers",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static bool HasSpecificTrigger(decimal trigger)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "AbstractActionManager", "HasSpecificTrigger" }, trigger
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
        
        public string hoverCursor
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "hoverCursor"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "hoverCursor",
                    value
                );
            }
        }

        
        public IAction[] actions
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<IAction>(
                    this.___guid,
                    "actions",
                    (entity) =>
                    {
                        return new IActionCachedEntity(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "actions",
                    value
                );
            }
        }

        
        public bool isRecursive
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isRecursive"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isRecursive",
                    value
                );
            }
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
        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
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

        public CachedEntity serialize(string name)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, name
                }
            );
        }

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
        #endregion
    }
}