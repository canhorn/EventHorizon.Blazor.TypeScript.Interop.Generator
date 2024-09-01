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

    [JsonConverter(typeof(CachedEntityConverter<Observer<CachedEntity>>))]
    public class Observer<T> : CachedEntityObject
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

        public async ValueTask<decimal> get_mask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "mask");
        }

        public ValueTask set_mask(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "mask", value);
        }

        public async ValueTask<CachedEntity> get_scope()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "scope",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_scope(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "scope", value);
        }

        public async ValueTask<bool> get_unregisterOnNextCall()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "unregisterOnNextCall");
        }

        public ValueTask set_unregisterOnNextCall(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "unregisterOnNextCall", value);
        }
        #endregion

        #region Constructor
        public Observer()
            : base() { }

        public Observer(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<Observer<T>> NewObserver(
            ActionCallback<T, EventState> callback,
            decimal mask,
            object scope = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Observer" },
                callback,
                mask,
                scope
            );

            return new Observer<T>(entity);
        }
        #endregion

        #region Methods
        public async ValueTask callback(T eventData, EventState eventState)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "callback" }, eventData, eventState }
            );
        }

        public async ValueTask remove()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "remove" } }
            );
        }
        #endregion
    }
}
