/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
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

    public decimal HALF_FLOAT_OES
    {
        get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "HALF_FLOAT_OES"); }
        set
        {

            EventHorizonBlazorInterop.Set(this.___guid, "HALF_FLOAT_OES", value);
        }
    }

    private RGBA16F __RGBA16F;
    public RGBA16F RGBA16F
    {
        get
        {
            if (__RGBA16F == null)
            {
                __RGBA16F = EventHorizonBlazorInterop.GetClass<RGBA16F>(
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
        set
        {
            __RGBA16F = null;
            EventHorizonBlazorInterop.Set(this.___guid, "RGBA16F", value);
        }
    }

    private RGBA32F __RGBA32F;
    public RGBA32F RGBA32F
    {
        get
        {
            if (__RGBA32F == null)
            {
                __RGBA32F = EventHorizonBlazorInterop.GetClass<RGBA32F>(
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
        set
        {
            __RGBA32F = null;
            EventHorizonBlazorInterop.Set(this.___guid, "RGBA32F", value);
        }
    }

    private DEPTH24_STENCIL8 __DEPTH24_STENCIL8;
    public DEPTH24_STENCIL8 DEPTH24_STENCIL8
    {
        get
        {
            if (__DEPTH24_STENCIL8 == null)
            {
                __DEPTH24_STENCIL8 = EventHorizonBlazorInterop.GetClass<DEPTH24_STENCIL8>(
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
        set
        {
            __DEPTH24_STENCIL8 = null;
            EventHorizonBlazorInterop.Set(this.___guid, "DEPTH24_STENCIL8", value);
        }
    }

    public decimal COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR
    {
        get
        {
            return EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR"
            );
        }
        set
        {

            EventHorizonBlazorInterop.Set(
                this.___guid,
                "COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR",
                value
            );
        }
    }

    public decimal COMPRESSED_SRGB_S3TC_DXT1_EXT
    {
        get
        {
            return EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "COMPRESSED_SRGB_S3TC_DXT1_EXT"
            );
        }
        set
        {

            EventHorizonBlazorInterop.Set(this.___guid, "COMPRESSED_SRGB_S3TC_DXT1_EXT", value);
        }
    }

    public decimal COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT
    {
        get
        {
            return EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT"
            );
        }
        set
        {

            EventHorizonBlazorInterop.Set(
                this.___guid,
                "COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT",
                value
            );
        }
    }

    public decimal COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT
    {
        get
        {
            return EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT"
            );
        }
        set
        {

            EventHorizonBlazorInterop.Set(
                this.___guid,
                "COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT",
                value
            );
        }
    }

    public decimal COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT
    {
        get
        {
            return EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT"
            );
        }
        set
        {

            EventHorizonBlazorInterop.Set(
                this.___guid,
                "COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT",
                value
            );
        }
    }

    public decimal COMPRESSED_SRGB8_ETC2
    {
        get
        {
            return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "COMPRESSED_SRGB8_ETC2");
        }
        set
        {

            EventHorizonBlazorInterop.Set(this.___guid, "COMPRESSED_SRGB8_ETC2", value);
        }
    }

    public decimal COMPRESSED_SRGB8_ALPHA8_ETC2_EAC
    {
        get
        {
            return EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "COMPRESSED_SRGB8_ALPHA8_ETC2_EAC"
            );
        }
        set
        {

            EventHorizonBlazorInterop.Set(this.___guid, "COMPRESSED_SRGB8_ALPHA8_ETC2_EAC", value);
        }
    }

    private DRAW_FRAMEBUFFER __DRAW_FRAMEBUFFER;
    public DRAW_FRAMEBUFFER DRAW_FRAMEBUFFER
    {
        get
        {
            if (__DRAW_FRAMEBUFFER == null)
            {
                __DRAW_FRAMEBUFFER = EventHorizonBlazorInterop.GetClass<DRAW_FRAMEBUFFER>(
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
        set
        {
            __DRAW_FRAMEBUFFER = null;
            EventHorizonBlazorInterop.Set(this.___guid, "DRAW_FRAMEBUFFER", value);
        }
    }

    private UNSIGNED_INT_24_8 __UNSIGNED_INT_24_8;
    public UNSIGNED_INT_24_8 UNSIGNED_INT_24_8
    {
        get
        {
            if (__UNSIGNED_INT_24_8 == null)
            {
                __UNSIGNED_INT_24_8 = EventHorizonBlazorInterop.GetClass<UNSIGNED_INT_24_8>(
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
        set
        {
            __UNSIGNED_INT_24_8 = null;
            EventHorizonBlazorInterop.Set(this.___guid, "UNSIGNED_INT_24_8", value);
        }
    }

    private MIN __MIN;
    public MIN MIN
    {
        get
        {
            if (__MIN == null)
            {
                __MIN = EventHorizonBlazorInterop.GetClass<MIN>(
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
        set
        {
            __MIN = null;
            EventHorizonBlazorInterop.Set(this.___guid, "MIN", value);
        }
    }

    private MAX __MAX;
    public MAX MAX
    {
        get
        {
            if (__MAX == null)
            {
                __MAX = EventHorizonBlazorInterop.GetClass<MAX>(
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
        set
        {
            __MAX = null;
            EventHorizonBlazorInterop.Set(this.___guid, "MAX", value);
        }
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
