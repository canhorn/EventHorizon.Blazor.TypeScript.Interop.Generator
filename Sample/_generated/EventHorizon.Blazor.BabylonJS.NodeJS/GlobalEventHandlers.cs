/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface GlobalEventHandlers : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<GlobalEventHandlersCachedEntity>))]
public class GlobalEventHandlersCachedEntity : CachedEntityObject, GlobalEventHandlers
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

    #endregion

    #region Constructor
    public GlobalEventHandlersCachedEntity()
        : base() { }

    public GlobalEventHandlersCachedEntity(ICachedEntity entity)
        : base(entity) { }

    #endregion

    #region Methods
    #region onbeforexrselect TODO: Get Comments as metadata identification
    private bool _isOnbeforexrselectEnabled = false;
    private readonly IDictionary<string, Func<Task>> _onbeforexrselectActionMap =
        new Dictionary<string, Func<Task>>();

    public string onbeforexrselect(Func<Task> callback)
    {
        SetupOnbeforexrselectLoop();

        var handle = Guid.NewGuid().ToString();
        _onbeforexrselectActionMap.Add(handle, callback);

        return handle;
    }

    public bool onbeforexrselect_Remove(string handle)
    {
        return _onbeforexrselectActionMap.Remove(handle);
    }

    private void SetupOnbeforexrselectLoop()
    {
        if (_isOnbeforexrselectEnabled)
        {
            return;
        }
        EventHorizonBlazorInterop.FuncCallback(
            this,
            "onbeforexrselect",
            "CallOnbeforexrselectActions",
            _invokableReference
        );
        _isOnbeforexrselectEnabled = true;
    }

    [JSInvokable]
    public async Task CallOnbeforexrselectActions()
    {
        foreach (var action in _onbeforexrselectActionMap.Values)
        {
            await action();
        }
    }
    #endregion
    #endregion
}
