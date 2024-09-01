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
        public BaseTexture texture
        {
            get
            {
                if (__texture == null)
                {
                    __texture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
            set
            {
                __texture = null;
                EventHorizonBlazorInterop.Set(this.___guid, "texture", value);
            }
        }

        public bool isEnabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isEnabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isEnabled", value);
            }
        }

        private Vector4 __animationParameters;
        public Vector4 animationParameters
        {
            get
            {
                if (__animationParameters == null)
                {
                    __animationParameters = EventHorizonBlazorInterop.GetClass<Vector4>(
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
            set
            {
                __animationParameters = null;
                EventHorizonBlazorInterop.Set(this.___guid, "animationParameters", value);
            }
        }

        public decimal time
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "time"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "time", value);
            }
        }
        #endregion

        #region Constructor
        public IBakedVertexAnimationManagerCachedEntity()
            : base() { }

        public IBakedVertexAnimationManagerCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void bind(Effect effect, bool useInstances)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "bind" }, effect, useInstances }
            );
        }

        public void setAnimationParameters(
            decimal startFrame,
            decimal endFrame,
            decimal offset,
            decimal speedFramesPerSecond
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public void dispose(System.Nullable<bool> forceDisposeTextures = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" }, forceDisposeTextures }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }
        #endregion
    }
}
