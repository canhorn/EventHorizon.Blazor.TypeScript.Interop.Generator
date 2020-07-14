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
    public class SubEmitter : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static SubEmitter Parse(object serializationObject, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInteropt.FuncClass<SubEmitter>(
                entity => new SubEmitter(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "SubEmitter", "Parse" }, serializationObject, scene, rootUrl
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        private ParticleSystem __particleSystem;
        public ParticleSystem particleSystem
        {
            get
            {
            if(__particleSystem == null)
            {
                __particleSystem = EventHorizonBlazorInteropt.GetClass<ParticleSystem>(
                    this.___guid,
                    "particleSystem",
                    (entity) =>
                    {
                        return new ParticleSystem(entity);
                    }
                );
            }
            return __particleSystem;
            }
            set
            {
__particleSystem = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "particleSystem",
                    value
                );
            }
        }

        private SubEmitterType __type;
        public SubEmitterType type
        {
            get
            {
            if(__type == null)
            {
                __type = EventHorizonBlazorInteropt.GetClass<SubEmitterType>(
                    this.___guid,
                    "type",
                    (entity) =>
                    {
                        return new SubEmitterType(entity);
                    }
                );
            }
            return __type;
            }
            set
            {
__type = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public bool inheritDirection
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "inheritDirection"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "inheritDirection",
                    value
                );
            }
        }

        
        public decimal inheritedVelocityAmount
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "inheritedVelocityAmount"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "inheritedVelocityAmount",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SubEmitter() : base() { } 

        public SubEmitter(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public SubEmitter(
            ParticleSystem particleSystem
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "SubEmitter" },
                particleSystem
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public SubEmitter clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<SubEmitter>(
                entity => new SubEmitter(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
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

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}