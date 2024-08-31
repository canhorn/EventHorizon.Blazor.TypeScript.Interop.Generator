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

    [JsonConverter(typeof(CachedEntityConverter<DrawWrapper>))]
    public class DrawWrapper : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Effect GetEffect(Effect effect)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] { new string[] { "BABYLON", "DrawWrapper", "GetEffect" }, effect }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        private Effect __effect;
        public Effect effect
        {
            get
            {
                if (__effect == null)
                {
                    __effect = EventHorizonBlazorInterop.GetClass<Effect>(
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
            set
            {
                __effect = null;
                EventHorizonBlazorInterop.Set(this.___guid, "effect", value);
            }
        }

        public string defines
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "defines"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "defines", value);
            }
        }

        private IMaterialContextCachedEntity __materialContext;
        public IMaterialContextCachedEntity materialContext
        {
            get
            {
                if (__materialContext == null)
                {
                    __materialContext =
                        EventHorizonBlazorInterop.GetClass<IMaterialContextCachedEntity>(
                            this.___guid,
                            "materialContext",
                            (entity) =>
                            {
                                return new IMaterialContextCachedEntity()
                                {
                                    ___guid = entity.___guid
                                };
                            }
                        );
                }
                return __materialContext;
            }
            set
            {
                __materialContext = null;
                EventHorizonBlazorInterop.Set(this.___guid, "materialContext", value);
            }
        }

        private IDrawContextCachedEntity __drawContext;
        public IDrawContextCachedEntity drawContext
        {
            get
            {
                if (__drawContext == null)
                {
                    __drawContext = EventHorizonBlazorInterop.GetClass<IDrawContextCachedEntity>(
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
            set
            {
                __drawContext = null;
                EventHorizonBlazorInterop.Set(this.___guid, "drawContext", value);
            }
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

        public DrawWrapper(
            AbstractEngine engine,
            System.Nullable<bool> createMaterialContext = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "DrawWrapper" },
                engine,
                createMaterialContext
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setEffect(
            Effect effect,
            string defines = null,
            System.Nullable<bool> resetContext = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEffect" },
                    effect,
                    defines,
                    resetContext
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
