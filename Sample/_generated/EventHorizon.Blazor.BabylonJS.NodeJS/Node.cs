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

    [JsonConverter(typeof(CachedEntityConverter<Node>))]
    public class Node : CachedEntityObject, IBehaviorAware<Node>
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void AddNodeConstructor(
            string type,
            ActionResultCallback<
                string,
                Scene,
                CachedEntity,
                ActionResultCallback<Node>
            > constructorFunc
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Node", "AddNodeConstructor" },
                    type,
                    constructorFunc
                }
            );
        }

        public static Node Construct()
        {
            return EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Node", "Construct" } }
            );
        }

        public static void ParseAnimationRanges(Node node, object parsedNode, Scene _scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Node", "ParseAnimationRanges" },
                    node,
                    parsedNode,
                    _scene
                }
            );
        }
        #endregion

        #region Accessors
        private IAccessibilityTagCachedEntity __accessibilityTag;
        public IAccessibilityTagCachedEntity accessibilityTag
        {
            get
            {
                if (__accessibilityTag == null)
                {
                    __accessibilityTag =
                        EventHorizonBlazorInterop.GetClass<IAccessibilityTagCachedEntity>(
                            this.___guid,
                            "accessibilityTag",
                            (entity) =>
                            {
                                return new IAccessibilityTagCachedEntity()
                                {
                                    ___guid = entity.___guid
                                };
                            }
                        );
                }
                return __accessibilityTag;
            }
            set
            {
                __accessibilityTag = null;
                EventHorizonBlazorInterop.Set(this.___guid, "accessibilityTag", value);
            }
        }

        public bool doNotSerialize
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "doNotSerialize"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "doNotSerialize", value);
            }
        }

        private Node __parent;
        public Node parent
        {
            get
            {
                if (__parent == null)
                {
                    __parent = EventHorizonBlazorInterop.GetClass<Node>(
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
                EventHorizonBlazorInterop.Set(this.___guid, "parent", value);
            }
        }

        private AnimationPropertiesOverride __animationPropertiesOverride;
        public AnimationPropertiesOverride animationPropertiesOverride
        {
            get
            {
                if (__animationPropertiesOverride == null)
                {
                    __animationPropertiesOverride =
                        EventHorizonBlazorInterop.GetClass<AnimationPropertiesOverride>(
                            this.___guid,
                            "animationPropertiesOverride",
                            (entity) =>
                            {
                                return new AnimationPropertiesOverride()
                                {
                                    ___guid = entity.___guid
                                };
                            }
                        );
                }
                return __animationPropertiesOverride;
            }
            set
            {
                __animationPropertiesOverride = null;
                EventHorizonBlazorInterop.Set(this.___guid, "animationPropertiesOverride", value);
            }
        }

        private Observable<bool> __onEnabledStateChangedObservable;
        public Observable<bool> onEnabledStateChangedObservable
        {
            get
            {
                if (__onEnabledStateChangedObservable == null)
                {
                    __onEnabledStateChangedObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<bool>
                    >(
                        this.___guid,
                        "onEnabledStateChangedObservable",
                        (entity) =>
                        {
                            return new Observable<bool>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onEnabledStateChangedObservable;
            }
        }

        private Observable<Node> __onClonedObservable;
        public Observable<Node> onClonedObservable
        {
            get
            {
                if (__onClonedObservable == null)
                {
                    __onClonedObservable = EventHorizonBlazorInterop.GetClass<Observable<Node>>(
                        this.___guid,
                        "onClonedObservable",
                        (entity) =>
                        {
                            return new Observable<Node>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onClonedObservable;
            }
        }

        public BehaviorCachedEntity<Node>[] behaviors
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<BehaviorCachedEntity<Node>>(
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
                if (__worldMatrixFromCache == null)
                {
                    __worldMatrixFromCache = EventHorizonBlazorInterop.GetClass<Matrix>(
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
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
            }
        }

        public string id
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "id"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "id", value);
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

        public string state
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "state"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "state", value);
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

        public CachedEntity reservedDataStore
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "reservedDataStore",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "reservedDataStore", value);
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

                EventHorizonBlazorInterop.Set(this.___guid, "inspectableCustomProperties", value);
            }
        }

        private Observable<IAccessibilityTagCachedEntity> __onAccessibilityTagChangedObservable;
        public Observable<IAccessibilityTagCachedEntity> onAccessibilityTagChangedObservable
        {
            get
            {
                if (__onAccessibilityTagChangedObservable == null)
                {
                    __onAccessibilityTagChangedObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<IAccessibilityTagCachedEntity>
                    >(
                        this.___guid,
                        "onAccessibilityTagChangedObservable",
                        (entity) =>
                        {
                            return new Observable<IAccessibilityTagCachedEntity>()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
                }
                return __onAccessibilityTagChangedObservable;
            }
            set
            {
                __onAccessibilityTagChangedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAccessibilityTagChangedObservable",
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

                EventHorizonBlazorInterop.Set(this.___guid, "animations", value);
            }
        }

        public ActionCallback<Node> onReady
        {
            get
            {
                return EventHorizonBlazorInterop.Get<ActionCallback<Node>>(this.___guid, "onReady");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "onReady", value);
            }
        }

        private Observable<Node> __onDisposeObservable;
        public Observable<Node> onDisposeObservable
        {
            get
            {
                if (__onDisposeObservable == null)
                {
                    __onDisposeObservable = EventHorizonBlazorInterop.GetClass<Observable<Node>>(
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
                EventHorizonBlazorInterop.Set(this.___guid, "onDisposeObservable", value);
            }
        }
        #endregion

        #region Constructor
        public Node()
            : base() { }

        public Node(ICachedEntity entity)
            : base(entity) { }

        public Node(string name, Scene scene = null, System.Nullable<bool> isPure = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Node" },
                name,
                scene,
                isPure
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isDisposed()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isDisposed" } }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getScene" } }
            );
        }

        public AbstractEngine getEngine()
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractEngine>(
                entity => new AbstractEngine() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getEngine" } }
            );
        }

        public Node addBehavior(
            Behavior<Node> behavior,
            System.Nullable<bool> attachImmediately = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addBehavior" },
                    behavior,
                    attachImmediately
                }
            );
        }

        public Node removeBehavior(Behavior<Node> behavior)
        {
            return EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "removeBehavior" }, behavior }
            );
        }

        public BehaviorCachedEntity<Node> getBehaviorByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<BehaviorCachedEntity<Node>>(
                entity => new BehaviorCachedEntity<Node>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBehaviorByName" }, name }
            );
        }

        public Matrix getWorldMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getWorldMatrix" } }
            );
        }

        public void updateCache(System.Nullable<bool> force = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateCache" }, force }
            );
        }

        public bool isSynchronizedWithParent()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isSynchronizedWithParent" } }
            );
        }

        public bool isSynchronized()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isSynchronized" } }
            );
        }

        public bool isReady(System.Nullable<bool> _completeCheck = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReady" }, _completeCheck }
            );
        }

        public Node markAsDirty(string _property = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "markAsDirty" }, _property }
            );
        }

        public bool isEnabled(System.Nullable<bool> checkAncestors = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isEnabled" }, checkAncestors }
            );
        }

        public void setEnabled(bool value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setEnabled" }, value }
            );
        }

        public bool isDescendantOf(Node ancestor)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isDescendantOf" }, ancestor }
            );
        }

        public T[] getDescendants<T>(
            System.Nullable<bool> directDescendantsOnly = null,
            ActionResultCallback<Node, T> predicate = null
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDescendants" },
                    directDescendantsOnly,
                    predicate
                }
            );
        }

        public T[] getChildMeshes<T>(
            System.Nullable<bool> directDescendantsOnly = null,
            ActionResultCallback<Node, T> predicate = null
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildMeshes" },
                    directDescendantsOnly,
                    predicate
                }
            );
        }

        public T[] getChildren<T>(
            ActionResultCallback<Node, T> predicate = null,
            System.Nullable<bool> directDescendantsOnly = null
        )
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildren" },
                    predicate,
                    directDescendantsOnly
                }
            );
        }

        public Animation getAnimationByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAnimationByName" }, name }
            );
        }

        public void createAnimationRange(string name, decimal from, decimal to)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createAnimationRange" },
                    name,
                    from,
                    to
                }
            );
        }

        public void deleteAnimationRange(string name, System.Nullable<bool> deleteFrames = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteAnimationRange" },
                    name,
                    deleteFrames
                }
            );
        }

        public AnimationRange getAnimationRange(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationRange>(
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAnimationRange" }, name }
            );
        }

        public Node clone(
            string name,
            Node newParent,
            System.Nullable<bool> doNotCloneChildren = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" },
                    name,
                    newParent,
                    doNotCloneChildren
                }
            );
        }

        public AnimationRange[] getAnimationRanges()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationRange>(
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAnimationRanges" } }
            );
        }

        public Animatable beginAnimation(
            string name,
            System.Nullable<bool> loop = null,
            System.Nullable<decimal> speedRatio = null,
            ActionCallback onAnimationEnd = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "beginAnimation" },
                    name,
                    loop,
                    speedRatio,
                    onAnimationEnd
                }
            );
        }

        public CachedEntity serializeAnimationRanges()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serializeAnimationRanges" } }
            );
        }

        public Matrix computeWorldMatrix(System.Nullable<bool> _force = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "computeWorldMatrix" }, _force }
            );
        }

        public void dispose(
            System.Nullable<bool> doNotRecurse = null,
            System.Nullable<bool> disposeMaterialAndTextures = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" },
                    doNotRecurse,
                    disposeMaterialAndTextures
                }
            );
        }

        public CachedEntity getHierarchyBoundingVectors(
            System.Nullable<bool> includeDescendants = null,
            ActionResultCallback<AbstractMesh, bool> predicate = null
        )
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getHierarchyBoundingVectors" },
                    includeDescendants,
                    predicate
                }
            );
        }
        #endregion
    }
}
