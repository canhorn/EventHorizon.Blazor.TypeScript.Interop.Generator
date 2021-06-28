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

    
    
    [JsonConverter(typeof(CachedEntityConverter<VertexData>))]
    public class VertexData : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal FRONTSIDE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexData.FRONTSIDE"
                );
            }
        }

        
        public static decimal BACKSIDE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexData.BACKSIDE"
                );
            }
        }

        
        public static decimal DOUBLESIDE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexData.DOUBLESIDE"
                );
            }
        }

        
        public static decimal DEFAULTSIDE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexData.DEFAULTSIDE"
                );
            }
        }
        #endregion

        #region Static Methods
        public static VertexData ExtractFromMesh(Mesh mesh, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "ExtractFromMesh" }, mesh, copyWhenShared, forceCopy
                }
            );
        }

        public static VertexData ExtractFromGeometry(Geometry geometry, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "ExtractFromGeometry" }, geometry, copyWhenShared, forceCopy
                }
            );
        }

        public static VertexData CreateRibbon(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateRibbon" }, options
                }
            );
        }

        public static VertexData CreateBox(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateBox" }, options
                }
            );
        }

        public static VertexData CreateTiledBox(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateTiledBox" }, options
                }
            );
        }

        public static VertexData CreateTiledPlane(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateTiledPlane" }, options
                }
            );
        }

        public static VertexData CreateSphere(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateSphere" }, options
                }
            );
        }

        public static VertexData CreateCylinder(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateCylinder" }, options
                }
            );
        }

        public static VertexData CreateTorus(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateTorus" }, options
                }
            );
        }

        public static VertexData CreateLineSystem(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateLineSystem" }, options
                }
            );
        }

        public static VertexData CreateDashedLines(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateDashedLines" }, options
                }
            );
        }

        public static VertexData CreateGround(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateGround" }, options
                }
            );
        }

        public static VertexData CreateTiledGround(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateTiledGround" }, options
                }
            );
        }

        public static VertexData CreateGroundFromHeightMap(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateGroundFromHeightMap" }, options
                }
            );
        }

        public static VertexData CreatePlane(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreatePlane" }, options
                }
            );
        }

        public static VertexData CreateDisc(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateDisc" }, options
                }
            );
        }

        public static VertexData CreatePolygon(Mesh polygon, decimal sideOrientation, Vector4[] fUV = null, Color4[] fColors = null, Vector4 frontUVs = null, Vector4 backUVs = null, System.Nullable<bool> wrap = null)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreatePolygon" }, polygon, sideOrientation, fUV, fColors, frontUVs, backUVs, wrap
                }
            );
        }

        public static VertexData CreateIcoSphere(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateIcoSphere" }, options
                }
            );
        }

        public static VertexData CreatePolyhedron(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreatePolyhedron" }, options
                }
            );
        }

        public static VertexData CreateCapsule(ICreateCapsuleOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateCapsule" }, options
                }
            );
        }

        public static VertexData CreateTorusKnot(object options)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "CreateTorusKnot" }, options
                }
            );
        }

        public static void ComputeNormals(object positions, object indices, object normals, object options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "ComputeNormals" }, positions, indices, normals, options
                }
            );
        }

        public static void ImportVertexData(object parsedVertexData, Geometry geometry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "VertexData", "ImportVertexData" }, parsedVertexData, geometry
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public decimal[] positions
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "positions"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "positions",
                    value
                );
            }
        }

        
        public decimal[] normals
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "normals"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normals",
                    value
                );
            }
        }

        
        public decimal[] tangents
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "tangents"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tangents",
                    value
                );
            }
        }

        
        public decimal[] uvs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs",
                    value
                );
            }
        }

        
        public decimal[] uvs2
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs2"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs2",
                    value
                );
            }
        }

        
        public decimal[] uvs3
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs3"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs3",
                    value
                );
            }
        }

        
        public decimal[] uvs4
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs4"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs4",
                    value
                );
            }
        }

        
        public decimal[] uvs5
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs5"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs5",
                    value
                );
            }
        }

        
        public decimal[] uvs6
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs6"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs6",
                    value
                );
            }
        }

        
        public decimal[] colors
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "colors"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colors",
                    value
                );
            }
        }

        
        public decimal[] matricesIndices
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "matricesIndices"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matricesIndices",
                    value
                );
            }
        }

        
        public decimal[] matricesWeights
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "matricesWeights"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matricesWeights",
                    value
                );
            }
        }

        
        public decimal[] matricesIndicesExtra
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "matricesIndicesExtra"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matricesIndicesExtra",
                    value
                );
            }
        }

        
        public decimal[] matricesWeightsExtra
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "matricesWeightsExtra"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matricesWeightsExtra",
                    value
                );
            }
        }

        
        public decimal[] indices
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "indices"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indices",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public VertexData() : base() { }

        public VertexData(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public void set(decimal[] data, string kind)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "set" }, data, kind
                }
            );
        }

        public VertexData applyToMesh(Mesh mesh, System.Nullable<bool> updatable = null)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyToMesh" }, mesh, updatable
                }
            );
        }

        public VertexData applyToGeometry(Geometry geometry, System.Nullable<bool> updatable = null)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "applyToGeometry" }, geometry, updatable
                }
            );
        }

        public VertexData updateMesh(Mesh mesh)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateMesh" }, mesh
                }
            );
        }

        public VertexData updateGeometry(Geometry geometry)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updateGeometry" }, geometry
                }
            );
        }

        public VertexData transform(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transform" }, matrix
                }
            );
        }

        public VertexData merge(VertexData other, System.Nullable<bool> use32BitsIndices = null)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "merge" }, other, use32BitsIndices
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}