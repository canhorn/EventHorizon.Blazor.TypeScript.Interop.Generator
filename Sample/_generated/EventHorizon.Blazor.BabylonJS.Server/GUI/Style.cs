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
        
        public async ValueTask<string> get_fontSize()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fontSize"
                );
        }
        public ValueTask set_fontSize(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fontSize",
                    value
                );
        }

        
        public async ValueTask<string> get_fontFamily()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fontFamily"
                );
        }
        public ValueTask set_fontFamily(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fontFamily",
                    value
                );
        }

        
        public async ValueTask<string> get_fontStyle()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fontStyle"
                );
        }
        public ValueTask set_fontStyle(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fontStyle",
                    value
                );
        }

        
        public async ValueTask<string> get_fontWeight()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "fontWeight"
                );
        }
        public ValueTask set_fontWeight(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fontWeight",
                    value
                );
        }
        #endregion

        #region Properties
        private Observable<Style> __onChangedObservable;
        public async ValueTask<Observable<Style>> get_onChangedObservable()
        {
            if(__onChangedObservable == null)
            {
                __onChangedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Style>>(
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
        public ValueTask set_onChangedObservable(Observable<Style> value)
        {
__onChangedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onChangedObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Style() : base() { }

        public Style(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Style> NewStyle(
            AdvancedDynamicTexture host
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Style" },
                host
            );

            return new Style(entity);
        }
        #endregion

        #region Methods
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