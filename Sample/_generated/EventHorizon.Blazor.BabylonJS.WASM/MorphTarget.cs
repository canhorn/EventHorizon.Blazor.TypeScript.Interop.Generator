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
    public class MorphTarget : CachedEntityObject, IAnimatable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static MorphTarget Parse(object serializationObject)
        {
            return EventHorizonBlazorInteropt.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "MorphTarget", "Parse" }, serializationObject
                }
            );
        }

        public static MorphTarget FromMesh(AbstractMesh mesh, string name = null, System.Nullable<decimal> influence = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "MorphTarget", "FromMesh" }, mesh, name, influence
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal influence
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "influence"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "influence",
                    value
                );
            }
        }

        private AnimationPropertiesOverride __animationPropertiesOverride;
        public AnimationPropertiesOverride animationPropertiesOverride
        {
            get
            {
            if(__animationPropertiesOverride == null)
            {
                __animationPropertiesOverride = EventHorizonBlazorInteropt.GetClass<AnimationPropertiesOverride>(
                    this.___guid,
                    "animationPropertiesOverride",
                    (entity) =>
                    {
                        return new AnimationPropertiesOverride() { ___guid = entity.___guid };
                    }
                );
            }
            return __animationPropertiesOverride;
            }
            set
            {
__animationPropertiesOverride = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "animationPropertiesOverride",
                    value
                );
            }
        }

        
        public decimal uniqueId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
        }

        
        public bool hasPositions
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "hasPositions"
                );
            }
        }

        
        public bool hasNormals
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "hasNormals"
                );
            }
        }

        
        public bool hasTangents
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "hasTangents"
                );
            }
        }

        
        public bool hasUVs
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "hasUVs"
                );
            }
        }
        #endregion

        #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public Animation[] animations
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "animations",
                    value
                );
            }
        }

// onInfluenceChanged is not supported by the platform yet

        
        public string id
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public MorphTarget() : base() { }

        public MorphTarget(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public MorphTarget(
            string name, System.Nullable<decimal> influence = null, Scene scene = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "MorphTarget" },
                name, influence, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setPositions(decimal[] data)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setPositions" }, data
                }
            );
        }

        public decimal[] getPositions()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getPositions" }
                }
            );
        }

        public void setNormals(decimal[] data)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setNormals" }, data
                }
            );
        }

        public decimal[] getNormals()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getNormals" }
                }
            );
        }

        public void setTangents(decimal[] data)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTangents" }, data
                }
            );
        }

        public decimal[] getTangents()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTangents" }
                }
            );
        }

        public void setUVs(decimal[] data)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setUVs" }, data
                }
            );
        }

        public decimal[] getUVs()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getUVs" }
                }
            );
        }

        public MorphTarget clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
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

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}