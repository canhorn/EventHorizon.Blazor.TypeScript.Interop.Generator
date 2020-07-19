/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Layer : CachedEntityObject
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
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "name",
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
                __texture = EventHorizonBlazorInteropt.GetClass<Texture>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "texture",
                    value
                );
            }
        }

        
        public bool isBackground
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isBackground"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isBackground",
                    value
                );
            }
        }

        private Color4 __color;
        public Color4 color
        {
            get
            {
            if(__color == null)
            {
                __color = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __color;
            }
            set
            {
__color = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        private Vector2 __scale;
        public Vector2 scale
        {
            get
            {
            if(__scale == null)
            {
                __scale = EventHorizonBlazorInteropt.GetClass<Vector2>(
                    this.___guid,
                    "scale",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __scale;
            }
            set
            {
__scale = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "scale",
                    value
                );
            }
        }

        private Vector2 __offset;
        public Vector2 offset
        {
            get
            {
            if(__offset == null)
            {
                __offset = EventHorizonBlazorInteropt.GetClass<Vector2>(
                    this.___guid,
                    "offset",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __offset;
            }
            set
            {
__offset = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "offset",
                    value
                );
            }
        }

        
        public decimal alphaBlendingMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "alphaBlendingMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "alphaBlendingMode",
                    value
                );
            }
        }

        
        public bool alphaTest
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "alphaTest"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "alphaTest",
                    value
                );
            }
        }

        
        public decimal layerMask
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "layerMask",
                    value
                );
            }
        }

        
        public RenderTargetTexture[] renderTargetTextures
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<RenderTargetTexture>(
                    this.___guid,
                    "renderTargetTextures",
                    (entity) =>
                    {
                        return new RenderTargetTexture() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "renderTargetTextures",
                    value
                );
            }
        }

        
        public bool renderOnlyInRenderTargetTextures
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "renderOnlyInRenderTargetTextures"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "renderOnlyInRenderTargetTextures",
                    value
                );
            }
        }

        private Observable<Layer> __onDisposeObservable;
        public Observable<Layer> onDisposeObservable
        {
            get
            {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = EventHorizonBlazorInteropt.GetClass<Observable<Layer>>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable<Layer>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onDisposeObservable;
            }
            set
            {
__onDisposeObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
            }
        }

        private Observable<Layer> __onBeforeRenderObservable;
        public Observable<Layer> onBeforeRenderObservable
        {
            get
            {
            if(__onBeforeRenderObservable == null)
            {
                __onBeforeRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable<Layer>>(
                    this.___guid,
                    "onBeforeRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Layer>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeRenderObservable;
            }
            set
            {
__onBeforeRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeRenderObservable",
                    value
                );
            }
        }

        private Observable<Layer> __onAfterRenderObservable;
        public Observable<Layer> onAfterRenderObservable
        {
            get
            {
            if(__onAfterRenderObservable == null)
            {
                __onAfterRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable<Layer>>(
                    this.___guid,
                    "onAfterRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Layer>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterRenderObservable;
            }
            set
            {
__onAfterRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterRenderObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Layer() : base() { } 

        public Layer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Layer(
            string name, Scene scene, string imgUrl = null, System.Nullable<bool> isBackground = null, Color4 color = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Layer" },
                name, imgUrl, scene, isBackground, color
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void render()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}