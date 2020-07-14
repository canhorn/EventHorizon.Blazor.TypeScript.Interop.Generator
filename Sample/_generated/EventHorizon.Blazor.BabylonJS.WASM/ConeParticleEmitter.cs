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
    public class ConeParticleEmitter : CachedEntityObject, IParticleEmitterType
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "radius",
                    value
                );
            }
        }

        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal directionRandomizer
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "directionRandomizer"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "directionRandomizer",
                    value
                );
            }
        }

        
        public decimal radiusRange
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "radiusRange"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "radiusRange",
                    value
                );
            }
        }

        
        public decimal heightRange
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "heightRange"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "heightRange",
                    value
                );
            }
        }

        
        public bool emitFromSpawnPointOnly
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "emitFromSpawnPointOnly"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "emitFromSpawnPointOnly",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ConeParticleEmitter() : base() { }

        public ConeParticleEmitter(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ConeParticleEmitter(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> angle = null, System.Nullable<decimal> directionRandomizer = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "ConeParticleEmitter" },
                radius, angle, directionRandomizer
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void startDirectionFunction(Matrix worldMatrix, Vector3 directionToUpdate, Particle particle, bool isLocal)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "startDirectionFunction" }, worldMatrix, directionToUpdate, particle, isLocal
                }
            );
        }

        public void startPositionFunction(Matrix worldMatrix, Vector3 positionToUpdate, Particle particle, bool isLocal)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "startPositionFunction" }, worldMatrix, positionToUpdate, particle, isLocal
                }
            );
        }

        public ConeParticleEmitter clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<ConeParticleEmitter>(
                entity => new ConeParticleEmitter(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public void applyToShader(Effect effect)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "applyToShader" }, effect
                }
            );
        }

        public string getEffectDefines()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getEffectDefines" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public void parse(object serializationObject)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "parse" }, serializationObject
                }
            );
        }
        #endregion
    }
}