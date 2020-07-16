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
                __groundColor = EventHorizonBlazorInteropt.GetClass<Color3>(
                    this.___guid,
                    "groundColor",
                    (entity) =>
                    {
                        return new Color3(entity);
                    }
                );
            }
            return __groundColor;
            }
            set
            {
__groundColor = null;
                EventHorizonBlazorInteropt.Set(
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
                __direction = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "direction",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __direction;
            }
            set
            {
__direction = null;
                EventHorizonBlazorInteropt.Set(
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
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "HemisphericLight" },
                name, direction, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public Vector3 setDirectionToTarget(Vector3 target)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setDirectionToTarget" }, target
                }
            );
        }

        public IShadowGenerator getShadowGenerator()
        {
            return EventHorizonBlazorInteropt.FuncClass<IShadowGenerator>(
                entity => new IShadowGeneratorCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getShadowGenerator" }
                }
            );
        }

        public HemisphericLight transferToEffect(Effect effect, string lightIndex)
        {
            return EventHorizonBlazorInteropt.FuncClass<HemisphericLight>(
                entity => new HemisphericLight(entity),
                new object[] 
                {
                    new string[] { this.___guid, "transferToEffect" }, effect, lightIndex
                }
            );
        }

        public HemisphericLight transferToNodeMaterialEffect(Effect effect, string lightDataUniformName)
        {
            return EventHorizonBlazorInteropt.FuncClass<HemisphericLight>(
                entity => new HemisphericLight(entity),
                new object[] 
                {
                    new string[] { this.___guid, "transferToNodeMaterialEffect" }, effect, lightDataUniformName
                }
            );
        }

        public Matrix computeWorldMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "computeWorldMatrix" }
                }
            );
        }

        public decimal getTypeID()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTypeID" }
                }
            );
        }

        public void prepareLightSpecificDefines(object defines, decimal lightIndex)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareLightSpecificDefines" }, defines, lightIndex
                }
            );
        }
        #endregion
    }
}