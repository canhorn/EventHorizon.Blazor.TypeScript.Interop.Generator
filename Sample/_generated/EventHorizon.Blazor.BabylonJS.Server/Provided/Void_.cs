using System.Collections.Generic;
using EventHorizon.Blazor.Server.Interop;
using Microsoft.JSInterop;

public class Void_ : CachedEntityObject
{
    public Void_()
        : base() { }

    public Void_(ICachedEntity entity)
        : base(entity) { }
}
