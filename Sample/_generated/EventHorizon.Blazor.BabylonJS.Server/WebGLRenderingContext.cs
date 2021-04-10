/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using Microsoft.JSInterop;

public interface WebGLRenderingContext : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<WebGLRenderingContextCachedEntity>))]
public class WebGLRenderingContextCachedEntity : CachedEntityObject, WebGLRenderingContext
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods

    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public async ValueTask<decimal> get_MAX_SAMPLES()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX_SAMPLES"
                );
        }
        public ValueTask set_MAX_SAMPLES(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MAX_SAMPLES",
                    value
                );
        }

        
        public async ValueTask<decimal> get_RGBA8()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RGBA8"
                );
        }
        public ValueTask set_RGBA8(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RGBA8",
                    value
                );
        }

        
        public async ValueTask<decimal> get_READ_FRAMEBUFFER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "READ_FRAMEBUFFER"
                );
        }
        public ValueTask set_READ_FRAMEBUFFER(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "READ_FRAMEBUFFER",
                    value
                );
        }

        
        public async ValueTask<decimal> get_DRAW_FRAMEBUFFER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DRAW_FRAMEBUFFER"
                );
        }
        public ValueTask set_DRAW_FRAMEBUFFER(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DRAW_FRAMEBUFFER",
                    value
                );
        }

        
        public async ValueTask<decimal> get_UNIFORM_BUFFER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNIFORM_BUFFER"
                );
        }
        public ValueTask set_UNIFORM_BUFFER(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "UNIFORM_BUFFER",
                    value
                );
        }

        
        public async ValueTask<decimal> get_HALF_FLOAT_OES()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "HALF_FLOAT_OES"
                );
        }
        public ValueTask set_HALF_FLOAT_OES(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "HALF_FLOAT_OES",
                    value
                );
        }

        
        public async ValueTask<decimal> get_RGBA16F()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RGBA16F"
                );
        }
        public ValueTask set_RGBA16F(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RGBA16F",
                    value
                );
        }

        
        public async ValueTask<decimal> get_RGBA32F()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RGBA32F"
                );
        }
        public ValueTask set_RGBA32F(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RGBA32F",
                    value
                );
        }

        
        public async ValueTask<decimal> get_R32F()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "R32F"
                );
        }
        public ValueTask set_R32F(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "R32F",
                    value
                );
        }

        
        public async ValueTask<decimal> get_RG32F()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RG32F"
                );
        }
        public ValueTask set_RG32F(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RG32F",
                    value
                );
        }

        
        public async ValueTask<decimal> get_RGB32F()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RGB32F"
                );
        }
        public ValueTask set_RGB32F(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RGB32F",
                    value
                );
        }

        
        public async ValueTask<decimal> get_R16F()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "R16F"
                );
        }
        public ValueTask set_R16F(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "R16F",
                    value
                );
        }

        
        public async ValueTask<decimal> get_RG16F()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RG16F"
                );
        }
        public ValueTask set_RG16F(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RG16F",
                    value
                );
        }

        
        public async ValueTask<decimal> get_RGB16F()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RGB16F"
                );
        }
        public ValueTask set_RGB16F(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RGB16F",
                    value
                );
        }

        
        public async ValueTask<decimal> get_RED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RED"
                );
        }
        public ValueTask set_RED(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RED",
                    value
                );
        }

        
        public async ValueTask<decimal> get_RG()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RG"
                );
        }
        public ValueTask set_RG(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RG",
                    value
                );
        }

        
        public async ValueTask<decimal> get_R8()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "R8"
                );
        }
        public ValueTask set_R8(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "R8",
                    value
                );
        }

        
        public async ValueTask<decimal> get_RG8()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RG8"
                );
        }
        public ValueTask set_RG8(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "RG8",
                    value
                );
        }

        
        public async ValueTask<decimal> get_UNSIGNED_INT_24_8()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "UNSIGNED_INT_24_8"
                );
        }
        public ValueTask set_UNSIGNED_INT_24_8(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "UNSIGNED_INT_24_8",
                    value
                );
        }

        
        public async ValueTask<decimal> get_DEPTH24_STENCIL8()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "DEPTH24_STENCIL8"
                );
        }
        public ValueTask set_DEPTH24_STENCIL8(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DEPTH24_STENCIL8",
                    value
                );
        }

        
        public async ValueTask<decimal> get_MIN()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MIN"
                );
        }
        public ValueTask set_MIN(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MIN",
                    value
                );
        }

        
        public async ValueTask<decimal> get_MAX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MAX"
                );
        }
        public ValueTask set_MAX(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "MAX",
                    value
                );
        }

        
        public async ValueTask<decimal> get_COLOR_ATTACHMENT0()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COLOR_ATTACHMENT0"
                );
        }

        
        public async ValueTask<decimal> get_COLOR_ATTACHMENT1()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COLOR_ATTACHMENT1"
                );
        }

        
        public async ValueTask<decimal> get_COLOR_ATTACHMENT2()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COLOR_ATTACHMENT2"
                );
        }

        
        public async ValueTask<decimal> get_COLOR_ATTACHMENT3()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "COLOR_ATTACHMENT3"
                );
        }

        
        public async ValueTask<decimal> get_ANY_SAMPLES_PASSED_CONSERVATIVE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ANY_SAMPLES_PASSED_CONSERVATIVE"
                );
        }
        public ValueTask set_ANY_SAMPLES_PASSED_CONSERVATIVE(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ANY_SAMPLES_PASSED_CONSERVATIVE",
                    value
                );
        }

        
        public async ValueTask<decimal> get_ANY_SAMPLES_PASSED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "ANY_SAMPLES_PASSED"
                );
        }
        public ValueTask set_ANY_SAMPLES_PASSED(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ANY_SAMPLES_PASSED",
                    value
                );
        }

        
        public async ValueTask<decimal> get_QUERY_RESULT_AVAILABLE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "QUERY_RESULT_AVAILABLE"
                );
        }
        public ValueTask set_QUERY_RESULT_AVAILABLE(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "QUERY_RESULT_AVAILABLE",
                    value
                );
        }

        
        public async ValueTask<decimal> get_QUERY_RESULT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "QUERY_RESULT"
                );
        }
        public ValueTask set_QUERY_RESULT(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "QUERY_RESULT",
                    value
                );
        }
    #endregion
    
    #region Constructor
        public WebGLRenderingContextCachedEntity() : base() { }

        public WebGLRenderingContextCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public async ValueTask drawArraysInstanced(decimal mode, decimal first, decimal count, decimal primcount)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawArraysInstanced" }, mode, first, count, primcount
                }
            );
        }

        public async ValueTask drawElementsInstanced(decimal mode, decimal count, decimal type, decimal offset, decimal primcount)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawElementsInstanced" }, mode, count, type, offset, primcount
                }
            );
        }

        public async ValueTask vertexAttribDivisor(decimal index, decimal divisor)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "vertexAttribDivisor" }, index, divisor
                }
            );
        }

        public async ValueTask<CachedEntity> createVertexArray()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "createVertexArray" }
                }
            );
        }

        public async ValueTask bindVertexArray(WebGLVertexArrayObject vao = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindVertexArray" }, vao
                }
            );
        }

        public async ValueTask deleteVertexArray(WebGLVertexArrayObject vao)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "deleteVertexArray" }, vao
                }
            );
        }

        public async ValueTask blitFramebuffer(decimal srcX0, decimal srcY0, decimal srcX1, decimal srcY1, decimal dstX0, decimal dstY0, decimal dstX1, decimal dstY1, decimal mask, decimal filter)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "blitFramebuffer" }, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter
                }
            );
        }

        public async ValueTask renderbufferStorageMultisample(decimal target, decimal samples, decimal internalformat, decimal width, decimal height)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "renderbufferStorageMultisample" }, target, samples, internalformat, width, height
                }
            );
        }

        public async ValueTask bindBufferBase(decimal target, decimal index, WebGLBuffer buffer = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindBufferBase" }, target, index, buffer
                }
            );
        }

        public async ValueTask<decimal> getUniformBlockIndex(WebGLProgram program, string uniformBlockName)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getUniformBlockIndex" }, program, uniformBlockName
                }
            );
        }

        public async ValueTask uniformBlockBinding(WebGLProgram program, decimal uniformBlockIndex, decimal uniformBlockBinding)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "uniformBlockBinding" }, program, uniformBlockIndex, uniformBlockBinding
                }
            );
        }

        public async ValueTask<WebGLQueryCachedEntity> createQuery()
        {
            return await EventHorizonBlazorInterop.FuncClass<WebGLQueryCachedEntity>(
                entity => new WebGLQueryCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createQuery" }
                }
            );
        }

        public async ValueTask deleteQuery(WebGLQuery query)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "deleteQuery" }, query
                }
            );
        }

        public async ValueTask beginQuery(decimal target, WebGLQuery query)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "beginQuery" }, target, query
                }
            );
        }

        public async ValueTask endQuery(decimal target)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "endQuery" }, target
                }
            );
        }

        public async ValueTask<CachedEntity> getQueryParameter(WebGLQuery query, decimal pname)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getQueryParameter" }, query, pname
                }
            );
        }

        public async ValueTask<CachedEntity> getQuery(decimal target, decimal pname)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getQuery" }, target, pname
                }
            );
        }

        public async ValueTask drawBuffers(decimal[] buffers)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawBuffers" }, buffers
                }
            );
        }

        public async ValueTask readBuffer(decimal src)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "readBuffer" }, src
                }
            );
        }
    #endregion
}