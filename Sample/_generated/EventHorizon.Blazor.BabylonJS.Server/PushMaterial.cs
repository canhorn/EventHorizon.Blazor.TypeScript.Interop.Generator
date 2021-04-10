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

        public static async ValueTask<PushMaterial> NewPushMaterial(
            string name, Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PushMaterial" },
                name, scene
            );

            return new PushMaterial(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<Effect> getEffect()
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEffect" }
                }
            );
        }

        public async ValueTask<bool> isReady(AbstractMesh mesh = null, System.Nullable<bool> useInstances = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, mesh, useInstances
                }
            );
        }

        public async ValueTask bindOnlyWorldMatrix(Matrix world)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindOnlyWorldMatrix" }, world
                }
            );
        }

        public async ValueTask bindOnlyNormalMatrix(Matrix normalMatrix)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindOnlyNormalMatrix" }, normalMatrix
                }
            );
        }

        public async ValueTask bind(Matrix world, Mesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bind" }, world, mesh
                }
            );
        }
        #endregion
    }
}