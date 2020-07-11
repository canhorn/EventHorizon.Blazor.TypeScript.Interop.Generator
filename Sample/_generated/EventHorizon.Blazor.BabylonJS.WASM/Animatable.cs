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
                __syncRoot = EventHorizonBlazorInteropt.GetClass<Animatable>(
                    this.___guid,
                    "syncRoot",
                    (entity) =>
                    {
                        return new Animatable(entity);
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "masterFrame"
                );
            }
        }

        
        public decimal weight
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "weight"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "speedRatio"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "target"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "fromFrame"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "toFrame"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "loopAnimation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "loopAnimation",
                    value
                );
            }
        }

        
        public bool disposeOnEnd
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "disposeOnEnd"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "animationStarted"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "animationStarted",
                    value
                );
            }
        }

        private Observable __onAnimationEndObservable;
        public Observable onAnimationEndObservable
        {
            get
            {
            if(__onAnimationEndObservable == null)
            {
                __onAnimationEndObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAnimationEndObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAnimationEndObservable;
            }
            set
            {
__onAnimationEndObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAnimationEndObservable",
                    value
                );
            }
        }

        private Observable __onAnimationLoopObservable;
        public Observable onAnimationLoopObservable
        {
            get
            {
            if(__onAnimationLoopObservable == null)
            {
                __onAnimationLoopObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAnimationLoopObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAnimationLoopObservable;
            }
            set
            {
__onAnimationLoopObservable = null;
                EventHorizonBlazorInteropt.Set(
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

        private void SetupOnAnimationEndLoop()
        {
            if (_isOnAnimationEndEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        private void SetupOnAnimationLoopLoop()
        {
            if (_isOnAnimationLoopEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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
            return EventHorizonBlazorInteropt.FuncClass<Animatable>(
                entity => new Animatable(entity),
                new object[] 
                {
                    new string[] { this.___guid, "syncWith" }, root
                }
            );
        }

        public RuntimeAnimation[] getAnimations()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<RuntimeAnimation>(
                entity => new RuntimeAnimation(entity),
                new object[]
                {
                    new string[] { this.___guid, "getAnimations" }
                }
            );
        }

        public void appendAnimations(CachedEntity target, Animation[] animations)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "appendAnimations" }, target, animations
                }
            );
        }

        public Animation getAnimationByTargetProperty(string property)
        {
            return EventHorizonBlazorInteropt.FuncClass<Animation>(
                entity => new Animation(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getAnimationByTargetProperty" }, property
                }
            );
        }

        public RuntimeAnimation getRuntimeAnimationByTargetProperty(string property)
        {
            return EventHorizonBlazorInteropt.FuncClass<RuntimeAnimation>(
                entity => new RuntimeAnimation(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getRuntimeAnimationByTargetProperty" }, property
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public void enableBlending(decimal blendingSpeed)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enableBlending" }, blendingSpeed
                }
            );
        }

        public void disableBlending()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disableBlending" }
                }
            );
        }

        public void goToFrame(decimal frame)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "goToFrame" }, frame
                }
            );
        }

        public void pause()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public void restart()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "restart" }
                }
            );
        }

        #region stop TODO: Get Comments as metadata identification
        private bool _isStopEnabled = false;
        private readonly IDictionary<string, Func<Task>> _stopActionMap = new Dictionary<string, Func<Task>>();

        public string stop(
            Func<Task> callback
        )
        {
            SetupStopLoop();

            var handle = Guid.NewGuid().ToString();
            _stopActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupStopLoop()
        {
            if (_isStopEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "stop",
                "CallStopActions",
                _invokableReference
            );
            _isStopEnabled = true;
        }

        [JSInvokable]
        public async Task CallStopActions()
        {
            foreach (var action in _stopActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public Animatable waitAsync()
        {
            return EventHorizonBlazorInteropt.FuncClass<Animatable>(
                entity => new Animatable(entity),
                new object[] 
                {
                    new string[] { this.___guid, "waitAsync" }
                }
            );
        }
        #endregion
    }
}