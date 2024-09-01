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

        public bool receiveShadows
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "receiveShadows"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "receiveShadows", value);
            }
        }

        private Material __material;
        public Material material
        {
            get
            {
                if (__material == null)
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
                EventHorizonBlazorInterop.Set(this.___guid, "material", value);
            }
        }

        public decimal visibility
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "visibility"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "visibility", value);
            }
        }

        private Skeleton __skeleton;
        public Skeleton skeleton
        {
            get
            {
                if (__skeleton == null)
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
                EventHorizonBlazorInterop.Set(this.___guid, "skeleton", value);
            }
        }

        public decimal renderingGroupId
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "renderingGroupId"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "renderingGroupId", value);
            }
        }

        private Mesh __sourceMesh;
        public Mesh sourceMesh
        {
            get
            {
                if (__sourceMesh == null)
                {
                    __sourceMesh = EventHorizonBlazorInterop.GetClass<Mesh>(
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
        }

        public bool isAnInstance
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isAnInstance"); }
        }
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public InstancedMesh()
            : base() { }

        public InstancedMesh(ICachedEntity entity)
            : base(entity) { }

        public InstancedMesh(string name, Mesh source)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InstancedMesh" },
                name,
                source
            );
            ___guid = entity.___guid;
        }

        public InstancedMesh(string name, Scene scene = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InstancedMesh" },
                name,
                scene
            );
            ___guid = entity.___guid;
        }

        public InstancedMesh(string name, Scene scene = null, System.Nullable<bool> isPure = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InstancedMesh" },
                name,
                scene,
                isPure
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public decimal getTotalVertices()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getTotalVertices" } }
            );
        }

        public decimal getTotalIndices()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getTotalIndices" } }
            );
        }

        public InstancedMesh createInstance(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<InstancedMesh>(
                entity => new InstancedMesh() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createInstance" }, name }
            );
        }

        public bool isReady(System.Nullable<bool> completeCheck = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReady" }, completeCheck }
            );
        }

        public decimal[] getVerticesData(
            string kind,
            System.Nullable<bool> copyWhenShared = null,
            System.Nullable<bool> forceCopy = null
        )
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" },
                    kind,
                    copyWhenShared,
                    forceCopy
                }
            );
        }

        public void copyVerticesData(string kind, object vertexData)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "copyVerticesData" }, kind, vertexData }
            );
        }

        public AbstractMesh setVerticesData(
            string kind,
            decimal[] data,
            System.Nullable<bool> updatable = null,
            System.Nullable<decimal> stride = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVerticesData" },
                    kind,
                    data,
                    updatable,
                    stride
                }
            );
        }

        public Mesh updateVerticesData(
            string kind,
            decimal[] data,
            System.Nullable<bool> updateExtends = null,
            System.Nullable<bool> makeItUnique = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateVerticesData" },
                    kind,
                    data,
                    updateExtends,
                    makeItUnique
                }
            );
        }

        public Mesh setIndices(decimal[] indices, System.Nullable<decimal> totalVertices = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setIndices" }, indices, totalVertices }
            );
        }

        public bool isVerticesDataPresent(string kind)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isVerticesDataPresent" }, kind }
            );
        }

        public decimal[] getIndices()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { this.___guid, "getIndices" } }
            );
        }

        public InstancedMesh refreshBoundingInfo(
            System.Nullable<bool> applySkeletonOrOptions = null,
            System.Nullable<bool> applyMorph = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<InstancedMesh>(
                entity => new InstancedMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "refreshBoundingInfo" },
                    applySkeletonOrOptions,
                    applyMorph
                }
            );
        }

        public Matrix getWorldMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getWorldMatrix" } }
            );
        }

        public AbstractMesh getLOD(Camera camera)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getLOD" }, camera }
            );
        }

        public InstancedMesh clone(
            string name,
            Node newParent = null,
            System.Nullable<bool> doNotCloneChildren = null,
            Mesh newSourceMesh = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<InstancedMesh>(
                entity => new InstancedMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" },
                    name,
                    newParent,
                    doNotCloneChildren,
                    newSourceMesh
                }
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

        public TransformNode instantiateHierarchy(
            TransformNode newParent = null,
            System.Nullable<bool> options = null,
            ActionCallback<TransformNode, TransformNode> onNewNodeCreated = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "instantiateHierarchy" },
                    newParent,
                    options,
                    onNewNodeCreated
                }
            );
        }
        #endregion
    }
}
