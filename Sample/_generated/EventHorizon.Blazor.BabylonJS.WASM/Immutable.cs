/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<Immutable<CachedEntity>>))]
public class Immutable<T> : CachedEntityObject
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
    public Immutable()
        : base() { }

    public Immutable(ICachedEntity entity)
        : base(entity)
    {
        ___guid = entity.___guid;
    }

    #endregion

    #region Methods

    #endregion
}
