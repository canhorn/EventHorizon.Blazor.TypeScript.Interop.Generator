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

    [JsonConverter(typeof(CachedEntityConverter<ExecuteCodeAction>))]
    public class ExecuteCodeAction : Action
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

        #endregion

        #region Constructor
        public ExecuteCodeAction()
            : base() { }

        public ExecuteCodeAction(ICachedEntity entity)
            : base(entity) { }

        public ExecuteCodeAction(
            object triggerOptions,
            ActionCallback<ActionEvent> func,
            Condition condition = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ExecuteCodeAction" },
                triggerOptions,
                func,
                condition
            );
            ___guid = entity.___guid;
        }

        public ExecuteCodeAction(object triggerOptions, Condition condition = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ExecuteCodeAction" },
                triggerOptions,
                condition
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void func(ActionEvent evt)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "func" }, evt }
            );
        }

        public void execute(ActionEvent evt)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "execute" }, evt }
            );
        }
        #endregion
    }
}
