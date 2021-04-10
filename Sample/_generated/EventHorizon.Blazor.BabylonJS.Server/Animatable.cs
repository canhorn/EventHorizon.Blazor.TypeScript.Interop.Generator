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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Animatable>))]
    public class Animatable : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private Animatable __syncRoot;
        public async ValueTask<Animatable> get_syncRoot()
        {
            if(__syncRoot == null)
            {
                __syncRoot = await EventHorizonBlazorInterop.GetClass<Animatable>(
                    this.___guid,
                    "syncRoot",
                    (entity) =>
                    {
                        return new Animatable() { ___guid = entity.___guid };
                    }
                );
            }
            return __syncRoot;
        }

        
        public async ValueTask<decimal> get_masterFrame()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "masterFrame"
                );
        }

        
        public async ValueTask<decimal> get_weight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "weight"
                );
        }
        public ValueTask set_weight(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "weight",
                    value
                );
        }

        
        public async ValueTask<decimal> get_speedRatio()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "speedRatio"
                );
        }
        public ValueTask set_speedRatio(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "speedRatio",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<CachedEntity> get_target()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_target(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
        }

        
        public async ValueTask<decimal> get_fromFrame()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fromFrame"
                );
        }
        public ValueTask set_fromFrame(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fromFrame",
                    value
                );
        }

        
        public async ValueTask<decimal> get_toFrame()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "toFrame"
                );
        }
        public ValueTask set_toFrame(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "toFrame",
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

        
        public async ValueTask<bool> get_isAdditive()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isAdditive"
                );
        }
        public ValueTask set_isAdditive(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isAdditive",
                    value
                );
        }

        
        public async ValueTask<bool> get_disposeOnEnd()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disposeOnEnd"
                );
        }
        public ValueTask set_disposeOnEnd(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disposeOnEnd",
                    value
                );
        }

        
        public async ValueTask<bool> get_animationStarted()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "animationStarted"
                );
        }
        public ValueTask set_animationStarted(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationStarted",
                    value
                );
        }

        private Observable<Animatable> __onAnimationEndObservable;
        public async ValueTask<Observable<Animatable>> get_onAnimationEndObservable()
        {
            if(__onAnimationEndObservable == null)
            {
                __onAnimationEndObservable = await EventHorizonBlazorInterop.GetClass<Observable<Animatable>>(
                    this.___guid,
                    "onAnimationEndObservable",
                    (entity) =>
                    {
                        return new Observable<Animatable>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAnimationEndObservable;
        }
        public ValueTask set_onAnimationEndObservable(Observable<Animatable> value)
        {
__onAnimationEndObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAnimationEndObservable",
                    value
                );
        }

        private Observable<Animatable> __onAnimationLoopObservable;
        public async ValueTask<Observable<Animatable>> get_onAnimationLoopObservable()
        {
            if(__onAnimationLoopObservable == null)
            {
                __onAnimationLoopObservable = await EventHorizonBlazorInterop.GetClass<Observable<Animatable>>(
                    this.___guid,
                    "onAnimationLoopObservable",
                    (entity) =>
                    {
                        return new Observable<Animatable>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAnimationLoopObservable;
        }
        public ValueTask set_onAnimationLoopObservable(Observable<Animatable> value)
        {
__onAnimationLoopObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAnimationLoopObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Animatable() : base() { } 

        public Animatable(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<Animatable> NewAnimatable(
            Scene scene, object target, System.Nullable<decimal> fromFrame = null, System.Nullable<decimal> toFrame = null, System.Nullable<bool> loopAnimation = null, System.Nullable<decimal> speedRatio = null, ActionCallback onAnimationEnd = null, Animation[] animations = null, ActionCallback onAnimationLoop = null, System.Nullable<bool> isAdditive = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Animatable" },
                scene, target, fromFrame, toFrame, loopAnimation, speedRatio, onAnimationEnd, animations, onAnimationLoop, isAdditive
            );

            return new Animatable(entity);
        }
        #endregion

        #region Methods
        #region onAnimationEnd TODO: Get Comments as metadata identification
        private bool _isOnAnimationEndEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onAnimationEndActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> onAnimationEnd(
            Func<Task> callback
        )
        {
            await SetupOnAnimationEndLoop();

            var handle = Guid.NewGuid().ToString();
            _onAnimationEndActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupOnAnimationEndLoop()
        {
            if (_isOnAnimationEndEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "onAnimationEnd",
                "CallOnAnimationEndActions",
                _invokableReference
            );
            _isOnAnimationEndEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnAnimationEndActions()
        {
            foreach (var action in _onAnimationEndActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onAnimationLoop TODO: Get Comments as metadata identification
        private bool _isOnAnimationLoopEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onAnimationLoopActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> onAnimationLoop(
            Func<Task> callback
        )
        {
            await SetupOnAnimationLoopLoop();

            var handle = Guid.NewGuid().ToString();
            _onAnimationLoopActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupOnAnimationLoopLoop()
        {
            if (_isOnAnimationLoopEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "onAnimationLoop",
                "CallOnAnimationLoopActions",
                _invokableReference
            );
            _isOnAnimationLoopEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnAnimationLoopActions()
        {
            foreach (var action in _onAnimationLoopActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public async ValueTask<Animatable> syncWith(Animatable root)
        {
            return await EventHorizonBlazorInterop.FuncClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "syncWith" }, root
                }
            );
        }

        public async ValueTask<RuntimeAnimation[]> getAnimations()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<RuntimeAnimation>(
                entity => new RuntimeAnimation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimations" }
                }
            );
        }

        public async ValueTask appendAnimations(object target, Animation[] animations)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "appendAnimations" }, target, animations
                }
            );
        }

        public async ValueTask<Animation> getAnimationByTargetProperty(string property)
        {
            return await EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAnimationByTargetProperty" }, property
                }
            );
        }

        public async ValueTask<RuntimeAnimation> getRuntimeAnimationByTargetProperty(string property)
        {
            return await EventHorizonBlazorInterop.FuncClass<RuntimeAnimation>(
                entity => new RuntimeAnimation() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRuntimeAnimationByTargetProperty" }, property
                }
            );
        }

        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public async ValueTask enableBlending(decimal blendingSpeed)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enableBlending" }, blendingSpeed
                }
            );
        }

        public async ValueTask disableBlending()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disableBlending" }
                }
            );
        }

        public async ValueTask goToFrame(decimal frame)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "goToFrame" }, frame
                }
            );
        }

        public async ValueTask pause()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public async ValueTask restart()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "restart" }
                }
            );
        }

        public async ValueTask stop(string animationName = null, ActionCallback<object> targetMask = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stop" }, animationName, targetMask
                }
            );
        }

        public async ValueTask<Animatable> waitAsync()
        {
            return await EventHorizonBlazorInterop.TaskClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "waitAsync" }
                }
            );
        }
        #endregion
    }
}