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
    public class InstancedMesh : AbstractMesh
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
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

        
        public bool receiveShadows
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "receiveShadows"
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

        private Mesh __sourceMesh;
        public Mesh sourceMesh
        {
            get
            {
            if(__sourceMesh == null)
            {
                __sourceMesh = EventHorizonBlazorInteropt.GetClass<Mesh>(
                    this.___guid,
                    "sourceMesh",
                    (entity) =>
                    {
                        return new Mesh(entity);
                    }
                );
            }
            return __sourceMesh;
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

        public InstancedMesh(
            string name, Mesh source
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "InstancedMesh" },
                name, source
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

        public bool isReady(System.Nullable<bool> completeCheck = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, completeCheck
                }
            );
        }

        public decimal[] getVerticesData(string kind, System.Nullable<bool> copyWhenShared = null)
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" }, kind, copyWhenShared
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

        public Mesh updateVerticesData(string kind, decimal[] data, System.Nullable<bool> updateExtends = null, System.Nullable<bool> makeItUnique = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "updateVerticesData" }, kind, data, updateExtends, makeItUnique
                }
            );
        }

        public Mesh setIndices(decimal[] indices, System.Nullable<decimal> totalVertices = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
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

        public decimal[] getIndices()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndices" }
                }
            );
        }

        public InstancedMesh refreshBoundingInfo(System.Nullable<bool> applySkeleton = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<InstancedMesh>(
                entity => new InstancedMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "refreshBoundingInfo" }, applySkeleton
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

        public InstancedMesh clone(string name, Node newParent = null, System.Nullable<bool> doNotCloneChildren = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<InstancedMesh>(
                entity => new InstancedMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren
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
        #endregion
    }
}