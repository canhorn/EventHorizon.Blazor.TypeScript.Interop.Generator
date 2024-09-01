/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<IShaderPath>))]
    public class IShaderPath : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static string vertexSource
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>("BABYLON", "IShaderPath.vertexSource");
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.vertexSource", value);
            }
        }

        public static string fragmentSource
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "IShaderPath.fragmentSource"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.fragmentSource", value);
            }
        }

        public static string vertex
        {
            get { return EventHorizonBlazorInterop.Get<string>("BABYLON", "IShaderPath.vertex"); }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.vertex", value);
            }
        }

        public static string fragment
        {
            get { return EventHorizonBlazorInterop.Get<string>("BABYLON", "IShaderPath.fragment"); }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.fragment", value);
            }
        }

        public static string vertexElement
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "IShaderPath.vertexElement"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.vertexElement", value);
            }
        }

        public static string fragmentElement
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "IShaderPath.fragmentElement"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.fragmentElement", value);
            }
        }

        public static string spectorName
        {
            get
            {
                return EventHorizonBlazorInterop.Get<string>("BABYLON", "IShaderPath.spectorName");
            }
            set
            {

                EventHorizonBlazorInterop.Set("BABYLON", "IShaderPath.spectorName", value);
            }
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
