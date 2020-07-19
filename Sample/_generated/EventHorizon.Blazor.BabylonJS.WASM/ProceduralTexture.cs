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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "refreshRate"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "refreshRate",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public bool isCube
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isCube"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isCube",
                    value
                );
            }
        }

        
        public bool isEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "autoClear"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __onGeneratedObservable = EventHorizonBlazorInteropt.GetClass<Observable<ProceduralTexture>>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onGeneratedObservable",
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
            string name, object size, object fragment, Scene scene, Texture fallbackTexture = null, System.Nullable<bool> generateMipMaps = null, System.Nullable<bool> isCube = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "ProceduralTexture" },
                name, size, fragment, scene, fallbackTexture, generateMipMaps, isCube
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

        private void SetupOnGeneratedLoop()
        {
            if (_isOnGeneratedEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEffect" }
                }
            );
        }

        public ArrayBufferView getContent()
        {
            return EventHorizonBlazorInteropt.FuncClass<ArrayBufferView>(
                entity => new ArrayBufferView() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getContent" }
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
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

        public void resetRefreshCounter()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resetRefreshCounter" }
                }
            );
        }

        public void setFragment(object fragment)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setFragment" }, fragment
                }
            );
        }

        public decimal getRenderSize()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderSize" }
                }
            );
        }

        public void resize(decimal size, bool generateMipMaps)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resize" }, size, generateMipMaps
                }
            );
        }

        public ProceduralTexture setTexture(string name, Texture texture)
        {
            return EventHorizonBlazorInteropt.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setTexture" }, name, texture
                }
            );
        }

        public ProceduralTexture setFloat(string name, decimal value)
        {
            return EventHorizonBlazorInteropt.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloat" }, name, value
                }
            );
        }

        public ProceduralTexture setInt(string name, decimal value)
        {
            return EventHorizonBlazorInteropt.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setInt" }, name, value
                }
            );
        }

        public ProceduralTexture setFloats(string name, decimal[] value)
        {
            return EventHorizonBlazorInteropt.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloats" }, name, value
                }
            );
        }

        public ProceduralTexture setColor3(string name, Color3 value)
        {
            return EventHorizonBlazorInteropt.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setColor3" }, name, value
                }
            );
        }

        public ProceduralTexture setColor4(string name, Color4 value)
        {
            return EventHorizonBlazorInteropt.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setColor4" }, name, value
                }
            );
        }

        public ProceduralTexture setVector2(string name, Vector2 value)
        {
            return EventHorizonBlazorInteropt.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVector2" }, name, value
                }
            );
        }

        public ProceduralTexture setVector3(string name, Vector3 value)
        {
            return EventHorizonBlazorInteropt.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVector3" }, name, value
                }
            );
        }

        public ProceduralTexture setMatrix(string name, Matrix value)
        {
            return EventHorizonBlazorInteropt.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setMatrix" }, name, value
                }
            );
        }

        public void render(System.Nullable<bool> useCameraPostProcess = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }, useCameraPostProcess
                }
            );
        }

        public ProceduralTexture clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
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