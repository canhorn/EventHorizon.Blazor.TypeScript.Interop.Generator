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

    
    
    [JsonConverter(typeof(CachedEntityConverter<VertexData>))]
    public class VertexData : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_FRONTSIDE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexData.FRONTSIDE"
                );
        }

        
        public static async ValueTask<decimal> get_BACKSIDE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexData.BACKSIDE"
                );
        }

        
        public static async ValueTask<decimal> get_DOUBLESIDE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexData.DOUBLESIDE"
                );
        }

        
        public static async ValueTask<decimal> get_DEFAULTSIDE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "VertexData.DEFAULTSIDE"
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<VertexData> ExtractFromMesh(Mesh mesh, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "ExtractFromMesh" }, mesh, copyWhenShared, forceCopy
                }
            );
        }

        public static async ValueTask<VertexData> ExtractFromGeometry(Geometry geometry, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "ExtractFromGeometry" }, geometry, copyWhenShared, forceCopy
                }
            );
        }

        public static async ValueTask<VertexData> CreateRibbon(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateRibbon" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateBox(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateBox" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateTiledBox(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateTiledBox" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateTiledPlane(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateTiledPlane" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateSphere(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateSphere" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateCylinder(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateCylinder" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateTorus(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateTorus" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateLineSystem(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateLineSystem" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateDashedLines(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateDashedLines" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateGround(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateGround" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateTiledGround(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateTiledGround" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateGroundFromHeightMap(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateGroundFromHeightMap" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreatePlane(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreatePlane" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateDisc(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateDisc" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreatePolygon(Mesh polygon, decimal sideOrientation, Vector4[] fUV = null, Color4[] fColors = null, Vector4 frontUVs = null, Vector4 backUVs = null, System.Nullable<bool> wrap = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreatePolygon" }, polygon, sideOrientation, fUV, fColors, frontUVs, backUVs, wrap
                }
            );
        }

        public static async ValueTask<VertexData> CreateIcoSphere(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateIcoSphere" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreatePolyhedron(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreatePolyhedron" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateCapsule(ICreateCapsuleOptions options = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateCapsule" }, options
                }
            );
        }

        public static async ValueTask<VertexData> CreateTorusKnot(object options)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "CreateTorusKnot" }, options
                }
            );
        }

        public static async ValueTask ComputeNormals(object positions, object indices, object normals, object options = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "VertexData", "ComputeNormals" }, positions, indices, normals, options
                }
            );
        }

        public static async ValueTask ImportVertexData(object parsedVertexData, Geometry geometry)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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
        
        public async ValueTask<decimal[]> get_positions()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "positions"
                );
        }
        public ValueTask set_positions(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "positions",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_normals()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "normals"
                );
        }
        public ValueTask set_normals(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normals",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_tangents()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "tangents"
                );
        }
        public ValueTask set_tangents(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "tangents",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_uvs()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs"
                );
        }
        public ValueTask set_uvs(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_uvs2()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs2"
                );
        }
        public ValueTask set_uvs2(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs2",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_uvs3()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs3"
                );
        }
        public ValueTask set_uvs3(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs3",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_uvs4()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs4"
                );
        }
        public ValueTask set_uvs4(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs4",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_uvs5()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs5"
                );
        }
        public ValueTask set_uvs5(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs5",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_uvs6()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "uvs6"
                );
        }
        public ValueTask set_uvs6(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uvs6",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_colors()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "colors"
                );
        }
        public ValueTask set_colors(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colors",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_matricesIndices()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "matricesIndices"
                );
        }
        public ValueTask set_matricesIndices(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matricesIndices",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_matricesWeights()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "matricesWeights"
                );
        }
        public ValueTask set_matricesWeights(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matricesWeights",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_matricesIndicesExtra()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "matricesIndicesExtra"
                );
        }
        public ValueTask set_matricesIndicesExtra(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matricesIndicesExtra",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_matricesWeightsExtra()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "matricesWeightsExtra"
                );
        }
        public ValueTask set_matricesWeightsExtra(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matricesWeightsExtra",
                    value
                );
        }

        
        public async ValueTask<decimal[]> get_indices()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "indices"
                );
        }
        public ValueTask set_indices(decimal[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "indices",
                    value
                );
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
        public async ValueTask set(decimal[] data, string kind)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "set" }, data, kind
                }
            );
        }

        public async ValueTask<VertexData> applyToMesh(Mesh mesh, System.Nullable<bool> updatable = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "applyToMesh" }, mesh, updatable
                }
            );
        }

        public async ValueTask<VertexData> applyToGeometry(Geometry geometry, System.Nullable<bool> updatable = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "applyToGeometry" }, geometry, updatable
                }
            );
        }

        public async ValueTask<VertexData> updateMesh(Mesh mesh)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updateMesh" }, mesh
                }
            );
        }

        public async ValueTask<VertexData> updateGeometry(Geometry geometry)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updateGeometry" }, geometry
                }
            );
        }

        public async ValueTask<VertexData> transform(Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "transform" }, matrix
                }
            );
        }

        public async ValueTask<VertexData> merge(VertexData other, System.Nullable<bool> use32BitsIndices = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexData>(
                entity => new VertexData() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "merge" }, other, use32BitsIndices
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}