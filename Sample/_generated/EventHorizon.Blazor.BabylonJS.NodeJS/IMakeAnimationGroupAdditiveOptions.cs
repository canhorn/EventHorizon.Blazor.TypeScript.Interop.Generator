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

        public bool cloneOriginalAnimationGroup
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cloneOriginalAnimationGroup"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "cloneOriginalAnimationGroup", value);
            }
        }

        public string clonedAnimationGroupName
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "clonedAnimationGroupName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "clonedAnimationGroupName", value);
            }
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
