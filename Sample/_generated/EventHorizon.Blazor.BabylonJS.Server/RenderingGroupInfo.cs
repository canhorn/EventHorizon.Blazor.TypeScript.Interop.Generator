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

    
    
    [JsonConverter(typeof(CachedEntityConverter<RenderingGroupInfo>))]
    public class RenderingGroupInfo : CachedEntityObject
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
        private Scene __scene;
        public async ValueTask<Scene> get_scene()
        {
            if(__scene == null)
            {
                __scene = await EventHorizonBlazorInterop.GetClass<Scene>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __scene;
        }
        public ValueTask set_scene(Scene value)
        {
__scene = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
                    value
                );
        }

        private Camera __camera;
        public async ValueTask<Camera> get_camera()
        {
            if(__camera == null)
            {
                __camera = await EventHorizonBlazorInterop.GetClass<Camera>(
                    this.___guid,
                    "camera",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            return __camera;
        }
        public ValueTask set_camera(Camera value)
        {
__camera = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "camera",
                    value
                );
        }

        
        public async ValueTask<decimal> get_renderingGroupId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderingGroupId"
                );
        }
        public ValueTask set_renderingGroupId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderingGroupId",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public RenderingGroupInfo() : base() { } 

        public RenderingGroupInfo(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}