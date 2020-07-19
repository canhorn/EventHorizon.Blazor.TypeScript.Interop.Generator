/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "x"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "y"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Viewport" },
                x, y, width, height
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Viewport toGlobal(decimal renderWidth, decimal renderHeight)
        {
            return EventHorizonBlazorInteropt.FuncClass<Viewport>(
                entity => new Viewport() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toGlobal" }, renderWidth, renderHeight
                }
            );
        }

        public Viewport toGlobalToRef(decimal renderWidth, decimal renderHeight, Viewport @ref)
        {
            return EventHorizonBlazorInteropt.FuncClass<Viewport>(
                entity => new Viewport() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "toGlobalToRef" }, renderWidth, renderHeight, @ref
                }
            );
        }

        public Viewport clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<Viewport>(
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