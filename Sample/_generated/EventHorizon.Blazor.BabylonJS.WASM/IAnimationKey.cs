/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IAnimationKey { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IAnimationKeyCachedEntity : CachedEntityObject, IAnimationKey
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
        
        public decimal frame
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "frame"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "frame",
                    value
                );
            }
        }

        
        public CachedEntity value
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "value"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "value",
                    value
                );
            }
        }

        
        public CachedEntity inTangent
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "inTangent"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "inTangent",
                    value
                );
            }
        }

        
        public CachedEntity outTangent
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "outTangent"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "outTangent",
                    value
                );
            }
        }

        private AnimationKeyInterpolation __interpolation;
        public AnimationKeyInterpolation interpolation
        {
            get
            {
            if(__interpolation == null)
            {
                __interpolation = EventHorizonBlazorInteropt.GetClass<AnimationKeyInterpolation>(
                    this.___guid,
                    "interpolation",
                    (entity) =>
                    {
                        return new AnimationKeyInterpolation(entity);
                    }
                );
            }
            return __interpolation;
            }
            set
            {
__interpolation = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "interpolation",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IAnimationKeyCachedEntity() : base() { }

        public IAnimationKeyCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}