/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface ICameraInput<TCamera> : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<ICameraInputCachedEntity<CachedEntity>>))]
public class ICameraInputCachedEntity<TCamera> : CachedEntityObject, ICameraInput<TCamera>
    where TCamera : CachedEntity, new()
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
    private TCamera __camera;

    public async ValueTask<TCamera> get_camera()
    {
        if (__camera == null)
        {
            __camera = await EventHorizonBlazorInterop.GetClass<TCamera>(
                this.___guid,
                "camera",
                (entity) =>
                {
                    return new TCamera() { ___guid = entity.___guid };
                }
            );
        }
        return __camera;
    }

    public ValueTask set_camera(TCamera value)
    {
        __camera = null;
        return EventHorizonBlazorInterop.Set(this.___guid, "camera", value);
    }
    #endregion

    #region Constructor
    public ICameraInputCachedEntity()
        : base() { }

    public ICameraInputCachedEntity(ICachedEntity entity)
        : base(entity) { }

    #endregion

    #region Methods
    public async ValueTask<string> getClassName()
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { this.___guid, "getClassName" } }
        );
    }

    public async ValueTask<string> getSimpleName()
    {
        return await EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { this.___guid, "getSimpleName" } }
        );
    }

    public async ValueTask attachControl(System.Nullable<bool> noPreventDefault = null)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "attachControl" }, noPreventDefault }
        );
    }

    public async ValueTask detachControl()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "detachControl" } }
        );
    }

    public async ValueTask checkInputs()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "checkInputs" } }
        );
    }
    #endregion
}
