/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Container : Control
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public bool adaptHeightToChildren
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "adaptHeightToChildren"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "adaptHeightToChildren",
                    value
                );
            }
        }

        
        public bool adaptWidthToChildren
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "adaptWidthToChildren"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "adaptWidthToChildren",
                    value
                );
            }
        }

        
        public string background
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "background"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "background",
                    value
                );
            }
        }

        
        public Control[] children
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Control>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new Control(entity);
                    }
                );
            }
        }
        #endregion

        #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public bool logLayoutCycleErrors
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "logLayoutCycleErrors"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "logLayoutCycleErrors",
                    value
                );
            }
        }

        
        public decimal maxLayoutCycle
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxLayoutCycle"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxLayoutCycle",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Container() : base() { }

        public Container(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Container(
            string name = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "GUI", "Container" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Control getChildByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<Control>(
                entity => new Control(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getChildByName" }, name
                }
            );
        }

        public Control getChildByType(string name, string type)
        {
            return EventHorizonBlazorInteropt.FuncClass<Control>(
                entity => new Control(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getChildByType" }, name, type
                }
            );
        }

        public bool containsControl(Control control)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "containsControl" }, control
                }
            );
        }

        public Container addControl(Control control)
        {
            return EventHorizonBlazorInteropt.FuncClass<Container>(
                entity => new Container(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addControl" }, control
                }
            );
        }

        public Container clearControls()
        {
            return EventHorizonBlazorInteropt.FuncClass<Container>(
                entity => new Container(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clearControls" }
                }
            );
        }

        public Container removeControl(Control control)
        {
            return EventHorizonBlazorInteropt.FuncClass<Container>(
                entity => new Container(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeControl" }, control
                }
            );
        }

        #region getDescendantsToRef TODO: Get Comments as metadata identification
        private bool _isGetDescendantsToRefEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getDescendantsToRefActionMap = new Dictionary<string, Func<Task>>();

        public string getDescendantsToRef(
            Func<Task> callback
        )
        {
            SetupGetDescendantsToRefLoop();

            var handle = Guid.NewGuid().ToString();
            _getDescendantsToRefActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupGetDescendantsToRefLoop()
        {
            if (_isGetDescendantsToRefEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "getDescendantsToRef",
                "CallGetDescendantsToRefActions",
                _invokableReference
            );
            _isGetDescendantsToRefEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetDescendantsToRefActions()
        {
            foreach (var action in _getDescendantsToRefActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}