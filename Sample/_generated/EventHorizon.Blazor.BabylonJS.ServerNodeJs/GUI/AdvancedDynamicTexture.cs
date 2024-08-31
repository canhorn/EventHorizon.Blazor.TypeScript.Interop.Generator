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

    [JsonConverter(typeof(CachedEntityConverter<AdvancedDynamicTexture>))]
    public class AdvancedDynamicTexture : DynamicTexture
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<string> get_SnippetUrl()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                "BABYLON",
                "GUI.AdvancedDynamicTexture.SnippetUrl"
            );
        }

        public static ValueTask set_SnippetUrl(string value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "GUI.AdvancedDynamicTexture.SnippetUrl",
                value
            );
        }

        public static async ValueTask<bool> get_AllowGPUOptimizations()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "GUI.AdvancedDynamicTexture.AllowGPUOptimizations"
            );
        }

        public static ValueTask set_AllowGPUOptimizations(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "GUI.AdvancedDynamicTexture.AllowGPUOptimizations",
                value
            );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<AdvancedDynamicTexture> ParseFromSnippetAsync(
            string snippetId,
            System.Nullable<bool> scaleToSize = null,
            AdvancedDynamicTexture appendToAdt = null,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            return await EventHorizonBlazorInterop.TaskClass<AdvancedDynamicTexture>(
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

        public static async ValueTask<AdvancedDynamicTexture> ParseFromFileAsync(
            string url,
            System.Nullable<bool> scaleToSize = null,
            AdvancedDynamicTexture appendToAdt = null,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            return await EventHorizonBlazorInterop.TaskClass<AdvancedDynamicTexture>(
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

        public static async ValueTask<AdvancedDynamicTexture> CreateForMesh(
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
            return await EventHorizonBlazorInterop.FuncClass<AdvancedDynamicTexture>(
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

        public static async ValueTask<AdvancedDynamicTexture> CreateForMeshTexture(
            AbstractMesh mesh,
            System.Nullable<decimal> width = null,
            System.Nullable<decimal> height = null,
            System.Nullable<bool> supportPointerMove = null,
            System.Nullable<bool> invertY = null,
            System.Nullable<decimal> sampling = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AdvancedDynamicTexture>(
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

        public static async ValueTask<AdvancedDynamicTexture> CreateFullscreenUI(
            string name,
            System.Nullable<bool> foreground = null,
            Scene scene = null,
            System.Nullable<decimal> sampling = null,
            System.Nullable<bool> adaptiveScaling = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AdvancedDynamicTexture>(
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

        public async ValueTask<decimal> get_numLayoutCalls()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "numLayoutCalls");
        }

        public async ValueTask<decimal> get_numRenderCalls()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "numRenderCalls");
        }

        public async ValueTask<decimal> get_renderScale()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "renderScale");
        }

        public ValueTask set_renderScale(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "renderScale", value);
        }

        public async ValueTask<string> get_background()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "background");
        }

        public ValueTask set_background(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "background", value);
        }

        public async ValueTask<decimal> get_idealWidth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "idealWidth");
        }

        public ValueTask set_idealWidth(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "idealWidth", value);
        }

        public async ValueTask<decimal> get_idealHeight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "idealHeight");
        }

        public ValueTask set_idealHeight(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "idealHeight", value);
        }

        public async ValueTask<bool> get_useSmallestIdeal()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "useSmallestIdeal");
        }

        public ValueTask set_useSmallestIdeal(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useSmallestIdeal", value);
        }

        public async ValueTask<bool> get_renderAtIdealSize()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "renderAtIdealSize");
        }

        public ValueTask set_renderAtIdealSize(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "renderAtIdealSize", value);
        }

        public async ValueTask<decimal> get_idealRatio()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "idealRatio");
        }

        private Layer __layer;

        public async ValueTask<Layer> get_layer()
        {
            if (__layer == null)
            {
                __layer = await EventHorizonBlazorInterop.GetClass<Layer>(
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

        private Container __rootContainer;

        public async ValueTask<Container> get_rootContainer()
        {
            if (__rootContainer == null)
            {
                __rootContainer = await EventHorizonBlazorInterop.GetClass<Container>(
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

        private Control __focusedControl;

        public async ValueTask<Control> get_focusedControl()
        {
            if (__focusedControl == null)
            {
                __focusedControl = await EventHorizonBlazorInterop.GetClass<Control>(
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

        public ValueTask set_focusedControl(Control value)
        {
            __focusedControl = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "focusedControl", value);
        }

        public async ValueTask<bool> get_isForeground()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isForeground");
        }

        public ValueTask set_isForeground(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isForeground", value);
        }

        public async ValueTask<string> get_clipboardData()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "clipboardData");
        }

        public ValueTask set_clipboardData(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "clipboardData", value);
        }

        public async ValueTask<bool> get_useInvalidateRectOptimization()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useInvalidateRectOptimization"
            );
        }

        public ValueTask set_useInvalidateRectOptimization(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "useInvalidateRectOptimization",
                value
            );
        }
        #endregion

        #region Properties

        public async ValueTask<string> get_snippetId()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "snippetId");
        }

        public ValueTask set_snippetId(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "snippetId", value);
        }

        private Observable<AdvancedDynamicTexture> __onGuiReadyObservable;

        public async ValueTask<Observable<AdvancedDynamicTexture>> get_onGuiReadyObservable()
        {
            if (__onGuiReadyObservable == null)
            {
                __onGuiReadyObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onGuiReadyObservable(Observable<AdvancedDynamicTexture> value)
        {
            __onGuiReadyObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onGuiReadyObservable", value);
        }

        private Observable<ClipboardInfo> __onClipboardObservable;

        public async ValueTask<Observable<ClipboardInfo>> get_onClipboardObservable()
        {
            if (__onClipboardObservable == null)
            {
                __onClipboardObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onClipboardObservable(Observable<ClipboardInfo> value)
        {
            __onClipboardObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onClipboardObservable", value);
        }

        private Observable<Control> __onControlPickedObservable;

        public async ValueTask<Observable<Control>> get_onControlPickedObservable()
        {
            if (__onControlPickedObservable == null)
            {
                __onControlPickedObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onControlPickedObservable(Observable<Control> value)
        {
            __onControlPickedObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onControlPickedObservable", value);
        }

        private Observable<AdvancedDynamicTexture> __onBeginLayoutObservable;

        public async ValueTask<Observable<AdvancedDynamicTexture>> get_onBeginLayoutObservable()
        {
            if (__onBeginLayoutObservable == null)
            {
                __onBeginLayoutObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onBeginLayoutObservable(Observable<AdvancedDynamicTexture> value)
        {
            __onBeginLayoutObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onBeginLayoutObservable", value);
        }

        private Observable<AdvancedDynamicTexture> __onEndLayoutObservable;

        public async ValueTask<Observable<AdvancedDynamicTexture>> get_onEndLayoutObservable()
        {
            if (__onEndLayoutObservable == null)
            {
                __onEndLayoutObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onEndLayoutObservable(Observable<AdvancedDynamicTexture> value)
        {
            __onEndLayoutObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onEndLayoutObservable", value);
        }

        private Observable<AdvancedDynamicTexture> __onBeginRenderObservable;

        public async ValueTask<Observable<AdvancedDynamicTexture>> get_onBeginRenderObservable()
        {
            if (__onBeginRenderObservable == null)
            {
                __onBeginRenderObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onBeginRenderObservable(Observable<AdvancedDynamicTexture> value)
        {
            __onBeginRenderObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onBeginRenderObservable", value);
        }

        private Observable<AdvancedDynamicTexture> __onEndRenderObservable;

        public async ValueTask<Observable<AdvancedDynamicTexture>> get_onEndRenderObservable()
        {
            if (__onEndRenderObservable == null)
            {
                __onEndRenderObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onEndRenderObservable(Observable<AdvancedDynamicTexture> value)
        {
            __onEndRenderObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onEndRenderObservable", value);
        }

        public async ValueTask<bool> get_premulAlpha()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "premulAlpha");
        }

        public ValueTask set_premulAlpha(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "premulAlpha", value);
        }

        public async ValueTask<bool> get_applyYInversionOnUpdate()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "applyYInversionOnUpdate"
            );
        }

        public ValueTask set_applyYInversionOnUpdate(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "applyYInversionOnUpdate", value);
        }

        public async ValueTask<bool> get_disableTabNavigation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "disableTabNavigation");
        }

        public ValueTask set_disableTabNavigation(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disableTabNavigation", value);
        }

        public async ValueTask<decimal> get_skipBlockEvents()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "skipBlockEvents");
        }

        public ValueTask set_skipBlockEvents(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "skipBlockEvents", value);
        }

        public async ValueTask<bool> get_checkPointerEveryFrame()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "checkPointerEveryFrame"
            );
        }

        public ValueTask set_checkPointerEveryFrame(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "checkPointerEveryFrame", value);
        }
        #endregion

        #region Constructor
        public AdvancedDynamicTexture()
            : base() { }

        public AdvancedDynamicTexture(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<AdvancedDynamicTexture> NewAdvancedDynamicTexture(
            string name,
            System.Nullable<decimal> width = null,
            System.Nullable<decimal> height = null,
            Scene scene = null,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<bool> invertY = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "AdvancedDynamicTexture" },
                name,
                width,
                height,
                scene,
                generateMipMaps,
                samplingMode,
                invertY
            );

            return new AdvancedDynamicTexture(entity);
        }

        public static async ValueTask<AdvancedDynamicTexture> NewAdvancedDynamicTexture(
            string name,
            object options,
            Scene scene = null,
            System.Nullable<bool> generateMipMaps = null,
            System.Nullable<decimal> samplingMode = null,
            System.Nullable<decimal> format = null,
            System.Nullable<bool> invertY = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AdvancedDynamicTexture" },
                name,
                options,
                scene,
                generateMipMaps,
                samplingMode,
                format,
                invertY
            );

            return new AdvancedDynamicTexture(entity);
        }

        public static async ValueTask<AdvancedDynamicTexture> NewAdvancedDynamicTexture(
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
        {
            var entity = await EventHorizonBlazorInterop.New(
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

            return new AdvancedDynamicTexture(entity);
        }

        public static async ValueTask<AdvancedDynamicTexture> NewAdvancedDynamicTexture(
            Scene sceneOrEngine = null,
            InternalTexture internalTexture = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AdvancedDynamicTexture" },
                sceneOrEngine,
                internalTexture
            );

            return new AdvancedDynamicTexture(entity);
        }

        public static async ValueTask<AdvancedDynamicTexture> NewAdvancedDynamicTexture(
            InternalTexture internalTexture
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AdvancedDynamicTexture" },
                internalTexture
            );

            return new AdvancedDynamicTexture(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<Container[]> getChildren()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getChildren" } }
            );
        }

        public async ValueTask<Control[]> getDescendants(
            System.Nullable<bool> directDescendantsOnly = null,
            ActionResultCallback<Control, bool> predicate = null
        )
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDescendants" },
                    directDescendantsOnly,
                    predicate
                }
            );
        }

        public async ValueTask<Control[]> getControlsByType(string typeName)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getControlsByType" }, typeName }
            );
        }

        public async ValueTask<Control> getControlByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getControlByName" }, name }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask executeOnAllControls(
            ActionCallback<Control> func,
            Container container = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "executeOnAllControls" },
                    func,
                    container
                }
            );
        }

        public async ValueTask invalidateRect(
            decimal invalidMinX,
            decimal invalidMinY,
            decimal invalidMaxX,
            decimal invalidMaxY
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask markAsDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "markAsDirty" } }
            );
        }

        public async ValueTask<Style> createStyle()
        {
            return await EventHorizonBlazorInterop.FuncClass<Style>(
                entity => new Style() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "createStyle" } }
            );
        }

        public async ValueTask<AdvancedDynamicTexture> addControl(Control control)
        {
            return await EventHorizonBlazorInterop.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "addControl" }, control }
            );
        }

        public async ValueTask<AdvancedDynamicTexture> removeControl(Control control)
        {
            return await EventHorizonBlazorInterop.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "removeControl" }, control }
            );
        }

        public async ValueTask moveToNonOverlappedPosition(
            System.Nullable<decimal> overlapGroup = null,
            System.Nullable<decimal> deltaStep = null,
            System.Nullable<decimal> repelFactor = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "moveToNonOverlappedPosition" },
                    overlapGroup,
                    deltaStep,
                    repelFactor
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }

        public async ValueTask<Vector2> getProjectedPosition(Vector3 position, Matrix worldMatrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getProjectedPosition" },
                    position,
                    worldMatrix
                }
            );
        }

        public async ValueTask<Vector3> getProjectedPositionWithZ(
            Vector3 position,
            Matrix worldMatrix
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getProjectedPositionWithZ" },
                    position,
                    worldMatrix
                }
            );
        }

        public async ValueTask pick(decimal x, decimal y, PointerInfoPre pi = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "pick" }, x, y, pi }
            );
        }

        public async ValueTask attach()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "attach" } }
            );
        }

        public async ValueTask registerClipboardEvents()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "registerClipboardEvents" } }
            );
        }

        public async ValueTask unRegisterClipboardEvents()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "unRegisterClipboardEvents" } }
            );
        }

        public async ValueTask attachToMesh(
            AbstractMesh mesh,
            System.Nullable<bool> supportPointerMove = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "attachToMesh" },
                    mesh,
                    supportPointerMove
                }
            );
        }

        public async ValueTask moveFocusToControl(Control control)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "moveFocusToControl" }, control }
            );
        }

        public async ValueTask<CachedEntity> serializeContent()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serializeContent" } }
            );
        }

        public async ValueTask parseSerializedObject(
            object serializedObject,
            System.Nullable<bool> scaleToSize = null,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "parseSerializedObject" },
                    serializedObject,
                    scaleToSize,
                    urlRewriter
                }
            );
        }

        public async ValueTask<AdvancedDynamicTexture> clone(
            string newName = null,
            AbstractMesh attachToMesh = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<AdvancedDynamicTexture>(
                entity => new AdvancedDynamicTexture() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" }, newName, attachToMesh }
            );
        }

        public async ValueTask parseContent(
            object serializedObject,
            System.Nullable<bool> scaleToSize = null,
            ActionResultCallback<ActionResultCallback<string, string>> urlRewriter = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "parseContent" },
                    serializedObject,
                    scaleToSize,
                    urlRewriter
                }
            );
        }

        public async ValueTask<AdvancedDynamicTexture> parseFromSnippetAsync(
            string snippetId,
            System.Nullable<bool> scaleToSize = null,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            return await EventHorizonBlazorInterop.TaskClass<AdvancedDynamicTexture>(
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

        public async ValueTask<AdvancedDynamicTexture> parseFromURLAsync(
            string url,
            System.Nullable<bool> scaleToSize = null,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            return await EventHorizonBlazorInterop.TaskClass<AdvancedDynamicTexture>(
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

        public async ValueTask scale(decimal ratio)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scale" }, ratio }
            );
        }

        public async ValueTask scaleTo(decimal width, decimal height)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scaleTo" }, width, height }
            );
        }

        public async ValueTask<bool> guiIsReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "guiIsReady" } }
            );
        }
        #endregion
    }
}
