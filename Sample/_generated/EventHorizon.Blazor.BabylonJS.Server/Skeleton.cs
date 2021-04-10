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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Skeleton>))]
    public class Skeleton : CachedEntityObject, IAnimatable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Skeleton> MakeAnimationAdditive(Skeleton skeleton, string range, System.Nullable<decimal> referenceFrame = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Skeleton", "MakeAnimationAdditive" }, skeleton, referenceFrame, range
                }
            );
        }

        public static async ValueTask<Skeleton> Parse(object parsedSkeleton, Scene scene)
        {
            return await EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Skeleton", "Parse" }, parsedSkeleton, scene
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_useTextureToStoreBoneMatrices()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useTextureToStoreBoneMatrices"
                );
        }
        public ValueTask set_useTextureToStoreBoneMatrices(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useTextureToStoreBoneMatrices",
                    value
                );
        }

        private AnimationPropertiesOverride __animationPropertiesOverride;
        public async ValueTask<AnimationPropertiesOverride> get_animationPropertiesOverride()
        {
            if(__animationPropertiesOverride == null)
            {
                __animationPropertiesOverride = await EventHorizonBlazorInterop.GetClass<AnimationPropertiesOverride>(
                    this.___guid,
                    "animationPropertiesOverride",
                    (entity) =>
                    {
                        return new AnimationPropertiesOverride() { ___guid = entity.___guid };
                    }
                );
            }
            return __animationPropertiesOverride;
        }
        public ValueTask set_animationPropertiesOverride(AnimationPropertiesOverride value)
        {
__animationPropertiesOverride = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationPropertiesOverride",
                    value
                );
        }

        
        public async ValueTask<bool> get_isUsingTextureForMatrices()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUsingTextureForMatrices"
                );
        }

        
        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
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

        
        public async ValueTask<string> get_id()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
        }
        public ValueTask set_id(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
        }

        
        public async ValueTask<Bone[]> get_bones()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Bone>(
                    this.___guid,
                    "bones",
                    (entity) =>
                    {
                        return new Bone() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_bones(Bone[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bones",
                    value
                );
        }

        private Vector3 __dimensionsAtRest;
        public async ValueTask<Vector3> get_dimensionsAtRest()
        {
            if(__dimensionsAtRest == null)
            {
                __dimensionsAtRest = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "dimensionsAtRest",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __dimensionsAtRest;
        }
        public ValueTask set_dimensionsAtRest(Vector3 value)
        {
__dimensionsAtRest = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dimensionsAtRest",
                    value
                );
        }

        
        public async ValueTask<bool> get_needInitialSkinMatrix()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "needInitialSkinMatrix"
                );
        }
        public ValueTask set_needInitialSkinMatrix(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "needInitialSkinMatrix",
                    value
                );
        }

        private AbstractMesh __overrideMesh;
        public async ValueTask<AbstractMesh> get_overrideMesh()
        {
            if(__overrideMesh == null)
            {
                __overrideMesh = await EventHorizonBlazorInterop.GetClass<AbstractMesh>(
                    this.___guid,
                    "overrideMesh",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __overrideMesh;
        }
        public ValueTask set_overrideMesh(AbstractMesh value)
        {
__overrideMesh = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "overrideMesh",
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

        
        public async ValueTask<bool> get_doNotSerialize()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotSerialize"
                );
        }
        public ValueTask set_doNotSerialize(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotSerialize",
                    value
                );
        }

        
        public async ValueTask<IInspectableCachedEntity[]> get_inspectableCustomProperties()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<IInspectableCachedEntity>(
                    this.___guid,
                    "inspectableCustomProperties",
                    (entity) =>
                    {
                        return new IInspectableCachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_inspectableCustomProperties(IInspectableCachedEntity[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inspectableCustomProperties",
                    value
                );
        }

        private Observable<Skeleton> __onBeforeComputeObservable;
        public async ValueTask<Observable<Skeleton>> get_onBeforeComputeObservable()
        {
            if(__onBeforeComputeObservable == null)
            {
                __onBeforeComputeObservable = await EventHorizonBlazorInterop.GetClass<Observable<Skeleton>>(
                    this.___guid,
                    "onBeforeComputeObservable",
                    (entity) =>
                    {
                        return new Observable<Skeleton>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeComputeObservable;
        }
        public ValueTask set_onBeforeComputeObservable(Observable<Skeleton> value)
        {
__onBeforeComputeObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeComputeObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Skeleton() : base() { }

        public Skeleton(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Skeleton> NewSkeleton(
            string name, string id, Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Skeleton" },
                name, id, scene
            );

            return new Skeleton(entity);
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

        public async ValueTask<Bone[]> getChildren()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildren" }
                }
            );
        }

        public async ValueTask<decimal[]> getTransformMatrices(AbstractMesh mesh)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTransformMatrices" }, mesh
                }
            );
        }

        public async ValueTask<RawTexture> getTransformMatrixTexture(AbstractMesh mesh)
        {
            return await EventHorizonBlazorInterop.FuncClass<RawTexture>(
                entity => new RawTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTransformMatrixTexture" }, mesh
                }
            );
        }

        public async ValueTask<Scene> getScene()
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
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

        public async ValueTask<decimal> getBoneIndexByName(string name)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getBoneIndexByName" }, name
                }
            );
        }

        public async ValueTask createAnimationRange(string name, decimal from, decimal to)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "createAnimationRange" }, name, from, to
                }
            );
        }

        public async ValueTask deleteAnimationRange(string name, System.Nullable<bool> deleteFrames = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "deleteAnimationRange" }, name, deleteFrames
                }
            );
        }

        public async ValueTask<AnimationRange> getAnimationRange(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationRange>(
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAnimationRange" }, name
                }
            );
        }

        public async ValueTask<AnimationRange[]> getAnimationRanges()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<AnimationRange>(
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimationRanges" }
                }
            );
        }

        public async ValueTask<bool> copyAnimationRange(Skeleton source, string name, System.Nullable<bool> rescaleAsRequired = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "copyAnimationRange" }, source, name, rescaleAsRequired
                }
            );
        }

        public async ValueTask returnToRest()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "returnToRest" }
                }
            );
        }

        public async ValueTask<Animatable> beginAnimation(string name, System.Nullable<bool> loop = null, System.Nullable<decimal> speedRatio = null, ActionCallback onAnimationEnd = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "beginAnimation" }, name, loop, speedRatio, onAnimationEnd
                }
            );
        }

        public async ValueTask prepare()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepare" }
                }
            );
        }

        public async ValueTask<IAnimatableCachedEntity[]> getAnimatables()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<IAnimatableCachedEntity>(
                entity => new IAnimatableCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimatables" }
                }
            );
        }

        public async ValueTask<Skeleton> clone(string name, string id = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, id
                }
            );
        }

        public async ValueTask enableBlending(System.Nullable<decimal> blendingSpeed = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enableBlending" }, blendingSpeed
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

        public async ValueTask computeAbsoluteTransforms(System.Nullable<bool> forceUpdate = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "computeAbsoluteTransforms" }, forceUpdate
                }
            );
        }

        public async ValueTask<Matrix> getPoseMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getPoseMatrix" }
                }
            );
        }

        public async ValueTask sortBones()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "sortBones" }
                }
            );
        }

        public async ValueTask setCurrentPoseAsRest()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setCurrentPoseAsRest" }
                }
            );
        }
        #endregion
    }
}