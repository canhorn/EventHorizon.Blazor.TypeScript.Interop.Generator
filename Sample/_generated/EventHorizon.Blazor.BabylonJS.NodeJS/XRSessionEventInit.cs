/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRSessionEventInit : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRSessionEventInitCachedEntity>))]
public class XRSessionEventInitCachedEntity : CachedEntityObject, XRSessionEventInit
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
    private XRSession __session;
    public XRSession session
    {
        get
        {
            if (__session == null)
            {
                __session = EventHorizonBlazorInterop.GetClass<XRSession>(
                    this.___guid,
                    "session",
                    (entity) =>
                    {
                        return new XRSession() { ___guid = entity.___guid };
                    }
                );
            }
            return __session;
        }
        set
        {
            __session = null;
            EventHorizonBlazorInterop.Set(this.___guid, "session", value);
        }
    }
    #endregion

    #region Constructor
    public XRSessionEventInitCachedEntity()
        : base() { }

    public XRSessionEventInitCachedEntity(ICachedEntity entity)
        : base(entity) { }

    #endregion

    #region Methods

    #endregion
}
