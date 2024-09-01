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

    public interface IFileRequest : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IFileRequestCachedEntity>))]
    public class IFileRequestCachedEntity : CachedEntityObject, IFileRequest
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
        private Observable<IFileRequestCachedEntity> __onCompleteObservable;

        public async ValueTask<Observable<IFileRequestCachedEntity>> get_onCompleteObservable()
        {
            if (__onCompleteObservable == null)
            {
                __onCompleteObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<IFileRequestCachedEntity>
                >(
                    this.___guid,
                    "onCompleteObservable",
                    (entity) =>
                    {
                        return new Observable<IFileRequestCachedEntity>()
                        {
                            ___guid = entity.___guid
                        };
                    }
                );
            }
            return __onCompleteObservable;
        }

        public ValueTask set_onCompleteObservable(Observable<IFileRequestCachedEntity> value)
        {
            __onCompleteObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onCompleteObservable", value);
        }
        #endregion

        #region Constructor
        public IFileRequestCachedEntity()
            : base() { }

        public IFileRequestCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask abort()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "abort" } }
            );
        }
        #endregion
    }
}
