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
    public class UniformBuffer : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public bool useUbo
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useUbo"
                );
            }
        }

        
        public bool isSync
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isSync"
                );
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public UniformBuffer() : base() { } 

        public UniformBuffer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public UniformBuffer(
            Engine engine, decimal[] data = null, System.Nullable<bool> dynamic = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "UniformBuffer" },
                engine, data, dynamic
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region updateMatrix3x3 TODO: Get Comments as metadata identification
        private bool _isUpdateMatrix3x3Enabled = false;
        private readonly IDictionary<string, Func<Task>> _updateMatrix3x3ActionMap = new Dictionary<string, Func<Task>>();

        public string updateMatrix3x3(
            Func<Task> callback
        )
        {
            SetupUpdateMatrix3x3Loop();

            var handle = Guid.NewGuid().ToString();
            _updateMatrix3x3ActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateMatrix3x3Loop()
        {
            if (_isUpdateMatrix3x3Enabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateMatrix3x3",
                "CallUpdateMatrix3x3Actions",
                _invokableReference
            );
            _isUpdateMatrix3x3Enabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateMatrix3x3Actions()
        {
            foreach (var action in _updateMatrix3x3ActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region updateMatrix2x2 TODO: Get Comments as metadata identification
        private bool _isUpdateMatrix2x2Enabled = false;
        private readonly IDictionary<string, Func<Task>> _updateMatrix2x2ActionMap = new Dictionary<string, Func<Task>>();

        public string updateMatrix2x2(
            Func<Task> callback
        )
        {
            SetupUpdateMatrix2x2Loop();

            var handle = Guid.NewGuid().ToString();
            _updateMatrix2x2ActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateMatrix2x2Loop()
        {
            if (_isUpdateMatrix2x2Enabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateMatrix2x2",
                "CallUpdateMatrix2x2Actions",
                _invokableReference
            );
            _isUpdateMatrix2x2Enabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateMatrix2x2Actions()
        {
            foreach (var action in _updateMatrix2x2ActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region updateFloat TODO: Get Comments as metadata identification
        private bool _isUpdateFloatEnabled = false;
        private readonly IDictionary<string, Func<Task>> _updateFloatActionMap = new Dictionary<string, Func<Task>>();

        public string updateFloat(
            Func<Task> callback
        )
        {
            SetupUpdateFloatLoop();

            var handle = Guid.NewGuid().ToString();
            _updateFloatActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateFloatLoop()
        {
            if (_isUpdateFloatEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateFloat",
                "CallUpdateFloatActions",
                _invokableReference
            );
            _isUpdateFloatEnabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateFloatActions()
        {
            foreach (var action in _updateFloatActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region updateFloat2 TODO: Get Comments as metadata identification
        private bool _isUpdateFloat2Enabled = false;
        private readonly IDictionary<string, Func<Task>> _updateFloat2ActionMap = new Dictionary<string, Func<Task>>();

        public string updateFloat2(
            Func<Task> callback
        )
        {
            SetupUpdateFloat2Loop();

            var handle = Guid.NewGuid().ToString();
            _updateFloat2ActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateFloat2Loop()
        {
            if (_isUpdateFloat2Enabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateFloat2",
                "CallUpdateFloat2Actions",
                _invokableReference
            );
            _isUpdateFloat2Enabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateFloat2Actions()
        {
            foreach (var action in _updateFloat2ActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region updateFloat3 TODO: Get Comments as metadata identification
        private bool _isUpdateFloat3Enabled = false;
        private readonly IDictionary<string, Func<Task>> _updateFloat3ActionMap = new Dictionary<string, Func<Task>>();

        public string updateFloat3(
            Func<Task> callback
        )
        {
            SetupUpdateFloat3Loop();

            var handle = Guid.NewGuid().ToString();
            _updateFloat3ActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateFloat3Loop()
        {
            if (_isUpdateFloat3Enabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateFloat3",
                "CallUpdateFloat3Actions",
                _invokableReference
            );
            _isUpdateFloat3Enabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateFloat3Actions()
        {
            foreach (var action in _updateFloat3ActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region updateFloat4 TODO: Get Comments as metadata identification
        private bool _isUpdateFloat4Enabled = false;
        private readonly IDictionary<string, Func<Task>> _updateFloat4ActionMap = new Dictionary<string, Func<Task>>();

        public string updateFloat4(
            Func<Task> callback
        )
        {
            SetupUpdateFloat4Loop();

            var handle = Guid.NewGuid().ToString();
            _updateFloat4ActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateFloat4Loop()
        {
            if (_isUpdateFloat4Enabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateFloat4",
                "CallUpdateFloat4Actions",
                _invokableReference
            );
            _isUpdateFloat4Enabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateFloat4Actions()
        {
            foreach (var action in _updateFloat4ActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region updateMatrix TODO: Get Comments as metadata identification
        private bool _isUpdateMatrixEnabled = false;
        private readonly IDictionary<string, Func<Task>> _updateMatrixActionMap = new Dictionary<string, Func<Task>>();

        public string updateMatrix(
            Func<Task> callback
        )
        {
            SetupUpdateMatrixLoop();

            var handle = Guid.NewGuid().ToString();
            _updateMatrixActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateMatrixLoop()
        {
            if (_isUpdateMatrixEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateMatrix",
                "CallUpdateMatrixActions",
                _invokableReference
            );
            _isUpdateMatrixEnabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateMatrixActions()
        {
            foreach (var action in _updateMatrixActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region updateVector3 TODO: Get Comments as metadata identification
        private bool _isUpdateVector3Enabled = false;
        private readonly IDictionary<string, Func<Task>> _updateVector3ActionMap = new Dictionary<string, Func<Task>>();

        public string updateVector3(
            Func<Task> callback
        )
        {
            SetupUpdateVector3Loop();

            var handle = Guid.NewGuid().ToString();
            _updateVector3ActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateVector3Loop()
        {
            if (_isUpdateVector3Enabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateVector3",
                "CallUpdateVector3Actions",
                _invokableReference
            );
            _isUpdateVector3Enabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateVector3Actions()
        {
            foreach (var action in _updateVector3ActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region updateVector4 TODO: Get Comments as metadata identification
        private bool _isUpdateVector4Enabled = false;
        private readonly IDictionary<string, Func<Task>> _updateVector4ActionMap = new Dictionary<string, Func<Task>>();

        public string updateVector4(
            Func<Task> callback
        )
        {
            SetupUpdateVector4Loop();

            var handle = Guid.NewGuid().ToString();
            _updateVector4ActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateVector4Loop()
        {
            if (_isUpdateVector4Enabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateVector4",
                "CallUpdateVector4Actions",
                _invokableReference
            );
            _isUpdateVector4Enabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateVector4Actions()
        {
            foreach (var action in _updateVector4ActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region updateColor3 TODO: Get Comments as metadata identification
        private bool _isUpdateColor3Enabled = false;
        private readonly IDictionary<string, Func<Task>> _updateColor3ActionMap = new Dictionary<string, Func<Task>>();

        public string updateColor3(
            Func<Task> callback
        )
        {
            SetupUpdateColor3Loop();

            var handle = Guid.NewGuid().ToString();
            _updateColor3ActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateColor3Loop()
        {
            if (_isUpdateColor3Enabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateColor3",
                "CallUpdateColor3Actions",
                _invokableReference
            );
            _isUpdateColor3Enabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateColor3Actions()
        {
            foreach (var action in _updateColor3ActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region updateColor4 TODO: Get Comments as metadata identification
        private bool _isUpdateColor4Enabled = false;
        private readonly IDictionary<string, Func<Task>> _updateColor4ActionMap = new Dictionary<string, Func<Task>>();

        public string updateColor4(
            Func<Task> callback
        )
        {
            SetupUpdateColor4Loop();

            var handle = Guid.NewGuid().ToString();
            _updateColor4ActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateColor4Loop()
        {
            if (_isUpdateColor4Enabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "updateColor4",
                "CallUpdateColor4Actions",
                _invokableReference
            );
            _isUpdateColor4Enabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateColor4Actions()
        {
            foreach (var action in _updateColor4ActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public bool isDynamic()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isDynamic" }
                }
            );
        }

        public decimal[] getData()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getData" }
                }
            );
        }

        public DataBuffer getBuffer()
        {
            return EventHorizonBlazorInteropt.FuncClass<DataBuffer>(
                entity => new DataBuffer(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getBuffer" }
                }
            );
        }

        public void addUniform(string name, decimal size)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addUniform" }, name, size
                }
            );
        }

        public void addMatrix(string name, Matrix mat)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addMatrix" }, name, mat
                }
            );
        }

        public void addFloat2(string name, decimal x, decimal y)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addFloat2" }, name, x, y
                }
            );
        }

        public void addFloat3(string name, decimal x, decimal y, decimal z)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addFloat3" }, name, x, y, z
                }
            );
        }

        public void addColor3(string name, Color3 color)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addColor3" }, name, color
                }
            );
        }

        public void addColor4(string name, Color3 color, decimal alpha)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addColor4" }, name, color, alpha
                }
            );
        }

        public void addVector3(string name, Vector3 vector)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addVector3" }, name, vector
                }
            );
        }

        public void addMatrix3x3(string name)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addMatrix3x3" }, name
                }
            );
        }

        public void addMatrix2x2(string name)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addMatrix2x2" }, name
                }
            );
        }

        public void create()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "create" }
                }
            );
        }

        public void update()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public void updateUniform(string uniformName, decimal[] data, decimal size)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateUniform" }, uniformName, data, size
                }
            );
        }

        public void setTexture(string name, BaseTexture texture)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTexture" }, name, texture
                }
            );
        }

        public void updateUniformDirectly(string uniformName, decimal[] data)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateUniformDirectly" }, uniformName, data
                }
            );
        }

        public void bindToEffect(Effect effect, string name)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindToEffect" }, effect, name
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
        #endregion
    }
}