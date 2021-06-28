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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Viewport>))]
    public class Viewport : CachedEntityObject
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
        
        public decimal x
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
            }
        }

        
        public decimal y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Viewport() : base() { }

        public Viewport(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Viewport(
            decimal x, decimal y, decimal width, decimal height
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Viewport" },
                x, y, width, height
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Viewport toGlobal(decimal renderWidth, decimal renderHeight)
        {
            return EventHorizonBlazorInterop.FuncClass<Viewport>(
                entity => new Viewport() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toGlobal" }, renderWidth, renderHeight
                }
            );
        }

        public Viewport toGlobalToRef(decimal renderWidth, decimal renderHeight, Viewport @ref)
        {
            return EventHorizonBlazorInterop.FuncClass<Viewport>(
                entity => new Viewport() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "toGlobalToRef" }, renderWidth, renderHeight, @ref
                }
            );
        }

        public Viewport clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Viewport>(
                entity => new Viewport() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }
        #endregion
    }
}