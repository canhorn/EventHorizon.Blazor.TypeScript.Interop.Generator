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

    [JsonConverter(typeof(CachedEntityConverter<Control>))]
    public class Control : CachedEntityObject, IAnimatable, IFocusableControl
    {
        #region Static Accessors

        public static async ValueTask<decimal> get_HORIZONTAL_ALIGNMENT_LEFT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GUI.Control.HORIZONTAL_ALIGNMENT_LEFT"
            );
        }

        public static async ValueTask<decimal> get_HORIZONTAL_ALIGNMENT_RIGHT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GUI.Control.HORIZONTAL_ALIGNMENT_RIGHT"
            );
        }

        public static async ValueTask<decimal> get_HORIZONTAL_ALIGNMENT_CENTER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GUI.Control.HORIZONTAL_ALIGNMENT_CENTER"
            );
        }

        public static async ValueTask<decimal> get_VERTICAL_ALIGNMENT_TOP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GUI.Control.VERTICAL_ALIGNMENT_TOP"
            );
        }

        public static async ValueTask<decimal> get_VERTICAL_ALIGNMENT_BOTTOM()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GUI.Control.VERTICAL_ALIGNMENT_BOTTOM"
            );
        }

        public static async ValueTask<decimal> get_VERTICAL_ALIGNMENT_CENTER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "GUI.Control.VERTICAL_ALIGNMENT_CENTER"
            );
        }
        #endregion

        #region Static Properties

        public static async ValueTask<bool> get_AllowAlphaInheritance()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "GUI.Control.AllowAlphaInheritance"
            );
        }

        public static ValueTask set_AllowAlphaInheritance(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "GUI.Control.AllowAlphaInheritance",
                value
            );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<Control> Parse(
            object serializedObject,
            AdvancedDynamicTexture host,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Control>(
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

        public static async ValueTask<CachedEntity> AddHeader(
            Control control,
            string text,
            string size,
            object options
        )
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<bool> get_isReadOnly()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isReadOnly");
        }

        public ValueTask set_isReadOnly(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isReadOnly", value);
        }

        private Measure __transformedMeasure;

        public async ValueTask<Measure> get_transformedMeasure()
        {
            if (__transformedMeasure == null)
            {
                __transformedMeasure = await EventHorizonBlazorInterop.GetClass<Measure>(
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

        public async ValueTask<bool> get_clipChildren()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "clipChildren");
        }

        public ValueTask set_clipChildren(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "clipChildren", value);
        }

        public async ValueTask<bool> get_clipContent()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "clipContent");
        }

        public ValueTask set_clipContent(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "clipContent", value);
        }

        public async ValueTask<decimal> get_shadowOffsetX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowOffsetX");
        }

        public ValueTask set_shadowOffsetX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shadowOffsetX", value);
        }

        public async ValueTask<decimal> get_shadowOffsetY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowOffsetY");
        }

        public ValueTask set_shadowOffsetY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shadowOffsetY", value);
        }

        public async ValueTask<decimal> get_shadowBlur()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowBlur");
        }

        public ValueTask set_shadowBlur(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shadowBlur", value);
        }

        public async ValueTask<string> get_shadowColor()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "shadowColor");
        }

        public ValueTask set_shadowColor(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "shadowColor", value);
        }

        public async ValueTask<string> get_typeName()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "typeName");
        }

        private IAccessibilityTagCachedEntity __accessibilityTag;

        public async ValueTask<IAccessibilityTagCachedEntity> get_accessibilityTag()
        {
            if (__accessibilityTag == null)
            {
                __accessibilityTag =
                    await EventHorizonBlazorInterop.GetClass<IAccessibilityTagCachedEntity>(
                        this.___guid,
                        "accessibilityTag",
                        (entity) =>
                        {
                            return new IAccessibilityTagCachedEntity() { ___guid = entity.___guid };
                        }
                    );
            }
            return __accessibilityTag;
        }

        public ValueTask set_accessibilityTag(IAccessibilityTagCachedEntity value)
        {
            __accessibilityTag = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "accessibilityTag", value);
        }

        private AdvancedDynamicTexture __host;

        public async ValueTask<AdvancedDynamicTexture> get_host()
        {
            if (__host == null)
            {
                __host = await EventHorizonBlazorInterop.GetClass<AdvancedDynamicTexture>(
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

        public async ValueTask<CachedEntity> get_fontOffset()
        {
            return await EventHorizonBlazorInterop.Get<CachedEntity>(this.___guid, "fontOffset");
        }

        public ValueTask set_fontOffset(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fontOffset", value);
        }

        public async ValueTask<decimal> get_alpha()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "alpha");
        }

        public ValueTask set_alpha(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "alpha", value);
        }

        public async ValueTask<decimal> get_highlightLineWidth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "highlightLineWidth");
        }

        public ValueTask set_highlightLineWidth(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "highlightLineWidth", value);
        }

        public async ValueTask<bool> get_isHighlighted()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isHighlighted");
        }

        public ValueTask set_isHighlighted(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isHighlighted", value);
        }

        public async ValueTask<string> get_highlightColor()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "highlightColor");
        }

        public ValueTask set_highlightColor(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "highlightColor", value);
        }

        public async ValueTask<decimal> get_scaleX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "scaleX");
        }

        public ValueTask set_scaleX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "scaleX", value);
        }

        public async ValueTask<decimal> get_scaleY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "scaleY");
        }

        public ValueTask set_scaleY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "scaleY", value);
        }

        public async ValueTask<decimal> get_rotation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "rotation");
        }

        public ValueTask set_rotation(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "rotation", value);
        }

        public async ValueTask<decimal> get_transformCenterY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "transformCenterY");
        }

        public ValueTask set_transformCenterY(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "transformCenterY", value);
        }

        public async ValueTask<decimal> get_transformCenterX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "transformCenterX");
        }

        public ValueTask set_transformCenterX(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "transformCenterX", value);
        }

        public async ValueTask<decimal> get_horizontalAlignment()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "horizontalAlignment"
            );
        }

        public ValueTask set_horizontalAlignment(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "horizontalAlignment", value);
        }

        public async ValueTask<decimal> get_verticalAlignment()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "verticalAlignment");
        }

        public ValueTask set_verticalAlignment(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "verticalAlignment", value);
        }

        public async ValueTask<decimal> get_fixedRatio()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "fixedRatio");
        }

        public ValueTask set_fixedRatio(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fixedRatio", value);
        }

        public async ValueTask<bool> get_fixedRatioMasterIsWidth()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "fixedRatioMasterIsWidth"
            );
        }

        public ValueTask set_fixedRatioMasterIsWidth(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fixedRatioMasterIsWidth", value);
        }

        public async ValueTask<string> get_width()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "width");
        }

        public ValueTask set_width(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "width", value);
        }

        public async ValueTask<decimal> get_widthInPixels()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "widthInPixels");
        }

        public ValueTask set_widthInPixels(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "widthInPixels", value);
        }

        public async ValueTask<string> get_height()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "height");
        }

        public ValueTask set_height(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "height", value);
        }

        public async ValueTask<decimal> get_heightInPixels()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "heightInPixels");
        }

        public ValueTask set_heightInPixels(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "heightInPixels", value);
        }

        public async ValueTask<string> get_fontFamily()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "fontFamily");
        }

        public ValueTask set_fontFamily(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fontFamily", value);
        }

        public async ValueTask<string> get_fontStyle()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "fontStyle");
        }

        public ValueTask set_fontStyle(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fontStyle", value);
        }

        public async ValueTask<string> get_fontWeight()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "fontWeight");
        }

        public ValueTask set_fontWeight(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fontWeight", value);
        }

        private Style __style;

        public async ValueTask<Style> get_style()
        {
            if (__style == null)
            {
                __style = await EventHorizonBlazorInterop.GetClass<Style>(
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

        public ValueTask set_style(Style value)
        {
            __style = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "style", value);
        }

        public async ValueTask<decimal> get_fontSizeInPixels()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "fontSizeInPixels");
        }

        public ValueTask set_fontSizeInPixels(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fontSizeInPixels", value);
        }

        public async ValueTask<string> get_fontSize()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "fontSize");
        }

        public ValueTask set_fontSize(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "fontSize", value);
        }

        public async ValueTask<string> get_color()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "color");
        }

        public ValueTask set_color(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "color", value);
        }

        private BaseGradient __gradient;

        public async ValueTask<BaseGradient> get_gradient()
        {
            if (__gradient == null)
            {
                __gradient = await EventHorizonBlazorInterop.GetClass<BaseGradient>(
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

        public ValueTask set_gradient(BaseGradient value)
        {
            __gradient = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "gradient", value);
        }

        public async ValueTask<decimal> get_zIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "zIndex");
        }

        public ValueTask set_zIndex(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "zIndex", value);
        }

        public async ValueTask<bool> get_notRenderable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "notRenderable");
        }

        public ValueTask set_notRenderable(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "notRenderable", value);
        }

        public async ValueTask<bool> get_isVisible()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isVisible");
        }

        public ValueTask set_isVisible(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isVisible", value);
        }

        public async ValueTask<bool> get_isDirty()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isDirty");
        }

        private TransformNode __linkedMesh;

        public async ValueTask<TransformNode> get_linkedMesh()
        {
            if (__linkedMesh == null)
            {
                __linkedMesh = await EventHorizonBlazorInterop.GetClass<TransformNode>(
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

        public async ValueTask<bool> get_descendantsOnlyPadding()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "descendantsOnlyPadding"
            );
        }

        public ValueTask set_descendantsOnlyPadding(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "descendantsOnlyPadding", value);
        }

        public async ValueTask<string> get_paddingLeft()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "paddingLeft");
        }

        public ValueTask set_paddingLeft(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "paddingLeft", value);
        }

        public async ValueTask<decimal> get_paddingLeftInPixels()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "paddingLeftInPixels"
            );
        }

        public ValueTask set_paddingLeftInPixels(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "paddingLeftInPixels", value);
        }

        public async ValueTask<string> get_paddingRight()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "paddingRight");
        }

        public ValueTask set_paddingRight(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "paddingRight", value);
        }

        public async ValueTask<decimal> get_paddingRightInPixels()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "paddingRightInPixels"
            );
        }

        public ValueTask set_paddingRightInPixels(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "paddingRightInPixels", value);
        }

        public async ValueTask<string> get_paddingTop()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "paddingTop");
        }

        public ValueTask set_paddingTop(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "paddingTop", value);
        }

        public async ValueTask<decimal> get_paddingTopInPixels()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "paddingTopInPixels");
        }

        public ValueTask set_paddingTopInPixels(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "paddingTopInPixels", value);
        }

        public async ValueTask<string> get_paddingBottom()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "paddingBottom");
        }

        public ValueTask set_paddingBottom(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "paddingBottom", value);
        }

        public async ValueTask<decimal> get_paddingBottomInPixels()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "paddingBottomInPixels"
            );
        }

        public ValueTask set_paddingBottomInPixels(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "paddingBottomInPixels", value);
        }

        public async ValueTask<string> get_left()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "left");
        }

        public ValueTask set_left(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "left", value);
        }

        public async ValueTask<decimal> get_leftInPixels()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "leftInPixels");
        }

        public ValueTask set_leftInPixels(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "leftInPixels", value);
        }

        public async ValueTask<string> get_top()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "top");
        }

        public ValueTask set_top(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "top", value);
        }

        public async ValueTask<decimal> get_topInPixels()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "topInPixels");
        }

        public ValueTask set_topInPixels(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "topInPixels", value);
        }

        public async ValueTask<string> get_linkOffsetX()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "linkOffsetX");
        }

        public ValueTask set_linkOffsetX(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "linkOffsetX", value);
        }

        public async ValueTask<decimal> get_linkOffsetXInPixels()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "linkOffsetXInPixels"
            );
        }

        public ValueTask set_linkOffsetXInPixels(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "linkOffsetXInPixels", value);
        }

        public async ValueTask<string> get_linkOffsetY()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "linkOffsetY");
        }

        public ValueTask set_linkOffsetY(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "linkOffsetY", value);
        }

        public async ValueTask<decimal> get_linkOffsetYInPixels()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "linkOffsetYInPixels"
            );
        }

        public ValueTask set_linkOffsetYInPixels(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "linkOffsetYInPixels", value);
        }

        public async ValueTask<decimal> get_centerX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "centerX");
        }

        public async ValueTask<decimal> get_centerY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "centerY");
        }

        public async ValueTask<bool> get_isEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isEnabled");
        }

        public ValueTask set_isEnabled(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isEnabled", value);
        }

        public async ValueTask<string> get_disabledColor()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "disabledColor");
        }

        public ValueTask set_disabledColor(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disabledColor", value);
        }

        public async ValueTask<string> get_disabledColorItem()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "disabledColorItem");
        }

        public ValueTask set_disabledColorItem(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "disabledColorItem", value);
        }

        public async ValueTask<string> get_focusedColor()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "focusedColor");
        }

        public ValueTask set_focusedColor(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "focusedColor", value);
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

        private Container __parent;

        public async ValueTask<Container> get_parent()
        {
            if (__parent == null)
            {
                __parent = await EventHorizonBlazorInterop.GetClass<Container>(
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

        public ValueTask set_parent(Container value)
        {
            __parent = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "parent", value);
        }

        // onEnabledStateChangedObservable is not supported by the platform yet


        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "uniqueId");
        }

        public ValueTask set_uniqueId(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "uniqueId", value);
        }

        public async ValueTask<CachedEntity> get_metadata()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "metadata",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_metadata(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "metadata", value);
        }

        public async ValueTask<bool> get_isHitTestVisible()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isHitTestVisible");
        }

        public ValueTask set_isHitTestVisible(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isHitTestVisible", value);
        }

        public async ValueTask<bool> get_isPointerBlocker()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isPointerBlocker");
        }

        public ValueTask set_isPointerBlocker(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isPointerBlocker", value);
        }

        public async ValueTask<bool> get_isFocusInvisible()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isFocusInvisible");
        }

        public ValueTask set_isFocusInvisible(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isFocusInvisible", value);
        }

        public async ValueTask<bool> get_useBitmapCache()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "useBitmapCache");
        }

        public ValueTask set_useBitmapCache(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useBitmapCache", value);
        }

        public async ValueTask<string> get_hoverCursor()
        {
            return await EventHorizonBlazorInterop.Get<string>(this.___guid, "hoverCursor");
        }

        public ValueTask set_hoverCursor(string value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "hoverCursor", value);
        }

        private Observable<IAccessibilityTagCachedEntity> __onAccessibilityTagChangedObservable;

        public async ValueTask<
            Observable<IAccessibilityTagCachedEntity>
        > get_onAccessibilityTagChangedObservable()
        {
            if (__onAccessibilityTagChangedObservable == null)
            {
                __onAccessibilityTagChangedObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onAccessibilityTagChangedObservable(
            Observable<IAccessibilityTagCachedEntity> value
        )
        {
            __onAccessibilityTagChangedObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onAccessibilityTagChangedObservable",
                value
            );
        }

        private Observable<Vector2> __onWheelObservable;

        public async ValueTask<Observable<Vector2>> get_onWheelObservable()
        {
            if (__onWheelObservable == null)
            {
                __onWheelObservable = await EventHorizonBlazorInterop.GetClass<Observable<Vector2>>(
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

        public ValueTask set_onWheelObservable(Observable<Vector2> value)
        {
            __onWheelObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onWheelObservable", value);
        }

        private Observable<Vector2> __onPointerMoveObservable;

        public async ValueTask<Observable<Vector2>> get_onPointerMoveObservable()
        {
            if (__onPointerMoveObservable == null)
            {
                __onPointerMoveObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onPointerMoveObservable(Observable<Vector2> value)
        {
            __onPointerMoveObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onPointerMoveObservable", value);
        }

        private Observable<Control> __onPointerOutObservable;

        public async ValueTask<Observable<Control>> get_onPointerOutObservable()
        {
            if (__onPointerOutObservable == null)
            {
                __onPointerOutObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onPointerOutObservable(Observable<Control> value)
        {
            __onPointerOutObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onPointerOutObservable", value);
        }

        private Observable<Vector2WithInfo> __onPointerDownObservable;

        public async ValueTask<Observable<Vector2WithInfo>> get_onPointerDownObservable()
        {
            if (__onPointerDownObservable == null)
            {
                __onPointerDownObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onPointerDownObservable(Observable<Vector2WithInfo> value)
        {
            __onPointerDownObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onPointerDownObservable", value);
        }

        private Observable<Vector2WithInfo> __onPointerUpObservable;

        public async ValueTask<Observable<Vector2WithInfo>> get_onPointerUpObservable()
        {
            if (__onPointerUpObservable == null)
            {
                __onPointerUpObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onPointerUpObservable(Observable<Vector2WithInfo> value)
        {
            __onPointerUpObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onPointerUpObservable", value);
        }

        private Observable<Vector2WithInfo> __onPointerClickObservable;

        public async ValueTask<Observable<Vector2WithInfo>> get_onPointerClickObservable()
        {
            if (__onPointerClickObservable == null)
            {
                __onPointerClickObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onPointerClickObservable(Observable<Vector2WithInfo> value)
        {
            __onPointerClickObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onPointerClickObservable", value);
        }

        private Observable<Control> __onEnterPressedObservable;

        public async ValueTask<Observable<Control>> get_onEnterPressedObservable()
        {
            if (__onEnterPressedObservable == null)
            {
                __onEnterPressedObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onEnterPressedObservable(Observable<Control> value)
        {
            __onEnterPressedObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onEnterPressedObservable", value);
        }

        private Observable<Control> __onPointerEnterObservable;

        public async ValueTask<Observable<Control>> get_onPointerEnterObservable()
        {
            if (__onPointerEnterObservable == null)
            {
                __onPointerEnterObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onPointerEnterObservable(Observable<Control> value)
        {
            __onPointerEnterObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onPointerEnterObservable", value);
        }

        private Observable<Control> __onDirtyObservable;

        public async ValueTask<Observable<Control>> get_onDirtyObservable()
        {
            if (__onDirtyObservable == null)
            {
                __onDirtyObservable = await EventHorizonBlazorInterop.GetClass<Observable<Control>>(
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

        public ValueTask set_onDirtyObservable(Observable<Control> value)
        {
            __onDirtyObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onDirtyObservable", value);
        }

        private Observable<Control> __onBeforeDrawObservable;

        public async ValueTask<Observable<Control>> get_onBeforeDrawObservable()
        {
            if (__onBeforeDrawObservable == null)
            {
                __onBeforeDrawObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onBeforeDrawObservable(Observable<Control> value)
        {
            __onBeforeDrawObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onBeforeDrawObservable", value);
        }

        private Observable<Control> __onAfterDrawObservable;

        public async ValueTask<Observable<Control>> get_onAfterDrawObservable()
        {
            if (__onAfterDrawObservable == null)
            {
                __onAfterDrawObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onAfterDrawObservable(Observable<Control> value)
        {
            __onAfterDrawObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onAfterDrawObservable", value);
        }

        private Observable<Control> __onDisposeObservable;

        public async ValueTask<Observable<Control>> get_onDisposeObservable()
        {
            if (__onDisposeObservable == null)
            {
                __onDisposeObservable = await EventHorizonBlazorInterop.GetClass<
                    Observable<Control>
                >(
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

        public ValueTask set_onDisposeObservable(Observable<Control> value)
        {
            __onDisposeObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onDisposeObservable", value);
        }

        // onIsVisibleChangedObservable is not supported by the platform yet


        public async ValueTask<bool> get_isSerializable()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "isSerializable");
        }

        public ValueTask set_isSerializable(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "isSerializable", value);
        }

        public async ValueTask<decimal> get_overlapGroup()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "overlapGroup");
        }

        public ValueTask set_overlapGroup(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "overlapGroup", value);
        }

        public async ValueTask<decimal> get_overlapDeltaMultiplier()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                this.___guid,
                "overlapDeltaMultiplier"
            );
        }

        public ValueTask set_overlapDeltaMultiplier(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "overlapDeltaMultiplier", value);
        }

        public async ValueTask<Animation[]> get_animations()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Animation>(
                this.___guid,
                "animations",
                (entity) =>
                {
                    return new Animation() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_animations(Animation[] value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "animations", value);
        }

        public async ValueTask<decimal> get_tabIndex()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "tabIndex");
        }

        public ValueTask set_tabIndex(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "tabIndex", value);
        }

        private Observable<Control> __onFocusObservable;

        public async ValueTask<Observable<Control>> get_onFocusObservable()
        {
            if (__onFocusObservable == null)
            {
                __onFocusObservable = await EventHorizonBlazorInterop.GetClass<Observable<Control>>(
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

        public ValueTask set_onFocusObservable(Observable<Control> value)
        {
            __onFocusObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onFocusObservable", value);
        }

        private Observable<Control> __onBlurObservable;

        public async ValueTask<Observable<Control>> get_onBlurObservable()
        {
            if (__onBlurObservable == null)
            {
                __onBlurObservable = await EventHorizonBlazorInterop.GetClass<Observable<Control>>(
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

        public ValueTask set_onBlurObservable(Observable<Control> value)
        {
            __onBlurObservable = null;
            return EventHorizonBlazorInterop.Set(this.___guid, "onBlurObservable", value);
        }

        private Observable<IKeyboardEventCachedEntity> __onKeyboardEventProcessedObservable;

        public async ValueTask<
            Observable<IKeyboardEventCachedEntity>
        > get_onKeyboardEventProcessedObservable()
        {
            if (__onKeyboardEventProcessedObservable == null)
            {
                __onKeyboardEventProcessedObservable = await EventHorizonBlazorInterop.GetClass<
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

        public ValueTask set_onKeyboardEventProcessedObservable(
            Observable<IKeyboardEventCachedEntity> value
        )
        {
            __onKeyboardEventProcessedObservable = null;
            return EventHorizonBlazorInterop.Set(
                this.___guid,
                "onKeyboardEventProcessedObservable",
                value
            );
        }
        #endregion

        #region Constructor
        public Control()
            : base() { }

        public Control(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<Control> NewControl(string name = null)
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Control" },
                name
            );

            return new Control(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public async ValueTask onBlur()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "onBlur" } }
            );
        }

        public async ValueTask onFocus()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "onFocus" } }
            );
        }

        public async ValueTask<Control[]> keepsFocusWith()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "keepsFocusWith" } }
            );
        }

        public async ValueTask focus()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "focus" } }
            );
        }

        public async ValueTask blur()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "blur" } }
            );
        }

        public async ValueTask processKeyboard(IKeyboardEvent evt)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "processKeyboard" }, evt }
            );
        }

        public async ValueTask<Control> getAscendantOfClass(string className)
        {
            return await EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAscendantOfClass" }, className }
            );
        }

        public async ValueTask markAsDirty(System.Nullable<bool> force = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "markAsDirty" }, force }
            );
        }

        public async ValueTask markAllAsDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "markAllAsDirty" } }
            );
        }

        public async ValueTask<bool> isAscendant(Control container)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isAscendant" }, container }
            );
        }

        public async ValueTask<Vector2> getLocalCoordinates(Vector2 globalCoordinates)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalCoordinates" },
                    globalCoordinates
                }
            );
        }

        public async ValueTask<Control> getLocalCoordinatesToRef(
            Vector2 globalCoordinates,
            Vector2 result
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalCoordinatesToRef" },
                    globalCoordinates,
                    result
                }
            );
        }

        public async ValueTask<Vector2> getParentLocalCoordinates(Vector2 globalCoordinates)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getParentLocalCoordinates" },
                    globalCoordinates
                }
            );
        }

        public async ValueTask moveToVector3(Vector3 position, Scene scene)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "moveToVector3" }, position, scene }
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

        public async ValueTask linkWithMesh(TransformNode mesh)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "linkWithMesh" }, mesh }
            );
        }

        public async ValueTask setPadding(
            string paddingTop,
            string paddingRight = null,
            string paddingBottom = null,
            string paddingLeft = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask setPaddingInPixels(
            decimal paddingTop,
            System.Nullable<decimal> paddingRight = null,
            System.Nullable<decimal> paddingBottom = null,
            System.Nullable<decimal> paddingLeft = null
        )
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask invalidateRect()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "invalidateRect" } }
            );
        }

        public async ValueTask<bool> contains(decimal x, decimal y)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "contains" }, x, y }
            );
        }

        public async ValueTask<bool> isDimensionFullyDefined(object dim)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "isDimensionFullyDefined" }, dim }
            );
        }

        public async ValueTask<ValueAndUnit> getDimension(object dim)
        {
            return await EventHorizonBlazorInterop.FuncClass<ValueAndUnit>(
                entity => new ValueAndUnit() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getDimension" }, dim }
            );
        }

        public async ValueTask<Control> clone(AdvancedDynamicTexture host = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" }, host }
            );
        }

        public async ValueTask<Control> parse(
            object serializedObject,
            AdvancedDynamicTexture host = null,
            ActionResultCallback<string, string> urlRewriter = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<Control>(
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
