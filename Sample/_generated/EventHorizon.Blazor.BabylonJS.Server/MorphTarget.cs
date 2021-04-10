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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MorphTarget>))]
    public class MorphTarget : CachedEntityObject, IAnimatable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<MorphTarget> Parse(object serializationObject)
        {
            return await EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "MorphTarget", "Parse" }, serializationObject
                }
            );
        }

        public static async ValueTask<MorphTarget> FromMesh(AbstractMesh mesh, string name = null, System.Nullable<decimal> influence = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "MorphTarget", "FromMesh" }, mesh, name, influence
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_influence()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "influence"
                );
        }
        public ValueTask set_influence(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "influence",
                    value
                );
        }

        private AnimationPropertiesOverride __animationPropertiesOverride;
        public async ValueTask<AnimationPropertiesOverride> get_animationPropertiesOverride()
        {
            if(__animationPropertiesOverride == null)
            {
                __animationPropertiesOverride = await EventHorizonBlazorInterop.GetClass<AnimationPropertiesOverride>(
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
        public ValueTask set_animationPropertiesOverride(AnimationPropertiesOverride value)
        {
__animationPropertiesOverride = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationPropertiesOverride",
                    value
                );
        }

        
        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
        }

        
        public async ValueTask<bool> get_hasPositions()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasPositions"
                );
        }

        
        public async ValueTask<bool> get_hasNormals()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasNormals"
                );
        }

        
        public async ValueTask<bool> get_hasTangents()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasTangents"
                );
        }

        
        public async ValueTask<bool> get_hasUVs()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasUVs"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        
        public async ValueTask<Animation[]> get_animations()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_animations(Animation[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
        }

// onInfluenceChanged is not supported by the platform yet

        
        public async ValueTask<string> get_id()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
        }
        public ValueTask set_id(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public MorphTarget() : base() { }

        public MorphTarget(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<MorphTarget> NewMorphTarget(
            string name, System.Nullable<decimal> influence = null, Scene scene = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MorphTarget" },
                name, influence, scene
            );

            return new MorphTarget(entity);
        }
        #endregion

        #region Methods
        public async ValueTask setPositions(decimal[] data)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setPositions" }, data
                }
            );
        }

        public async ValueTask<decimal[]> getPositions()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getPositions" }
                }
            );
        }

        public async ValueTask setNormals(decimal[] data)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setNormals" }, data
                }
            );
        }

        public async ValueTask<decimal[]> getNormals()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getNormals" }
                }
            );
        }

        public async ValueTask setTangents(decimal[] data)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTangents" }, data
                }
            );
        }

        public async ValueTask<decimal[]> getTangents()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTangents" }
                }
            );
        }

        public async ValueTask setUVs(decimal[] data)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setUVs" }, data
                }
            );
        }

        public async ValueTask<decimal[]> getUVs()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getUVs" }
                }
            );
        }

        public async ValueTask<MorphTarget> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}