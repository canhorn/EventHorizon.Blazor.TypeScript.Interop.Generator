/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Control : CachedEntityObject
    {
        #region Static Accessors
        
        public static decimal HORIZONTAL_ALIGNMENT_LEFT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "GUI.Control.HORIZONTAL_ALIGNMENT_LEFT"
                );
            }
        }

        
        public static decimal HORIZONTAL_ALIGNMENT_RIGHT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "GUI.Control.HORIZONTAL_ALIGNMENT_RIGHT"
                );
            }
        }

        
        public static decimal HORIZONTAL_ALIGNMENT_CENTER
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "GUI.Control.HORIZONTAL_ALIGNMENT_CENTER"
                );
            }
        }

        
        public static decimal VERTICAL_ALIGNMENT_TOP
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "GUI.Control.VERTICAL_ALIGNMENT_TOP"
                );
            }
        }

        
        public static decimal VERTICAL_ALIGNMENT_BOTTOM
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "GUI.Control.VERTICAL_ALIGNMENT_BOTTOM"
                );
            }
        }

        
        public static decimal VERTICAL_ALIGNMENT_CENTER
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "GUI.Control.AllowAlphaInheritance"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "GUI.Control.AllowAlphaInheritance",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        #region AddHeader TODO: Get Comments as metadata identification
        private static bool IsAddHeaderEnabled = false;
        private static readonly IDictionary<string, Func<Task>> AddHeaderActionMap = new Dictionary<string, Func<Task>>();

        public static string AddHeader(
            Func<Task> callback
        )
        {
            SetupAddHeaderStaticLoop();

            var handle = Guid.NewGuid().ToString();
            AddHeaderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static void SetupAddHeaderStaticLoop()
        {
            if (IsAddHeaderEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.GUI.Control.AddHeader",
                "CallAddHeaderStaticActions"
            );
            IsAddHeaderEnabled = true;
        }

        [JSInvokable]
        public static async Task CallAddHeaderStaticActions()
        {
            foreach (var action in AddHeaderActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion

        #region Accessors
        
        public decimal shadowOffsetX
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "shadowOffsetX"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "shadowOffsetX",
                    value
                );
            }
        }

        
        public decimal shadowOffsetY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "shadowOffsetY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "shadowOffsetY",
                    value
                );
            }
        }

        
        public decimal shadowBlur
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "shadowBlur"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "shadowBlur",
                    value
                );
            }
        }

        
        public string shadowColor
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "shadowColor"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "shadowColor",
                    value
                );
            }
        }

        
        public string typeName
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "typeName"
                );
            }
        }

        private AdvancedDynamicTexture __host;
        public AdvancedDynamicTexture host
        {
            get
            {
            if(__host == null)
            {
                __host = EventHorizonBlazorInteropt.GetClass<AdvancedDynamicTexture>(
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
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "fontOffset"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "fontOffset",
                    value
                );
            }
        }

        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
        public bool isHighlighted
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isHighlighted"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isHighlighted",
                    value
                );
            }
        }

        
        public decimal scaleX
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "scaleX"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "scaleX",
                    value
                );
            }
        }

        
        public decimal scaleY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "scaleY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "scaleY",
                    value
                );
            }
        }

        
        public decimal rotation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "rotation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "rotation",
                    value
                );
            }
        }

        
        public decimal transformCenterY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "transformCenterY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "transformCenterY",
                    value
                );
            }
        }

        
        public decimal transformCenterX
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "transformCenterX"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "transformCenterX",
                    value
                );
            }
        }

        
        public decimal horizontalAlignment
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "horizontalAlignment"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "horizontalAlignment",
                    value
                );
            }
        }

        
        public decimal verticalAlignment
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "verticalAlignment"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "verticalAlignment",
                    value
                );
            }
        }

        
        public string width
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal widthInPixels
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "widthInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "widthInPixels",
                    value
                );
            }
        }

        
        public string height
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public decimal heightInPixels
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "heightInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "heightInPixels",
                    value
                );
            }
        }

        
        public string fontFamily
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "fontFamily"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "fontFamily",
                    value
                );
            }
        }

        
        public string fontStyle
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "fontStyle"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "fontStyle",
                    value
                );
            }
        }

        
        public string fontWeight
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "fontWeight"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "fontWeight",
                    value
                );
            }
        }

        private Style __style;
        public Style style
        {
            get
            {
            if(__style == null)
            {
                __style = EventHorizonBlazorInteropt.GetClass<Style>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "style",
                    value
                );
            }
        }

        
        public decimal fontSizeInPixels
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "fontSizeInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "fontSizeInPixels",
                    value
                );
            }
        }

        
        public string fontSize
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "fontSize"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "fontSize",
                    value
                );
            }
        }

        
        public string color
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "color"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        
        public decimal zIndex
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "zIndex"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "zIndex",
                    value
                );
            }
        }

        
        public bool notRenderable
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "notRenderable"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "notRenderable",
                    value
                );
            }
        }

        
        public bool isVisible
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isVisible"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isVisible",
                    value
                );
            }
        }

        
        public bool isDirty
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isDirty"
                );
            }
        }

        private AbstractMesh __linkedMesh;
        public AbstractMesh linkedMesh
        {
            get
            {
            if(__linkedMesh == null)
            {
                __linkedMesh = EventHorizonBlazorInteropt.GetClass<AbstractMesh>(
                    this.___guid,
                    "linkedMesh",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __linkedMesh;
            }
        }

        
        public string paddingLeft
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "paddingLeft"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "paddingLeft",
                    value
                );
            }
        }

        
        public decimal paddingLeftInPixels
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "paddingLeftInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "paddingLeftInPixels",
                    value
                );
            }
        }

        
        public string paddingRight
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "paddingRight"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "paddingRight",
                    value
                );
            }
        }

        
        public decimal paddingRightInPixels
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "paddingRightInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "paddingRightInPixels",
                    value
                );
            }
        }

        
        public string paddingTop
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "paddingTop"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "paddingTop",
                    value
                );
            }
        }

        
        public decimal paddingTopInPixels
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "paddingTopInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "paddingTopInPixels",
                    value
                );
            }
        }

        
        public string paddingBottom
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "paddingBottom"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "paddingBottom",
                    value
                );
            }
        }

        
        public decimal paddingBottomInPixels
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "paddingBottomInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "paddingBottomInPixels",
                    value
                );
            }
        }

        
        public string left
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "left"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "left",
                    value
                );
            }
        }

        
        public decimal leftInPixels
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "leftInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "leftInPixels",
                    value
                );
            }
        }

        
        public string top
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "top"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "top",
                    value
                );
            }
        }

        
        public decimal topInPixels
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "topInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "topInPixels",
                    value
                );
            }
        }

        
        public string linkOffsetX
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "linkOffsetX"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "linkOffsetX",
                    value
                );
            }
        }

        
        public decimal linkOffsetXInPixels
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "linkOffsetXInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "linkOffsetXInPixels",
                    value
                );
            }
        }

        
        public string linkOffsetY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "linkOffsetY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "linkOffsetY",
                    value
                );
            }
        }

        
        public decimal linkOffsetYInPixels
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "linkOffsetYInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "linkOffsetYInPixels",
                    value
                );
            }
        }

        
        public decimal centerX
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "centerX"
                );
            }
        }

        
        public decimal centerY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "centerY"
                );
            }
        }

        
        public bool isEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isEnabled",
                    value
                );
            }
        }

        
        public string disabledColor
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "disabledColor"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "disabledColor",
                    value
                );
            }
        }

        
        public string disabledColorItem
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "disabledColorItem"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "disabledColorItem",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        private Container __parent;
        public Container parent
        {
            get
            {
            if(__parent == null)
            {
                __parent = EventHorizonBlazorInteropt.GetClass<Container>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "parent",
                    value
                );
            }
        }

        
        public decimal uniqueId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "uniqueId",
                    value
                );
            }
        }

        
        public CachedEntity metadata
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "metadata"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "metadata",
                    value
                );
            }
        }

        
        public bool isHitTestVisible
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isHitTestVisible"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isHitTestVisible",
                    value
                );
            }
        }

        
        public bool isPointerBlocker
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isPointerBlocker"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isPointerBlocker",
                    value
                );
            }
        }

        
        public bool isFocusInvisible
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isFocusInvisible"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isFocusInvisible",
                    value
                );
            }
        }

        
        public bool clipChildren
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "clipChildren"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "clipChildren",
                    value
                );
            }
        }

        
        public bool clipContent
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "clipContent"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "clipContent",
                    value
                );
            }
        }

        
        public bool useBitmapCache
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useBitmapCache"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useBitmapCache",
                    value
                );
            }
        }

        
        public string hoverCursor
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "hoverCursor"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "hoverCursor",
                    value
                );
            }
        }

        private Observable<Vector2> __onWheelObservable;
        public Observable<Vector2> onWheelObservable
        {
            get
            {
            if(__onWheelObservable == null)
            {
                __onWheelObservable = EventHorizonBlazorInteropt.GetClass<Observable<Vector2>>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onWheelObservable",
                    value
                );
            }
        }

        private Observable<Vector2> __onPointerMoveObservable;
        public Observable<Vector2> onPointerMoveObservable
        {
            get
            {
            if(__onPointerMoveObservable == null)
            {
                __onPointerMoveObservable = EventHorizonBlazorInteropt.GetClass<Observable<Vector2>>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onPointerMoveObservable",
                    value
                );
            }
        }

        private Observable<Control> __onPointerOutObservable;
        public Observable<Control> onPointerOutObservable
        {
            get
            {
            if(__onPointerOutObservable == null)
            {
                __onPointerOutObservable = EventHorizonBlazorInteropt.GetClass<Observable<Control>>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onPointerOutObservable",
                    value
                );
            }
        }

        private Observable<Vector2WithInfo> __onPointerDownObservable;
        public Observable<Vector2WithInfo> onPointerDownObservable
        {
            get
            {
            if(__onPointerDownObservable == null)
            {
                __onPointerDownObservable = EventHorizonBlazorInteropt.GetClass<Observable<Vector2WithInfo>>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onPointerDownObservable",
                    value
                );
            }
        }

        private Observable<Vector2WithInfo> __onPointerUpObservable;
        public Observable<Vector2WithInfo> onPointerUpObservable
        {
            get
            {
            if(__onPointerUpObservable == null)
            {
                __onPointerUpObservable = EventHorizonBlazorInteropt.GetClass<Observable<Vector2WithInfo>>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onPointerUpObservable",
                    value
                );
            }
        }

        private Observable<Vector2WithInfo> __onPointerClickObservable;
        public Observable<Vector2WithInfo> onPointerClickObservable
        {
            get
            {
            if(__onPointerClickObservable == null)
            {
                __onPointerClickObservable = EventHorizonBlazorInteropt.GetClass<Observable<Vector2WithInfo>>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onPointerClickObservable",
                    value
                );
            }
        }

        private Observable<Control> __onPointerEnterObservable;
        public Observable<Control> onPointerEnterObservable
        {
            get
            {
            if(__onPointerEnterObservable == null)
            {
                __onPointerEnterObservable = EventHorizonBlazorInteropt.GetClass<Observable<Control>>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onPointerEnterObservable",
                    value
                );
            }
        }

        private Observable<Control> __onDirtyObservable;
        public Observable<Control> onDirtyObservable
        {
            get
            {
            if(__onDirtyObservable == null)
            {
                __onDirtyObservable = EventHorizonBlazorInteropt.GetClass<Observable<Control>>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onDirtyObservable",
                    value
                );
            }
        }

        private Observable<Control> __onBeforeDrawObservable;
        public Observable<Control> onBeforeDrawObservable
        {
            get
            {
            if(__onBeforeDrawObservable == null)
            {
                __onBeforeDrawObservable = EventHorizonBlazorInteropt.GetClass<Observable<Control>>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeDrawObservable",
                    value
                );
            }
        }

        private Observable<Control> __onAfterDrawObservable;
        public Observable<Control> onAfterDrawObservable
        {
            get
            {
            if(__onAfterDrawObservable == null)
            {
                __onAfterDrawObservable = EventHorizonBlazorInteropt.GetClass<Observable<Control>>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterDrawObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Control() : base() { } 

        public Control(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Control(
            string name = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "GUI", "Control" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public Control getAscendantOfClass(string className)
        {
            return EventHorizonBlazorInteropt.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAscendantOfClass" }, className
                }
            );
        }

        public bool isAscendant(Control container)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isAscendant" }, container
                }
            );
        }

        public Vector2 getLocalCoordinates(Vector2 globalCoordinates)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLocalCoordinates" }, globalCoordinates
                }
            );
        }

        public Control getLocalCoordinatesToRef(Vector2 globalCoordinates, Vector2 result)
        {
            return EventHorizonBlazorInteropt.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLocalCoordinatesToRef" }, globalCoordinates, result
                }
            );
        }

        public Vector2 getParentLocalCoordinates(Vector2 globalCoordinates)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getParentLocalCoordinates" }, globalCoordinates
                }
            );
        }

        public void moveToVector3(Vector3 position, Scene scene)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "moveToVector3" }, position, scene
                }
            );
        }

        #region getDescendantsToRef TODO: Get Comments as metadata identification
        private bool _isGetDescendantsToRefEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getDescendantsToRefActionMap = new Dictionary<string, Func<Task>>();

        public string getDescendantsToRef(
            Func<Task> callback
        )
        {
            SetupGetDescendantsToRefLoop();

            var handle = Guid.NewGuid().ToString();
            _getDescendantsToRefActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupGetDescendantsToRefLoop()
        {
            if (_isGetDescendantsToRefEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "getDescendantsToRef",
                "CallGetDescendantsToRefActions",
                _invokableReference
            );
            _isGetDescendantsToRefEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetDescendantsToRefActions()
        {
            foreach (var action in _getDescendantsToRefActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region getDescendants TODO: Get Comments as metadata identification
        private bool _isGetDescendantsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getDescendantsActionMap = new Dictionary<string, Func<Task>>();

        public string getDescendants(
            Func<Task> callback
        )
        {
            SetupGetDescendantsLoop();

            var handle = Guid.NewGuid().ToString();
            _getDescendantsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupGetDescendantsLoop()
        {
            if (_isGetDescendantsEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "getDescendants",
                "CallGetDescendantsActions",
                _invokableReference
            );
            _isGetDescendantsEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetDescendantsActions()
        {
            foreach (var action in _getDescendantsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void linkWithMesh(AbstractMesh mesh)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "linkWithMesh" }, mesh
                }
            );
        }

        public bool contains(decimal x, decimal y)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "contains" }, x, y
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}