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

    [JsonConverter(typeof(CachedEntityConverter<Node>))]
    public class Node : CachedEntityObject, IBehaviorAware<Node>
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask AddNodeConstructor(
            string type,
            ActionResultCallback<
                string,
                Scene,
                CachedEntity,
                ActionResultCallback<Node>
            > constructorFunc
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Node", "AddNodeConstructor" },
                    type,
                    constructorFunc
                }
            );
        }

        public static async ValueTask<Node> Construct()
        {
            return await EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "Node", "Construct" } }
            );
        }

        public static async ValueTask ParseAnimationRanges(
            Node node,
            object parsedNode,
            Scene _scene
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<IAccessibilityTagCachedEntity> get_accessibilityTag()
        {
            if (__accessibilityTag == null)
            {
                __accessibilityTag =
                    await EventHorizonBlazorInterop.GetClass<IAccessibilityTagCachedEntity>(
                        this.___guid,
                        "accessibilityTag",
                        (entity) =>
                        {
                            return new IAccessibilityTagCachedEntity() { ___guid = entity.___guid };
                        }
                    );
            }
            return __accessibilityTag;
        }

        public ValueTask set_accessibilityTag(IAccessibilityTagCachedEntity value)
        {
            __accessibilityTag = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "accessibilityTag", value);
        }

        public async ValueTask<bool> get_doNotSerialize()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "doNotSerialize");
        }

        public ValueTask set_doNotSerialize(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "doNotSerialize", value);
        }

        private Node __parent;

        public async ValueTask<Node> get_parent()
        {
            if (__parent == null)
            {
                __parent = await EventHorizonBlazorInterop.GetClass<Node>(
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

        public ValueTask set_parent(Node value)
        {
            __parent = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "parent", value);
        }

        private AnimationPropertiesOverride __animationPropertiesOverride;

        public async ValueTask<AnimationPropertiesOverride> get_animationPropertiesOverride()
        {
            if (__animationPropertiesOverride == null)
            {
                __animationPropertiesOverride =
                    await EventHorizonBlazorInterop.GetClass<AnimationPropertiesOverride>(
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

        private Observable<bool> __onEnabledStateChangedObservable;

        public async ValueTask<Observable<bool>> get_onEnabledStateChangedObservable()
        {
            if (__onEnabledStateChangedObservable == null)
            {
                __onEnabledStateChangedObservable = await EventHorizonBlazorInterop.GetClass<
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

        private Observable<Node> __onClonedObservable;

        public async ValueTask<Observable<Node>> get_onClonedObservable()
        {
            if (__onClonedObservable == null)
            {
                __onClonedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Node>>(
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

        public async ValueTask<BehaviorCachedEntity<Node>[]> get_behaviors()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<BehaviorCachedEntity<Node>>(
                this.___guid,
                "behaviors",
                (entity) =>
                {
                    return new BehaviorCachedEntity<Node>() { ___guid = entity.___guid };
                }
            );
        }

        private Matrix __worldMatrixFromCache;

        public async ValueTask<Matrix> get_worldMatrixFromCache()
        {
            if (__worldMatrixFromCache == null)
            {
                __worldMatrixFromCache = await EventHorizonBlazorInterop.GetClass<Matrix>(
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

        public async ValueTask<string> get_id()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "id");
        }

        public ValueTask set_id(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "id", value);
        }

        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "uniqueId");
        }

        public ValueTask set_uniqueId(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "uniqueId", value);
        }

        public async ValueTask<string> get_state()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "state");
        }

        public ValueTask set_state(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "state", value);
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

        public async ValueTask<CachedEntity> get_reservedDataStore()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "reservedDataStore",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_reservedDataStore(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "reservedDataStore", value);
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

        private Observable<IAccessibilityTagCachedEntity> __onAccessibilityTagChangedObservable;

        public async ValueTask<
            Observable<IAccessibilityTagCachedEntity>
        > get_onAccessibilityTagChangedObservable()
        {
            if (__onAccessibilityTagChangedObservable == null)
            {
                __onAccessibilityTagChangedObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onAccessibilityTagChangedObservable(
            Observable<IAccessibilityTagCachedEntity> value
        )
        {
            __onAccessibilityTagChangedObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onAccessibilityTagChangedObservable",
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
            return EventHorizonBlazorInterop.Set(this.___guid, "animations", value);
        }

        public async ValueTask<ActionCallback<Node>> get_onReady()
        {
            return await EventHorizonBlazorInterop.Get<ActionCallback<Node>>(
                this.___guid,
                "onReady"
            );
        }

        public ValueTask set_onReady(ActionCallback<Node> value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "onReady", value);
        }

        private Observable<Node> __onDisposeObservable;

        public async ValueTask<Observable<Node>> get_onDisposeObservable()
        {
            if (__onDisposeObservable == null)
            {
                __onDisposeObservable = await EventHorizonBlazorInterop.GetClass<Observable<Node>>(
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

        public ValueTask set_onDisposeObservable(Observable<Node> value)
        {
            __onDisposeObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onDisposeObservable", value);
        }
        #endregion

        #region Constructor
        public Node()
            : base() { }

        public Node(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<Node> NewNode(
            string name,
            Scene scene = null,
            System.Nullable<bool> isPure = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Node" },
                name,
                scene,
                isPure
            );

            return new Node(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> isDisposed()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isDisposed" } }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask<Scene> getScene()
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getScene" } }
            );
        }

        public async ValueTask<AbstractEngine> getEngine()
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractEngine>(
                entity => new AbstractEngine() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getEngine" } }
            );
        }

        public async ValueTask<Node> addBehavior(
            Behavior<Node> behavior,
            System.Nullable<bool> attachImmediately = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addBehavior" },
                    behavior,
                    attachImmediately
                }
            );
        }

        public async ValueTask<Node> removeBehavior(Behavior<Node> behavior)
        {
            return await EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "removeBehavior" }, behavior }
            );
        }

        public async ValueTask<BehaviorCachedEntity<Node>> getBehaviorByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<BehaviorCachedEntity<Node>>(
                entity => new BehaviorCachedEntity<Node>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBehaviorByName" }, name }
            );
        }

        public async ValueTask<Matrix> getWorldMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getWorldMatrix" } }
            );
        }

        public async ValueTask updateCache(System.Nullable<bool> force = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateCache" }, force }
            );
        }

        public async ValueTask<bool> isSynchronizedWithParent()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isSynchronizedWithParent" } }
            );
        }

        public async ValueTask<bool> isSynchronized()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isSynchronized" } }
            );
        }

        public async ValueTask<bool> isReady(System.Nullable<bool> _completeCheck = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReady" }, _completeCheck }
            );
        }

        public async ValueTask<Node> markAsDirty(string _property = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "markAsDirty" }, _property }
            );
        }

        public async ValueTask<bool> isEnabled(System.Nullable<bool> checkAncestors = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isEnabled" }, checkAncestors }
            );
        }

        public async ValueTask setEnabled(bool value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setEnabled" }, value }
            );
        }

        public async ValueTask<bool> isDescendantOf(Node ancestor)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isDescendantOf" }, ancestor }
            );
        }

        public async ValueTask<T[]> getDescendants<T>(
            System.Nullable<bool> directDescendantsOnly = null,
            ActionResultCallback<Node, T> predicate = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDescendants" },
                    directDescendantsOnly,
                    predicate
                }
            );
        }

        public async ValueTask<T[]> getChildMeshes<T>(
            System.Nullable<bool> directDescendantsOnly = null,
            ActionResultCallback<Node, T> predicate = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildMeshes" },
                    directDescendantsOnly,
                    predicate
                }
            );
        }

        public async ValueTask<T[]> getChildren<T>(
            ActionResultCallback<Node, T> predicate = null,
            System.Nullable<bool> directDescendantsOnly = null
        )
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildren" },
                    predicate,
                    directDescendantsOnly
                }
            );
        }

        public async ValueTask<Animation> getAnimationByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAnimationByName" }, name }
            );
        }

        public async ValueTask createAnimationRange(string name, decimal from, decimal to)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createAnimationRange" },
                    name,
                    from,
                    to
                }
            );
        }

        public async ValueTask deleteAnimationRange(
            string name,
            System.Nullable<bool> deleteFrames = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteAnimationRange" },
                    name,
                    deleteFrames
                }
            );
        }

        public async ValueTask<AnimationRange> getAnimationRange(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationRange>(
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAnimationRange" }, name }
            );
        }

        public async ValueTask<Node> clone(
            string name,
            Node newParent,
            System.Nullable<bool> doNotCloneChildren = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Node>(
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

        public async ValueTask<AnimationRange[]> getAnimationRanges()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<AnimationRange>(
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAnimationRanges" } }
            );
        }

        public async ValueTask<Animatable> beginAnimation(
            string name,
            System.Nullable<bool> loop = null,
            System.Nullable<decimal> speedRatio = null,
            ActionCallback onAnimationEnd = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Animatable>(
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

        public async ValueTask<CachedEntity> serializeAnimationRanges()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serializeAnimationRanges" } }
            );
        }

        public async ValueTask<Matrix> computeWorldMatrix(System.Nullable<bool> _force = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "computeWorldMatrix" }, _force }
            );
        }

        public async ValueTask dispose(
            System.Nullable<bool> doNotRecurse = null,
            System.Nullable<bool> disposeMaterialAndTextures = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" },
                    doNotRecurse,
                    disposeMaterialAndTextures
                }
            );
        }

        public async ValueTask<CachedEntity> getHierarchyBoundingVectors(
            System.Nullable<bool> includeDescendants = null,
            ActionResultCallback<AbstractMesh, bool> predicate = null
        )
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
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
