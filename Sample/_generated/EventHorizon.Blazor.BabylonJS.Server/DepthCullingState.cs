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

    
    
    [JsonConverter(typeof(CachedEntityConverter<DepthCullingState>))]
    public class DepthCullingState : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_isDirty()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isDirty"
                );
        }

        
        public async ValueTask<decimal> get_zOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zOffset"
                );
        }
        public ValueTask set_zOffset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "zOffset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cullFace()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cullFace"
                );
        }
        public ValueTask set_cullFace(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cullFace",
                    value
                );
        }

        
        public async ValueTask<bool> get_cull()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cull"
                );
        }
        public ValueTask set_cull(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cull",
                    value
                );
        }

        
        public async ValueTask<decimal> get_depthFunc()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depthFunc"
                );
        }
        public ValueTask set_depthFunc(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depthFunc",
                    value
                );
        }

        
        public async ValueTask<bool> get_depthMask()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "depthMask"
                );
        }
        public ValueTask set_depthMask(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depthMask",
                    value
                );
        }

        
        public async ValueTask<bool> get_depthTest()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "depthTest"
                );
        }
        public ValueTask set_depthTest(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "depthTest",
                    value
                );
        }

        
        public async ValueTask<decimal> get_frontFace()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "frontFace"
                );
        }
        public ValueTask set_frontFace(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "frontFace",
                    value
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public DepthCullingState() : base() { } 

        public DepthCullingState(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public async ValueTask apply(WebGLRenderingContext gl)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "apply" }, gl
                }
            );
        }
        #endregion
    }
}