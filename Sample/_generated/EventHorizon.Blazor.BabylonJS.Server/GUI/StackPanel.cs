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

    
    
    [JsonConverter(typeof(CachedEntityConverter<StackPanel>))]
    public class StackPanel : Container
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_isVertical()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isVertical"
                );
        }
        public ValueTask set_isVertical(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isVertical",
                    value
                );
        }

        
        public async ValueTask<string> get_width()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "width"
                );
        }
        public ValueTask set_width(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
        }

        
        public async ValueTask<string> get_height()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "height"
                );
        }
        public ValueTask set_height(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
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

        
        public async ValueTask<bool> get_ignoreLayoutWarnings()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreLayoutWarnings"
                );
        }
        public ValueTask set_ignoreLayoutWarnings(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignoreLayoutWarnings",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public StackPanel() : base() { }

        public StackPanel(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<StackPanel> NewStackPanel(
            string name = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "StackPanel" },
                name
            );

            return new StackPanel(entity);
        }
        #endregion

        #region Methods

        #endregion
    }
}