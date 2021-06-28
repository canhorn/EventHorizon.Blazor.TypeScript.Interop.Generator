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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationGroup>))]
    public class AnimationGroup : CachedEntityObject, _IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static AnimationGroup Parse(object parsedAnimationGroup, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AnimationGroup", "Parse" }, parsedAnimationGroup, scene
                }
            );
        }

        public static AnimationGroup MakeAnimationAdditive(AnimationGroup sourceAnimationGroup, System.Nullable<decimal> referenceFrame = null, string range = null, System.Nullable<bool> cloneOriginal = null, string clonedName = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AnimationGroup", "MakeAnimationAdditive" }, sourceAnimationGroup, referenceFrame, range, cloneOriginal, clonedName
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal from
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "from"
                );
            }
        }

        
        public decimal to
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "to"
                );
            }
        }

        
        public bool isStarted
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isStarted"
                );
            }
        }

        
        public bool isPlaying
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPlaying"
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

        
        public TargetedAnimation[] targetedAnimations
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<TargetedAnimation>(
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
            return EventHorizonBlazorInterop.GetArrayClass<Animatable>(
                    this.___guid,
                    "animatables",
                    (entity) =>
                    {
                        return new Animatable() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public TargetedAnimation[] children
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<TargetedAnimation>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new TargetedAnimation() { ___guid = entity.___guid };
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

        private Observable<TargetedAnimation> __onAnimationEndObservable;
        public Observable<TargetedAnimation> onAnimationEndObservable
        {
            get
            {
            if(__onAnimationEndObservable == null)
            {
                __onAnimationEndObservable = EventHorizonBlazorInterop.GetClass<Observable<TargetedAnimation>>(
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
                EventHorizonBlazorInterop.Set(
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
                __onAnimationLoopObservable = EventHorizonBlazorInterop.GetClass<Observable<TargetedAnimation>>(
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
                EventHorizonBlazorInterop.Set(
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
                __onAnimationGroupLoopObservable = EventHorizonBlazorInterop.GetClass<Observable<AnimationGroup>>(
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
                EventHorizonBlazorInterop.Set(
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
                __onAnimationGroupEndObservable = EventHorizonBlazorInterop.GetClass<Observable<AnimationGroup>>(
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
                EventHorizonBlazorInterop.Set(
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
                __onAnimationGroupPauseObservable = EventHorizonBlazorInterop.GetClass<Observable<AnimationGroup>>(
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
                EventHorizonBlazorInterop.Set(
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
                __onAnimationGroupPlayObservable = EventHorizonBlazorInterop.GetClass<Observable<AnimationGroup>>(
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
                EventHorizonBlazorInterop.Set(
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
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AnimationGroup" },
                name, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public TargetedAnimation addTargetedAnimation(Animation animation, object target)
        {
            return EventHorizonBlazorInterop.FuncClass<TargetedAnimation>(
                entity => new TargetedAnimation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addTargetedAnimation" }, animation, target
                }
            );
        }

        public AnimationGroup normalize(System.Nullable<decimal> beginFrame = null, System.Nullable<decimal> endFrame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalize" }, beginFrame, endFrame
                }
            );
        }

        public AnimationGroup start(System.Nullable<bool> loop = null, System.Nullable<decimal> speedRatio = null, System.Nullable<decimal> from = null, System.Nullable<decimal> to = null, System.Nullable<bool> isAdditive = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "start" }, loop, speedRatio, from, to, isAdditive
                }
            );
        }

        public AnimationGroup pause()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public AnimationGroup play(System.Nullable<bool> loop = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "play" }, loop
                }
            );
        }

        public AnimationGroup reset()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public AnimationGroup restart()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "restart" }
                }
            );
        }

        public AnimationGroup stop()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public AnimationGroup setWeightForAllAnimatables(decimal weight)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setWeightForAllAnimatables" }, weight
                }
            );
        }

        public AnimationGroup syncAllAnimationsWith(Animatable root)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "syncAllAnimationsWith" }, root
                }
            );
        }

        public AnimationGroup goToFrame(decimal frame)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "goToFrame" }, frame
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

        public AnimationGroup clone(string newName, ActionResultCallback<object, CachedEntity> targetConverter = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, newName, targetConverter
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }
        #endregion
    }
}