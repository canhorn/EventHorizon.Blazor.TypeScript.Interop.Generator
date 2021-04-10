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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PrePassConfiguration>))]
    public class PrePassConfiguration : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask AddUniforms(string[] uniforms)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "PrePassConfiguration", "AddUniforms" }, uniforms
                }
            );
        }

        public static async ValueTask AddSamplers(string[] samplers)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "PrePassConfiguration", "AddSamplers" }, samplers
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public async ValueTask<CachedEntity> get_previousWorldMatrices()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "previousWorldMatrices",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_previousWorldMatrices(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "previousWorldMatrices",
                    value
                );
        }

        private Matrix __previousViewProjection;
        public async ValueTask<Matrix> get_previousViewProjection()
        {
            if(__previousViewProjection == null)
            {
                __previousViewProjection = await EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "previousViewProjection",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __previousViewProjection;
        }
        public ValueTask set_previousViewProjection(Matrix value)
        {
__previousViewProjection = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "previousViewProjection",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_previousBones()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "previousBones",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_previousBones(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "previousBones",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public PrePassConfiguration() : base() { } 

        public PrePassConfiguration(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public async ValueTask bindForSubMesh(Effect effect, Scene scene, Mesh mesh, Matrix world, bool isFrozen)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindForSubMesh" }, effect, scene, mesh, world, isFrozen
                }
            );
        }
        #endregion
    }
}