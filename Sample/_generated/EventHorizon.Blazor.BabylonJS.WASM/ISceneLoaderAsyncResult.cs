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
        
        public AbstractMesh[] meshes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "meshes",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public IParticleSystemCachedEntity[] particleSystems
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IParticleSystemCachedEntity>(
                    this.___guid,
                    "particleSystems",
                    (entity) =>
                    {
                        return new IParticleSystemCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public Skeleton[] skeletons
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Skeleton>(
                    this.___guid,
                    "skeletons",
                    (entity) =>
                    {
                        return new Skeleton() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public AnimationGroup[] animationGroups
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AnimationGroup>(
                    this.___guid,
                    "animationGroups",
                    (entity) =>
                    {
                        return new AnimationGroup() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public TransformNode[] transformNodes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<TransformNode>(
                    this.___guid,
                    "transformNodes",
                    (entity) =>
                    {
                        return new TransformNode() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public Geometry[] geometries
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Geometry>(
                    this.___guid,
                    "geometries",
                    (entity) =>
                    {
                        return new Geometry() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public Light[] lights
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Light>(
                    this.___guid,
                    "lights",
                    (entity) =>
                    {
                        return new Light() { ___guid = entity.___guid };
                    }
                );
            }
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