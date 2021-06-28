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

    
    
    [JsonConverter(typeof(CachedEntityConverter<LinesMesh>))]
    public class LinesMesh : Mesh
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private Material __material;
        public Material material
        {
            get
            {
            if(__material == null)
            {
                __material = EventHorizonBlazorInterop.GetClass<Material>(
                    this.___guid,
                    "material",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
            }
            return __material;
            }
            set
            {
__material = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "material",
                    value
                );
            }
        }

        
        public bool checkCollisions
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "checkCollisions"
                );
            }
        }
        #endregion

        #region Properties
        
        public bool useVertexColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useVertexColor"
                );
            }
        }

        
        public bool useVertexAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useVertexAlpha"
                );
            }
        }

        private Color3 __color;
        public Color3 color
        {
            get
            {
            if(__color == null)
            {
                __color = EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __color;
            }
            set
            {
__color = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        
        public decimal alpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
            }
        }

        
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

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intersectionThreshold",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public LinesMesh() : base() { }

        public LinesMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public LinesMesh(
            string name, Scene scene = null, Node parent = null, LinesMesh source = null, System.Nullable<bool> doNotCloneChildren = null, System.Nullable<bool> useVertexColor = null, System.Nullable<bool> useVertexAlpha = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "LinesMesh" },
                name, scene, parent, source, doNotCloneChildren, useVertexColor, useVertexAlpha
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void dispose(System.Nullable<bool> doNotRecurse = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, doNotRecurse
                }
            );
        }

        public LinesMesh clone(string name, Node newParent = null, System.Nullable<bool> doNotCloneChildren = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LinesMesh>(
                entity => new LinesMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren
                }
            );
        }

        public InstancedLinesMesh createInstance(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<InstancedLinesMesh>(
                entity => new InstancedLinesMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createInstance" }, name
                }
            );
        }
        #endregion
    }
}