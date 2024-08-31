/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface ILoadingScreen : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<ILoadingScreenCachedEntity>))]
public class ILoadingScreenCachedEntity : CachedEntityObject, ILoadingScreen
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

    public string loadingUIBackgroundColor
    {
        get
        {
            return EventHorizonBlazorInterop.Get<string>(this.___guid, "loadingUIBackgroundColor");
        }
        set
        {

            EventHorizonBlazorInterop.Set(this.___guid, "loadingUIBackgroundColor", value);
        }
    }

    public string loadingUIText
    {
        get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "loadingUIText"); }
        set
        {

            EventHorizonBlazorInterop.Set(this.___guid, "loadingUIText", value);
        }
    }
    #endregion

    #region Constructor
    public ILoadingScreenCachedEntity()
        : base() { }

    public ILoadingScreenCachedEntity(ICachedEntity entity)
        : base(entity) { }

    #endregion

    #region Methods
    public void displayLoadingUI()
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "displayLoadingUI" } }
        );
    }

    public void hideLoadingUI()
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "hideLoadingUI" } }
        );
    }
    #endregion
}
