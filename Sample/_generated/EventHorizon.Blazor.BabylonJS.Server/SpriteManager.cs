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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SpriteManager>))]
    public class SpriteManager : CachedEntityObject, ISpriteManager
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<string> get_SnippetUrl()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "SpriteManager.SnippetUrl"
                );
        }
        public static ValueTask set_SnippetUrl(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "SpriteManager.SnippetUrl",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<SpriteManager> Parse(object parsedManager, Scene scene, string rootUrl)
        {
            return await EventHorizonBlazorInterop.FuncClass<SpriteManager>(
                entity => new SpriteManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SpriteManager", "Parse" }, parsedManager, scene, rootUrl
                }
            );
        }

        public static async ValueTask<SpriteManager> ParseFromFileAsync(string url, Scene scene, string name = null, string rootUrl = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<SpriteManager>(
                entity => new SpriteManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SpriteManager", "ParseFromFileAsync" }, name, url, scene, rootUrl
                }
            );
        }

        public static async ValueTask<SpriteManager> CreateFromSnippetAsync(string snippetId, Scene scene, string rootUrl = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<SpriteManager>(
                entity => new SpriteManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SpriteManager", "CreateFromSnippetAsync" }, snippetId, scene, rootUrl
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<Sprite[]> get_children()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Sprite>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new Sprite() { ___guid = entity.___guid };
                    }
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

        
        public async ValueTask<decimal> get_capacity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "capacity"
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

        
        public async ValueTask<bool> get_fogEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "fogEnabled"
                );
        }
        public ValueTask set_fogEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogEnabled",
                    value
                );
        }

        
        public async ValueTask<decimal> get_blendMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blendMode"
                );
        }
        public ValueTask set_blendMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
                    value
                );
        }
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

        
        public async ValueTask<string> get_snippetId()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "snippetId"
                );
        }
        public ValueTask set_snippetId(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "snippetId",
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

        private Observable<SpriteManager> __onDisposeObservable;
        public async ValueTask<Observable<SpriteManager>> get_onDisposeObservable()
        {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = await EventHorizonBlazorInterop.GetClass<Observable<SpriteManager>>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable<SpriteManager>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onDisposeObservable;
        }
        public ValueTask set_onDisposeObservable(Observable<SpriteManager> value)
        {
__onDisposeObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
        }

        
        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
        }
        public ValueTask set_uniqueId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniqueId",
                    value
                );
        }

        
        public async ValueTask<bool> get_disableDepthWrite()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableDepthWrite"
                );
        }
        public ValueTask set_disableDepthWrite(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableDepthWrite",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public SpriteManager() : base() { }

        public SpriteManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<SpriteManager> NewSpriteManager(
            string name, string imgUrl, decimal capacity, object cellSize, Scene scene, System.Nullable<decimal> epsilon = null, System.Nullable<decimal> samplingMode = null, System.Nullable<bool> fromPacked = null, object spriteJSON = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "SpriteManager" },
                name, imgUrl, capacity, cellSize, scene, epsilon, samplingMode, fromPacked, spriteJSON
            );

            return new SpriteManager(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

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

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public async ValueTask<CachedEntity> serialize(System.Nullable<bool> serializeTexture = null)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, serializeTexture
                }
            );
        }
        #endregion
    }
}