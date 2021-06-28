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

    
    
    [JsonConverter(typeof(CachedEntityConverter<PrePassConfiguration>))]
    public class PrePassConfiguration : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void AddUniforms(string[] uniforms)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "PrePassConfiguration", "AddUniforms" }, uniforms
                }
            );
        }

        public static void AddSamplers(string[] samplers)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
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
        
        public CachedEntity previousWorldMatrices
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "previousWorldMatrices",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "previousWorldMatrices",
                    value
                );
            }
        }

        private Matrix __previousViewProjection;
        public Matrix previousViewProjection
        {
            get
            {
            if(__previousViewProjection == null)
            {
                __previousViewProjection = EventHorizonBlazorInterop.GetClass<Matrix>(
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
            set
            {
__previousViewProjection = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "previousViewProjection",
                    value
                );
            }
        }

        
        public CachedEntity previousBones
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "previousBones",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "previousBones",
                    value
                );
            }
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
        public void bindForSubMesh(Effect effect, Scene scene, Mesh mesh, Matrix world, bool isFrozen)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindForSubMesh" }, effect, scene, mesh, world, isFrozen
                }
            );
        }
        #endregion
    }
}