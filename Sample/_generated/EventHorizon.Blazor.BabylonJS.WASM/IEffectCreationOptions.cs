/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IEffectCreationOptions { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IEffectCreationOptionsCachedEntity : CachedEntityObject, IEffectCreationOptions
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
        
        public string[] attributes
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<string>(
                    this.___guid,
                    "attributes"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "attributes",
                    value
                );
            }
        }

        
        public string[] uniformsNames
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<string>(
                    this.___guid,
                    "uniformsNames"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "uniformsNames",
                    value
                );
            }
        }

        
        public string[] uniformBuffersNames
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<string>(
                    this.___guid,
                    "uniformBuffersNames"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "uniformBuffersNames",
                    value
                );
            }
        }

        
        public string[] samplers
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<string>(
                    this.___guid,
                    "samplers"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "samplers",
                    value
                );
            }
        }

        
        public CachedEntity defines
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "defines"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "defines",
                    value
                );
            }
        }

        private IEffectFallbacks __fallbacks;
        public IEffectFallbacks fallbacks
        {
            get
            {
            if(__fallbacks == null)
            {
                __fallbacks = EventHorizonBlazorInteropt.GetClass<IEffectFallbacks>(
                    this.___guid,
                    "fallbacks",
                    (entity) =>
                    {
                        return new IEffectFallbacksCachedEntity(entity);
                    }
                );
            }
            return __fallbacks;
            }
            set
            {
__fallbacks = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "fallbacks",
                    value
                );
            }
        }

        private Effect __onCompiled;
        public Effect onCompiled
        {
            get
            {
            if(__onCompiled == null)
            {
                __onCompiled = EventHorizonBlazorInteropt.GetClass<Effect>(
                    this.___guid,
                    "onCompiled",
                    (entity) =>
                    {
                        return new Effect(entity);
                    }
                );
            }
            return __onCompiled;
            }
            set
            {
__onCompiled = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onCompiled",
                    value
                );
            }
        }

        private Effect __onError;
        public Effect onError
        {
            get
            {
            if(__onError == null)
            {
                __onError = EventHorizonBlazorInteropt.GetClass<Effect>(
                    this.___guid,
                    "onError",
                    (entity) =>
                    {
                        return new Effect(entity);
                    }
                );
            }
            return __onError;
            }
            set
            {
__onError = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onError",
                    value
                );
            }
        }

        
        public CachedEntity indexParameters
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "indexParameters"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "indexParameters",
                    value
                );
            }
        }

        
        public decimal maxSimultaneousLights
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxSimultaneousLights"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxSimultaneousLights",
                    value
                );
            }
        }

        
        public string[] transformFeedbackVaryings
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<string>(
                    this.___guid,
                    "transformFeedbackVaryings"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "transformFeedbackVaryings",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IEffectCreationOptionsCachedEntity() : base() { }

        public IEffectCreationOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}