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
    public class Skeleton : CachedEntityObject, IAnimatable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Skeleton Parse(object parsedSkeleton, Scene scene)
        {
            return EventHorizonBlazorInteropt.FuncClass<Skeleton>(
                entity => new Skeleton(entity),
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useTextureToStoreBoneMatrices"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __animationPropertiesOverride = EventHorizonBlazorInteropt.GetClass<AnimationPropertiesOverride>(
                    this.___guid,
                    "animationPropertiesOverride",
                    (entity) =>
                    {
                        return new AnimationPropertiesOverride(entity);
                    }
                );
            }
            return __animationPropertiesOverride;
            }
            set
            {
__animationPropertiesOverride = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isUsingTextureForMatrices"
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

        
        public string id
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<Bone>(
                    this.___guid,
                    "bones",
                    (entity) =>
                    {
                        return new Bone(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __dimensionsAtRest = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "dimensionsAtRest",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __dimensionsAtRest;
            }
            set
            {
__dimensionsAtRest = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "needInitialSkinMatrix"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __overrideMesh = EventHorizonBlazorInteropt.GetClass<AbstractMesh>(
                    this.___guid,
                    "overrideMesh",
                    (entity) =>
                    {
                        return new AbstractMesh(entity);
                    }
                );
            }
            return __overrideMesh;
            }
            set
            {
__overrideMesh = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "doNotSerialize"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "doNotSerialize",
                    value
                );
            }
        }

        
        public IInspectable[] inspectableCustomProperties
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<IInspectable>(
                    this.___guid,
                    "inspectableCustomProperties",
                    (entity) =>
                    {
                        return new IInspectableCachedEntity(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "inspectableCustomProperties",
                    value
                );
            }
        }

        private Observable __onBeforeComputeObservable;
        public Observable onBeforeComputeObservable
        {
            get
            {
            if(__onBeforeComputeObservable == null)
            {
                __onBeforeComputeObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeComputeObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeComputeObservable;
            }
            set
            {
__onBeforeComputeObservable = null;
                EventHorizonBlazorInteropt.Set(
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
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Skeleton" },
                name, id, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public Bone[] getChildren()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<Bone>(
                entity => new Bone(entity),
                new object[]
                {
                    new string[] { this.___guid, "getChildren" }
                }
            );
        }

        public decimal[] getTransformMatrices(AbstractMesh mesh)
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTransformMatrices" }, mesh
                }
            );
        }

        public RawTexture getTransformMatrixTexture(AbstractMesh mesh)
        {
            return EventHorizonBlazorInteropt.FuncClass<RawTexture>(
                entity => new RawTexture(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getTransformMatrixTexture" }, mesh
                }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
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

        public decimal getBoneIndexByName(string name)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getBoneIndexByName" }, name
                }
            );
        }

        public void createAnimationRange(string name, decimal from, decimal to)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "createAnimationRange" }, name, from, to
                }
            );
        }

        public void deleteAnimationRange(string name, System.Nullable<bool> deleteFrames = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "deleteAnimationRange" }, name, deleteFrames
                }
            );
        }

        public AnimationRange getAnimationRange(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationRange>(
                entity => new AnimationRange(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getAnimationRange" }, name
                }
            );
        }

        public AnimationRange[] getAnimationRanges()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<AnimationRange>(
                entity => new AnimationRange(entity),
                new object[]
                {
                    new string[] { this.___guid, "getAnimationRanges" }
                }
            );
        }

        public bool copyAnimationRange(Skeleton source, string name, System.Nullable<bool> rescaleAsRequired = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "copyAnimationRange" }, source, name, rescaleAsRequired
                }
            );
        }

        public void returnToRest()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "returnToRest" }
                }
            );
        }

        #region beginAnimation TODO: Get Comments as metadata identification
        private bool _isBeginAnimationEnabled = false;
        private readonly IDictionary<string, Func<Task>> _beginAnimationActionMap = new Dictionary<string, Func<Task>>();

        public string beginAnimation(
            Func<Task> callback
        )
        {
            SetupBeginAnimationLoop();

            var handle = Guid.NewGuid().ToString();
            _beginAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupBeginAnimationLoop()
        {
            if (_isBeginAnimationEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "beginAnimation",
                "CallBeginAnimationActions",
                _invokableReference
            );
            _isBeginAnimationEnabled = true;
        }

        [JSInvokable]
        public async Task CallBeginAnimationActions()
        {
            foreach (var action in _beginAnimationActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void prepare()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepare" }
                }
            );
        }

        public IAnimatable[] getAnimatables()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<IAnimatable>(
                entity => new IAnimatableCachedEntity(entity),
                new object[]
                {
                    new string[] { this.___guid, "getAnimatables" }
                }
            );
        }

        public Skeleton clone(string name, string id = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Skeleton>(
                entity => new Skeleton(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, id
                }
            );
        }

        public void enableBlending(System.Nullable<decimal> blendingSpeed = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enableBlending" }, blendingSpeed
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

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public void computeAbsoluteTransforms(System.Nullable<bool> forceUpdate = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "computeAbsoluteTransforms" }, forceUpdate
                }
            );
        }

        public Matrix getPoseMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getPoseMatrix" }
                }
            );
        }

        public void sortBones()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "sortBones" }
                }
            );
        }
        #endregion
    }
}