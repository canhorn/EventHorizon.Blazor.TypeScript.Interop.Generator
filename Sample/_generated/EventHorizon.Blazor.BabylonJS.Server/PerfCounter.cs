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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PerfCounter>))]
    public class PerfCounter : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<bool> get_Enabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "PerfCounter.Enabled"
                );
        }
        public static ValueTask set_Enabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "PerfCounter.Enabled",
                    value
                );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_min()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "min"
                );
        }

        
        public async ValueTask<decimal> get_max()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "max"
                );
        }

        
        public async ValueTask<decimal> get_average()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "average"
                );
        }

        
        public async ValueTask<decimal> get_lastSecAverage()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lastSecAverage"
                );
        }

        
        public async ValueTask<decimal> get_current()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "current"
                );
        }

        
        public async ValueTask<decimal> get_total()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "total"
                );
        }

        
        public async ValueTask<decimal> get_count()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "count"
                );
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public PerfCounter() : base() { } 

        public PerfCounter(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public async ValueTask fetchNewFrame()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "fetchNewFrame" }
                }
            );
        }

        public async ValueTask addCount(decimal newCount, bool fetchResult)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addCount" }, newCount, fetchResult
                }
            );
        }

        public async ValueTask beginMonitoring()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "beginMonitoring" }
                }
            );
        }

        public async ValueTask endMonitoring(System.Nullable<bool> newFrame = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "endMonitoring" }, newFrame
                }
            );
        }
        #endregion
    }
}