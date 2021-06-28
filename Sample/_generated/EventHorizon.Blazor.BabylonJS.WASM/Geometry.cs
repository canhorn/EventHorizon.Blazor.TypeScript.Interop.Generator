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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Geometry>))]
    public class Geometry : CachedEntityObject, IGetSetVerticesData
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Geometry CreateGeometryForMesh(Mesh mesh)
        {
            return EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Geometry", "CreateGeometryForMesh" }, mesh
                }
            );
        }

        public static Geometry ExtractFromMesh(Mesh mesh, string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Geometry", "ExtractFromMesh" }, mesh, id
                }
            );
        }

        public static string RandomId()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { "BABYLON", "Geometry", "RandomId" }
                }
            );
        }

        public static Geometry Parse(object parsedVertexData, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInterop.FuncClass<Geometry>(
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
        public Vector2 boundingBias
        {
            get
            {
            if(__boundingBias == null)
            {
                __boundingBias = EventHorizonBlazorInterop.GetClass<Vector2>(
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
            set
            {
__boundingBias = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "boundingBias",
                    value
                );
            }
        }

        
        public Mesh[] meshes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Mesh>(
                    this.___guid,
                    "meshes",
                    (entity) =>
                    {
                        return new Mesh() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public CachedEntity extend
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "extend"
                );
            }
        }

        
        public bool doNotSerialize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotSerialize"
                );
            }
        }
        #endregion

        #region Properties
        
        public string id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        
        public decimal uniqueId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniqueId",
                    value
                );
            }
        }

        
        public decimal delayLoadState
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "delayLoadState"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delayLoadState",
                    value
                );
            }
        }

        
        public string delayLoadingFile
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "delayLoadingFile"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "delayLoadingFile",
                    value
                );
            }
        }

        
        public bool useBoundingInfoFromGeometry
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useBoundingInfoFromGeometry"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useBoundingInfoFromGeometry",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Geometry() : base() { }

        public Geometry(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Geometry(
            string id, Scene scene, VertexData vertexData = null, System.Nullable<bool> updatable = null, Mesh mesh = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Geometry" },
                id, scene, vertexData, updatable, mesh
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region onGeometryUpdated TODO: Get Comments as metadata identification
        private bool _isOnGeometryUpdatedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onGeometryUpdatedActionMap = new Dictionary<string, Func<Task>>();

        public string onGeometryUpdated(
            Func<Task> callback
        )
        {
            SetupOnGeometryUpdatedLoop();

            var handle = Guid.NewGuid().ToString();
            _onGeometryUpdatedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onGeometryUpdated_Remove(
            string handle
        )
        {
            return _onGeometryUpdatedActionMap.Remove(
                handle
            );
        }

        private void SetupOnGeometryUpdatedLoop()
        {
            if (_isOnGeometryUpdatedEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
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

        public Scene getScene()
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        public Engine getEngine()
        {
            return EventHorizonBlazorInterop.FuncClass<Engine>(
                entity => new Engine() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEngine" }
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public void setAllVerticesData(VertexData vertexData, System.Nullable<bool> updatable = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAllVerticesData" }, vertexData, updatable
                }
            );
        }

        public void setVerticesData(string kind, decimal[] data, System.Nullable<bool> updatable = null, System.Nullable<decimal> stride = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setVerticesData" }, kind, data, updatable, stride
                }
            );
        }

        public void removeVerticesData(string kind)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeVerticesData" }, kind
                }
            );
        }

        public void setVerticesBuffer(VertexBuffer buffer, System.Nullable<decimal> totalVertices = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setVerticesBuffer" }, buffer, totalVertices
                }
            );
        }

        public void updateVerticesDataDirectly(string kind, decimal[] data, decimal offset, System.Nullable<bool> useBytes = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateVerticesDataDirectly" }, kind, data, offset, useBytes
                }
            );
        }

        public void updateVerticesData(string kind, decimal[] data, System.Nullable<bool> updateExtends = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateVerticesData" }, kind, data, updateExtends
                }
            );
        }

        public decimal getTotalVertices()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTotalVertices" }
                }
            );
        }

        public decimal[] getVerticesData(string kind, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" }, kind, copyWhenShared, forceCopy
                }
            );
        }

        public bool isVertexBufferUpdatable(string kind)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isVertexBufferUpdatable" }, kind
                }
            );
        }

        public VertexBuffer getVertexBuffer(string kind)
        {
            return EventHorizonBlazorInterop.FuncClass<VertexBuffer>(
                entity => new VertexBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getVertexBuffer" }, kind
                }
            );
        }

        public CachedEntity getVertexBuffers()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getVertexBuffers" }
                }
            );
        }

        public bool isVerticesDataPresent(string kind)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isVerticesDataPresent" }, kind
                }
            );
        }

        public string[] getVerticesDataKinds()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesDataKinds" }
                }
            );
        }

        public void updateIndices(decimal[] indices, System.Nullable<decimal> offset = null, System.Nullable<bool> gpuMemoryOnly = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateIndices" }, indices, offset, gpuMemoryOnly
                }
            );
        }

        public void setIndices(decimal[] indices, System.Nullable<decimal> totalVertices = null, System.Nullable<bool> updatable = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setIndices" }, indices, totalVertices, updatable
                }
            );
        }

        public decimal getTotalIndices()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTotalIndices" }
                }
            );
        }

        public decimal[] getIndices(System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndices" }, copyWhenShared, forceCopy
                }
            );
        }

        public DataBuffer getIndexBuffer()
        {
            return EventHorizonBlazorInterop.FuncClass<DataBuffer>(
                entity => new DataBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getIndexBuffer" }
                }
            );
        }

        public void releaseForMesh(Mesh mesh, System.Nullable<bool> shouldDispose = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "releaseForMesh" }, mesh, shouldDispose
                }
            );
        }

        public void applyToMesh(Mesh mesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyToMesh" }, mesh
                }
            );
        }

        public void load(Scene scene, ActionCallback onLoaded = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "load" }, scene, onLoaded
                }
            );
        }

        public void toLeftHanded()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "toLeftHanded" }
                }
            );
        }

        public bool isDisposed()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isDisposed" }
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

        public Geometry copy(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copy" }, id
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

        public CachedEntity serializeVerticeData()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serializeVerticeData" }
                }
            );
        }
        #endregion
    }
}