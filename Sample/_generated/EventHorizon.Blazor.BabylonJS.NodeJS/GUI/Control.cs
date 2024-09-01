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

    [JsonConverter(typeof(CachedEntityConverter<Control>))]
    public class Control : CachedEntityObject, IAnimatable, IFocusableControl
    {
        #region Static Accessors

        public static decimal HORIZONTAL_ALIGNMENT_LEFT
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Control.HORIZONTAL_ALIGNMENT_LEFT"
                );
            }
        }

        public static decimal HORIZONTAL_ALIGNMENT_RIGHT
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Control.HORIZONTAL_ALIGNMENT_RIGHT"
                );
            }
        }

        public static decimal HORIZONTAL_ALIGNMENT_CENTER
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Control.HORIZONTAL_ALIGNMENT_CENTER"
                );
            }
        }

        public static decimal VERTICAL_ALIGNMENT_TOP
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Control.VERTICAL_ALIGNMENT_TOP"
                );
            }
        }

        public static decimal VERTICAL_ALIGNMENT_BOTTOM
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Control.VERTICAL_ALIGNMENT_BOTTOM"
                );
            }
        }

        public static decimal VERTICAL_ALIGNMENT_CENTER
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "GUI.Control.VERTICAL_ALIGNMENT_CENTER"
                );
            }
        }
        #endregion

        #region Static Properties

        public static bool AllowAlphaInheritance
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "GUI.Control.AllowAlphaInheritance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "GUI.Control.AllowAlphaInheritance",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static Control Parse(
            object serializedObject,
            AdvancedDynamicTexture host,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Control", "Parse" },
                    serializedObject,
                    host,
                    urlRewriter
                }
            );
        }

        public static CachedEntity AddHeader(
            Control control,
            string text,
            string size,
            object options
        )
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Control", "AddHeader" },
                    control,
                    text,
                    size,
                    options
                }
            );
        }
        #endregion

        #region Accessors

        public bool isReadOnly
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isReadOnly"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isReadOnly", value);
            }
        }

        private Measure __transformedMeasure;
        public Measure transformedMeasure
        {
            get
            {
                if (__transformedMeasure == null)
                {
                    __transformedMeasure = EventHorizonBlazorInterop.GetClass<Measure>(
                        this.___guid,
                        "transformedMeasure",
                        (entity) =>
                        {
                            return new Measure() { ___guid = entity.___guid };
                        }
                    );
                }
                return __transformedMeasure;
            }
        }

        public bool clipChildren
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "clipChildren"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "clipChildren", value);
            }
        }

        public bool clipContent
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "clipContent"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "clipContent", value);
            }
        }

        public decimal shadowOffsetX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowOffsetX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shadowOffsetX", value);
            }
        }

        public decimal shadowOffsetY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowOffsetY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shadowOffsetY", value);
            }
        }

        public decimal shadowBlur
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowBlur"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shadowBlur", value);
            }
        }

        public string shadowColor
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "shadowColor"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shadowColor", value);
            }
        }

        public string typeName
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "typeName"); }
        }

        private IAccessibilityTagCachedEntity __accessibilityTag;
        public IAccessibilityTagCachedEntity accessibilityTag
        {
            get
            {
                if (__accessibilityTag == null)
                {
                    __accessibilityTag =
                        EventHorizonBlazorInterop.GetClass<IAccessibilityTagCachedEntity>(
                            this.___guid,
                            "accessibilityTag",
                            (entity) =>
                            {
                                return new IAccessibilityTagCachedEntity()
                                {
                                    ___guid = entity.___guid
                                };
                            }
                        );
                }
                return __accessibilityTag;
            }
            set
            {
                __accessibilityTag = null;
                EventHorizonBlazorInterop.Set(this.___guid, "accessibilityTag", value);
            }
        }

        private AdvancedDynamicTexture __host;
        public AdvancedDynamicTexture host
        {
            get
            {
                if (__host == null)
                {
                    __host = EventHorizonBlazorInterop.GetClass<AdvancedDynamicTexture>(
                        this.___guid,
                        "host",
                        (entity) =>
                        {
                            return new AdvancedDynamicTexture() { ___guid = entity.___guid };
                        }
                    );
                }
                return __host;
            }
        }

        public CachedEntity fontOffset
        {
            get { return EventHorizonBlazorInterop.Get<CachedEntity>(this.___guid, "fontOffset"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "fontOffset", value);
            }
        }

        public decimal alpha
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "alpha"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "alpha", value);
            }
        }

        public decimal highlightLineWidth
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "highlightLineWidth");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "highlightLineWidth", value);
            }
        }

        public bool isHighlighted
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isHighlighted"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isHighlighted", value);
            }
        }

        public string highlightColor
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "highlightColor"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "highlightColor", value);
            }
        }

        public decimal scaleX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "scaleX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "scaleX", value);
            }
        }

        public decimal scaleY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "scaleY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "scaleY", value);
            }
        }

        public decimal rotation
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "rotation"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "rotation", value);
            }
        }

        public decimal transformCenterY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "transformCenterY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "transformCenterY", value);
            }
        }

        public decimal transformCenterX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "transformCenterX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "transformCenterX", value);
            }
        }

        public decimal horizontalAlignment
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "horizontalAlignment");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "horizontalAlignment", value);
            }
        }

        public decimal verticalAlignment
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "verticalAlignment");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "verticalAlignment", value);
            }
        }

        public decimal fixedRatio
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "fixedRatio"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "fixedRatio", value);
            }
        }

        public bool fixedRatioMasterIsWidth
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "fixedRatioMasterIsWidth");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "fixedRatioMasterIsWidth", value);
            }
        }

        public string width
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "width"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "width", value);
            }
        }

        public decimal widthInPixels
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "widthInPixels"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "widthInPixels", value);
            }
        }

        public string height
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "height"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "height", value);
            }
        }

        public decimal heightInPixels
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "heightInPixels"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "heightInPixels", value);
            }
        }

        public string fontFamily
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "fontFamily"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "fontFamily", value);
            }
        }

        public string fontStyle
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "fontStyle"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "fontStyle", value);
            }
        }

        public string fontWeight
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "fontWeight"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "fontWeight", value);
            }
        }

        private Style __style;
        public Style style
        {
            get
            {
                if (__style == null)
                {
                    __style = EventHorizonBlazorInterop.GetClass<Style>(
                        this.___guid,
                        "style",
                        (entity) =>
                        {
                            return new Style() { ___guid = entity.___guid };
                        }
                    );
                }
                return __style;
            }
            set
            {
                __style = null;
                EventHorizonBlazorInterop.Set(this.___guid, "style", value);
            }
        }

        public decimal fontSizeInPixels
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "fontSizeInPixels"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "fontSizeInPixels", value);
            }
        }

        public string fontSize
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "fontSize"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "fontSize", value);
            }
        }

        public string color
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "color"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "color", value);
            }
        }

        private BaseGradient __gradient;
        public BaseGradient gradient
        {
            get
            {
                if (__gradient == null)
                {
                    __gradient = EventHorizonBlazorInterop.GetClass<BaseGradient>(
                        this.___guid,
                        "gradient",
                        (entity) =>
                        {
                            return new BaseGradient() { ___guid = entity.___guid };
                        }
                    );
                }
                return __gradient;
            }
            set
            {
                __gradient = null;
                EventHorizonBlazorInterop.Set(this.___guid, "gradient", value);
            }
        }

        public decimal zIndex
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "zIndex"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "zIndex", value);
            }
        }

        public bool notRenderable
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "notRenderable"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "notRenderable", value);
            }
        }

        public bool isVisible
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isVisible"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isVisible", value);
            }
        }

        public bool isDirty
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDirty"); }
        }

        private TransformNode __linkedMesh;
        public TransformNode linkedMesh
        {
            get
            {
                if (__linkedMesh == null)
                {
                    __linkedMesh = EventHorizonBlazorInterop.GetClass<TransformNode>(
                        this.___guid,
                        "linkedMesh",
                        (entity) =>
                        {
                            return new TransformNode() { ___guid = entity.___guid };
                        }
                    );
                }
                return __linkedMesh;
            }
        }

        public bool descendantsOnlyPadding
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "descendantsOnlyPadding");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "descendantsOnlyPadding", value);
            }
        }

        public string paddingLeft
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "paddingLeft"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "paddingLeft", value);
            }
        }

        public decimal paddingLeftInPixels
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "paddingLeftInPixels");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "paddingLeftInPixels", value);
            }
        }

        public string paddingRight
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "paddingRight"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "paddingRight", value);
            }
        }

        public decimal paddingRightInPixels
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "paddingRightInPixels");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "paddingRightInPixels", value);
            }
        }

        public string paddingTop
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "paddingTop"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "paddingTop", value);
            }
        }

        public decimal paddingTopInPixels
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "paddingTopInPixels");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "paddingTopInPixels", value);
            }
        }

        public string paddingBottom
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "paddingBottom"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "paddingBottom", value);
            }
        }

        public decimal paddingBottomInPixels
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "paddingBottomInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "paddingBottomInPixels", value);
            }
        }

        public string left
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "left"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "left", value);
            }
        }

        public decimal leftInPixels
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "leftInPixels"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "leftInPixels", value);
            }
        }

        public string top
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "top"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "top", value);
            }
        }

        public decimal topInPixels
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "topInPixels"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "topInPixels", value);
            }
        }

        public string linkOffsetX
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "linkOffsetX"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "linkOffsetX", value);
            }
        }

        public decimal linkOffsetXInPixels
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "linkOffsetXInPixels");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "linkOffsetXInPixels", value);
            }
        }

        public string linkOffsetY
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "linkOffsetY"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "linkOffsetY", value);
            }
        }

        public decimal linkOffsetYInPixels
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "linkOffsetYInPixels");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "linkOffsetYInPixels", value);
            }
        }

        public decimal centerX
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "centerX"); }
        }

        public decimal centerY
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "centerY"); }
        }

        public bool isEnabled
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isEnabled"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isEnabled", value);
            }
        }

        public string disabledColor
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "disabledColor"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disabledColor", value);
            }
        }

        public string disabledColorItem
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "disabledColorItem"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "disabledColorItem", value);
            }
        }

        public string focusedColor
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "focusedColor"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "focusedColor", value);
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

        private Container __parent;
        public Container parent
        {
            get
            {
                if (__parent == null)
                {
                    __parent = EventHorizonBlazorInterop.GetClass<Container>(
                        this.___guid,
                        "parent",
                        (entity) =>
                        {
                            return new Container() { ___guid = entity.___guid };
                        }
                    );
                }
                return __parent;
            }
            set
            {
                __parent = null;
                EventHorizonBlazorInterop.Set(this.___guid, "parent", value);
            }
        }

        // onEnabledStateChangedObservable is not supported by the platform yet


        public decimal uniqueId
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "uniqueId"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "uniqueId", value);
            }
        }

        public CachedEntity metadata
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "metadata",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "metadata", value);
            }
        }

        public bool isHitTestVisible
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isHitTestVisible"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isHitTestVisible", value);
            }
        }

        public bool isPointerBlocker
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isPointerBlocker"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isPointerBlocker", value);
            }
        }

        public bool isFocusInvisible
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isFocusInvisible"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isFocusInvisible", value);
            }
        }

        public bool useBitmapCache
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "useBitmapCache"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useBitmapCache", value);
            }
        }

        public string hoverCursor
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "hoverCursor"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "hoverCursor", value);
            }
        }

        private Observable<IAccessibilityTagCachedEntity> __onAccessibilityTagChangedObservable;
        public Observable<IAccessibilityTagCachedEntity> onAccessibilityTagChangedObservable
        {
            get
            {
                if (__onAccessibilityTagChangedObservable == null)
                {
                    __onAccessibilityTagChangedObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<IAccessibilityTagCachedEntity>
                    >(
                        this.___guid,
                        "onAccessibilityTagChangedObservable",
                        (entity) =>
                        {
                            return new Observable<IAccessibilityTagCachedEntity>()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
                }
                return __onAccessibilityTagChangedObservable;
            }
            set
            {
                __onAccessibilityTagChangedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAccessibilityTagChangedObservable",
                    value
                );
            }
        }

        private Observable<Vector2> __onWheelObservable;
        public Observable<Vector2> onWheelObservable
        {
            get
            {
                if (__onWheelObservable == null)
                {
                    __onWheelObservable = EventHorizonBlazorInterop.GetClass<Observable<Vector2>>(
                        this.___guid,
                        "onWheelObservable",
                        (entity) =>
                        {
                            return new Observable<Vector2>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onWheelObservable;
            }
            set
            {
                __onWheelObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onWheelObservable", value);
            }
        }

        private Observable<Vector2> __onPointerMoveObservable;
        public Observable<Vector2> onPointerMoveObservable
        {
            get
            {
                if (__onPointerMoveObservable == null)
                {
                    __onPointerMoveObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Vector2>
                    >(
                        this.___guid,
                        "onPointerMoveObservable",
                        (entity) =>
                        {
                            return new Observable<Vector2>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onPointerMoveObservable;
            }
            set
            {
                __onPointerMoveObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onPointerMoveObservable", value);
            }
        }

        private Observable<Control> __onPointerOutObservable;
        public Observable<Control> onPointerOutObservable
        {
            get
            {
                if (__onPointerOutObservable == null)
                {
                    __onPointerOutObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Control>
                    >(
                        this.___guid,
                        "onPointerOutObservable",
                        (entity) =>
                        {
                            return new Observable<Control>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onPointerOutObservable;
            }
            set
            {
                __onPointerOutObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onPointerOutObservable", value);
            }
        }

        private Observable<Vector2WithInfo> __onPointerDownObservable;
        public Observable<Vector2WithInfo> onPointerDownObservable
        {
            get
            {
                if (__onPointerDownObservable == null)
                {
                    __onPointerDownObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Vector2WithInfo>
                    >(
                        this.___guid,
                        "onPointerDownObservable",
                        (entity) =>
                        {
                            return new Observable<Vector2WithInfo>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onPointerDownObservable;
            }
            set
            {
                __onPointerDownObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onPointerDownObservable", value);
            }
        }

        private Observable<Vector2WithInfo> __onPointerUpObservable;
        public Observable<Vector2WithInfo> onPointerUpObservable
        {
            get
            {
                if (__onPointerUpObservable == null)
                {
                    __onPointerUpObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Vector2WithInfo>
                    >(
                        this.___guid,
                        "onPointerUpObservable",
                        (entity) =>
                        {
                            return new Observable<Vector2WithInfo>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onPointerUpObservable;
            }
            set
            {
                __onPointerUpObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onPointerUpObservable", value);
            }
        }

        private Observable<Vector2WithInfo> __onPointerClickObservable;
        public Observable<Vector2WithInfo> onPointerClickObservable
        {
            get
            {
                if (__onPointerClickObservable == null)
                {
                    __onPointerClickObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Vector2WithInfo>
                    >(
                        this.___guid,
                        "onPointerClickObservable",
                        (entity) =>
                        {
                            return new Observable<Vector2WithInfo>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onPointerClickObservable;
            }
            set
            {
                __onPointerClickObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onPointerClickObservable", value);
            }
        }

        private Observable<Control> __onEnterPressedObservable;
        public Observable<Control> onEnterPressedObservable
        {
            get
            {
                if (__onEnterPressedObservable == null)
                {
                    __onEnterPressedObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Control>
                    >(
                        this.___guid,
                        "onEnterPressedObservable",
                        (entity) =>
                        {
                            return new Observable<Control>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onEnterPressedObservable;
            }
            set
            {
                __onEnterPressedObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onEnterPressedObservable", value);
            }
        }

        private Observable<Control> __onPointerEnterObservable;
        public Observable<Control> onPointerEnterObservable
        {
            get
            {
                if (__onPointerEnterObservable == null)
                {
                    __onPointerEnterObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Control>
                    >(
                        this.___guid,
                        "onPointerEnterObservable",
                        (entity) =>
                        {
                            return new Observable<Control>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onPointerEnterObservable;
            }
            set
            {
                __onPointerEnterObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onPointerEnterObservable", value);
            }
        }

        private Observable<Control> __onDirtyObservable;
        public Observable<Control> onDirtyObservable
        {
            get
            {
                if (__onDirtyObservable == null)
                {
                    __onDirtyObservable = EventHorizonBlazorInterop.GetClass<Observable<Control>>(
                        this.___guid,
                        "onDirtyObservable",
                        (entity) =>
                        {
                            return new Observable<Control>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onDirtyObservable;
            }
            set
            {
                __onDirtyObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onDirtyObservable", value);
            }
        }

        private Observable<Control> __onBeforeDrawObservable;
        public Observable<Control> onBeforeDrawObservable
        {
            get
            {
                if (__onBeforeDrawObservable == null)
                {
                    __onBeforeDrawObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Control>
                    >(
                        this.___guid,
                        "onBeforeDrawObservable",
                        (entity) =>
                        {
                            return new Observable<Control>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onBeforeDrawObservable;
            }
            set
            {
                __onBeforeDrawObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onBeforeDrawObservable", value);
            }
        }

        private Observable<Control> __onAfterDrawObservable;
        public Observable<Control> onAfterDrawObservable
        {
            get
            {
                if (__onAfterDrawObservable == null)
                {
                    __onAfterDrawObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<Control>
                    >(
                        this.___guid,
                        "onAfterDrawObservable",
                        (entity) =>
                        {
                            return new Observable<Control>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onAfterDrawObservable;
            }
            set
            {
                __onAfterDrawObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onAfterDrawObservable", value);
            }
        }

        private Observable<Control> __onDisposeObservable;
        public Observable<Control> onDisposeObservable
        {
            get
            {
                if (__onDisposeObservable == null)
                {
                    __onDisposeObservable = EventHorizonBlazorInterop.GetClass<Observable<Control>>(
                        this.___guid,
                        "onDisposeObservable",
                        (entity) =>
                        {
                            return new Observable<Control>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onDisposeObservable;
            }
            set
            {
                __onDisposeObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onDisposeObservable", value);
            }
        }

        // onIsVisibleChangedObservable is not supported by the platform yet


        public bool isSerializable
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "isSerializable"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "isSerializable", value);
            }
        }

        public decimal overlapGroup
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "overlapGroup"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "overlapGroup", value);
            }
        }

        public decimal overlapDeltaMultiplier
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "overlapDeltaMultiplier"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "overlapDeltaMultiplier", value);
            }
        }

        public Animation[] animations
        {
            get
            {
                return EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "animations", value);
            }
        }

        public decimal tabIndex
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "tabIndex"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "tabIndex", value);
            }
        }

        private Observable<Control> __onFocusObservable;
        public Observable<Control> onFocusObservable
        {
            get
            {
                if (__onFocusObservable == null)
                {
                    __onFocusObservable = EventHorizonBlazorInterop.GetClass<Observable<Control>>(
                        this.___guid,
                        "onFocusObservable",
                        (entity) =>
                        {
                            return new Observable<Control>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onFocusObservable;
            }
            set
            {
                __onFocusObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onFocusObservable", value);
            }
        }

        private Observable<Control> __onBlurObservable;
        public Observable<Control> onBlurObservable
        {
            get
            {
                if (__onBlurObservable == null)
                {
                    __onBlurObservable = EventHorizonBlazorInterop.GetClass<Observable<Control>>(
                        this.___guid,
                        "onBlurObservable",
                        (entity) =>
                        {
                            return new Observable<Control>() { ___guid = entity.___guid };
                        }
                    );
                }
                return __onBlurObservable;
            }
            set
            {
                __onBlurObservable = null;
                EventHorizonBlazorInterop.Set(this.___guid, "onBlurObservable", value);
            }
        }

        private Observable<IKeyboardEventCachedEntity> __onKeyboardEventProcessedObservable;
        public Observable<IKeyboardEventCachedEntity> onKeyboardEventProcessedObservable
        {
            get
            {
                if (__onKeyboardEventProcessedObservable == null)
                {
                    __onKeyboardEventProcessedObservable = EventHorizonBlazorInterop.GetClass<
                        Observable<IKeyboardEventCachedEntity>
                    >(
                        this.___guid,
                        "onKeyboardEventProcessedObservable",
                        (entity) =>
                        {
                            return new Observable<IKeyboardEventCachedEntity>()
                            {
                                ___guid = entity.___guid
                            };
                        }
                    );
                }
                return __onKeyboardEventProcessedObservable;
            }
            set
            {
                __onKeyboardEventProcessedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onKeyboardEventProcessedObservable",
                    value
                );
            }
        }
        #endregion

        #region Constructor
        public Control()
            : base() { }

        public Control(ICachedEntity entity)
            : base(entity) { }

        public Control(string name = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Control" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public void onBlur()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "onBlur" } }
            );
        }

        public void onFocus()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "onFocus" } }
            );
        }

        public Control[] keepsFocusWith()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "keepsFocusWith" } }
            );
        }

        public void focus()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "focus" } }
            );
        }

        public void blur()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "blur" } }
            );
        }

        public void processKeyboard(IKeyboardEvent evt)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "processKeyboard" }, evt }
            );
        }

        public Control getAscendantOfClass(string className)
        {
            return EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAscendantOfClass" }, className }
            );
        }

        public void markAsDirty(System.Nullable<bool> force = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "markAsDirty" }, force }
            );
        }

        public void markAllAsDirty()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "markAllAsDirty" } }
            );
        }

        public bool isAscendant(Control container)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isAscendant" }, container }
            );
        }

        public Vector2 getLocalCoordinates(Vector2 globalCoordinates)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalCoordinates" },
                    globalCoordinates
                }
            );
        }

        public Control getLocalCoordinatesToRef(Vector2 globalCoordinates, Vector2 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalCoordinatesToRef" },
                    globalCoordinates,
                    result
                }
            );
        }

        public Vector2 getParentLocalCoordinates(Vector2 globalCoordinates)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getParentLocalCoordinates" },
                    globalCoordinates
                }
            );
        }

        public void moveToVector3(Vector3 position, Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "moveToVector3" }, position, scene }
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

        public void linkWithMesh(TransformNode mesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "linkWithMesh" }, mesh }
            );
        }

        public void setPadding(
            string paddingTop,
            string paddingRight = null,
            string paddingBottom = null,
            string paddingLeft = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPadding" },
                    paddingTop,
                    paddingRight,
                    paddingBottom,
                    paddingLeft
                }
            );
        }

        public void setPaddingInPixels(
            decimal paddingTop,
            System.Nullable<decimal> paddingRight = null,
            System.Nullable<decimal> paddingBottom = null,
            System.Nullable<decimal> paddingLeft = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPaddingInPixels" },
                    paddingTop,
                    paddingRight,
                    paddingBottom,
                    paddingLeft
                }
            );
        }

        public void invalidateRect()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "invalidateRect" } }
            );
        }

        public bool contains(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "contains" }, x, y }
            );
        }

        public bool isDimensionFullyDefined(object dim)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isDimensionFullyDefined" }, dim }
            );
        }

        public ValueAndUnit getDimension(object dim)
        {
            return EventHorizonBlazorInterop.FuncClass<ValueAndUnit>(
                entity => new ValueAndUnit() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getDimension" }, dim }
            );
        }

        public Control clone(AdvancedDynamicTexture host = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" }, host }
            );
        }

        public Control parse(
            object serializedObject,
            AdvancedDynamicTexture host = null,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "parse" },
                    serializedObject,
                    host,
                    urlRewriter
                }
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
