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
    public class VertexData : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal FRONTSIDE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".VertexData.FRONTSIDE"
                );
            }
        }

        
        public static decimal BACKSIDE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".VertexData.BACKSIDE"
                );
            }
        }

        
        public static decimal DOUBLESIDE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".VertexData.DOUBLESIDE"
                );
            }
        }

        
        public static decimal DEFAULTSIDE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".VertexData.DEFAULTSIDE"
                );
            }
        }
        #endregion

        #region Static Methods
        public static VertexData ExtractFromMesh(Mesh mesh, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<VertexData>(
                entity => new VertexData(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "ExtractFromMesh" }, mesh, copyWhenShared, forceCopy
                }
            );
        }

        public static VertexData ExtractFromGeometry(Geometry geometry, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<VertexData>(
                entity => new VertexData(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "ExtractFromGeometry" }, geometry, copyWhenShared, forceCopy
                }
            );
        }

        public static CachedEntity CreateRibbon(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateRibbon" }, options
                }
            );
        }

        public static CachedEntity CreateBox(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateBox" }, options
                }
            );
        }

        public static CachedEntity CreateTiledBox(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateTiledBox" }, options
                }
            );
        }

        public static CachedEntity CreateTiledPlane(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateTiledPlane" }, options
                }
            );
        }

        public static CachedEntity CreateSphere(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateSphere" }, options
                }
            );
        }

        public static CachedEntity CreateCylinder(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateCylinder" }, options
                }
            );
        }

        public static CachedEntity CreateTorus(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateTorus" }, options
                }
            );
        }

        public static CachedEntity CreateLineSystem(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateLineSystem" }, options
                }
            );
        }

        public static CachedEntity CreateDashedLines(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateDashedLines" }, options
                }
            );
        }

        public static CachedEntity CreateGround(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateGround" }, options
                }
            );
        }

        public static CachedEntity CreateTiledGround(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateTiledGround" }, options
                }
            );
        }

        public static CachedEntity CreateGroundFromHeightMap(CachedEntity options)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateGroundFromHeightMap" }, options
                }
            );
        }

        public static CachedEntity CreatePlane(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreatePlane" }, options
                }
            );
        }

        public static CachedEntity CreateDisc(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateDisc" }, options
                }
            );
        }

        public static VertexData CreatePolygon(Mesh polygon, decimal sideOrientation, Vector4[] fUV = null, Color4[] fColors = null, Vector4 frontUVs = null, Vector4 backUVs = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<VertexData>(
                entity => new VertexData(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreatePolygon" }, polygon, sideOrientation, fUV, fColors, frontUVs, backUVs
                }
            );
        }

        public static CachedEntity CreateIcoSphere(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateIcoSphere" }, options
                }
            );
        }

        public static CachedEntity CreatePolyhedron(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreatePolyhedron" }, options
                }
            );
        }

        public static CachedEntity CreateTorusKnot(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateTorusKnot" }, options
                }
            );
        }

        public static void ComputeNormals(CachedEntity positions, CachedEntity indices, CachedEntity normals, CachedEntity options = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "ComputeNormals" }, positions, indices, normals, options
                }
            );
        }

        public static void ImportVertexData(CachedEntity parsedVertexData, Geometry geometry)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "positions"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "normals"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "tangents"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "uvs"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "uvs2"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "uvs3"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "uvs4"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "uvs5"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "uvs6"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "colors"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "matricesIndices"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "matricesWeights"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "matricesIndicesExtra"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "matricesWeightsExtra"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "indices"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "set" }, data, kind
                }
            );
        }

        public VertexData applyToMesh(Mesh mesh, System.Nullable<bool> updatable = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<VertexData>(
                entity => new VertexData(entity),
                new object[] 
                {
                    new string[] { this.___guid, "applyToMesh" }, mesh, updatable
                }
            );
        }

        public VertexData applyToGeometry(Geometry geometry, System.Nullable<bool> updatable = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<VertexData>(
                entity => new VertexData(entity),
                new object[] 
                {
                    new string[] { this.___guid, "applyToGeometry" }, geometry, updatable
                }
            );
        }

        public VertexData updateMesh(Mesh mesh)
        {
            return EventHorizonBlazorInteropt.FuncClass<VertexData>(
                entity => new VertexData(entity),
                new object[] 
                {
                    new string[] { this.___guid, "updateMesh" }, mesh
                }
            );
        }

        public VertexData updateGeometry(Geometry geometry)
        {
            return EventHorizonBlazorInteropt.FuncClass<VertexData>(
                entity => new VertexData(entity),
                new object[] 
                {
                    new string[] { this.___guid, "updateGeometry" }, geometry
                }
            );
        }

        public VertexData transform(Matrix matrix)
        {
            return EventHorizonBlazorInteropt.FuncClass<VertexData>(
                entity => new VertexData(entity),
                new object[] 
                {
                    new string[] { this.___guid, "transform" }, matrix
                }
            );
        }

        public VertexData merge(VertexData other, System.Nullable<bool> use32BitsIndices = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<VertexData>(
                entity => new VertexData(entity),
                new object[] 
                {
                    new string[] { this.___guid, "merge" }, other, use32BitsIndices
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}