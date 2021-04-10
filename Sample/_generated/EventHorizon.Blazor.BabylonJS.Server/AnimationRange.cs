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
        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        
        public async ValueTask<decimal> get_from()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "from"
                );
        }
        public ValueTask set_from(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "from",
                    value
                );
        }

        
        public async ValueTask<decimal> get_to()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "to"
                );
        }
        public ValueTask set_to(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "to",
                    value
                );
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

        public static async ValueTask<AnimationRange> NewAnimationRange(
            string name, decimal from, decimal to
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AnimationRange" },
                name, from, to
            );

            return new AnimationRange(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<AnimationRange> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationRange>(
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