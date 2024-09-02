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

    [JsonConverter(typeof(CachedEntityConverter<Action>))]
    public class Action : CachedEntityObject, IAction
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

                EventHorizonBlazorInterop.Set(this.___guid, "triggerOptions", value);
            }
        }

        public decimal trigger
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "trigger"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "trigger", value);
            }
        }

        private Observable<Action> __onBeforeExecuteObservable;
        public Observable<Action> onBeforeExecuteObservable
        {
            get
            {
                if (__onBeforeExecuteObservable == null)
                {
                    __onBeforeExecuteObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Action>
                    >(
                        this.___guid,
                        "onBeforeExecuteObservable",
                        (entity) =>
                        {
                            return new Observable<Action>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onBeforeExecuteObservable;
            }
            set
            {
                __onBeforeExecuteObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onBeforeExecuteObservable", value);
            }
        }
        #endregion

        #region Constructor
        public Action()
            : base() { }

        public Action(ICachedEntity entity)
            : base(entity) { }

        public Action(object triggerOptions, Condition condition = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Action" },
                triggerOptions,
                condition
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public CachedEntity getTriggerParameter()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getTriggerParameter" } }
            );
        }

        public void setTriggerParameter(object value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setTriggerParameter" }, value }
            );
        }

        public void execute(ActionEvent evt = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "execute" }, evt }
            );
        }

        public void skipToNextActiveAction()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "skipToNextActiveAction" } }
            );
        }

        public Action then(Action action)
        {
            return EventHorizonBlazorInterop.FuncClass<Action>(
                entity => new Action() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "then" }, action }
            );
        }

        public CachedEntity serialize(object parent)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" }, parent }
            );
        }
        #endregion
    }
}
