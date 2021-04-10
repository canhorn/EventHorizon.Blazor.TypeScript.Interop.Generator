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
        
        public async ValueTask<decimal> get_SMOOTHING()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "SMOOTHING"
                );
        }
        public ValueTask set_SMOOTHING(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "SMOOTHING",
                    value
                );
        }

        
        public async ValueTask<decimal> get_FFT_SIZE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "FFT_SIZE"
                );
        }
        public ValueTask set_FFT_SIZE(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "FFT_SIZE",
                    value
                );
        }

        
        public async ValueTask<decimal> get_BARGRAPHAMPLITUDE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "BARGRAPHAMPLITUDE"
                );
        }
        public ValueTask set_BARGRAPHAMPLITUDE(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "BARGRAPHAMPLITUDE",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_DEBUGCANVASPOS()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "DEBUGCANVASPOS",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_DEBUGCANVASPOS(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DEBUGCANVASPOS",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_DEBUGCANVASSIZE()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "DEBUGCANVASSIZE",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_DEBUGCANVASSIZE(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "DEBUGCANVASSIZE",
                    value
                );
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

        public static async ValueTask<Analyser> NewAnalyser(
            Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Analyser" },
                scene
            );

            return new Analyser(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<decimal> getFrequencyBinCount()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getFrequencyBinCount" }
                }
            );
        }

        public async ValueTask<decimal[]> getByteFrequencyData()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getByteFrequencyData" }
                }
            );
        }

        public async ValueTask<decimal[]> getByteTimeDomainData()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getByteTimeDomainData" }
                }
            );
        }

        public async ValueTask<decimal[]> getFloatFrequencyData()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFloatFrequencyData" }
                }
            );
        }

        public async ValueTask drawDebugCanvas()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawDebugCanvas" }
                }
            );
        }

        public async ValueTask stopDebugCanvas()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stopDebugCanvas" }
                }
            );
        }

        public async ValueTask connectAudioNodes(AudioNode inputAudioNode, AudioNode outputAudioNode)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "connectAudioNodes" }, inputAudioNode, outputAudioNode
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
        #endregion
    }
}