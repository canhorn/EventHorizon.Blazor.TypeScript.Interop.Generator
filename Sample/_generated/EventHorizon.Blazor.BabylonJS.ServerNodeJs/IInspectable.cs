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

    public interface IInspectable : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IInspectableCachedEntity>))]
    public class IInspectableCachedEntity : CachedEntityObject, IInspectable
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

        public async ValueTask<string> get_label()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "label");
        }

        public ValueTask set_label(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "label", value);
        }

        public async ValueTask<string> get_propertyName()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "propertyName");
        }

        public ValueTask set_propertyName(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "propertyName", value);
        }

        public async ValueTask<int> get_type()
        {
            return await EventHorizonBlazorInterop.Get<int>(this.___guid, "type");
        }

        public ValueTask set_type(int value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "type", value);
        }

        public async ValueTask<decimal> get_min()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "min");
        }

        public ValueTask set_min(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "min", value);
        }

        public async ValueTask<decimal> get_max()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "max");
        }

        public ValueTask set_max(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "max", value);
        }

        public async ValueTask<decimal> get_step()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "step");
        }

        public ValueTask set_step(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "step", value);
        }

        public async ValueTask<IInspectableOptionsCachedEntity[]> get_options()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<IInspectableOptionsCachedEntity>(
                this.___guid,
                "options",
                (entity) =>
                {
                    return new IInspectableOptionsCachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_options(IInspectableOptionsCachedEntity[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "options", value);
        }

        public async ValueTask<string> get_accept()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "accept");
        }

        public ValueTask set_accept(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "accept", value);
        }
        #endregion

        #region Constructor
        public IInspectableCachedEntity()
            : base() { }

        public IInspectableCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask callback()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "callback" } }
            );
        }

        public async ValueTask fileCallback(File file)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "fileCallback" }, file }
            );
        }
        #endregion
    }
}
