/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface Tensor<V, I> : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<TensorCachedEntity<CachedEntity, CachedEntity>>))]
    public class TensorCachedEntity<V, I> : CachedEntityObject, Tensor<V, I>
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
        private Dimension<T> __dimension;

        public async ValueTask<Dimension<T>> get_dimension()
        {
            if (__dimension == null)
            {
                __dimension = await EventHorizonBlazorInterop.GetClass<Dimension<T>>(
                    this.___guid,
                    "dimension",
                    (entity) =>
                    {
                        return new Dimension<T>() { ___guid = entity.___guid };
                    }
                );
            }
            return __dimension;
        }

        public async ValueTask<decimal> get_rank()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "rank");
        }
        #endregion

        #region Constructor
        public TensorCachedEntity()
            : base() { }

        public TensorCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask<decimal> getHashCode()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getHashCode" } }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> toArray(
            decimal[] array,
            System.Nullable<decimal> index = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> fromArray(
            decimal[] array,
            System.Nullable<decimal> index = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, index }
            );
        }

        public async ValueTask<TensorNumberArray<V>> asArray()
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorNumberArray<V>>(
                entity => new TensorNumberArray<V>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "asArray" } }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> copyFrom(I source)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, source }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> copyFromFloats(TensorNumberArray<V> floats)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, floats }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> set(TensorNumberArray<V> values)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, values }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> setAll(decimal value)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, value }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> add(I other)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, other }
            );
        }

        public async ValueTask<R> addToRef<R>(I other, R result)
            where R : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, other, result }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> addInPlace(I other)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, other }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> addInPlaceFromFloats(
            TensorNumberArray<V> floats
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, floats }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> subtract(I other)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, other }
            );
        }

        public async ValueTask<R> subtractToRef<R>(I other, R result)
            where R : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, other, result }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> subtractInPlace(I other)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, other }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> subtractFromFloats(
            TensorNumberArray<V> floats
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, floats }
            );
        }

        public async ValueTask<R> subtractFromFloatsToRef<R>(R args)
            where R : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloatsToRef" }, args }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> multiply(I other)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, other }
            );
        }

        public async ValueTask<R> multiplyToRef<R>(I other, R result)
            where R : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, other, result }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> multiplyInPlace(I other)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, other }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> multiplyByFloats(
            TensorNumberArray<V> floats
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, floats }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> divide(I other)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, other }
            );
        }

        public async ValueTask<R> divideToRef<R>(I other, R result)
            where R : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, other, result }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> divideInPlace(I other)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, other }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> minimizeInPlace(I other)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> minimizeInPlaceFromFloats(
            TensorNumberArray<V> floats
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlaceFromFloats" }, floats }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> maximizeInPlace(I other)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> maximizeInPlaceFromFloats(
            TensorNumberArray<V> floats
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlaceFromFloats" }, floats }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> negate()
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> negateInPlace()
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateInPlace" } }
            );
        }

        public async ValueTask<R> negateToRef<R>(R result)
            where R : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateToRef" }, result }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> scaleInPlace(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, scale }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> scale(decimal scale)
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scale" }, scale }
            );
        }

        public async ValueTask<R> scaleToRef<R>(decimal scale, R result)
            where R : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleToRef" }, scale, result }
            );
        }

        public async ValueTask<R> scaleAndAddToRef<R>(decimal scale, R result)
            where R : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleAndAddToRef" }, scale, result }
            );
        }

        public async ValueTask<bool> equals(I other)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, other }
            );
        }

        public async ValueTask<bool> equalsWithEpsilon(
            I other,
            System.Nullable<decimal> epsilon = null
        )
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsWithEpsilon" }, other, epsilon }
            );
        }

        public async ValueTask<bool> equalsToFloats(TensorNumberArray<V> floats)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, floats }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> floor()
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
            );
        }

        public async ValueTask<R> floorToRef<R>(R result)
            where R : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floorToRef" }, result }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> fract()
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
            );
        }

        public async ValueTask<R> fractToRef<R>(R result)
            where R : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fractToRef" }, result }
            );
        }

        public async ValueTask<TensorCachedEntity<V, I>> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }
        #endregion
    }
}
