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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ShadowDepthWrapper>))]
    public class ShadowDepthWrapper : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<bool> get_standalone()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "standalone"
                );
        }

        private Material __baseMaterial;
        public async ValueTask<Material> get_baseMaterial()
        {
            if(__baseMaterial == null)
            {
                __baseMaterial = await EventHorizonBlazorInterop.GetClass<Material>(
                    this.___guid,
                    "baseMaterial",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
            }
            return __baseMaterial;
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public ShadowDepthWrapper() : base() { } 

        public ShadowDepthWrapper(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<ShadowDepthWrapper> NewShadowDepthWrapper(
            Material baseMaterial, Scene scene, IIOptionShadowDepthMaterial options = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ShadowDepthWrapper" },
                baseMaterial, scene, options
            );

            return new ShadowDepthWrapper(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<Effect> getEffect(SubMesh subMesh, ShadowGenerator shadowGenerator)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEffect" }, subMesh, shadowGenerator
                }
            );
        }

        public async ValueTask<bool> isReadyForSubMesh(SubMesh subMesh, string[] defines, ShadowGenerator shadowGenerator, bool useInstances)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, subMesh, defines, shadowGenerator, useInstances
                }
            );
        }

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