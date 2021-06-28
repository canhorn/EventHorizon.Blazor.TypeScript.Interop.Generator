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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SpriteManager>))]
    public class SpriteManager : CachedEntityObject, ISpriteManager
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static string SnippetUrl
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "SpriteManager.SnippetUrl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "SpriteManager.SnippetUrl",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static SpriteManager Parse(object parsedManager, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInterop.FuncClass<SpriteManager>(
                entity => new SpriteManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SpriteManager", "Parse" }, parsedManager, scene, rootUrl
                }
            );
        }

        public static ValueTask<SpriteManager> ParseFromFileAsync(string url, Scene scene, string name = null, string rootUrl = null)
        {
            return EventHorizonBlazorInterop.TaskClass<SpriteManager>(
                entity => new SpriteManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SpriteManager", "ParseFromFileAsync" }, name, url, scene, rootUrl
                }
            );
        }

        public static ValueTask<SpriteManager> CreateFromSnippetAsync(string snippetId, Scene scene, string rootUrl = null)
        {
            return EventHorizonBlazorInterop.TaskClass<SpriteManager>(
                entity => new SpriteManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SpriteManager", "CreateFromSnippetAsync" }, snippetId, scene, rootUrl
                }
            );
        }
        #endregion

        #region Accessors
        
        public Sprite[] children
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Sprite>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new Sprite() { ___guid = entity.___guid };
                    }
                );
            }
        }

        private Scene __scene;
        public Scene scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInterop.GetClass<Scene>(
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
        }

        
        public decimal capacity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "capacity"
                );
            }
        }

        private Texture __texture;
        public Texture texture
        {
            get
            {
            if(__texture == null)
            {
                __texture = EventHorizonBlazorInterop.GetClass<Texture>(
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
            set
            {
__texture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }

        
        public decimal cellWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellWidth",
                    value
                );
            }
        }

        
        public decimal cellHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellHeight",
                    value
                );
            }
        }

        
        public bool fogEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "fogEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogEnabled",
                    value
                );
            }
        }

        
        public decimal blendMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public string snippetId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "snippetId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "snippetId",
                    value
                );
            }
        }

        
        public Sprite[] sprites
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Sprite>(
                    this.___guid,
                    "sprites",
                    (entity) =>
                    {
                        return new Sprite() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sprites",
                    value
                );
            }
        }

        
        public decimal renderingGroupId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderingGroupId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderingGroupId",
                    value
                );
            }
        }

        
        public decimal layerMask
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "layerMask",
                    value
                );
            }
        }

        
        public bool isPickable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPickable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPickable",
                    value
                );
            }
        }

        private Observable<SpriteManager> __onDisposeObservable;
        public Observable<SpriteManager> onDisposeObservable
        {
            get
            {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = EventHorizonBlazorInterop.GetClass<Observable<SpriteManager>>(
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
            set
            {
__onDisposeObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
            }
        }

        
        public decimal uniqueId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniqueId",
                    value
                );
            }
        }

        
        public bool disableDepthWrite
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableDepthWrite"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableDepthWrite",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SpriteManager() : base() { }

        public SpriteManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SpriteManager(
            string name, string imgUrl, decimal capacity, object cellSize, Scene scene, System.Nullable<decimal> epsilon = null, System.Nullable<decimal> samplingMode = null, System.Nullable<bool> fromPacked = null, object spriteJSON = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "SpriteManager" },
                name, imgUrl, capacity, cellSize, scene, epsilon, samplingMode, fromPacked, spriteJSON
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public PickingInfo intersects(Ray ray, Camera camera, ActionResultCallback<Sprite, bool> predicate = null, System.Nullable<bool> fastCheck = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersects" }, ray, camera, predicate, fastCheck
                }
            );
        }

        public PickingInfo[] multiIntersects(Ray ray, Camera camera, ActionResultCallback<Sprite, bool> predicate = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiIntersects" }, ray, camera, predicate
                }
            );
        }

        public void render()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public CachedEntity serialize(System.Nullable<bool> serializeTexture = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }, serializeTexture
                }
            );
        }
        #endregion
    }
}