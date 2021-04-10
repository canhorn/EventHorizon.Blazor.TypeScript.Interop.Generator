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
        
        public async ValueTask<decimal> get_currentFrame()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentFrame"
                );
        }

        
        public async ValueTask<decimal> get_weight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "weight"
                );
        }

        
        public async ValueTask<CachedEntity> get_currentValue()
        {
            return await EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "currentValue"
                );
        }

        
        public async ValueTask<string> get_targetPath()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "targetPath"
                );
        }

        
        public async ValueTask<CachedEntity> get_target()
        {
            return await EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "target"
                );
        }

        
        public async ValueTask<bool> get_isAdditive()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isAdditive"
                );
        }

        private Animation __animation;
        public async ValueTask<Animation> get_animation()
        {
            if(__animation == null)
            {
                __animation = await EventHorizonBlazorInterop.GetClass<Animation>(
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

        public static async ValueTask<RuntimeAnimation> NewRuntimeAnimation(
            object target, Animation animation, Scene scene, Animatable host
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "RuntimeAnimation" },
                target, animation, scene, host
            );

            return new RuntimeAnimation(entity);
        }
        #endregion

        #region Methods
        public async ValueTask reset(System.Nullable<bool> restoreOriginal = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }, restoreOriginal
                }
            );
        }

        public async ValueTask<bool> isStopped()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isStopped" }
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public async ValueTask setValue(object currentValue, decimal weight)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setValue" }, currentValue, weight
                }
            );
        }

        public async ValueTask goToFrame(decimal frame)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "goToFrame" }, frame
                }
            );
        }

        public async ValueTask<bool> animate(decimal delay, decimal from, decimal to, bool loop, decimal speedRatio, System.Nullable<decimal> weight = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "animate" }, delay, from, to, loop, speedRatio, weight
                }
            );
        }
        #endregion
    }
}