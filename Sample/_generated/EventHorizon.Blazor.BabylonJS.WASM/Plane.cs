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
    public class Plane : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Plane FromArray(decimal[] array)
        {
            return EventHorizonBlazorInteropt.FuncClass<Plane>(
                entity => new Plane(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Plane", "FromArray" }, array
                }
            );
        }

        public static Plane FromPoints(Vector3 point1, Vector3 point2, Vector3 point3)
        {
            return EventHorizonBlazorInteropt.FuncClass<Plane>(
                entity => new Plane(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Plane", "FromPoints" }, point1, point2, point3
                }
            );
        }

        public static Plane FromPositionAndNormal(Vector3 origin, Vector3 normal)
        {
            return EventHorizonBlazorInteropt.FuncClass<Plane>(
                entity => new Plane(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Plane", "FromPositionAndNormal" }, origin, normal
                }
            );
        }

        public static decimal SignedDistanceToPlaneFromPositionAndNormal(Vector3 origin, Vector3 normal, Vector3 point)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Plane", "SignedDistanceToPlaneFromPositionAndNormal" }, origin, normal, point
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        private Vector3 __normal;
        public Vector3 normal
        {
            get
            {
            if(__normal == null)
            {
                __normal = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "normal",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __normal;
            }
            set
            {
__normal = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "normal",
                    value
                );
            }
        }

        
        public decimal d
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "d"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "d",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Plane() : base() { } 

        public Plane(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Plane(
            decimal a, decimal b, decimal c, decimal d
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Plane" },
                a, b, c, d
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal[] asArray()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "asArray" }
                }
            );
        }

        public Plane clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<Plane>(
                entity => new Plane(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
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

        public decimal getHashCode()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getHashCode" }
                }
            );
        }

        public Plane normalize()
        {
            return EventHorizonBlazorInteropt.FuncClass<Plane>(
                entity => new Plane(entity),
                new object[] 
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public Plane transform(Matrix transformation)
        {
            return EventHorizonBlazorInteropt.FuncClass<Plane>(
                entity => new Plane(entity),
                new object[] 
                {
                    new string[] { this.___guid, "transform" }, transformation
                }
            );
        }

        public decimal dotCoordinate(Vector3 point)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "dotCoordinate" }, point
                }
            );
        }

        public Plane copyFromPoints(Vector3 point1, Vector3 point2, Vector3 point3)
        {
            return EventHorizonBlazorInteropt.FuncClass<Plane>(
                entity => new Plane(entity),
                new object[] 
                {
                    new string[] { this.___guid, "copyFromPoints" }, point1, point2, point3
                }
            );
        }

        public bool isFrontFacingTo(Vector3 direction, decimal epsilon)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isFrontFacingTo" }, direction, epsilon
                }
            );
        }

        public decimal signedDistanceTo(Vector3 point)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "signedDistanceTo" }, point
                }
            );
        }
        #endregion
    }
}