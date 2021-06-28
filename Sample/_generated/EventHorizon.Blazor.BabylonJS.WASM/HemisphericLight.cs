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
        public Color3 groundColor
        {
            get
            {
            if(__groundColor == null)
            {
                __groundColor = EventHorizonBlazorInterop.GetClass<Color3>(
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
            set
            {
__groundColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundColor",
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
        
        #region Constructor
        public HemisphericLight() : base() { }

        public HemisphericLight(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public HemisphericLight(
            string name, Vector3 direction, Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "HemisphericLight" },
                name, direction, scene
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

        public Vector3 setDirectionToTarget(Vector3 target)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDirectionToTarget" }, target
                }
            );
        }

        public IShadowGeneratorCachedEntity getShadowGenerator()
        {
            return EventHorizonBlazorInterop.FuncClass<IShadowGeneratorCachedEntity>(
                entity => new IShadowGeneratorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getShadowGenerator" }
                }
            );
        }

        public HemisphericLight transferToEffect(Effect effect, string lightIndex)
        {
            return EventHorizonBlazorInterop.FuncClass<HemisphericLight>(
                entity => new HemisphericLight() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transferToEffect" }, effect, lightIndex
                }
            );
        }

        public HemisphericLight transferToNodeMaterialEffect(Effect effect, string lightDataUniformName)
        {
            return EventHorizonBlazorInterop.FuncClass<HemisphericLight>(
                entity => new HemisphericLight() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transferToNodeMaterialEffect" }, effect, lightDataUniformName
                }
            );
        }

        public Matrix computeWorldMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "computeWorldMatrix" }
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