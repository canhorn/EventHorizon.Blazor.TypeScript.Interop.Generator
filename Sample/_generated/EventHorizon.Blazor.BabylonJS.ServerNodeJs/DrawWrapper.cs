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

    [JsonConverter(typeof(CachedEntityConverter<DrawWrapper>))]
    public class DrawWrapper : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Effect> GetEffect(Effect effect)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "DrawWrapper", "GetEffect" }, effect }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        private Effect __effect;

        public async ValueTask<Effect> get_effect()
        {
            if (__effect == null)
            {
                __effect = await EventHorizonBlazorInterop.GetClass<Effect>(
                    this.___guid,
                    "effect",
                    (entity) =>
                    {
                        return new Effect() { ___guid = entity.___guid };
                    }
                );
            }
            return __effect;
        }

        public ValueTask set_effect(Effect value)
        {
            __effect = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "effect", value);
        }

        public async ValueTask<string> get_defines()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "defines");
        }

        public ValueTask set_defines(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "defines", value);
        }

        private IMaterialContextCachedEntity __materialContext;

        public async ValueTask<IMaterialContextCachedEntity> get_materialContext()
        {
            if (__materialContext == null)
            {
                __materialContext =
                    await EventHorizonBlazorInterop.GetClass<IMaterialContextCachedEntity>(
                        this.___guid,
                        "materialContext",
                        (entity) =>
                        {
                            return new IMaterialContextCachedEntity() { ___guid = entity.___guid };
                        }
                    );
            }
            return __materialContext;
        }

        public ValueTask set_materialContext(IMaterialContextCachedEntity value)
        {
            __materialContext = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "materialContext", value);
        }

        private IDrawContextCachedEntity __drawContext;

        public async ValueTask<IDrawContextCachedEntity> get_drawContext()
        {
            if (__drawContext == null)
            {
                __drawContext = await EventHorizonBlazorInterop.GetClass<IDrawContextCachedEntity>(
                    this.___guid,
                    "drawContext",
                    (entity) =>
                    {
                        return new IDrawContextCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __drawContext;
        }

        public ValueTask set_drawContext(IDrawContextCachedEntity value)
        {
            __drawContext = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "drawContext", value);
        }
        #endregion

        #region Constructor
        public DrawWrapper()
            : base() { }

        public DrawWrapper(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<DrawWrapper> NewDrawWrapper(
            AbstractEngine engine,
            System.Nullable<bool> createMaterialContext = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DrawWrapper" },
                engine,
                createMaterialContext
            );

            return new DrawWrapper(entity);
        }
        #endregion

        #region Methods
        public async ValueTask setEffect(
            Effect effect,
            string defines = null,
            System.Nullable<bool> resetContext = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEffect" },
                    effect,
                    defines,
                    resetContext
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
