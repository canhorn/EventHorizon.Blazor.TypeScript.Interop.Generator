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
    public class StencilState : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal ALWAYS
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "StencilState.ALWAYS"
                );
            }
        }

        
        public static decimal KEEP
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "StencilState.KEEP"
                );
            }
        }

        
        public static decimal REPLACE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "StencilState.REPLACE"
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public bool isDirty
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isDirty"
                );
            }
        }

        
        public decimal stencilFunc
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "stencilFunc"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "stencilFunc",
                    value
                );
            }
        }

        
        public decimal stencilFuncRef
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "stencilFuncRef"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "stencilFuncRef",
                    value
                );
            }
        }

        
        public decimal stencilFuncMask
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "stencilFuncMask"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "stencilFuncMask",
                    value
                );
            }
        }

        
        public decimal stencilOpStencilFail
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "stencilOpStencilFail"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "stencilOpStencilFail",
                    value
                );
            }
        }

        
        public decimal stencilOpDepthFail
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "stencilOpDepthFail"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "stencilOpDepthFail",
                    value
                );
            }
        }

        
        public decimal stencilOpStencilDepthPass
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "stencilOpStencilDepthPass"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "stencilOpStencilDepthPass",
                    value
                );
            }
        }

        
        public decimal stencilMask
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "stencilMask"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "stencilMask",
                    value
                );
            }
        }

        
        public bool stencilTest
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "stencilTest"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "stencilTest",
                    value
                );
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public StencilState() : base() { } 

        public StencilState(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public void reset()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public void apply(WebGLRenderingContextCachedEntity gl)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "apply" }, gl
                }
            );
        }
        #endregion
    }
}