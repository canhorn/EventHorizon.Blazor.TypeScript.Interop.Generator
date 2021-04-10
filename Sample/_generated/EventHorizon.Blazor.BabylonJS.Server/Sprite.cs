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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Sprite>))]
    public class Sprite : ThinSprite, IAnimatable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Sprite> Parse(object parsedSprite, SpriteManager manager)
        {
            return await EventHorizonBlazorInterop.FuncClass<Sprite>(
                entity => new Sprite() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Sprite", "Parse" }, parsedSprite, manager
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_size()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "size"
                );
        }
        public ValueTask set_size(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "size",
                    value
                );
        }

        private ISpriteManagerCachedEntity __manager;
        public async ValueTask<ISpriteManagerCachedEntity> get_manager()
        {
            if(__manager == null)
            {
                __manager = await EventHorizonBlazorInterop.GetClass<ISpriteManagerCachedEntity>(
                    this.___guid,
                    "manager",
                    (entity) =>
                    {
                        return new ISpriteManagerCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __manager;
        }

        
        public async ValueTask<decimal> get_fromIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fromIndex"
                );
        }
        public ValueTask set_fromIndex(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fromIndex",
                    value
                );
        }

        
        public async ValueTask<decimal> get_toIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "toIndex"
                );
        }
        public ValueTask set_toIndex(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "toIndex",
                    value
                );
        }

        
        public async ValueTask<bool> get_loopAnimation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "loopAnimation"
                );
        }
        public ValueTask set_loopAnimation(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loopAnimation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_delay()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "delay"
                );
        }
        public ValueTask set_delay(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delay",
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

        private Vector3 __position;
        public async ValueTask<Vector3> get_position()
        {
            if(__position == null)
            {
                __position = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
        }
        public ValueTask set_position(Vector3 value)
        {
__position = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
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

        
        public async ValueTask<bool> get_disposeWhenFinishedAnimating()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disposeWhenFinishedAnimating"
                );
        }
        public ValueTask set_disposeWhenFinishedAnimating(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disposeWhenFinishedAnimating",
                    value
                );
        }

        
        public async ValueTask<Animation[]> get_animations()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_animations(Animation[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
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

        
        public async ValueTask<bool> get_useAlphaForPicking()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useAlphaForPicking"
                );
        }
        public ValueTask set_useAlphaForPicking(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useAlphaForPicking",
                    value
                );
        }

        private ActionManager __actionManager;
        public async ValueTask<ActionManager> get_actionManager()
        {
            if(__actionManager == null)
            {
                __actionManager = await EventHorizonBlazorInterop.GetClass<ActionManager>(
                    this.___guid,
                    "actionManager",
                    (entity) =>
                    {
                        return new ActionManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __actionManager;
        }
        public ValueTask set_actionManager(ActionManager value)
        {
__actionManager = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "actionManager",
                    value
                );
        }

        private Observable<Sprite> __onDisposeObservable;
        public async ValueTask<Observable<Sprite>> get_onDisposeObservable()
        {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = await EventHorizonBlazorInterop.GetClass<Observable<Sprite>>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable<Sprite>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onDisposeObservable;
        }
        public ValueTask set_onDisposeObservable(Observable<Sprite> value)
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
        #endregion
        
        #region Constructor
        public Sprite() : base() { }

        public Sprite(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Sprite> NewSprite(
            string name, ISpriteManager manager
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Sprite" },
                name, manager
            );

            return new Sprite(entity);
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

        public async ValueTask playAnimation(decimal from, decimal to, bool loop, decimal delay, ActionCallback onAnimationEnd = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "playAnimation" }, from, to, loop, delay, onAnimationEnd
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

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}