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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ParticleHelper>))]
    public class ParticleHelper : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<string> get_BaseAssetsUrl()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ParticleHelper.BaseAssetsUrl"
                );
        }
        public static ValueTask set_BaseAssetsUrl(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ParticleHelper.BaseAssetsUrl",
                    value
                );
        }

        
        public static async ValueTask<string> get_SnippetUrl()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ParticleHelper.SnippetUrl"
                );
        }
        public static ValueTask set_SnippetUrl(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ParticleHelper.SnippetUrl",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<IParticleSystemCachedEntity> CreateDefault(AbstractMesh emitter, System.Nullable<decimal> capacity = null, Scene scene = null, System.Nullable<bool> useGPU = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "ParticleHelper", "CreateDefault" }, emitter, capacity, scene, useGPU
                }
            );
        }

        public static async ValueTask<ParticleSystemSet> CreateAsync(string type, Scene scene, System.Nullable<bool> gpu = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<ParticleSystemSet>(
                entity => new ParticleSystemSet() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ParticleHelper", "CreateAsync" }, type, scene, gpu
                }
            );
        }

        public static async ValueTask<ParticleSystemSet> ExportSet(IParticleSystem[] systems)
        {
            return await EventHorizonBlazorInterop.FuncClass<ParticleSystemSet>(
                entity => new ParticleSystemSet() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "ParticleHelper", "ExportSet" }, systems
                }
            );
        }

        public static async ValueTask<IParticleSystemCachedEntity> ParseFromFileAsync(string url, Scene scene, string name = null, System.Nullable<bool> gpu = null, string rootUrl = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "ParticleHelper", "ParseFromFileAsync" }, name, url, scene, gpu, rootUrl
                }
            );
        }

        public static async ValueTask<IParticleSystemCachedEntity> CreateFromSnippetAsync(string snippetId, Scene scene, System.Nullable<bool> gpu = null, string rootUrl = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<IParticleSystemCachedEntity>(
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