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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Scene>))]
    public class Scene : AbstractScene, IAnimatable, IClipPlanesHolder
    {
        #region Static Accessors
        
        public static decimal DragMovementThreshold
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.DragMovementThreshold"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Scene.DragMovementThreshold",
                    value
                );
            }
        }

        
        public static decimal LongPressDelay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.LongPressDelay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Scene.LongPressDelay",
                    value
                );
            }
        }

        
        public static decimal DoubleClickDelay
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.DoubleClickDelay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Scene.DoubleClickDelay",
                    value
                );
            }
        }

        
        public static bool ExclusiveDoubleClickMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Scene.ExclusiveDoubleClickMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Scene.ExclusiveDoubleClickMode",
                    value
                );
            }
        }
        #endregion

        #region Static Properties
        
        public static decimal FOGMODE_NONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.FOGMODE_NONE"
                );
            }
        }

        
        public static decimal FOGMODE_EXP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.FOGMODE_EXP"
                );
            }
        }

        
        public static decimal FOGMODE_EXP2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.FOGMODE_EXP2"
                );
            }
        }

        
        public static decimal FOGMODE_LINEAR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.FOGMODE_LINEAR"
                );
            }
        }

        
        public static decimal MinDeltaTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.MinDeltaTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Scene.MinDeltaTime",
                    value
                );
            }
        }

        
        public static decimal MaxDeltaTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.MaxDeltaTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Scene.MaxDeltaTime",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static Material DefaultMaterialFactory(Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Scene", "DefaultMaterialFactory" }, scene
                }
            );
        }

        public static ICollisionCoordinatorCachedEntity CollisionCoordinatorFactory()
        {
            return EventHorizonBlazorInterop.FuncClass<ICollisionCoordinatorCachedEntity>(
                entity => new ICollisionCoordinatorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Scene", "CollisionCoordinatorFactory" }
                }
            );
        }
        #endregion

        #region Accessors
        private BaseTexture __environmentTexture;
        public BaseTexture environmentTexture
        {
            get
            {
            if(__environmentTexture == null)
            {
                __environmentTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "environmentTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __environmentTexture;
            }
            set
            {
__environmentTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "environmentTexture",
                    value
                );
            }
        }

        
        public decimal environmentIntensity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "environmentIntensity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "environmentIntensity",
                    value
                );
            }
        }

        private ImageProcessingConfiguration __imageProcessingConfiguration;
        public ImageProcessingConfiguration imageProcessingConfiguration
        {
            get
            {
            if(__imageProcessingConfiguration == null)
            {
                __imageProcessingConfiguration = EventHorizonBlazorInterop.GetClass<ImageProcessingConfiguration>(
                    this.___guid,
                    "imageProcessingConfiguration",
                    (entity) =>
                    {
                        return new ImageProcessingConfiguration() { ___guid = entity.___guid };
                    }
                );
            }
            return __imageProcessingConfiguration;
            }
        }

        
        public bool forceWireframe
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceWireframe"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forceWireframe",
                    value
                );
            }
        }

        
        public bool skipFrustumClipping
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skipFrustumClipping"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skipFrustumClipping",
                    value
                );
            }
        }

        
        public bool forcePointsCloud
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forcePointsCloud"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forcePointsCloud",
                    value
                );
            }
        }

        private AnimationPropertiesOverride __animationPropertiesOverride;
        public AnimationPropertiesOverride animationPropertiesOverride
        {
            get
            {
            if(__animationPropertiesOverride == null)
            {
                __animationPropertiesOverride = EventHorizonBlazorInterop.GetClass<AnimationPropertiesOverride>(
                    this.___guid,
                    "animationPropertiesOverride",
                    (entity) =>
                    {
                        return new AnimationPropertiesOverride() { ___guid = entity.___guid };
                    }
                );
            }
            return __animationPropertiesOverride;
            }
            set
            {
__animationPropertiesOverride = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationPropertiesOverride",
                    value
                );
            }
        }

        private Vector2 __unTranslatedPointer;
        public Vector2 unTranslatedPointer
        {
            get
            {
            if(__unTranslatedPointer == null)
            {
                __unTranslatedPointer = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "unTranslatedPointer",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __unTranslatedPointer;
            }
        }

        
        public bool useRightHandedSystem
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useRightHandedSystem"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useRightHandedSystem",
                    value
                );
            }
        }

        
        public bool fogEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "fogEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogEnabled",
                    value
                );
            }
        }

        
        public decimal fogMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fogMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogMode",
                    value
                );
            }
        }

        
        public bool shadowsEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "shadowsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowsEnabled",
                    value
                );
            }
        }

        
        public bool lightsEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "lightsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lightsEnabled",
                    value
                );
            }
        }

        private Camera __activeCamera;
        public Camera activeCamera
        {
            get
            {
            if(__activeCamera == null)
            {
                __activeCamera = EventHorizonBlazorInterop.GetClass<Camera>(
                    this.___guid,
                    "activeCamera",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            return __activeCamera;
            }
            set
            {
__activeCamera = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "activeCamera",
                    value
                );
            }
        }

        private Material __defaultMaterial;
        public Material defaultMaterial
        {
            get
            {
            if(__defaultMaterial == null)
            {
                __defaultMaterial = EventHorizonBlazorInterop.GetClass<Material>(
                    this.___guid,
                    "defaultMaterial",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
            }
            return __defaultMaterial;
            }
            set
            {
__defaultMaterial = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultMaterial",
                    value
                );
            }
        }

        
        public bool texturesEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "texturesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texturesEnabled",
                    value
                );
            }
        }

        
        public bool skeletonsEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skeletonsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skeletonsEnabled",
                    value
                );
            }
        }

        private ICollisionCoordinatorCachedEntity __collisionCoordinator;
        public ICollisionCoordinatorCachedEntity collisionCoordinator
        {
            get
            {
            if(__collisionCoordinator == null)
            {
                __collisionCoordinator = EventHorizonBlazorInterop.GetClass<ICollisionCoordinatorCachedEntity>(
                    this.___guid,
                    "collisionCoordinator",
                    (entity) =>
                    {
                        return new ICollisionCoordinatorCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __collisionCoordinator;
            }
        }

        
        public Plane[] frustumPlanes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Plane>(
                    this.___guid,
                    "frustumPlanes",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
        }

        private AbstractMesh __meshUnderPointer;
        public AbstractMesh meshUnderPointer
        {
            get
            {
            if(__meshUnderPointer == null)
            {
                __meshUnderPointer = EventHorizonBlazorInterop.GetClass<AbstractMesh>(
                    this.___guid,
                    "meshUnderPointer",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __meshUnderPointer;
            }
        }

        
        public decimal pointerX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pointerX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointerX",
                    value
                );
            }
        }

        
        public decimal pointerY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pointerY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointerY",
                    value
                );
            }
        }

        private PerfCounter __totalVerticesPerfCounter;
        public PerfCounter totalVerticesPerfCounter
        {
            get
            {
            if(__totalVerticesPerfCounter == null)
            {
                __totalVerticesPerfCounter = EventHorizonBlazorInterop.GetClass<PerfCounter>(
                    this.___guid,
                    "totalVerticesPerfCounter",
                    (entity) =>
                    {
                        return new PerfCounter() { ___guid = entity.___guid };
                    }
                );
            }
            return __totalVerticesPerfCounter;
            }
        }

        private PerfCounter __totalActiveIndicesPerfCounter;
        public PerfCounter totalActiveIndicesPerfCounter
        {
            get
            {
            if(__totalActiveIndicesPerfCounter == null)
            {
                __totalActiveIndicesPerfCounter = EventHorizonBlazorInterop.GetClass<PerfCounter>(
                    this.___guid,
                    "totalActiveIndicesPerfCounter",
                    (entity) =>
                    {
                        return new PerfCounter() { ___guid = entity.___guid };
                    }
                );
            }
            return __totalActiveIndicesPerfCounter;
            }
        }

        private PerfCounter __activeParticlesPerfCounter;
        public PerfCounter activeParticlesPerfCounter
        {
            get
            {
            if(__activeParticlesPerfCounter == null)
            {
                __activeParticlesPerfCounter = EventHorizonBlazorInterop.GetClass<PerfCounter>(
                    this.___guid,
                    "activeParticlesPerfCounter",
                    (entity) =>
                    {
                        return new PerfCounter() { ___guid = entity.___guid };
                    }
                );
            }
            return __activeParticlesPerfCounter;
            }
        }

        private PerfCounter __activeBonesPerfCounter;
        public PerfCounter activeBonesPerfCounter
        {
            get
            {
            if(__activeBonesPerfCounter == null)
            {
                __activeBonesPerfCounter = EventHorizonBlazorInterop.GetClass<PerfCounter>(
                    this.___guid,
                    "activeBonesPerfCounter",
                    (entity) =>
                    {
                        return new PerfCounter() { ___guid = entity.___guid };
                    }
                );
            }
            return __activeBonesPerfCounter;
            }
        }

        
        public bool isLoading
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLoading"
                );
            }
        }

        
        public Animatable[] animatables
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Animatable>(
                    this.___guid,
                    "animatables",
                    (entity) =>
                    {
                        return new Animatable() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public string uid
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "uid"
                );
            }
        }

        
        public bool blockfreeActiveMeshesAndRenderingGroups
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "blockfreeActiveMeshesAndRenderingGroups"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blockfreeActiveMeshesAndRenderingGroups",
                    value
                );
            }
        }

        
        public bool isDisposed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isDisposed"
                );
            }
        }

        
        public bool blockMaterialDirtyMechanism
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "blockMaterialDirtyMechanism"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blockMaterialDirtyMechanism",
                    value
                );
            }
        }
        #endregion

        #region Properties
        private Camera __cameraToUseForPointers;
        public Camera cameraToUseForPointers
        {
            get
            {
            if(__cameraToUseForPointers == null)
            {
                __cameraToUseForPointers = EventHorizonBlazorInterop.GetClass<Camera>(
                    this.___guid,
                    "cameraToUseForPointers",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            return __cameraToUseForPointers;
            }
            set
            {
__cameraToUseForPointers = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraToUseForPointers",
                    value
                );
            }
        }

        
        public bool autoClear
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClear"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClear",
                    value
                );
            }
        }

        
        public bool autoClearDepthAndStencil
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClearDepthAndStencil"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClearDepthAndStencil",
                    value
                );
            }
        }

        private Color4 __clearColor;
        public Color4 clearColor
        {
            get
            {
            if(__clearColor == null)
            {
                __clearColor = EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "clearColor",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __clearColor;
            }
            set
            {
__clearColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearColor",
                    value
                );
            }
        }

        private Color3 __ambientColor;
        public Color3 ambientColor
        {
            get
            {
            if(__ambientColor == null)
            {
                __ambientColor = EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "ambientColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __ambientColor;
            }
            set
            {
__ambientColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ambientColor",
                    value
                );
            }
        }

        private BaseTexture __environmentBRDFTexture;
        public BaseTexture environmentBRDFTexture
        {
            get
            {
            if(__environmentBRDFTexture == null)
            {
                __environmentBRDFTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "environmentBRDFTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __environmentBRDFTexture;
            }
            set
            {
__environmentBRDFTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "environmentBRDFTexture",
                    value
                );
            }
        }

        private Plane __clipPlane;
        public Plane clipPlane
        {
            get
            {
            if(__clipPlane == null)
            {
                __clipPlane = EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "clipPlane",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipPlane;
            }
            set
            {
__clipPlane = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane",
                    value
                );
            }
        }

        private Plane __clipPlane2;
        public Plane clipPlane2
        {
            get
            {
            if(__clipPlane2 == null)
            {
                __clipPlane2 = EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "clipPlane2",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipPlane2;
            }
            set
            {
__clipPlane2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane2",
                    value
                );
            }
        }

        private Plane __clipPlane3;
        public Plane clipPlane3
        {
            get
            {
            if(__clipPlane3 == null)
            {
                __clipPlane3 = EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "clipPlane3",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipPlane3;
            }
            set
            {
__clipPlane3 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane3",
                    value
                );
            }
        }

        private Plane __clipPlane4;
        public Plane clipPlane4
        {
            get
            {
            if(__clipPlane4 == null)
            {
                __clipPlane4 = EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "clipPlane4",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipPlane4;
            }
            set
            {
__clipPlane4 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane4",
                    value
                );
            }
        }

        private Plane __clipPlane5;
        public Plane clipPlane5
        {
            get
            {
            if(__clipPlane5 == null)
            {
                __clipPlane5 = EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "clipPlane5",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipPlane5;
            }
            set
            {
__clipPlane5 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane5",
                    value
                );
            }
        }

        private Plane __clipPlane6;
        public Plane clipPlane6
        {
            get
            {
            if(__clipPlane6 == null)
            {
                __clipPlane6 = EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "clipPlane6",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __clipPlane6;
            }
            set
            {
__clipPlane6 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane6",
                    value
                );
            }
        }

        
        public bool animationsEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "animationsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationsEnabled",
                    value
                );
            }
        }

        
        public bool useConstantAnimationDeltaTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useConstantAnimationDeltaTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useConstantAnimationDeltaTime",
                    value
                );
            }
        }

        
        public bool constantlyUpdateMeshUnderPointer
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "constantlyUpdateMeshUnderPointer"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "constantlyUpdateMeshUnderPointer",
                    value
                );
            }
        }

        
        public string hoverCursor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "hoverCursor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hoverCursor",
                    value
                );
            }
        }

        
        public string defaultCursor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "defaultCursor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultCursor",
                    value
                );
            }
        }

        
        public bool doNotHandleCursors
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotHandleCursors"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotHandleCursors",
                    value
                );
            }
        }

        
        public bool preventDefaultOnPointerDown
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preventDefaultOnPointerDown"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preventDefaultOnPointerDown",
                    value
                );
            }
        }

        
        public bool preventDefaultOnPointerUp
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preventDefaultOnPointerUp"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preventDefaultOnPointerUp",
                    value
                );
            }
        }

        
        public CachedEntity metadata
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "metadata",
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
                    "metadata",
                    value
                );
            }
        }

        
        public CachedEntity reservedDataStore
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "reservedDataStore",
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
                    "reservedDataStore",
                    value
                );
            }
        }

        
        public string loadingPluginName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "loadingPluginName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loadingPluginName",
                    value
                );
            }
        }

        
        public RegExp[] disableOfflineSupportExceptionRules
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<RegExp>(
                    this.___guid,
                    "disableOfflineSupportExceptionRules",
                    (entity) =>
                    {
                        return new RegExp() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableOfflineSupportExceptionRules",
                    value
                );
            }
        }

        private Observable<Scene> __onDisposeObservable;
        public Observable<Scene> onDisposeObservable
        {
            get
            {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onDisposeObservable;
            }
            set
            {
__onDisposeObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onBeforeRenderObservable;
        public Observable<Scene> onBeforeRenderObservable
        {
            get
            {
            if(__onBeforeRenderObservable == null)
            {
                __onBeforeRenderObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onBeforeRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeRenderObservable;
            }
            set
            {
__onBeforeRenderObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeRenderObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onAfterRenderObservable;
        public Observable<Scene> onAfterRenderObservable
        {
            get
            {
            if(__onAfterRenderObservable == null)
            {
                __onAfterRenderObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onAfterRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterRenderObservable;
            }
            set
            {
__onAfterRenderObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterRenderObservable",
                    value
                );
            }
        }

        private Observable<Camera> __onAfterRenderCameraObservable;
        public Observable<Camera> onAfterRenderCameraObservable
        {
            get
            {
            if(__onAfterRenderCameraObservable == null)
            {
                __onAfterRenderCameraObservable = EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
                    this.___guid,
                    "onAfterRenderCameraObservable",
                    (entity) =>
                    {
                        return new Observable<Camera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterRenderCameraObservable;
            }
            set
            {
__onAfterRenderCameraObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterRenderCameraObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onBeforeAnimationsObservable;
        public Observable<Scene> onBeforeAnimationsObservable
        {
            get
            {
            if(__onBeforeAnimationsObservable == null)
            {
                __onBeforeAnimationsObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onBeforeAnimationsObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeAnimationsObservable;
            }
            set
            {
__onBeforeAnimationsObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeAnimationsObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onAfterAnimationsObservable;
        public Observable<Scene> onAfterAnimationsObservable
        {
            get
            {
            if(__onAfterAnimationsObservable == null)
            {
                __onAfterAnimationsObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onAfterAnimationsObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterAnimationsObservable;
            }
            set
            {
__onAfterAnimationsObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterAnimationsObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onBeforeDrawPhaseObservable;
        public Observable<Scene> onBeforeDrawPhaseObservable
        {
            get
            {
            if(__onBeforeDrawPhaseObservable == null)
            {
                __onBeforeDrawPhaseObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onBeforeDrawPhaseObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeDrawPhaseObservable;
            }
            set
            {
__onBeforeDrawPhaseObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeDrawPhaseObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onAfterDrawPhaseObservable;
        public Observable<Scene> onAfterDrawPhaseObservable
        {
            get
            {
            if(__onAfterDrawPhaseObservable == null)
            {
                __onAfterDrawPhaseObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onAfterDrawPhaseObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterDrawPhaseObservable;
            }
            set
            {
__onAfterDrawPhaseObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterDrawPhaseObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onReadyObservable;
        public Observable<Scene> onReadyObservable
        {
            get
            {
            if(__onReadyObservable == null)
            {
                __onReadyObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onReadyObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onReadyObservable;
            }
            set
            {
__onReadyObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onReadyObservable",
                    value
                );
            }
        }

        private Observable<Camera> __onBeforeCameraRenderObservable;
        public Observable<Camera> onBeforeCameraRenderObservable
        {
            get
            {
            if(__onBeforeCameraRenderObservable == null)
            {
                __onBeforeCameraRenderObservable = EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
                    this.___guid,
                    "onBeforeCameraRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Camera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeCameraRenderObservable;
            }
            set
            {
__onBeforeCameraRenderObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeCameraRenderObservable",
                    value
                );
            }
        }

        private Observable<Camera> __onAfterCameraRenderObservable;
        public Observable<Camera> onAfterCameraRenderObservable
        {
            get
            {
            if(__onAfterCameraRenderObservable == null)
            {
                __onAfterCameraRenderObservable = EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
                    this.___guid,
                    "onAfterCameraRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Camera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterCameraRenderObservable;
            }
            set
            {
__onAfterCameraRenderObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterCameraRenderObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onBeforeActiveMeshesEvaluationObservable;
        public Observable<Scene> onBeforeActiveMeshesEvaluationObservable
        {
            get
            {
            if(__onBeforeActiveMeshesEvaluationObservable == null)
            {
                __onBeforeActiveMeshesEvaluationObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onBeforeActiveMeshesEvaluationObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeActiveMeshesEvaluationObservable;
            }
            set
            {
__onBeforeActiveMeshesEvaluationObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeActiveMeshesEvaluationObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onAfterActiveMeshesEvaluationObservable;
        public Observable<Scene> onAfterActiveMeshesEvaluationObservable
        {
            get
            {
            if(__onAfterActiveMeshesEvaluationObservable == null)
            {
                __onAfterActiveMeshesEvaluationObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onAfterActiveMeshesEvaluationObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterActiveMeshesEvaluationObservable;
            }
            set
            {
__onAfterActiveMeshesEvaluationObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterActiveMeshesEvaluationObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onBeforeParticlesRenderingObservable;
        public Observable<Scene> onBeforeParticlesRenderingObservable
        {
            get
            {
            if(__onBeforeParticlesRenderingObservable == null)
            {
                __onBeforeParticlesRenderingObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onBeforeParticlesRenderingObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeParticlesRenderingObservable;
            }
            set
            {
__onBeforeParticlesRenderingObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeParticlesRenderingObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onAfterParticlesRenderingObservable;
        public Observable<Scene> onAfterParticlesRenderingObservable
        {
            get
            {
            if(__onAfterParticlesRenderingObservable == null)
            {
                __onAfterParticlesRenderingObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onAfterParticlesRenderingObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterParticlesRenderingObservable;
            }
            set
            {
__onAfterParticlesRenderingObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterParticlesRenderingObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onDataLoadedObservable;
        public Observable<Scene> onDataLoadedObservable
        {
            get
            {
            if(__onDataLoadedObservable == null)
            {
                __onDataLoadedObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onDataLoadedObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onDataLoadedObservable;
            }
            set
            {
__onDataLoadedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDataLoadedObservable",
                    value
                );
            }
        }

        private Observable<Camera> __onNewCameraAddedObservable;
        public Observable<Camera> onNewCameraAddedObservable
        {
            get
            {
            if(__onNewCameraAddedObservable == null)
            {
                __onNewCameraAddedObservable = EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
                    this.___guid,
                    "onNewCameraAddedObservable",
                    (entity) =>
                    {
                        return new Observable<Camera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onNewCameraAddedObservable;
            }
            set
            {
__onNewCameraAddedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewCameraAddedObservable",
                    value
                );
            }
        }

        private Observable<Camera> __onCameraRemovedObservable;
        public Observable<Camera> onCameraRemovedObservable
        {
            get
            {
            if(__onCameraRemovedObservable == null)
            {
                __onCameraRemovedObservable = EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
                    this.___guid,
                    "onCameraRemovedObservable",
                    (entity) =>
                    {
                        return new Observable<Camera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onCameraRemovedObservable;
            }
            set
            {
__onCameraRemovedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCameraRemovedObservable",
                    value
                );
            }
        }

        private Observable<Light> __onNewLightAddedObservable;
        public Observable<Light> onNewLightAddedObservable
        {
            get
            {
            if(__onNewLightAddedObservable == null)
            {
                __onNewLightAddedObservable = EventHorizonBlazorInterop.GetClass<Observable<Light>>(
                    this.___guid,
                    "onNewLightAddedObservable",
                    (entity) =>
                    {
                        return new Observable<Light>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onNewLightAddedObservable;
            }
            set
            {
__onNewLightAddedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewLightAddedObservable",
                    value
                );
            }
        }

        private Observable<Light> __onLightRemovedObservable;
        public Observable<Light> onLightRemovedObservable
        {
            get
            {
            if(__onLightRemovedObservable == null)
            {
                __onLightRemovedObservable = EventHorizonBlazorInterop.GetClass<Observable<Light>>(
                    this.___guid,
                    "onLightRemovedObservable",
                    (entity) =>
                    {
                        return new Observable<Light>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onLightRemovedObservable;
            }
            set
            {
__onLightRemovedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onLightRemovedObservable",
                    value
                );
            }
        }

        private Observable<Geometry> __onNewGeometryAddedObservable;
        public Observable<Geometry> onNewGeometryAddedObservable
        {
            get
            {
            if(__onNewGeometryAddedObservable == null)
            {
                __onNewGeometryAddedObservable = EventHorizonBlazorInterop.GetClass<Observable<Geometry>>(
                    this.___guid,
                    "onNewGeometryAddedObservable",
                    (entity) =>
                    {
                        return new Observable<Geometry>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onNewGeometryAddedObservable;
            }
            set
            {
__onNewGeometryAddedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewGeometryAddedObservable",
                    value
                );
            }
        }

        private Observable<Geometry> __onGeometryRemovedObservable;
        public Observable<Geometry> onGeometryRemovedObservable
        {
            get
            {
            if(__onGeometryRemovedObservable == null)
            {
                __onGeometryRemovedObservable = EventHorizonBlazorInterop.GetClass<Observable<Geometry>>(
                    this.___guid,
                    "onGeometryRemovedObservable",
                    (entity) =>
                    {
                        return new Observable<Geometry>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onGeometryRemovedObservable;
            }
            set
            {
__onGeometryRemovedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onGeometryRemovedObservable",
                    value
                );
            }
        }

        private Observable<TransformNode> __onNewTransformNodeAddedObservable;
        public Observable<TransformNode> onNewTransformNodeAddedObservable
        {
            get
            {
            if(__onNewTransformNodeAddedObservable == null)
            {
                __onNewTransformNodeAddedObservable = EventHorizonBlazorInterop.GetClass<Observable<TransformNode>>(
                    this.___guid,
                    "onNewTransformNodeAddedObservable",
                    (entity) =>
                    {
                        return new Observable<TransformNode>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onNewTransformNodeAddedObservable;
            }
            set
            {
__onNewTransformNodeAddedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewTransformNodeAddedObservable",
                    value
                );
            }
        }

        private Observable<TransformNode> __onTransformNodeRemovedObservable;
        public Observable<TransformNode> onTransformNodeRemovedObservable
        {
            get
            {
            if(__onTransformNodeRemovedObservable == null)
            {
                __onTransformNodeRemovedObservable = EventHorizonBlazorInterop.GetClass<Observable<TransformNode>>(
                    this.___guid,
                    "onTransformNodeRemovedObservable",
                    (entity) =>
                    {
                        return new Observable<TransformNode>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onTransformNodeRemovedObservable;
            }
            set
            {
__onTransformNodeRemovedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onTransformNodeRemovedObservable",
                    value
                );
            }
        }

        private Observable<AbstractMesh> __onNewMeshAddedObservable;
        public Observable<AbstractMesh> onNewMeshAddedObservable
        {
            get
            {
            if(__onNewMeshAddedObservable == null)
            {
                __onNewMeshAddedObservable = EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
                    this.___guid,
                    "onNewMeshAddedObservable",
                    (entity) =>
                    {
                        return new Observable<AbstractMesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onNewMeshAddedObservable;
            }
            set
            {
__onNewMeshAddedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewMeshAddedObservable",
                    value
                );
            }
        }

        private Observable<AbstractMesh> __onMeshRemovedObservable;
        public Observable<AbstractMesh> onMeshRemovedObservable
        {
            get
            {
            if(__onMeshRemovedObservable == null)
            {
                __onMeshRemovedObservable = EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
                    this.___guid,
                    "onMeshRemovedObservable",
                    (entity) =>
                    {
                        return new Observable<AbstractMesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onMeshRemovedObservable;
            }
            set
            {
__onMeshRemovedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onMeshRemovedObservable",
                    value
                );
            }
        }

        private Observable<Skeleton> __onNewSkeletonAddedObservable;
        public Observable<Skeleton> onNewSkeletonAddedObservable
        {
            get
            {
            if(__onNewSkeletonAddedObservable == null)
            {
                __onNewSkeletonAddedObservable = EventHorizonBlazorInterop.GetClass<Observable<Skeleton>>(
                    this.___guid,
                    "onNewSkeletonAddedObservable",
                    (entity) =>
                    {
                        return new Observable<Skeleton>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onNewSkeletonAddedObservable;
            }
            set
            {
__onNewSkeletonAddedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewSkeletonAddedObservable",
                    value
                );
            }
        }

        private Observable<Skeleton> __onSkeletonRemovedObservable;
        public Observable<Skeleton> onSkeletonRemovedObservable
        {
            get
            {
            if(__onSkeletonRemovedObservable == null)
            {
                __onSkeletonRemovedObservable = EventHorizonBlazorInterop.GetClass<Observable<Skeleton>>(
                    this.___guid,
                    "onSkeletonRemovedObservable",
                    (entity) =>
                    {
                        return new Observable<Skeleton>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onSkeletonRemovedObservable;
            }
            set
            {
__onSkeletonRemovedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onSkeletonRemovedObservable",
                    value
                );
            }
        }

        private Observable<Material> __onNewMaterialAddedObservable;
        public Observable<Material> onNewMaterialAddedObservable
        {
            get
            {
            if(__onNewMaterialAddedObservable == null)
            {
                __onNewMaterialAddedObservable = EventHorizonBlazorInterop.GetClass<Observable<Material>>(
                    this.___guid,
                    "onNewMaterialAddedObservable",
                    (entity) =>
                    {
                        return new Observable<Material>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onNewMaterialAddedObservable;
            }
            set
            {
__onNewMaterialAddedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewMaterialAddedObservable",
                    value
                );
            }
        }

        private Observable<MultiMaterial> __onNewMultiMaterialAddedObservable;
        public Observable<MultiMaterial> onNewMultiMaterialAddedObservable
        {
            get
            {
            if(__onNewMultiMaterialAddedObservable == null)
            {
                __onNewMultiMaterialAddedObservable = EventHorizonBlazorInterop.GetClass<Observable<MultiMaterial>>(
                    this.___guid,
                    "onNewMultiMaterialAddedObservable",
                    (entity) =>
                    {
                        return new Observable<MultiMaterial>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onNewMultiMaterialAddedObservable;
            }
            set
            {
__onNewMultiMaterialAddedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewMultiMaterialAddedObservable",
                    value
                );
            }
        }

        private Observable<Material> __onMaterialRemovedObservable;
        public Observable<Material> onMaterialRemovedObservable
        {
            get
            {
            if(__onMaterialRemovedObservable == null)
            {
                __onMaterialRemovedObservable = EventHorizonBlazorInterop.GetClass<Observable<Material>>(
                    this.___guid,
                    "onMaterialRemovedObservable",
                    (entity) =>
                    {
                        return new Observable<Material>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onMaterialRemovedObservable;
            }
            set
            {
__onMaterialRemovedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onMaterialRemovedObservable",
                    value
                );
            }
        }

        private Observable<MultiMaterial> __onMultiMaterialRemovedObservable;
        public Observable<MultiMaterial> onMultiMaterialRemovedObservable
        {
            get
            {
            if(__onMultiMaterialRemovedObservable == null)
            {
                __onMultiMaterialRemovedObservable = EventHorizonBlazorInterop.GetClass<Observable<MultiMaterial>>(
                    this.___guid,
                    "onMultiMaterialRemovedObservable",
                    (entity) =>
                    {
                        return new Observable<MultiMaterial>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onMultiMaterialRemovedObservable;
            }
            set
            {
__onMultiMaterialRemovedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onMultiMaterialRemovedObservable",
                    value
                );
            }
        }

        private Observable<BaseTexture> __onNewTextureAddedObservable;
        public Observable<BaseTexture> onNewTextureAddedObservable
        {
            get
            {
            if(__onNewTextureAddedObservable == null)
            {
                __onNewTextureAddedObservable = EventHorizonBlazorInterop.GetClass<Observable<BaseTexture>>(
                    this.___guid,
                    "onNewTextureAddedObservable",
                    (entity) =>
                    {
                        return new Observable<BaseTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onNewTextureAddedObservable;
            }
            set
            {
__onNewTextureAddedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewTextureAddedObservable",
                    value
                );
            }
        }

        private Observable<BaseTexture> __onTextureRemovedObservable;
        public Observable<BaseTexture> onTextureRemovedObservable
        {
            get
            {
            if(__onTextureRemovedObservable == null)
            {
                __onTextureRemovedObservable = EventHorizonBlazorInterop.GetClass<Observable<BaseTexture>>(
                    this.___guid,
                    "onTextureRemovedObservable",
                    (entity) =>
                    {
                        return new Observable<BaseTexture>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onTextureRemovedObservable;
            }
            set
            {
__onTextureRemovedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onTextureRemovedObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onBeforeRenderTargetsRenderObservable;
        public Observable<Scene> onBeforeRenderTargetsRenderObservable
        {
            get
            {
            if(__onBeforeRenderTargetsRenderObservable == null)
            {
                __onBeforeRenderTargetsRenderObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onBeforeRenderTargetsRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeRenderTargetsRenderObservable;
            }
            set
            {
__onBeforeRenderTargetsRenderObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeRenderTargetsRenderObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onAfterRenderTargetsRenderObservable;
        public Observable<Scene> onAfterRenderTargetsRenderObservable
        {
            get
            {
            if(__onAfterRenderTargetsRenderObservable == null)
            {
                __onAfterRenderTargetsRenderObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onAfterRenderTargetsRenderObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterRenderTargetsRenderObservable;
            }
            set
            {
__onAfterRenderTargetsRenderObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterRenderTargetsRenderObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onBeforeStepObservable;
        public Observable<Scene> onBeforeStepObservable
        {
            get
            {
            if(__onBeforeStepObservable == null)
            {
                __onBeforeStepObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onBeforeStepObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeStepObservable;
            }
            set
            {
__onBeforeStepObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeStepObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onAfterStepObservable;
        public Observable<Scene> onAfterStepObservable
        {
            get
            {
            if(__onAfterStepObservable == null)
            {
                __onAfterStepObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onAfterStepObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterStepObservable;
            }
            set
            {
__onAfterStepObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterStepObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onActiveCameraChanged;
        public Observable<Scene> onActiveCameraChanged
        {
            get
            {
            if(__onActiveCameraChanged == null)
            {
                __onActiveCameraChanged = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onActiveCameraChanged",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onActiveCameraChanged;
            }
            set
            {
__onActiveCameraChanged = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onActiveCameraChanged",
                    value
                );
            }
        }

        private Observable<RenderingGroupInfo> __onBeforeRenderingGroupObservable;
        public Observable<RenderingGroupInfo> onBeforeRenderingGroupObservable
        {
            get
            {
            if(__onBeforeRenderingGroupObservable == null)
            {
                __onBeforeRenderingGroupObservable = EventHorizonBlazorInterop.GetClass<Observable<RenderingGroupInfo>>(
                    this.___guid,
                    "onBeforeRenderingGroupObservable",
                    (entity) =>
                    {
                        return new Observable<RenderingGroupInfo>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeRenderingGroupObservable;
            }
            set
            {
__onBeforeRenderingGroupObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeRenderingGroupObservable",
                    value
                );
            }
        }

        private Observable<RenderingGroupInfo> __onAfterRenderingGroupObservable;
        public Observable<RenderingGroupInfo> onAfterRenderingGroupObservable
        {
            get
            {
            if(__onAfterRenderingGroupObservable == null)
            {
                __onAfterRenderingGroupObservable = EventHorizonBlazorInterop.GetClass<Observable<RenderingGroupInfo>>(
                    this.___guid,
                    "onAfterRenderingGroupObservable",
                    (entity) =>
                    {
                        return new Observable<RenderingGroupInfo>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterRenderingGroupObservable;
            }
            set
            {
__onAfterRenderingGroupObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterRenderingGroupObservable",
                    value
                );
            }
        }

        private Observable<AbstractMesh> __onMeshImportedObservable;
        public Observable<AbstractMesh> onMeshImportedObservable
        {
            get
            {
            if(__onMeshImportedObservable == null)
            {
                __onMeshImportedObservable = EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
                    this.___guid,
                    "onMeshImportedObservable",
                    (entity) =>
                    {
                        return new Observable<AbstractMesh>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onMeshImportedObservable;
            }
            set
            {
__onMeshImportedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onMeshImportedObservable",
                    value
                );
            }
        }

        private Observable<Scene> __onAnimationFileImportedObservable;
        public Observable<Scene> onAnimationFileImportedObservable
        {
            get
            {
            if(__onAnimationFileImportedObservable == null)
            {
                __onAnimationFileImportedObservable = EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
                    this.___guid,
                    "onAnimationFileImportedObservable",
                    (entity) =>
                    {
                        return new Observable<Scene>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAnimationFileImportedObservable;
            }
            set
            {
__onAnimationFileImportedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAnimationFileImportedObservable",
                    value
                );
            }
        }

        private Observable<PointerInfoPre> __onPrePointerObservable;
        public Observable<PointerInfoPre> onPrePointerObservable
        {
            get
            {
            if(__onPrePointerObservable == null)
            {
                __onPrePointerObservable = EventHorizonBlazorInterop.GetClass<Observable<PointerInfoPre>>(
                    this.___guid,
                    "onPrePointerObservable",
                    (entity) =>
                    {
                        return new Observable<PointerInfoPre>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onPrePointerObservable;
            }
            set
            {
__onPrePointerObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onPrePointerObservable",
                    value
                );
            }
        }

        private Observable<PointerInfo> __onPointerObservable;
        public Observable<PointerInfo> onPointerObservable
        {
            get
            {
            if(__onPointerObservable == null)
            {
                __onPointerObservable = EventHorizonBlazorInterop.GetClass<Observable<PointerInfo>>(
                    this.___guid,
                    "onPointerObservable",
                    (entity) =>
                    {
                        return new Observable<PointerInfo>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onPointerObservable;
            }
            set
            {
__onPointerObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onPointerObservable",
                    value
                );
            }
        }

        private Observable<KeyboardInfoPre> __onPreKeyboardObservable;
        public Observable<KeyboardInfoPre> onPreKeyboardObservable
        {
            get
            {
            if(__onPreKeyboardObservable == null)
            {
                __onPreKeyboardObservable = EventHorizonBlazorInterop.GetClass<Observable<KeyboardInfoPre>>(
                    this.___guid,
                    "onPreKeyboardObservable",
                    (entity) =>
                    {
                        return new Observable<KeyboardInfoPre>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onPreKeyboardObservable;
            }
            set
            {
__onPreKeyboardObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onPreKeyboardObservable",
                    value
                );
            }
        }

        private Observable<KeyboardInfo> __onKeyboardObservable;
        public Observable<KeyboardInfo> onKeyboardObservable
        {
            get
            {
            if(__onKeyboardObservable == null)
            {
                __onKeyboardObservable = EventHorizonBlazorInterop.GetClass<Observable<KeyboardInfo>>(
                    this.___guid,
                    "onKeyboardObservable",
                    (entity) =>
                    {
                        return new Observable<KeyboardInfo>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onKeyboardObservable;
            }
            set
            {
__onKeyboardObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onKeyboardObservable",
                    value
                );
            }
        }

        private Color3 __fogColor;
        public Color3 fogColor
        {
            get
            {
            if(__fogColor == null)
            {
                __fogColor = EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "fogColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __fogColor;
            }
            set
            {
__fogColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogColor",
                    value
                );
            }
        }

        
        public decimal fogDensity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fogDensity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogDensity",
                    value
                );
            }
        }

        
        public decimal fogStart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fogStart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogStart",
                    value
                );
            }
        }

        
        public decimal fogEnd
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fogEnd"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogEnd",
                    value
                );
            }
        }

        
        public bool prePass
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "prePass"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "prePass",
                    value
                );
            }
        }

        
        public Camera[] activeCameras
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Camera>(
                    this.___guid,
                    "activeCameras",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "activeCameras",
                    value
                );
            }
        }

        
        public bool physicsEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "physicsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "physicsEnabled",
                    value
                );
            }
        }

        
        public bool particlesEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "particlesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "particlesEnabled",
                    value
                );
            }
        }

        
        public bool spritesEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "spritesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "spritesEnabled",
                    value
                );
            }
        }

        
        public bool lensFlaresEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "lensFlaresEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lensFlaresEnabled",
                    value
                );
            }
        }

        
        public bool collisionsEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collisionsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionsEnabled",
                    value
                );
            }
        }

        private Vector3 __gravity;
        public Vector3 gravity
        {
            get
            {
            if(__gravity == null)
            {
                __gravity = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "gravity",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __gravity;
            }
            set
            {
__gravity = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gravity",
                    value
                );
            }
        }

        
        public bool postProcessesEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "postProcessesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "postProcessesEnabled",
                    value
                );
            }
        }

        private PostProcessManager __postProcessManager;
        public PostProcessManager postProcessManager
        {
            get
            {
            if(__postProcessManager == null)
            {
                __postProcessManager = EventHorizonBlazorInterop.GetClass<PostProcessManager>(
                    this.___guid,
                    "postProcessManager",
                    (entity) =>
                    {
                        return new PostProcessManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __postProcessManager;
            }
            set
            {
__postProcessManager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "postProcessManager",
                    value
                );
            }
        }

        
        public bool renderTargetsEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderTargetsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderTargetsEnabled",
                    value
                );
            }
        }

        
        public bool dumpNextRenderTargets
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "dumpNextRenderTargets"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dumpNextRenderTargets",
                    value
                );
            }
        }

        
        public RenderTargetTexture[] customRenderTargets
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<RenderTargetTexture>(
                    this.___guid,
                    "customRenderTargets",
                    (entity) =>
                    {
                        return new RenderTargetTexture() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customRenderTargets",
                    value
                );
            }
        }

        
        public bool useDelayedTextureLoading
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useDelayedTextureLoading"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useDelayedTextureLoading",
                    value
                );
            }
        }

        
        public string[] importedMeshesFiles
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "importedMeshesFiles"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "importedMeshesFiles",
                    value
                );
            }
        }

        
        public bool probesEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "probesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "probesEnabled",
                    value
                );
            }
        }

        private IOfflineProviderCachedEntity __offlineProvider;
        public IOfflineProviderCachedEntity offlineProvider
        {
            get
            {
            if(__offlineProvider == null)
            {
                __offlineProvider = EventHorizonBlazorInterop.GetClass<IOfflineProviderCachedEntity>(
                    this.___guid,
                    "offlineProvider",
                    (entity) =>
                    {
                        return new IOfflineProviderCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __offlineProvider;
            }
            set
            {
__offlineProvider = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offlineProvider",
                    value
                );
            }
        }

        private AbstractActionManager __actionManager;
        public AbstractActionManager actionManager
        {
            get
            {
            if(__actionManager == null)
            {
                __actionManager = EventHorizonBlazorInterop.GetClass<AbstractActionManager>(
                    this.___guid,
                    "actionManager",
                    (entity) =>
                    {
                        return new AbstractActionManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __actionManager;
            }
            set
            {
__actionManager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "actionManager",
                    value
                );
            }
        }

        
        public bool proceduralTexturesEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "proceduralTexturesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "proceduralTexturesEnabled",
                    value
                );
            }
        }

        
        public decimal animationTimeScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "animationTimeScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationTimeScale",
                    value
                );
            }
        }

        
        public bool dispatchAllSubMeshesOfActiveMeshes
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "dispatchAllSubMeshesOfActiveMeshes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dispatchAllSubMeshesOfActiveMeshes",
                    value
                );
            }
        }

        
        public bool requireLightSorting
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "requireLightSorting"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "requireLightSorting",
                    value
                );
            }
        }

        
        public bool useMaterialMeshMap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useMaterialMeshMap"
                );
            }
        }

        
        public bool useClonedMeshMap
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useClonedMeshMap"
                );
            }
        }
        #endregion
        
        #region Constructor
        public Scene() : base() { }

        public Scene(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Scene(
            Engine engine, SceneOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Scene" },
                engine, options
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region customLODSelector TODO: Get Comments as metadata identification
        private bool _isCustomLODSelectorEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customLODSelectorActionMap = new Dictionary<string, Func<Task>>();

        public string customLODSelector(
            Func<Task> callback
        )
        {
            SetupCustomLODSelectorLoop();

            var handle = Guid.NewGuid().ToString();
            _customLODSelectorActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool customLODSelector_Remove(
            string handle
        )
        {
            return _customLODSelectorActionMap.Remove(
                handle
            );
        }

        private void SetupCustomLODSelectorLoop()
        {
            if (_isCustomLODSelectorEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "customLODSelector",
                "CallCustomLODSelectorActions",
                _invokableReference
            );
            _isCustomLODSelectorEnabled = true;
        }

        [JSInvokable]
        public async Task CallCustomLODSelectorActions()
        {
            foreach (var action in _customLODSelectorActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region pointerDownPredicate TODO: Get Comments as metadata identification
        private bool _isPointerDownPredicateEnabled = false;
        private readonly IDictionary<string, Func<Task>> _pointerDownPredicateActionMap = new Dictionary<string, Func<Task>>();

        public string pointerDownPredicate(
            Func<Task> callback
        )
        {
            SetupPointerDownPredicateLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerDownPredicateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool pointerDownPredicate_Remove(
            string handle
        )
        {
            return _pointerDownPredicateActionMap.Remove(
                handle
            );
        }

        private void SetupPointerDownPredicateLoop()
        {
            if (_isPointerDownPredicateEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "pointerDownPredicate",
                "CallPointerDownPredicateActions",
                _invokableReference
            );
            _isPointerDownPredicateEnabled = true;
        }

        [JSInvokable]
        public async Task CallPointerDownPredicateActions()
        {
            foreach (var action in _pointerDownPredicateActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region pointerUpPredicate TODO: Get Comments as metadata identification
        private bool _isPointerUpPredicateEnabled = false;
        private readonly IDictionary<string, Func<Task>> _pointerUpPredicateActionMap = new Dictionary<string, Func<Task>>();

        public string pointerUpPredicate(
            Func<Task> callback
        )
        {
            SetupPointerUpPredicateLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerUpPredicateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool pointerUpPredicate_Remove(
            string handle
        )
        {
            return _pointerUpPredicateActionMap.Remove(
                handle
            );
        }

        private void SetupPointerUpPredicateLoop()
        {
            if (_isPointerUpPredicateEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "pointerUpPredicate",
                "CallPointerUpPredicateActions",
                _invokableReference
            );
            _isPointerUpPredicateEnabled = true;
        }

        [JSInvokable]
        public async Task CallPointerUpPredicateActions()
        {
            foreach (var action in _pointerUpPredicateActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region pointerMovePredicate TODO: Get Comments as metadata identification
        private bool _isPointerMovePredicateEnabled = false;
        private readonly IDictionary<string, Func<Task>> _pointerMovePredicateActionMap = new Dictionary<string, Func<Task>>();

        public string pointerMovePredicate(
            Func<Task> callback
        )
        {
            SetupPointerMovePredicateLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerMovePredicateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool pointerMovePredicate_Remove(
            string handle
        )
        {
            return _pointerMovePredicateActionMap.Remove(
                handle
            );
        }

        private void SetupPointerMovePredicateLoop()
        {
            if (_isPointerMovePredicateEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "pointerMovePredicate",
                "CallPointerMovePredicateActions",
                _invokableReference
            );
            _isPointerMovePredicateEnabled = true;
        }

        [JSInvokable]
        public async Task CallPointerMovePredicateActions()
        {
            foreach (var action in _pointerMovePredicateActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onPointerMove TODO: Get Comments as metadata identification
        private bool _isOnPointerMoveEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onPointerMoveActionMap = new Dictionary<string, Func<Task>>();

        public string onPointerMove(
            Func<Task> callback
        )
        {
            SetupOnPointerMoveLoop();

            var handle = Guid.NewGuid().ToString();
            _onPointerMoveActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onPointerMove_Remove(
            string handle
        )
        {
            return _onPointerMoveActionMap.Remove(
                handle
            );
        }

        private void SetupOnPointerMoveLoop()
        {
            if (_isOnPointerMoveEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onPointerMove",
                "CallOnPointerMoveActions",
                _invokableReference
            );
            _isOnPointerMoveEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnPointerMoveActions()
        {
            foreach (var action in _onPointerMoveActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onPointerDown TODO: Get Comments as metadata identification
        private bool _isOnPointerDownEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onPointerDownActionMap = new Dictionary<string, Func<Task>>();

        public string onPointerDown(
            Func<Task> callback
        )
        {
            SetupOnPointerDownLoop();

            var handle = Guid.NewGuid().ToString();
            _onPointerDownActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onPointerDown_Remove(
            string handle
        )
        {
            return _onPointerDownActionMap.Remove(
                handle
            );
        }

        private void SetupOnPointerDownLoop()
        {
            if (_isOnPointerDownEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onPointerDown",
                "CallOnPointerDownActions",
                _invokableReference
            );
            _isOnPointerDownEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnPointerDownActions()
        {
            foreach (var action in _onPointerDownActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onPointerUp TODO: Get Comments as metadata identification
        private bool _isOnPointerUpEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onPointerUpActionMap = new Dictionary<string, Func<Task>>();

        public string onPointerUp(
            Func<Task> callback
        )
        {
            SetupOnPointerUpLoop();

            var handle = Guid.NewGuid().ToString();
            _onPointerUpActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onPointerUp_Remove(
            string handle
        )
        {
            return _onPointerUpActionMap.Remove(
                handle
            );
        }

        private void SetupOnPointerUpLoop()
        {
            if (_isOnPointerUpEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onPointerUp",
                "CallOnPointerUpActions",
                _invokableReference
            );
            _isOnPointerUpEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnPointerUpActions()
        {
            foreach (var action in _onPointerUpActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region onPointerPick TODO: Get Comments as metadata identification
        private bool _isOnPointerPickEnabled = false;
        private readonly IDictionary<string, Func<Task>> _onPointerPickActionMap = new Dictionary<string, Func<Task>>();

        public string onPointerPick(
            Func<Task> callback
        )
        {
            SetupOnPointerPickLoop();

            var handle = Guid.NewGuid().ToString();
            _onPointerPickActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onPointerPick_Remove(
            string handle
        )
        {
            return _onPointerPickActionMap.Remove(
                handle
            );
        }

        private void SetupOnPointerPickLoop()
        {
            if (_isOnPointerPickEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onPointerPick",
                "CallOnPointerPickActions",
                _invokableReference
            );
            _isOnPointerPickEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnPointerPickActions()
        {
            foreach (var action in _onPointerPickActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void setStepId(decimal newStepId)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setStepId" }, newStepId
                }
            );
        }

        public decimal getStepId()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getStepId" }
                }
            );
        }

        public decimal getInternalStep()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getInternalStep" }
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

        public void setDefaultCandidateProviders()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setDefaultCandidateProviders" }
                }
            );
        }

        public Material getCachedMaterial()
        {
            return EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCachedMaterial" }
                }
            );
        }

        public Effect getCachedEffect()
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCachedEffect" }
                }
            );
        }

        public decimal getCachedVisibility()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getCachedVisibility" }
                }
            );
        }

        public bool isCachedMaterialInvalid(Material material, Effect effect, System.Nullable<decimal> visibility = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isCachedMaterialInvalid" }, material, effect, visibility
                }
            );
        }

        public Engine getEngine()
        {
            return EventHorizonBlazorInterop.FuncClass<Engine>(
                entity => new Engine() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEngine" }
                }
            );
        }

        public decimal getTotalVertices()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTotalVertices" }
                }
            );
        }

        public decimal getActiveIndices()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getActiveIndices" }
                }
            );
        }

        public decimal getActiveParticles()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getActiveParticles" }
                }
            );
        }

        public decimal getActiveBones()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getActiveBones" }
                }
            );
        }

        public SmartArray<AbstractMesh> getActiveMeshes()
        {
            return EventHorizonBlazorInterop.FuncClass<SmartArray<AbstractMesh>>(
                entity => new SmartArray<AbstractMesh>() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveMeshes" }
                }
            );
        }

        public decimal getAnimationRatio()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAnimationRatio" }
                }
            );
        }

        public decimal getRenderId()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getRenderId" }
                }
            );
        }

        public decimal getFrameId()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getFrameId" }
                }
            );
        }

        public void incrementRenderId()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "incrementRenderId" }
                }
            );
        }

        public Scene simulatePointerMove(PickingInfo pickResult, PointerEventInit pointerEventInit = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "simulatePointerMove" }, pickResult, pointerEventInit
                }
            );
        }

        public Scene simulatePointerDown(PickingInfo pickResult, PointerEventInit pointerEventInit = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "simulatePointerDown" }, pickResult, pointerEventInit
                }
            );
        }

        public Scene simulatePointerUp(PickingInfo pickResult, PointerEventInit pointerEventInit = null, System.Nullable<bool> doubleTap = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "simulatePointerUp" }, pickResult, pointerEventInit, doubleTap
                }
            );
        }

        public bool isPointerCaptured(System.Nullable<decimal> pointerId = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isPointerCaptured" }, pointerId
                }
            );
        }

        public void attachControl(System.Nullable<bool> attachUp = null, System.Nullable<bool> attachDown = null, System.Nullable<bool> attachMove = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "attachControl" }, attachUp, attachDown, attachMove
                }
            );
        }

        public void detachControl()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "detachControl" }
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public void resetCachedMaterial()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetCachedMaterial" }
                }
            );
        }

        public void registerBeforeRender(ActionCallback func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "registerBeforeRender" }, func
                }
            );
        }

        public void unregisterBeforeRender(ActionCallback func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unregisterBeforeRender" }, func
                }
            );
        }

        public void registerAfterRender(ActionCallback func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "registerAfterRender" }, func
                }
            );
        }

        public void unregisterAfterRender(ActionCallback func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unregisterAfterRender" }, func
                }
            );
        }

        public void executeOnceBeforeRender(ActionCallback func, System.Nullable<decimal> timeout = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "executeOnceBeforeRender" }, func, timeout
                }
            );
        }

        public decimal getWaitingItemsCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getWaitingItemsCount" }
                }
            );
        }

        public void executeWhenReady(ActionCallback func)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "executeWhenReady" }, func
                }
            );
        }

        public async ValueTask whenReadyAsync()
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "whenReadyAsync" }
                }
            );
        }

        public void resetLastAnimationTimeFrame()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetLastAnimationTimeFrame" }
                }
            );
        }

        public Matrix getViewMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getViewMatrix" }
                }
            );
        }

        public Matrix getProjectionMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getProjectionMatrix" }
                }
            );
        }

        public Matrix getTransformMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformMatrix" }
                }
            );
        }

        public void setTransformMatrix(Matrix viewL, Matrix projectionL, Matrix viewR = null, Matrix projectionR = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTransformMatrix" }, viewL, projectionL, viewR, projectionR
                }
            );
        }

        public UniformBuffer getSceneUniformBuffer()
        {
            return EventHorizonBlazorInterop.FuncClass<UniformBuffer>(
                entity => new UniformBuffer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSceneUniformBuffer" }
                }
            );
        }

        public decimal getUniqueId()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getUniqueId" }
                }
            );
        }

        public void addMesh(AbstractMesh newMesh, System.Nullable<bool> recursive = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addMesh" }, newMesh, recursive
                }
            );
        }

        public decimal removeMesh(AbstractMesh toRemove, System.Nullable<bool> recursive = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeMesh" }, toRemove, recursive
                }
            );
        }

        public void addTransformNode(TransformNode newTransformNode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addTransformNode" }, newTransformNode
                }
            );
        }

        public decimal removeTransformNode(TransformNode toRemove)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeTransformNode" }, toRemove
                }
            );
        }

        public decimal removeSkeleton(Skeleton toRemove)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeSkeleton" }, toRemove
                }
            );
        }

        public decimal removeMorphTargetManager(MorphTargetManager toRemove)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeMorphTargetManager" }, toRemove
                }
            );
        }

        public decimal removeLight(Light toRemove)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeLight" }, toRemove
                }
            );
        }

        public decimal removeCamera(Camera toRemove)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeCamera" }, toRemove
                }
            );
        }

        public decimal removeParticleSystem(IParticleSystem toRemove)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeParticleSystem" }, toRemove
                }
            );
        }

        public decimal removeAnimation(Animation toRemove)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeAnimation" }, toRemove
                }
            );
        }

        public void stopAnimation(object target, string animationName = null, ActionResultCallback<object, bool> targetMask = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stopAnimation" }, target, animationName, targetMask
                }
            );
        }

        public decimal removeAnimationGroup(AnimationGroup toRemove)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeAnimationGroup" }, toRemove
                }
            );
        }

        public decimal removeMultiMaterial(MultiMaterial toRemove)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeMultiMaterial" }, toRemove
                }
            );
        }

        public decimal removeMaterial(Material toRemove)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeMaterial" }, toRemove
                }
            );
        }

        public decimal removeActionManager(AbstractActionManager toRemove)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeActionManager" }, toRemove
                }
            );
        }

        public decimal removeTexture(BaseTexture toRemove)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "removeTexture" }, toRemove
                }
            );
        }

        public void addLight(Light newLight)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addLight" }, newLight
                }
            );
        }

        public void sortLightsByPriority()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "sortLightsByPriority" }
                }
            );
        }

        public void addCamera(Camera newCamera)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addCamera" }, newCamera
                }
            );
        }

        public void addSkeleton(Skeleton newSkeleton)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addSkeleton" }, newSkeleton
                }
            );
        }

        public void addParticleSystem(IParticleSystem newParticleSystem)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addParticleSystem" }, newParticleSystem
                }
            );
        }

        public void addAnimation(Animation newAnimation)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addAnimation" }, newAnimation
                }
            );
        }

        public void addAnimationGroup(AnimationGroup newAnimationGroup)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addAnimationGroup" }, newAnimationGroup
                }
            );
        }

        public void addMultiMaterial(MultiMaterial newMultiMaterial)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addMultiMaterial" }, newMultiMaterial
                }
            );
        }

        public void addMaterial(Material newMaterial)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addMaterial" }, newMaterial
                }
            );
        }

        public void addMorphTargetManager(MorphTargetManager newMorphTargetManager)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addMorphTargetManager" }, newMorphTargetManager
                }
            );
        }

        public void addGeometry(Geometry newGeometry)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addGeometry" }, newGeometry
                }
            );
        }

        public void addActionManager(AbstractActionManager newActionManager)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addActionManager" }, newActionManager
                }
            );
        }

        public void addTexture(BaseTexture newTexture)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addTexture" }, newTexture
                }
            );
        }

        public void switchActiveCamera(Camera newCamera, System.Nullable<bool> attachControl = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "switchActiveCamera" }, newCamera, attachControl
                }
            );
        }

        public Camera setActiveCameraByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setActiveCameraByID" }, id
                }
            );
        }

        public Camera setActiveCameraByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setActiveCameraByName" }, name
                }
            );
        }

        public AnimationGroup getAnimationGroupByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAnimationGroupByName" }, name
                }
            );
        }

        public Material getMaterialByUniqueID(decimal uniqueId)
        {
            return EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMaterialByUniqueID" }, uniqueId
                }
            );
        }

        public Material getMaterialByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMaterialByID" }, id
                }
            );
        }

        public Material getLastMaterialByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLastMaterialByID" }, id
                }
            );
        }

        public Material getMaterialByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMaterialByName" }, name
                }
            );
        }

        public BaseTexture getTextureByUniqueID(decimal uniqueId)
        {
            return EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTextureByUniqueID" }, uniqueId
                }
            );
        }

        public Camera getCameraByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCameraByID" }, id
                }
            );
        }

        public Camera getCameraByUniqueID(decimal uniqueId)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCameraByUniqueID" }, uniqueId
                }
            );
        }

        public Camera getCameraByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCameraByName" }, name
                }
            );
        }

        public Bone getBoneByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBoneByID" }, id
                }
            );
        }

        public Bone getBoneByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBoneByName" }, name
                }
            );
        }

        public Light getLightByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLightByName" }, name
                }
            );
        }

        public Light getLightByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLightByID" }, id
                }
            );
        }

        public Light getLightByUniqueID(decimal uniqueId)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLightByUniqueID" }, uniqueId
                }
            );
        }

        public IParticleSystemCachedEntity getParticleSystemByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getParticleSystemByID" }, id
                }
            );
        }

        public Geometry getGeometryByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getGeometryByID" }, id
                }
            );
        }

        public bool pushGeometry(Geometry geometry, System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "pushGeometry" }, geometry, force
                }
            );
        }

        public bool removeGeometry(Geometry geometry)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "removeGeometry" }, geometry
                }
            );
        }

        public Geometry[] getGeometries()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getGeometries" }
                }
            );
        }

        public AbstractMesh getMeshByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMeshByID" }, id
                }
            );
        }

        public AbstractMesh[] getMeshesByID(string id)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMeshesByID" }, id
                }
            );
        }

        public TransformNode getTransformNodeByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformNodeByID" }, id
                }
            );
        }

        public TransformNode getTransformNodeByUniqueID(decimal uniqueId)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformNodeByUniqueID" }, uniqueId
                }
            );
        }

        public TransformNode[] getTransformNodesByID(string id)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformNodesByID" }, id
                }
            );
        }

        public AbstractMesh getMeshByUniqueID(decimal uniqueId)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMeshByUniqueID" }, uniqueId
                }
            );
        }

        public AbstractMesh getLastMeshByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLastMeshByID" }, id
                }
            );
        }

        public Node getLastEntryByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLastEntryByID" }, id
                }
            );
        }

        public Node getNodeByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getNodeByID" }, id
                }
            );
        }

        public Node getNodeByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getNodeByName" }, name
                }
            );
        }

        public AbstractMesh getMeshByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMeshByName" }, name
                }
            );
        }

        public TransformNode getTransformNodeByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformNodeByName" }, name
                }
            );
        }

        public Skeleton getLastSkeletonByID(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLastSkeletonByID" }, id
                }
            );
        }

        public Skeleton getSkeletonByUniqueId(decimal uniqueId)
        {
            return EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSkeletonByUniqueId" }, uniqueId
                }
            );
        }

        public Skeleton getSkeletonById(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSkeletonById" }, id
                }
            );
        }

        public Skeleton getSkeletonByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSkeletonByName" }, name
                }
            );
        }

        public MorphTargetManager getMorphTargetManagerById(decimal id)
        {
            return EventHorizonBlazorInterop.FuncClass<MorphTargetManager>(
                entity => new MorphTargetManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMorphTargetManagerById" }, id
                }
            );
        }

        public MorphTarget getMorphTargetById(string id)
        {
            return EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMorphTargetById" }, id
                }
            );
        }

        public MorphTarget getMorphTargetByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMorphTargetByName" }, name
                }
            );
        }

        public PostProcess getPostProcessByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<PostProcess>(
                entity => new PostProcess() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPostProcessByName" }, name
                }
            );
        }

        public bool isActiveMesh(AbstractMesh mesh)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isActiveMesh" }, mesh
                }
            );
        }

        public bool addExternalData<T>(string key, T data)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "addExternalData" }, key, data
                }
            );
        }

        public T getExternalData<T>(string key) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getExternalData" }, key
                }
            );
        }

        public T getOrAddExternalDataWithFactory<T>(string key, ActionResultCallback<string, T> factory) where T : CachedEntity, new()
        {
            return EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getOrAddExternalDataWithFactory" }, key, factory
                }
            );
        }

        public bool removeExternalData(string key)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "removeExternalData" }, key
                }
            );
        }

        public void freeProcessedMaterials()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "freeProcessedMaterials" }
                }
            );
        }

        public void freeActiveMeshes()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "freeActiveMeshes" }
                }
            );
        }

        public void freeRenderingGroups()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "freeRenderingGroups" }
                }
            );
        }

        #region getActiveMeshCandidates TODO: Get Comments as metadata identification
        private bool _isGetActiveMeshCandidatesEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getActiveMeshCandidatesActionMap = new Dictionary<string, Func<Task>>();

        public string getActiveMeshCandidates(
            Func<Task> callback
        )
        {
            SetupGetActiveMeshCandidatesLoop();

            var handle = Guid.NewGuid().ToString();
            _getActiveMeshCandidatesActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool getActiveMeshCandidates_Remove(
            string handle
        )
        {
            return _getActiveMeshCandidatesActionMap.Remove(
                handle
            );
        }

        private void SetupGetActiveMeshCandidatesLoop()
        {
            if (_isGetActiveMeshCandidatesEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "getActiveMeshCandidates",
                "CallGetActiveMeshCandidatesActions",
                _invokableReference
            );
            _isGetActiveMeshCandidatesEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetActiveMeshCandidatesActions()
        {
            foreach (var action in _getActiveMeshCandidatesActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region getActiveSubMeshCandidates TODO: Get Comments as metadata identification
        private bool _isGetActiveSubMeshCandidatesEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getActiveSubMeshCandidatesActionMap = new Dictionary<string, Func<Task>>();

        public string getActiveSubMeshCandidates(
            Func<Task> callback
        )
        {
            SetupGetActiveSubMeshCandidatesLoop();

            var handle = Guid.NewGuid().ToString();
            _getActiveSubMeshCandidatesActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool getActiveSubMeshCandidates_Remove(
            string handle
        )
        {
            return _getActiveSubMeshCandidatesActionMap.Remove(
                handle
            );
        }

        private void SetupGetActiveSubMeshCandidatesLoop()
        {
            if (_isGetActiveSubMeshCandidatesEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "getActiveSubMeshCandidates",
                "CallGetActiveSubMeshCandidatesActions",
                _invokableReference
            );
            _isGetActiveSubMeshCandidatesEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetActiveSubMeshCandidatesActions()
        {
            foreach (var action in _getActiveSubMeshCandidatesActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region getIntersectingSubMeshCandidates TODO: Get Comments as metadata identification
        private bool _isGetIntersectingSubMeshCandidatesEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getIntersectingSubMeshCandidatesActionMap = new Dictionary<string, Func<Task>>();

        public string getIntersectingSubMeshCandidates(
            Func<Task> callback
        )
        {
            SetupGetIntersectingSubMeshCandidatesLoop();

            var handle = Guid.NewGuid().ToString();
            _getIntersectingSubMeshCandidatesActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool getIntersectingSubMeshCandidates_Remove(
            string handle
        )
        {
            return _getIntersectingSubMeshCandidatesActionMap.Remove(
                handle
            );
        }

        private void SetupGetIntersectingSubMeshCandidatesLoop()
        {
            if (_isGetIntersectingSubMeshCandidatesEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "getIntersectingSubMeshCandidates",
                "CallGetIntersectingSubMeshCandidatesActions",
                _invokableReference
            );
            _isGetIntersectingSubMeshCandidatesEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetIntersectingSubMeshCandidatesActions()
        {
            foreach (var action in _getIntersectingSubMeshCandidatesActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region getCollidingSubMeshCandidates TODO: Get Comments as metadata identification
        private bool _isGetCollidingSubMeshCandidatesEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getCollidingSubMeshCandidatesActionMap = new Dictionary<string, Func<Task>>();

        public string getCollidingSubMeshCandidates(
            Func<Task> callback
        )
        {
            SetupGetCollidingSubMeshCandidatesLoop();

            var handle = Guid.NewGuid().ToString();
            _getCollidingSubMeshCandidatesActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool getCollidingSubMeshCandidates_Remove(
            string handle
        )
        {
            return _getCollidingSubMeshCandidatesActionMap.Remove(
                handle
            );
        }

        private void SetupGetCollidingSubMeshCandidatesLoop()
        {
            if (_isGetCollidingSubMeshCandidatesEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "getCollidingSubMeshCandidates",
                "CallGetCollidingSubMeshCandidatesActions",
                _invokableReference
            );
            _isGetCollidingSubMeshCandidatesEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetCollidingSubMeshCandidatesActions()
        {
            foreach (var action in _getCollidingSubMeshCandidatesActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public Scene freezeActiveMeshes(System.Nullable<bool> skipEvaluateActiveMeshes = null, ActionCallback onSuccess = null, ActionCallback<string> onError = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "freezeActiveMeshes" }, skipEvaluateActiveMeshes, onSuccess, onError
                }
            );
        }

        public Scene unfreezeActiveMeshes()
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "unfreezeActiveMeshes" }
                }
            );
        }

        public void updateTransformMatrix(System.Nullable<bool> force = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateTransformMatrix" }, force
                }
            );
        }

        #region getDeterministicFrameTime TODO: Get Comments as metadata identification
        private bool _isGetDeterministicFrameTimeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getDeterministicFrameTimeActionMap = new Dictionary<string, Func<Task>>();

        public string getDeterministicFrameTime(
            Func<Task> callback
        )
        {
            SetupGetDeterministicFrameTimeLoop();

            var handle = Guid.NewGuid().ToString();
            _getDeterministicFrameTimeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool getDeterministicFrameTime_Remove(
            string handle
        )
        {
            return _getDeterministicFrameTimeActionMap.Remove(
                handle
            );
        }

        private void SetupGetDeterministicFrameTimeLoop()
        {
            if (_isGetDeterministicFrameTimeEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "getDeterministicFrameTime",
                "CallGetDeterministicFrameTimeActions",
                _invokableReference
            );
            _isGetDeterministicFrameTimeEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetDeterministicFrameTimeActions()
        {
            foreach (var action in _getDeterministicFrameTimeActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void animate()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "animate" }
                }
            );
        }

        public void render(System.Nullable<bool> updateCameras = null, System.Nullable<bool> ignoreAnimations = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "render" }, updateCameras, ignoreAnimations
                }
            );
        }

        public void freezeMaterials()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "freezeMaterials" }
                }
            );
        }

        public void unfreezeMaterials()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unfreezeMaterials" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public void clearCachedVertexData()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clearCachedVertexData" }
                }
            );
        }

        public void cleanCachedTextureBuffer()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "cleanCachedTextureBuffer" }
                }
            );
        }

        public CachedEntity getWorldExtends(ActionResultCallback<AbstractMesh, bool> filterPredicate = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getWorldExtends" }, filterPredicate
                }
            );
        }

        public Ray createPickingRay(decimal x, decimal y, Matrix world, Camera camera, System.Nullable<bool> cameraViewSpace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createPickingRay" }, x, y, world, camera, cameraViewSpace
                }
            );
        }

        public Scene createPickingRayToRef(decimal x, decimal y, Matrix world, Ray result, Camera camera, System.Nullable<bool> cameraViewSpace = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createPickingRayToRef" }, x, y, world, result, camera, cameraViewSpace
                }
            );
        }

        public Ray createPickingRayInCameraSpace(decimal x, decimal y, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createPickingRayInCameraSpace" }, x, y, camera
                }
            );
        }

        public Scene createPickingRayInCameraSpaceToRef(decimal x, decimal y, Ray result, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createPickingRayInCameraSpaceToRef" }, x, y, result, camera
                }
            );
        }

        public PickingInfo pick(decimal x, decimal y, ActionResultCallback<AbstractMesh, bool> predicate = null, System.Nullable<bool> fastCheck = null, Camera camera = null, ActionResultCallback<Vector3, Vector3, Vector3, Ray, bool> trianglePredicate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pick" }, x, y, predicate, fastCheck, camera, trianglePredicate
                }
            );
        }

        public PickingInfo pickWithBoundingInfo(decimal x, decimal y, ActionResultCallback<AbstractMesh, bool> predicate = null, System.Nullable<bool> fastCheck = null, Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pickWithBoundingInfo" }, x, y, predicate, fastCheck, camera
                }
            );
        }

        public PickingInfo pickWithRay(Ray ray, ActionResultCallback<AbstractMesh, bool> predicate = null, System.Nullable<bool> fastCheck = null, ActionResultCallback<Vector3, Vector3, Vector3, Ray, bool> trianglePredicate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "pickWithRay" }, ray, predicate, fastCheck, trianglePredicate
                }
            );
        }

        public PickingInfo[] multiPick(decimal x, decimal y, ActionResultCallback<AbstractMesh, bool> predicate = null, Camera camera = null, ActionResultCallback<Vector3, Vector3, Vector3, Ray, bool> trianglePredicate = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiPick" }, x, y, predicate, camera, trianglePredicate
                }
            );
        }

        public PickingInfo[] multiPickWithRay(Ray ray, ActionResultCallback<AbstractMesh, bool> predicate, ActionResultCallback<Vector3, Vector3, Vector3, Ray, bool> trianglePredicate = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiPickWithRay" }, ray, predicate, trianglePredicate
                }
            );
        }

        public void setPointerOverMesh(AbstractMesh mesh, System.Nullable<decimal> pointerId = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPointerOverMesh" }, mesh, pointerId
                }
            );
        }

        public AbstractMesh getPointerOverMesh()
        {
            return EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPointerOverMesh" }
                }
            );
        }

        public Mesh[] getMeshesByTags(string tagsQuery, ActionCallback<AbstractMesh> forEach = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMeshesByTags" }, tagsQuery, forEach
                }
            );
        }

        public Camera[] getCamerasByTags(string tagsQuery, ActionCallback<Camera> forEach = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCamerasByTags" }, tagsQuery, forEach
                }
            );
        }

        public Light[] getLightsByTags(string tagsQuery, ActionCallback<Light> forEach = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLightsByTags" }, tagsQuery, forEach
                }
            );
        }

        public Material[] getMaterialByTags(string tagsQuery, ActionCallback<Material> forEach = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMaterialByTags" }, tagsQuery, forEach
                }
            );
        }

        public TransformNode[] getTransformNodesByTags(string tagsQuery, ActionCallback<TransformNode> forEach = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformNodesByTags" }, tagsQuery, forEach
                }
            );
        }

        public void setRenderingOrder(decimal renderingGroupId, ActionResultCallback<SubMesh, SubMesh, decimal> opaqueSortCompareFn = null, ActionResultCallback<SubMesh, SubMesh, decimal> alphaTestSortCompareFn = null, ActionResultCallback<SubMesh, SubMesh, decimal> transparentSortCompareFn = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRenderingOrder" }, renderingGroupId, opaqueSortCompareFn, alphaTestSortCompareFn, transparentSortCompareFn
                }
            );
        }

        public void setRenderingAutoClearDepthStencil(decimal renderingGroupId, bool autoClearDepthStencil, System.Nullable<bool> depth = null, System.Nullable<bool> stencil = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRenderingAutoClearDepthStencil" }, renderingGroupId, autoClearDepthStencil, depth, stencil
                }
            );
        }

        public IRenderingManagerAutoClearSetupCachedEntity getAutoClearDepthStencilSetup(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<IRenderingManagerAutoClearSetupCachedEntity>(
                entity => new IRenderingManagerAutoClearSetupCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAutoClearDepthStencilSetup" }, index
                }
            );
        }

        public void markAllMaterialsAsDirty(decimal flag, ActionResultCallback<Material, bool> predicate = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "markAllMaterialsAsDirty" }, flag, predicate
                }
            );
        }
        #endregion
    }
}