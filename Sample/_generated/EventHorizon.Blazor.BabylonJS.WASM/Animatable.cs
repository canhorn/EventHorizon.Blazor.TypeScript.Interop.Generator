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
        public Animatable syncRoot
        {
            get
            {
            if(__syncRoot == null)
            {
                __syncRoot = EventHorizonBlazorInterop.GetClass<Animatable>(
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
        }

        
        public decimal masterFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "masterFrame"
                );
            }
        }

        
        public decimal weight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "weight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "weight",
                    value
                );
            }
        }

        
        public decimal speedRatio
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "speedRatio"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "speedRatio",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public CachedEntity target
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "target",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
            }
        }

        
        public decimal fromFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fromFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fromFrame",
                    value
                );
            }
        }

        
        public decimal toFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "toFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "toFrame",
                    value
                );
            }
        }

        
        public bool loopAnimation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "loopAnimation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loopAnimation",
                    value
                );
            }
        }

        
        public bool isAdditive
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isAdditive"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isAdditive",
                    value
                );
            }
        }

        
        public bool disposeOnEnd
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disposeOnEnd"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disposeOnEnd",
                    value
                );
            }
        }

        
        public bool animationStarted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "animationStarted"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationStarted",
                    value
                );
            }
        }

        private Observable<Animatable> __onAnimationEndObservable;
        public Observable<Animatable> onAnimationEndObservable
        {
            get
            {
            if(__onAnimationEndObservable == null)
            {
                __onAnimationEndObservable = EventHorizonBlazorInterop.GetClass<Observable<Animatable>>(
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
            set
            {
__onAnimationEndObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAnimationEndObservable",
                    value
                );
            }
        }

        private Observable<Animatable> __onAnimationLoopObservable;
        public Observable<Animatable> onAnimationLoopObservable
        {
            get
            {
            if(__onAnimationLoopObservable == null)
            {
                __onAnimationLoopObservable = EventHorizonBlazorInterop.GetClass<Observable<Animatable>>(
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
            set
            {
__onAnimationLoopObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAnimationLoopObservable",
                    value
                );
            }
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

        public Animatable(
            Scene scene, object target, System.Nullable<decimal> fromFrame = null, System.Nullable<decimal> toFrame = null, System.Nullable<bool> loopAnimation = null, System.Nullable<decimal> speedRatio = null, ActionResultCallback<ActionCallback> onAnimationEnd = null, Animation[] animations = null, ActionResultCallback<ActionCallback> onAnimationLoop = null, System.Nullable<bool> isAdditive = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Animatable" },
                scene, target, fromFrame, toFrame, loopAnimation, speedRatio, onAnimationEnd, animations, onAnimationLoop, isAdditive
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region onAnimationEnd TODO: Get Comments as metadata identification
        private bool _isOnAnimationEndEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onAnimationEndActionMap = new Dictionary<string, Func<Task>>();

        public string onAnimationEnd(
            Func<Task> callback
        )
        {
            SetupOnAnimationEndLoop();

            var handle = Guid.NewGuid().ToString();
            _onAnimationEndActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onAnimationEnd_Remove(
            string handle
        )
        {
            return _onAnimationEndActionMap.Remove(
                handle
            );
        }

        private void SetupOnAnimationEndLoop()
        {
            if (_isOnAnimationEndEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public string onAnimationLoop(
            Func<Task> callback
        )
        {
            SetupOnAnimationLoopLoop();

            var handle = Guid.NewGuid().ToString();
            _onAnimationLoopActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onAnimationLoop_Remove(
            string handle
        )
        {
            return _onAnimationLoopActionMap.Remove(
                handle
            );
        }

        private void SetupOnAnimationLoopLoop()
        {
            if (_isOnAnimationLoopEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public Animatable syncWith(Animatable root)
        {
            return EventHorizonBlazorInterop.FuncClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "syncWith" }, root
                }
            );
        }

        public RuntimeAnimation[] getAnimations()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<RuntimeAnimation>(
                entity => new RuntimeAnimation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimations" }
                }
            );
        }

        public void appendAnimations(object target, Animation[] animations)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "appendAnimations" }, target, animations
                }
            );
        }

        public Animation getAnimationByTargetProperty(string property)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimationByTargetProperty" }, property
                }
            );
        }

        public RuntimeAnimation getRuntimeAnimationByTargetProperty(string property)
        {
            return EventHorizonBlazorInterop.FuncClass<RuntimeAnimation>(
                entity => new RuntimeAnimation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRuntimeAnimationByTargetProperty" }, property
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public void enableBlending(decimal blendingSpeed)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enableBlending" }, blendingSpeed
                }
            );
        }

        public void disableBlending()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disableBlending" }
                }
            );
        }

        public void goToFrame(decimal frame)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "goToFrame" }, frame
                }
            );
        }

        public void pause()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public void restart()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "restart" }
                }
            );
        }

        public void stop(string animationName = null, ActionResultCallback<object, bool> targetMask = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stop" }, animationName, targetMask
                }
            );
        }

        public ValueTask<Animatable> waitAsync()
        {
            return EventHorizonBlazorInterop.TaskClass<Animatable>(
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