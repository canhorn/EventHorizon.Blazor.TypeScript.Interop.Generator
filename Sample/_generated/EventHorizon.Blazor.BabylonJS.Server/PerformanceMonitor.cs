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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PerformanceMonitor>))]
    public class PerformanceMonitor : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_averageFrameTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "averageFrameTime"
                );
        }

        
        public async ValueTask<decimal> get_averageFrameTimeVariance()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "averageFrameTimeVariance"
                );
        }

        
        public async ValueTask<decimal> get_instantaneousFrameTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "instantaneousFrameTime"
                );
        }

        
        public async ValueTask<decimal> get_averageFPS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "averageFPS"
                );
        }

        
        public async ValueTask<decimal> get_instantaneousFPS()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "instantaneousFPS"
                );
        }

        
        public async ValueTask<bool> get_isSaturated()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSaturated"
                );
        }

        
        public async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public PerformanceMonitor() : base() { } 

        public PerformanceMonitor(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<PerformanceMonitor> NewPerformanceMonitor(
            System.Nullable<decimal> frameSampleSize = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PerformanceMonitor" },
                frameSampleSize
            );

            return new PerformanceMonitor(entity);
        }
        #endregion

        #region Methods
        public async ValueTask sampleFrame(System.Nullable<decimal> timeMs = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "sampleFrame" }, timeMs
                }
            );
        }

        public async ValueTask enable()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enable" }
                }
            );
        }

        public async ValueTask disable()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disable" }
                }
            );
        }

        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }
        #endregion
    }
}