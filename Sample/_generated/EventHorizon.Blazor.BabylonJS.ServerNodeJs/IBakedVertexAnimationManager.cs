/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface IBakedVertexAnimationManager : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IBakedVertexAnimationManagerCachedEntity>))]
    public class IBakedVertexAnimationManagerCachedEntity
        : CachedEntityObject,
            IBakedVertexAnimationManager
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
        private BaseTexture __texture;

        public async ValueTask<BaseTexture> get_texture()
        {
            if (__texture == null)
            {
                __texture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "texture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __texture;
        }

        public ValueTask set_texture(BaseTexture value)
        {
            __texture = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "texture", value);
        }

        public async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isEnabled");
        }

        public ValueTask set_isEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isEnabled", value);
        }

        private Vector4 __animationParameters;

        public async ValueTask<Vector4> get_animationParameters()
        {
            if (__animationParameters == null)
            {
                __animationParameters = await EventHorizonBlazorInterop.GetClass<Vector4>(
                    this.___guid,
                    "animationParameters",
                    (entity) =>
                    {
                        return new Vector4() { ___guid = entity.___guid };
                    }
                );
            }
            return __animationParameters;
        }

        public ValueTask set_animationParameters(Vector4 value)
        {
            __animationParameters = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "animationParameters", value);
        }

        public async ValueTask<decimal> get_time()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "time");
        }

        public ValueTask set_time(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "time", value);
        }
        #endregion

        #region Constructor
        public IBakedVertexAnimationManagerCachedEntity()
            : base() { }

        public IBakedVertexAnimationManagerCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask bind(Effect effect, bool useInstances)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bind" }, effect, useInstances }
            );
        }

        public async ValueTask setAnimationParameters(
            decimal startFrame,
            decimal endFrame,
            decimal offset,
            decimal speedFramesPerSecond
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAnimationParameters" },
                    startFrame,
                    endFrame,
                    offset,
                    speedFramesPerSecond
                }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> forceDisposeTextures = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" }, forceDisposeTextures }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }
        #endregion
    }
}
