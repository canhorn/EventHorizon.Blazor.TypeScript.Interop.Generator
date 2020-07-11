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
    public class AbstractMesh : TransformNode, IDisposable
    {
        #region Static Accessors
        
        public static decimal BILLBOARDMODE_NONE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_NONE"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_X
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_X"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_Y
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_Y"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_Z
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_Z"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_ALL
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_ALL"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_USE_POSITION
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_USE_POSITION"
                );
            }
        }
        #endregion

        #region Static Properties
        
        public static decimal OCCLUSION_TYPE_NONE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".AbstractMesh.OCCLUSION_TYPE_NONE"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".AbstractMesh.OCCLUSION_TYPE_NONE",
                    value
                );
            }
        }

        
        public static decimal OCCLUSION_TYPE_OPTIMISTIC
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".AbstractMesh.OCCLUSION_TYPE_OPTIMISTIC"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".AbstractMesh.OCCLUSION_TYPE_OPTIMISTIC",
                    value
                );
            }
        }

        
        public static decimal OCCLUSION_TYPE_STRICT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".AbstractMesh.OCCLUSION_TYPE_STRICT"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".AbstractMesh.OCCLUSION_TYPE_STRICT",
                    value
                );
            }
        }

        
        public static decimal OCCLUSION_ALGORITHM_TYPE_ACCURATE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".AbstractMesh.OCCLUSION_ALGORITHM_TYPE_ACCURATE"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".AbstractMesh.OCCLUSION_ALGORITHM_TYPE_ACCURATE",
                    value
                );
            }
        }

        
        public static decimal OCCLUSION_ALGORITHM_TYPE_CONSERVATIVE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".AbstractMesh.OCCLUSION_ALGORITHM_TYPE_CONSERVATIVE"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".AbstractMesh.OCCLUSION_ALGORITHM_TYPE_CONSERVATIVE",
                    value
                );
            }
        }

        
        public static decimal CULLINGSTRATEGY_STANDARD
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".AbstractMesh.CULLINGSTRATEGY_STANDARD"
                );
            }
        }

        
        public static decimal CULLINGSTRATEGY_BOUNDINGSPHERE_ONLY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".AbstractMesh.CULLINGSTRATEGY_BOUNDINGSPHERE_ONLY"
                );
            }
        }

        
        public static decimal CULLINGSTRATEGY_OPTIMISTIC_INCLUSION
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".AbstractMesh.CULLINGSTRATEGY_OPTIMISTIC_INCLUSION"
                );
            }
        }

        
        public static decimal CULLINGSTRATEGY_OPTIMISTIC_INCLUSION_THEN_BSPHERE_ONLY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".AbstractMesh.CULLINGSTRATEGY_OPTIMISTIC_INCLUSION_THEN_BSPHERE_ONLY"
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public decimal facetNb
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "facetNb"
                );
            }
        }

        
        public decimal partitioningSubdivisions
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "partitioningSubdivisions"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "partitioningSubdivisions",
                    value
                );
            }
        }

        
        public decimal partitioningBBoxRatio
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "partitioningBBoxRatio"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "partitioningBBoxRatio",
                    value
                );
            }
        }

        
        public bool mustDepthSortFacets
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "mustDepthSortFacets"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "mustDepthSortFacets",
                    value
                );
            }
        }

        private Vector3 __facetDepthSortFrom;
        public Vector3 facetDepthSortFrom
        {
            get
            {
            if(__facetDepthSortFrom == null)
            {
                __facetDepthSortFrom = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "facetDepthSortFrom",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __facetDepthSortFrom;
            }
            set
            {
__facetDepthSortFrom = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "facetDepthSortFrom",
                    value
                );
            }
        }

        
        public bool isFacetDataEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isFacetDataEnabled"
                );
            }
        }

        
        public decimal visibility
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "visibility"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "visibility",
                    value
                );
            }
        }

        private Material __material;
        public Material material
        {
            get
            {
            if(__material == null)
            {
                __material = EventHorizonBlazorInteropt.GetClass<Material>(
                    this.___guid,
                    "material",
                    (entity) =>
                    {
                        return new Material(entity);
                    }
                );
            }
            return __material;
            }
            set
            {
__material = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "material",
                    value
                );
            }
        }

        
        public bool receiveShadows
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "receiveShadows"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "receiveShadows",
                    value
                );
            }
        }

        
        public bool hasVertexAlpha
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "hasVertexAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "hasVertexAlpha",
                    value
                );
            }
        }

        
        public bool useVertexColors
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useVertexColors"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useVertexColors",
                    value
                );
            }
        }

        
        public bool computeBonesUsingShaders
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "computeBonesUsingShaders"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "computeBonesUsingShaders",
                    value
                );
            }
        }

        
        public decimal numBoneInfluencers
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "numBoneInfluencers"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "numBoneInfluencers",
                    value
                );
            }
        }

        
        public bool applyFog
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "applyFog"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "applyFog",
                    value
                );
            }
        }

        
        public decimal layerMask
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "layerMask",
                    value
                );
            }
        }

        
        public decimal collisionMask
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "collisionMask"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "collisionMask",
                    value
                );
            }
        }

        
        public decimal collisionGroup
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "collisionGroup"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "collisionGroup",
                    value
                );
            }
        }

        
        public Light[] lightSources
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Light>(
                    this.___guid,
                    "lightSources",
                    (entity) =>
                    {
                        return new Light(entity);
                    }
                );
            }
        }

        private Skeleton __skeleton;
        public Skeleton skeleton
        {
            get
            {
            if(__skeleton == null)
            {
                __skeleton = EventHorizonBlazorInteropt.GetClass<Skeleton>(
                    this.___guid,
                    "skeleton",
                    (entity) =>
                    {
                        return new Skeleton(entity);
                    }
                );
            }
            return __skeleton;
            }
            set
            {
__skeleton = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "skeleton",
                    value
                );
            }
        }

        private Vector3 __scaling;
        public Vector3 scaling
        {
            get
            {
            if(__scaling == null)
            {
                __scaling = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "scaling",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __scaling;
            }
            set
            {
__scaling = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "scaling",
                    value
                );
            }
        }

        
        public bool isBlocked
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isBlocked"
                );
            }
        }

        
        public bool useBones
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useBones"
                );
            }
        }

        
        public bool isAnInstance
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isAnInstance"
                );
            }
        }

        
        public bool hasInstances
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "hasInstances"
                );
            }
        }

        
        public bool checkCollisions
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "checkCollisions"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "checkCollisions",
                    value
                );
            }
        }

        private Collider __collider;
        public Collider collider
        {
            get
            {
            if(__collider == null)
            {
                __collider = EventHorizonBlazorInteropt.GetClass<Collider>(
                    this.___guid,
                    "collider",
                    (entity) =>
                    {
                        return new Collider(entity);
                    }
                );
            }
            return __collider;
            }
        }
        #endregion

        #region Properties
        
        public decimal cullingStrategy
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "cullingStrategy"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cullingStrategy",
                    value
                );
            }
        }

        private Observable __onCollideObservable;
        public Observable onCollideObservable
        {
            get
            {
            if(__onCollideObservable == null)
            {
                __onCollideObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onCollideObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onCollideObservable;
            }
            set
            {
__onCollideObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onCollideObservable",
                    value
                );
            }
        }

        private Observable __onCollisionPositionChangeObservable;
        public Observable onCollisionPositionChangeObservable
        {
            get
            {
            if(__onCollisionPositionChangeObservable == null)
            {
                __onCollisionPositionChangeObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onCollisionPositionChangeObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onCollisionPositionChangeObservable;
            }
            set
            {
__onCollisionPositionChangeObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onCollisionPositionChangeObservable",
                    value
                );
            }
        }

        private Observable __onMaterialChangedObservable;
        public Observable onMaterialChangedObservable
        {
            get
            {
            if(__onMaterialChangedObservable == null)
            {
                __onMaterialChangedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onMaterialChangedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onMaterialChangedObservable;
            }
            set
            {
__onMaterialChangedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onMaterialChangedObservable",
                    value
                );
            }
        }

        
        public bool definedFacingForward
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "definedFacingForward"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "definedFacingForward",
                    value
                );
            }
        }

        
        public decimal alphaIndex
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "alphaIndex"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "alphaIndex",
                    value
                );
            }
        }

        
        public bool isVisible
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isVisible"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isVisible",
                    value
                );
            }
        }

        
        public bool isPickable
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isPickable"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isPickable",
                    value
                );
            }
        }

        
        public bool showSubMeshesBoundingBox
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "showSubMeshesBoundingBox"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "showSubMeshesBoundingBox",
                    value
                );
            }
        }

        
        public bool isBlocker
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isBlocker"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isBlocker",
                    value
                );
            }
        }

        
        public bool enablePointerMoveEvents
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "enablePointerMoveEvents"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "enablePointerMoveEvents",
                    value
                );
            }
        }

        
        public decimal renderingGroupId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "renderingGroupId"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "renderingGroupId",
                    value
                );
            }
        }

        private Color3 __outlineColor;
        public Color3 outlineColor
        {
            get
            {
            if(__outlineColor == null)
            {
                __outlineColor = EventHorizonBlazorInteropt.GetClass<Color3>(
                    this.___guid,
                    "outlineColor",
                    (entity) =>
                    {
                        return new Color3(entity);
                    }
                );
            }
            return __outlineColor;
            }
            set
            {
__outlineColor = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "outlineColor",
                    value
                );
            }
        }

        
        public decimal outlineWidth
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "outlineWidth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "outlineWidth",
                    value
                );
            }
        }

        private Color3 __overlayColor;
        public Color3 overlayColor
        {
            get
            {
            if(__overlayColor == null)
            {
                __overlayColor = EventHorizonBlazorInteropt.GetClass<Color3>(
                    this.___guid,
                    "overlayColor",
                    (entity) =>
                    {
                        return new Color3(entity);
                    }
                );
            }
            return __overlayColor;
            }
            set
            {
__overlayColor = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "overlayColor",
                    value
                );
            }
        }

        
        public decimal overlayAlpha
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "overlayAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "overlayAlpha",
                    value
                );
            }
        }

        
        public bool useOctreeForRenderingSelection
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useOctreeForRenderingSelection"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useOctreeForRenderingSelection",
                    value
                );
            }
        }

        
        public bool useOctreeForPicking
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useOctreeForPicking"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useOctreeForPicking",
                    value
                );
            }
        }

        
        public bool useOctreeForCollisions
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useOctreeForCollisions"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useOctreeForCollisions",
                    value
                );
            }
        }

        
        public bool alwaysSelectAsActiveMesh
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "alwaysSelectAsActiveMesh"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "alwaysSelectAsActiveMesh",
                    value
                );
            }
        }

        
        public bool doNotSyncBoundingInfo
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "doNotSyncBoundingInfo"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "doNotSyncBoundingInfo",
                    value
                );
            }
        }

        private AbstractActionManager __actionManager;
        public AbstractActionManager actionManager
        {
            get
            {
            if(__actionManager == null)
            {
                __actionManager = EventHorizonBlazorInteropt.GetClass<AbstractActionManager>(
                    this.___guid,
                    "actionManager",
                    (entity) =>
                    {
                        return new AbstractActionManager(entity);
                    }
                );
            }
            return __actionManager;
            }
            set
            {
__actionManager = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "actionManager",
                    value
                );
            }
        }

        private Vector3 __ellipsoid;
        public Vector3 ellipsoid
        {
            get
            {
            if(__ellipsoid == null)
            {
                __ellipsoid = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "ellipsoid",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __ellipsoid;
            }
            set
            {
__ellipsoid = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "ellipsoid",
                    value
                );
            }
        }

        private Vector3 __ellipsoidOffset;
        public Vector3 ellipsoidOffset
        {
            get
            {
            if(__ellipsoidOffset == null)
            {
                __ellipsoidOffset = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "ellipsoidOffset",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __ellipsoidOffset;
            }
            set
            {
__ellipsoidOffset = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "ellipsoidOffset",
                    value
                );
            }
        }

        
        public decimal edgesWidth
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "edgesWidth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "edgesWidth",
                    value
                );
            }
        }

        private Color4 __edgesColor;
        public Color4 edgesColor
        {
            get
            {
            if(__edgesColor == null)
            {
                __edgesColor = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "edgesColor",
                    (entity) =>
                    {
                        return new Color4(entity);
                    }
                );
            }
            return __edgesColor;
            }
            set
            {
__edgesColor = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "edgesColor",
                    value
                );
            }
        }

        
        public SubMesh[] subMeshes
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<SubMesh>(
                    this.___guid,
                    "subMeshes",
                    (entity) =>
                    {
                        return new SubMesh(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "subMeshes",
                    value
                );
            }
        }

        private Observable __onRebuildObservable;
        public Observable onRebuildObservable
        {
            get
            {
            if(__onRebuildObservable == null)
            {
                __onRebuildObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onRebuildObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onRebuildObservable;
            }
            set
            {
__onRebuildObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onRebuildObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AbstractMesh() : base() { }

        public AbstractMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AbstractMesh(
            string name, Scene scene = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "AbstractMesh" },
                name, scene
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

        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }

        public AbstractMesh getLOD(Camera camera)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getLOD" }, camera
                }
            );
        }

        public decimal getTotalVertices()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTotalVertices" }
                }
            );
        }

        public decimal getTotalIndices()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTotalIndices" }
                }
            );
        }

        public decimal[] getIndices()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndices" }
                }
            );
        }

        public decimal[] getVerticesData(string kind)
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" }, kind
                }
            );
        }

        public AbstractMesh setVerticesData(string kind, decimal[] data, System.Nullable<bool> updatable = null, System.Nullable<decimal> stride = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setVerticesData" }, kind, data, updatable, stride
                }
            );
        }

        public AbstractMesh updateVerticesData(string kind, decimal[] data, System.Nullable<bool> updateExtends = null, System.Nullable<bool> makeItUnique = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "updateVerticesData" }, kind, data, updateExtends, makeItUnique
                }
            );
        }

        public AbstractMesh setIndices(decimal[] indices, decimal totalVertices)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setIndices" }, indices, totalVertices
                }
            );
        }

        public bool isVerticesDataPresent(string kind)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isVerticesDataPresent" }, kind
                }
            );
        }

        public BoundingInfo getBoundingInfo()
        {
            return EventHorizonBlazorInteropt.FuncClass<BoundingInfo>(
                entity => new BoundingInfo(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getBoundingInfo" }
                }
            );
        }

        public AbstractMesh normalizeToUnitCube(System.Nullable<bool> includeDescendants = null, System.Nullable<bool> ignoreRotation = null, AbstractMesh predicate = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "normalizeToUnitCube" }, includeDescendants, ignoreRotation, predicate
                }
            );
        }

        public AbstractMesh setBoundingInfo(BoundingInfo boundingInfo)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setBoundingInfo" }, boundingInfo
                }
            );
        }

        public Matrix getWorldMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getWorldMatrix" }
                }
            );
        }

        public AbstractMesh movePOV(decimal amountRight, decimal amountUp, decimal amountForward)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "movePOV" }, amountRight, amountUp, amountForward
                }
            );
        }

        public Vector3 calcMovePOV(decimal amountRight, decimal amountUp, decimal amountForward)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "calcMovePOV" }, amountRight, amountUp, amountForward
                }
            );
        }

        public AbstractMesh rotatePOV(decimal flipBack, decimal twirlClockwise, decimal tiltRight)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "rotatePOV" }, flipBack, twirlClockwise, tiltRight
                }
            );
        }

        public Vector3 calcRotatePOV(decimal flipBack, decimal twirlClockwise, decimal tiltRight)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "calcRotatePOV" }, flipBack, twirlClockwise, tiltRight
                }
            );
        }

        public AbstractMesh refreshBoundingInfo(System.Nullable<bool> applySkeleton = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "refreshBoundingInfo" }, applySkeleton
                }
            );
        }

        public bool isInFrustum(Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isInFrustum" }, frustumPlanes
                }
            );
        }

        public bool isCompletelyInFrustum(Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isCompletelyInFrustum" }, frustumPlanes
                }
            );
        }

        public bool intersectsMesh(object mesh, System.Nullable<bool> precise = null, System.Nullable<bool> includeDescendants = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsMesh" }, mesh, precise, includeDescendants
                }
            );
        }

        public bool intersectsPoint(Vector3 point)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsPoint" }, point
                }
            );
        }

        public AbstractMesh moveWithCollisions(Vector3 displacement)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "moveWithCollisions" }, displacement
                }
            );
        }

        public PickingInfo intersects(Ray ray, System.Nullable<bool> fastCheck = null, TrianglePickingPredicate trianglePredicate = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<PickingInfo>(
                entity => new PickingInfo(entity),
                new object[] 
                {
                    new string[] { this.___guid, "intersects" }, ray, fastCheck, trianglePredicate
                }
            );
        }

        public AbstractMesh clone(string name, Node newParent, System.Nullable<bool> doNotCloneChildren = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren
                }
            );
        }

        public AbstractMesh releaseSubMeshes()
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "releaseSubMeshes" }
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

        public AbstractMesh addChild(AbstractMesh mesh)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addChild" }, mesh
                }
            );
        }

        public AbstractMesh removeChild(AbstractMesh mesh)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeChild" }, mesh
                }
            );
        }

        public AbstractMesh updateFacetData()
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "updateFacetData" }
                }
            );
        }

        public Vector3[] getFacetLocalNormals()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<Vector3>(
                entity => new Vector3(entity),
                new object[]
                {
                    new string[] { this.___guid, "getFacetLocalNormals" }
                }
            );
        }

        public Vector3[] getFacetLocalPositions()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<Vector3>(
                entity => new Vector3(entity),
                new object[]
                {
                    new string[] { this.___guid, "getFacetLocalPositions" }
                }
            );
        }

        public decimal[] getFacetLocalPartitioning()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFacetLocalPartitioning" }
                }
            );
        }

        public Vector3 getFacetPosition(decimal i)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getFacetPosition" }, i
                }
            );
        }

        public AbstractMesh getFacetPositionToRef(decimal i, Vector3 @ref)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getFacetPositionToRef" }, i, @ref
                }
            );
        }

        public Vector3 getFacetNormal(decimal i)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getFacetNormal" }, i
                }
            );
        }

        public AbstractMesh getFacetNormalToRef(decimal i, Vector3 @ref)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getFacetNormalToRef" }, i, @ref
                }
            );
        }

        public decimal[] getFacetsAtLocalCoordinates(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFacetsAtLocalCoordinates" }, x, y, z
                }
            );
        }

        public decimal getClosestFacetAtCoordinates(decimal x, decimal y, decimal z, Vector3 projected = null, System.Nullable<bool> checkFace = null, System.Nullable<bool> facing = null)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getClosestFacetAtCoordinates" }, x, y, z, projected, checkFace, facing
                }
            );
        }

        public decimal getClosestFacetAtLocalCoordinates(decimal x, decimal y, decimal z, Vector3 projected = null, System.Nullable<bool> checkFace = null, System.Nullable<bool> facing = null)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getClosestFacetAtLocalCoordinates" }, x, y, z, projected, checkFace, facing
                }
            );
        }

        public CachedEntity getFacetDataParameters()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getFacetDataParameters" }
                }
            );
        }

        public AbstractMesh disableFacetData()
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "disableFacetData" }
                }
            );
        }

        public AbstractMesh updateIndices(decimal[] indices, System.Nullable<decimal> offset = null, System.Nullable<bool> gpuMemoryOnly = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "updateIndices" }, indices, offset, gpuMemoryOnly
                }
            );
        }

        public AbstractMesh createNormals(bool updatable)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createNormals" }, updatable
                }
            );
        }

        public AbstractMesh alignWithNormal(Vector3 normal, Vector3 upDirection = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "alignWithNormal" }, normal, upDirection
                }
            );
        }

        public AbstractMesh disableEdgesRendering()
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "disableEdgesRendering" }
                }
            );
        }

        public AbstractMesh enableEdgesRendering(System.Nullable<decimal> epsilon = null, System.Nullable<bool> checkVerticesInsteadOfIndices = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "enableEdgesRendering" }, epsilon, checkVerticesInsteadOfIndices
                }
            );
        }
        #endregion
    }
}