/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
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

        public bool renderToIntermediateTexture
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderToIntermediateTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "renderToIntermediateTexture", value);
            }
        }

        public bool adaptHeightToChildren
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "adaptHeightToChildren");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "adaptHeightToChildren", value);
            }
        }

        public bool adaptWidthToChildren
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "adaptWidthToChildren");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "adaptWidthToChildren", value);
            }
        }

        public string background
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "background"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "background", value);
            }
        }

        private BaseGradient __backgroundGradient;
        public BaseGradient backgroundGradient
        {
            get
            {
                if (__backgroundGradient == null)
                {
                    __backgroundGradient = EventHorizonBlazorInterop.GetClass<BaseGradient>(
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
            set
            {
                __backgroundGradient = null;
                EventHorizonBlazorInterop.Set(this.___guid, "backgroundGradient", value);
            }
        }

        public Control[] children
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<Control>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new Control() { ___guid = entity.___guid };
                    }
                );
            }
        }

        public bool isReadOnly
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isReadOnly"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isReadOnly", value);
            }
        }
        #endregion

        #region Properties

        public string name
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
            }
        }

        public bool delegatePickingToChildren
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "delegatePickingToChildren"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "delegatePickingToChildren", value);
            }
        }

        public bool logLayoutCycleErrors
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "logLayoutCycleErrors");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "logLayoutCycleErrors", value);
            }
        }

        public decimal maxLayoutCycle
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "maxLayoutCycle"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "maxLayoutCycle", value);
            }
        }

        private Observable<Control> __onControlAddedObservable;
        public Observable<Control> onControlAddedObservable
        {
            get
            {
                if (__onControlAddedObservable == null)
                {
                    __onControlAddedObservable = EventHorizonBlazorInterop.GetClass<
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
            set
            {
                __onControlAddedObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onControlAddedObservable", value);
            }
        }

        private Observable<Control> __onControlRemovedObservable;
        public Observable<Control> onControlRemovedObservable
        {
            get
            {
                if (__onControlRemovedObservable == null)
                {
                    __onControlRemovedObservable = EventHorizonBlazorInterop.GetClass<
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
            set
            {
                __onControlRemovedObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onControlRemovedObservable", value);
            }
        }
        #endregion

        #region Constructor
        public Container()
            : base() { }

        public Container(ICachedEntity entity)
            : base(entity) { }

        public Container(string name = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Container" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Control getChildByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getChildByName" }, name }
            );
        }

        public Control getChildByType(string name, string type)
        {
            return EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getChildByType" }, name, type }
            );
        }

        public bool containsControl(Control control)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "containsControl" }, control }
            );
        }

        public Container addControl(Control control)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addControl" }, control }
            );
        }

        public Container clearControls()
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clearControls" } }
            );
        }

        public Container removeControl(Control control)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "removeControl" }, control }
            );
        }

        public void getDescendantsToRef(
            Control[] results,
            System.Nullable<bool> directDescendantsOnly = null,
            ActionResultCallback<Control, bool> predicate = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getDescendantsToRef" },
                    results,
                    directDescendantsOnly,
                    predicate
                }
            );
        }

        public bool isDimensionFullyDefined(object dim)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isDimensionFullyDefined" }, dim }
            );
        }

        public void serialize(
            object serializationObject,
            System.Nullable<bool> force = null,
            System.Nullable<bool> allowCanvas = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" },
                    serializationObject,
                    force,
                    allowCanvas
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isReady" } }
            );
        }
        #endregion
    }
}
