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
    public class CylinderDirectedParticleEmitter : CylinderParticleEmitter
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
        private Vector3 __direction1;
        public Vector3 direction1
        {
            get
            {
            if(__direction1 == null)
            {
                __direction1 = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "direction1",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __direction1;
            }
            set
            {
__direction1 = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "direction1",
                    value
                );
            }
        }

        private Vector3 __direction2;
        public Vector3 direction2
        {
            get
            {
            if(__direction2 == null)
            {
                __direction2 = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "direction2",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __direction2;
            }
            set
            {
__direction2 = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "direction2",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public CylinderDirectedParticleEmitter() : base() { }

        public CylinderDirectedParticleEmitter(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public CylinderDirectedParticleEmitter(
            System.Nullable<decimal> radius = null, System.Nullable<decimal> height = null, System.Nullable<decimal> radiusRange = null, Vector3 direction1 = null, Vector3 direction2 = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "CylinderDirectedParticleEmitter" },
                radius, height, radiusRange, direction1, direction2
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void startDirectionFunction(Matrix worldMatrix, Vector3 directionToUpdate, Particle particle)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "startDirectionFunction" }, worldMatrix, directionToUpdate, particle
                }
            );
        }

        public CylinderDirectedParticleEmitter clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<CylinderDirectedParticleEmitter>(
                entity => new CylinderDirectedParticleEmitter(entity),
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

        public void parse(CachedEntity serializationObject)
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