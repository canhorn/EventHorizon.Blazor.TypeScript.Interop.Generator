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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Effect>))]
    public class Effect : CachedEntityObject, _IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static string ShadersRepository
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "Effect.ShadersRepository"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Effect.ShadersRepository",
                    value
                );
            }
        }

        
        public static bool LogShaderCodeOnCompilationError
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Effect.LogShaderCodeOnCompilationError"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Effect.LogShaderCodeOnCompilationError",
                    value
                );
            }
        }

        
        public static CachedEntity ShadersStore
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    "BABYLON",
                    "Effect.ShadersStore",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    "BABYLON",
                    "Effect.IncludesShadersStore",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Effect", "RegisterShader" }, name, pixelShader, vertexShader
                }
            );
        }

        public static void ResetCache()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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
                __onBindObservable = EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "key"
                );
            }
        }

        
        public string vertexSourceCode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "vertexSourceCode"
                );
            }
        }

        
        public string fragmentSourceCode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fragmentSourceCode"
                );
            }
        }

        
        public string rawVertexSourceCode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "rawVertexSourceCode"
                );
            }
        }

        
        public string rawFragmentSourceCode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "rawFragmentSourceCode"
                );
            }
        }

        
        public bool isSupported
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
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
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "name",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "defines"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defines",
                    value
                );
            }
        }

        
        public ActionCallback<Effect> onCompiled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<Effect>>(
                    this.___guid,
                    "onCompiled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCompiled",
                    value
                );
            }
        }

        
        public ActionCallback<Effect, string> onError
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<Effect, string>>(
                    this.___guid,
                    "onError"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onError",
                    value
                );
            }
        }

        
        public ActionCallback<Effect> onBind
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<Effect>>(
                    this.___guid,
                    "onBind"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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

        private Observable<Effect> __onCompileObservable;
        public Observable<Effect> onCompileObservable
        {
            get
            {
            if(__onCompileObservable == null)
            {
                __onCompileObservable = EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
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
                EventHorizonBlazorInterop.Set(
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
                __onErrorObservable = EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
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
                EventHorizonBlazorInterop.Set(
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
        }

        public Effect(
            object baseName, string[] attributesNamesOrOptions, string[] uniformsNamesOrEngine, string[] samplers = null, ThinEngine engine = null, string defines = null, IEffectFallbacks fallbacks = null, ActionCallback<Effect> onCompiled = null, ActionCallback<Effect, string> onError = null, object indexParameters = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Effect" },
                baseName, attributesNamesOrOptions, uniformsNamesOrEngine, samplers, engine, defines, fallbacks, onCompiled, onError, indexParameters
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }
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

        public IPipelineContextCachedEntity getPipelineContext()
        {
            return EventHorizonBlazorInterop.FuncClass<IPipelineContextCachedEntity>(
                entity => new IPipelineContextCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPipelineContext" }
                }
            );
        }

        public string[] getAttributesNames()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributesNames" }
                }
            );
        }

        public decimal getAttributeLocation(decimal index)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributeLocation" }, index
                }
            );
        }

        public decimal getAttributeLocationByName(string name)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributeLocationByName" }, name
                }
            );
        }

        public decimal getAttributesCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributesCount" }
                }
            );
        }

        public decimal getUniformIndex(string uniformName)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getUniformIndex" }, uniformName
                }
            );
        }

        public WebGLUniformLocationCachedEntity getUniform(string uniformName)
        {
            return EventHorizonBlazorInterop.FuncClass<WebGLUniformLocationCachedEntity>(
                entity => new WebGLUniformLocationCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getUniform" }, uniformName
                }
            );
        }

        public string[] getSamplers()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getSamplers" }
                }
            );
        }

        public string[] getUniformNames()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getUniformNames" }
                }
            );
        }

        public string[] getUniformBuffersNames()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getUniformBuffersNames" }
                }
            );
        }

        public CachedEntity getIndexParameters()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getIndexParameters" }
                }
            );
        }

        public string getCompilationError()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getCompilationError" }
                }
            );
        }

        public bool allFallbacksProcessed()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "allFallbacksProcessed" }
                }
            );
        }

        public void executeWhenCompiled(ActionCallback<Effect> func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "executeWhenCompiled" }, func
                }
            );
        }

        public void setTexture(string channel, ThinTexture texture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTexture" }, channel, texture
                }
            );
        }

        public void setDepthStencilTexture(string channel, RenderTargetTexture texture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setDepthStencilTexture" }, channel, texture
                }
            );
        }

        public void setTextureArray(string channel, ThinTexture[] textures)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTextureArray" }, channel, textures
                }
            );
        }

        public void setTextureFromPostProcess(string channel, PostProcess postProcess)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTextureFromPostProcess" }, channel, postProcess
                }
            );
        }

        public void setTextureFromPostProcessOutput(string channel, PostProcess postProcess)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTextureFromPostProcessOutput" }, channel, postProcess
                }
            );
        }

        public void bindUniformBuffer(DataBuffer buffer, string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindUniformBuffer" }, buffer, name
                }
            );
        }

        public void bindUniformBlock(string blockName, decimal index)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindUniformBlock" }, blockName, index
                }
            );
        }

        public Effect setInt(string uniformName, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setInt" }, uniformName, value
                }
            );
        }

        public Effect setIntArray(string uniformName, Int32Array array)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setIntArray" }, uniformName, array
                }
            );
        }

        public Effect setIntArray2(string uniformName, Int32Array array)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setIntArray2" }, uniformName, array
                }
            );
        }

        public Effect setIntArray3(string uniformName, Int32Array array)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setIntArray3" }, uniformName, array
                }
            );
        }

        public Effect setIntArray4(string uniformName, Int32Array array)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setIntArray4" }, uniformName, array
                }
            );
        }

        public Effect setFloatArray(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFloatArray" }, uniformName, array
                }
            );
        }

        public Effect setFloatArray2(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFloatArray2" }, uniformName, array
                }
            );
        }

        public Effect setFloatArray3(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFloatArray3" }, uniformName, array
                }
            );
        }

        public Effect setFloatArray4(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFloatArray4" }, uniformName, array
                }
            );
        }

        public Effect setArray(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setArray" }, uniformName, array
                }
            );
        }

        public Effect setArray2(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setArray2" }, uniformName, array
                }
            );
        }

        public Effect setArray3(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setArray3" }, uniformName, array
                }
            );
        }

        public Effect setArray4(string uniformName, decimal[] array)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setArray4" }, uniformName, array
                }
            );
        }

        public Effect setMatrices(string uniformName, decimal[] matrices)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMatrices" }, uniformName, matrices
                }
            );
        }

        public Effect setMatrix(string uniformName, IMatrixLike matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMatrix" }, uniformName, matrix
                }
            );
        }

        public Effect setMatrix3x3(string uniformName, decimal[] matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMatrix3x3" }, uniformName, matrix
                }
            );
        }

        public Effect setMatrix2x2(string uniformName, decimal[] matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setMatrix2x2" }, uniformName, matrix
                }
            );
        }

        public Effect setFloat(string uniformName, decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFloat" }, uniformName, value
                }
            );
        }

        public Effect setBool(string uniformName, bool @bool)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setBool" }, uniformName, @bool
                }
            );
        }

        public Effect setVector2(string uniformName, IVector2Like vector2)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVector2" }, uniformName, vector2
                }
            );
        }

        public Effect setFloat2(string uniformName, decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFloat2" }, uniformName, x, y
                }
            );
        }

        public Effect setVector3(string uniformName, IVector3Like vector3)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVector3" }, uniformName, vector3
                }
            );
        }

        public Effect setFloat3(string uniformName, decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFloat3" }, uniformName, x, y, z
                }
            );
        }

        public Effect setVector4(string uniformName, IVector4Like vector4)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setVector4" }, uniformName, vector4
                }
            );
        }

        public Effect setFloat4(string uniformName, decimal x, decimal y, decimal z, decimal w)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setFloat4" }, uniformName, x, y, z, w
                }
            );
        }

        public Effect setColor3(string uniformName, IColor3Like color3)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setColor3" }, uniformName, color3
                }
            );
        }

        public Effect setColor4(string uniformName, IColor3Like color3, decimal alpha)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setColor4" }, uniformName, color3, alpha
                }
            );
        }

        public Effect setDirectColor4(string uniformName, IColor4Like color4)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDirectColor4" }, uniformName, color4
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