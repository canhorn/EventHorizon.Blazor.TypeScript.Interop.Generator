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

        public async ValueTask<CachedEntity> get_rank()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "rank",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }
        #endregion

        #region Constructor
        public VectorCachedEntity()
            : base() { }

        public VectorCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask<decimal> length()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "length" } }
            );
        }

        public async ValueTask<decimal> lengthSquared()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "lengthSquared" } }
            );
        }

        public async ValueTask<VectorCachedEntity<N, I>> normalize()
        {
            return await EventHorizonBlazorInterop.FuncClass<VectorCachedEntity<N, I>>(
                entity => new VectorCachedEntity<N, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalize" } }
            );
        }

        public async ValueTask<VectorCachedEntity<N, I>> normalizeFromLength(decimal len)
        {
            return await EventHorizonBlazorInterop.FuncClass<VectorCachedEntity<N, I>>(
                entity => new VectorCachedEntity<N, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeFromLength" }, len }
            );
        }

        public async ValueTask<VectorCachedEntity<N, I>> normalizeToNew()
        {
            return await EventHorizonBlazorInterop.FuncClass<VectorCachedEntity<N, I>>(
                entity => new VectorCachedEntity<N, I>() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeToNew" } }
            );
        }

        public async ValueTask<T> normalizeToRef<T>(T reference)
            where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "normalizeToRef" }, reference }
            );
        }
        #endregion
    }
}
