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
    public class Effect : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static string ShadersRepository
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "Effect.ShadersRepository"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "Effect.ShadersRepository",
                    value
                );
            }
        }

        
        public static CachedEntity ShadersStore
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    "BABYLON",
                    "Effect.ShadersStore"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "Effect.ShadersStore",
                    value
                );
            }
        }

        
        public static CachedEntity IncludesShadersStore
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    "BABYLON",
                    "Effect.IncludesShadersStore"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "Effect.IncludesShadersStore",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static void RegisterShader(string name, string pixelShader = null, string vertexShader = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Effect", "RegisterShader" }, name, pixelShader, vertexShader
                }
            );
        }

        public static void ResetCache()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Effect", "ResetCache" }
                }
            );
        }
        #endregion

        #region Accessors
        private Observable<Effect> __onBindObservable;
        public Observable<Effect> onBindObservable
        {
            get
            {
            if(__onBindObservable == null)
            {
                __onBindObservable = EventHorizonBlazorInteropt.GetClass<Observable<Effect>>(
                    this.___guid,
                    "onBindObservable",
                    (entity) =>
                    {
                        return new Observable<Effect>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBindObservable;
            }
        }

        
        public string key
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "key"
                );
            }
        }

        
        public bool isSupported
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isSupported"
                );
            }
        }
        #endregion

        #region Properties
        
        public CachedEntity name
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public string defines
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "defines"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "defines",
                    value
                );
            }
        }

        
        public CachedEntity onCompiled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "onCompiled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onCompiled",
                    value
                );
            }
        }

        
        public CachedEntity onError
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "onError"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onError",
                    value
                );
            }
        }

        
        public CachedEntity onBind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "onBind"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBind",
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

        private Observable<Effect> __onCompileObservable;
        public Observable<Effect> onCompileObservable
        {
            get
            {
            if(__onCompileObservable == null)
            {
                __onCompileObservable = EventHorizonBlazorInteropt.GetClass<Observable<Effect>>(
                    this.___guid,
                    "onCompileObservable",
                    (entity) =>
                    {
                        return new Observable<Effect>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onCompileObservable;
            }
            set
            {
__onCompileObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onCompileObservable",
                    value
                );
            }
        }

        private Observable<Effect> __onErrorObservable;
        public Observable<Effect> onErrorObservable
        {
            get
            {
            if(__onErrorObservable == null)
            {
                __onErrorObservable = EventHorizonBlazorInteropt.GetClass<Observable<Effect>>(
                    this.___guid,
                    "onErrorObservable",
                    (entity) =>
                    {
                        return new Observable<Effect>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onErrorObservable;
            }
            set
            {
__onErrorObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onErrorObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Effect() : base() { } 

        public Effect(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Effect(
            object baseName, string[] attributesNamesOrOptions, string[] uniformsNamesOrEngine, string[] samplers = null, ThinEngine engine = null, string defines = null, IEffectFallbacksCachedEntity fallbacks = null, CachedEntity onCompiled = null, CachedEntity onError = null, object indexParameters = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Effect" },
                baseName, attributesNamesOrOptions, uniformsNamesOrEngine, samplers, engine, defines, fallbacks, onCompiled, onError, indexParameters
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isReady()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public Engine getEngine()
        {
            return EventHorizonBlazorInteropt.FuncClass<Engine>(
                entity => new Engine() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEngine" }
                }
            );
        }

        public IPipelineContextCachedEntity getPipelineContext()
        {
            return EventHorizonBlazorInteropt.FuncClass<IPipelineContextCachedEntity>(
                entity => new IPipelineContextCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getPipelineContext" }
                }
            );
        }

        public string[] getAttributesNames()
        {
            return EventHorizonBlazorInteropt.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributesNames" }
                }
            );
        }

        public decimal getAttributeLocation(decimal index)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getAttributeLocation" }, index
                }
            );
        }

        public decimal getAttributeLocationByName(string name)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getAttributeLocationByName" }, name
                }
            );
        }

        public decimal getAttributesCount()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getAttributesCount" }
                }
            );
        }

        public decimal getUniformIndex(string uniformName)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getUniformIndex" }, uniformName
                }
            );
        }

        public WebGLUniformLocationCachedEntity getUniform(string uniformName)
        {
            return EventHorizonBlazorInteropt.FuncClass<WebGLUniformLocationCachedEntity>(
                entity => new WebGLUniformLocationCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getUniform" }, uniformName
                }
            );
        }

        public string[] getSamplers()
        {
            return EventHorizonBlazorInteropt.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getSamplers" }
                }
            );
        }

        public string getCompilationError()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getCompilationError" }
                }
            );
        }

        public bool allFallbacksProcessed()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "allFallbacksProcessed" }
                }
            );
        }

        #region executeWhenCompiled TODO: Get Comments as metadata identification
        private bool _isExecuteWhenCompiledEnabled = false;
        private readonly IDictionary<string, Func<Effect, Task>> _executeWhenCompiledActionMap = new Dictionary<string, Func<Effect, Task>>();

        public string executeWhenCompiled(
            Func<Effect, Task> callback
        )
        {
            SetupExecuteWhenCompiledLoop();

            var handle = Guid.NewGuid().ToString();
            _executeWhenCompiledActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupExecuteWhenCompiledLoop()
        {
            if (_isExecuteWhenCompiledEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "executeWhenCompiled",
                "CallExecuteWhenCompiledActions",
                _invokableReference
            );
            _isExecuteWhenCompiledEnabled = true;
        }

        [JSInvokable]
        public async Task CallExecuteWhenCompiledActions(Effect effect)
        {
            foreach (var action in _executeWhenCompiledActionMap.Values)
            {
                await action(effect);
            }
        }
        #endregion

        public void setTexture(string channel, BaseTexture texture)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTexture" }, channel, texture
                }
            );
        }

        public void setDepthStencilTexture(string channel, RenderTargetTexture texture)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthStencilTexture" }, channel, texture
                }
            );
        }

        public void setTextureArray(string channel, BaseTexture[] textures)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTextureArray" }, channel, textures
                }
            );
        }

        public void setTextureFromPostProcess(string channel, PostProcess postProcess)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTextureFromPostProcess" }, channel, postProcess
                }
            );
        }

        public void setTextureFromPostProcessOutput(string channel, PostProcess postProcess)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTextureFromPostProcessOutput" }, channel, postProcess
                }
            );
        }

        public void bindUniformBuffer(DataBuffer buffer, string name)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindUniformBuffer" }, buffer, name
                }
            );
        }

        public void bindUniformBlock(string blockName, decimal index)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindUniformBlock" }, blockName, index
                }
            );
        }

        public Effect setInt(string uniformName, decimal value)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setInt" }, uniformName, value
                }
            );
        }

        public Effect setIntArray(string uniformName, Int32Array array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray" }, uniformName, array
                }
            );
        }

        public Effect setIntArray2(string uniformName, Int32Array array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray2" }, uniformName, array
                }
            );
        }

        public Effect setIntArray3(string uniformName, Int32Array array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray3" }, uniformName, array
                }
            );
        }

        public Effect setIntArray4(string uniformName, Int32Array array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray4" }, uniformName, array
                }
            );
        }

        public Effect setFloatArray(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloatArray" }, uniformName, array
                }
            );
        }

        public Effect setFloatArray2(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloatArray2" }, uniformName, array
                }
            );
        }

        public Effect setFloatArray3(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloatArray3" }, uniformName, array
                }
            );
        }

        public Effect setFloatArray4(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloatArray4" }, uniformName, array
                }
            );
        }

        public Effect setArray(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setArray" }, uniformName, array
                }
            );
        }

        public Effect setArray2(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setArray2" }, uniformName, array
                }
            );
        }

        public Effect setArray3(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setArray3" }, uniformName, array
                }
            );
        }

        public Effect setArray4(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setArray4" }, uniformName, array
                }
            );
        }

        public Effect setMatrices(string uniformName, decimal[] matrices)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setMatrices" }, uniformName, matrices
                }
            );
        }

        public Effect setMatrix(string uniformName, IMatrixLikeCachedEntity matrix)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setMatrix" }, uniformName, matrix
                }
            );
        }

        public Effect setMatrix3x3(string uniformName, decimal[] matrix)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setMatrix3x3" }, uniformName, matrix
                }
            );
        }

        public Effect setMatrix2x2(string uniformName, decimal[] matrix)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setMatrix2x2" }, uniformName, matrix
                }
            );
        }

        public Effect setFloat(string uniformName, decimal value)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloat" }, uniformName, value
                }
            );
        }

        public Effect setBool(string uniformName, bool @bool)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setBool" }, uniformName, @bool
                }
            );
        }

        public Effect setVector2(string uniformName, IVector2LikeCachedEntity vector2)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVector2" }, uniformName, vector2
                }
            );
        }

        public Effect setFloat2(string uniformName, decimal x, decimal y)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloat2" }, uniformName, x, y
                }
            );
        }

        public Effect setVector3(string uniformName, IVector3LikeCachedEntity vector3)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVector3" }, uniformName, vector3
                }
            );
        }

        public Effect setFloat3(string uniformName, decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloat3" }, uniformName, x, y, z
                }
            );
        }

        public Effect setVector4(string uniformName, IVector4LikeCachedEntity vector4)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVector4" }, uniformName, vector4
                }
            );
        }

        public Effect setFloat4(string uniformName, decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloat4" }, uniformName, x, y, z, w
                }
            );
        }

        public Effect setColor3(string uniformName, IColor3LikeCachedEntity color3)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setColor3" }, uniformName, color3
                }
            );
        }

        public Effect setColor4(string uniformName, IColor3LikeCachedEntity color3, decimal alpha)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setColor4" }, uniformName, color3, alpha
                }
            );
        }

        public Effect setDirectColor4(string uniformName, IColor4LikeCachedEntity color4)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setDirectColor4" }, uniformName, color4
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