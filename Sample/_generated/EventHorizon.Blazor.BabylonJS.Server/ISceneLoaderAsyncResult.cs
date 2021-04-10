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

    public interface ISceneLoaderAsyncResult : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ISceneLoaderAsyncResultCachedEntity>))]
    public class ISceneLoaderAsyncResultCachedEntity : CachedEntityObject, ISceneLoaderAsyncResult
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
        
        public async ValueTask<AbstractMesh[]> get_meshes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "meshes",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<IParticleSystemCachedEntity[]> get_particleSystems()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<IParticleSystemCachedEntity>(
                    this.___guid,
                    "particleSystems",
                    (entity) =>
                    {
                        return new IParticleSystemCachedEntity() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<Skeleton[]> get_skeletons()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Skeleton>(
                    this.___guid,
                    "skeletons",
                    (entity) =>
                    {
                        return new Skeleton() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<AnimationGroup[]> get_animationGroups()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AnimationGroup>(
                    this.___guid,
                    "animationGroups",
                    (entity) =>
                    {
                        return new AnimationGroup() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<TransformNode[]> get_transformNodes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<TransformNode>(
                    this.___guid,
                    "transformNodes",
                    (entity) =>
                    {
                        return new TransformNode() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<Geometry[]> get_geometries()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Geometry>(
                    this.___guid,
                    "geometries",
                    (entity) =>
                    {
                        return new Geometry() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<Light[]> get_lights()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Light>(
                    this.___guid,
                    "lights",
                    (entity) =>
                    {
                        return new Light() { ___guid = entity.___guid };
                    }
                );
        }
        #endregion
        
        #region Constructor
        public ISceneLoaderAsyncResultCachedEntity() : base() { }

        public ISceneLoaderAsyncResultCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}