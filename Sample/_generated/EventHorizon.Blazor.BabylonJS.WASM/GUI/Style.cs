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
    public class Style : CachedEntityObject
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
        #endregion

        #region Properties
        private Observable __onChangedObservable;
        public Observable onChangedObservable
        {
            get
            {
            if(__onChangedObservable == null)
            {
                __onChangedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onChangedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onChangedObservable;
            }
            set
            {
__onChangedObservable = null;
                EventHorizonBlazorInteropt.Set(
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
            ___guid = entity.___guid;
        }

        public Style(
            AdvancedDynamicTexture host
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "GUI", "Style" },
                host
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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