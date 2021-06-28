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
            set
            {
__scene = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
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
        #endregion
    }
}