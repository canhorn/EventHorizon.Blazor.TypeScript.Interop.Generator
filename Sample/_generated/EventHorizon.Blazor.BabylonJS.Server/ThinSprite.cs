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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ThinSprite>))]
    public class ThinSprite : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_animationStarted()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "animationStarted"
                );
        }

        
        public async ValueTask<decimal> get_fromIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fromIndex"
                );
        }

        
        public async ValueTask<decimal> get_toIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "toIndex"
                );
        }

        
        public async ValueTask<bool> get_loopAnimation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "loopAnimation"
                );
        }

        
        public async ValueTask<decimal> get_delay()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "delay"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_cellIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cellIndex"
                );
        }
        public ValueTask set_cellIndex(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellIndex",
                    value
                );
        }

        
        public async ValueTask<string> get_cellRef()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "cellRef"
                );
        }
        public ValueTask set_cellRef(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cellRef",
                    value
                );
        }

        private IVector3LikeCachedEntity __position;
        public async ValueTask<IVector3LikeCachedEntity> get_position()
        {
            if(__position == null)
            {
                __position = await EventHorizonBlazorInterop.GetClass<IVector3LikeCachedEntity>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new IVector3LikeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
        }
        public ValueTask set_position(IVector3LikeCachedEntity value)
        {
__position = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
        }

        private IColor4LikeCachedEntity __color;
        public async ValueTask<IColor4LikeCachedEntity> get_color()
        {
            if(__color == null)
            {
                __color = await EventHorizonBlazorInterop.GetClass<IColor4LikeCachedEntity>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new IColor4LikeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __color;
        }
        public ValueTask set_color(IColor4LikeCachedEntity value)
        {
__color = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
        }

        
        public async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
        }
        public ValueTask set_width(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
        }

        
        public async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
        }
        public ValueTask set_height(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
        }

        
        public async ValueTask<decimal> get_angle()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
        }
        public ValueTask set_angle(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
        }

        
        public async ValueTask<bool> get_invertU()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertU"
                );
        }
        public ValueTask set_invertU(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertU",
                    value
                );
        }

        
        public async ValueTask<bool> get_invertV()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "invertV"
                );
        }
        public ValueTask set_invertV(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "invertV",
                    value
                );
        }

        
        public async ValueTask<bool> get_isVisible()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isVisible"
                );
        }
        public ValueTask set_isVisible(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isVisible",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ThinSprite() : base() { } 

        public ThinSprite(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public async ValueTask playAnimation(decimal from, decimal to, bool loop, decimal delay, ActionCallback onAnimationEnd = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "playAnimation" }, from, to, loop, delay, onAnimationEnd
                }
            );
        }

        public async ValueTask stopAnimation()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stopAnimation" }
                }
            );
        }
        #endregion
    }
}