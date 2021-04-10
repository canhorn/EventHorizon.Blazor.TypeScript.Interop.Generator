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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Light>))]
    public class Light : Node
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_FALLOFF_DEFAULT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.FALLOFF_DEFAULT"
                );
        }

        
        public static async ValueTask<decimal> get_FALLOFF_PHYSICAL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.FALLOFF_PHYSICAL"
                );
        }

        
        public static async ValueTask<decimal> get_FALLOFF_GLTF()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.FALLOFF_GLTF"
                );
        }

        
        public static async ValueTask<decimal> get_FALLOFF_STANDARD()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.FALLOFF_STANDARD"
                );
        }

        
        public static async ValueTask<decimal> get_LIGHTMAP_DEFAULT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTMAP_DEFAULT"
                );
        }

        
        public static async ValueTask<decimal> get_LIGHTMAP_SPECULAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTMAP_SPECULAR"
                );
        }

        
        public static async ValueTask<decimal> get_LIGHTMAP_SHADOWSONLY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTMAP_SHADOWSONLY"
                );
        }

        
        public static async ValueTask<decimal> get_INTENSITYMODE_AUTOMATIC()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.INTENSITYMODE_AUTOMATIC"
                );
        }

        
        public static async ValueTask<decimal> get_INTENSITYMODE_LUMINOUSPOWER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.INTENSITYMODE_LUMINOUSPOWER"
                );
        }

        
        public static async ValueTask<decimal> get_INTENSITYMODE_LUMINOUSINTENSITY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.INTENSITYMODE_LUMINOUSINTENSITY"
                );
        }

        
        public static async ValueTask<decimal> get_INTENSITYMODE_ILLUMINANCE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.INTENSITYMODE_ILLUMINANCE"
                );
        }

        
        public static async ValueTask<decimal> get_INTENSITYMODE_LUMINANCE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.INTENSITYMODE_LUMINANCE"
                );
        }

        
        public static async ValueTask<decimal> get_LIGHTTYPEID_POINTLIGHT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTTYPEID_POINTLIGHT"
                );
        }

        
        public static async ValueTask<decimal> get_LIGHTTYPEID_DIRECTIONALLIGHT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTTYPEID_DIRECTIONALLIGHT"
                );
        }

        
        public static async ValueTask<decimal> get_LIGHTTYPEID_SPOTLIGHT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTTYPEID_SPOTLIGHT"
                );
        }

        
        public static async ValueTask<decimal> get_LIGHTTYPEID_HEMISPHERICLIGHT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTTYPEID_HEMISPHERICLIGHT"
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<decimal> CompareLightsPriority(Light a, Light b)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "Light", "CompareLightsPriority" }, a, b
                }
            );
        }

        public static async ValueTask<ActionCallback> GetConstructorFromName(decimal type, string name, Scene scene)
        {
            return await EventHorizonBlazorInterop.Func<ActionCallback>(
                new object[] 
                {
                    new string[] { "BABYLON", "Light", "GetConstructorFromName" }, type, name, scene
                }
            );
        }

        public static async ValueTask<Light> Parse(object parsedLight, Scene scene)
        {
            return await EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Light", "Parse" }, parsedLight, scene
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_range()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "range"
                );
        }
        public ValueTask set_range(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "range",
                    value
                );
        }

        
        public async ValueTask<decimal> get_intensityMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "intensityMode"
                );
        }
        public ValueTask set_intensityMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intensityMode",
                    value
                );
        }

        
        public async ValueTask<decimal> get_radius()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
        }
        public ValueTask set_radius(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
        }

        
        public async ValueTask<bool> get_shadowEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "shadowEnabled"
                );
        }
        public ValueTask set_shadowEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowEnabled",
                    value
                );
        }

        
        public async ValueTask<AbstractMesh[]> get_includedOnlyMeshes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "includedOnlyMeshes",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_includedOnlyMeshes(AbstractMesh[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "includedOnlyMeshes",
                    value
                );
        }

        
        public async ValueTask<AbstractMesh[]> get_excludedMeshes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "excludedMeshes",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_excludedMeshes(AbstractMesh[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "excludedMeshes",
                    value
                );
        }

        
        public async ValueTask<decimal> get_excludeWithLayerMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "excludeWithLayerMask"
                );
        }
        public ValueTask set_excludeWithLayerMask(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "excludeWithLayerMask",
                    value
                );
        }

        
        public async ValueTask<decimal> get_includeOnlyWithLayerMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "includeOnlyWithLayerMask"
                );
        }
        public ValueTask set_includeOnlyWithLayerMask(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "includeOnlyWithLayerMask",
                    value
                );
        }

        
        public async ValueTask<decimal> get_lightmapMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lightmapMode"
                );
        }
        public ValueTask set_lightmapMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lightmapMode",
                    value
                );
        }
        #endregion

        #region Properties
        private Color3 __diffuse;
        public async ValueTask<Color3> get_diffuse()
        {
            if(__diffuse == null)
            {
                __diffuse = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "diffuse",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __diffuse;
        }
        public ValueTask set_diffuse(Color3 value)
        {
__diffuse = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "diffuse",
                    value
                );
        }

        private Color3 __specular;
        public async ValueTask<Color3> get_specular()
        {
            if(__specular == null)
            {
                __specular = await EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "specular",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __specular;
        }
        public ValueTask set_specular(Color3 value)
        {
__specular = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "specular",
                    value
                );
        }

        
        public async ValueTask<decimal> get_falloffType()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "falloffType"
                );
        }
        public ValueTask set_falloffType(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "falloffType",
                    value
                );
        }

        
        public async ValueTask<decimal> get_intensity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "intensity"
                );
        }
        public ValueTask set_intensity(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intensity",
                    value
                );
        }

        
        public async ValueTask<decimal> get_renderPriority()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderPriority"
                );
        }
        public ValueTask set_renderPriority(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderPriority",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Light() : base() { }

        public Light(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Light> NewLight(
            string name, Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Light" },
                name, scene
            );

            return new Light(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<Light> transferToEffect(Effect effect, string lightIndex)
        {
            return await EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "transferToEffect" }, effect, lightIndex
                }
            );
        }

        public async ValueTask<Light> transferTexturesToEffect(Effect effect, string lightIndex)
        {
            return await EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "transferTexturesToEffect" }, effect, lightIndex
                }
            );
        }

        public async ValueTask<Light> transferToNodeMaterialEffect(Effect effect, string lightDataUniformName)
        {
            return await EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "transferToNodeMaterialEffect" }, effect, lightDataUniformName
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

        public async ValueTask<string> toString(System.Nullable<bool> fullDetails = null)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }

        public async ValueTask setEnabled(bool value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setEnabled" }, value
                }
            );
        }

        public async ValueTask<IShadowGeneratorCachedEntity> getShadowGenerator()
        {
            return await EventHorizonBlazorInterop.FuncClass<IShadowGeneratorCachedEntity>(
                entity => new IShadowGeneratorCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getShadowGenerator" }
                }
            );
        }

        public async ValueTask<Vector3> getAbsolutePosition()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAbsolutePosition" }
                }
            );
        }

        public async ValueTask<bool> canAffectMesh(AbstractMesh mesh)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "canAffectMesh" }, mesh
                }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> doNotRecurse = null, System.Nullable<bool> disposeMaterialAndTextures = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, doNotRecurse, disposeMaterialAndTextures
                }
            );
        }

        public async ValueTask<decimal> getTypeID()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTypeID" }
                }
            );
        }

        public async ValueTask<decimal> getScaledIntensity()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getScaledIntensity" }
                }
            );
        }

        public async ValueTask<Light> clone(string name, Node newParent = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newParent
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public async ValueTask prepareLightSpecificDefines(object defines, decimal lightIndex)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareLightSpecificDefines" }, defines, lightIndex
                }
            );
        }
        #endregion
    }
}