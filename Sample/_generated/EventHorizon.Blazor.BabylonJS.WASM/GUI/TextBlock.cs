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
    public class TextBlock : Control
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public CachedEntity[] lines
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<CachedEntity>(
                    this.___guid,
                    "lines"
                );
            }
        }

        
        public bool resizeToFit
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "resizeToFit"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "resizeToFit",
                    value
                );
            }
        }

        private TextWrapping __textWrapping;
        public TextWrapping textWrapping
        {
            get
            {
            if(__textWrapping == null)
            {
                __textWrapping = EventHorizonBlazorInteropt.GetClass<TextWrapping>(
                    this.___guid,
                    "textWrapping",
                    (entity) =>
                    {
                        return new TextWrapping(entity);
                    }
                );
            }
            return __textWrapping;
            }
            set
            {
__textWrapping = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "textWrapping",
                    value
                );
            }
        }

        
        public string text
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "text"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "text",
                    value
                );
            }
        }

        
        public decimal textHorizontalAlignment
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "textHorizontalAlignment"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "textHorizontalAlignment",
                    value
                );
            }
        }

        
        public decimal textVerticalAlignment
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "textVerticalAlignment"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "textVerticalAlignment",
                    value
                );
            }
        }

        
        public string lineSpacing
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "lineSpacing"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "lineSpacing",
                    value
                );
            }
        }

        
        public decimal outlineWidth
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "outlineWidth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "outlineWidth",
                    value
                );
            }
        }

        
        public string outlineColor
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "outlineColor"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "outlineColor",
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

        private Observable __onTextChangedObservable;
        public Observable onTextChangedObservable
        {
            get
            {
            if(__onTextChangedObservable == null)
            {
                __onTextChangedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onTextChangedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onTextChangedObservable;
            }
            set
            {
__onTextChangedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onTextChangedObservable",
                    value
                );
            }
        }

        private Observable __onLinesReadyObservable;
        public Observable onLinesReadyObservable
        {
            get
            {
            if(__onLinesReadyObservable == null)
            {
                __onLinesReadyObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onLinesReadyObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onLinesReadyObservable;
            }
            set
            {
__onLinesReadyObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onLinesReadyObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TextBlock() : base() { }

        public TextBlock(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TextBlock(
            string name = null, string text = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "GUI", "TextBlock" },
                name, text
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public decimal computeExpectedHeight()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "computeExpectedHeight" }
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