/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface WebGL2RenderingContext : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<WebGL2RenderingContextCachedEntity>))]
public class WebGL2RenderingContextCachedEntity : CachedEntityObject, WebGL2RenderingContext
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

    public async ValueTask<decimal> get_HALF_FLOAT_OES()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "HALF_FLOAT_OES");
    }

    public ValueTask set_HALF_FLOAT_OES(decimal value)
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "HALF_FLOAT_OES", value);
    }

    private RGBA16F __RGBA16F;

    public async ValueTask<RGBA16F> get_RGBA16F()
    {
        if (__RGBA16F == null)
        {
            __RGBA16F = await EventHorizonBlazorInterop.GetClass<RGBA16F>(
                this.___guid,
                "RGBA16F",
                (entity) =>
                {
                    return new RGBA16F() { ___guid = entity.___guid };
                }
            );
        }
        return __RGBA16F;
    }

    public ValueTask set_RGBA16F(RGBA16F value)
    {
        __RGBA16F = null;
        return EventHorizonBlazorInterop.Set(this.___guid, "RGBA16F", value);
    }

    private RGBA32F __RGBA32F;

    public async ValueTask<RGBA32F> get_RGBA32F()
    {
        if (__RGBA32F == null)
        {
            __RGBA32F = await EventHorizonBlazorInterop.GetClass<RGBA32F>(
                this.___guid,
                "RGBA32F",
                (entity) =>
                {
                    return new RGBA32F() { ___guid = entity.___guid };
                }
            );
        }
        return __RGBA32F;
    }

    public ValueTask set_RGBA32F(RGBA32F value)
    {
        __RGBA32F = null;
        return EventHorizonBlazorInterop.Set(this.___guid, "RGBA32F", value);
    }

    private DEPTH24_STENCIL8 __DEPTH24_STENCIL8;

    public async ValueTask<DEPTH24_STENCIL8> get_DEPTH24_STENCIL8()
    {
        if (__DEPTH24_STENCIL8 == null)
        {
            __DEPTH24_STENCIL8 = await EventHorizonBlazorInterop.GetClass<DEPTH24_STENCIL8>(
                this.___guid,
                "DEPTH24_STENCIL8",
                (entity) =>
                {
                    return new DEPTH24_STENCIL8() { ___guid = entity.___guid };
                }
            );
        }
        return __DEPTH24_STENCIL8;
    }

    public ValueTask set_DEPTH24_STENCIL8(DEPTH24_STENCIL8 value)
    {
        __DEPTH24_STENCIL8 = null;
        return EventHorizonBlazorInterop.Set(this.___guid, "DEPTH24_STENCIL8", value);
    }

    public async ValueTask<decimal> get_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(
            this.___guid,
            "COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR"
        );
    }

    public ValueTask set_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR(decimal value)
    {
        return EventHorizonBlazorInterop.Set(
            this.___guid,
            "COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR",
            value
        );
    }

    public async ValueTask<decimal> get_COMPRESSED_SRGB_S3TC_DXT1_EXT()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(
            this.___guid,
            "COMPRESSED_SRGB_S3TC_DXT1_EXT"
        );
    }

    public ValueTask set_COMPRESSED_SRGB_S3TC_DXT1_EXT(decimal value)
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "COMPRESSED_SRGB_S3TC_DXT1_EXT", value);
    }

    public async ValueTask<decimal> get_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(
            this.___guid,
            "COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT"
        );
    }

    public ValueTask set_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT(decimal value)
    {
        return EventHorizonBlazorInterop.Set(
            this.___guid,
            "COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT",
            value
        );
    }

    public async ValueTask<decimal> get_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(
            this.___guid,
            "COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT"
        );
    }

    public ValueTask set_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT(decimal value)
    {
        return EventHorizonBlazorInterop.Set(
            this.___guid,
            "COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT",
            value
        );
    }

    public async ValueTask<decimal> get_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(
            this.___guid,
            "COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT"
        );
    }

    public ValueTask set_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT(decimal value)
    {
        return EventHorizonBlazorInterop.Set(
            this.___guid,
            "COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT",
            value
        );
    }

    public async ValueTask<decimal> get_COMPRESSED_SRGB8_ETC2()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "COMPRESSED_SRGB8_ETC2");
    }

    public ValueTask set_COMPRESSED_SRGB8_ETC2(decimal value)
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "COMPRESSED_SRGB8_ETC2", value);
    }

    public async ValueTask<decimal> get_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC()
    {
        return await EventHorizonBlazorInterop.Get<decimal>(
            this.___guid,
            "COMPRESSED_SRGB8_ALPHA8_ETC2_EAC"
        );
    }

    public ValueTask set_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC(decimal value)
    {
        return EventHorizonBlazorInterop.Set(
            this.___guid,
            "COMPRESSED_SRGB8_ALPHA8_ETC2_EAC",
            value
        );
    }

    private DRAW_FRAMEBUFFER __DRAW_FRAMEBUFFER;

    public async ValueTask<DRAW_FRAMEBUFFER> get_DRAW_FRAMEBUFFER()
    {
        if (__DRAW_FRAMEBUFFER == null)
        {
            __DRAW_FRAMEBUFFER = await EventHorizonBlazorInterop.GetClass<DRAW_FRAMEBUFFER>(
                this.___guid,
                "DRAW_FRAMEBUFFER",
                (entity) =>
                {
                    return new DRAW_FRAMEBUFFER() { ___guid = entity.___guid };
                }
            );
        }
        return __DRAW_FRAMEBUFFER;
    }

    public ValueTask set_DRAW_FRAMEBUFFER(DRAW_FRAMEBUFFER value)
    {
        __DRAW_FRAMEBUFFER = null;
        return EventHorizonBlazorInterop.Set(this.___guid, "DRAW_FRAMEBUFFER", value);
    }

    private UNSIGNED_INT_24_8 __UNSIGNED_INT_24_8;

    public async ValueTask<UNSIGNED_INT_24_8> get_UNSIGNED_INT_24_8()
    {
        if (__UNSIGNED_INT_24_8 == null)
        {
            __UNSIGNED_INT_24_8 = await EventHorizonBlazorInterop.GetClass<UNSIGNED_INT_24_8>(
                this.___guid,
                "UNSIGNED_INT_24_8",
                (entity) =>
                {
                    return new UNSIGNED_INT_24_8() { ___guid = entity.___guid };
                }
            );
        }
        return __UNSIGNED_INT_24_8;
    }

    public ValueTask set_UNSIGNED_INT_24_8(UNSIGNED_INT_24_8 value)
    {
        __UNSIGNED_INT_24_8 = null;
        return EventHorizonBlazorInterop.Set(this.___guid, "UNSIGNED_INT_24_8", value);
    }

    private MIN __MIN;

    public async ValueTask<MIN> get_MIN()
    {
        if (__MIN == null)
        {
            __MIN = await EventHorizonBlazorInterop.GetClass<MIN>(
                this.___guid,
                "MIN",
                (entity) =>
                {
                    return new MIN() { ___guid = entity.___guid };
                }
            );
        }
        return __MIN;
    }

    public ValueTask set_MIN(MIN value)
    {
        __MIN = null;
        return EventHorizonBlazorInterop.Set(this.___guid, "MIN", value);
    }

    private MAX __MAX;

    public async ValueTask<MAX> get_MAX()
    {
        if (__MAX == null)
        {
            __MAX = await EventHorizonBlazorInterop.GetClass<MAX>(
                this.___guid,
                "MAX",
                (entity) =>
                {
                    return new MAX() { ___guid = entity.___guid };
                }
            );
        }
        return __MAX;
    }

    public ValueTask set_MAX(MAX value)
    {
        __MAX = null;
        return EventHorizonBlazorInterop.Set(this.___guid, "MAX", value);
    }
    #endregion

    #region Constructor
    public WebGL2RenderingContextCachedEntity()
        : base() { }

    public WebGL2RenderingContextCachedEntity(ICachedEntity entity)
        : base(entity) { }

    #endregion

    #region Methods

    #endregion
}
