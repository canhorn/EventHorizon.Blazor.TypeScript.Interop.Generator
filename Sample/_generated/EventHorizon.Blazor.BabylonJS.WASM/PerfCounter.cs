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
    public class PerfCounter : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static bool Enabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "PerfCounter.Enabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "min"
                );
            }
        }

        
        public decimal max
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "max"
                );
            }
        }

        
        public decimal average
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "average"
                );
            }
        }

        
        public decimal lastSecAverage
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "lastSecAverage"
                );
            }
        }

        
        public decimal current
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "current"
                );
            }
        }

        
        public decimal total
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "total"
                );
            }
        }

        
        public decimal count
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
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
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "fetchNewFrame" }
                }
            );
        }

        public void addCount(decimal newCount, bool fetchResult)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addCount" }, newCount, fetchResult
                }
            );
        }

        public void beginMonitoring()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "beginMonitoring" }
                }
            );
        }

        public void endMonitoring(System.Nullable<bool> newFrame = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "endMonitoring" }, newFrame
                }
            );
        }
        #endregion
    }
}