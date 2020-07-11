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
    public class DepthSortedParticle : CachedEntityObject
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
        
        public decimal ind
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "ind"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "ind",
                    value
                );
            }
        }

        
        public decimal indicesLength
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "indicesLength"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "indicesLength",
                    value
                );
            }
        }

        
        public decimal sqDistance
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "sqDistance"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sqDistance",
                    value
                );
            }
        }

        
        public decimal materialIndex
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "materialIndex"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "materialIndex",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public DepthSortedParticle() : base() { } 

        public DepthSortedParticle(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public DepthSortedParticle(
            decimal ind, decimal indLength, decimal materialIndex
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "DepthSortedParticle" },
                ind, indLength, materialIndex
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods

        #endregion
    }
}