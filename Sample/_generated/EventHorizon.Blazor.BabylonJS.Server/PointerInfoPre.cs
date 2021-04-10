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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PointerInfoPre>))]
    public class PointerInfoPre : PointerInfoBase
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
        private Ray __ray;
        public async ValueTask<Ray> get_ray()
        {
            if(__ray == null)
            {
                __ray = await EventHorizonBlazorInterop.GetClass<Ray>(
                    this.___guid,
                    "ray",
                    (entity) =>
                    {
                        return new Ray() { ___guid = entity.___guid };
                    }
                );
            }
            return __ray;
        }
        public ValueTask set_ray(Ray value)
        {
__ray = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ray",
                    value
                );
        }

        private Vector2 __localPosition;
        public async ValueTask<Vector2> get_localPosition()
        {
            if(__localPosition == null)
            {
                __localPosition = await EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "localPosition",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __localPosition;
        }
        public ValueTask set_localPosition(Vector2 value)
        {
__localPosition = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "localPosition",
                    value
                );
        }

        
        public async ValueTask<bool> get_skipOnPointerObservable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skipOnPointerObservable"
                );
        }
        public ValueTask set_skipOnPointerObservable(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skipOnPointerObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public PointerInfoPre() : base() { }

        public PointerInfoPre(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<PointerInfoPre> NewPointerInfoPre(
            decimal type, PointerEvent @event, decimal localX, decimal localY
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PointerInfoPre" },
                type, @event, localX, localY
            );

            return new PointerInfoPre(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}