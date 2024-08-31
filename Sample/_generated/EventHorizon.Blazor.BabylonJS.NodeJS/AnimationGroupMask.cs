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

    [JsonConverter(typeof(CachedEntityConverter<AnimationGroupMask>))]
    public class AnimationGroupMask : CachedEntityObject
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

        public int mode
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "mode"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "mode", value);
            }
        }

        public bool disabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "disabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disabled", value);
            }
        }
        #endregion

        #region Constructor
        public AnimationGroupMask()
            : base() { }

        public AnimationGroupMask(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        public AnimationGroupMask(string[] names = null, System.Nullable<int> mode = null)
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AnimationGroupMask" },
                names,
                mode
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void addTargetName(string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addTargetName" }, name }
            );
        }

        public void removeTargetName(string name)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeTargetName" }, name }
            );
        }

        public bool hasTarget(string name)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasTarget" }, name }
            );
        }

        public bool retainsTarget(string name)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "retainsTarget" }, name }
            );
        }
        #endregion
    }
}
