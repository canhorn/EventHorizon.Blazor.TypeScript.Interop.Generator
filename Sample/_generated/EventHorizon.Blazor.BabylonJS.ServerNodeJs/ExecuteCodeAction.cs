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

        public static async ValueTask<ExecuteCodeAction> NewExecuteCodeAction(
            object triggerOptions,
            ActionCallback<ActionEvent> func,
            Condition condition = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ExecuteCodeAction" },
                triggerOptions,
                func,
                condition
            );

            return new ExecuteCodeAction(entity);
        }

        public static async ValueTask<ExecuteCodeAction> NewExecuteCodeAction(
            object triggerOptions,
            Condition condition = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ExecuteCodeAction" },
                triggerOptions,
                condition
            );

            return new ExecuteCodeAction(entity);
        }
        #endregion

        #region Methods
        public async ValueTask func(ActionEvent evt)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "func" }, evt }
            );
        }

        public async ValueTask execute(ActionEvent evt)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "execute" }, evt }
            );
        }
        #endregion
    }
}
