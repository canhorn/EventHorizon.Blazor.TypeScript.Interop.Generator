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

    public interface IMakeAnimationGroupAdditiveOptions : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IMakeAnimationGroupAdditiveOptionsCachedEntity>))]
    public class IMakeAnimationGroupAdditiveOptionsCachedEntity
        : CachedEntityObject,
            IMakeAnimationGroupAdditiveOptions
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

        public async ValueTask<bool> get_cloneOriginalAnimationGroup()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "cloneOriginalAnimationGroup"
            );
        }

        public ValueTask set_cloneOriginalAnimationGroup(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "cloneOriginalAnimationGroup",
                value
            );
        }

        public async ValueTask<string> get_clonedAnimationGroupName()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                this.___guid,
                "clonedAnimationGroupName"
            );
        }

        public ValueTask set_clonedAnimationGroupName(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "clonedAnimationGroupName", value);
        }
        #endregion

        #region Constructor
        public IMakeAnimationGroupAdditiveOptionsCachedEntity()
            : base() { }

        public IMakeAnimationGroupAdditiveOptionsCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
