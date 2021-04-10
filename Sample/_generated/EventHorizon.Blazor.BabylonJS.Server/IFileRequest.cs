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
            if(__onCompleteObservable == null)
            {
                __onCompleteObservable = await EventHorizonBlazorInterop.GetClass<Observable<IFileRequestCachedEntity>>(
                    this.___guid,
                    "onCompleteObservable",
                    (entity) =>
                    {
                        return new Observable<IFileRequestCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onCompleteObservable;
        }
        public ValueTask set_onCompleteObservable(Observable<IFileRequestCachedEntity> value)
        {
__onCompleteObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCompleteObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public IFileRequestCachedEntity() : base() { }

        public IFileRequestCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        #region abort TODO: Get Comments as metadata identification
        private bool _isAbortEnabled = false;
        private readonly IDictionary<string, Func<Task>> _abortActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> abort(
            Func<Task> callback
        )
        {
            await SetupAbortLoop();

            var handle = Guid.NewGuid().ToString();
            _abortActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupAbortLoop()
        {
            if (_isAbortEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
                this,
                "abort",
                "CallAbortActions",
                _invokableReference
            );
            _isAbortEnabled = true;
        }

        [JSInvokable]
        public async Task CallAbortActions()
        {
            foreach (var action in _abortActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}