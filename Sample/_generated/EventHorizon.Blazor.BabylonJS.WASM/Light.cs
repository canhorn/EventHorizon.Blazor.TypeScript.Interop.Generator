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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Light>))]
    public class Light : Node
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal FALLOFF_DEFAULT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.FALLOFF_DEFAULT"
                );
            }
        }

        
        public static decimal FALLOFF_PHYSICAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.FALLOFF_PHYSICAL"
                );
            }
        }

        
        public static decimal FALLOFF_GLTF
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.FALLOFF_GLTF"
                );
            }
        }

        
        public static decimal FALLOFF_STANDARD
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.FALLOFF_STANDARD"
                );
            }
        }

        
        public static decimal LIGHTMAP_DEFAULT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTMAP_DEFAULT"
                );
            }
        }

        
        public static decimal LIGHTMAP_SPECULAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTMAP_SPECULAR"
                );
            }
        }

        
        public static decimal LIGHTMAP_SHADOWSONLY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTMAP_SHADOWSONLY"
                );
            }
        }

        
        public static decimal INTENSITYMODE_AUTOMATIC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.INTENSITYMODE_AUTOMATIC"
                );
            }
        }

        
        public static decimal INTENSITYMODE_LUMINOUSPOWER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.INTENSITYMODE_LUMINOUSPOWER"
                );
            }
        }

        
        public static decimal INTENSITYMODE_LUMINOUSINTENSITY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.INTENSITYMODE_LUMINOUSINTENSITY"
                );
            }
        }

        
        public static decimal INTENSITYMODE_ILLUMINANCE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.INTENSITYMODE_ILLUMINANCE"
                );
            }
        }

        
        public static decimal INTENSITYMODE_LUMINANCE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.INTENSITYMODE_LUMINANCE"
                );
            }
        }

        
        public static decimal LIGHTTYPEID_POINTLIGHT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTTYPEID_POINTLIGHT"
                );
            }
        }

        
        public static decimal LIGHTTYPEID_DIRECTIONALLIGHT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTTYPEID_DIRECTIONALLIGHT"
                );
            }
        }

        
        public static decimal LIGHTTYPEID_SPOTLIGHT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTTYPEID_SPOTLIGHT"
                );
            }
        }

        
        public static decimal LIGHTTYPEID_HEMISPHERICLIGHT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Light.LIGHTTYPEID_HEMISPHERICLIGHT"
                );
            }
        }
        #endregion

        #region Static Methods
        public static decimal CompareLightsPriority(Light a, Light b)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "Light", "CompareLightsPriority" }, a, b
                }
            );
        }

        public static ActionResultCallback<Light> GetConstructorFromName(decimal type, string name, Scene scene)
        {
            return EventHorizonBlazorInterop.Func<ActionResultCallback<Light>>(
                new object[]
                {
                    new string[] { "BABYLON", "Light", "GetConstructorFromName" }, type, name, scene
                }
            );
        }

        public static Light Parse(object parsedLight, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Light", "Parse" }, parsedLight, scene
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal range
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "range"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "range",
                    value
                );
            }
        }

        
        public decimal intensityMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "intensityMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intensityMode",
                    value
                );
            }
        }

        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
            }
        }

        
        public bool shadowEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "shadowEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowEnabled",
                    value
                );
            }
        }

        
        public AbstractMesh[] includedOnlyMeshes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "includedOnlyMeshes",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "includedOnlyMeshes",
                    value
                );
            }
        }

        
        public AbstractMesh[] excludedMeshes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "excludedMeshes",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "excludedMeshes",
                    value
                );
            }
        }

        
        public decimal excludeWithLayerMask
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "excludeWithLayerMask"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "excludeWithLayerMask",
                    value
                );
            }
        }

        
        public decimal includeOnlyWithLayerMask
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "includeOnlyWithLayerMask"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "includeOnlyWithLayerMask",
                    value
                );
            }
        }

        
        public decimal lightmapMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lightmapMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lightmapMode",
                    value
                );
            }
        }
        #endregion

        #region Properties
        private Color3 __diffuse;
        public Color3 diffuse
        {
            get
            {
            if(__diffuse == null)
            {
                __diffuse = EventHorizonBlazorInterop.GetClass<Color3>(
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
            set
            {
__diffuse = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "diffuse",
                    value
                );
            }
        }

        private Color3 __specular;
        public Color3 specular
        {
            get
            {
            if(__specular == null)
            {
                __specular = EventHorizonBlazorInterop.GetClass<Color3>(
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
            set
            {
__specular = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "specular",
                    value
                );
            }
        }

        
        public decimal falloffType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "falloffType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "falloffType",
                    value
                );
            }
        }

        
        public decimal intensity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "intensity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "intensity",
                    value
                );
            }
        }

        
        public decimal renderPriority
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderPriority"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderPriority",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Light() : base() { }

        public Light(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Light(
            string name, Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Light" },
                name, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Light transferToEffect(Effect effect, string lightIndex)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transferToEffect" }, effect, lightIndex
                }
            );
        }

        public Light transferTexturesToEffect(Effect effect, string lightIndex)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transferTexturesToEffect" }, effect, lightIndex
                }
            );
        }

        public Light transferToNodeMaterialEffect(Effect effect, string lightDataUniformName)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transferToNodeMaterialEffect" }, effect, lightDataUniformName
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

        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }

        public void setEnabled(bool value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEnabled" }, value
                }
            );
        }

        public IShadowGeneratorCachedEntity getShadowGenerator()
        {
            return EventHorizonBlazorInterop.FuncClass<IShadowGeneratorCachedEntity>(
                entity => new IShadowGeneratorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getShadowGenerator" }
                }
            );
        }

        public Vector3 getAbsolutePosition()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAbsolutePosition" }
                }
            );
        }

        public bool canAffectMesh(AbstractMesh mesh)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "canAffectMesh" }, mesh
                }
            );
        }

        public void dispose(System.Nullable<bool> doNotRecurse = null, System.Nullable<bool> disposeMaterialAndTextures = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, doNotRecurse, disposeMaterialAndTextures
                }
            );
        }

        public decimal getTypeID()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTypeID" }
                }
            );
        }

        public decimal getScaledIntensity()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getScaledIntensity" }
                }
            );
        }

        public Light clone(string name, Node newParent = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, name, newParent
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public void prepareLightSpecificDefines(object defines, decimal lightIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareLightSpecificDefines" }, defines, lightIndex
                }
            );
        }
        #endregion
    }
}