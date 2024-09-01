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

    public interface IAnimationKey : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IAnimationKeyCachedEntity>))]
    public class IAnimationKeyCachedEntity : CachedEntityObject, IAnimationKey
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

        public decimal frame
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "frame"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "frame", value);
            }
        }

        public CachedEntity value
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "value",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "value", value);
            }
        }

        public CachedEntity inTangent
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "inTangent",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "inTangent", value);
            }
        }

        public CachedEntity outTangent
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "outTangent",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "outTangent", value);
            }
        }

        public int interpolation
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "interpolation"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "interpolation", value);
            }
        }

        public bool lockedTangent
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "lockedTangent"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "lockedTangent", value);
            }
        }

        private IEasingFunctionCachedEntity __easingFunction;
        public IEasingFunctionCachedEntity easingFunction
        {
            get
            {
                if (__easingFunction == null)
                {
                    __easingFunction =
                        EventHorizonBlazorInterop.GetClass<IEasingFunctionCachedEntity>(
                            this.___guid,
                            "easingFunction",
                            (entity) =>
                            {
                                return new IEasingFunctionCachedEntity()
                                {
                                    ___guid = entity.___guid
                                };
                            }
                        );
                }
                return __easingFunction;
            }
            set
            {
                __easingFunction = null;
                EventHorizonBlazorInterop.Set(this.___guid, "easingFunction", value);
            }
        }
        #endregion

        #region Constructor
        public IAnimationKeyCachedEntity()
            : base() { }

        public IAnimationKeyCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods

        #endregion
    }
}
