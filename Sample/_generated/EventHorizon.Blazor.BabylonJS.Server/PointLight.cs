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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PointLight>))]
    public class PointLight : ShadowLight
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_shadowAngle()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowAngle"
                );
        }
        public ValueTask set_shadowAngle(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowAngle",
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

        #region Properties

        #endregion
        
        #region Constructor
        public PointLight() : base() { }

        public PointLight(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<PointLight> NewPointLight(
            string name, Vector3 position, Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PointLight" },
                name, position, scene
            );

            return new PointLight(entity);
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

        public async ValueTask<decimal> getTypeID()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTypeID" }
                }
            );
        }

        public async ValueTask<bool> needCube()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needCube" }
                }
            );
        }

        public async ValueTask<Vector3> getShadowDirection(System.Nullable<decimal> faceIndex = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getShadowDirection" }, faceIndex
                }
            );
        }

        public async ValueTask<PointLight> transferToEffect(Effect effect, string lightIndex)
        {
            return await EventHorizonBlazorInterop.FuncClass<PointLight>(
                entity => new PointLight() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "transferToEffect" }, effect, lightIndex
                }
            );
        }

        public async ValueTask<PointLight> transferToNodeMaterialEffect(Effect effect, string lightDataUniformName)
        {
            return await EventHorizonBlazorInterop.FuncClass<PointLight>(
                entity => new PointLight() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "transferToNodeMaterialEffect" }, effect, lightDataUniformName
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