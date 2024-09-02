/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
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
            return EventHorizonBlazorInterop.Set(this.___guid, "triggerOptions", value);
        }

        public async ValueTask<decimal> get_trigger()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "trigger");
        }

        public ValueTask set_trigger(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "trigger", value);
        }

        private Observable<Action> __onBeforeExecuteObservable;

        public async ValueTask<Observable<Action>> get_onBeforeExecuteObservable()
        {
            if (__onBeforeExecuteObservable == null)
            {
                __onBeforeExecuteObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onBeforeExecuteObservable(Observable<Action> value)
        {
            __onBeforeExecuteObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onBeforeExecuteObservable", value);
        }
        #endregion

        #region Constructor
        public Action()
            : base() { }

        public Action(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<Action> NewAction(
            object triggerOptions,
            Condition condition = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Action" },
                triggerOptions,
                condition
            );

            return new Action(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<CachedEntity> getTriggerParameter()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getTriggerParameter" } }
            );
        }

        public async ValueTask setTriggerParameter(object value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setTriggerParameter" }, value }
            );
        }

        public async ValueTask execute(ActionEvent evt = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "execute" }, evt }
            );
        }

        public async ValueTask skipToNextActiveAction()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "skipToNextActiveAction" } }
            );
        }

        public async ValueTask<Action> then(Action action)
        {
            return await EventHorizonBlazorInterop.FuncClass<Action>(
                entity => new Action() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "then" }, action }
            );
        }

        public async ValueTask<CachedEntity> serialize(object parent)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" }, parent }
            );
        }
        #endregion
    }
}
