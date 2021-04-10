/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
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
        public async ValueTask<Material> get_material()
        {
            if(__material == null)
            {
                __material = await EventHorizonBlazorInterop.GetClass<Material>(
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
        public ValueTask set_material(Material value)
        {
__material = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "material",
                    value
                );
        }

        
        public async ValueTask<bool> get_checkCollisions()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "checkCollisions"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<bool> get_useVertexColor()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useVertexColor"
                );
        }

        
        public async ValueTask<bool> get_useVertexAlpha()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useVertexAlpha"
                );
        }

        private Color3 __color;
        public async ValueTask<Color3> get_color()
        {
            if(__color == null)
            {
                __color = await EventHorizonBlazorInterop.GetClass<Color3>(
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
        public ValueTask set_color(Color3 value)
        {
__color = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color",
                    value
                );
        }

        
        public async ValueTask<decimal> get_alpha()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "alpha"
                );
        }
        public ValueTask set_alpha(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "alpha",
                    value
                );
        }

        
        public async ValueTask<decimal> get_intersectionThreshold()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "intersectionThreshold"
                );
        }
        public ValueTask set_intersectionThreshold(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intersectionThreshold",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public LinesMesh() : base() { }

        public LinesMesh(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<LinesMesh> NewLinesMesh(
            string name, Scene scene = null, Node parent = null, LinesMesh source = null, System.Nullable<bool> doNotCloneChildren = null, System.Nullable<bool> useVertexColor = null, System.Nullable<bool> useVertexAlpha = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "LinesMesh" },
                name, scene, parent, source, doNotCloneChildren, useVertexColor, useVertexAlpha
            );

            return new LinesMesh(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> isReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> doNotRecurse = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, doNotRecurse
                }
            );
        }

        public async ValueTask<LinesMesh> clone(string name, Node newParent = null, System.Nullable<bool> doNotCloneChildren = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<LinesMesh>(
                entity => new LinesMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren
                }
            );
        }

        public async ValueTask<InstancedLinesMesh> createInstance(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<InstancedLinesMesh>(
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