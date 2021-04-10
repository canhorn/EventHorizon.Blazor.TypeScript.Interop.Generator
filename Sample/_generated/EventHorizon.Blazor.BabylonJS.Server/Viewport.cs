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
        
        public async ValueTask<decimal> get_x()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "x"
                );
        }
        public ValueTask set_x(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "x",
                    value
                );
        }

        
        public async ValueTask<decimal> get_y()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "y"
                );
        }
        public ValueTask set_y(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "y",
                    value
                );
        }

        
        public async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
        }
        public ValueTask set_width(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
        }

        
        public async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
        }
        public ValueTask set_height(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
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

        public static async ValueTask<Viewport> NewViewport(
            decimal x, decimal y, decimal width, decimal height
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Viewport" },
                x, y, width, height
            );

            return new Viewport(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<Viewport> toGlobal(decimal renderWidth, decimal renderHeight)
        {
            return await EventHorizonBlazorInterop.FuncClass<Viewport>(
                entity => new Viewport() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toGlobal" }, renderWidth, renderHeight
                }
            );
        }

        public async ValueTask<Viewport> toGlobalToRef(decimal renderWidth, decimal renderHeight, Viewport @ref)
        {
            return await EventHorizonBlazorInterop.FuncClass<Viewport>(
                entity => new Viewport() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toGlobalToRef" }, renderWidth, renderHeight, @ref
                }
            );
        }

        public async ValueTask<Viewport> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Viewport>(
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