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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ProceduralTexture>))]
    public class ProceduralTexture : Texture
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public decimal refreshRate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "refreshRate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "refreshRate",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public bool isEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isEnabled",
                    value
                );
            }
        }

        
        public bool autoClear
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClear"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClear",
                    value
                );
            }
        }

        private Observable<ProceduralTexture> __onGeneratedObservable;
        public Observable<ProceduralTexture> onGeneratedObservable
        {
            get
            {
            if(__onGeneratedObservable == null)
            {
                __onGeneratedObservable = EventHorizonBlazorInterop.GetClass<Observable<ProceduralTexture>>(
                    this.___guid,
                    "onGeneratedObservable",
                    (entity) =>
                    {
                        return new Observable<ProceduralTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onGeneratedObservable;
            }
            set
            {
__onGeneratedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onGeneratedObservable",
                    value
                );
            }
        }

        private Observable<ProceduralTexture> __onBeforeGenerationObservable;
        public Observable<ProceduralTexture> onBeforeGenerationObservable
        {
            get
            {
            if(__onBeforeGenerationObservable == null)
            {
                __onBeforeGenerationObservable = EventHorizonBlazorInterop.GetClass<Observable<ProceduralTexture>>(
                    this.___guid,
                    "onBeforeGenerationObservable",
                    (entity) =>
                    {
                        return new Observable<ProceduralTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeGenerationObservable;
            }
            set
            {
__onBeforeGenerationObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeGenerationObservable",
                    value
                );
            }
        }

        private NodeMaterial __nodeMaterialSource;
        public NodeMaterial nodeMaterialSource
        {
            get
            {
            if(__nodeMaterialSource == null)
            {
                __nodeMaterialSource = EventHorizonBlazorInterop.GetClass<NodeMaterial>(
                    this.___guid,
                    "nodeMaterialSource",
                    (entity) =>
                    {
                        return new NodeMaterial() { ___guid = entity.___guid };
                    }
                );
            }
            return __nodeMaterialSource;
            }
            set
            {
__nodeMaterialSource = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nodeMaterialSource",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ProceduralTexture() : base() { }

        public ProceduralTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ProceduralTexture(
            string name, decimal size, object fragment, Scene scene, Texture fallbackTexture = null, System.Nullable<bool> generateMipMaps = null, System.Nullable<bool> isCube = null, System.Nullable<decimal> textureType = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ProceduralTexture" },
                name, size, fragment, scene, fallbackTexture, generateMipMaps, isCube, textureType
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region onGenerated TODO: Get Comments as metadata identification
        private bool _isOnGeneratedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onGeneratedActionMap = new Dictionary<string, Func<Task>>();

        public string onGenerated(
            Func<Task> callback
        )
        {
            SetupOnGeneratedLoop();

            var handle = Guid.NewGuid().ToString();
            _onGeneratedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onGenerated_Remove(
            string handle
        )
        {
            return _onGeneratedActionMap.Remove(
                handle
            );
        }

        private void SetupOnGeneratedLoop()
        {
            if (_isOnGeneratedEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onGenerated",
                "CallOnGeneratedActions",
                _invokableReference
            );
            _isOnGeneratedEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnGeneratedActions()
        {
            foreach (var action in _onGeneratedActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public Effect getEffect()
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEffect" }
                }
            );
        }

        public ArrayBufferView getContent()
        {
            return EventHorizonBlazorInterop.FuncClass<ArrayBufferView>(
                entity => new ArrayBufferView() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getContent" }
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
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

        public void resetRefreshCounter()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetRefreshCounter" }
                }
            );
        }

        public void setFragment(object fragment)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setFragment" }, fragment
                }
            );
        }

        public decimal getRenderSize()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRenderSize" }
                }
            );
        }

        public void resize(decimal size, bool generateMipMaps)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resize" }, size, generateMipMaps
                }
            );
        }

        public ProceduralTexture setTexture(string name, Texture texture)
        {
            return EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setTexture" }, name, texture
                }
            );
        }

        public ProceduralTexture setFloat(string name, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFloat" }, name, value
                }
            );
        }

        public ProceduralTexture setInt(string name, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setInt" }, name, value
                }
            );
        }

        public ProceduralTexture setFloats(string name, decimal[] value)
        {
            return EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFloats" }, name, value
                }
            );
        }

        public ProceduralTexture setColor3(string name, Color3 value)
        {
            return EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setColor3" }, name, value
                }
            );
        }

        public ProceduralTexture setColor4(string name, Color4 value)
        {
            return EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setColor4" }, name, value
                }
            );
        }

        public ProceduralTexture setVector2(string name, Vector2 value)
        {
            return EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVector2" }, name, value
                }
            );
        }

        public ProceduralTexture setVector3(string name, Vector3 value)
        {
            return EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVector3" }, name, value
                }
            );
        }

        public ProceduralTexture setMatrix(string name, Matrix value)
        {
            return EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMatrix" }, name, value
                }
            );
        }

        public void render(System.Nullable<bool> useCameraPostProcess = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, useCameraPostProcess
                }
            );
        }

        public ProceduralTexture clone()
        {
            return EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
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
        #endregion
    }
}