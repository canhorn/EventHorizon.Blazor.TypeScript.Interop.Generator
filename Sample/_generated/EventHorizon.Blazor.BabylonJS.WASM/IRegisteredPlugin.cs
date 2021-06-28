/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface IRegisteredPlugin : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IRegisteredPluginCachedEntity>))]
    public class IRegisteredPluginCachedEntity : CachedEntityObject, IRegisteredPlugin
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
        private ISceneLoaderPluginCachedEntity __plugin;
        public ISceneLoaderPluginCachedEntity plugin
        {
            get
            {
            if(__plugin == null)
            {
                __plugin = EventHorizonBlazorInterop.GetClass<ISceneLoaderPluginCachedEntity>(
                    this.___guid,
                    "plugin",
                    (entity) =>
                    {
                        return new ISceneLoaderPluginCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __plugin;
            }
            set
            {
__plugin = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "plugin",
                    value
                );
            }
        }

        
        public bool isBinary
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBinary"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isBinary",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IRegisteredPluginCachedEntity() : base() { }

        public IRegisteredPluginCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}