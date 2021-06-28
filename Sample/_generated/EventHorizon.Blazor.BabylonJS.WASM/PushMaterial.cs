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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PushMaterial>))]
    public class PushMaterial : Material
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

        #endregion
        
        #region Constructor
        public PushMaterial() : base() { }

        public PushMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public PushMaterial(
            string name, Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PushMaterial" },
                name, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Effect getEffect()
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEffect" }
                }
            );
        }

        public bool isReady(AbstractMesh mesh = null, System.Nullable<bool> useInstances = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }, mesh, useInstances
                }
            );
        }

        public void bindOnlyWorldMatrix(Matrix world)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindOnlyWorldMatrix" }, world
                }
            );
        }

        public void bindOnlyNormalMatrix(Matrix normalMatrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindOnlyNormalMatrix" }, normalMatrix
                }
            );
        }

        public void bind(Matrix world, Mesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, world, mesh
                }
            );
        }
        #endregion
    }
}