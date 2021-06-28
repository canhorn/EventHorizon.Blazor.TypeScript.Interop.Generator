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
        
        public decimal averageFrameTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "averageFrameTime"
                );
            }
        }

        
        public decimal averageFrameTimeVariance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "averageFrameTimeVariance"
                );
            }
        }

        
        public decimal instantaneousFrameTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "instantaneousFrameTime"
                );
            }
        }

        
        public decimal averageFPS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "averageFPS"
                );
            }
        }

        
        public decimal instantaneousFPS
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "instantaneousFPS"
                );
            }
        }

        
        public bool isSaturated
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSaturated"
                );
            }
        }

        
        public bool isEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
            }
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

        public PerformanceMonitor(
            System.Nullable<decimal> frameSampleSize = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PerformanceMonitor" },
                frameSampleSize
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void sampleFrame(System.Nullable<decimal> timeMs = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sampleFrame" }, timeMs
                }
            );
        }

        public void enable()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "enable" }
                }
            );
        }

        public void disable()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "disable" }
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }
        #endregion
    }
}