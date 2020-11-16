/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
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
        
        public decimal shadowAngle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowAngle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowAngle",
                    value
                );
            }
        }

        private Vector3 __direction;
        public Vector3 direction
        {
            get
            {
            if(__direction == null)
            {
                __direction = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__direction = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction",
                    value
                );
            }
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

        public PointLight(
            string name, Vector3 position, Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PointLight" },
                name, position, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public decimal getTypeID()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTypeID" }
                }
            );
        }

        public bool needCube()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "needCube" }
                }
            );
        }

        public Vector3 getShadowDirection(System.Nullable<decimal> faceIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getShadowDirection" }, faceIndex
                }
            );
        }

        public PointLight transferToEffect(Effect effect, string lightIndex)
        {
            return EventHorizonBlazorInterop.FuncClass<PointLight>(
                entity => new PointLight() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transferToEffect" }, effect, lightIndex
                }
            );
        }

        public PointLight transferToNodeMaterialEffect(Effect effect, string lightDataUniformName)
        {
            return EventHorizonBlazorInterop.FuncClass<PointLight>(
                entity => new PointLight() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transferToNodeMaterialEffect" }, effect, lightDataUniformName
                }
            );
        }

        public void prepareLightSpecificDefines(object defines, decimal lightIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareLightSpecificDefines" }, defines, lightIndex
                }
            );
        }
        #endregion
    }
}