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
        public Dimension<T> dimension
        {
            get
            {
                if (__dimension == null)
                {
                    __dimension = EventHorizonBlazorInterop.GetClass<Dimension<T>>(
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
        }

        public decimal rank
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "rank"); }
        }
        #endregion

        #region Constructor
        public TensorCachedEntity()
            : base() { }

        public TensorCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public decimal getHashCode()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getHashCode" } }
            );
        }

        public TensorCachedEntity<V, I> toArray(
            decimal[] array,
            System.Nullable<decimal> index = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "toArray" }, array, index }
            );
        }

        public TensorCachedEntity<V, I> fromArray(
            decimal[] array,
            System.Nullable<decimal> index = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fromArray" }, array, index }
            );
        }

        public TensorNumberArray<V> asArray()
        {
            return EventHorizonBlazorInterop.FuncClass<TensorNumberArray<V>>(
                entity => new TensorNumberArray<V>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "asArray" } }
            );
        }

        public TensorCachedEntity<V, I> copyFrom(I source)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFrom" }, source }
            );
        }

        public TensorCachedEntity<V, I> copyFromFloats(TensorNumberArray<V> floats)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "copyFromFloats" }, floats }
            );
        }

        public TensorCachedEntity<V, I> set(TensorNumberArray<V> values)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "set" }, values }
            );
        }

        public TensorCachedEntity<V, I> setAll(decimal value)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "setAll" }, value }
            );
        }

        public TensorCachedEntity<V, I> add(I other)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "add" }, other }
            );
        }

        public R addToRef<R>(I other, R result)
            where R : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addToRef" }, other, result }
            );
        }

        public TensorCachedEntity<V, I> addInPlace(I other)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlace" }, other }
            );
        }

        public TensorCachedEntity<V, I> addInPlaceFromFloats(TensorNumberArray<V> floats)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addInPlaceFromFloats" }, floats }
            );
        }

        public TensorCachedEntity<V, I> subtract(I other)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtract" }, other }
            );
        }

        public R subtractToRef<R>(I other, R result)
            where R : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractToRef" }, other, result }
            );
        }

        public TensorCachedEntity<V, I> subtractInPlace(I other)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractInPlace" }, other }
            );
        }

        public TensorCachedEntity<V, I> subtractFromFloats(TensorNumberArray<V> floats)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloats" }, floats }
            );
        }

        public R subtractFromFloatsToRef<R>(R args)
            where R : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "subtractFromFloatsToRef" }, args }
            );
        }

        public TensorCachedEntity<V, I> multiply(I other)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiply" }, other }
            );
        }

        public R multiplyToRef<R>(I other, R result)
            where R : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyToRef" }, other, result }
            );
        }

        public TensorCachedEntity<V, I> multiplyInPlace(I other)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyInPlace" }, other }
            );
        }

        public TensorCachedEntity<V, I> multiplyByFloats(TensorNumberArray<V> floats)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "multiplyByFloats" }, floats }
            );
        }

        public TensorCachedEntity<V, I> divide(I other)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divide" }, other }
            );
        }

        public R divideToRef<R>(I other, R result)
            where R : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideToRef" }, other, result }
            );
        }

        public TensorCachedEntity<V, I> divideInPlace(I other)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "divideInPlace" }, other }
            );
        }

        public TensorCachedEntity<V, I> minimizeInPlace(I other)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlace" }, other }
            );
        }

        public TensorCachedEntity<V, I> minimizeInPlaceFromFloats(TensorNumberArray<V> floats)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "minimizeInPlaceFromFloats" }, floats }
            );
        }

        public TensorCachedEntity<V, I> maximizeInPlace(I other)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlace" }, other }
            );
        }

        public TensorCachedEntity<V, I> maximizeInPlaceFromFloats(TensorNumberArray<V> floats)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "maximizeInPlaceFromFloats" }, floats }
            );
        }

        public TensorCachedEntity<V, I> negate()
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negate" } }
            );
        }

        public TensorCachedEntity<V, I> negateInPlace()
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateInPlace" } }
            );
        }

        public R negateToRef<R>(R result)
            where R : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "negateToRef" }, result }
            );
        }

        public TensorCachedEntity<V, I> scaleInPlace(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleInPlace" }, scale }
            );
        }

        public TensorCachedEntity<V, I> scale(decimal scale)
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scale" }, scale }
            );
        }

        public R scaleToRef<R>(decimal scale, R result)
            where R : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleToRef" }, scale, result }
            );
        }

        public R scaleAndAddToRef<R>(decimal scale, R result)
            where R : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "scaleAndAddToRef" }, scale, result }
            );
        }

        public bool equals(I other)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equals" }, other }
            );
        }

        public bool equalsWithEpsilon(I other, System.Nullable<decimal> epsilon = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsWithEpsilon" }, other, epsilon }
            );
        }

        public bool equalsToFloats(TensorNumberArray<V> floats)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "equalsToFloats" }, floats }
            );
        }

        public TensorCachedEntity<V, I> floor()
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floor" } }
            );
        }

        public R floorToRef<R>(R result)
            where R : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "floorToRef" }, result }
            );
        }

        public TensorCachedEntity<V, I> fract()
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fract" } }
            );
        }

        public R fractToRef<R>(R result)
            where R : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<R>(
                entity => new R() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "fractToRef" }, result }
            );
        }

        public TensorCachedEntity<V, I> clone()
        {
            return EventHorizonBlazorInterop.FuncClass<TensorCachedEntity<V, I>>(
                entity => new TensorCachedEntity<V, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }
        #endregion
    }
}
