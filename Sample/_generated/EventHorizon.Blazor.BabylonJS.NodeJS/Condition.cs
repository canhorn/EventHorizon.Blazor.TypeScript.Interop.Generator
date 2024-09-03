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

    [JsonConverter(typeof(CachedEntityConverter<Condition>))]
    public class Condition : CachedEntityObject
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
        public Condition()
            : base() { }

        public Condition(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Condition(ActionManager actionManager)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Condition" },
                actionManager
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isValid()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isValid" } }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
            );
        }
        #endregion
    }
}
