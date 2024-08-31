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
        public Observable<IFileRequestCachedEntity> onCompleteObservable
        {
            get
            {
                if (__onCompleteObservable == null)
                {
                    __onCompleteObservable = EventHorizonBlazorInterop.GetClass<
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
            set
            {
                __onCompleteObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onCompleteObservable", value);
            }
        }
        #endregion

        #region Constructor
        public IFileRequestCachedEntity()
            : base() { }

        public IFileRequestCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public void abort()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "abort" } }
            );
        }
        #endregion
    }
}
