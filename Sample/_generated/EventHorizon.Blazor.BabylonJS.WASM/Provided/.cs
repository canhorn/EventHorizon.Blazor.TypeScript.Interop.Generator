using System.Collections.Generic;
using EventHorizon.Blazor.Interop;
using Microsoft.JSInterop;

public class CachedEntityObject : CachedEntity
{
    protected static readonly IDictionary<string, ICachedEntity> CachedEntityMap = new Dictionary<string, ICachedEntity>();
    protected readonly DotNetObjectReference<CachedEntityObject> _invokableReference;
    protected IDictionary<string, ICachedEntity> _cachedEntityMap = new Dictionary<string, ICachedEntity>();

    public CachedEntityObject()
    {
        _invokableReference = DotNetObjectReference.Create(
            this
        );
    }
    public CachedEntityObject(
        ICachedEntity entity
    )
    {
        ___guid = entity.___guid;
        _invokableReference = DotNetObjectReference.Create(
            this
        );
    }
}