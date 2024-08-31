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
        public static AnimationGroup MergeAnimationGroups(
            AnimationGroup[] animationGroups,
            System.Nullable<bool> disposeSource = null,
            System.Nullable<bool> normalize = null,
            System.Nullable<decimal> weight = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AnimationGroup", "MergeAnimationGroups" },
                    animationGroups,
                    disposeSource,
                    normalize,
                    weight
                }
            );
        }

        public static AnimationGroup Parse(object parsedAnimationGroup, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AnimationGroup", "Parse" },
                    parsedAnimationGroup,
                    scene
                }
            );
        }

        public static AnimationGroup MakeAnimationAdditive(
            AnimationGroup sourceAnimationGroup,
            decimal referenceFrame,
            string range = null,
            System.Nullable<bool> cloneOriginal = null,
            string clonedName = null,
            IMakeAnimationGroupAdditiveOptions options = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AnimationGroup", "MakeAnimationAdditive" },
                    sourceAnimationGroup,
                    referenceFrame,
                    range,
                    cloneOriginal,
                    clonedName,
                    options
                }
            );
        }

        public static AnimationGroup ClipKeys(
            AnimationGroup sourceAnimationGroup,
            decimal fromKey,
            decimal toKey,
            string name = null,
            System.Nullable<bool> dontCloneAnimations = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AnimationGroup", "ClipKeys" },
                    sourceAnimationGroup,
                    fromKey,
                    toKey,
                    name,
                    dontCloneAnimations
                }
            );
        }

        public static AnimationGroup ClipKeysInPlace(
            AnimationGroup animationGroup,
            decimal fromKey,
            decimal toKey,
            System.Nullable<bool> dontCloneAnimations = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AnimationGroup", "ClipKeysInPlace" },
                    animationGroup,
                    fromKey,
                    toKey,
                    dontCloneAnimations
                }
            );
        }

        public static AnimationGroup ClipFrames(
            AnimationGroup sourceAnimationGroup,
            decimal fromFrame,
            decimal toFrame,
            string name = null,
            System.Nullable<bool> dontCloneAnimations = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AnimationGroup", "ClipFrames" },
                    sourceAnimationGroup,
                    fromFrame,
                    toFrame,
                    name,
                    dontCloneAnimations
                }
            );
        }

        public static AnimationGroup ClipFramesInPlace(
            AnimationGroup animationGroup,
            decimal fromFrame,
            decimal toFrame,
            System.Nullable<bool> dontCloneAnimations = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AnimationGroup", "ClipFramesInPlace" },
                    animationGroup,
                    fromFrame,
                    toFrame,
                    dontCloneAnimations
                }
            );
        }

        public static AnimationGroup ClipInPlace(
            AnimationGroup animationGroup,
            decimal start,
            decimal end,
            System.Nullable<bool> dontCloneAnimations = null,
            System.Nullable<bool> useFrame = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AnimationGroup", "ClipInPlace" },
                    animationGroup,
                    start,
                    end,
                    dontCloneAnimations,
                    useFrame
                }
            );
        }
        #endregion

        #region Accessors
        private AnimationGroupMask __mask;
        public AnimationGroupMask mask
        {
            get
            {
                if (__mask == null)
                {
                    __mask = EventHorizonBlazorInterop.GetClass<AnimationGroupMask>(
                        this.___guid,
                        "mask",
                        (entity) =>
                        {
                            return new AnimationGroupMask() { ___guid = entity.___guid };
                        }
                    );
                }
                return __mask;
            }
            set
            {
                __mask = null;
                EventHorizonBlazorInterop.Set(this.___guid, "mask", value);
            }
        }

        public decimal from
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "from"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "from", value);
            }
        }

        public decimal to
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "to"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "to", value);
            }
        }

        public bool isStarted
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isStarted"); }
        }

        public bool isPlaying
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isPlaying"); }
        }

        public decimal speedRatio
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "speedRatio"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "speedRatio", value);
            }
        }

        public bool loopAnimation
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "loopAnimation"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "loopAnimation", value);
            }
        }

        public bool isAdditive
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isAdditive"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isAdditive", value);
            }
        }

        public decimal weight
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "weight"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "weight", value);
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

        public decimal playOrder
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "playOrder"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "playOrder", value);
            }
        }

        public bool enableBlending
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "enableBlending"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "enableBlending", value);
            }
        }

        public decimal blendingSpeed
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "blendingSpeed"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "blendingSpeed", value);
            }
        }
        #endregion

        #region Properties

        public string name
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
            }
        }

        public decimal uniqueId
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "uniqueId"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "uniqueId", value);
            }
        }

        private Observable<TargetedAnimation> __onAnimationEndObservable;
        public Observable<TargetedAnimation> onAnimationEndObservable
        {
            get
            {
                if (__onAnimationEndObservable == null)
                {
                    __onAnimationEndObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<TargetedAnimation>
                    >(
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
                EventHorizonBlazorInterop.Set(this.___guid, "onAnimationEndObservable", value);
            }
        }

        private Observable<TargetedAnimation> __onAnimationLoopObservable;
        public Observable<TargetedAnimation> onAnimationLoopObservable
        {
            get
            {
                if (__onAnimationLoopObservable == null)
                {
                    __onAnimationLoopObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<TargetedAnimation>
                    >(
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
                EventHorizonBlazorInterop.Set(this.___guid, "onAnimationLoopObservable", value);
            }
        }

        private Observable<AnimationGroup> __onAnimationGroupLoopObservable;
        public Observable<AnimationGroup> onAnimationGroupLoopObservable
        {
            get
            {
                if (__onAnimationGroupLoopObservable == null)
                {
                    __onAnimationGroupLoopObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AnimationGroup>
                    >(
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
                if (__onAnimationGroupEndObservable == null)
                {
                    __onAnimationGroupEndObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AnimationGroup>
                    >(
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
                EventHorizonBlazorInterop.Set(this.___guid, "onAnimationGroupEndObservable", value);
            }
        }

        private Observable<AnimationGroup> __onAnimationGroupPauseObservable;
        public Observable<AnimationGroup> onAnimationGroupPauseObservable
        {
            get
            {
                if (__onAnimationGroupPauseObservable == null)
                {
                    __onAnimationGroupPauseObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AnimationGroup>
                    >(
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
                if (__onAnimationGroupPlayObservable == null)
                {
                    __onAnimationGroupPlayObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AnimationGroup>
                    >(
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

        public CachedEntity metadata
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "metadata",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "metadata", value);
            }
        }
        #endregion

        #region Constructor
        public AnimationGroup()
            : base() { }

        public AnimationGroup(ICachedEntity entity)
            : base(entity) { }

        public AnimationGroup(
            string name,
            Scene scene = null,
            System.Nullable<decimal> weight = null,
            System.Nullable<decimal> playOrder = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AnimationGroup" },
                name,
                scene,
                weight,
                playOrder
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void syncWithMask(System.Nullable<bool> forceUpdate = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "syncWithMask" }, forceUpdate }
            );
        }

        public void removeUnmaskedAnimations()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeUnmaskedAnimations" } }
            );
        }

        public decimal getLength(
            System.Nullable<decimal> from = null,
            System.Nullable<decimal> to = null
        )
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getLength" }, from, to }
            );
        }

        public TargetedAnimation addTargetedAnimation(Animation animation, object target)
        {
            return EventHorizonBlazorInterop.FuncClass<TargetedAnimation>(
                entity => new TargetedAnimation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addTargetedAnimation" },
                    animation,
                    target
                }
            );
        }

        public void removeTargetedAnimation(Animation animation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeTargetedAnimation" }, animation }
            );
        }

        public AnimationGroup normalize(
            System.Nullable<decimal> beginFrame = null,
            System.Nullable<decimal> endFrame = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalize" }, beginFrame, endFrame }
            );
        }

        public AnimationGroup start(
            System.Nullable<bool> loop = null,
            System.Nullable<decimal> speedRatio = null,
            System.Nullable<decimal> from = null,
            System.Nullable<decimal> to = null,
            System.Nullable<bool> isAdditive = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "start" },
                    loop,
                    speedRatio,
                    from,
                    to,
                    isAdditive
                }
            );
        }

        public AnimationGroup pause()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "pause" } }
            );
        }

        public AnimationGroup play(System.Nullable<bool> loop = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "play" }, loop }
            );
        }

        public AnimationGroup reset()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }

        public AnimationGroup restart()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "restart" } }
            );
        }

        public AnimationGroup stop()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "stop" } }
            );
        }

        public AnimationGroup setWeightForAllAnimatables(decimal weight)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setWeightForAllAnimatables" }, weight }
            );
        }

        public AnimationGroup syncAllAnimationsWith(Animatable root)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "syncAllAnimationsWith" }, root }
            );
        }

        public AnimationGroup goToFrame(decimal frame)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "goToFrame" }, frame }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public AnimationGroup clone(
            string newName,
            ActionResultCallback<object, CachedEntity> targetConverter = null,
            System.Nullable<bool> cloneAnimations = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" },
                    newName,
                    targetConverter,
                    cloneAnimations
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "toString" }, fullDetails }
            );
        }
        #endregion
    }
}
