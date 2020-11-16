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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ParticleSystemSet>))]
    public class ParticleSystemSet : CachedEntityObject, _IDisposable
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
                    "ParticleSystemSet.BaseAssetsUrl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "ParticleSystemSet.BaseAssetsUrl",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static ParticleSystemSet Parse(object data, Scene scene, System.Nullable<bool> gpu = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleSystemSet>(
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
        public TransformNode emitterNode
        {
            get
            {
            if(__emitterNode == null)
            {
                __emitterNode = EventHorizonBlazorInterop.GetClass<TransformNode>(
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
        }
        #endregion

        #region Properties
        
        public IParticleSystemCachedEntity[] systems
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IParticleSystemCachedEntity>(
                    this.___guid,
                    "systems",
                    (entity) =>
                    {
                        return new IParticleSystemCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "systems",
                    value
                );
            }
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
        public void setEmitterAsSphere(object options, decimal renderingGroupId, Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEmitterAsSphere" }, options, renderingGroupId, scene
                }
            );
        }

        public void start(AbstractMesh emitter = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "start" }, emitter
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

        public CachedEntity serialize(System.Nullable<bool> serializeTexture = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }, serializeTexture
                }
            );
        }
        #endregion
    }
}