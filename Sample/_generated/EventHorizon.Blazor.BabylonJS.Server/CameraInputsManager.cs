/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<CameraInputsManager<CachedEntity>>))]
public class CameraInputsManager<TCamera> : CachedEntityObject
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
    private CameraInputsMapCachedEntity<TCamera> __attached;

    public async ValueTask<CameraInputsMapCachedEntity<TCamera>> get_attached()
    {
        if (__attached == null)
        {
            __attached = await EventHorizonBlazorInterop.GetClass<
                CameraInputsMapCachedEntity<TCamera>
            >(
                this.___guid,
                "attached",
                (entity) =>
                {
                    return new CameraInputsMapCachedEntity<TCamera>() { ___guid = entity.___guid };
                }
            );
        }
        return __attached;
    }

    public ValueTask set_attached(CameraInputsMapCachedEntity<TCamera> value)
    {
        __attached = null;
        return EventHorizonBlazorInterop.Set(this.___guid, "attached", value);
    }

    public async ValueTask<bool> get_attachedToElement()
    {
        return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "attachedToElement");
    }

    public ValueTask set_attachedToElement(bool value)
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "attachedToElement", value);
    }

    public async ValueTask<bool> get_noPreventDefault()
    {
        return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "noPreventDefault");
    }

    public ValueTask set_noPreventDefault(bool value)
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "noPreventDefault", value);
    }

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
    public CameraInputsManager()
        : base() { }

    public CameraInputsManager(ICachedEntity entity)
        : base(entity)
    {
        ___guid = entity.___guid;
    }

    public static async ValueTask<CameraInputsManager<TCamera>> NewCameraInputsManager(
        TCamera camera
    )
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "CameraInputsManager" },
            camera
        );

        return new CameraInputsManager<TCamera>(entity);
    }
    #endregion

    #region Methods
    public async ValueTask checkInputs()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "checkInputs" } }
        );
    }

    public async ValueTask add(ICameraInput<TCamera> input)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "add" }, input }
        );
    }

    public async ValueTask remove(ICameraInput<TCamera> inputToRemove)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "remove" }, inputToRemove }
        );
    }

    public async ValueTask removeByType(string inputType)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "removeByType" }, inputType }
        );
    }

    public async ValueTask attachInput(ICameraInput<TCamera> input)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "attachInput" }, input }
        );
    }

    public async ValueTask attachElement(System.Nullable<bool> noPreventDefault = null)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "attachElement" }, noPreventDefault }
        );
    }

    public async ValueTask detachElement(System.Nullable<bool> disconnect = null)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "detachElement" }, disconnect }
        );
    }

    public async ValueTask rebuildInputCheck()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "rebuildInputCheck" } }
        );
    }

    public async ValueTask clear()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "clear" } }
        );
    }

    public async ValueTask serialize(object serializedCamera)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "serialize" }, serializedCamera }
        );
    }

    public async ValueTask parse(object parsedCamera)
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "parse" }, parsedCamera }
        );
    }
    #endregion
}
