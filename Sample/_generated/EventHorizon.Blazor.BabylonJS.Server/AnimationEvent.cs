/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<AnimationEvent>))]
public class AnimationEvent : CachedEntityObject
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

    public async ValueTask<decimal> get_frame()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "frame");
    }

    public ValueTask set_frame(decimal value)
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "frame", value);
    }

    public async ValueTask<bool> get_onlyOnce()
    {
        return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "onlyOnce");
    }

    public ValueTask set_onlyOnce(bool value)
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "onlyOnce", value);
    }

    public async ValueTask<bool> get_isDone()
    {
        return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDone");
    }

    public ValueTask set_isDone(bool value)
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "isDone", value);
    }
    #endregion

    #region Constructor
    public AnimationEvent()
        : base() { }

    public AnimationEvent(ICachedEntity entity)
        : base(entity)
    {
        ___guid = entity.___guid;
    }

    public static async ValueTask<AnimationEvent> NewAnimationEvent(
        decimal frame,
        ActionCallback<decimal> action,
        System.Nullable<bool> onlyOnce = null
    )
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "AnimationEvent" },
            frame,
            action,
            onlyOnce
        );

        return new AnimationEvent(entity);
    }
    #endregion

    #region Methods
    public async ValueTask action(decimal currentFrame)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "action" }, currentFrame }
        );
    }
    #endregion
}
