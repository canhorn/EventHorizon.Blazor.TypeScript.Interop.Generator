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

    public interface ICustomShaderOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ICustomShaderOptionsCachedEntity>))]
    public class ICustomShaderOptionsCachedEntity : CachedEntityObject, ICustomShaderOptions
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
        
        public async ValueTask<string> get_shaderName()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "shaderName"
                );
        }
        public ValueTask set_shaderName(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shaderName",
                    value
                );
        }

        
        public async ValueTask<string[]> get_attributes()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "attributes"
                );
        }
        public ValueTask set_attributes(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attributes",
                    value
                );
        }

        
        public async ValueTask<string[]> get_uniforms()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "uniforms"
                );
        }
        public ValueTask set_uniforms(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniforms",
                    value
                );
        }

        
        public async ValueTask<string[]> get_samplers()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "samplers"
                );
        }
        public ValueTask set_samplers(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "samplers",
                    value
                );
        }

        
        public async ValueTask<string[]> get_defines()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "defines"
                );
        }
        public ValueTask set_defines(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defines",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ICustomShaderOptionsCachedEntity() : base() { }

        public ICustomShaderOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}