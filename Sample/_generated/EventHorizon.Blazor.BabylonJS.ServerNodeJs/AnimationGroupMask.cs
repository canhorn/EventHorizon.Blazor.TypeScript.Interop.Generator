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

        public async ValueTask<int> get_mode()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "mode");
        }

        public ValueTask set_mode(int value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "mode", value);
        }

        public async ValueTask<bool> get_disabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "disabled");
        }

        public ValueTask set_disabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disabled", value);
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

        public static async ValueTask<AnimationGroupMask> NewAnimationGroupMask(
            string[] names = null,
            System.Nullable<int> mode = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AnimationGroupMask" },
                names,
                mode
            );

            return new AnimationGroupMask(entity);
        }
        #endregion

        #region Methods
        public async ValueTask addTargetName(string name)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addTargetName" }, name }
            );
        }

        public async ValueTask removeTargetName(string name)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeTargetName" }, name }
            );
        }

        public async ValueTask<bool> hasTarget(string name)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "hasTarget" }, name }
            );
        }

        public async ValueTask<bool> retainsTarget(string name)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "retainsTarget" }, name }
            );
        }
        #endregion
    }
}
