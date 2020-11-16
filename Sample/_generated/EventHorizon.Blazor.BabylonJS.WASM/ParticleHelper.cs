/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<ParticleHelper>))]
    public class ParticleHelper : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static string BaseAssetsUrl
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ParticleHelper.BaseAssetsUrl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ParticleHelper.BaseAssetsUrl",
                    value
                );
            }
        }

        
        public static string SnippetUrl
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ParticleHelper.SnippetUrl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ParticleHelper.SnippetUrl",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static IParticleSystemCachedEntity CreateDefault(AbstractMesh emitter, System.Nullable<decimal> capacity = null, Scene scene = null, System.Nullable<bool> useGPU = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ParticleHelper", "CreateDefault" }, emitter, capacity, scene, useGPU
                }
            );
        }

        public static ValueTask<ParticleSystemSet> CreateAsync(string type, Scene scene, System.Nullable<bool> gpu = null)
        {
            return EventHorizonBlazorInterop.TaskClass<ParticleSystemSet>(
                entity => new ParticleSystemSet() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ParticleHelper", "CreateAsync" }, type, scene, gpu
                }
            );
        }

        public static ParticleSystemSet ExportSet(IParticleSystem[] systems)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleSystemSet>(
                entity => new ParticleSystemSet() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ParticleHelper", "ExportSet" }, systems
                }
            );
        }

        public static ValueTask<IParticleSystemCachedEntity> ParseFromFileAsync(string url, Scene scene, string name = null, System.Nullable<bool> gpu = null, string rootUrl = null)
        {
            return EventHorizonBlazorInterop.TaskClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ParticleHelper", "ParseFromFileAsync" }, name, url, scene, gpu, rootUrl
                }
            );
        }

        public static ValueTask<IParticleSystemCachedEntity> CreateFromSnippetAsync(string snippetId, Scene scene, System.Nullable<bool> gpu = null, string rootUrl = null)
        {
            return EventHorizonBlazorInterop.TaskClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ParticleHelper", "CreateFromSnippetAsync" }, snippetId, scene, gpu, rootUrl
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public ParticleHelper() : base() { }

        public ParticleHelper(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}