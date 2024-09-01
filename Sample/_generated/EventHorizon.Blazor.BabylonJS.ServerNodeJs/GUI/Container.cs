/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<Container>))]
    public class Container : Control
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public async ValueTask<bool> get_renderToIntermediateTexture()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "renderToIntermediateTexture"
            );
        }

        public ValueTask set_renderToIntermediateTexture(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "renderToIntermediateTexture",
                value
            );
        }

        public async ValueTask<bool> get_adaptHeightToChildren()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "adaptHeightToChildren");
        }

        public ValueTask set_adaptHeightToChildren(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "adaptHeightToChildren", value);
        }

        public async ValueTask<bool> get_adaptWidthToChildren()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "adaptWidthToChildren");
        }

        public ValueTask set_adaptWidthToChildren(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "adaptWidthToChildren", value);
        }

        public async ValueTask<string> get_background()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "background");
        }

        public ValueTask set_background(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "background", value);
        }

        private BaseGradient __backgroundGradient;

        public async ValueTask<BaseGradient> get_backgroundGradient()
        {
            if (__backgroundGradient == null)
            {
                __backgroundGradient = await EventHorizonBlazorInterop.GetClass<BaseGradient>(
                    this.___guid,
                    "backgroundGradient",
                    (entity) =>
                    {
                        return new BaseGradient() { ___guid = entity.___guid };
                    }
                );
            }
            return __backgroundGradient;
        }

        public ValueTask set_backgroundGradient(BaseGradient value)
        {
            __backgroundGradient = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "backgroundGradient", value);
        }

        public async ValueTask<Control[]> get_children()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Control>(
                this.___guid,
                "children",
                (entity) =>
                {
                    return new Control() { ___guid = entity.___guid };
                }
            );
        }

        public async ValueTask<bool> get_isReadOnly()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isReadOnly");
        }

        public ValueTask set_isReadOnly(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isReadOnly", value);
        }
        #endregion

        #region Properties

        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "name");
        }

        public ValueTask set_name(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "name", value);
        }

        public async ValueTask<bool> get_delegatePickingToChildren()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "delegatePickingToChildren"
            );
        }

        public ValueTask set_delegatePickingToChildren(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "delegatePickingToChildren", value);
        }

        public async ValueTask<bool> get_logLayoutCycleErrors()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "logLayoutCycleErrors");
        }

        public ValueTask set_logLayoutCycleErrors(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "logLayoutCycleErrors", value);
        }

        public async ValueTask<decimal> get_maxLayoutCycle()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maxLayoutCycle");
        }

        public ValueTask set_maxLayoutCycle(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "maxLayoutCycle", value);
        }

        private Observable<Control> __onControlAddedObservable;

        public async ValueTask<Observable<Control>> get_onControlAddedObservable()
        {
            if (__onControlAddedObservable == null)
            {
                __onControlAddedObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<Control>
                >(
                    this.___guid,
                    "onControlAddedObservable",
                    (entity) =>
                    {
                        return new Observable<Control>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onControlAddedObservable;
        }

        public ValueTask set_onControlAddedObservable(Observable<Control> value)
        {
            __onControlAddedObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onControlAddedObservable", value);
        }

        private Observable<Control> __onControlRemovedObservable;

        public async ValueTask<Observable<Control>> get_onControlRemovedObservable()
        {
            if (__onControlRemovedObservable == null)
            {
                __onControlRemovedObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<Control>
                >(
                    this.___guid,
                    "onControlRemovedObservable",
                    (entity) =>
                    {
                        return new Observable<Control>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onControlRemovedObservable;
        }

        public ValueTask set_onControlRemovedObservable(Observable<Control> value)
        {
            __onControlRemovedObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onControlRemovedObservable", value);
        }
        #endregion

        #region Constructor
        public Container()
            : base() { }

        public Container(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<Container> NewContainer(string name = null)
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Container" },
                name
            );

            return new Container(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<Control> getChildByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getChildByName" }, name }
            );
        }

        public async ValueTask<Control> getChildByType(string name, string type)
        {
            return await EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getChildByType" }, name, type }
            );
        }

        public async ValueTask<bool> containsControl(Control control)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "containsControl" }, control }
            );
        }

        public async ValueTask<Container> addControl(Control control)
        {
            return await EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addControl" }, control }
            );
        }

        public async ValueTask<Container> clearControls()
        {
            return await EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clearControls" } }
            );
        }

        public async ValueTask<Container> removeControl(Control control)
        {
            return await EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "removeControl" }, control }
            );
        }

        public async ValueTask getDescendantsToRef(
            Control[] results,
            System.Nullable<bool> directDescendantsOnly = null,
            ActionResultCallback<Control, bool> predicate = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getDescendantsToRef" },
                    results,
                    directDescendantsOnly,
                    predicate
                }
            );
        }

        public async ValueTask<bool> isDimensionFullyDefined(object dim)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isDimensionFullyDefined" }, dim }
            );
        }

        public async ValueTask serialize(
            object serializationObject,
            System.Nullable<bool> force = null,
            System.Nullable<bool> allowCanvas = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" },
                    serializationObject,
                    force,
                    allowCanvas
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public async ValueTask<bool> isReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReady" } }
            );
        }
        #endregion
    }
}
