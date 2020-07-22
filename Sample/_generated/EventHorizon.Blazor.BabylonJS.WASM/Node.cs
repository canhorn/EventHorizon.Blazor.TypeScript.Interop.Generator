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
    public class Node : CachedEntityObject, IBehaviorAware<Node>
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void AddNodeConstructor(string type, NodeConstructor constructorFunc)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Node", "AddNodeConstructor" }, type, constructorFunc
                }
            );
        }

        public static CachedEntity Construct(string type, string name, Scene scene, object options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Node", "Construct" }, type, name, scene, options
                }
            );
        }

        public static void ParseAnimationRanges(Node node, object parsedNode, Scene scene)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Node", "ParseAnimationRanges" }, node, parsedNode, scene
                }
            );
        }
        #endregion

        #region Accessors
        
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

        private Node __parent;
        public Node parent
        {
            get
            {
            if(__parent == null)
            {
                __parent = EventHorizonBlazorInteropt.GetClass<Node>(
                    this.___guid,
                    "parent",
                    (entity) =>
                    {
                        return new Node() { ___guid = entity.___guid };
                    }
                );
            }
            return __parent;
            }
            set
            {
__parent = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "parent",
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
                        return new AnimationPropertiesOverride() { ___guid = entity.___guid };
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

        
        public BehaviorCachedEntity<Node>[] behaviors
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<BehaviorCachedEntity<Node>>(
                    this.___guid,
                    "behaviors",
                    (entity) =>
                    {
                        return new BehaviorCachedEntity<Node>() { ___guid = entity.___guid };
                    }
                );
            }
        }

        private Matrix __worldMatrixFromCache;
        public Matrix worldMatrixFromCache
        {
            get
            {
            if(__worldMatrixFromCache == null)
            {
                __worldMatrixFromCache = EventHorizonBlazorInteropt.GetClass<Matrix>(
                    this.___guid,
                    "worldMatrixFromCache",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __worldMatrixFromCache;
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

        
        public string state
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "state"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "state",
                    value
                );
            }
        }

        
        public CachedEntity metadata
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "metadata"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "metadata",
                    value
                );
            }
        }

        
        public CachedEntity reservedDataStore
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "reservedDataStore"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "reservedDataStore",
                    value
                );
            }
        }

        
        public IInspectableCachedEntity[] inspectableCustomProperties
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<IInspectableCachedEntity>(
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

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "inspectableCustomProperties",
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
                        return new Animation() { ___guid = entity.___guid };
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

        
        public CachedEntity onReady
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "onReady"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onReady",
                    value
                );
            }
        }

        private Observable<Node> __onDisposeObservable;
        public Observable<Node> onDisposeObservable
        {
            get
            {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = EventHorizonBlazorInteropt.GetClass<Observable<Node>>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable<Node>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onDisposeObservable;
            }
            set
            {
__onDisposeObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Node() : base() { }

        public Node(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Node(
            string name, Scene scene = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Node" },
                name, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isDisposed()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isDisposed" }
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

        public Scene getScene()
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        public Engine getEngine()
        {
            return EventHorizonBlazorInteropt.FuncClass<Engine>(
                entity => new Engine() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEngine" }
                }
            );
        }

        public Node addBehavior(BehaviorCachedEntity<Node> behavior, System.Nullable<bool> attachImmediately = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addBehavior" }, behavior, attachImmediately
                }
            );
        }

        public Node removeBehavior(BehaviorCachedEntity<Node> behavior)
        {
            return EventHorizonBlazorInteropt.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeBehavior" }, behavior
                }
            );
        }

        public BehaviorCachedEntity<Node> getBehaviorByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<BehaviorCachedEntity<Node>>(
                entity => new BehaviorCachedEntity<Node>() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getBehaviorByName" }, name
                }
            );
        }

        public Matrix getWorldMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getWorldMatrix" }
                }
            );
        }

        public void updateCache(System.Nullable<bool> force = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateCache" }, force
                }
            );
        }

        public bool isSynchronizedWithParent()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isSynchronizedWithParent" }
                }
            );
        }

        public bool isSynchronized()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isSynchronized" }
                }
            );
        }

        public bool isReady(System.Nullable<bool> completeCheck = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, completeCheck
                }
            );
        }

        public bool isEnabled(System.Nullable<bool> checkAncestors = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isEnabled" }, checkAncestors
                }
            );
        }

        public void setEnabled(bool value)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setEnabled" }, value
                }
            );
        }

        public bool isDescendantOf(Node ancestor)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isDescendantOf" }, ancestor
                }
            );
        }

// getDescendants is not supported by the platform yet

// getChildMeshes is not supported by the platform yet

        #region getChildren TODO: Get Comments as metadata identification
        private bool _isGetChildrenEnabled = false;
        private readonly IDictionary<string, Func<Node, Task>> _getChildrenActionMap = new Dictionary<string, Func<Node, Task>>();

        public string getChildren(
            Func<Node, Task> callback
        )
        {
            SetupGetChildrenLoop();

            var handle = Guid.NewGuid().ToString();
            _getChildrenActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupGetChildrenLoop()
        {
            if (_isGetChildrenEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "getChildren",
                "CallGetChildrenActions",
                _invokableReference
            );
            _isGetChildrenEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetChildrenActions(Node node)
        {
            foreach (var action in _getChildrenActionMap.Values)
            {
                await action(node);
            }
        }
        #endregion

        public Animation getAnimationByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAnimationByName" }, name
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
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAnimationRange" }, name
                }
            );
        }

        public AnimationRange[] getAnimationRanges()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<AnimationRange>(
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimationRanges" }
                }
            );
        }

// beginAnimation is not supported by the platform yet

        public CachedEntity serializeAnimationRanges()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serializeAnimationRanges" }
                }
            );
        }

        public Matrix computeWorldMatrix(System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "computeWorldMatrix" }, force
                }
            );
        }

        public void dispose(System.Nullable<bool> doNotRecurse = null, System.Nullable<bool> disposeMaterialAndTextures = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, doNotRecurse, disposeMaterialAndTextures
                }
            );
        }

        public CachedEntity getHierarchyBoundingVectors(System.Nullable<bool> includeDescendants = null, CachedEntity predicate = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getHierarchyBoundingVectors" }, includeDescendants, predicate
                }
            );
        }
        #endregion
    }
}