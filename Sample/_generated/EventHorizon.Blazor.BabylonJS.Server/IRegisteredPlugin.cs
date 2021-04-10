/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
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
        public async ValueTask<ISceneLoaderPluginCachedEntity> get_plugin()
        {
            if(__plugin == null)
            {
                __plugin = await EventHorizonBlazorInterop.GetClass<ISceneLoaderPluginCachedEntity>(
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
        public ValueTask set_plugin(ISceneLoaderPluginCachedEntity value)
        {
__plugin = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "plugin",
                    value
                );
        }

        
        public async ValueTask<bool> get_isBinary()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBinary"
                );
        }
        public ValueTask set_isBinary(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isBinary",
                    value
                );
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