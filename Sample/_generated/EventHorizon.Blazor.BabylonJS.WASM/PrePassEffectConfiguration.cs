/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface PrePassEffectConfiguration : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<PrePassEffectConfigurationCachedEntity>))]
public class PrePassEffectConfigurationCachedEntity : CachedEntityObject, PrePassEffectConfiguration
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

    public string name
    {
        get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
        set
        {

            EventHorizonBlazorInterop.Set(this.___guid, "name", value);
        }
    }

    private PostProcess __postProcess;
    public PostProcess postProcess
    {
        get
        {
            if (__postProcess == null)
            {
                __postProcess = EventHorizonBlazorInterop.GetClass<PostProcess>(
                    this.___guid,
                    "postProcess",
                    (entity) =>
                    {
                        return new PostProcess() { ___guid = entity.___guid };
                    }
                );
            }
            return __postProcess;
        }
        set
        {
            __postProcess = null;
            EventHorizonBlazorInterop.Set(this.___guid, "postProcess", value);
        }
    }

    public decimal[] texturesRequired
    {
        get
        {
            return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "texturesRequired");
        }
        set
        {

            EventHorizonBlazorInterop.Set(this.___guid, "texturesRequired", value);
        }
    }

    public bool enabled
    {
        get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "enabled"); }
        set
        {

            EventHorizonBlazorInterop.Set(this.___guid, "enabled", value);
        }
    }
    #endregion

    #region Constructor
    public PrePassEffectConfigurationCachedEntity()
        : base() { }

    public PrePassEffectConfigurationCachedEntity(ICachedEntity entity)
        : base(entity) { }

    #endregion

    #region Methods
    public void dispose()
    {
        EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "dispose" } }
        );
    }

    public PostProcess createPostProcess()
    {
        return EventHorizonBlazorInterop.FuncClass<PostProcess>(
            entity => new PostProcess() { ___guid = entity.___guid },
            new object[] { new string[] { this.___guid, "createPostProcess" } }
        );
    }
    #endregion
}
