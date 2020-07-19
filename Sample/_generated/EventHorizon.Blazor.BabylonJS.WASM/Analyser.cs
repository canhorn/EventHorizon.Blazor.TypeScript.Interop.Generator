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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "SMOOTHING"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "FFT_SIZE"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "BARGRAPHAMPLITUDE"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "DEBUGCANVASPOS"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "DEBUGCANVASSIZE"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Analyser" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal getFrequencyBinCount()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getFrequencyBinCount" }
                }
            );
        }

        public decimal[] getByteFrequencyData()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getByteFrequencyData" }
                }
            );
        }

        public decimal[] getByteTimeDomainData()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getByteTimeDomainData" }
                }
            );
        }

        public decimal[] getFloatFrequencyData()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFloatFrequencyData" }
                }
            );
        }

        public void drawDebugCanvas()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawDebugCanvas" }
                }
            );
        }

        public void stopDebugCanvas()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stopDebugCanvas" }
                }
            );
        }

        public void connectAudioNodes(AudioNode inputAudioNode, AudioNode outputAudioNode)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "connectAudioNodes" }, inputAudioNode, outputAudioNode
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
        #endregion
    }
}