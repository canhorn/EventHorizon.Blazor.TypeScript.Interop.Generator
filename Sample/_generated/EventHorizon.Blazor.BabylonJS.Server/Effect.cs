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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Effect>))]
    public class Effect : CachedEntityObject, _IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<string> get_ShadersRepository()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "Effect.ShadersRepository"
                );
        }
        public static ValueTask set_ShadersRepository(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Effect.ShadersRepository",
                    value
                );
        }

        
        public static async ValueTask<bool> get_LogShaderCodeOnCompilationError()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Effect.LogShaderCodeOnCompilationError"
                );
        }
        public static ValueTask set_LogShaderCodeOnCompilationError(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Effect.LogShaderCodeOnCompilationError",
                    value
                );
        }

        
        public static async ValueTask<CachedEntity> get_ShadersStore()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    "BABYLON",
                    "Effect.ShadersStore",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public static ValueTask set_ShadersStore(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Effect.ShadersStore",
                    value
                );
        }

        
        public static async ValueTask<CachedEntity> get_IncludesShadersStore()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    "BABYLON",
                    "Effect.IncludesShadersStore",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public static ValueTask set_IncludesShadersStore(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Effect.IncludesShadersStore",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask RegisterShader(string name, string pixelShader = null, string vertexShader = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Effect", "RegisterShader" }, name, pixelShader, vertexShader
                }
            );
        }

        public static async ValueTask ResetCache()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Effect", "ResetCache" }
                }
            );
        }
        #endregion

        #region Accessors
        private Observable<Effect> __onBindObservable;
        public async ValueTask<Observable<Effect>> get_onBindObservable()
        {
            if(__onBindObservable == null)
            {
                __onBindObservable = await EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
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

        
        public async ValueTask<string> get_key()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "key"
                );
        }

        
        public async ValueTask<string> get_vertexSourceCode()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "vertexSourceCode"
                );
        }

        
        public async ValueTask<string> get_fragmentSourceCode()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fragmentSourceCode"
                );
        }

        
        public async ValueTask<string> get_rawVertexSourceCode()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "rawVertexSourceCode"
                );
        }

        
        public async ValueTask<string> get_rawFragmentSourceCode()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "rawFragmentSourceCode"
                );
        }

        
        public async ValueTask<bool> get_isSupported()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSupported"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<CachedEntity> get_name()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "name",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_name(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        
        public async ValueTask<string> get_defines()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "defines"
                );
        }
        public ValueTask set_defines(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defines",
                    value
                );
        }

        
        public async ValueTask<ActionCallback<Effect>> get_onCompiled()
        {
            return await EventHorizonBlazorInterop.Get<ActionCallback<Effect>>(
                    this.___guid,
                    "onCompiled"
                );
        }
        public ValueTask set_onCompiled(ActionCallback<Effect> value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCompiled",
                    value
                );
        }

        
        public async ValueTask<ActionCallback<Effect, string>> get_onError()
        {
            return await EventHorizonBlazorInterop.Get<ActionCallback<Effect, string>>(
                    this.___guid,
                    "onError"
                );
        }
        public ValueTask set_onError(ActionCallback<Effect, string> value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onError",
                    value
                );
        }

        
        public async ValueTask<ActionCallback<Effect>> get_onBind()
        {
            return await EventHorizonBlazorInterop.Get<ActionCallback<Effect>>(
                    this.___guid,
                    "onBind"
                );
        }
        public ValueTask set_onBind(ActionCallback<Effect> value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBind",
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

        private Observable<Effect> __onCompileObservable;
        public async ValueTask<Observable<Effect>> get_onCompileObservable()
        {
            if(__onCompileObservable == null)
            {
                __onCompileObservable = await EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
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
        public ValueTask set_onCompileObservable(Observable<Effect> value)
        {
__onCompileObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCompileObservable",
                    value
                );
        }

        private Observable<Effect> __onErrorObservable;
        public async ValueTask<Observable<Effect>> get_onErrorObservable()
        {
            if(__onErrorObservable == null)
            {
                __onErrorObservable = await EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
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
        public ValueTask set_onErrorObservable(Observable<Effect> value)
        {
__onErrorObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onErrorObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Effect() : base() { }

        public Effect(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Effect> NewEffect(
            object baseName, string[] attributesNamesOrOptions, string[] uniformsNamesOrEngine, string[] samplers = null, ThinEngine engine = null, string defines = null, IEffectFallbacks fallbacks = null, ActionCallback<Effect> onCompiled = null, ActionCallback<Effect, string> onError = null, object indexParameters = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Effect" },
                baseName, attributesNamesOrOptions, uniformsNamesOrEngine, samplers, engine, defines, fallbacks, onCompiled, onError, indexParameters
            );

            return new Effect(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> isReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
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

        public async ValueTask<IPipelineContextCachedEntity> getPipelineContext()
        {
            return await EventHorizonBlazorInterop.FuncClass<IPipelineContextCachedEntity>(
                entity => new IPipelineContextCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getPipelineContext" }
                }
            );
        }

        public async ValueTask<string[]> getAttributesNames()
        {
            return await EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributesNames" }
                }
            );
        }

        public async ValueTask<decimal> getAttributeLocation(decimal index)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getAttributeLocation" }, index
                }
            );
        }

        public async ValueTask<decimal> getAttributeLocationByName(string name)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getAttributeLocationByName" }, name
                }
            );
        }

        public async ValueTask<decimal> getAttributesCount()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getAttributesCount" }
                }
            );
        }

        public async ValueTask<decimal> getUniformIndex(string uniformName)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getUniformIndex" }, uniformName
                }
            );
        }

        public async ValueTask<WebGLUniformLocationCachedEntity> getUniform(string uniformName)
        {
            return await EventHorizonBlazorInterop.FuncClass<WebGLUniformLocationCachedEntity>(
                entity => new WebGLUniformLocationCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getUniform" }, uniformName
                }
            );
        }

        public async ValueTask<string[]> getSamplers()
        {
            return await EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getSamplers" }
                }
            );
        }

        public async ValueTask<string[]> getUniformNames()
        {
            return await EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getUniformNames" }
                }
            );
        }

        public async ValueTask<string[]> getUniformBuffersNames()
        {
            return await EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getUniformBuffersNames" }
                }
            );
        }

        public async ValueTask<CachedEntity> getIndexParameters()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getIndexParameters" }
                }
            );
        }

        public async ValueTask<string> getCompilationError()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getCompilationError" }
                }
            );
        }

        public async ValueTask<bool> allFallbacksProcessed()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "allFallbacksProcessed" }
                }
            );
        }

        public async ValueTask executeWhenCompiled(ActionCallback<Effect> func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "executeWhenCompiled" }, func
                }
            );
        }

        public async ValueTask setTexture(string channel, ThinTexture texture)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTexture" }, channel, texture
                }
            );
        }

        public async ValueTask setDepthStencilTexture(string channel, RenderTargetTexture texture)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDepthStencilTexture" }, channel, texture
                }
            );
        }

        public async ValueTask setTextureArray(string channel, ThinTexture[] textures)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTextureArray" }, channel, textures
                }
            );
        }

        public async ValueTask setTextureFromPostProcess(string channel, PostProcess postProcess)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTextureFromPostProcess" }, channel, postProcess
                }
            );
        }

        public async ValueTask setTextureFromPostProcessOutput(string channel, PostProcess postProcess)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTextureFromPostProcessOutput" }, channel, postProcess
                }
            );
        }

        public async ValueTask bindUniformBuffer(DataBuffer buffer, string name)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindUniformBuffer" }, buffer, name
                }
            );
        }

        public async ValueTask bindUniformBlock(string blockName, decimal index)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindUniformBlock" }, blockName, index
                }
            );
        }

        public async ValueTask<Effect> setInt(string uniformName, decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setInt" }, uniformName, value
                }
            );
        }

        public async ValueTask<Effect> setIntArray(string uniformName, Int32Array array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray" }, uniformName, array
                }
            );
        }

        public async ValueTask<Effect> setIntArray2(string uniformName, Int32Array array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray2" }, uniformName, array
                }
            );
        }

        public async ValueTask<Effect> setIntArray3(string uniformName, Int32Array array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray3" }, uniformName, array
                }
            );
        }

        public async ValueTask<Effect> setIntArray4(string uniformName, Int32Array array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray4" }, uniformName, array
                }
            );
        }

        public async ValueTask<Effect> setFloatArray(string uniformName, decimal[] array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloatArray" }, uniformName, array
                }
            );
        }

        public async ValueTask<Effect> setFloatArray2(string uniformName, decimal[] array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloatArray2" }, uniformName, array
                }
            );
        }

        public async ValueTask<Effect> setFloatArray3(string uniformName, decimal[] array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloatArray3" }, uniformName, array
                }
            );
        }

        public async ValueTask<Effect> setFloatArray4(string uniformName, decimal[] array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloatArray4" }, uniformName, array
                }
            );
        }

        public async ValueTask<Effect> setArray(string uniformName, decimal[] array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setArray" }, uniformName, array
                }
            );
        }

        public async ValueTask<Effect> setArray2(string uniformName, decimal[] array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setArray2" }, uniformName, array
                }
            );
        }

        public async ValueTask<Effect> setArray3(string uniformName, decimal[] array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setArray3" }, uniformName, array
                }
            );
        }

        public async ValueTask<Effect> setArray4(string uniformName, decimal[] array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setArray4" }, uniformName, array
                }
            );
        }

        public async ValueTask<Effect> setMatrices(string uniformName, decimal[] matrices)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setMatrices" }, uniformName, matrices
                }
            );
        }

        public async ValueTask<Effect> setMatrix(string uniformName, IMatrixLike matrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setMatrix" }, uniformName, matrix
                }
            );
        }

        public async ValueTask<Effect> setMatrix3x3(string uniformName, decimal[] matrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setMatrix3x3" }, uniformName, matrix
                }
            );
        }

        public async ValueTask<Effect> setMatrix2x2(string uniformName, decimal[] matrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setMatrix2x2" }, uniformName, matrix
                }
            );
        }

        public async ValueTask<Effect> setFloat(string uniformName, decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloat" }, uniformName, value
                }
            );
        }

        public async ValueTask<Effect> setBool(string uniformName, bool @bool)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setBool" }, uniformName, @bool
                }
            );
        }

        public async ValueTask<Effect> setVector2(string uniformName, IVector2Like vector2)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVector2" }, uniformName, vector2
                }
            );
        }

        public async ValueTask<Effect> setFloat2(string uniformName, decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloat2" }, uniformName, x, y
                }
            );
        }

        public async ValueTask<Effect> setVector3(string uniformName, IVector3Like vector3)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVector3" }, uniformName, vector3
                }
            );
        }

        public async ValueTask<Effect> setFloat3(string uniformName, decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloat3" }, uniformName, x, y, z
                }
            );
        }

        public async ValueTask<Effect> setVector4(string uniformName, IVector4Like vector4)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setVector4" }, uniformName, vector4
                }
            );
        }

        public async ValueTask<Effect> setFloat4(string uniformName, decimal x, decimal y, decimal z, decimal w)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setFloat4" }, uniformName, x, y, z, w
                }
            );
        }

        public async ValueTask<Effect> setColor3(string uniformName, IColor3Like color3)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setColor3" }, uniformName, color3
                }
            );
        }

        public async ValueTask<Effect> setColor4(string uniformName, IColor3Like color3, decimal alpha)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setColor4" }, uniformName, color3, alpha
                }
            );
        }

        public async ValueTask<Effect> setDirectColor4(string uniformName, IColor4Like color4)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setDirectColor4" }, uniformName, color4
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