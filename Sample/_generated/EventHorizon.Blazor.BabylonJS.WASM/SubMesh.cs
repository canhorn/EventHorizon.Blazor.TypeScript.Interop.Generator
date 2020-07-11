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
    public class SubMesh : BaseSubMesh, ICullable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static SubMesh AddToMesh(decimal materialIndex, decimal verticesStart, decimal verticesCount, decimal indexStart, decimal indexCount, AbstractMesh mesh, Mesh renderingMesh = null, System.Nullable<bool> createBoundingBox = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<SubMesh>(
                entity => new SubMesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "SubMesh", "AddToMesh" }, materialIndex, verticesStart, verticesCount, indexStart, indexCount, mesh, renderingMesh, createBoundingBox
                }
            );
        }

        public static SubMesh CreateFromIndices(decimal materialIndex, decimal startIndex, decimal indexCount, AbstractMesh mesh, Mesh renderingMesh = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<SubMesh>(
                entity => new SubMesh(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "SubMesh", "CreateFromIndices" }, materialIndex, startIndex, indexCount, mesh, renderingMesh
                }
            );
        }
        #endregion

        #region Accessors
        
        public bool IsGlobal
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "materialIndex"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "verticesStart"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "verticesCount"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "indexStart"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "indexCount"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            decimal materialIndex, decimal verticesStart, decimal verticesCount, decimal indexStart, decimal indexCount, AbstractMesh mesh, Mesh renderingMesh = null, System.Nullable<bool> createBoundingBox = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "SubMesh" },
                materialIndex, verticesStart, verticesCount, indexStart, indexCount, mesh, renderingMesh, createBoundingBox
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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

        public SubMesh setBoundingInfo(BoundingInfo boundingInfo)
        {
            return EventHorizonBlazorInteropt.FuncClass<SubMesh>(
                entity => new SubMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setBoundingInfo" }, boundingInfo
                }
            );
        }

        public AbstractMesh getMesh()
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getMesh" }
                }
            );
        }

        public Mesh getRenderingMesh()
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getRenderingMesh" }
                }
            );
        }

        public Material getMaterial()
        {
            return EventHorizonBlazorInteropt.FuncClass<Material>(
                entity => new Material(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getMaterial" }
                }
            );
        }

        public SubMesh refreshBoundingInfo(decimal[] data = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<SubMesh>(
                entity => new SubMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "refreshBoundingInfo" }, data
                }
            );
        }

        public SubMesh updateBoundingInfo(Matrix world)
        {
            return EventHorizonBlazorInteropt.FuncClass<SubMesh>(
                entity => new SubMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "updateBoundingInfo" }, world
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

        public SubMesh render(bool enableAlphaMode)
        {
            return EventHorizonBlazorInteropt.FuncClass<SubMesh>(
                entity => new SubMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "render" }, enableAlphaMode
                }
            );
        }

        public bool canIntersects(Ray ray)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "canIntersects" }, ray
                }
            );
        }

        public IntersectionInfo intersects(Ray ray, Vector3[] positions, decimal[] indices, System.Nullable<bool> fastCheck = null, TrianglePickingPredicate trianglePredicate = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IntersectionInfo>(
                entity => new IntersectionInfo(entity),
                new object[] 
                {
                    new string[] { this.___guid, "intersects" }, ray, positions, indices, fastCheck, trianglePredicate
                }
            );
        }

        public SubMesh clone(AbstractMesh newMesh, Mesh newRenderingMesh = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<SubMesh>(
                entity => new SubMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, newMesh, newRenderingMesh
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}