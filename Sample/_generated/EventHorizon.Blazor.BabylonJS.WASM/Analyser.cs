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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Analyser>))]
    public class Analyser : CachedEntityObject
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
        
        public decimal SMOOTHING
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SMOOTHING"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SMOOTHING",
                    value
                );
            }
        }

        
        public decimal FFT_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FFT_SIZE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "FFT_SIZE",
                    value
                );
            }
        }

        
        public decimal BARGRAPHAMPLITUDE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BARGRAPHAMPLITUDE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BARGRAPHAMPLITUDE",
                    value
                );
            }
        }

        
        public CachedEntity DEBUGCANVASPOS
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "DEBUGCANVASPOS",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DEBUGCANVASPOS",
                    value
                );
            }
        }

        
        public CachedEntity DEBUGCANVASSIZE
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "DEBUGCANVASSIZE",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DEBUGCANVASSIZE",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Analyser() : base() { }

        public Analyser(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Analyser(
            Scene scene
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Analyser" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal getFrequencyBinCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFrequencyBinCount" }
                }
            );
        }

        public decimal[] getByteFrequencyData()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getByteFrequencyData" }
                }
            );
        }

        public decimal[] getByteTimeDomainData()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getByteTimeDomainData" }
                }
            );
        }

        public decimal[] getFloatFrequencyData()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFloatFrequencyData" }
                }
            );
        }

        public void drawDebugCanvas()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "drawDebugCanvas" }
                }
            );
        }

        public void stopDebugCanvas()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stopDebugCanvas" }
                }
            );
        }

        public void connectAudioNodes(AudioNode inputAudioNode, AudioNode outputAudioNode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "connectAudioNodes" }, inputAudioNode, outputAudioNode
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
        #endregion
    }
}