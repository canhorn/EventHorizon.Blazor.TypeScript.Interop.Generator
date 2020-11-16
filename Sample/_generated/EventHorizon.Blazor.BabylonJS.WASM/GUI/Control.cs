/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Control>))]
    public class Control : CachedEntityObject
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

        public static bool AddHeader_Remove(
            string handle
        )
        {
            return AddHeaderActionMap.Remove(
                handle
            );
        }

        private static void SetupAddHeaderStaticLoop()
        {
            if (IsAddHeaderEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.AssemblyFuncCallback(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowOffsetX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowOffsetY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowBlur"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "shadowColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
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
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "fontOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isHighlighted"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scaleY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "transformCenterY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "transformCenterX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "horizontalAlignment"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "verticalAlignment"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "widthInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "heightInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fontFamily"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fontStyle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fontWeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fontSizeInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fontSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "color"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "zIndex"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "notRenderable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isVisible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isDirty"
                );
            }
        }

        private TransformNode __linkedMesh;
        public TransformNode linkedMesh
        {
            get
            {
            if(__linkedMesh == null)
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

        
        public string paddingLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "paddingLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "paddingLeftInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "paddingRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "paddingRightInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "paddingTop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "paddingTopInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "paddingBottom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "paddingBottomInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "left"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "leftInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "top"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "topInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "linkOffsetX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "linkOffsetXInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "linkOffsetY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "linkOffsetYInPixels"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "centerX"
                );
            }
        }

        
        public decimal centerY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "centerY"
                );
            }
        }

        
        public bool isEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "disabledColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "disabledColorItem"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isHitTestVisible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isPointerBlocker"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isFocusInvisible"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "clipChildren"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "clipContent"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useBitmapCache"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "hoverCursor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                EventHorizonBlazorInterop.Set(
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
                __onPointerMoveObservable = EventHorizonBlazorInterop.GetClass<Observable<Vector2>>(
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
                EventHorizonBlazorInterop.Set(
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
                __onPointerOutObservable = EventHorizonBlazorInterop.GetClass<Observable<Control>>(
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
                EventHorizonBlazorInterop.Set(
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
                __onPointerDownObservable = EventHorizonBlazorInterop.GetClass<Observable<Vector2WithInfo>>(
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
                EventHorizonBlazorInterop.Set(
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
                __onPointerUpObservable = EventHorizonBlazorInterop.GetClass<Observable<Vector2WithInfo>>(
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
                EventHorizonBlazorInterop.Set(
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
                __onPointerClickObservable = EventHorizonBlazorInterop.GetClass<Observable<Vector2WithInfo>>(
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
                EventHorizonBlazorInterop.Set(
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
                __onPointerEnterObservable = EventHorizonBlazorInterop.GetClass<Observable<Control>>(
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
                EventHorizonBlazorInterop.Set(
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
                EventHorizonBlazorInterop.Set(
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
                __onBeforeDrawObservable = EventHorizonBlazorInterop.GetClass<Observable<Control>>(
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
                EventHorizonBlazorInterop.Set(
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
                __onAfterDrawObservable = EventHorizonBlazorInterop.GetClass<Observable<Control>>(
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
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterDrawObservable",
                    value
                );
            }
        }

        private Observable<Control> __onDisposeObservable;
        public Observable<Control> onDisposeObservable
        {
            get
            {
            if(__onDisposeObservable == null)
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
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
            }
        }

        
        public decimal fixedRatio
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fixedRatio"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fixedRatio",
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
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public Control getAscendantOfClass(string className)
        {
            return EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAscendantOfClass" }, className
                }
            );
        }

        public bool isAscendant(Control container)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isAscendant" }, container
                }
            );
        }

        public Vector2 getLocalCoordinates(Vector2 globalCoordinates)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalCoordinates" }, globalCoordinates
                }
            );
        }

        public Control getLocalCoordinatesToRef(Vector2 globalCoordinates, Vector2 result)
        {
            return EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalCoordinatesToRef" }, globalCoordinates, result
                }
            );
        }

        public Vector2 getParentLocalCoordinates(Vector2 globalCoordinates)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getParentLocalCoordinates" }, globalCoordinates
                }
            );
        }

        public void moveToVector3(Vector3 position, Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "moveToVector3" }, position, scene
                }
            );
        }

        public void getDescendantsToRef(Control[] results, System.Nullable<bool> directDescendantsOnly = null, ActionCallback<Control> predicate = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getDescendantsToRef" }, results, directDescendantsOnly, predicate
                }
            );
        }

        public Control[] getDescendants(System.Nullable<bool> directDescendantsOnly = null, ActionCallback<Control> predicate = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDescendants" }, directDescendantsOnly, predicate
                }
            );
        }

        public void linkWithMesh(TransformNode mesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "linkWithMesh" }, mesh
                }
            );
        }

        public bool contains(decimal x, decimal y)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "contains" }, x, y
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}