/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<SmartArray<CachedEntity>>))]
    public class SmartArray<T> : CachedEntityObject, ISmartArrayLike<T> where T : CachedEntity, new()
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
        
        public T[] data
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<T>(
                    this.___guid,
                    "data",
                    (entity) =>
                    {
                        return new T() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "data",
                    value
                );
            }
        }

        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "length",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SmartArray() : base() { }

        public SmartArray(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SmartArray(
            decimal capacity
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "SmartArray" },
                capacity
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void push(T value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "push" }, value
                }
            );
        }

        #region forEach TODO: Get Comments as metadata identification
        private bool _isForEachEnabled = false;
        private readonly IDictionary<string, Func<T, Task>> _forEachActionMap = new Dictionary<string, Func<T, Task>>();

        public string forEach(
            Func<T, Task> callback
        )
        {
            SetupForEachLoop();

            var handle = Guid.NewGuid().ToString();
            _forEachActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupForEachLoop()
        {
            if (_isForEachEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "forEach",
                "CallForEachActions",
                _invokableReference
            );
            _isForEachEnabled = true;
        }

        [JSInvokable]
        public async Task CallForEachActions(T content)
        {
            foreach (var action in _forEachActionMap.Values)
            {
                await action(content);
            }
        }
        #endregion

        #region sort TODO: Get Comments as metadata identification
        private bool _isSortEnabled = false;
        private readonly IDictionary<string, Func<T, T, Task>> _sortActionMap = new Dictionary<string, Func<T, T, Task>>();

        public string sort(
            Func<T, T, Task> callback
        )
        {
            SetupSortLoop();

            var handle = Guid.NewGuid().ToString();
            _sortActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupSortLoop()
        {
            if (_isSortEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "sort",
                "CallSortActions",
                _invokableReference
            );
            _isSortEnabled = true;
        }

        [JSInvokable]
        public async Task CallSortActions(T a, T b)
        {
            foreach (var action in _sortActionMap.Values)
            {
                await action(a, b);
            }
        }
        #endregion

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public void concat(object array)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "concat" }, array
                }
            );
        }

        public decimal indexOf(T value)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "indexOf" }, value
                }
            );
        }

        public bool contains(T value)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "contains" }, value
                }
            );
        }
        #endregion
    }
}