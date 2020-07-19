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
    public class AnimationGroup : CachedEntityObject, IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static AnimationGroup Parse(object parsedAnimationGroup, Scene scene)
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "AnimationGroup", "Parse" }, parsedAnimationGroup, scene
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal from
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "from"
                );
            }
        }

        
        public decimal to
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "to"
                );
            }
        }

        
        public bool isStarted
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isStarted"
                );
            }
        }

        
        public bool isPlaying
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isPlaying"
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

        
        public TargetedAnimation[] targetedAnimations
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<TargetedAnimation>(
                    this.___guid,
                    "targetedAnimations",
                    (entity) =>
                    {
                        return new TargetedAnimation() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public Animatable[] animatables
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Animatable>(
                    this.___guid,
                    "animatables",
                    (entity) =>
                    {
                        return new Animatable() { ___guid = entity.___guid };
                    }
                );
            }
        }
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

        
        public decimal uniqueId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "uniqueId",
                    value
                );
            }
        }

        private Observable<TargetedAnimation> __onAnimationEndObservable;
        public Observable<TargetedAnimation> onAnimationEndObservable
        {
            get
            {
            if(__onAnimationEndObservable == null)
            {
                __onAnimationEndObservable = EventHorizonBlazorInteropt.GetClass<Observable<TargetedAnimation>>(
                    this.___guid,
                    "onAnimationEndObservable",
                    (entity) =>
                    {
                        return new Observable<TargetedAnimation>() { ___guid = entity.___guid };
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

        private Observable<TargetedAnimation> __onAnimationLoopObservable;
        public Observable<TargetedAnimation> onAnimationLoopObservable
        {
            get
            {
            if(__onAnimationLoopObservable == null)
            {
                __onAnimationLoopObservable = EventHorizonBlazorInteropt.GetClass<Observable<TargetedAnimation>>(
                    this.___guid,
                    "onAnimationLoopObservable",
                    (entity) =>
                    {
                        return new Observable<TargetedAnimation>() { ___guid = entity.___guid };
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

        private Observable<AnimationGroup> __onAnimationGroupLoopObservable;
        public Observable<AnimationGroup> onAnimationGroupLoopObservable
        {
            get
            {
            if(__onAnimationGroupLoopObservable == null)
            {
                __onAnimationGroupLoopObservable = EventHorizonBlazorInteropt.GetClass<Observable<AnimationGroup>>(
                    this.___guid,
                    "onAnimationGroupLoopObservable",
                    (entity) =>
                    {
                        return new Observable<AnimationGroup>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAnimationGroupLoopObservable;
            }
            set
            {
__onAnimationGroupLoopObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAnimationGroupLoopObservable",
                    value
                );
            }
        }

        private Observable<AnimationGroup> __onAnimationGroupEndObservable;
        public Observable<AnimationGroup> onAnimationGroupEndObservable
        {
            get
            {
            if(__onAnimationGroupEndObservable == null)
            {
                __onAnimationGroupEndObservable = EventHorizonBlazorInteropt.GetClass<Observable<AnimationGroup>>(
                    this.___guid,
                    "onAnimationGroupEndObservable",
                    (entity) =>
                    {
                        return new Observable<AnimationGroup>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAnimationGroupEndObservable;
            }
            set
            {
__onAnimationGroupEndObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAnimationGroupEndObservable",
                    value
                );
            }
        }

        private Observable<AnimationGroup> __onAnimationGroupPauseObservable;
        public Observable<AnimationGroup> onAnimationGroupPauseObservable
        {
            get
            {
            if(__onAnimationGroupPauseObservable == null)
            {
                __onAnimationGroupPauseObservable = EventHorizonBlazorInteropt.GetClass<Observable<AnimationGroup>>(
                    this.___guid,
                    "onAnimationGroupPauseObservable",
                    (entity) =>
                    {
                        return new Observable<AnimationGroup>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAnimationGroupPauseObservable;
            }
            set
            {
__onAnimationGroupPauseObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAnimationGroupPauseObservable",
                    value
                );
            }
        }

        private Observable<AnimationGroup> __onAnimationGroupPlayObservable;
        public Observable<AnimationGroup> onAnimationGroupPlayObservable
        {
            get
            {
            if(__onAnimationGroupPlayObservable == null)
            {
                __onAnimationGroupPlayObservable = EventHorizonBlazorInteropt.GetClass<Observable<AnimationGroup>>(
                    this.___guid,
                    "onAnimationGroupPlayObservable",
                    (entity) =>
                    {
                        return new Observable<AnimationGroup>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAnimationGroupPlayObservable;
            }
            set
            {
__onAnimationGroupPlayObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAnimationGroupPlayObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AnimationGroup() : base() { }

        public AnimationGroup(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AnimationGroup(
            string name, Scene scene = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "AnimationGroup" },
                name, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public TargetedAnimation addTargetedAnimation(Animation animation, object target)
        {
            return EventHorizonBlazorInteropt.FuncClass<TargetedAnimation>(
                entity => new TargetedAnimation() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addTargetedAnimation" }, animation, target
                }
            );
        }

        public AnimationGroup normalize(System.Nullable<decimal> beginFrame = null, System.Nullable<decimal> endFrame = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "normalize" }, beginFrame, endFrame
                }
            );
        }

        public AnimationGroup start(System.Nullable<bool> loop = null, System.Nullable<decimal> speedRatio = null, System.Nullable<decimal> from = null, System.Nullable<decimal> to = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "start" }, loop, speedRatio, from, to
                }
            );
        }

        public AnimationGroup pause()
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public AnimationGroup play(System.Nullable<bool> loop = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "play" }, loop
                }
            );
        }

        public AnimationGroup reset()
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public AnimationGroup restart()
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "restart" }
                }
            );
        }

        public AnimationGroup stop()
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public AnimationGroup setWeightForAllAnimatables(decimal weight)
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setWeightForAllAnimatables" }, weight
                }
            );
        }

        public AnimationGroup syncAllAnimationsWith(Animatable root)
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "syncAllAnimationsWith" }, root
                }
            );
        }

        public AnimationGroup goToFrame(decimal frame)
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "goToFrame" }, frame
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

        #region clone TODO: Get Comments as metadata identification
        private bool _isCloneEnabled = false;
        private readonly IDictionary<string, Func<Task>> _cloneActionMap = new Dictionary<string, Func<Task>>();

        public string clone(
            Func<Task> callback
        )
        {
            SetupCloneLoop();

            var handle = Guid.NewGuid().ToString();
            _cloneActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupCloneLoop()
        {
            if (_isCloneEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "clone",
                "CallCloneActions",
                _invokableReference
            );
            _isCloneEnabled = true;
        }

        [JSInvokable]
        public async Task CallCloneActions()
        {
            foreach (var action in _cloneActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }
        #endregion
    }
}