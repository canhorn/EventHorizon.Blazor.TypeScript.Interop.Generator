/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<TouchCamera>))]
public class TouchCamera : FreeCamera
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    public decimal touchAngularSensibility
    {
        get
        {
            return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "touchAngularSensibility");
        }
        set
        {

            EventHorizonBlazorInterop.Set(this.___guid, "touchAngularSensibility", value);
        }
    }

    public decimal touchMoveSensibility
    {
        get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "touchMoveSensibility"); }
        set
        {

            EventHorizonBlazorInterop.Set(this.___guid, "touchMoveSensibility", value);
        }
    }
    #endregion

    #region Properties

    #endregion

    #region Constructor
    public TouchCamera()
        : base() { }

    public TouchCamera(ICachedEntity entity)
        : base(entity) { }

    public TouchCamera(string name, Vector3 position, Scene scene)
        : base()
    {
        var entity = EventHorizonBlazorInterop.New(
            new string[] { "TouchCamera" },
            name,
            position,
            scene
        );
        ___guid = entity.___guid;
    }

    public TouchCamera(
        string name,
        Vector3 position,
        Scene scene,
        System.Nullable<bool> setActiveOnSceneIfNoneActive = null
    )
        : base()
    {
        var entity = EventHorizonBlazorInterop.New(
            new string[] { "TouchCamera" },
            name,
            position,
            scene,
            setActiveOnSceneIfNoneActive
        );
        ___guid = entity.___guid;
    }

    public TouchCamera(string name, Scene scene = null)
        : base()
    {
        var entity = EventHorizonBlazorInterop.New(new string[] { "TouchCamera" }, name, scene);
        ___guid = entity.___guid;
    }
    #endregion

    #region Methods
    public string getClassName()
    {
        return EventHorizonBlazorInterop.Func<string>(
            new object[] { new string[] { this.___guid, "getClassName" } }
        );
    }
    #endregion
}
