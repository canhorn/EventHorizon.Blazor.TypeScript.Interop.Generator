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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Style>))]
    public class Style : CachedEntityObject, _IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
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
        #endregion

        #region Properties
        private Observable<Style> __onChangedObservable;
        public Observable<Style> onChangedObservable
        {
            get
            {
            if(__onChangedObservable == null)
            {
                __onChangedObservable = EventHorizonBlazorInterop.GetClass<Observable<Style>>(
                    this.___guid,
                    "onChangedObservable",
                    (entity) =>
                    {
                        return new Observable<Style>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onChangedObservable;
            }
            set
            {
__onChangedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onChangedObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Style() : base() { }

        public Style(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Style(
            AdvancedDynamicTexture host
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Style" },
                host
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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