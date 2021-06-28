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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AbstractActionManager>))]
    public class AbstractActionManager : CachedEntityObject, _IDisposable
    {
        #region Static Accessors
        
        public static bool HasTriggers
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "AbstractActionManager.HasTriggers"
                );
            }
        }

        
        public static bool HasPickTriggers
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    "BABYLON",
                    "AbstractActionManager.Triggers",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "AbstractActionManager.Triggers",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static bool HasSpecificTrigger(decimal trigger)
        {
            return EventHorizonBlazorInterop.Func<bool>(
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
        
        public string hoverCursor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "hoverCursor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hoverCursor",
                    value
                );
            }
        }

        
        public IActionCachedEntity[] actions
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IActionCachedEntity>(
                    this.___guid,
                    "actions",
                    (entity) =>
                    {
                        return new IActionCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRecursive"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
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

        public CachedEntity serialize(string name)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }, name
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
        #endregion
    }
}