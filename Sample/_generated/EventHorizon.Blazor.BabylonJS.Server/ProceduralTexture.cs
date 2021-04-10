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
        
        public async ValueTask<decimal> get_refreshRate()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "refreshRate"
                );
        }
        public ValueTask set_refreshRate(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "refreshRate",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
        }
        public ValueTask set_isEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_autoClear()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClear"
                );
        }
        public ValueTask set_autoClear(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClear",
                    value
                );
        }

        private Observable<ProceduralTexture> __onGeneratedObservable;
        public async ValueTask<Observable<ProceduralTexture>> get_onGeneratedObservable()
        {
            if(__onGeneratedObservable == null)
            {
                __onGeneratedObservable = await EventHorizonBlazorInterop.GetClass<Observable<ProceduralTexture>>(
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
        public ValueTask set_onGeneratedObservable(Observable<ProceduralTexture> value)
        {
__onGeneratedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onGeneratedObservable",
                    value
                );
        }

        private Observable<ProceduralTexture> __onBeforeGenerationObservable;
        public async ValueTask<Observable<ProceduralTexture>> get_onBeforeGenerationObservable()
        {
            if(__onBeforeGenerationObservable == null)
            {
                __onBeforeGenerationObservable = await EventHorizonBlazorInterop.GetClass<Observable<ProceduralTexture>>(
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
        public ValueTask set_onBeforeGenerationObservable(Observable<ProceduralTexture> value)
        {
__onBeforeGenerationObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeGenerationObservable",
                    value
                );
        }

        private NodeMaterial __nodeMaterialSource;
        public async ValueTask<NodeMaterial> get_nodeMaterialSource()
        {
            if(__nodeMaterialSource == null)
            {
                __nodeMaterialSource = await EventHorizonBlazorInterop.GetClass<NodeMaterial>(
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
        public ValueTask set_nodeMaterialSource(NodeMaterial value)
        {
__nodeMaterialSource = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "nodeMaterialSource",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ProceduralTexture() : base() { }

        public ProceduralTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<ProceduralTexture> NewProceduralTexture(
            string name, decimal size, object fragment, Scene scene, Texture fallbackTexture = null, System.Nullable<bool> generateMipMaps = null, System.Nullable<bool> isCube = null, System.Nullable<decimal> textureType = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ProceduralTexture" },
                name, size, fragment, scene, fallbackTexture, generateMipMaps, isCube, textureType
            );

            return new ProceduralTexture(entity);
        }
        #endregion

        #region Methods
        #region onGenerated TODO: Get Comments as metadata identification
        private bool _isOnGeneratedEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onGeneratedActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> onGenerated(
            Func<Task> callback
        )
        {
            await SetupOnGeneratedLoop();

            var handle = Guid.NewGuid().ToString();
            _onGeneratedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupOnGeneratedLoop()
        {
            if (_isOnGeneratedEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<Effect> getEffect()
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEffect" }
                }
            );
        }

        public async ValueTask<ArrayBufferView> getContent()
        {
            return await EventHorizonBlazorInterop.FuncClass<ArrayBufferView>(
                entity => new ArrayBufferView() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getContent" }
                }
            );
        }

        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
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

        public async ValueTask resetRefreshCounter()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resetRefreshCounter" }
                }
            );
        }

        public async ValueTask setFragment(object fragment)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setFragment" }, fragment
                }
            );
        }

        public async ValueTask<decimal> getRenderSize()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderSize" }
                }
            );
        }

        public async ValueTask resize(decimal size, bool generateMipMaps)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resize" }, size, generateMipMaps
                }
            );
        }

        public async ValueTask<ProceduralTexture> setTexture(string name, Texture texture)
        {
            return await EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setTexture" }, name, texture
                }
            );
        }

        public async ValueTask<ProceduralTexture> setFloat(string name, decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloat" }, name, value
                }
            );
        }

        public async ValueTask<ProceduralTexture> setInt(string name, decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setInt" }, name, value
                }
            );
        }

        public async ValueTask<ProceduralTexture> setFloats(string name, decimal[] value)
        {
            return await EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloats" }, name, value
                }
            );
        }

        public async ValueTask<ProceduralTexture> setColor3(string name, Color3 value)
        {
            return await EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setColor3" }, name, value
                }
            );
        }

        public async ValueTask<ProceduralTexture> setColor4(string name, Color4 value)
        {
            return await EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setColor4" }, name, value
                }
            );
        }

        public async ValueTask<ProceduralTexture> setVector2(string name, Vector2 value)
        {
            return await EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVector2" }, name, value
                }
            );
        }

        public async ValueTask<ProceduralTexture> setVector3(string name, Vector3 value)
        {
            return await EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVector3" }, name, value
                }
            );
        }

        public async ValueTask<ProceduralTexture> setMatrix(string name, Matrix value)
        {
            return await EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setMatrix" }, name, value
                }
            );
        }

        public async ValueTask render(System.Nullable<bool> useCameraPostProcess = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }, useCameraPostProcess
                }
            );
        }

        public async ValueTask<ProceduralTexture> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
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
        #endregion
    }
}