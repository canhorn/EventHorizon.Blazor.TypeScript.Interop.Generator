/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<IShaderPath>))]
    public class IShaderPath : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<string> get_vertexSource()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                "BABYLON",
                "IShaderPath.vertexSource"
            );
        }

        public static ValueTask set_vertexSource(string value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.vertexSource", value);
        }

        public static async ValueTask<string> get_fragmentSource()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                "BABYLON",
                "IShaderPath.fragmentSource"
            );
        }

        public static ValueTask set_fragmentSource(string value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.fragmentSource", value);
        }

        public static async ValueTask<string> get_vertex()
        {
            return await EventHorizonBlazorInterop.Get<string>("BABYLON", "IShaderPath.vertex");
        }

        public static ValueTask set_vertex(string value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.vertex", value);
        }

        public static async ValueTask<string> get_fragment()
        {
            return await EventHorizonBlazorInterop.Get<string>("BABYLON", "IShaderPath.fragment");
        }

        public static ValueTask set_fragment(string value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.fragment", value);
        }

        public static async ValueTask<string> get_vertexElement()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                "BABYLON",
                "IShaderPath.vertexElement"
            );
        }

        public static ValueTask set_vertexElement(string value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.vertexElement", value);
        }

        public static async ValueTask<string> get_fragmentElement()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                "BABYLON",
                "IShaderPath.fragmentElement"
            );
        }

        public static ValueTask set_fragmentElement(string value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.fragmentElement", value);
        }

        public static async ValueTask<string> get_spectorName()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                "BABYLON",
                "IShaderPath.spectorName"
            );
        }

        public static ValueTask set_spectorName(string value)
        {
            return EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.spectorName", value);
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion

        #region Constructor
        public IShaderPath()
            : base() { }

        public IShaderPath(ICachedEntity entity)
            : base(entity)
        {
            ___guid = entity.___guid;
        }

        #endregion

        #region Methods

        #endregion
    }
}
