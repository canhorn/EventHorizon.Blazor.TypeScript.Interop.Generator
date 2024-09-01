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

    [JsonConverter(typeof(CachedEntityConverter<AdvancedDynamicTexture>))]
    public class AdvancedDynamicTexture : DynamicTexture
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static string SnippetUrl
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "GUI.AdvancedDynamicTexture.SnippetUrl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "GUI.AdvancedDynamicTexture.SnippetUrl",
                    value
                );
            }
        }

        public static bool AllowGPUOptimizations
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "GUI.AdvancedDynamicTexture.AllowGPUOptimizations"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "GUI.AdvancedDynamicTexture.AllowGPUOptimizations",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static ValueTask<AdvancedDynamicTexture> ParseFromSnippetAsync(
            string snippetId,
            System.Nullable<bool> scaleToSize = null,
            AdvancedDynamicTexture appendToAdt = null,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            return EventHorizonBlazorInterop.TaskClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[]
                    {
                        "BABYLON",
                        "GUI",
                        "AdvancedDynamicTexture",
                        "ParseFromSnippetAsync"
                    },
                    snippetId,
                    scaleToSize,
                    appendToAdt,
                    urlRewriter
                }
            );
        }

        public static ValueTask<AdvancedDynamicTexture> ParseFromFileAsync(
            string url,
            System.Nullable<bool> scaleToSize = null,
            AdvancedDynamicTexture appendToAdt = null,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            return EventHorizonBlazorInterop.TaskClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[]
                    {
                        "BABYLON",
                        "GUI",
                        "AdvancedDynamicTexture",
                        "ParseFromFileAsync"
                    },
                    url,
                    scaleToSize,
                    appendToAdt,
                    urlRewriter
                }
            );
        }

        public static AdvancedDynamicTexture CreateForMesh(
            AbstractMesh mesh,
            System.Nullable<decimal> width = null,
            System.Nullable<decimal> height = null,
            System.Nullable<bool> supportPointerMove = null,
            System.Nullable<bool> onlyAlphaTesting = null,
            System.Nullable<bool> invertY = null,
            ActionCallback<
                AbstractMesh,
                string,
                AdvancedDynamicTexture,
                bool
            > materialSetupCallback = null,
            System.Nullable<decimal> sampling = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "AdvancedDynamicTexture", "CreateForMesh" },
                    mesh,
                    width,
                    height,
                    supportPointerMove,
                    onlyAlphaTesting,
                    invertY,
                    materialSetupCallback,
                    sampling
                }
            );
        }

        public static AdvancedDynamicTexture CreateForMeshTexture(
            AbstractMesh mesh,
            System.Nullable<decimal> width = null,
            System.Nullable<decimal> height = null,
            System.Nullable<bool> supportPointerMove = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<decimal> sampling = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[]
                    {
                        "BABYLON",
                        "GUI",
                        "AdvancedDynamicTexture",
                        "CreateForMeshTexture"
                    },
                    mesh,
                    width,
                    height,
                    supportPointerMove,
                    invertY,
                    sampling
                }
            );
        }

        public static AdvancedDynamicTexture CreateFullscreenUI(
            string name,
            System.Nullable<bool> foreground = null,
            Scene scene = null,
            System.Nullable<decimal> sampling = null,
            System.Nullable<bool> adaptiveScaling = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[]
                    {
                        "BABYLON",
                        "GUI",
                        "AdvancedDynamicTexture",
                        "CreateFullscreenUI"
                    },
                    name,
                    foreground,
                    scene,
                    sampling,
                    adaptiveScaling
                }
            );
        }
        #endregion

        #region Accessors

        public decimal numLayoutCalls
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "numLayoutCalls"); }
        }

        public decimal numRenderCalls
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "numRenderCalls"); }
        }

        public decimal renderScale
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "renderScale"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "renderScale", value);
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

        public decimal idealWidth
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "idealWidth"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "idealWidth", value);
            }
        }

        public decimal idealHeight
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "idealHeight"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "idealHeight", value);
            }
        }

        public bool useSmallestIdeal
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useSmallestIdeal"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useSmallestIdeal", value);
            }
        }

        public bool renderAtIdealSize
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "renderAtIdealSize"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "renderAtIdealSize", value);
            }
        }

        public decimal idealRatio
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "idealRatio"); }
        }

        private Layer __layer;
        public Layer layer
        {
            get
            {
                if (__layer == null)
                {
                    __layer = EventHorizonBlazorInterop.GetClass<Layer>(
                        this.___guid,
                        "layer",
                        (entity) =>
                        {
                            return new Layer() { ___guid = entity.___guid };
                        }
                    );
                }
                return __layer;
            }
        }

        private Container __rootContainer;
        public Container rootContainer
        {
            get
            {
                if (__rootContainer == null)
                {
                    __rootContainer = EventHorizonBlazorInterop.GetClass<Container>(
                        this.___guid,
                        "rootContainer",
                        (entity) =>
                        {
                            return new Container() { ___guid = entity.___guid };
                        }
                    );
                }
                return __rootContainer;
            }
        }

        private Control __focusedControl;
        public Control focusedControl
        {
            get
            {
                if (__focusedControl == null)
                {
                    __focusedControl = EventHorizonBlazorInterop.GetClass<Control>(
                        this.___guid,
                        "focusedControl",
                        (entity) =>
                        {
                            return new Control() { ___guid = entity.___guid };
                        }
                    );
                }
                return __focusedControl;
            }
            set
            {
                __focusedControl = null;
                EventHorizonBlazorInterop.Set(this.___guid, "focusedControl", value);
            }
        }

        public bool isForeground
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isForeground"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isForeground", value);
            }
        }

        public string clipboardData
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "clipboardData"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "clipboardData", value);
            }
        }

        public bool useInvalidateRectOptimization
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useInvalidateRectOptimization"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useInvalidateRectOptimization", value);
            }
        }
        #endregion

        #region Properties

        public string snippetId
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "snippetId"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "snippetId", value);
            }
        }

        private Observable<AdvancedDynamicTexture> __onGuiReadyObservable;
        public Observable<AdvancedDynamicTexture> onGuiReadyObservable
        {
            get
            {
                if (__onGuiReadyObservable == null)
                {
                    __onGuiReadyObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AdvancedDynamicTexture>
                    >(
                        this.___guid,
                        "onGuiReadyObservable",
                        (entity) =>
                        {
                            return new Observable<AdvancedDynamicTexture>()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
                }
                return __onGuiReadyObservable;
            }
            set
            {
                __onGuiReadyObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onGuiReadyObservable", value);
            }
        }

        private Observable<ClipboardInfo> __onClipboardObservable;
        public Observable<ClipboardInfo> onClipboardObservable
        {
            get
            {
                if (__onClipboardObservable == null)
                {
                    __onClipboardObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<ClipboardInfo>
                    >(
                        this.___guid,
                        "onClipboardObservable",
                        (entity) =>
                        {
                            return new Observable<ClipboardInfo>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onClipboardObservable;
            }
            set
            {
                __onClipboardObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onClipboardObservable", value);
            }
        }

        private Observable<Control> __onControlPickedObservable;
        public Observable<Control> onControlPickedObservable
        {
            get
            {
                if (__onControlPickedObservable == null)
                {
                    __onControlPickedObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Control>
                    >(
                        this.___guid,
                        "onControlPickedObservable",
                        (entity) =>
                        {
                            return new Observable<Control>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onControlPickedObservable;
            }
            set
            {
                __onControlPickedObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onControlPickedObservable", value);
            }
        }

        private Observable<AdvancedDynamicTexture> __onBeginLayoutObservable;
        public Observable<AdvancedDynamicTexture> onBeginLayoutObservable
        {
            get
            {
                if (__onBeginLayoutObservable == null)
                {
                    __onBeginLayoutObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AdvancedDynamicTexture>
                    >(
                        this.___guid,
                        "onBeginLayoutObservable",
                        (entity) =>
                        {
                            return new Observable<AdvancedDynamicTexture>()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
                }
                return __onBeginLayoutObservable;
            }
            set
            {
                __onBeginLayoutObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onBeginLayoutObservable", value);
            }
        }

        private Observable<AdvancedDynamicTexture> __onEndLayoutObservable;
        public Observable<AdvancedDynamicTexture> onEndLayoutObservable
        {
            get
            {
                if (__onEndLayoutObservable == null)
                {
                    __onEndLayoutObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AdvancedDynamicTexture>
                    >(
                        this.___guid,
                        "onEndLayoutObservable",
                        (entity) =>
                        {
                            return new Observable<AdvancedDynamicTexture>()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
                }
                return __onEndLayoutObservable;
            }
            set
            {
                __onEndLayoutObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onEndLayoutObservable", value);
            }
        }

        private Observable<AdvancedDynamicTexture> __onBeginRenderObservable;
        public Observable<AdvancedDynamicTexture> onBeginRenderObservable
        {
            get
            {
                if (__onBeginRenderObservable == null)
                {
                    __onBeginRenderObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AdvancedDynamicTexture>
                    >(
                        this.___guid,
                        "onBeginRenderObservable",
                        (entity) =>
                        {
                            return new Observable<AdvancedDynamicTexture>()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
                }
                return __onBeginRenderObservable;
            }
            set
            {
                __onBeginRenderObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onBeginRenderObservable", value);
            }
        }

        private Observable<AdvancedDynamicTexture> __onEndRenderObservable;
        public Observable<AdvancedDynamicTexture> onEndRenderObservable
        {
            get
            {
                if (__onEndRenderObservable == null)
                {
                    __onEndRenderObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<AdvancedDynamicTexture>
                    >(
                        this.___guid,
                        "onEndRenderObservable",
                        (entity) =>
                        {
                            return new Observable<AdvancedDynamicTexture>()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
                }
                return __onEndRenderObservable;
            }
            set
            {
                __onEndRenderObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onEndRenderObservable", value);
            }
        }

        public bool premulAlpha
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "premulAlpha"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "premulAlpha", value);
            }
        }

        public bool applyYInversionOnUpdate
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "applyYInversionOnUpdate");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "applyYInversionOnUpdate", value);
            }
        }

        public bool disableTabNavigation
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableTabNavigation");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disableTabNavigation", value);
            }
        }

        public decimal skipBlockEvents
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "skipBlockEvents"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "skipBlockEvents", value);
            }
        }

        public bool checkPointerEveryFrame
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "checkPointerEveryFrame");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "checkPointerEveryFrame", value);
            }
        }
        #endregion

        #region Constructor
        public AdvancedDynamicTexture()
            : base() { }

        public AdvancedDynamicTexture(ICachedEntity entity)
            : base(entity) { }

        public AdvancedDynamicTexture(
            string name,
            System.Nullable<decimal> width = null,
            System.Nullable<decimal> height = null,
            Scene scene = null,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<bool> invertY = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "AdvancedDynamicTexture" },
                name,
                width,
                height,
                scene,
                generateMipMaps,
                samplingMode,
                invertY
            );
            ___guid = entity.___guid;
        }

        public AdvancedDynamicTexture(
            string name,
            object options,
            Scene scene = null,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<decimal> format = null,
            System.Nullable<bool> invertY = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AdvancedDynamicTexture" },
                name,
                options,
                scene,
                generateMipMaps,
                samplingMode,
                format,
                invertY
            );
            ___guid = entity.___guid;
        }

        public AdvancedDynamicTexture(
            string url = null,
            Scene sceneOrEngine = null,
            System.Nullable<bool> noMipmapOrOptions = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<decimal> samplingMode = null,
            ActionCallback onLoad = null,
            ActionCallback<string, CachedEntity> onError = null,
            string buffer = null,
            System.Nullable<bool> deleteBuffer = null,
            System.Nullable<decimal> format = null,
            string mimeType = null,
            object loaderOptions = null,
            System.Nullable<decimal> creationFlags = null,
            string forcedExtension = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AdvancedDynamicTexture" },
                url,
                sceneOrEngine,
                noMipmapOrOptions,
                invertY,
                samplingMode,
                onLoad,
                onError,
                buffer,
                deleteBuffer,
                format,
                mimeType,
                loaderOptions,
                creationFlags,
                forcedExtension
            );
            ___guid = entity.___guid;
        }

        public AdvancedDynamicTexture(
            Scene sceneOrEngine = null,
            InternalTexture internalTexture = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AdvancedDynamicTexture" },
                sceneOrEngine,
                internalTexture
            );
            ___guid = entity.___guid;
        }

        public AdvancedDynamicTexture(InternalTexture internalTexture)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AdvancedDynamicTexture" },
                internalTexture
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Container[] getChildren()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getChildren" } }
            );
        }

        public Control[] getDescendants(
            System.Nullable<bool> directDescendantsOnly = null,
            ActionResultCallback<Control, bool> predicate = null
        )
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDescendants" },
                    directDescendantsOnly,
                    predicate
                }
            );
        }

        public Control[] getControlsByType(string typeName)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getControlsByType" }, typeName }
            );
        }

        public Control getControlByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getControlByName" }, name }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public void executeOnAllControls(ActionCallback<Control> func, Container container = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "executeOnAllControls" },
                    func,
                    container
                }
            );
        }

        public void invalidateRect(
            decimal invalidMinX,
            decimal invalidMinY,
            decimal invalidMaxX,
            decimal invalidMaxY
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "invalidateRect" },
                    invalidMinX,
                    invalidMinY,
                    invalidMaxX,
                    invalidMaxY
                }
            );
        }

        public void markAsDirty()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "markAsDirty" } }
            );
        }

        public Style createStyle()
        {
            return EventHorizonBlazorInterop.FuncClass<Style>(
                entity => new Style() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createStyle" } }
            );
        }

        public AdvancedDynamicTexture addControl(Control control)
        {
            return EventHorizonBlazorInterop.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addControl" }, control }
            );
        }

        public AdvancedDynamicTexture removeControl(Control control)
        {
            return EventHorizonBlazorInterop.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "removeControl" }, control }
            );
        }

        public void moveToNonOverlappedPosition(
            System.Nullable<decimal> overlapGroup = null,
            System.Nullable<decimal> deltaStep = null,
            System.Nullable<decimal> repelFactor = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "moveToNonOverlappedPosition" },
                    overlapGroup,
                    deltaStep,
                    repelFactor
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public Vector2 getProjectedPosition(Vector3 position, Matrix worldMatrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getProjectedPosition" },
                    position,
                    worldMatrix
                }
            );
        }

        public Vector3 getProjectedPositionWithZ(Vector3 position, Matrix worldMatrix)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getProjectedPositionWithZ" },
                    position,
                    worldMatrix
                }
            );
        }

        public void pick(decimal x, decimal y, PointerInfoPre pi = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "pick" }, x, y, pi }
            );
        }

        public void attach()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "attach" } }
            );
        }

        public void registerClipboardEvents()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "registerClipboardEvents" } }
            );
        }

        public void unRegisterClipboardEvents()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unRegisterClipboardEvents" } }
            );
        }

        public void attachToMesh(AbstractMesh mesh, System.Nullable<bool> supportPointerMove = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "attachToMesh" },
                    mesh,
                    supportPointerMove
                }
            );
        }

        public void moveFocusToControl(Control control)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "moveFocusToControl" }, control }
            );
        }

        public CachedEntity serializeContent()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serializeContent" } }
            );
        }

        public void parseSerializedObject(
            object serializedObject,
            System.Nullable<bool> scaleToSize = null,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "parseSerializedObject" },
                    serializedObject,
                    scaleToSize,
                    urlRewriter
                }
            );
        }

        public AdvancedDynamicTexture clone(string newName = null, AbstractMesh attachToMesh = null)
        {
            return EventHorizonBlazorInterop.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" }, newName, attachToMesh }
            );
        }

        public void parseContent(
            object serializedObject,
            System.Nullable<bool> scaleToSize = null,
            ActionResultCallback<ActionResultCallback<string, string>> urlRewriter = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "parseContent" },
                    serializedObject,
                    scaleToSize,
                    urlRewriter
                }
            );
        }

        public ValueTask<AdvancedDynamicTexture> parseFromSnippetAsync(
            string snippetId,
            System.Nullable<bool> scaleToSize = null,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            return EventHorizonBlazorInterop.TaskClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parseFromSnippetAsync" },
                    snippetId,
                    scaleToSize,
                    urlRewriter
                }
            );
        }

        public ValueTask<AdvancedDynamicTexture> parseFromURLAsync(
            string url,
            System.Nullable<bool> scaleToSize = null,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            return EventHorizonBlazorInterop.TaskClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parseFromURLAsync" },
                    url,
                    scaleToSize,
                    urlRewriter
                }
            );
        }

        public void scale(decimal ratio)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scale" }, ratio }
            );
        }

        public void scaleTo(decimal width, decimal height)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scaleTo" }, width, height }
            );
        }

        public bool guiIsReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "guiIsReady" } }
            );
        }
        #endregion
    }
}
