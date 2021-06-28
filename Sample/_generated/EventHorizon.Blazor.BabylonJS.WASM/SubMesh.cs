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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SubMesh>))]
    public class SubMesh : CachedEntityObject, ICullable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static SubMesh AddToMesh(decimal materialIndex, decimal verticesStart, decimal verticesCount, decimal indexStart, decimal indexCount, AbstractMesh mesh, Mesh renderingMesh = null, System.Nullable<bool> createBoundingBox = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "SubMesh", "AddToMesh" }, materialIndex, verticesStart, verticesCount, indexStart, indexCount, mesh, renderingMesh, createBoundingBox
                }
            );
        }

        public static SubMesh CreateFromIndices(decimal materialIndex, decimal startIndex, decimal indexCount, AbstractMesh mesh, Mesh renderingMesh = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SubMesh>(
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
        public MaterialDefines materialDefines
        {
            get
            {
            if(__materialDefines == null)
            {
                __materialDefines = EventHorizonBlazorInterop.GetClass<MaterialDefines>(
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
            set
            {
__materialDefines = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "materialDefines",
                    value
                );
            }
        }

        private Effect __effect;
        public Effect effect
        {
            get
            {
            if(__effect == null)
            {
                __effect = EventHorizonBlazorInterop.GetClass<Effect>(
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
        }

        
        public bool IsGlobal
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "IsGlobal"
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal materialIndex
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "materialIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "materialIndex",
                    value
                );
            }
        }

        
        public decimal verticesStart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "verticesStart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "verticesStart",
                    value
                );
            }
        }

        
        public decimal verticesCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "verticesCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "verticesCount",
                    value
                );
            }
        }

        
        public decimal indexStart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "indexStart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indexStart",
                    value
                );
            }
        }

        
        public decimal indexCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "indexCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indexCount",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SubMesh() : base() { }

        public SubMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SubMesh(
            decimal materialIndex, decimal verticesStart, decimal verticesCount, decimal indexStart, decimal indexCount, AbstractMesh mesh, Mesh renderingMesh = null, System.Nullable<bool> createBoundingBox = null, System.Nullable<bool> addToMesh = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "SubMesh" },
                materialIndex, verticesStart, verticesCount, indexStart, indexCount, mesh, renderingMesh, createBoundingBox, addToMesh
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setEffect(Effect effect, MaterialDefines defines = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEffect" }, effect, defines
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

        public SubMesh setBoundingInfo(BoundingInfo boundingInfo)
        {
            return EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBoundingInfo" }, boundingInfo
                }
            );
        }

        public AbstractMesh getMesh()
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMesh" }
                }
            );
        }

        public Mesh getRenderingMesh()
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRenderingMesh" }
                }
            );
        }

        public AbstractMesh getReplacementMesh()
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getReplacementMesh" }
                }
            );
        }

        public AbstractMesh getEffectiveMesh()
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEffectiveMesh" }
                }
            );
        }

        public Material getMaterial()
        {
            return EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMaterial" }
                }
            );
        }

        public SubMesh refreshBoundingInfo(decimal[] data = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "refreshBoundingInfo" }, data
                }
            );
        }

        public SubMesh updateBoundingInfo(Matrix world)
        {
            return EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateBoundingInfo" }, world
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

        public SubMesh render(bool enableAlphaMode)
        {
            return EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "render" }, enableAlphaMode
                }
            );
        }

        public bool canIntersects(Ray ray)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "canIntersects" }, ray
                }
            );
        }

        public IntersectionInfo intersects(Ray ray, Vector3[] positions, decimal[] indices, System.Nullable<bool> fastCheck = null, ActionResultCallback<Vector3, Vector3, Vector3, Ray, bool> trianglePredicate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IntersectionInfo>(
                entity => new IntersectionInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "intersects" }, ray, positions, indices, fastCheck, trianglePredicate
                }
            );
        }

        public SubMesh clone(AbstractMesh newMesh, Mesh newRenderingMesh = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SubMesh>(
                entity => new SubMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, newMesh, newRenderingMesh
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}