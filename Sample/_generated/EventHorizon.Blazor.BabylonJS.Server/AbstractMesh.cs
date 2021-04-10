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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AbstractMesh>))]
    public class AbstractMesh : TransformNode, _IDisposable, ICullable, IGetSetVerticesData
    {
        #region Static Accessors
        
        public static async ValueTask<decimal> get_BILLBOARDMODE_NONE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_NONE"
                );
        }

        
        public static async ValueTask<decimal> get_BILLBOARDMODE_X()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_X"
                );
        }

        
        public static async ValueTask<decimal> get_BILLBOARDMODE_Y()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_Y"
                );
        }

        
        public static async ValueTask<decimal> get_BILLBOARDMODE_Z()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_Z"
                );
        }

        
        public static async ValueTask<decimal> get_BILLBOARDMODE_ALL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_ALL"
                );
        }

        
        public static async ValueTask<decimal> get_BILLBOARDMODE_USE_POSITION()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.BILLBOARDMODE_USE_POSITION"
                );
        }
        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_OCCLUSION_TYPE_NONE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_TYPE_NONE"
                );
        }
        public static ValueTask set_OCCLUSION_TYPE_NONE(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_TYPE_NONE",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_OCCLUSION_TYPE_OPTIMISTIC()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_TYPE_OPTIMISTIC"
                );
        }
        public static ValueTask set_OCCLUSION_TYPE_OPTIMISTIC(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_TYPE_OPTIMISTIC",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_OCCLUSION_TYPE_STRICT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_TYPE_STRICT"
                );
        }
        public static ValueTask set_OCCLUSION_TYPE_STRICT(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_TYPE_STRICT",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_OCCLUSION_ALGORITHM_TYPE_ACCURATE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_ALGORITHM_TYPE_ACCURATE"
                );
        }
        public static ValueTask set_OCCLUSION_ALGORITHM_TYPE_ACCURATE(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_ALGORITHM_TYPE_ACCURATE",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_OCCLUSION_ALGORITHM_TYPE_CONSERVATIVE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_ALGORITHM_TYPE_CONSERVATIVE"
                );
        }
        public static ValueTask set_OCCLUSION_ALGORITHM_TYPE_CONSERVATIVE(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "AbstractMesh.OCCLUSION_ALGORITHM_TYPE_CONSERVATIVE",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_CULLINGSTRATEGY_STANDARD()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.CULLINGSTRATEGY_STANDARD"
                );
        }

        
        public static async ValueTask<decimal> get_CULLINGSTRATEGY_BOUNDINGSPHERE_ONLY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.CULLINGSTRATEGY_BOUNDINGSPHERE_ONLY"
                );
        }

        
        public static async ValueTask<decimal> get_CULLINGSTRATEGY_OPTIMISTIC_INCLUSION()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.CULLINGSTRATEGY_OPTIMISTIC_INCLUSION"
                );
        }

        
        public static async ValueTask<decimal> get_CULLINGSTRATEGY_OPTIMISTIC_INCLUSION_THEN_BSPHERE_ONLY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "AbstractMesh.CULLINGSTRATEGY_OPTIMISTIC_INCLUSION_THEN_BSPHERE_ONLY"
                );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_facetNb()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "facetNb"
                );
        }

        
        public async ValueTask<decimal> get_partitioningSubdivisions()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "partitioningSubdivisions"
                );
        }
        public ValueTask set_partitioningSubdivisions(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "partitioningSubdivisions",
                    value
                );
        }

        
        public async ValueTask<decimal> get_partitioningBBoxRatio()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "partitioningBBoxRatio"
                );
        }
        public ValueTask set_partitioningBBoxRatio(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "partitioningBBoxRatio",
                    value
                );
        }

        
        public async ValueTask<bool> get_mustDepthSortFacets()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "mustDepthSortFacets"
                );
        }
        public ValueTask set_mustDepthSortFacets(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mustDepthSortFacets",
                    value
                );
        }

        private Vector3 __facetDepthSortFrom;
        public async ValueTask<Vector3> get_facetDepthSortFrom()
        {
            if(__facetDepthSortFrom == null)
            {
                __facetDepthSortFrom = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_facetDepthSortFrom(Vector3 value)
        {
__facetDepthSortFrom = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "facetDepthSortFrom",
                    value
                );
        }

        
        public async ValueTask<bool> get_isFacetDataEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isFacetDataEnabled"
                );
        }

        
        public async ValueTask<decimal> get_visibility()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "visibility"
                );
        }
        public ValueTask set_visibility(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visibility",
                    value
                );
        }

        
        public async ValueTask<decimal> get_renderingGroupId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderingGroupId"
                );
        }
        public ValueTask set_renderingGroupId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderingGroupId",
                    value
                );
        }

        private Material __material;
        public async ValueTask<Material> get_material()
        {
            if(__material == null)
            {
                __material = await EventHorizonBlazorInterop.GetClass<Material>(
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
        public ValueTask set_material(Material value)
        {
__material = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "material",
                    value
                );
        }

        
        public async ValueTask<bool> get_receiveShadows()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "receiveShadows"
                );
        }
        public ValueTask set_receiveShadows(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "receiveShadows",
                    value
                );
        }

        
        public async ValueTask<bool> get_hasVertexAlpha()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasVertexAlpha"
                );
        }
        public ValueTask set_hasVertexAlpha(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hasVertexAlpha",
                    value
                );
        }

        
        public async ValueTask<bool> get_useVertexColors()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useVertexColors"
                );
        }
        public ValueTask set_useVertexColors(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useVertexColors",
                    value
                );
        }

        
        public async ValueTask<bool> get_computeBonesUsingShaders()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "computeBonesUsingShaders"
                );
        }
        public ValueTask set_computeBonesUsingShaders(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "computeBonesUsingShaders",
                    value
                );
        }

        
        public async ValueTask<decimal> get_numBoneInfluencers()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "numBoneInfluencers"
                );
        }
        public ValueTask set_numBoneInfluencers(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "numBoneInfluencers",
                    value
                );
        }

        
        public async ValueTask<bool> get_applyFog()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "applyFog"
                );
        }
        public ValueTask set_applyFog(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "applyFog",
                    value
                );
        }

        
        public async ValueTask<decimal> get_layerMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
        }
        public ValueTask set_layerMask(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "layerMask",
                    value
                );
        }

        
        public async ValueTask<decimal> get_collisionMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "collisionMask"
                );
        }
        public ValueTask set_collisionMask(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionMask",
                    value
                );
        }

        
        public async ValueTask<bool> get_collisionResponse()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collisionResponse"
                );
        }
        public ValueTask set_collisionResponse(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionResponse",
                    value
                );
        }

        
        public async ValueTask<decimal> get_collisionGroup()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "collisionGroup"
                );
        }
        public ValueTask set_collisionGroup(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionGroup",
                    value
                );
        }

        
        public async ValueTask<AbstractMesh[]> get_surroundingMeshes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "surroundingMeshes",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_surroundingMeshes(AbstractMesh[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "surroundingMeshes",
                    value
                );
        }

        
        public async ValueTask<Light[]> get_lightSources()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Light>(
                    this.___guid,
                    "lightSources",
                    (entity) =>
                    {
                        return new Light() { ___guid = entity.___guid };
                    }
                );
        }

        private Skeleton __skeleton;
        public async ValueTask<Skeleton> get_skeleton()
        {
            if(__skeleton == null)
            {
                __skeleton = await EventHorizonBlazorInterop.GetClass<Skeleton>(
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
        public ValueTask set_skeleton(Skeleton value)
        {
__skeleton = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skeleton",
                    value
                );
        }

        private Vector3 __scaling;
        public async ValueTask<Vector3> get_scaling()
        {
            if(__scaling == null)
            {
                __scaling = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_scaling(Vector3 value)
        {
__scaling = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaling",
                    value
                );
        }

        
        public async ValueTask<bool> get_isBlocked()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBlocked"
                );
        }

        
        public async ValueTask<bool> get_useBones()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useBones"
                );
        }

        
        public async ValueTask<bool> get_isAnInstance()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isAnInstance"
                );
        }

        
        public async ValueTask<bool> get_hasInstances()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasInstances"
                );
        }

        
        public async ValueTask<bool> get_hasThinInstances()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasThinInstances"
                );
        }

        
        public async ValueTask<bool> get_checkCollisions()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "checkCollisions"
                );
        }
        public ValueTask set_checkCollisions(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "checkCollisions",
                    value
                );
        }

        private Collider __collider;
        public async ValueTask<Collider> get_collider()
        {
            if(__collider == null)
            {
                __collider = await EventHorizonBlazorInterop.GetClass<Collider>(
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
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_cullingStrategy()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cullingStrategy"
                );
        }
        public ValueTask set_cullingStrategy(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cullingStrategy",
                    value
                );
        }

        private Observable<AbstractMesh> __onCollideObservable;
        public async ValueTask<Observable<AbstractMesh>> get_onCollideObservable()
        {
            if(__onCollideObservable == null)
            {
                __onCollideObservable = await EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
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
        public ValueTask set_onCollideObservable(Observable<AbstractMesh> value)
        {
__onCollideObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCollideObservable",
                    value
                );
        }

        private Observable<Vector3> __onCollisionPositionChangeObservable;
        public async ValueTask<Observable<Vector3>> get_onCollisionPositionChangeObservable()
        {
            if(__onCollisionPositionChangeObservable == null)
            {
                __onCollisionPositionChangeObservable = await EventHorizonBlazorInterop.GetClass<Observable<Vector3>>(
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
        public ValueTask set_onCollisionPositionChangeObservable(Observable<Vector3> value)
        {
__onCollisionPositionChangeObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCollisionPositionChangeObservable",
                    value
                );
        }

        private Observable<AbstractMesh> __onMaterialChangedObservable;
        public async ValueTask<Observable<AbstractMesh>> get_onMaterialChangedObservable()
        {
            if(__onMaterialChangedObservable == null)
            {
                __onMaterialChangedObservable = await EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
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
        public ValueTask set_onMaterialChangedObservable(Observable<AbstractMesh> value)
        {
__onMaterialChangedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onMaterialChangedObservable",
                    value
                );
        }

        
        public async ValueTask<bool> get_definedFacingForward()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "definedFacingForward"
                );
        }
        public ValueTask set_definedFacingForward(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "definedFacingForward",
                    value
                );
        }

        
        public async ValueTask<decimal> get_alphaIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alphaIndex"
                );
        }
        public ValueTask set_alphaIndex(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alphaIndex",
                    value
                );
        }

        
        public async ValueTask<bool> get_isVisible()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isVisible"
                );
        }
        public ValueTask set_isVisible(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isVisible",
                    value
                );
        }

        
        public async ValueTask<bool> get_isPickable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPickable"
                );
        }
        public ValueTask set_isPickable(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isPickable",
                    value
                );
        }

        
        public async ValueTask<bool> get_showSubMeshesBoundingBox()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "showSubMeshesBoundingBox"
                );
        }
        public ValueTask set_showSubMeshesBoundingBox(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "showSubMeshesBoundingBox",
                    value
                );
        }

        
        public async ValueTask<bool> get_isBlocker()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBlocker"
                );
        }
        public ValueTask set_isBlocker(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isBlocker",
                    value
                );
        }

        
        public async ValueTask<bool> get_enablePointerMoveEvents()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enablePointerMoveEvents"
                );
        }
        public ValueTask set_enablePointerMoveEvents(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enablePointerMoveEvents",
                    value
                );
        }

        private Color3 __outlineColor;
        public async ValueTask<Color3> get_outlineColor()
        {
            if(__outlineColor == null)
            {
                __outlineColor = await EventHorizonBlazorInterop.GetClass<Color3>(
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
        public ValueTask set_outlineColor(Color3 value)
        {
__outlineColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outlineColor",
                    value
                );
        }

        
        public async ValueTask<decimal> get_outlineWidth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "outlineWidth"
                );
        }
        public ValueTask set_outlineWidth(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outlineWidth",
                    value
                );
        }

        private Color3 __overlayColor;
        public async ValueTask<Color3> get_overlayColor()
        {
            if(__overlayColor == null)
            {
                __overlayColor = await EventHorizonBlazorInterop.GetClass<Color3>(
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
        public ValueTask set_overlayColor(Color3 value)
        {
__overlayColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "overlayColor",
                    value
                );
        }

        
        public async ValueTask<decimal> get_overlayAlpha()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "overlayAlpha"
                );
        }
        public ValueTask set_overlayAlpha(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "overlayAlpha",
                    value
                );
        }

        
        public async ValueTask<bool> get_useOctreeForRenderingSelection()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useOctreeForRenderingSelection"
                );
        }
        public ValueTask set_useOctreeForRenderingSelection(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useOctreeForRenderingSelection",
                    value
                );
        }

        
        public async ValueTask<bool> get_useOctreeForPicking()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useOctreeForPicking"
                );
        }
        public ValueTask set_useOctreeForPicking(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useOctreeForPicking",
                    value
                );
        }

        
        public async ValueTask<bool> get_useOctreeForCollisions()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useOctreeForCollisions"
                );
        }
        public ValueTask set_useOctreeForCollisions(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useOctreeForCollisions",
                    value
                );
        }

        
        public async ValueTask<bool> get_alwaysSelectAsActiveMesh()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "alwaysSelectAsActiveMesh"
                );
        }
        public ValueTask set_alwaysSelectAsActiveMesh(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alwaysSelectAsActiveMesh",
                    value
                );
        }

        
        public async ValueTask<bool> get_doNotSyncBoundingInfo()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotSyncBoundingInfo"
                );
        }
        public ValueTask set_doNotSyncBoundingInfo(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotSyncBoundingInfo",
                    value
                );
        }

        private AbstractActionManager __actionManager;
        public async ValueTask<AbstractActionManager> get_actionManager()
        {
            if(__actionManager == null)
            {
                __actionManager = await EventHorizonBlazorInterop.GetClass<AbstractActionManager>(
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
        public ValueTask set_actionManager(AbstractActionManager value)
        {
__actionManager = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "actionManager",
                    value
                );
        }

        private Vector3 __ellipsoid;
        public async ValueTask<Vector3> get_ellipsoid()
        {
            if(__ellipsoid == null)
            {
                __ellipsoid = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_ellipsoid(Vector3 value)
        {
__ellipsoid = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ellipsoid",
                    value
                );
        }

        private Vector3 __ellipsoidOffset;
        public async ValueTask<Vector3> get_ellipsoidOffset()
        {
            if(__ellipsoidOffset == null)
            {
                __ellipsoidOffset = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_ellipsoidOffset(Vector3 value)
        {
__ellipsoidOffset = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ellipsoidOffset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_edgesWidth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "edgesWidth"
                );
        }
        public ValueTask set_edgesWidth(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "edgesWidth",
                    value
                );
        }

        private Color4 __edgesColor;
        public async ValueTask<Color4> get_edgesColor()
        {
            if(__edgesColor == null)
            {
                __edgesColor = await EventHorizonBlazorInterop.GetClass<Color4>(
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
        public ValueTask set_edgesColor(Color4 value)
        {
__edgesColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "edgesColor",
                    value
                );
        }

        
        public async ValueTask<SubMesh[]> get_subMeshes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<SubMesh>(
                    this.___guid,
                    "subMeshes",
                    (entity) =>
                    {
                        return new SubMesh() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_subMeshes(SubMesh[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "subMeshes",
                    value
                );
        }

        private Observable<AbstractMesh> __onRebuildObservable;
        public async ValueTask<Observable<AbstractMesh>> get_onRebuildObservable()
        {
            if(__onRebuildObservable == null)
            {
                __onRebuildObservable = await EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
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
        public ValueTask set_onRebuildObservable(Observable<AbstractMesh> value)
        {
__onRebuildObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onRebuildObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public AbstractMesh() : base() { }

        public AbstractMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<AbstractMesh> NewAbstractMesh(
            string name, Scene scene = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AbstractMesh" },
                name, scene
            );

            return new AbstractMesh(entity);
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

        public async ValueTask<string> toString(System.Nullable<bool> fullDetails = null)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }

        public async ValueTask<AbstractMesh> getLOD(Camera camera)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLOD" }, camera
                }
            );
        }

        public async ValueTask<decimal> getTotalVertices()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTotalVertices" }
                }
            );
        }

        public async ValueTask<decimal> getTotalIndices()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTotalIndices" }
                }
            );
        }

        public async ValueTask<decimal[]> getIndices()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndices" }
                }
            );
        }

        public async ValueTask<decimal[]> getVerticesData(string kind)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" }, kind
                }
            );
        }

        public async ValueTask<AbstractMesh> setVerticesData(string kind, decimal[] data, System.Nullable<bool> updatable = null, System.Nullable<decimal> stride = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVerticesData" }, kind, data, updatable, stride
                }
            );
        }

        public async ValueTask<AbstractMesh> updateVerticesData(string kind, decimal[] data, System.Nullable<bool> updateExtends = null, System.Nullable<bool> makeItUnique = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updateVerticesData" }, kind, data, updateExtends, makeItUnique
                }
            );
        }

        public async ValueTask<AbstractMesh> setIndices(decimal[] indices, System.Nullable<decimal> totalVertices = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setIndices" }, indices, totalVertices
                }
            );
        }

        public async ValueTask<bool> isVerticesDataPresent(string kind)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isVerticesDataPresent" }, kind
                }
            );
        }

        public async ValueTask<BoundingInfo> getBoundingInfo()
        {
            return await EventHorizonBlazorInterop.FuncClass<BoundingInfo>(
                entity => new BoundingInfo() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getBoundingInfo" }
                }
            );
        }

        public async ValueTask<AbstractMesh> normalizeToUnitCube(System.Nullable<bool> includeDescendants = null, System.Nullable<bool> ignoreRotation = null, ActionCallback<AbstractMesh> predicate = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "normalizeToUnitCube" }, includeDescendants, ignoreRotation, predicate
                }
            );
        }

        public async ValueTask<AbstractMesh> setBoundingInfo(BoundingInfo boundingInfo)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setBoundingInfo" }, boundingInfo
                }
            );
        }

        public async ValueTask<Matrix> getWorldMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getWorldMatrix" }
                }
            );
        }

        public async ValueTask<AbstractMesh> movePOV(decimal amountRight, decimal amountUp, decimal amountForward)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "movePOV" }, amountRight, amountUp, amountForward
                }
            );
        }

        public async ValueTask<Vector3> calcMovePOV(decimal amountRight, decimal amountUp, decimal amountForward)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "calcMovePOV" }, amountRight, amountUp, amountForward
                }
            );
        }

        public async ValueTask<AbstractMesh> rotatePOV(decimal flipBack, decimal twirlClockwise, decimal tiltRight)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "rotatePOV" }, flipBack, twirlClockwise, tiltRight
                }
            );
        }

        public async ValueTask<Vector3> calcRotatePOV(decimal flipBack, decimal twirlClockwise, decimal tiltRight)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "calcRotatePOV" }, flipBack, twirlClockwise, tiltRight
                }
            );
        }

        public async ValueTask<AbstractMesh> refreshBoundingInfo(System.Nullable<bool> applySkeleton = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "refreshBoundingInfo" }, applySkeleton
                }
            );
        }

        public async ValueTask<bool> isInFrustum(Plane[] frustumPlanes)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isInFrustum" }, frustumPlanes
                }
            );
        }

        public async ValueTask<bool> isCompletelyInFrustum(Plane[] frustumPlanes)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isCompletelyInFrustum" }, frustumPlanes
                }
            );
        }

        public async ValueTask<bool> intersectsMesh(AbstractMesh mesh, System.Nullable<bool> precise = null, System.Nullable<bool> includeDescendants = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsMesh" }, mesh, precise, includeDescendants
                }
            );
        }

        public async ValueTask<bool> intersectsPoint(Vector3 point)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "intersectsPoint" }, point
                }
            );
        }

        public async ValueTask<AbstractMesh> moveWithCollisions(Vector3 displacement)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "moveWithCollisions" }, displacement
                }
            );
        }

        public async ValueTask<PickingInfo> intersects(Ray ray, System.Nullable<bool> fastCheck = null, ActionCallback<Vector3, Vector3, Vector3, Ray> trianglePredicate = null, System.Nullable<bool> onlyBoundingInfo = null, Matrix worldToUse = null, System.Nullable<bool> skipBoundingInfo = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "intersects" }, ray, fastCheck, trianglePredicate, onlyBoundingInfo, worldToUse, skipBoundingInfo
                }
            );
        }

        public async ValueTask<AbstractMesh> clone(string name, Node newParent, System.Nullable<bool> doNotCloneChildren = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren
                }
            );
        }

        public async ValueTask<AbstractMesh> releaseSubMeshes()
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "releaseSubMeshes" }
                }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> doNotRecurse = null, System.Nullable<bool> disposeMaterialAndTextures = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, doNotRecurse, disposeMaterialAndTextures
                }
            );
        }

        public async ValueTask<AbstractMesh> addChild(AbstractMesh mesh)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addChild" }, mesh
                }
            );
        }

        public async ValueTask<AbstractMesh> removeChild(AbstractMesh mesh)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeChild" }, mesh
                }
            );
        }

        public async ValueTask<AbstractMesh> updateFacetData()
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updateFacetData" }
                }
            );
        }

        public async ValueTask<Vector3[]> getFacetLocalNormals()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFacetLocalNormals" }
                }
            );
        }

        public async ValueTask<Vector3[]> getFacetLocalPositions()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFacetLocalPositions" }
                }
            );
        }

// getFacetLocalPartitioning is not supported by the platform yet

        public async ValueTask<Vector3> getFacetPosition(decimal i)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getFacetPosition" }, i
                }
            );
        }

        public async ValueTask<AbstractMesh> getFacetPositionToRef(decimal i, Vector3 @ref)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getFacetPositionToRef" }, i, @ref
                }
            );
        }

        public async ValueTask<Vector3> getFacetNormal(decimal i)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getFacetNormal" }, i
                }
            );
        }

        public async ValueTask<AbstractMesh> getFacetNormalToRef(decimal i, Vector3 @ref)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getFacetNormalToRef" }, i, @ref
                }
            );
        }

        public async ValueTask<decimal[]> getFacetsAtLocalCoordinates(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFacetsAtLocalCoordinates" }, x, y, z
                }
            );
        }

        public async ValueTask<decimal> getClosestFacetAtCoordinates(decimal x, decimal y, decimal z, Vector3 projected = null, System.Nullable<bool> checkFace = null, System.Nullable<bool> facing = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getClosestFacetAtCoordinates" }, x, y, z, projected, checkFace, facing
                }
            );
        }

        public async ValueTask<decimal> getClosestFacetAtLocalCoordinates(decimal x, decimal y, decimal z, Vector3 projected = null, System.Nullable<bool> checkFace = null, System.Nullable<bool> facing = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getClosestFacetAtLocalCoordinates" }, x, y, z, projected, checkFace, facing
                }
            );
        }

        public async ValueTask<CachedEntity> getFacetDataParameters()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getFacetDataParameters" }
                }
            );
        }

        public async ValueTask<AbstractMesh> disableFacetData()
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "disableFacetData" }
                }
            );
        }

        public async ValueTask<AbstractMesh> updateIndices(decimal[] indices, System.Nullable<decimal> offset = null, System.Nullable<bool> gpuMemoryOnly = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updateIndices" }, indices, offset, gpuMemoryOnly
                }
            );
        }

        public async ValueTask<AbstractMesh> createNormals(bool updatable)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createNormals" }, updatable
                }
            );
        }

        public async ValueTask<AbstractMesh> alignWithNormal(Vector3 normal, Vector3 upDirection = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "alignWithNormal" }, normal, upDirection
                }
            );
        }

        public async ValueTask<AbstractMesh> disableEdgesRendering()
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "disableEdgesRendering" }
                }
            );
        }

        public async ValueTask<AbstractMesh> enableEdgesRendering(System.Nullable<decimal> epsilon = null, System.Nullable<bool> checkVerticesInsteadOfIndices = null, IEdgesRendererOptions options = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "enableEdgesRendering" }, epsilon, checkVerticesInsteadOfIndices, options
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity[]> getConnectedParticleSystems()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<IParticleSystemCachedEntity>(
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