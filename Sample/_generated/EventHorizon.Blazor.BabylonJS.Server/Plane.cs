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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Plane>))]
    public class Plane : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Plane> FromArray(decimal[] array)
        {
            return await EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Plane", "FromArray" }, array
                }
            );
        }

        public static async ValueTask<Plane> FromPoints(Vector3 point1, Vector3 point2, Vector3 point3)
        {
            return await EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Plane", "FromPoints" }, point1, point2, point3
                }
            );
        }

        public static async ValueTask<Plane> FromPositionAndNormal(Vector3 origin, Vector3 normal)
        {
            return await EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Plane", "FromPositionAndNormal" }, origin, normal
                }
            );
        }

        public static async ValueTask<decimal> SignedDistanceToPlaneFromPositionAndNormal(Vector3 origin, Vector3 normal, Vector3 point)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
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
        public async ValueTask<Vector3> get_normal()
        {
            if(__normal == null)
            {
                __normal = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "normal",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __normal;
        }
        public ValueTask set_normal(Vector3 value)
        {
__normal = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "normal",
                    value
                );
        }

        
        public async ValueTask<decimal> get_d()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "d"
                );
        }
        public ValueTask set_d(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "d",
                    value
                );
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

        public static async ValueTask<Plane> NewPlane(
            decimal a, decimal b, decimal c, decimal d
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Plane" },
                a, b, c, d
            );

            return new Plane(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<decimal[]> asArray()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "asArray" }
                }
            );
        }

        public async ValueTask<Plane> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
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

        public async ValueTask<decimal> getHashCode()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getHashCode" }
                }
            );
        }

        public async ValueTask<Plane> normalize()
        {
            return await EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "normalize" }
                }
            );
        }

        public async ValueTask<Plane> transform(Matrix transformation)
        {
            return await EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "transform" }, transformation
                }
            );
        }

        public async ValueTask<decimal> dotCoordinate(Vector3 point)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "dotCoordinate" }, point
                }
            );
        }

        public async ValueTask<Plane> copyFromPoints(Vector3 point1, Vector3 point2, Vector3 point3)
        {
            return await EventHorizonBlazorInterop.FuncClass<Plane>(
                entity => new Plane() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFromPoints" }, point1, point2, point3
                }
            );
        }

        public async ValueTask<bool> isFrontFacingTo(Vector3 direction, decimal epsilon)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isFrontFacingTo" }, direction, epsilon
                }
            );
        }

        public async ValueTask<decimal> signedDistanceTo(Vector3 point)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "signedDistanceTo" }, point
                }
            );
        }
        #endregion
    }
}