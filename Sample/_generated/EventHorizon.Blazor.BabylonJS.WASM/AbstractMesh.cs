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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AbstractMesh>))]
    public class AbstractMesh : TransformNode, _IDisposable, ICullable, IGetSetVerticesData
    {
        #region Static Accessors
        
        public static decimal BILLBOARDMODE_NONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_NONE"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_X
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_X"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_Y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_Y"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_Z
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_Z"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_ALL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_ALL"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_USE_POSITION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_TYPE_NONE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_TYPE_NONE",
                    value
                );
            }
        }

        
        public static decimal OCCLUSION_TYPE_OPTIMISTIC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_TYPE_OPTIMISTIC"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_TYPE_OPTIMISTIC",
                    value
                );
            }
        }

        
        public static decimal OCCLUSION_TYPE_STRICT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_TYPE_STRICT"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_TYPE_STRICT",
                    value
                );
            }
        }

        
        public static decimal OCCLUSION_ALGORITHM_TYPE_ACCURATE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_ALGORITHM_TYPE_ACCURATE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_ALGORITHM_TYPE_ACCURATE",
                    value
                );
            }
        }

        
        public static decimal OCCLUSION_ALGORITHM_TYPE_CONSERVATIVE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_ALGORITHM_TYPE_CONSERVATIVE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_ALGORITHM_TYPE_CONSERVATIVE",
                    value
                );
            }
        }

        
        public static decimal CULLINGSTRATEGY_STANDARD
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.CULLINGSTRATEGY_STANDARD"
                );
            }
        }

        
        public static decimal CULLINGSTRATEGY_BOUNDINGSPHERE_ONLY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.CULLINGSTRATEGY_BOUNDINGSPHERE_ONLY"
                );
            }
        }

        
        public static decimal CULLINGSTRATEGY_OPTIMISTIC_INCLUSION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.CULLINGSTRATEGY_OPTIMISTIC_INCLUSION"
                );
            }
        }

        
        public static decimal CULLINGSTRATEGY_OPTIMISTIC_INCLUSION_THEN_BSPHERE_ONLY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.CULLINGSTRATEGY_OPTIMISTIC_INCLUSION_THEN_BSPHERE_ONLY"
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "facetNb"
                );
            }
        }

        
        public decimal partitioningSubdivisions
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "partitioningSubdivisions"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "partitioningBBoxRatio"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "mustDepthSortFacets"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __facetDepthSortFrom = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "facetDepthSortFrom",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __facetDepthSortFrom;
            }
            set
            {
__facetDepthSortFrom = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isFacetDataEnabled"
                );
            }
        }

        
        public decimal visibility
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "visibility"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visibility",
                    value
                );
            }
        }

        
        public decimal renderingGroupId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderingGroupId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderingGroupId",
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
                __material = EventHorizonBlazorInterop.GetClass<Material>(
                    this.___guid,
                    "material",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
            }
            return __material;
            }
            set
            {
__material = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "receiveShadows"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasVertexAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useVertexColors"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "computeBonesUsingShaders"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "numBoneInfluencers"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "applyFog"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "collisionMask"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionMask",
                    value
                );
            }
        }

        
        public bool collisionResponse
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collisionResponse"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionResponse",
                    value
                );
            }
        }

        
        public decimal collisionGroup
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "collisionGroup"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionGroup",
                    value
                );
            }
        }

        
        public AbstractMesh[] surroundingMeshes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "surroundingMeshes",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "surroundingMeshes",
                    value
                );
            }
        }

        
        public Light[] lightSources
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Light>(
                    this.___guid,
                    "lightSources",
                    (entity) =>
                    {
                        return new Light() { ___guid = entity.___guid };
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
                __skeleton = EventHorizonBlazorInterop.GetClass<Skeleton>(
                    this.___guid,
                    "skeleton",
                    (entity) =>
                    {
                        return new Skeleton() { ___guid = entity.___guid };
                    }
                );
            }
            return __skeleton;
            }
            set
            {
__skeleton = null;
                EventHorizonBlazorInterop.Set(
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
                __scaling = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "scaling",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __scaling;
            }
            set
            {
__scaling = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBlocked"
                );
            }
        }

        
        public bool useBones
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useBones"
                );
            }
        }

        
        public bool isAnInstance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isAnInstance"
                );
            }
        }

        
        public bool hasInstances
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasInstances"
                );
            }
        }

        
        public bool hasThinInstances
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasThinInstances"
                );
            }
        }

        
        public bool checkCollisions
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "checkCollisions"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __collider = EventHorizonBlazorInterop.GetClass<Collider>(
                    this.___guid,
                    "collider",
                    (entity) =>
                    {
                        return new Collider() { ___guid = entity.___guid };
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cullingStrategy"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cullingStrategy",
                    value
                );
            }
        }

        private Observable<AbstractMesh> __onCollideObservable;
        public Observable<AbstractMesh> onCollideObservable
        {
            get
            {
            if(__onCollideObservable == null)
            {
                __onCollideObservable = EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
                    this.___guid,
                    "onCollideObservable",
                    (entity) =>
                    {
                        return new Observable<AbstractMesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onCollideObservable;
            }
            set
            {
__onCollideObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCollideObservable",
                    value
                );
            }
        }

        private Observable<Vector3> __onCollisionPositionChangeObservable;
        public Observable<Vector3> onCollisionPositionChangeObservable
        {
            get
            {
            if(__onCollisionPositionChangeObservable == null)
            {
                __onCollisionPositionChangeObservable = EventHorizonBlazorInterop.GetClass<Observable<Vector3>>(
                    this.___guid,
                    "onCollisionPositionChangeObservable",
                    (entity) =>
                    {
                        return new Observable<Vector3>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onCollisionPositionChangeObservable;
            }
            set
            {
__onCollisionPositionChangeObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCollisionPositionChangeObservable",
                    value
                );
            }
        }

        private Observable<AbstractMesh> __onMaterialChangedObservable;
        public Observable<AbstractMesh> onMaterialChangedObservable
        {
            get
            {
            if(__onMaterialChangedObservable == null)
            {
                __onMaterialChangedObservable = EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
                    this.___guid,
                    "onMaterialChangedObservable",
                    (entity) =>
                    {
                        return new Observable<AbstractMesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onMaterialChangedObservable;
            }
            set
            {
__onMaterialChangedObservable = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "definedFacingForward"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isVisible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPickable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "showSubMeshesBoundingBox"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBlocker"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enablePointerMoveEvents"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enablePointerMoveEvents",
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
                __outlineColor = EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "outlineColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __outlineColor;
            }
            set
            {
__outlineColor = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "outlineWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __overlayColor = EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "overlayColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __overlayColor;
            }
            set
            {
__overlayColor = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "overlayAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useOctreeForRenderingSelection"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useOctreeForPicking"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useOctreeForCollisions"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "alwaysSelectAsActiveMesh"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotSyncBoundingInfo"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __actionManager = EventHorizonBlazorInterop.GetClass<AbstractActionManager>(
                    this.___guid,
                    "actionManager",
                    (entity) =>
                    {
                        return new AbstractActionManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __actionManager;
            }
            set
            {
__actionManager = null;
                EventHorizonBlazorInterop.Set(
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
                __ellipsoid = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "ellipsoid",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __ellipsoid;
            }
            set
            {
__ellipsoid = null;
                EventHorizonBlazorInterop.Set(
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
                __ellipsoidOffset = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "ellipsoidOffset",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __ellipsoidOffset;
            }
            set
            {
__ellipsoidOffset = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "edgesWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __edgesColor = EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "edgesColor",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __edgesColor;
            }
            set
            {
__edgesColor = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetArrayClass<SubMesh>(
                    this.___guid,
                    "subMeshes",
                    (entity) =>
                    {
                        return new SubMesh() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "subMeshes",
                    value
                );
            }
        }

        private Observable<AbstractMesh> __onRebuildObservable;
        public Observable<AbstractMesh> onRebuildObservable
        {
            get
            {
            if(__onRebuildObservable == null)
            {
                __onRebuildObservable = EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
                    this.___guid,
                    "onRebuildObservable",
                    (entity) =>
                    {
                        return new Observable<AbstractMesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onRebuildObservable;
            }
            set
            {
__onRebuildObservable = null;
                EventHorizonBlazorInterop.Set(
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
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AbstractMesh" },
                name, scene
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

        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }

        public AbstractMesh getLOD(Camera camera)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLOD" }, camera
                }
            );
        }

        public decimal getTotalVertices()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTotalVertices" }
                }
            );
        }

        public decimal getTotalIndices()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTotalIndices" }
                }
            );
        }

        public decimal[] getIndices()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndices" }
                }
            );
        }

        public decimal[] getVerticesData(string kind)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" }, kind
                }
            );
        }

        public AbstractMesh setVerticesData(string kind, decimal[] data, System.Nullable<bool> updatable = null, System.Nullable<decimal> stride = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVerticesData" }, kind, data, updatable, stride
                }
            );
        }

        public AbstractMesh updateVerticesData(string kind, decimal[] data, System.Nullable<bool> updateExtends = null, System.Nullable<bool> makeItUnique = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateVerticesData" }, kind, data, updateExtends, makeItUnique
                }
            );
        }

        public AbstractMesh setIndices(decimal[] indices, System.Nullable<decimal> totalVertices = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setIndices" }, indices, totalVertices
                }
            );
        }

        public bool isVerticesDataPresent(string kind)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isVerticesDataPresent" }, kind
                }
            );
        }

        public BoundingInfo getBoundingInfo()
        {
            return EventHorizonBlazorInterop.FuncClass<BoundingInfo>(
                entity => new BoundingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBoundingInfo" }
                }
            );
        }

        public AbstractMesh normalizeToUnitCube(System.Nullable<bool> includeDescendants = null, System.Nullable<bool> ignoreRotation = null, ActionResultCallback<AbstractMesh, bool> predicate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalizeToUnitCube" }, includeDescendants, ignoreRotation, predicate
                }
            );
        }

        public AbstractMesh setBoundingInfo(BoundingInfo boundingInfo)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBoundingInfo" }, boundingInfo
                }
            );
        }

        public Matrix getWorldMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWorldMatrix" }
                }
            );
        }

        public AbstractMesh movePOV(decimal amountRight, decimal amountUp, decimal amountForward)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "movePOV" }, amountRight, amountUp, amountForward
                }
            );
        }

        public Vector3 calcMovePOV(decimal amountRight, decimal amountUp, decimal amountForward)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "calcMovePOV" }, amountRight, amountUp, amountForward
                }
            );
        }

        public AbstractMesh rotatePOV(decimal flipBack, decimal twirlClockwise, decimal tiltRight)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotatePOV" }, flipBack, twirlClockwise, tiltRight
                }
            );
        }

        public Vector3 calcRotatePOV(decimal flipBack, decimal twirlClockwise, decimal tiltRight)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "calcRotatePOV" }, flipBack, twirlClockwise, tiltRight
                }
            );
        }

        public AbstractMesh refreshBoundingInfo(System.Nullable<bool> applySkeleton = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "refreshBoundingInfo" }, applySkeleton
                }
            );
        }

        public bool isInFrustum(Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isInFrustum" }, frustumPlanes
                }
            );
        }

        public bool isCompletelyInFrustum(Plane[] frustumPlanes)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isCompletelyInFrustum" }, frustumPlanes
                }
            );
        }

        public bool intersectsMesh(AbstractMesh mesh, System.Nullable<bool> precise = null, System.Nullable<bool> includeDescendants = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsMesh" }, mesh, precise, includeDescendants
                }
            );
        }

        public bool intersectsPoint(Vector3 point)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "intersectsPoint" }, point
                }
            );
        }

        public AbstractMesh moveWithCollisions(Vector3 displacement)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "moveWithCollisions" }, displacement
                }
            );
        }

        public PickingInfo intersects(Ray ray, System.Nullable<bool> fastCheck = null, ActionResultCallback<Vector3, Vector3, Vector3, Ray, bool> trianglePredicate = null, System.Nullable<bool> onlyBoundingInfo = null, Matrix worldToUse = null, System.Nullable<bool> skipBoundingInfo = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersects" }, ray, fastCheck, trianglePredicate, onlyBoundingInfo, worldToUse, skipBoundingInfo
                }
            );
        }

        public AbstractMesh clone(string name, Node newParent, System.Nullable<bool> doNotCloneChildren = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren
                }
            );
        }

        public AbstractMesh releaseSubMeshes()
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "releaseSubMeshes" }
                }
            );
        }

        public void dispose(System.Nullable<bool> doNotRecurse = null, System.Nullable<bool> disposeMaterialAndTextures = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, doNotRecurse, disposeMaterialAndTextures
                }
            );
        }

        public AbstractMesh addChild(AbstractMesh mesh)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addChild" }, mesh
                }
            );
        }

        public AbstractMesh removeChild(AbstractMesh mesh)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeChild" }, mesh
                }
            );
        }

        public AbstractMesh updateFacetData()
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateFacetData" }
                }
            );
        }

        public Vector3[] getFacetLocalNormals()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFacetLocalNormals" }
                }
            );
        }

        public Vector3[] getFacetLocalPositions()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFacetLocalPositions" }
                }
            );
        }

// getFacetLocalPartitioning is not supported by the platform yet

        public Vector3 getFacetPosition(decimal i)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFacetPosition" }, i
                }
            );
        }

        public AbstractMesh getFacetPositionToRef(decimal i, Vector3 @ref)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFacetPositionToRef" }, i, @ref
                }
            );
        }

        public Vector3 getFacetNormal(decimal i)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFacetNormal" }, i
                }
            );
        }

        public AbstractMesh getFacetNormalToRef(decimal i, Vector3 @ref)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFacetNormalToRef" }, i, @ref
                }
            );
        }

        public decimal[] getFacetsAtLocalCoordinates(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFacetsAtLocalCoordinates" }, x, y, z
                }
            );
        }

        public decimal getClosestFacetAtCoordinates(decimal x, decimal y, decimal z, Vector3 projected = null, System.Nullable<bool> checkFace = null, System.Nullable<bool> facing = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getClosestFacetAtCoordinates" }, x, y, z, projected, checkFace, facing
                }
            );
        }

        public decimal getClosestFacetAtLocalCoordinates(decimal x, decimal y, decimal z, Vector3 projected = null, System.Nullable<bool> checkFace = null, System.Nullable<bool> facing = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getClosestFacetAtLocalCoordinates" }, x, y, z, projected, checkFace, facing
                }
            );
        }

        public CachedEntity getFacetDataParameters()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getFacetDataParameters" }
                }
            );
        }

        public AbstractMesh disableFacetData()
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "disableFacetData" }
                }
            );
        }

        public AbstractMesh updateIndices(decimal[] indices, System.Nullable<decimal> offset = null, System.Nullable<bool> gpuMemoryOnly = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateIndices" }, indices, offset, gpuMemoryOnly
                }
            );
        }

        public AbstractMesh createNormals(bool updatable)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createNormals" }, updatable
                }
            );
        }

        public AbstractMesh alignWithNormal(Vector3 normal, Vector3 upDirection = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "alignWithNormal" }, normal, upDirection
                }
            );
        }

        public AbstractMesh disableEdgesRendering()
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "disableEdgesRendering" }
                }
            );
        }

        public AbstractMesh enableEdgesRendering(System.Nullable<decimal> epsilon = null, System.Nullable<bool> checkVerticesInsteadOfIndices = null, IEdgesRendererOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enableEdgesRendering" }, epsilon, checkVerticesInsteadOfIndices, options
                }
            );
        }

        public IParticleSystemCachedEntity[] getConnectedParticleSystems()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getConnectedParticleSystems" }
                }
            );
        }
        #endregion
    }
}