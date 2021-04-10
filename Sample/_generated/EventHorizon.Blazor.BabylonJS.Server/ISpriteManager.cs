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

    public interface ISpriteManager : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ISpriteManagerCachedEntity>))]
    public class ISpriteManagerCachedEntity : CachedEntityObject, ISpriteManager
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
        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        
        public async ValueTask<decimal> get_layerMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
        }
        public ValueTask set_layerMask(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "layerMask",
                    value
                );
        }

        
        public async ValueTask<bool> get_isPickable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPickable"
                );
        }
        public ValueTask set_isPickable(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPickable",
                    value
                );
        }

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

        
        public async ValueTask<Sprite[]> get_sprites()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Sprite>(
                    this.___guid,
                    "sprites",
                    (entity) =>
                    {
                        return new Sprite() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_sprites(Sprite[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sprites",
                    value
                );
        }

        private Texture __texture;
        public async ValueTask<Texture> get_texture()
        {
            if(__texture == null)
            {
                __texture = await EventHorizonBlazorInterop.GetClass<Texture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new Texture() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
        }
        public ValueTask set_texture(Texture value)
        {
__texture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cellWidth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellWidth"
                );
        }
        public ValueTask set_cellWidth(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellWidth",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cellHeight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellHeight"
                );
        }
        public ValueTask set_cellHeight(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellHeight",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ISpriteManagerCachedEntity() : base() { }

        public ISpriteManagerCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask<PickingInfo> intersects(Ray ray, Camera camera, ActionCallback<Sprite> predicate = null, System.Nullable<bool> fastCheck = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "intersects" }, ray, camera, predicate, fastCheck
                }
            );
        }

        public async ValueTask<PickingInfo[]> multiIntersects(Ray ray, Camera camera, ActionCallback<Sprite> predicate = null)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiIntersects" }, ray, camera, predicate
                }
            );
        }

        public async ValueTask render()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }
                }
            );
        }
        #endregion
    }
}