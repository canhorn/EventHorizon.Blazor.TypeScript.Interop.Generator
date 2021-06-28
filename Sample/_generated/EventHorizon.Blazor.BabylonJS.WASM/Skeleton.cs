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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Skeleton>))]
    public class Skeleton : CachedEntityObject, IAnimatable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Skeleton MakeAnimationAdditive(Skeleton skeleton, string range, System.Nullable<decimal> referenceFrame = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Skeleton", "MakeAnimationAdditive" }, skeleton, referenceFrame, range
                }
            );
        }

        public static Skeleton Parse(object parsedSkeleton, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Skeleton", "Parse" }, parsedSkeleton, scene
                }
            );
        }
        #endregion

        #region Accessors
        
        public bool useTextureToStoreBoneMatrices
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useTextureToStoreBoneMatrices"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useTextureToStoreBoneMatrices",
                    value
                );
            }
        }

        private AnimationPropertiesOverride __animationPropertiesOverride;
        public AnimationPropertiesOverride animationPropertiesOverride
        {
            get
            {
            if(__animationPropertiesOverride == null)
            {
                __animationPropertiesOverride = EventHorizonBlazorInterop.GetClass<AnimationPropertiesOverride>(
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
            set
            {
__animationPropertiesOverride = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationPropertiesOverride",
                    value
                );
            }
        }

        
        public bool isUsingTextureForMatrices
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUsingTextureForMatrices"
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

        
        public string id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        
        public Bone[] bones
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Bone>(
                    this.___guid,
                    "bones",
                    (entity) =>
                    {
                        return new Bone() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bones",
                    value
                );
            }
        }

        private Vector3 __dimensionsAtRest;
        public Vector3 dimensionsAtRest
        {
            get
            {
            if(__dimensionsAtRest == null)
            {
                __dimensionsAtRest = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__dimensionsAtRest = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dimensionsAtRest",
                    value
                );
            }
        }

        
        public bool needInitialSkinMatrix
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "needInitialSkinMatrix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "needInitialSkinMatrix",
                    value
                );
            }
        }

        private AbstractMesh __overrideMesh;
        public AbstractMesh overrideMesh
        {
            get
            {
            if(__overrideMesh == null)
            {
                __overrideMesh = EventHorizonBlazorInterop.GetClass<AbstractMesh>(
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
            set
            {
__overrideMesh = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "overrideMesh",
                    value
                );
            }
        }

        
        public Animation[] animations
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
            }
        }

        
        public bool doNotSerialize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotSerialize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotSerialize",
                    value
                );
            }
        }

        
        public IInspectableCachedEntity[] inspectableCustomProperties
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IInspectableCachedEntity>(
                    this.___guid,
                    "inspectableCustomProperties",
                    (entity) =>
                    {
                        return new IInspectableCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inspectableCustomProperties",
                    value
                );
            }
        }

        private Observable<Skeleton> __onBeforeComputeObservable;
        public Observable<Skeleton> onBeforeComputeObservable
        {
            get
            {
            if(__onBeforeComputeObservable == null)
            {
                __onBeforeComputeObservable = EventHorizonBlazorInterop.GetClass<Observable<Skeleton>>(
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
            set
            {
__onBeforeComputeObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeComputeObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Skeleton() : base() { }

        public Skeleton(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Skeleton(
            string name, string id, Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Skeleton" },
                name, id, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public Bone[] getChildren()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildren" }
                }
            );
        }

        public decimal[] getTransformMatrices(AbstractMesh mesh)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTransformMatrices" }, mesh
                }
            );
        }

        public RawTexture getTransformMatrixTexture(AbstractMesh mesh)
        {
            return EventHorizonBlazorInterop.FuncClass<RawTexture>(
                entity => new RawTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformMatrixTexture" }, mesh
                }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getScene" }
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

        public decimal getBoneIndexByName(string name)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getBoneIndexByName" }, name
                }
            );
        }

        public void createAnimationRange(string name, decimal from, decimal to)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createAnimationRange" }, name, from, to
                }
            );
        }

        public void deleteAnimationRange(string name, System.Nullable<bool> deleteFrames = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteAnimationRange" }, name, deleteFrames
                }
            );
        }

        public AnimationRange getAnimationRange(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationRange>(
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimationRange" }, name
                }
            );
        }

        public AnimationRange[] getAnimationRanges()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationRange>(
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimationRanges" }
                }
            );
        }

        public bool copyAnimationRange(Skeleton source, string name, System.Nullable<bool> rescaleAsRequired = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "copyAnimationRange" }, source, name, rescaleAsRequired
                }
            );
        }

        public void returnToRest()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "returnToRest" }
                }
            );
        }

        public Animatable beginAnimation(string name, System.Nullable<bool> loop = null, System.Nullable<decimal> speedRatio = null, ActionCallback onAnimationEnd = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "beginAnimation" }, name, loop, speedRatio, onAnimationEnd
                }
            );
        }

        public void prepare()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepare" }
                }
            );
        }

        public IAnimatableCachedEntity[] getAnimatables()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<IAnimatableCachedEntity>(
                entity => new IAnimatableCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimatables" }
                }
            );
        }

        public Skeleton clone(string name, string id = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, name, id
                }
            );
        }

        public void enableBlending(System.Nullable<decimal> blendingSpeed = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enableBlending" }, blendingSpeed
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

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public void computeAbsoluteTransforms(System.Nullable<bool> forceUpdate = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "computeAbsoluteTransforms" }, forceUpdate
                }
            );
        }

        public Matrix getPoseMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPoseMatrix" }
                }
            );
        }

        public void sortBones()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sortBones" }
                }
            );
        }

        public void setCurrentPoseAsRest()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCurrentPoseAsRest" }
                }
            );
        }
        #endregion
    }
}