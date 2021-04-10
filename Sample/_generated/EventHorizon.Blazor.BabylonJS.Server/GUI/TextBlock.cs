/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<TextBlock>))]
    public class TextBlock : Control
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<CachedEntity[]> get_lines()
        {
            return await EventHorizonBlazorInterop.GetArray<CachedEntity>(
                    this.___guid,
                    "lines"
                );
        }

        
        public async ValueTask<bool> get_resizeToFit()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "resizeToFit"
                );
        }
        public ValueTask set_resizeToFit(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "resizeToFit",
                    value
                );
        }

        
        public async ValueTask<int> get_textWrapping()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "textWrapping"
                );
        }
        public ValueTask set_textWrapping(int value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textWrapping",
                    value
                );
        }

        
        public async ValueTask<string> get_text()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "text"
                );
        }
        public ValueTask set_text(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "text",
                    value
                );
        }

        
        public async ValueTask<decimal> get_textHorizontalAlignment()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "textHorizontalAlignment"
                );
        }
        public ValueTask set_textHorizontalAlignment(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textHorizontalAlignment",
                    value
                );
        }

        
        public async ValueTask<decimal> get_textVerticalAlignment()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "textVerticalAlignment"
                );
        }
        public ValueTask set_textVerticalAlignment(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textVerticalAlignment",
                    value
                );
        }

        
        public async ValueTask<string> get_lineSpacing()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "lineSpacing"
                );
        }
        public ValueTask set_lineSpacing(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineSpacing",
                    value
                );
        }

        
        public async ValueTask<decimal> get_outlineWidth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "outlineWidth"
                );
        }
        public ValueTask set_outlineWidth(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outlineWidth",
                    value
                );
        }

        
        public async ValueTask<bool> get_underline()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "underline"
                );
        }
        public ValueTask set_underline(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "underline",
                    value
                );
        }

        
        public async ValueTask<bool> get_lineThrough()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "lineThrough"
                );
        }
        public ValueTask set_lineThrough(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lineThrough",
                    value
                );
        }

        
        public async ValueTask<string> get_outlineColor()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "outlineColor"
                );
        }
        public ValueTask set_outlineColor(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outlineColor",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        private Observable<TextBlock> __onTextChangedObservable;
        public async ValueTask<Observable<TextBlock>> get_onTextChangedObservable()
        {
            if(__onTextChangedObservable == null)
            {
                __onTextChangedObservable = await EventHorizonBlazorInterop.GetClass<Observable<TextBlock>>(
                    this.___guid,
                    "onTextChangedObservable",
                    (entity) =>
                    {
                        return new Observable<TextBlock>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onTextChangedObservable;
        }
        public ValueTask set_onTextChangedObservable(Observable<TextBlock> value)
        {
__onTextChangedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onTextChangedObservable",
                    value
                );
        }

        private Observable<TextBlock> __onLinesReadyObservable;
        public async ValueTask<Observable<TextBlock>> get_onLinesReadyObservable()
        {
            if(__onLinesReadyObservable == null)
            {
                __onLinesReadyObservable = await EventHorizonBlazorInterop.GetClass<Observable<TextBlock>>(
                    this.___guid,
                    "onLinesReadyObservable",
                    (entity) =>
                    {
                        return new Observable<TextBlock>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onLinesReadyObservable;
        }
        public ValueTask set_onLinesReadyObservable(Observable<TextBlock> value)
        {
__onLinesReadyObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onLinesReadyObservable",
                    value
                );
        }

        
        public async ValueTask<ActionCallback<string>> get_wordSplittingFunction()
        {
            return await EventHorizonBlazorInterop.Get<ActionCallback<string>>(
                    this.___guid,
                    "wordSplittingFunction"
                );
        }
        public ValueTask set_wordSplittingFunction(ActionCallback<string> value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "wordSplittingFunction",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public TextBlock() : base() { }

        public TextBlock(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<TextBlock> NewTextBlock(
            string name = null, string text = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "TextBlock" },
                name, text
            );

            return new TextBlock(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<decimal> computeExpectedHeight()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "computeExpectedHeight" }
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}