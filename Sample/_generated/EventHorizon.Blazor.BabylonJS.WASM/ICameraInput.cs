/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
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
    public TCamera camera
    {
        get
        {
            if (__camera == null)
            {
                __camera = EventHorizonBlazorInterop.GetClass<TCamera>(
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
        set
        {
            __camera = null;
            EventHorizonBlazorInterop.Set(this.___guid, "camera", value);
        }
    }
    #endregion

    #region Constructor
    public ICameraInputCachedEntity()
        : base() { }

    public ICameraInputCachedEntity(ICachedEntity entity)
        : base(entity) { }

    #endregion

    #region Methods
    public string getClassName()
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { this.___guid, "getClassName" } }
        );
    }

    public string getSimpleName()
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { this.___guid, "getSimpleName" } }
        );
    }

    public void attachControl(System.Nullable<bool> noPreventDefault = null)
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "attachControl" }, noPreventDefault }
        );
    }

    public void detachControl()
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "detachControl" } }
        );
    }

    public void checkInputs()
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "checkInputs" } }
        );
    }
    #endregion
}
