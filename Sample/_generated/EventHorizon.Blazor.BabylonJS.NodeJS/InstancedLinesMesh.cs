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

    [JsonConverter(typeof(CachedEntityConverter<InstancedLinesMesh>))]
    public class InstancedLinesMesh : InstancedMesh
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        public decimal intersectionThreshold
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "intersectionThreshold"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "intersectionThreshold", value);
            }
        }
        #endregion

        #region Constructor
        public InstancedLinesMesh()
            : base() { }

        public InstancedLinesMesh(ICachedEntity entity)
            : base(entity) { }

        public InstancedLinesMesh(string name, LinesMesh source)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InstancedLinesMesh" },
                name,
                source
            );
            ___guid = entity.___guid;
        }

        public InstancedLinesMesh(string name, Mesh source)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InstancedLinesMesh" },
                name,
                source
            );
            ___guid = entity.___guid;
        }

        public InstancedLinesMesh(string name, Scene scene = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InstancedLinesMesh" },
                name,
                scene
            );
            ___guid = entity.___guid;
        }

        public InstancedLinesMesh(
            string name,
            Scene scene = null,
            System.Nullable<bool> isPure = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InstancedLinesMesh" },
                name,
                scene,
                isPure
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }
        #endregion
    }
}
