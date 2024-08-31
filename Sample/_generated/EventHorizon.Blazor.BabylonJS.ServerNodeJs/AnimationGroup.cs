/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<AnimationGroup>))]
    public class AnimationGroup : CachedEntityObject, _IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<AnimationGroup> MergeAnimationGroups(
            AnimationGroup[] animationGroups,
            System.Nullable<bool> disposeSource = null,
            System.Nullable<bool> normalize = null,
            System.Nullable<decimal> weight = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
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

        public static async ValueTask<AnimationGroup> Parse(
            object parsedAnimationGroup,
            Scene scene
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "AnimationGroup", "Parse" },
                    parsedAnimationGroup,
                    scene
                }
            );
        }

        public static async ValueTask<AnimationGroup> MakeAnimationAdditive(
            AnimationGroup sourceAnimationGroup,
            decimal referenceFrame,
            string range = null,
            System.Nullable<bool> cloneOriginal = null,
            string clonedName = null,
            IMakeAnimationGroupAdditiveOptions options = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
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

        public static async ValueTask<AnimationGroup> ClipKeys(
            AnimationGroup sourceAnimationGroup,
            decimal fromKey,
            decimal toKey,
            string name = null,
            System.Nullable<bool> dontCloneAnimations = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
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

        public static async ValueTask<AnimationGroup> ClipKeysInPlace(
            AnimationGroup animationGroup,
            decimal fromKey,
            decimal toKey,
            System.Nullable<bool> dontCloneAnimations = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
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

        public static async ValueTask<AnimationGroup> ClipFrames(
            AnimationGroup sourceAnimationGroup,
            decimal fromFrame,
            decimal toFrame,
            string name = null,
            System.Nullable<bool> dontCloneAnimations = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
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

        public static async ValueTask<AnimationGroup> ClipFramesInPlace(
            AnimationGroup animationGroup,
            decimal fromFrame,
            decimal toFrame,
            System.Nullable<bool> dontCloneAnimations = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
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

        public static async ValueTask<AnimationGroup> ClipInPlace(
            AnimationGroup animationGroup,
            decimal start,
            decimal end,
            System.Nullable<bool> dontCloneAnimations = null,
            System.Nullable<bool> useFrame = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
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

        public async ValueTask<AnimationGroupMask> get_mask()
        {
            if (__mask == null)
            {
                __mask = await EventHorizonBlazorInterop.GetClass<AnimationGroupMask>(
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

        public ValueTask set_mask(AnimationGroupMask value)
        {
            __mask = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "mask", value);
        }

        public async ValueTask<decimal> get_from()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "from");
        }

        public ValueTask set_from(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "from", value);
        }

        public async ValueTask<decimal> get_to()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "to");
        }

        public ValueTask set_to(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "to", value);
        }

        public async ValueTask<bool> get_isStarted()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isStarted");
        }

        public async ValueTask<bool> get_isPlaying()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isPlaying");
        }

        public async ValueTask<decimal> get_speedRatio()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "speedRatio");
        }

        public ValueTask set_speedRatio(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "speedRatio", value);
        }

        public async ValueTask<bool> get_loopAnimation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "loopAnimation");
        }

        public ValueTask set_loopAnimation(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "loopAnimation", value);
        }

        public async ValueTask<bool> get_isAdditive()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isAdditive");
        }

        public ValueTask set_isAdditive(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isAdditive", value);
        }

        public async ValueTask<decimal> get_weight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "weight");
        }

        public ValueTask set_weight(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "weight", value);
        }

        public async ValueTask<TargetedAnimation[]> get_targetedAnimations()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<TargetedAnimation>(
                this.___guid,
                "targetedAnimations",
                (entity) =>
                {
                    return new TargetedAnimation() { ___guid = entity.___guid };
                }
            );
        }

        public async ValueTask<Animatable[]> get_animatables()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Animatable>(
                this.___guid,
                "animatables",
                (entity) =>
                {
                    return new Animatable() { ___guid = entity.___guid };
                }
            );
        }

        public async ValueTask<TargetedAnimation[]> get_children()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<TargetedAnimation>(
                this.___guid,
                "children",
                (entity) =>
                {
                    return new TargetedAnimation() { ___guid = entity.___guid };
                }
            );
        }

        public async ValueTask<decimal> get_playOrder()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "playOrder");
        }

        public ValueTask set_playOrder(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "playOrder", value);
        }

        public async ValueTask<bool> get_enableBlending()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "enableBlending");
        }

        public ValueTask set_enableBlending(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "enableBlending", value);
        }

        public async ValueTask<decimal> get_blendingSpeed()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "blendingSpeed");
        }

        public ValueTask set_blendingSpeed(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "blendingSpeed", value);
        }
        #endregion

        #region Properties

        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "name");
        }

        public ValueTask set_name(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "name", value);
        }

        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "uniqueId");
        }

        public ValueTask set_uniqueId(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "uniqueId", value);
        }

        private Observable<TargetedAnimation> __onAnimationEndObservable;

        public async ValueTask<Observable<TargetedAnimation>> get_onAnimationEndObservable()
        {
            if (__onAnimationEndObservable == null)
            {
                __onAnimationEndObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onAnimationEndObservable(Observable<TargetedAnimation> value)
        {
            __onAnimationEndObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onAnimationEndObservable", value);
        }

        private Observable<TargetedAnimation> __onAnimationLoopObservable;

        public async ValueTask<Observable<TargetedAnimation>> get_onAnimationLoopObservable()
        {
            if (__onAnimationLoopObservable == null)
            {
                __onAnimationLoopObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onAnimationLoopObservable(Observable<TargetedAnimation> value)
        {
            __onAnimationLoopObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onAnimationLoopObservable", value);
        }

        private Observable<AnimationGroup> __onAnimationGroupLoopObservable;

        public async ValueTask<Observable<AnimationGroup>> get_onAnimationGroupLoopObservable()
        {
            if (__onAnimationGroupLoopObservable == null)
            {
                __onAnimationGroupLoopObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onAnimationGroupLoopObservable(Observable<AnimationGroup> value)
        {
            __onAnimationGroupLoopObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onAnimationGroupLoopObservable",
                value
            );
        }

        private Observable<AnimationGroup> __onAnimationGroupEndObservable;

        public async ValueTask<Observable<AnimationGroup>> get_onAnimationGroupEndObservable()
        {
            if (__onAnimationGroupEndObservable == null)
            {
                __onAnimationGroupEndObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onAnimationGroupEndObservable(Observable<AnimationGroup> value)
        {
            __onAnimationGroupEndObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onAnimationGroupEndObservable",
                value
            );
        }

        private Observable<AnimationGroup> __onAnimationGroupPauseObservable;

        public async ValueTask<Observable<AnimationGroup>> get_onAnimationGroupPauseObservable()
        {
            if (__onAnimationGroupPauseObservable == null)
            {
                __onAnimationGroupPauseObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onAnimationGroupPauseObservable(Observable<AnimationGroup> value)
        {
            __onAnimationGroupPauseObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onAnimationGroupPauseObservable",
                value
            );
        }

        private Observable<AnimationGroup> __onAnimationGroupPlayObservable;

        public async ValueTask<Observable<AnimationGroup>> get_onAnimationGroupPlayObservable()
        {
            if (__onAnimationGroupPlayObservable == null)
            {
                __onAnimationGroupPlayObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onAnimationGroupPlayObservable(Observable<AnimationGroup> value)
        {
            __onAnimationGroupPlayObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onAnimationGroupPlayObservable",
                value
            );
        }

        public async ValueTask<CachedEntity> get_metadata()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "metadata",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_metadata(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "metadata", value);
        }
        #endregion

        #region Constructor
        public AnimationGroup()
            : base() { }

        public AnimationGroup(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<AnimationGroup> NewAnimationGroup(
            string name,
            Scene scene = null,
            System.Nullable<decimal> weight = null,
            System.Nullable<decimal> playOrder = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AnimationGroup" },
                name,
                scene,
                weight,
                playOrder
            );

            return new AnimationGroup(entity);
        }
        #endregion

        #region Methods
        public async ValueTask syncWithMask(System.Nullable<bool> forceUpdate = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "syncWithMask" }, forceUpdate }
            );
        }

        public async ValueTask removeUnmaskedAnimations()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeUnmaskedAnimations" } }
            );
        }

        public async ValueTask<decimal> getLength(
            System.Nullable<decimal> from = null,
            System.Nullable<decimal> to = null
        )
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getLength" }, from, to }
            );
        }

        public async ValueTask<TargetedAnimation> addTargetedAnimation(
            Animation animation,
            object target
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<TargetedAnimation>(
                entity => new TargetedAnimation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addTargetedAnimation" },
                    animation,
                    target
                }
            );
        }

        public async ValueTask removeTargetedAnimation(Animation animation)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeTargetedAnimation" }, animation }
            );
        }

        public async ValueTask<AnimationGroup> normalize(
            System.Nullable<decimal> beginFrame = null,
            System.Nullable<decimal> endFrame = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalize" }, beginFrame, endFrame }
            );
        }

        public async ValueTask<AnimationGroup> start(
            System.Nullable<bool> loop = null,
            System.Nullable<decimal> speedRatio = null,
            System.Nullable<decimal> from = null,
            System.Nullable<decimal> to = null,
            System.Nullable<bool> isAdditive = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
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

        public async ValueTask<AnimationGroup> pause()
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "pause" } }
            );
        }

        public async ValueTask<AnimationGroup> play(System.Nullable<bool> loop = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "play" }, loop }
            );
        }

        public async ValueTask<AnimationGroup> reset()
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "reset" } }
            );
        }

        public async ValueTask<AnimationGroup> restart()
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "restart" } }
            );
        }

        public async ValueTask<AnimationGroup> stop()
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "stop" } }
            );
        }

        public async ValueTask<AnimationGroup> setWeightForAllAnimatables(decimal weight)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setWeightForAllAnimatables" }, weight }
            );
        }

        public async ValueTask<AnimationGroup> syncAllAnimationsWith(Animatable root)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "syncAllAnimationsWith" }, root }
            );
        }

        public async ValueTask<AnimationGroup> goToFrame(decimal frame)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "goToFrame" }, frame }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public async ValueTask<AnimationGroup> clone(
            string newName,
            ActionResultCallback<object, CachedEntity> targetConverter = null,
            System.Nullable<bool> cloneAnimations = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
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

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask<string> toString(System.Nullable<bool> fullDetails = null)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "toString" }, fullDetails }
            );
        }
        #endregion
    }
}
