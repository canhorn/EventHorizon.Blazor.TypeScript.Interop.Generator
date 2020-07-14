/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface ICameraInput { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class ICameraInputCachedEntity : CachedEntityObject, ICameraInput
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
        
        public CachedEntity camera
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "camera"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "camera",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ICameraInputCachedEntity() : base() { }

        public ICameraInputCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
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

        public string getSimpleName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getSimpleName" }
                }
            );
        }

        public void attachControl(object element, System.Nullable<bool> noPreventDefault = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachControl" }, element, noPreventDefault
                }
            );
        }

        public void detachControl(object element)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachControl" }, element
                }
            );
        }

        #region checkInputs TODO: Get Comments as metadata identification
        private bool _isCheckInputsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _checkInputsActionMap = new Dictionary<string, Func<Task>>();

        public string checkInputs(
            Func<Task> callback
        )
        {
            SetupCheckInputsLoop();

            var handle = Guid.NewGuid().ToString();
            _checkInputsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupCheckInputsLoop()
        {
            if (_isCheckInputsEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "checkInputs",
                "CallCheckInputsActions",
                _invokableReference
            );
            _isCheckInputsEnabled = true;
        }

        [JSInvokable]
        public async Task CallCheckInputsActions()
        {
            foreach (var action in _checkInputsActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}