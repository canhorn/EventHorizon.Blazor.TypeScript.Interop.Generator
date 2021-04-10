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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SubMesh>))]
    public class SubMesh : CachedEntityObject, ICullable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<SubMesh> AddToMesh(decimal materialIndex, decimal verticesStart, decimal verticesCount, decimal indexStart, decimal indexCount, AbstractMesh mesh, Mesh renderingMesh = null, System.Nullable<bool> createBoundingBox = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SubMesh", "AddToMesh" }, materialIndex, verticesStart, verticesCount, indexStart, indexCount, mesh, renderingMesh, createBoundingBox
                }
            );
        }

        public static async ValueTask<SubMesh> CreateFromIndices(decimal materialIndex, decimal startIndex, decimal indexCount, AbstractMesh mesh, Mesh renderingMesh = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "SubMesh", "CreateFromIndices" }, materialIndex, startIndex, indexCount, mesh, renderingMesh
                }
            );
        }
        #endregion

        #region Accessors
        private MaterialDefines __materialDefines;
        public async ValueTask<MaterialDefines> get_materialDefines()
        {
            if(__materialDefines == null)
            {
                __materialDefines = await EventHorizonBlazorInterop.GetClass<MaterialDefines>(
                    this.___guid,
                    "materialDefines",
                    (entity) =>
                    {
                        return new MaterialDefines() { ___guid = entity.___guid };
                    }
                );
            }
            return __materialDefines;
        }
        public ValueTask set_materialDefines(MaterialDefines value)
        {
__materialDefines = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "materialDefines",
                    value
                );
        }

        private Effect __effect;
        public async ValueTask<Effect> get_effect()
        {
            if(__effect == null)
            {
                __effect = await EventHorizonBlazorInterop.GetClass<Effect>(
                    this.___guid,
                    "effect",
                    (entity) =>
                    {
                        return new Effect() { ___guid = entity.___guid };
                    }
                );
            }
            return __effect;
        }

        
        public async ValueTask<bool> get_IsGlobal()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IsGlobal"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_materialIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "materialIndex"
                );
        }
        public ValueTask set_materialIndex(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "materialIndex",
                    value
                );
        }

        
        public async ValueTask<decimal> get_verticesStart()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "verticesStart"
                );
        }
        public ValueTask set_verticesStart(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "verticesStart",
                    value
                );
        }

        
        public async ValueTask<decimal> get_verticesCount()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "verticesCount"
                );
        }
        public ValueTask set_verticesCount(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "verticesCount",
                    value
                );
        }

        
        public async ValueTask<decimal> get_indexStart()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "indexStart"
                );
        }
        public ValueTask set_indexStart(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indexStart",
                    value
                );
        }

        
        public async ValueTask<decimal> get_indexCount()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "indexCount"
                );
        }
        public ValueTask set_indexCount(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indexCount",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public SubMesh() : base() { }

        public SubMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<SubMesh> NewSubMesh(
            decimal materialIndex, decimal verticesStart, decimal verticesCount, decimal indexStart, decimal indexCount, AbstractMesh mesh, Mesh renderingMesh = null, System.Nullable<bool> createBoundingBox = null, System.Nullable<bool> addToMesh = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "SubMesh" },
                materialIndex, verticesStart, verticesCount, indexStart, indexCount, mesh, renderingMesh, createBoundingBox, addToMesh
            );

            return new SubMesh(entity);
        }
        #endregion

        #region Methods
        public async ValueTask setEffect(Effect effect, MaterialDefines defines = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setEffect" }, effect, defines
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

        public async ValueTask<SubMesh> setBoundingInfo(BoundingInfo boundingInfo)
        {
            return await EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setBoundingInfo" }, boundingInfo
                }
            );
        }

        public async ValueTask<AbstractMesh> getMesh()
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getMesh" }
                }
            );
        }

        public async ValueTask<Mesh> getRenderingMesh()
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRenderingMesh" }
                }
            );
        }

        public async ValueTask<AbstractMesh> getReplacementMesh()
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getReplacementMesh" }
                }
            );
        }

        public async ValueTask<AbstractMesh> getEffectiveMesh()
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEffectiveMesh" }
                }
            );
        }

        public async ValueTask<Material> getMaterial()
        {
            return await EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getMaterial" }
                }
            );
        }

        public async ValueTask<SubMesh> refreshBoundingInfo(decimal[] data = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "refreshBoundingInfo" }, data
                }
            );
        }

        public async ValueTask<SubMesh> updateBoundingInfo(Matrix world)
        {
            return await EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updateBoundingInfo" }, world
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

        public async ValueTask<SubMesh> render(bool enableAlphaMode)
        {
            return await EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "render" }, enableAlphaMode
                }
            );
        }

        public async ValueTask<bool> canIntersects(Ray ray)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "canIntersects" }, ray
                }
            );
        }

        public async ValueTask<IntersectionInfo> intersects(Ray ray, Vector3[] positions, decimal[] indices, System.Nullable<bool> fastCheck = null, ActionCallback<Vector3, Vector3, Vector3, Ray> trianglePredicate = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IntersectionInfo>(
                entity => new IntersectionInfo() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "intersects" }, ray, positions, indices, fastCheck, trianglePredicate
                }
            );
        }

        public async ValueTask<SubMesh> clone(AbstractMesh newMesh, Mesh newRenderingMesh = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, newMesh, newRenderingMesh
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

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}