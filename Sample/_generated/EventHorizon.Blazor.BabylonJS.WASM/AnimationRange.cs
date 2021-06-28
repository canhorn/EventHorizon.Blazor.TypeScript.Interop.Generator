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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AnimationRange>))]
    public class AnimationRange : CachedEntityObject
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
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public decimal from
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "from"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "from",
                    value
                );
            }
        }

        
        public decimal to
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "to"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "to",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AnimationRange() : base() { }

        public AnimationRange(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AnimationRange(
            string name, decimal from, decimal to
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AnimationRange" },
                name, from, to
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public AnimationRange clone()
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationRange>(
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }
        #endregion
    }
}