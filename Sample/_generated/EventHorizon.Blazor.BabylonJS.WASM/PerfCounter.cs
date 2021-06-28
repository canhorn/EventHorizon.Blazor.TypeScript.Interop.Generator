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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PerfCounter>))]
    public class PerfCounter : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static bool Enabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "PerfCounter.Enabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "PerfCounter.Enabled",
                    value
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public decimal min
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "min"
                );
            }
        }

        
        public decimal max
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "max"
                );
            }
        }

        
        public decimal average
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "average"
                );
            }
        }

        
        public decimal lastSecAverage
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lastSecAverage"
                );
            }
        }

        
        public decimal current
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "current"
                );
            }
        }

        
        public decimal total
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "total"
                );
            }
        }

        
        public decimal count
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "count"
                );
            }
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
        public void fetchNewFrame()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fetchNewFrame" }
                }
            );
        }

        public void addCount(decimal newCount, bool fetchResult)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addCount" }, newCount, fetchResult
                }
            );
        }

        public void beginMonitoring()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "beginMonitoring" }
                }
            );
        }

        public void endMonitoring(System.Nullable<bool> newFrame = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "endMonitoring" }, newFrame
                }
            );
        }
        #endregion
    }
}