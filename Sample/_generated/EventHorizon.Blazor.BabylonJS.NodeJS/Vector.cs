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

    public interface Vector<N, I> : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<VectorCachedEntity<CachedEntity, CachedEntity>>))]
    public class VectorCachedEntity<N, I> : CachedEntityObject, Vector<N, I>
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

        public CachedEntity rank
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "rank",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }
        #endregion

        #region Constructor
        public VectorCachedEntity()
            : base() { }

        public VectorCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public decimal length()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "length" } }
            );
        }

        public decimal lengthSquared()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "lengthSquared" } }
            );
        }

        public VectorCachedEntity<N, I> normalize()
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity<N, I>>(
                entity => new VectorCachedEntity<N, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalize" } }
            );
        }

        public VectorCachedEntity<N, I> normalizeFromLength(decimal len)
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity<N, I>>(
                entity => new VectorCachedEntity<N, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeFromLength" }, len }
            );
        }

        public VectorCachedEntity<N, I> normalizeToNew()
        {
            return EventHorizonBlazorInterop.FuncClass<VectorCachedEntity<N, I>>(
                entity => new VectorCachedEntity<N, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeToNew" } }
            );
        }

        public T normalizeToRef<T>(T reference)
            where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeToRef" }, reference }
            );
        }
        #endregion
    }
}
