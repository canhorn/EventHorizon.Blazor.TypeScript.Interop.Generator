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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ParticleSystemSet>))]
    public class ParticleSystemSet : CachedEntityObject, _IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<string> get_BaseAssetsUrl()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "ParticleSystemSet.BaseAssetsUrl"
                );
        }
        public static ValueTask set_BaseAssetsUrl(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ParticleSystemSet.BaseAssetsUrl",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<ParticleSystemSet> Parse(object data, Scene scene, System.Nullable<bool> gpu = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<ParticleSystemSet>(
                entity => new ParticleSystemSet() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "ParticleSystemSet", "Parse" }, data, scene, gpu
                }
            );
        }
        #endregion

        #region Accessors
        private TransformNode __emitterNode;
        public async ValueTask<TransformNode> get_emitterNode()
        {
            if(__emitterNode == null)
            {
                __emitterNode = await EventHorizonBlazorInterop.GetClass<TransformNode>(
                    this.___guid,
                    "emitterNode",
                    (entity) =>
                    {
                        return new TransformNode() { ___guid = entity.___guid };
                    }
                );
            }
            return __emitterNode;
        }
        #endregion

        #region Properties
        
        public async ValueTask<IParticleSystemCachedEntity[]> get_systems()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<IParticleSystemCachedEntity>(
                    this.___guid,
                    "systems",
                    (entity) =>
                    {
                        return new IParticleSystemCachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_systems(IParticleSystemCachedEntity[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "systems",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public ParticleSystemSet() : base() { }

        public ParticleSystemSet(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public async ValueTask setEmitterAsSphere(object options, decimal renderingGroupId, Scene scene)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setEmitterAsSphere" }, options, renderingGroupId, scene
                }
            );
        }

        public async ValueTask start(AbstractMesh emitter = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "start" }, emitter
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

        public async ValueTask<CachedEntity> serialize(System.Nullable<bool> serializeTexture = null)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, serializeTexture
                }
            );
        }
        #endregion
    }
}