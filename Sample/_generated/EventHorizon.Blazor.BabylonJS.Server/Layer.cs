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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Layer>))]
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

        
        public async ValueTask<bool> get_isBackground()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBackground"
                );
        }
        public ValueTask set_isBackground(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isBackground",
                    value
                );
        }

        private Color4 __color;
        public async ValueTask<Color4> get_color()
        {
            if(__color == null)
            {
                __color = await EventHorizonBlazorInterop.GetClass<Color4>(
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
        public ValueTask set_color(Color4 value)
        {
__color = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
        }

        private Vector2 __scale;
        public async ValueTask<Vector2> get_scale()
        {
            if(__scale == null)
            {
                __scale = await EventHorizonBlazorInterop.GetClass<Vector2>(
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
        public ValueTask set_scale(Vector2 value)
        {
__scale = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scale",
                    value
                );
        }

        private Vector2 __offset;
        public async ValueTask<Vector2> get_offset()
        {
            if(__offset == null)
            {
                __offset = await EventHorizonBlazorInterop.GetClass<Vector2>(
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
        public ValueTask set_offset(Vector2 value)
        {
__offset = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_alphaBlendingMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaBlendingMode"
                );
        }
        public ValueTask set_alphaBlendingMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaBlendingMode",
                    value
                );
        }

        
        public async ValueTask<bool> get_alphaTest()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "alphaTest"
                );
        }
        public ValueTask set_alphaTest(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaTest",
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

        
        public async ValueTask<RenderTargetTexture[]> get_renderTargetTextures()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<RenderTargetTexture>(
                    this.___guid,
                    "renderTargetTextures",
                    (entity) =>
                    {
                        return new RenderTargetTexture() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_renderTargetTextures(RenderTargetTexture[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderTargetTextures",
                    value
                );
        }

        
        public async ValueTask<bool> get_renderOnlyInRenderTargetTextures()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderOnlyInRenderTargetTextures"
                );
        }
        public ValueTask set_renderOnlyInRenderTargetTextures(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderOnlyInRenderTargetTextures",
                    value
                );
        }

        private Observable<Layer> __onDisposeObservable;
        public async ValueTask<Observable<Layer>> get_onDisposeObservable()
        {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = await EventHorizonBlazorInterop.GetClass<Observable<Layer>>(
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
        public ValueTask set_onDisposeObservable(Observable<Layer> value)
        {
__onDisposeObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
        }

        private Observable<Layer> __onBeforeRenderObservable;
        public async ValueTask<Observable<Layer>> get_onBeforeRenderObservable()
        {
            if(__onBeforeRenderObservable == null)
            {
                __onBeforeRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Layer>>(
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
        public ValueTask set_onBeforeRenderObservable(Observable<Layer> value)
        {
__onBeforeRenderObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeRenderObservable",
                    value
                );
        }

        private Observable<Layer> __onAfterRenderObservable;
        public async ValueTask<Observable<Layer>> get_onAfterRenderObservable()
        {
            if(__onAfterRenderObservable == null)
            {
                __onAfterRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Layer>>(
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
        public ValueTask set_onAfterRenderObservable(Observable<Layer> value)
        {
__onAfterRenderObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterRenderObservable",
                    value
                );
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

        public static async ValueTask<Layer> NewLayer(
            string name, Scene scene, string imgUrl = null, System.Nullable<bool> isBackground = null, Color4 color = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Layer" },
                name, imgUrl, scene, isBackground, color
            );

            return new Layer(entity);
        }
        #endregion

        #region Methods
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
        #endregion
    }
}