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

    public interface IParticleEmitterType : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IParticleEmitterTypeCachedEntity>))]
    public class IParticleEmitterTypeCachedEntity : CachedEntityObject, IParticleEmitterType
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

        #endregion
        
        #region Constructor
        public IParticleEmitterTypeCachedEntity() : base() { }

        public IParticleEmitterTypeCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void startDirectionFunction(Matrix worldMatrix, Vector3 directionToUpdate, Particle particle, bool isLocal)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "startDirectionFunction" }, worldMatrix, directionToUpdate, particle, isLocal
                }
            );
        }

        public void startPositionFunction(Matrix worldMatrix, Vector3 positionToUpdate, Particle particle, bool isLocal)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "startPositionFunction" }, worldMatrix, positionToUpdate, particle, isLocal
                }
            );
        }

        public IParticleEmitterTypeCachedEntity clone()
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleEmitterTypeCachedEntity>(
                entity => new IParticleEmitterTypeCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public void applyToShader(Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "applyToShader" }, effect
                }
            );
        }

        public string getEffectDefines()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getEffectDefines" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public void parse(object serializationObject, Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "parse" }, serializationObject, scene
                }
            );
        }
        #endregion
    }
}