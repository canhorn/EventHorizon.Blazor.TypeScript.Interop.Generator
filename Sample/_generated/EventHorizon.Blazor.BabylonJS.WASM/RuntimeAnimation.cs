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
    public class RuntimeAnimation : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public decimal currentFrame
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "currentFrame"
                );
            }
        }

        
        public decimal weight
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "weight"
                );
            }
        }

        
        public CachedEntity currentValue
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "currentValue"
                );
            }
        }

        
        public string targetPath
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "targetPath"
                );
            }
        }

        
        public CachedEntity target
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "target"
                );
            }
        }

        private Animation __animation;
        public Animation animation
        {
            get
            {
            if(__animation == null)
            {
                __animation = EventHorizonBlazorInteropt.GetClass<Animation>(
                    this.___guid,
                    "animation",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
            }
            return __animation;
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public RuntimeAnimation() : base() { } 

        public RuntimeAnimation(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public RuntimeAnimation(
            object target, Animation animation, Scene scene, Animatable host
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "RuntimeAnimation" },
                target, animation, scene, host
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void reset(System.Nullable<bool> restoreOriginal = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }, restoreOriginal
                }
            );
        }

        public bool isStopped()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isStopped" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public void setValue(object currentValue, decimal weight)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setValue" }, currentValue, weight
                }
            );
        }

        public void goToFrame(decimal frame)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "goToFrame" }, frame
                }
            );
        }

        public bool animate(decimal delay, decimal from, decimal to, bool loop, decimal speedRatio, System.Nullable<decimal> weight = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "animate" }, delay, from, to, loop, speedRatio, weight
                }
            );
        }
        #endregion
    }
}