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

    
    
    [JsonConverter(typeof(CachedEntityConverter<RuntimeAnimation>))]
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentFrame"
                );
            }
        }

        
        public decimal weight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "weight"
                );
            }
        }

        
        public CachedEntity currentValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "currentValue"
                );
            }
        }

        
        public string targetPath
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "targetPath"
                );
            }
        }

        
        public CachedEntity target
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "target"
                );
            }
        }

        
        public bool isAdditive
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isAdditive"
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
                __animation = EventHorizonBlazorInterop.GetClass<Animation>(
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
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RuntimeAnimation" },
                target, animation, scene, host
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void reset(System.Nullable<bool> restoreOriginal = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }, restoreOriginal
                }
            );
        }

        public bool isStopped()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isStopped" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public void setValue(object currentValue, decimal weight)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setValue" }, currentValue, weight
                }
            );
        }

        public void goToFrame(decimal frame)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "goToFrame" }, frame
                }
            );
        }

        public bool animate(decimal delay, decimal from, decimal to, bool loop, decimal speedRatio, System.Nullable<decimal> weight = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "animate" }, delay, from, to, loop, speedRatio, weight
                }
            );
        }
        #endregion
    }
}