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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationGroup>))]
    public class AnimationGroup : CachedEntityObject, _IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<AnimationGroup> Parse(object parsedAnimationGroup, Scene scene)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "AnimationGroup", "Parse" }, parsedAnimationGroup, scene
                }
            );
        }

        public static async ValueTask<AnimationGroup> MakeAnimationAdditive(AnimationGroup sourceAnimationGroup, System.Nullable<decimal> referenceFrame = null, string range = null, System.Nullable<bool> cloneOriginal = null, string clonedName = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "AnimationGroup", "MakeAnimationAdditive" }, sourceAnimationGroup, referenceFrame, range, cloneOriginal, clonedName
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_from()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "from"
                );
        }

        
        public async ValueTask<decimal> get_to()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "to"
                );
        }

        
        public async ValueTask<bool> get_isStarted()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isStarted"
                );
        }

        
        public async ValueTask<bool> get_isPlaying()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPlaying"
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

        private Observable<TargetedAnimation> __onAnimationEndObservable;
        public async ValueTask<Observable<TargetedAnimation>> get_onAnimationEndObservable()
        {
            if(__onAnimationEndObservable == null)
            {
                __onAnimationEndObservable = await EventHorizonBlazorInterop.GetClass<Observable<TargetedAnimation>>(
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
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAnimationEndObservable",
                    value
                );
        }

        private Observable<TargetedAnimation> __onAnimationLoopObservable;
        public async ValueTask<Observable<TargetedAnimation>> get_onAnimationLoopObservable()
        {
            if(__onAnimationLoopObservable == null)
            {
                __onAnimationLoopObservable = await EventHorizonBlazorInterop.GetClass<Observable<TargetedAnimation>>(
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
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAnimationLoopObservable",
                    value
                );
        }

        private Observable<AnimationGroup> __onAnimationGroupLoopObservable;
        public async ValueTask<Observable<AnimationGroup>> get_onAnimationGroupLoopObservable()
        {
            if(__onAnimationGroupLoopObservable == null)
            {
                __onAnimationGroupLoopObservable = await EventHorizonBlazorInterop.GetClass<Observable<AnimationGroup>>(
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
            if(__onAnimationGroupEndObservable == null)
            {
                __onAnimationGroupEndObservable = await EventHorizonBlazorInterop.GetClass<Observable<AnimationGroup>>(
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
            if(__onAnimationGroupPauseObservable == null)
            {
                __onAnimationGroupPauseObservable = await EventHorizonBlazorInterop.GetClass<Observable<AnimationGroup>>(
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
            if(__onAnimationGroupPlayObservable == null)
            {
                __onAnimationGroupPlayObservable = await EventHorizonBlazorInterop.GetClass<Observable<AnimationGroup>>(
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
        #endregion
        
        #region Constructor
        public AnimationGroup() : base() { }

        public AnimationGroup(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<AnimationGroup> NewAnimationGroup(
            string name, Scene scene = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AnimationGroup" },
                name, scene
            );

            return new AnimationGroup(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<TargetedAnimation> addTargetedAnimation(Animation animation, object target)
        {
            return await EventHorizonBlazorInterop.FuncClass<TargetedAnimation>(
                entity => new TargetedAnimation() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addTargetedAnimation" }, animation, target
                }
            );
        }

        public async ValueTask<AnimationGroup> normalize(System.Nullable<decimal> beginFrame = null, System.Nullable<decimal> endFrame = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "normalize" }, beginFrame, endFrame
                }
            );
        }

        public async ValueTask<AnimationGroup> start(System.Nullable<bool> loop = null, System.Nullable<decimal> speedRatio = null, System.Nullable<decimal> from = null, System.Nullable<decimal> to = null, System.Nullable<bool> isAdditive = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "start" }, loop, speedRatio, from, to, isAdditive
                }
            );
        }

        public async ValueTask<AnimationGroup> pause()
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "pause" }
                }
            );
        }

        public async ValueTask<AnimationGroup> play(System.Nullable<bool> loop = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "play" }, loop
                }
            );
        }

        public async ValueTask<AnimationGroup> reset()
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public async ValueTask<AnimationGroup> restart()
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "restart" }
                }
            );
        }

        public async ValueTask<AnimationGroup> stop()
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public async ValueTask<AnimationGroup> setWeightForAllAnimatables(decimal weight)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setWeightForAllAnimatables" }, weight
                }
            );
        }

        public async ValueTask<AnimationGroup> syncAllAnimationsWith(Animatable root)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "syncAllAnimationsWith" }, root
                }
            );
        }

        public async ValueTask<AnimationGroup> goToFrame(decimal frame)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "goToFrame" }, frame
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

        public async ValueTask<AnimationGroup> clone(string newName, ActionCallback<object> targetConverter = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, newName, targetConverter
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

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<string> toString(System.Nullable<bool> fullDetails = null)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }
        #endregion
    }
}