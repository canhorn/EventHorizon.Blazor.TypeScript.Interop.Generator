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

    
    
    [JsonConverter(typeof(CachedEntityConverter<InstancedMesh>))]
    public class InstancedMesh : AbstractMesh
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
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

        
        public async ValueTask<bool> get_receiveShadows()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "receiveShadows"
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

        
        public async ValueTask<decimal> get_visibility()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "visibility"
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

        private Mesh __sourceMesh;
        public async ValueTask<Mesh> get_sourceMesh()
        {
            if(__sourceMesh == null)
            {
                __sourceMesh = await EventHorizonBlazorInterop.GetClass<Mesh>(
                    this.___guid,
                    "sourceMesh",
                    (entity) =>
                    {
                        return new Mesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __sourceMesh;
        }

        
        public async ValueTask<bool> get_isAnInstance()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isAnInstance"
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public InstancedMesh() : base() { }

        public InstancedMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<InstancedMesh> NewInstancedMesh(
            string name, Mesh source
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InstancedMesh" },
                name, source
            );

            return new InstancedMesh(entity);
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

        public async ValueTask<InstancedMesh> createInstance(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<InstancedMesh>(
                entity => new InstancedMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createInstance" }, name
                }
            );
        }

        public async ValueTask<bool> isReady(System.Nullable<bool> completeCheck = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, completeCheck
                }
            );
        }

        public async ValueTask<decimal[]> getVerticesData(string kind, System.Nullable<bool> copyWhenShared = null)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" }, kind, copyWhenShared
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

        public async ValueTask<Mesh> updateVerticesData(string kind, decimal[] data, System.Nullable<bool> updateExtends = null, System.Nullable<bool> makeItUnique = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updateVerticesData" }, kind, data, updateExtends, makeItUnique
                }
            );
        }

        public async ValueTask<Mesh> setIndices(decimal[] indices, System.Nullable<decimal> totalVertices = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
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

        public async ValueTask<decimal[]> getIndices()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndices" }
                }
            );
        }

        public async ValueTask<InstancedMesh> refreshBoundingInfo(System.Nullable<bool> applySkeleton = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<InstancedMesh>(
                entity => new InstancedMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "refreshBoundingInfo" }, applySkeleton
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

        public async ValueTask<InstancedMesh> clone(string name, Node newParent = null, System.Nullable<bool> doNotCloneChildren = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<InstancedMesh>(
                entity => new InstancedMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren
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
        #endregion
    }
}