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

    
    
    [JsonConverter(typeof(CachedEntityConverter<HemisphericLight>))]
    public class HemisphericLight : Light
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
        private Color3 __groundColor;
        public async ValueTask<Color3> get_groundColor()
        {
            if(__groundColor == null)
            {
                __groundColor = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "groundColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __groundColor;
        }
        public ValueTask set_groundColor(Color3 value)
        {
__groundColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundColor",
                    value
                );
        }

        private Vector3 __direction;
        public async ValueTask<Vector3> get_direction()
        {
            if(__direction == null)
            {
                __direction = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "direction",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __direction;
        }
        public ValueTask set_direction(Vector3 value)
        {
__direction = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public HemisphericLight() : base() { }

        public HemisphericLight(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<HemisphericLight> NewHemisphericLight(
            string name, Vector3 direction, Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "HemisphericLight" },
                name, direction, scene
            );

            return new HemisphericLight(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<Vector3> setDirectionToTarget(Vector3 target)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setDirectionToTarget" }, target
                }
            );
        }

        public async ValueTask<IShadowGeneratorCachedEntity> getShadowGenerator()
        {
            return await EventHorizonBlazorInterop.FuncClass<IShadowGeneratorCachedEntity>(
                entity => new IShadowGeneratorCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getShadowGenerator" }
                }
            );
        }

        public async ValueTask<HemisphericLight> transferToEffect(Effect effect, string lightIndex)
        {
            return await EventHorizonBlazorInterop.FuncClass<HemisphericLight>(
                entity => new HemisphericLight() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "transferToEffect" }, effect, lightIndex
                }
            );
        }

        public async ValueTask<HemisphericLight> transferToNodeMaterialEffect(Effect effect, string lightDataUniformName)
        {
            return await EventHorizonBlazorInterop.FuncClass<HemisphericLight>(
                entity => new HemisphericLight() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "transferToNodeMaterialEffect" }, effect, lightDataUniformName
                }
            );
        }

        public async ValueTask<Matrix> computeWorldMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "computeWorldMatrix" }
                }
            );
        }

        public async ValueTask<decimal> getTypeID()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTypeID" }
                }
            );
        }

        public async ValueTask prepareLightSpecificDefines(object defines, decimal lightIndex)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareLightSpecificDefines" }, defines, lightIndex
                }
            );
        }
        #endregion
    }
}