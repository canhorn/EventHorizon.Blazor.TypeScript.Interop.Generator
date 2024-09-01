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

    [JsonConverter(typeof(CachedEntityConverter<InternalTexture>))]
    public class InternalTexture : TextureSampler
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        public bool useMipMaps
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useMipMaps"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useMipMaps", value);
            }
        }

        public decimal uniqueId
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "uniqueId"); }
        }

        public int source
        {
            get { return EventHorizonBlazorInterop.Get<int>(this.___guid, "source"); }
        }
        #endregion

        #region Properties

        public bool isReady
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isReady"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isReady", value);
            }
        }

        public bool isCube
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isCube"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isCube", value);
            }
        }

        public bool is3D
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "is3D"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "is3D", value);
            }
        }

        public bool is2DArray
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "is2DArray"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "is2DArray", value);
            }
        }

        public bool isMultiview
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isMultiview"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isMultiview", value);
            }
        }

        public string url
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "url"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "url", value);
            }
        }

        public bool generateMipMaps
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "generateMipMaps"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "generateMipMaps", value);
            }
        }

        public decimal samples
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "samples"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "samples", value);
            }
        }

        public decimal type
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "type"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "type", value);
            }
        }

        public decimal format
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "format"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "format", value);
            }
        }

        private Observable<InternalTexture> __onLoadedObservable;
        public Observable<InternalTexture> onLoadedObservable
        {
            get
            {
                if (__onLoadedObservable == null)
                {
                    __onLoadedObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<InternalTexture>
                    >(
                        this.___guid,
                        "onLoadedObservable",
                        (entity) =>
                        {
                            return new Observable<InternalTexture>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onLoadedObservable;
            }
            set
            {
                __onLoadedObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onLoadedObservable", value);
            }
        }

        private Observable<CachedEntity> __onErrorObservable;
        public Observable<CachedEntity> onErrorObservable
        {
            get
            {
                if (__onErrorObservable == null)
                {
                    __onErrorObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<CachedEntity>
                    >(
                        this.___guid,
                        "onErrorObservable",
                        (entity) =>
                        {
                            return new Observable<CachedEntity>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onErrorObservable;
            }
            set
            {
                __onErrorObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onErrorObservable", value);
            }
        }

        public ActionResultCallback<InternalTexture, InternalTexture> onRebuildCallback
        {
            get
            {
                return EventHorizonBlazorInterop.Get<
                    ActionResultCallback<InternalTexture, InternalTexture>
                >(this.___guid, "onRebuildCallback");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "onRebuildCallback", value);
            }
        }

        public decimal width
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "width"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "width", value);
            }
        }

        public decimal height
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "height"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "height", value);
            }
        }

        public decimal depth
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "depth"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "depth", value);
            }
        }

        public decimal baseWidth
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "baseWidth"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "baseWidth", value);
            }
        }

        public decimal baseHeight
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "baseHeight"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "baseHeight", value);
            }
        }

        public decimal baseDepth
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "baseDepth"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "baseDepth", value);
            }
        }

        public bool invertY
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "invertY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "invertY", value);
            }
        }
        #endregion

        #region Constructor
        public InternalTexture()
            : base() { }

        public InternalTexture(ICachedEntity entity)
            : base(entity) { }

        public InternalTexture(
            AbstractEngine engine,
            int source,
            System.Nullable<bool> delayAllocation = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InternalTexture" },
                engine,
                source,
                delayAllocation
            );
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods
        public AbstractEngine getEngine()
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractEngine>(
                entity => new AbstractEngine() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getEngine" } }
            );
        }

        public void incrementReferences()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "incrementReferences" } }
            );
        }

        public void updateSize(decimal width, decimal height, System.Nullable<decimal> depth = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "updateSize" }, width, height, depth }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
