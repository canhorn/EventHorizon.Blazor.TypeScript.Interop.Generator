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
    public class Geometry : CachedEntityObject, IGetSetVerticesData
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Geometry CreateGeometryForMesh(Mesh mesh)
        {
            return EventHorizonBlazorInteropt.FuncClass<Geometry>(
                entity => new Geometry(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Geometry", "CreateGeometryForMesh" }, mesh
                }
            );
        }

        public static Geometry ExtractFromMesh(Mesh mesh, string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Geometry>(
                entity => new Geometry(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Geometry", "ExtractFromMesh" }, mesh, id
                }
            );
        }

        public static string RandomId()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { "BABYLON", "Geometry", "RandomId" }
                }
            );
        }

        public static Geometry Parse(object parsedVertexData, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInteropt.FuncClass<Geometry>(
                entity => new Geometry(entity),
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
                __boundingBias = EventHorizonBlazorInteropt.GetClass<Vector2>(
                    this.___guid,
                    "boundingBias",
                    (entity) =>
                    {
                        return new Vector2(entity);
                    }
                );
            }
            return __boundingBias;
            }
            set
            {
__boundingBias = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "boundingBias",
                    value
                );
            }
        }

        
        public CachedEntity extend
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "extend"
                );
            }
        }

        
        public bool doNotSerialize
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
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
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "delayLoadState"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "delayLoadingFile"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "delayLoadingFile",
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
            var entity = EventHorizonBlazorInteropt.New(
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

        private void SetupOnGeometryUpdatedLoop()
        {
            if (_isOnGeometryUpdatedEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        public Engine getEngine()
        {
            return EventHorizonBlazorInteropt.FuncClass<Engine>(
                entity => new Engine(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getEngine" }
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public void setAllVerticesData(VertexData vertexData, System.Nullable<bool> updatable = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setAllVerticesData" }, vertexData, updatable
                }
            );
        }

        public void setVerticesData(string kind, decimal[] data, System.Nullable<bool> updatable = null, System.Nullable<decimal> stride = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setVerticesData" }, kind, data, updatable, stride
                }
            );
        }

        public void removeVerticesData(string kind)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeVerticesData" }, kind
                }
            );
        }

        public void setVerticesBuffer(VertexBuffer buffer, System.Nullable<decimal> totalVertices = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setVerticesBuffer" }, buffer, totalVertices
                }
            );
        }

        public void updateVerticesDataDirectly(string kind, DataArray data, decimal offset, System.Nullable<bool> useBytes = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateVerticesDataDirectly" }, kind, data, offset, useBytes
                }
            );
        }

        public void updateVerticesData(string kind, decimal[] data, System.Nullable<bool> updateExtends = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateVerticesData" }, kind, data, updateExtends
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

        public decimal[] getVerticesData(string kind, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" }, kind, copyWhenShared, forceCopy
                }
            );
        }

        public bool isVertexBufferUpdatable(string kind)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isVertexBufferUpdatable" }, kind
                }
            );
        }

        public VertexBuffer getVertexBuffer(string kind)
        {
            return EventHorizonBlazorInteropt.FuncClass<VertexBuffer>(
                entity => new VertexBuffer(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getVertexBuffer" }, kind
                }
            );
        }

        public CachedEntity getVertexBuffers()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getVertexBuffers" }
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

        public string[] getVerticesDataKinds()
        {
            return EventHorizonBlazorInteropt.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesDataKinds" }
                }
            );
        }

        public void updateIndices(decimal[] indices, System.Nullable<decimal> offset = null, System.Nullable<bool> gpuMemoryOnly = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateIndices" }, indices, offset, gpuMemoryOnly
                }
            );
        }

        public void setIndices(decimal[] indices, System.Nullable<decimal> totalVertices = null, System.Nullable<bool> updatable = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setIndices" }, indices, totalVertices, updatable
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

        public decimal[] getIndices(System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndices" }, copyWhenShared, forceCopy
                }
            );
        }

        public DataBuffer getIndexBuffer()
        {
            return EventHorizonBlazorInteropt.FuncClass<DataBuffer>(
                entity => new DataBuffer(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getIndexBuffer" }
                }
            );
        }

        public void releaseForMesh(Mesh mesh, System.Nullable<bool> shouldDispose = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "releaseForMesh" }, mesh, shouldDispose
                }
            );
        }

        public void applyToMesh(Mesh mesh)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "applyToMesh" }, mesh
                }
            );
        }

        #region load TODO: Get Comments as metadata identification
        private bool _isLoadEnabled = false;
        private readonly IDictionary<string, Func<Task>> _loadActionMap = new Dictionary<string, Func<Task>>();

        public string load(
            Func<Task> callback
        )
        {
            SetupLoadLoop();

            var handle = Guid.NewGuid().ToString();
            _loadActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupLoadLoop()
        {
            if (_isLoadEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "load",
                "CallLoadActions",
                _invokableReference
            );
            _isLoadEnabled = true;
        }

        [JSInvokable]
        public async Task CallLoadActions()
        {
            foreach (var action in _loadActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void toLeftHanded()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "toLeftHanded" }
                }
            );
        }

        public bool isDisposed()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isDisposed" }
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

        public Geometry copy(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Geometry>(
                entity => new Geometry(entity),
                new object[] 
                {
                    new string[] { this.___guid, "copy" }, id
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

        public CachedEntity serializeVerticeData()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serializeVerticeData" }
                }
            );
        }
        #endregion
    }
}