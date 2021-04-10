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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Geometry>))]
    public class Geometry : CachedEntityObject, IGetSetVerticesData
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Geometry> CreateGeometryForMesh(Mesh mesh)
        {
            return await EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Geometry", "CreateGeometryForMesh" }, mesh
                }
            );
        }

        public static async ValueTask<Geometry> ExtractFromMesh(Mesh mesh, string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Geometry", "ExtractFromMesh" }, mesh, id
                }
            );
        }

        public static async ValueTask<string> RandomId()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { "BABYLON", "Geometry", "RandomId" }
                }
            );
        }

        public static async ValueTask<Geometry> Parse(object parsedVertexData, Scene scene, string rootUrl)
        {
            return await EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Geometry", "Parse" }, parsedVertexData, scene, rootUrl
                }
            );
        }
        #endregion

        #region Accessors
        private Vector2 __boundingBias;
        public async ValueTask<Vector2> get_boundingBias()
        {
            if(__boundingBias == null)
            {
                __boundingBias = await EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "boundingBias",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __boundingBias;
        }
        public ValueTask set_boundingBias(Vector2 value)
        {
__boundingBias = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boundingBias",
                    value
                );
        }

        
        public async ValueTask<Mesh[]> get_meshes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Mesh>(
                    this.___guid,
                    "meshes",
                    (entity) =>
                    {
                        return new Mesh() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<CachedEntity> get_extend()
        {
            return await EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "extend"
                );
        }

        
        public async ValueTask<bool> get_doNotSerialize()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotSerialize"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<string> get_id()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
        }
        public ValueTask set_id(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
        }

        
        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
        }
        public ValueTask set_uniqueId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniqueId",
                    value
                );
        }

        
        public async ValueTask<decimal> get_delayLoadState()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "delayLoadState"
                );
        }
        public ValueTask set_delayLoadState(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delayLoadState",
                    value
                );
        }

        
        public async ValueTask<string> get_delayLoadingFile()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "delayLoadingFile"
                );
        }
        public ValueTask set_delayLoadingFile(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delayLoadingFile",
                    value
                );
        }

        
        public async ValueTask<bool> get_useBoundingInfoFromGeometry()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useBoundingInfoFromGeometry"
                );
        }
        public ValueTask set_useBoundingInfoFromGeometry(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useBoundingInfoFromGeometry",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Geometry() : base() { }

        public Geometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Geometry> NewGeometry(
            string id, Scene scene, VertexData vertexData = null, System.Nullable<bool> updatable = null, Mesh mesh = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Geometry" },
                id, scene, vertexData, updatable, mesh
            );

            return new Geometry(entity);
        }
        #endregion

        #region Methods
        #region onGeometryUpdated TODO: Get Comments as metadata identification
        private bool _isOnGeometryUpdatedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onGeometryUpdatedActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> onGeometryUpdated(
            Func<Task> callback
        )
        {
            await SetupOnGeometryUpdatedLoop();

            var handle = Guid.NewGuid().ToString();
            _onGeometryUpdatedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupOnGeometryUpdatedLoop()
        {
            if (_isOnGeometryUpdatedEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "onGeometryUpdated",
                "CallOnGeometryUpdatedActions",
                _invokableReference
            );
            _isOnGeometryUpdatedEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnGeometryUpdatedActions()
        {
            foreach (var action in _onGeometryUpdatedActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public async ValueTask<Scene> getScene()
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        public async ValueTask<Engine> getEngine()
        {
            return await EventHorizonBlazorInterop.FuncClass<Engine>(
                entity => new Engine() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEngine" }
                }
            );
        }

        public async ValueTask<bool> isReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public async ValueTask setAllVerticesData(VertexData vertexData, System.Nullable<bool> updatable = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setAllVerticesData" }, vertexData, updatable
                }
            );
        }

        public async ValueTask setVerticesData(string kind, decimal[] data, System.Nullable<bool> updatable = null, System.Nullable<decimal> stride = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setVerticesData" }, kind, data, updatable, stride
                }
            );
        }

        public async ValueTask removeVerticesData(string kind)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeVerticesData" }, kind
                }
            );
        }

        public async ValueTask setVerticesBuffer(VertexBuffer buffer, System.Nullable<decimal> totalVertices = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setVerticesBuffer" }, buffer, totalVertices
                }
            );
        }

        public async ValueTask updateVerticesDataDirectly(string kind, decimal[] data, decimal offset, System.Nullable<bool> useBytes = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateVerticesDataDirectly" }, kind, data, offset, useBytes
                }
            );
        }

        public async ValueTask updateVerticesData(string kind, decimal[] data, System.Nullable<bool> updateExtends = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateVerticesData" }, kind, data, updateExtends
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

        public async ValueTask<decimal[]> getVerticesData(string kind, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" }, kind, copyWhenShared, forceCopy
                }
            );
        }

        public async ValueTask<bool> isVertexBufferUpdatable(string kind)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isVertexBufferUpdatable" }, kind
                }
            );
        }

        public async ValueTask<VertexBuffer> getVertexBuffer(string kind)
        {
            return await EventHorizonBlazorInterop.FuncClass<VertexBuffer>(
                entity => new VertexBuffer() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getVertexBuffer" }, kind
                }
            );
        }

        public async ValueTask<CachedEntity> getVertexBuffers()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getVertexBuffers" }
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

        public async ValueTask<string[]> getVerticesDataKinds()
        {
            return await EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesDataKinds" }
                }
            );
        }

        public async ValueTask updateIndices(decimal[] indices, System.Nullable<decimal> offset = null, System.Nullable<bool> gpuMemoryOnly = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateIndices" }, indices, offset, gpuMemoryOnly
                }
            );
        }

        public async ValueTask setIndices(decimal[] indices, System.Nullable<decimal> totalVertices = null, System.Nullable<bool> updatable = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setIndices" }, indices, totalVertices, updatable
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

        public async ValueTask<decimal[]> getIndices(System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndices" }, copyWhenShared, forceCopy
                }
            );
        }

        public async ValueTask<DataBuffer> getIndexBuffer()
        {
            return await EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getIndexBuffer" }
                }
            );
        }

        public async ValueTask releaseForMesh(Mesh mesh, System.Nullable<bool> shouldDispose = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "releaseForMesh" }, mesh, shouldDispose
                }
            );
        }

        public async ValueTask applyToMesh(Mesh mesh)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "applyToMesh" }, mesh
                }
            );
        }

        public async ValueTask load(Scene scene, ActionCallback onLoaded = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "load" }, scene, onLoaded
                }
            );
        }

        public async ValueTask toLeftHanded()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "toLeftHanded" }
                }
            );
        }

        public async ValueTask<bool> isDisposed()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isDisposed" }
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

        public async ValueTask<Geometry> copy(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copy" }, id
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

        public async ValueTask<CachedEntity> serializeVerticeData()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serializeVerticeData" }
                }
            );
        }
        #endregion
    }
}