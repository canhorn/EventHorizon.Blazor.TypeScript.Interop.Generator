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
        public Ray ray
        {
            get
            {
            if(__ray == null)
            {
                __ray = EventHorizonBlazorInterop.GetClass<Ray>(
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
            set
            {
__ray = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ray",
                    value
                );
            }
        }

        private Vector2 __localPosition;
        public Vector2 localPosition
        {
            get
            {
            if(__localPosition == null)
            {
                __localPosition = EventHorizonBlazorInterop.GetClass<Vector2>(
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
            set
            {
__localPosition = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "localPosition",
                    value
                );
            }
        }

        
        public bool skipOnPointerObservable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skipOnPointerObservable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skipOnPointerObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public PointerInfoPre() : base() { }

        public PointerInfoPre(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PointerInfoPre(
            decimal type, PointerEvent @event, decimal localX, decimal localY
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PointerInfoPre" },
                type, @event, localX, localY
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}