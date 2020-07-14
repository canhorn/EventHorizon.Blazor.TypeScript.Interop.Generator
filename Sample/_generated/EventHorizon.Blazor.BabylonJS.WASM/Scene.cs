/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Scene : AbstractScene, IAnimatable
    {
        #region Static Accessors
        
        public static decimal DragMovementThreshold
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Scene.DragMovementThreshold"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Scene.LongPressDelay"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Scene.DoubleClickDelay"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "Scene.ExclusiveDoubleClickMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Scene.FOGMODE_NONE"
                );
            }
        }

        
        public static decimal FOGMODE_EXP
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Scene.FOGMODE_EXP"
                );
            }
        }

        
        public static decimal FOGMODE_EXP2
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Scene.FOGMODE_EXP2"
                );
            }
        }

        
        public static decimal FOGMODE_LINEAR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Scene.FOGMODE_LINEAR"
                );
            }
        }

        
        public static decimal MinDeltaTime
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Scene.MinDeltaTime"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".Scene.MinDeltaTime",
                    value
                );
            }
        }

        
        public static decimal MaxDeltaTime
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".Scene.MaxDeltaTime"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".Scene.MaxDeltaTime",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static Material DefaultMaterialFactory(Scene scene)
        {
            return EventHorizonBlazorInteropt.FuncClass<Material>(
                entity => new Material(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Scene", "DefaultMaterialFactory" }, scene
                }
            );
        }

        public static ICollisionCoordinator CollisionCoordinatorFactory()
        {
            return EventHorizonBlazorInteropt.FuncClass<ICollisionCoordinator>(
                entity => new ICollisionCoordinatorCachedEntity(entity),
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
                __environmentTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
                    this.___guid,
                    "environmentTexture",
                    (entity) =>
                    {
                        return new BaseTexture(entity);
                    }
                );
            }
            return __environmentTexture;
            }
            set
            {
__environmentTexture = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "environmentIntensity"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __imageProcessingConfiguration = EventHorizonBlazorInteropt.GetClass<ImageProcessingConfiguration>(
                    this.___guid,
                    "imageProcessingConfiguration",
                    (entity) =>
                    {
                        return new ImageProcessingConfiguration(entity);
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "forceWireframe"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "skipFrustumClipping"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "forcePointsCloud"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __animationPropertiesOverride = EventHorizonBlazorInteropt.GetClass<AnimationPropertiesOverride>(
                    this.___guid,
                    "animationPropertiesOverride",
                    (entity) =>
                    {
                        return new AnimationPropertiesOverride(entity);
                    }
                );
            }
            return __animationPropertiesOverride;
            }
            set
            {
__animationPropertiesOverride = null;
                EventHorizonBlazorInteropt.Set(
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
                __unTranslatedPointer = EventHorizonBlazorInteropt.GetClass<Vector2>(
                    this.___guid,
                    "unTranslatedPointer",
                    (entity) =>
                    {
                        return new Vector2(entity);
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useRightHandedSystem"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "fogEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "fogMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "shadowsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "lightsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __activeCamera = EventHorizonBlazorInteropt.GetClass<Camera>(
                    this.___guid,
                    "activeCamera",
                    (entity) =>
                    {
                        return new Camera(entity);
                    }
                );
            }
            return __activeCamera;
            }
            set
            {
__activeCamera = null;
                EventHorizonBlazorInteropt.Set(
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
                __defaultMaterial = EventHorizonBlazorInteropt.GetClass<Material>(
                    this.___guid,
                    "defaultMaterial",
                    (entity) =>
                    {
                        return new Material(entity);
                    }
                );
            }
            return __defaultMaterial;
            }
            set
            {
__defaultMaterial = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "texturesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "skeletonsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "skeletonsEnabled",
                    value
                );
            }
        }

        private ICollisionCoordinator __collisionCoordinator;
        public ICollisionCoordinator collisionCoordinator
        {
            get
            {
            if(__collisionCoordinator == null)
            {
                __collisionCoordinator = EventHorizonBlazorInteropt.GetClass<ICollisionCoordinator>(
                    this.___guid,
                    "collisionCoordinator",
                    (entity) =>
                    {
                        return new ICollisionCoordinatorCachedEntity(entity);
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
            return EventHorizonBlazorInteropt.GetArrayClass<Plane>(
                    this.___guid,
                    "frustumPlanes",
                    (entity) =>
                    {
                        return new Plane(entity);
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
                __meshUnderPointer = EventHorizonBlazorInteropt.GetClass<AbstractMesh>(
                    this.___guid,
                    "meshUnderPointer",
                    (entity) =>
                    {
                        return new AbstractMesh(entity);
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "pointerX"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "pointerY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __totalVerticesPerfCounter = EventHorizonBlazorInteropt.GetClass<PerfCounter>(
                    this.___guid,
                    "totalVerticesPerfCounter",
                    (entity) =>
                    {
                        return new PerfCounter(entity);
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
                __totalActiveIndicesPerfCounter = EventHorizonBlazorInteropt.GetClass<PerfCounter>(
                    this.___guid,
                    "totalActiveIndicesPerfCounter",
                    (entity) =>
                    {
                        return new PerfCounter(entity);
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
                __activeParticlesPerfCounter = EventHorizonBlazorInteropt.GetClass<PerfCounter>(
                    this.___guid,
                    "activeParticlesPerfCounter",
                    (entity) =>
                    {
                        return new PerfCounter(entity);
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
                __activeBonesPerfCounter = EventHorizonBlazorInteropt.GetClass<PerfCounter>(
                    this.___guid,
                    "activeBonesPerfCounter",
                    (entity) =>
                    {
                        return new PerfCounter(entity);
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isLoading"
                );
            }
        }

        
        public Animatable[] animatables
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Animatable>(
                    this.___guid,
                    "animatables",
                    (entity) =>
                    {
                        return new Animatable(entity);
                    }
                );
            }
        }

        
        public string uid
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "uid"
                );
            }
        }

        
        public bool blockfreeActiveMeshesAndRenderingGroups
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "blockfreeActiveMeshesAndRenderingGroups"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isDisposed"
                );
            }
        }

        
        public bool blockMaterialDirtyMechanism
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "blockMaterialDirtyMechanism"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __cameraToUseForPointers = EventHorizonBlazorInteropt.GetClass<Camera>(
                    this.___guid,
                    "cameraToUseForPointers",
                    (entity) =>
                    {
                        return new Camera(entity);
                    }
                );
            }
            return __cameraToUseForPointers;
            }
            set
            {
__cameraToUseForPointers = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "autoClear"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "autoClearDepthAndStencil"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __clearColor = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "clearColor",
                    (entity) =>
                    {
                        return new Color4(entity);
                    }
                );
            }
            return __clearColor;
            }
            set
            {
__clearColor = null;
                EventHorizonBlazorInteropt.Set(
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
                __ambientColor = EventHorizonBlazorInteropt.GetClass<Color3>(
                    this.___guid,
                    "ambientColor",
                    (entity) =>
                    {
                        return new Color3(entity);
                    }
                );
            }
            return __ambientColor;
            }
            set
            {
__ambientColor = null;
                EventHorizonBlazorInteropt.Set(
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
                __environmentBRDFTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
                    this.___guid,
                    "environmentBRDFTexture",
                    (entity) =>
                    {
                        return new BaseTexture(entity);
                    }
                );
            }
            return __environmentBRDFTexture;
            }
            set
            {
__environmentBRDFTexture = null;
                EventHorizonBlazorInteropt.Set(
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
                __clipPlane = EventHorizonBlazorInteropt.GetClass<Plane>(
                    this.___guid,
                    "clipPlane",
                    (entity) =>
                    {
                        return new Plane(entity);
                    }
                );
            }
            return __clipPlane;
            }
            set
            {
__clipPlane = null;
                EventHorizonBlazorInteropt.Set(
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
                __clipPlane2 = EventHorizonBlazorInteropt.GetClass<Plane>(
                    this.___guid,
                    "clipPlane2",
                    (entity) =>
                    {
                        return new Plane(entity);
                    }
                );
            }
            return __clipPlane2;
            }
            set
            {
__clipPlane2 = null;
                EventHorizonBlazorInteropt.Set(
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
                __clipPlane3 = EventHorizonBlazorInteropt.GetClass<Plane>(
                    this.___guid,
                    "clipPlane3",
                    (entity) =>
                    {
                        return new Plane(entity);
                    }
                );
            }
            return __clipPlane3;
            }
            set
            {
__clipPlane3 = null;
                EventHorizonBlazorInteropt.Set(
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
                __clipPlane4 = EventHorizonBlazorInteropt.GetClass<Plane>(
                    this.___guid,
                    "clipPlane4",
                    (entity) =>
                    {
                        return new Plane(entity);
                    }
                );
            }
            return __clipPlane4;
            }
            set
            {
__clipPlane4 = null;
                EventHorizonBlazorInteropt.Set(
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
                __clipPlane5 = EventHorizonBlazorInteropt.GetClass<Plane>(
                    this.___guid,
                    "clipPlane5",
                    (entity) =>
                    {
                        return new Plane(entity);
                    }
                );
            }
            return __clipPlane5;
            }
            set
            {
__clipPlane5 = null;
                EventHorizonBlazorInteropt.Set(
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
                __clipPlane6 = EventHorizonBlazorInteropt.GetClass<Plane>(
                    this.___guid,
                    "clipPlane6",
                    (entity) =>
                    {
                        return new Plane(entity);
                    }
                );
            }
            return __clipPlane6;
            }
            set
            {
__clipPlane6 = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "animationsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useConstantAnimationDeltaTime"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "constantlyUpdateMeshUnderPointer"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "hoverCursor"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "defaultCursor"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "doNotHandleCursors"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "preventDefaultOnPointerDown"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "preventDefaultOnPointerUp"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "metadata"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "reservedDataStore"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "loadingPluginName"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<RegExp>(
                    this.___guid,
                    "disableOfflineSupportExceptionRules",
                    (entity) =>
                    {
                        return new RegExp(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "disableOfflineSupportExceptionRules",
                    value
                );
            }
        }

        private Observable __onDisposeObservable;
        public Observable onDisposeObservable
        {
            get
            {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onDisposeObservable;
            }
            set
            {
__onDisposeObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
            }
        }

        private Observable __onBeforeRenderObservable;
        public Observable onBeforeRenderObservable
        {
            get
            {
            if(__onBeforeRenderObservable == null)
            {
                __onBeforeRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeRenderObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeRenderObservable;
            }
            set
            {
__onBeforeRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeRenderObservable",
                    value
                );
            }
        }

        private Observable __onAfterRenderObservable;
        public Observable onAfterRenderObservable
        {
            get
            {
            if(__onAfterRenderObservable == null)
            {
                __onAfterRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterRenderObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterRenderObservable;
            }
            set
            {
__onAfterRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterRenderObservable",
                    value
                );
            }
        }

        private Observable __onAfterRenderCameraObservable;
        public Observable onAfterRenderCameraObservable
        {
            get
            {
            if(__onAfterRenderCameraObservable == null)
            {
                __onAfterRenderCameraObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterRenderCameraObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterRenderCameraObservable;
            }
            set
            {
__onAfterRenderCameraObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterRenderCameraObservable",
                    value
                );
            }
        }

        private Observable __onBeforeAnimationsObservable;
        public Observable onBeforeAnimationsObservable
        {
            get
            {
            if(__onBeforeAnimationsObservable == null)
            {
                __onBeforeAnimationsObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeAnimationsObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeAnimationsObservable;
            }
            set
            {
__onBeforeAnimationsObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeAnimationsObservable",
                    value
                );
            }
        }

        private Observable __onAfterAnimationsObservable;
        public Observable onAfterAnimationsObservable
        {
            get
            {
            if(__onAfterAnimationsObservable == null)
            {
                __onAfterAnimationsObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterAnimationsObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterAnimationsObservable;
            }
            set
            {
__onAfterAnimationsObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterAnimationsObservable",
                    value
                );
            }
        }

        private Observable __onBeforeDrawPhaseObservable;
        public Observable onBeforeDrawPhaseObservable
        {
            get
            {
            if(__onBeforeDrawPhaseObservable == null)
            {
                __onBeforeDrawPhaseObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeDrawPhaseObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeDrawPhaseObservable;
            }
            set
            {
__onBeforeDrawPhaseObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeDrawPhaseObservable",
                    value
                );
            }
        }

        private Observable __onAfterDrawPhaseObservable;
        public Observable onAfterDrawPhaseObservable
        {
            get
            {
            if(__onAfterDrawPhaseObservable == null)
            {
                __onAfterDrawPhaseObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterDrawPhaseObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterDrawPhaseObservable;
            }
            set
            {
__onAfterDrawPhaseObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterDrawPhaseObservable",
                    value
                );
            }
        }

        private Observable __onReadyObservable;
        public Observable onReadyObservable
        {
            get
            {
            if(__onReadyObservable == null)
            {
                __onReadyObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onReadyObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onReadyObservable;
            }
            set
            {
__onReadyObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onReadyObservable",
                    value
                );
            }
        }

        private Observable __onBeforeCameraRenderObservable;
        public Observable onBeforeCameraRenderObservable
        {
            get
            {
            if(__onBeforeCameraRenderObservable == null)
            {
                __onBeforeCameraRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeCameraRenderObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeCameraRenderObservable;
            }
            set
            {
__onBeforeCameraRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeCameraRenderObservable",
                    value
                );
            }
        }

        private Observable __onAfterCameraRenderObservable;
        public Observable onAfterCameraRenderObservable
        {
            get
            {
            if(__onAfterCameraRenderObservable == null)
            {
                __onAfterCameraRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterCameraRenderObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterCameraRenderObservable;
            }
            set
            {
__onAfterCameraRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterCameraRenderObservable",
                    value
                );
            }
        }

        private Observable __onBeforeActiveMeshesEvaluationObservable;
        public Observable onBeforeActiveMeshesEvaluationObservable
        {
            get
            {
            if(__onBeforeActiveMeshesEvaluationObservable == null)
            {
                __onBeforeActiveMeshesEvaluationObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeActiveMeshesEvaluationObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeActiveMeshesEvaluationObservable;
            }
            set
            {
__onBeforeActiveMeshesEvaluationObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeActiveMeshesEvaluationObservable",
                    value
                );
            }
        }

        private Observable __onAfterActiveMeshesEvaluationObservable;
        public Observable onAfterActiveMeshesEvaluationObservable
        {
            get
            {
            if(__onAfterActiveMeshesEvaluationObservable == null)
            {
                __onAfterActiveMeshesEvaluationObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterActiveMeshesEvaluationObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterActiveMeshesEvaluationObservable;
            }
            set
            {
__onAfterActiveMeshesEvaluationObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterActiveMeshesEvaluationObservable",
                    value
                );
            }
        }

        private Observable __onBeforeParticlesRenderingObservable;
        public Observable onBeforeParticlesRenderingObservable
        {
            get
            {
            if(__onBeforeParticlesRenderingObservable == null)
            {
                __onBeforeParticlesRenderingObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeParticlesRenderingObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeParticlesRenderingObservable;
            }
            set
            {
__onBeforeParticlesRenderingObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeParticlesRenderingObservable",
                    value
                );
            }
        }

        private Observable __onAfterParticlesRenderingObservable;
        public Observable onAfterParticlesRenderingObservable
        {
            get
            {
            if(__onAfterParticlesRenderingObservable == null)
            {
                __onAfterParticlesRenderingObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterParticlesRenderingObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterParticlesRenderingObservable;
            }
            set
            {
__onAfterParticlesRenderingObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterParticlesRenderingObservable",
                    value
                );
            }
        }

        private Observable __onDataLoadedObservable;
        public Observable onDataLoadedObservable
        {
            get
            {
            if(__onDataLoadedObservable == null)
            {
                __onDataLoadedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onDataLoadedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onDataLoadedObservable;
            }
            set
            {
__onDataLoadedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onDataLoadedObservable",
                    value
                );
            }
        }

        private Observable __onNewCameraAddedObservable;
        public Observable onNewCameraAddedObservable
        {
            get
            {
            if(__onNewCameraAddedObservable == null)
            {
                __onNewCameraAddedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onNewCameraAddedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onNewCameraAddedObservable;
            }
            set
            {
__onNewCameraAddedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onNewCameraAddedObservable",
                    value
                );
            }
        }

        private Observable __onCameraRemovedObservable;
        public Observable onCameraRemovedObservable
        {
            get
            {
            if(__onCameraRemovedObservable == null)
            {
                __onCameraRemovedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onCameraRemovedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onCameraRemovedObservable;
            }
            set
            {
__onCameraRemovedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onCameraRemovedObservable",
                    value
                );
            }
        }

        private Observable __onNewLightAddedObservable;
        public Observable onNewLightAddedObservable
        {
            get
            {
            if(__onNewLightAddedObservable == null)
            {
                __onNewLightAddedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onNewLightAddedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onNewLightAddedObservable;
            }
            set
            {
__onNewLightAddedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onNewLightAddedObservable",
                    value
                );
            }
        }

        private Observable __onLightRemovedObservable;
        public Observable onLightRemovedObservable
        {
            get
            {
            if(__onLightRemovedObservable == null)
            {
                __onLightRemovedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onLightRemovedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onLightRemovedObservable;
            }
            set
            {
__onLightRemovedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onLightRemovedObservable",
                    value
                );
            }
        }

        private Observable __onNewGeometryAddedObservable;
        public Observable onNewGeometryAddedObservable
        {
            get
            {
            if(__onNewGeometryAddedObservable == null)
            {
                __onNewGeometryAddedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onNewGeometryAddedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onNewGeometryAddedObservable;
            }
            set
            {
__onNewGeometryAddedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onNewGeometryAddedObservable",
                    value
                );
            }
        }

        private Observable __onGeometryRemovedObservable;
        public Observable onGeometryRemovedObservable
        {
            get
            {
            if(__onGeometryRemovedObservable == null)
            {
                __onGeometryRemovedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onGeometryRemovedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onGeometryRemovedObservable;
            }
            set
            {
__onGeometryRemovedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onGeometryRemovedObservable",
                    value
                );
            }
        }

        private Observable __onNewTransformNodeAddedObservable;
        public Observable onNewTransformNodeAddedObservable
        {
            get
            {
            if(__onNewTransformNodeAddedObservable == null)
            {
                __onNewTransformNodeAddedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onNewTransformNodeAddedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onNewTransformNodeAddedObservable;
            }
            set
            {
__onNewTransformNodeAddedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onNewTransformNodeAddedObservable",
                    value
                );
            }
        }

        private Observable __onTransformNodeRemovedObservable;
        public Observable onTransformNodeRemovedObservable
        {
            get
            {
            if(__onTransformNodeRemovedObservable == null)
            {
                __onTransformNodeRemovedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onTransformNodeRemovedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onTransformNodeRemovedObservable;
            }
            set
            {
__onTransformNodeRemovedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onTransformNodeRemovedObservable",
                    value
                );
            }
        }

        private Observable __onNewMeshAddedObservable;
        public Observable onNewMeshAddedObservable
        {
            get
            {
            if(__onNewMeshAddedObservable == null)
            {
                __onNewMeshAddedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onNewMeshAddedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onNewMeshAddedObservable;
            }
            set
            {
__onNewMeshAddedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onNewMeshAddedObservable",
                    value
                );
            }
        }

        private Observable __onMeshRemovedObservable;
        public Observable onMeshRemovedObservable
        {
            get
            {
            if(__onMeshRemovedObservable == null)
            {
                __onMeshRemovedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onMeshRemovedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onMeshRemovedObservable;
            }
            set
            {
__onMeshRemovedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onMeshRemovedObservable",
                    value
                );
            }
        }

        private Observable __onNewSkeletonAddedObservable;
        public Observable onNewSkeletonAddedObservable
        {
            get
            {
            if(__onNewSkeletonAddedObservable == null)
            {
                __onNewSkeletonAddedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onNewSkeletonAddedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onNewSkeletonAddedObservable;
            }
            set
            {
__onNewSkeletonAddedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onNewSkeletonAddedObservable",
                    value
                );
            }
        }

        private Observable __onSkeletonRemovedObservable;
        public Observable onSkeletonRemovedObservable
        {
            get
            {
            if(__onSkeletonRemovedObservable == null)
            {
                __onSkeletonRemovedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onSkeletonRemovedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onSkeletonRemovedObservable;
            }
            set
            {
__onSkeletonRemovedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onSkeletonRemovedObservable",
                    value
                );
            }
        }

        private Observable __onNewMaterialAddedObservable;
        public Observable onNewMaterialAddedObservable
        {
            get
            {
            if(__onNewMaterialAddedObservable == null)
            {
                __onNewMaterialAddedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onNewMaterialAddedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onNewMaterialAddedObservable;
            }
            set
            {
__onNewMaterialAddedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onNewMaterialAddedObservable",
                    value
                );
            }
        }

        private Observable __onMaterialRemovedObservable;
        public Observable onMaterialRemovedObservable
        {
            get
            {
            if(__onMaterialRemovedObservable == null)
            {
                __onMaterialRemovedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onMaterialRemovedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onMaterialRemovedObservable;
            }
            set
            {
__onMaterialRemovedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onMaterialRemovedObservable",
                    value
                );
            }
        }

        private Observable __onNewTextureAddedObservable;
        public Observable onNewTextureAddedObservable
        {
            get
            {
            if(__onNewTextureAddedObservable == null)
            {
                __onNewTextureAddedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onNewTextureAddedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onNewTextureAddedObservable;
            }
            set
            {
__onNewTextureAddedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onNewTextureAddedObservable",
                    value
                );
            }
        }

        private Observable __onTextureRemovedObservable;
        public Observable onTextureRemovedObservable
        {
            get
            {
            if(__onTextureRemovedObservable == null)
            {
                __onTextureRemovedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onTextureRemovedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onTextureRemovedObservable;
            }
            set
            {
__onTextureRemovedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onTextureRemovedObservable",
                    value
                );
            }
        }

        private Observable __onBeforeRenderTargetsRenderObservable;
        public Observable onBeforeRenderTargetsRenderObservable
        {
            get
            {
            if(__onBeforeRenderTargetsRenderObservable == null)
            {
                __onBeforeRenderTargetsRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeRenderTargetsRenderObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeRenderTargetsRenderObservable;
            }
            set
            {
__onBeforeRenderTargetsRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeRenderTargetsRenderObservable",
                    value
                );
            }
        }

        private Observable __onAfterRenderTargetsRenderObservable;
        public Observable onAfterRenderTargetsRenderObservable
        {
            get
            {
            if(__onAfterRenderTargetsRenderObservable == null)
            {
                __onAfterRenderTargetsRenderObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterRenderTargetsRenderObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterRenderTargetsRenderObservable;
            }
            set
            {
__onAfterRenderTargetsRenderObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterRenderTargetsRenderObservable",
                    value
                );
            }
        }

        private Observable __onBeforeStepObservable;
        public Observable onBeforeStepObservable
        {
            get
            {
            if(__onBeforeStepObservable == null)
            {
                __onBeforeStepObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeStepObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeStepObservable;
            }
            set
            {
__onBeforeStepObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeStepObservable",
                    value
                );
            }
        }

        private Observable __onAfterStepObservable;
        public Observable onAfterStepObservable
        {
            get
            {
            if(__onAfterStepObservable == null)
            {
                __onAfterStepObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterStepObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterStepObservable;
            }
            set
            {
__onAfterStepObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterStepObservable",
                    value
                );
            }
        }

        private Observable __onActiveCameraChanged;
        public Observable onActiveCameraChanged
        {
            get
            {
            if(__onActiveCameraChanged == null)
            {
                __onActiveCameraChanged = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onActiveCameraChanged",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onActiveCameraChanged;
            }
            set
            {
__onActiveCameraChanged = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onActiveCameraChanged",
                    value
                );
            }
        }

        private Observable __onBeforeRenderingGroupObservable;
        public Observable onBeforeRenderingGroupObservable
        {
            get
            {
            if(__onBeforeRenderingGroupObservable == null)
            {
                __onBeforeRenderingGroupObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeRenderingGroupObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeRenderingGroupObservable;
            }
            set
            {
__onBeforeRenderingGroupObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeRenderingGroupObservable",
                    value
                );
            }
        }

        private Observable __onAfterRenderingGroupObservable;
        public Observable onAfterRenderingGroupObservable
        {
            get
            {
            if(__onAfterRenderingGroupObservable == null)
            {
                __onAfterRenderingGroupObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterRenderingGroupObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterRenderingGroupObservable;
            }
            set
            {
__onAfterRenderingGroupObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterRenderingGroupObservable",
                    value
                );
            }
        }

        private Observable __onMeshImportedObservable;
        public Observable onMeshImportedObservable
        {
            get
            {
            if(__onMeshImportedObservable == null)
            {
                __onMeshImportedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onMeshImportedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onMeshImportedObservable;
            }
            set
            {
__onMeshImportedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onMeshImportedObservable",
                    value
                );
            }
        }

        private Observable __onAnimationFileImportedObservable;
        public Observable onAnimationFileImportedObservable
        {
            get
            {
            if(__onAnimationFileImportedObservable == null)
            {
                __onAnimationFileImportedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAnimationFileImportedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAnimationFileImportedObservable;
            }
            set
            {
__onAnimationFileImportedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAnimationFileImportedObservable",
                    value
                );
            }
        }

        private Observable __onPrePointerObservable;
        public Observable onPrePointerObservable
        {
            get
            {
            if(__onPrePointerObservable == null)
            {
                __onPrePointerObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onPrePointerObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onPrePointerObservable;
            }
            set
            {
__onPrePointerObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onPrePointerObservable",
                    value
                );
            }
        }

        private Observable __onPointerObservable;
        public Observable onPointerObservable
        {
            get
            {
            if(__onPointerObservable == null)
            {
                __onPointerObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onPointerObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onPointerObservable;
            }
            set
            {
__onPointerObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onPointerObservable",
                    value
                );
            }
        }

        private Observable __onPreKeyboardObservable;
        public Observable onPreKeyboardObservable
        {
            get
            {
            if(__onPreKeyboardObservable == null)
            {
                __onPreKeyboardObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onPreKeyboardObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onPreKeyboardObservable;
            }
            set
            {
__onPreKeyboardObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onPreKeyboardObservable",
                    value
                );
            }
        }

        private Observable __onKeyboardObservable;
        public Observable onKeyboardObservable
        {
            get
            {
            if(__onKeyboardObservable == null)
            {
                __onKeyboardObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onKeyboardObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onKeyboardObservable;
            }
            set
            {
__onKeyboardObservable = null;
                EventHorizonBlazorInteropt.Set(
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
                __fogColor = EventHorizonBlazorInteropt.GetClass<Color3>(
                    this.___guid,
                    "fogColor",
                    (entity) =>
                    {
                        return new Color3(entity);
                    }
                );
            }
            return __fogColor;
            }
            set
            {
__fogColor = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "fogDensity"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "fogStart"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "fogEnd"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "fogEnd",
                    value
                );
            }
        }

        
        public Camera[] activeCameras
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Camera>(
                    this.___guid,
                    "activeCameras",
                    (entity) =>
                    {
                        return new Camera(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "activeCameras",
                    value
                );
            }
        }

        
        public bool particlesEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "particlesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "spritesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "lensFlaresEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "collisionsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __gravity = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "gravity",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __gravity;
            }
            set
            {
__gravity = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "postProcessesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "postProcessesEnabled",
                    value
                );
            }
        }

        
        public PostProcess[] postProcesses
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<PostProcess>(
                    this.___guid,
                    "postProcesses",
                    (entity) =>
                    {
                        return new PostProcess(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "postProcesses",
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
                __postProcessManager = EventHorizonBlazorInteropt.GetClass<PostProcessManager>(
                    this.___guid,
                    "postProcessManager",
                    (entity) =>
                    {
                        return new PostProcessManager(entity);
                    }
                );
            }
            return __postProcessManager;
            }
            set
            {
__postProcessManager = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "renderTargetsEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "dumpNextRenderTargets"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<RenderTargetTexture>(
                    this.___guid,
                    "customRenderTargets",
                    (entity) =>
                    {
                        return new RenderTargetTexture(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useDelayedTextureLoading"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArray<string>(
                    this.___guid,
                    "importedMeshesFiles"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "probesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "probesEnabled",
                    value
                );
            }
        }

        private IOfflineProvider __offlineProvider;
        public IOfflineProvider offlineProvider
        {
            get
            {
            if(__offlineProvider == null)
            {
                __offlineProvider = EventHorizonBlazorInteropt.GetClass<IOfflineProvider>(
                    this.___guid,
                    "offlineProvider",
                    (entity) =>
                    {
                        return new IOfflineProviderCachedEntity(entity);
                    }
                );
            }
            return __offlineProvider;
            }
            set
            {
__offlineProvider = null;
                EventHorizonBlazorInteropt.Set(
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
                __actionManager = EventHorizonBlazorInteropt.GetClass<AbstractActionManager>(
                    this.___guid,
                    "actionManager",
                    (entity) =>
                    {
                        return new AbstractActionManager(entity);
                    }
                );
            }
            return __actionManager;
            }
            set
            {
__actionManager = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "proceduralTexturesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "animationTimeScale"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "dispatchAllSubMeshesOfActiveMeshes"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "requireLightSorting"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useMaterialMeshMap"
                );
            }
        }

        
        public bool useClonedMeshMap
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
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
            var entity = EventHorizonBlazorInteropt.New(
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

        private void SetupCustomLODSelectorLoop()
        {
            if (_isCustomLODSelectorEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        private void SetupPointerDownPredicateLoop()
        {
            if (_isPointerDownPredicateEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        private void SetupPointerUpPredicateLoop()
        {
            if (_isPointerUpPredicateEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        private void SetupPointerMovePredicateLoop()
        {
            if (_isPointerMovePredicateEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        private void SetupOnPointerMoveLoop()
        {
            if (_isOnPointerMoveEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        private void SetupOnPointerDownLoop()
        {
            if (_isOnPointerDownEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        private void SetupOnPointerUpLoop()
        {
            if (_isOnPointerUpEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        private void SetupOnPointerPickLoop()
        {
            if (_isOnPointerPickEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStepId" }, newStepId
                }
            );
        }

        public decimal getStepId()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStepId" }
                }
            );
        }

        public decimal getInternalStep()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getInternalStep" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void setDefaultCandidateProviders()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDefaultCandidateProviders" }
                }
            );
        }

        public Material getCachedMaterial()
        {
            return EventHorizonBlazorInteropt.FuncClass<Material>(
                entity => new Material(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getCachedMaterial" }
                }
            );
        }

        public Effect getCachedEffect()
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getCachedEffect" }
                }
            );
        }

        public decimal getCachedVisibility()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getCachedVisibility" }
                }
            );
        }

        public bool isCachedMaterialInvalid(Material material, Effect effect, System.Nullable<decimal> visibility = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isCachedMaterialInvalid" }, material, effect, visibility
                }
            );
        }

        public Engine getEngine()
        {
            return EventHorizonBlazorInteropt.FuncClass<Engine>(
                entity => new Engine(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getEngine" }
                }
            );
        }

        public decimal getTotalVertices()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTotalVertices" }
                }
            );
        }

        public decimal getActiveIndices()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getActiveIndices" }
                }
            );
        }

        public decimal getActiveParticles()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getActiveParticles" }
                }
            );
        }

        public decimal getActiveBones()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getActiveBones" }
                }
            );
        }

        public AbstractMesh getActiveMeshes()
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getActiveMeshes" }
                }
            );
        }

        public decimal getAnimationRatio()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getAnimationRatio" }
                }
            );
        }

        public decimal getRenderId()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderId" }
                }
            );
        }

        public decimal getFrameId()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getFrameId" }
                }
            );
        }

        public void incrementRenderId()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "incrementRenderId" }
                }
            );
        }

        public Scene simulatePointerMove(PickingInfo pickResult, PointerEventInit pointerEventInit = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene(entity),
                new object[] 
                {
                    new string[] { this.___guid, "simulatePointerMove" }, pickResult, pointerEventInit
                }
            );
        }

        public Scene simulatePointerDown(PickingInfo pickResult, PointerEventInit pointerEventInit = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene(entity),
                new object[] 
                {
                    new string[] { this.___guid, "simulatePointerDown" }, pickResult, pointerEventInit
                }
            );
        }

        public Scene simulatePointerUp(PickingInfo pickResult, PointerEventInit pointerEventInit = null, System.Nullable<bool> doubleTap = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene(entity),
                new object[] 
                {
                    new string[] { this.___guid, "simulatePointerUp" }, pickResult, pointerEventInit, doubleTap
                }
            );
        }

        public bool isPointerCaptured(System.Nullable<decimal> pointerId = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isPointerCaptured" }, pointerId
                }
            );
        }

        public void attachControl(System.Nullable<bool> attachUp = null, System.Nullable<bool> attachDown = null, System.Nullable<bool> attachMove = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachControl" }, attachUp, attachDown, attachMove
                }
            );
        }

        public void detachControl()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachControl" }
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public void resetCachedMaterial()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resetCachedMaterial" }
                }
            );
        }

        #region registerBeforeRender TODO: Get Comments as metadata identification
        private bool _isRegisterBeforeRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _registerBeforeRenderActionMap = new Dictionary<string, Func<Task>>();

        public string registerBeforeRender(
            Func<Task> callback
        )
        {
            SetupRegisterBeforeRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _registerBeforeRenderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupRegisterBeforeRenderLoop()
        {
            if (_isRegisterBeforeRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "registerBeforeRender",
                "CallRegisterBeforeRenderActions",
                _invokableReference
            );
            _isRegisterBeforeRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallRegisterBeforeRenderActions()
        {
            foreach (var action in _registerBeforeRenderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region unregisterBeforeRender TODO: Get Comments as metadata identification
        private bool _isUnregisterBeforeRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _unregisterBeforeRenderActionMap = new Dictionary<string, Func<Task>>();

        public string unregisterBeforeRender(
            Func<Task> callback
        )
        {
            SetupUnregisterBeforeRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _unregisterBeforeRenderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUnregisterBeforeRenderLoop()
        {
            if (_isUnregisterBeforeRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "unregisterBeforeRender",
                "CallUnregisterBeforeRenderActions",
                _invokableReference
            );
            _isUnregisterBeforeRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallUnregisterBeforeRenderActions()
        {
            foreach (var action in _unregisterBeforeRenderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region registerAfterRender TODO: Get Comments as metadata identification
        private bool _isRegisterAfterRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _registerAfterRenderActionMap = new Dictionary<string, Func<Task>>();

        public string registerAfterRender(
            Func<Task> callback
        )
        {
            SetupRegisterAfterRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _registerAfterRenderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupRegisterAfterRenderLoop()
        {
            if (_isRegisterAfterRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "registerAfterRender",
                "CallRegisterAfterRenderActions",
                _invokableReference
            );
            _isRegisterAfterRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallRegisterAfterRenderActions()
        {
            foreach (var action in _registerAfterRenderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region unregisterAfterRender TODO: Get Comments as metadata identification
        private bool _isUnregisterAfterRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _unregisterAfterRenderActionMap = new Dictionary<string, Func<Task>>();

        public string unregisterAfterRender(
            Func<Task> callback
        )
        {
            SetupUnregisterAfterRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _unregisterAfterRenderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUnregisterAfterRenderLoop()
        {
            if (_isUnregisterAfterRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "unregisterAfterRender",
                "CallUnregisterAfterRenderActions",
                _invokableReference
            );
            _isUnregisterAfterRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallUnregisterAfterRenderActions()
        {
            foreach (var action in _unregisterAfterRenderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region executeOnceBeforeRender TODO: Get Comments as metadata identification
        private bool _isExecuteOnceBeforeRenderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _executeOnceBeforeRenderActionMap = new Dictionary<string, Func<Task>>();

        public string executeOnceBeforeRender(
            Func<Task> callback
        )
        {
            SetupExecuteOnceBeforeRenderLoop();

            var handle = Guid.NewGuid().ToString();
            _executeOnceBeforeRenderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupExecuteOnceBeforeRenderLoop()
        {
            if (_isExecuteOnceBeforeRenderEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "executeOnceBeforeRender",
                "CallExecuteOnceBeforeRenderActions",
                _invokableReference
            );
            _isExecuteOnceBeforeRenderEnabled = true;
        }

        [JSInvokable]
        public async Task CallExecuteOnceBeforeRenderActions()
        {
            foreach (var action in _executeOnceBeforeRenderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public decimal getWaitingItemsCount()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getWaitingItemsCount" }
                }
            );
        }

        #region executeWhenReady TODO: Get Comments as metadata identification
        private bool _isExecuteWhenReadyEnabled = false;
        private readonly IDictionary<string, Func<Task>> _executeWhenReadyActionMap = new Dictionary<string, Func<Task>>();

        public string executeWhenReady(
            Func<Task> callback
        )
        {
            SetupExecuteWhenReadyLoop();

            var handle = Guid.NewGuid().ToString();
            _executeWhenReadyActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupExecuteWhenReadyLoop()
        {
            if (_isExecuteWhenReadyEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "executeWhenReady",
                "CallExecuteWhenReadyActions",
                _invokableReference
            );
            _isExecuteWhenReadyEnabled = true;
        }

        [JSInvokable]
        public async Task CallExecuteWhenReadyActions()
        {
            foreach (var action in _executeWhenReadyActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void whenReadyAsync()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "whenReadyAsync" }
                }
            );
        }

        public void resetLastAnimationTimeFrame()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resetLastAnimationTimeFrame" }
                }
            );
        }

        public Matrix getViewMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getViewMatrix" }
                }
            );
        }

        public Matrix getProjectionMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getProjectionMatrix" }
                }
            );
        }

        public Matrix getTransformMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getTransformMatrix" }
                }
            );
        }

        public void setTransformMatrix(Matrix viewL, Matrix projectionL, Matrix viewR = null, Matrix projectionR = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTransformMatrix" }, viewL, projectionL, viewR, projectionR
                }
            );
        }

        public UniformBuffer getSceneUniformBuffer()
        {
            return EventHorizonBlazorInteropt.FuncClass<UniformBuffer>(
                entity => new UniformBuffer(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getSceneUniformBuffer" }
                }
            );
        }

        public decimal getUniqueId()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getUniqueId" }
                }
            );
        }

        public void addMesh(AbstractMesh newMesh, System.Nullable<bool> recursive = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addMesh" }, newMesh, recursive
                }
            );
        }

        public decimal removeMesh(AbstractMesh toRemove, System.Nullable<bool> recursive = null)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeMesh" }, toRemove, recursive
                }
            );
        }

        public void addTransformNode(TransformNode newTransformNode)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addTransformNode" }, newTransformNode
                }
            );
        }

        public decimal removeTransformNode(TransformNode toRemove)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeTransformNode" }, toRemove
                }
            );
        }

        public decimal removeSkeleton(Skeleton toRemove)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeSkeleton" }, toRemove
                }
            );
        }

        public decimal removeMorphTargetManager(MorphTargetManager toRemove)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeMorphTargetManager" }, toRemove
                }
            );
        }

        public decimal removeLight(Light toRemove)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeLight" }, toRemove
                }
            );
        }

        public decimal removeCamera(Camera toRemove)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeCamera" }, toRemove
                }
            );
        }

        public decimal removeParticleSystem(IParticleSystem toRemove)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeParticleSystem" }, toRemove
                }
            );
        }

        public decimal removeAnimation(Animation toRemove)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeAnimation" }, toRemove
                }
            );
        }

        #region stopAnimation TODO: Get Comments as metadata identification
        private bool _isStopAnimationEnabled = false;
        private readonly IDictionary<string, Func<Task>> _stopAnimationActionMap = new Dictionary<string, Func<Task>>();

        public string stopAnimation(
            Func<Task> callback
        )
        {
            SetupStopAnimationLoop();

            var handle = Guid.NewGuid().ToString();
            _stopAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupStopAnimationLoop()
        {
            if (_isStopAnimationEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "stopAnimation",
                "CallStopAnimationActions",
                _invokableReference
            );
            _isStopAnimationEnabled = true;
        }

        [JSInvokable]
        public async Task CallStopAnimationActions()
        {
            foreach (var action in _stopAnimationActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public decimal removeAnimationGroup(AnimationGroup toRemove)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeAnimationGroup" }, toRemove
                }
            );
        }

        public decimal removeMultiMaterial(MultiMaterial toRemove)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeMultiMaterial" }, toRemove
                }
            );
        }

        public decimal removeMaterial(Material toRemove)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeMaterial" }, toRemove
                }
            );
        }

        public decimal removeActionManager(AbstractActionManager toRemove)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeActionManager" }, toRemove
                }
            );
        }

        public decimal removeTexture(BaseTexture toRemove)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeTexture" }, toRemove
                }
            );
        }

        public void addLight(Light newLight)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addLight" }, newLight
                }
            );
        }

        public void sortLightsByPriority()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "sortLightsByPriority" }
                }
            );
        }

        public void addCamera(Camera newCamera)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addCamera" }, newCamera
                }
            );
        }

        public void addSkeleton(Skeleton newSkeleton)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addSkeleton" }, newSkeleton
                }
            );
        }

        public void addParticleSystem(IParticleSystem newParticleSystem)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addParticleSystem" }, newParticleSystem
                }
            );
        }

        public void addAnimation(Animation newAnimation)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addAnimation" }, newAnimation
                }
            );
        }

        public void addAnimationGroup(AnimationGroup newAnimationGroup)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addAnimationGroup" }, newAnimationGroup
                }
            );
        }

        public void addMultiMaterial(MultiMaterial newMultiMaterial)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addMultiMaterial" }, newMultiMaterial
                }
            );
        }

        public void addMaterial(Material newMaterial)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addMaterial" }, newMaterial
                }
            );
        }

        public void addMorphTargetManager(MorphTargetManager newMorphTargetManager)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addMorphTargetManager" }, newMorphTargetManager
                }
            );
        }

        public void addGeometry(Geometry newGeometry)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addGeometry" }, newGeometry
                }
            );
        }

        public void addActionManager(AbstractActionManager newActionManager)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addActionManager" }, newActionManager
                }
            );
        }

        public void addTexture(BaseTexture newTexture)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addTexture" }, newTexture
                }
            );
        }

        public void switchActiveCamera(Camera newCamera, System.Nullable<bool> attachControl = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "switchActiveCamera" }, newCamera, attachControl
                }
            );
        }

        public Camera setActiveCameraByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Camera>(
                entity => new Camera(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setActiveCameraByID" }, id
                }
            );
        }

        public Camera setActiveCameraByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<Camera>(
                entity => new Camera(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setActiveCameraByName" }, name
                }
            );
        }

        public AnimationGroup getAnimationGroupByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationGroup>(
                entity => new AnimationGroup(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getAnimationGroupByName" }, name
                }
            );
        }

        public Material getMaterialByUniqueID(decimal uniqueId)
        {
            return EventHorizonBlazorInteropt.FuncClass<Material>(
                entity => new Material(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getMaterialByUniqueID" }, uniqueId
                }
            );
        }

        public Material getMaterialByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Material>(
                entity => new Material(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getMaterialByID" }, id
                }
            );
        }

        public Material getLastMaterialByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Material>(
                entity => new Material(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getLastMaterialByID" }, id
                }
            );
        }

        public Material getMaterialByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<Material>(
                entity => new Material(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getMaterialByName" }, name
                }
            );
        }

        public BaseTexture getTextureByUniqueID(decimal uniqueId)
        {
            return EventHorizonBlazorInteropt.FuncClass<BaseTexture>(
                entity => new BaseTexture(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getTextureByUniqueID" }, uniqueId
                }
            );
        }

        public Camera getCameraByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Camera>(
                entity => new Camera(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getCameraByID" }, id
                }
            );
        }

        public Camera getCameraByUniqueID(decimal uniqueId)
        {
            return EventHorizonBlazorInteropt.FuncClass<Camera>(
                entity => new Camera(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getCameraByUniqueID" }, uniqueId
                }
            );
        }

        public Camera getCameraByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<Camera>(
                entity => new Camera(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getCameraByName" }, name
                }
            );
        }

        public Bone getBoneByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Bone>(
                entity => new Bone(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getBoneByID" }, id
                }
            );
        }

        public Bone getBoneByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<Bone>(
                entity => new Bone(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getBoneByName" }, name
                }
            );
        }

        public Light getLightByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<Light>(
                entity => new Light(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getLightByName" }, name
                }
            );
        }

        public Light getLightByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Light>(
                entity => new Light(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getLightByID" }, id
                }
            );
        }

        public Light getLightByUniqueID(decimal uniqueId)
        {
            return EventHorizonBlazorInteropt.FuncClass<Light>(
                entity => new Light(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getLightByUniqueID" }, uniqueId
                }
            );
        }

        public IParticleSystem getParticleSystemByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getParticleSystemByID" }, id
                }
            );
        }

        public Geometry getGeometryByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Geometry>(
                entity => new Geometry(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getGeometryByID" }, id
                }
            );
        }

        public bool pushGeometry(Geometry geometry, System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "pushGeometry" }, geometry, force
                }
            );
        }

        public bool removeGeometry(Geometry geometry)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "removeGeometry" }, geometry
                }
            );
        }

        public Geometry[] getGeometries()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<Geometry>(
                entity => new Geometry(entity),
                new object[]
                {
                    new string[] { this.___guid, "getGeometries" }
                }
            );
        }

        public AbstractMesh getMeshByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getMeshByID" }, id
                }
            );
        }

        public AbstractMesh[] getMeshesByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[]
                {
                    new string[] { this.___guid, "getMeshesByID" }, id
                }
            );
        }

        public TransformNode getTransformNodeByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getTransformNodeByID" }, id
                }
            );
        }

        public TransformNode getTransformNodeByUniqueID(decimal uniqueId)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getTransformNodeByUniqueID" }, uniqueId
                }
            );
        }

        public TransformNode[] getTransformNodesByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[]
                {
                    new string[] { this.___guid, "getTransformNodesByID" }, id
                }
            );
        }

        public AbstractMesh getMeshByUniqueID(decimal uniqueId)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getMeshByUniqueID" }, uniqueId
                }
            );
        }

        public AbstractMesh getLastMeshByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getLastMeshByID" }, id
                }
            );
        }

        public Node getLastEntryByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Node>(
                entity => new Node(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getLastEntryByID" }, id
                }
            );
        }

        public Node getNodeByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Node>(
                entity => new Node(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getNodeByID" }, id
                }
            );
        }

        public Node getNodeByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<Node>(
                entity => new Node(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getNodeByName" }, name
                }
            );
        }

        public AbstractMesh getMeshByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getMeshByName" }, name
                }
            );
        }

        public TransformNode getTransformNodeByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getTransformNodeByName" }, name
                }
            );
        }

        public Skeleton getLastSkeletonByID(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Skeleton>(
                entity => new Skeleton(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getLastSkeletonByID" }, id
                }
            );
        }

        public Skeleton getSkeletonByUniqueId(decimal uniqueId)
        {
            return EventHorizonBlazorInteropt.FuncClass<Skeleton>(
                entity => new Skeleton(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getSkeletonByUniqueId" }, uniqueId
                }
            );
        }

        public Skeleton getSkeletonById(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<Skeleton>(
                entity => new Skeleton(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getSkeletonById" }, id
                }
            );
        }

        public Skeleton getSkeletonByName(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<Skeleton>(
                entity => new Skeleton(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getSkeletonByName" }, name
                }
            );
        }

        public MorphTargetManager getMorphTargetManagerById(decimal id)
        {
            return EventHorizonBlazorInteropt.FuncClass<MorphTargetManager>(
                entity => new MorphTargetManager(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getMorphTargetManagerById" }, id
                }
            );
        }

        public MorphTarget getMorphTargetById(string id)
        {
            return EventHorizonBlazorInteropt.FuncClass<MorphTarget>(
                entity => new MorphTarget(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getMorphTargetById" }, id
                }
            );
        }

        public bool isActiveMesh(AbstractMesh mesh)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isActiveMesh" }, mesh
                }
            );
        }

        public bool addExternalData(string key, object data)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "addExternalData" }, key, data
                }
            );
        }

        public CachedEntity getExternalData(string key)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getExternalData" }, key
                }
            );
        }

        #region getOrAddExternalDataWithFactory TODO: Get Comments as metadata identification
        private bool _isGetOrAddExternalDataWithFactoryEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getOrAddExternalDataWithFactoryActionMap = new Dictionary<string, Func<Task>>();

        public string getOrAddExternalDataWithFactory(
            Func<Task> callback
        )
        {
            SetupGetOrAddExternalDataWithFactoryLoop();

            var handle = Guid.NewGuid().ToString();
            _getOrAddExternalDataWithFactoryActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupGetOrAddExternalDataWithFactoryLoop()
        {
            if (_isGetOrAddExternalDataWithFactoryEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "getOrAddExternalDataWithFactory",
                "CallGetOrAddExternalDataWithFactoryActions",
                _invokableReference
            );
            _isGetOrAddExternalDataWithFactoryEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetOrAddExternalDataWithFactoryActions()
        {
            foreach (var action in _getOrAddExternalDataWithFactoryActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public bool removeExternalData(string key)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "removeExternalData" }, key
                }
            );
        }

        public void freeProcessedMaterials()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freeProcessedMaterials" }
                }
            );
        }

        public void freeActiveMeshes()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freeActiveMeshes" }
                }
            );
        }

        public void freeRenderingGroups()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
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

        private void SetupGetActiveMeshCandidatesLoop()
        {
            if (_isGetActiveMeshCandidatesEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        private void SetupGetActiveSubMeshCandidatesLoop()
        {
            if (_isGetActiveSubMeshCandidatesEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        private void SetupGetIntersectingSubMeshCandidatesLoop()
        {
            if (_isGetIntersectingSubMeshCandidatesEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        private void SetupGetCollidingSubMeshCandidatesLoop()
        {
            if (_isGetCollidingSubMeshCandidatesEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        public Scene freezeActiveMeshes(System.Nullable<bool> skipEvaluateActiveMeshes = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene(entity),
                new object[] 
                {
                    new string[] { this.___guid, "freezeActiveMeshes" }, skipEvaluateActiveMeshes
                }
            );
        }

        public Scene unfreezeActiveMeshes()
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene(entity),
                new object[] 
                {
                    new string[] { this.___guid, "unfreezeActiveMeshes" }
                }
            );
        }

        public void updateTransformMatrix(System.Nullable<bool> force = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
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

        private void SetupGetDeterministicFrameTimeLoop()
        {
            if (_isGetDeterministicFrameTimeEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "animate" }
                }
            );
        }

        public void render(System.Nullable<bool> updateCameras = null, System.Nullable<bool> ignoreAnimations = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }, updateCameras, ignoreAnimations
                }
            );
        }

        public void freezeMaterials()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freezeMaterials" }
                }
            );
        }

        public void unfreezeMaterials()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unfreezeMaterials" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public void clearCachedVertexData()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clearCachedVertexData" }
                }
            );
        }

        public void cleanCachedTextureBuffer()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "cleanCachedTextureBuffer" }
                }
            );
        }

        #region getWorldExtends TODO: Get Comments as metadata identification
        private bool _isGetWorldExtendsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getWorldExtendsActionMap = new Dictionary<string, Func<Task>>();

        public string getWorldExtends(
            Func<Task> callback
        )
        {
            SetupGetWorldExtendsLoop();

            var handle = Guid.NewGuid().ToString();
            _getWorldExtendsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupGetWorldExtendsLoop()
        {
            if (_isGetWorldExtendsEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "getWorldExtends",
                "CallGetWorldExtendsActions",
                _invokableReference
            );
            _isGetWorldExtendsEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetWorldExtendsActions()
        {
            foreach (var action in _getWorldExtendsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public Ray createPickingRay(decimal x, decimal y, Matrix world, Camera camera, System.Nullable<bool> cameraViewSpace = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Ray>(
                entity => new Ray(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createPickingRay" }, x, y, world, camera, cameraViewSpace
                }
            );
        }

        public Scene createPickingRayToRef(decimal x, decimal y, Matrix world, Ray result, Camera camera, System.Nullable<bool> cameraViewSpace = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createPickingRayToRef" }, x, y, world, result, camera, cameraViewSpace
                }
            );
        }

        public Ray createPickingRayInCameraSpace(decimal x, decimal y, Camera camera = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Ray>(
                entity => new Ray(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createPickingRayInCameraSpace" }, x, y, camera
                }
            );
        }

        public Scene createPickingRayInCameraSpaceToRef(decimal x, decimal y, Ray result, Camera camera = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createPickingRayInCameraSpaceToRef" }, x, y, result, camera
                }
            );
        }

        #region pick TODO: Get Comments as metadata identification
        private bool _isPickEnabled = false;
        private readonly IDictionary<string, Func<Task>> _pickActionMap = new Dictionary<string, Func<Task>>();

        public string pick(
            Func<Task> callback
        )
        {
            SetupPickLoop();

            var handle = Guid.NewGuid().ToString();
            _pickActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupPickLoop()
        {
            if (_isPickEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "pick",
                "CallPickActions",
                _invokableReference
            );
            _isPickEnabled = true;
        }

        [JSInvokable]
        public async Task CallPickActions()
        {
            foreach (var action in _pickActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region pickWithRay TODO: Get Comments as metadata identification
        private bool _isPickWithRayEnabled = false;
        private readonly IDictionary<string, Func<Task>> _pickWithRayActionMap = new Dictionary<string, Func<Task>>();

        public string pickWithRay(
            Func<Task> callback
        )
        {
            SetupPickWithRayLoop();

            var handle = Guid.NewGuid().ToString();
            _pickWithRayActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupPickWithRayLoop()
        {
            if (_isPickWithRayEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "pickWithRay",
                "CallPickWithRayActions",
                _invokableReference
            );
            _isPickWithRayEnabled = true;
        }

        [JSInvokable]
        public async Task CallPickWithRayActions()
        {
            foreach (var action in _pickWithRayActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region multiPick TODO: Get Comments as metadata identification
        private bool _isMultiPickEnabled = false;
        private readonly IDictionary<string, Func<Task>> _multiPickActionMap = new Dictionary<string, Func<Task>>();

        public string multiPick(
            Func<Task> callback
        )
        {
            SetupMultiPickLoop();

            var handle = Guid.NewGuid().ToString();
            _multiPickActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupMultiPickLoop()
        {
            if (_isMultiPickEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "multiPick",
                "CallMultiPickActions",
                _invokableReference
            );
            _isMultiPickEnabled = true;
        }

        [JSInvokable]
        public async Task CallMultiPickActions()
        {
            foreach (var action in _multiPickActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region multiPickWithRay TODO: Get Comments as metadata identification
        private bool _isMultiPickWithRayEnabled = false;
        private readonly IDictionary<string, Func<Task>> _multiPickWithRayActionMap = new Dictionary<string, Func<Task>>();

        public string multiPickWithRay(
            Func<Task> callback
        )
        {
            SetupMultiPickWithRayLoop();

            var handle = Guid.NewGuid().ToString();
            _multiPickWithRayActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupMultiPickWithRayLoop()
        {
            if (_isMultiPickWithRayEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "multiPickWithRay",
                "CallMultiPickWithRayActions",
                _invokableReference
            );
            _isMultiPickWithRayEnabled = true;
        }

        [JSInvokable]
        public async Task CallMultiPickWithRayActions()
        {
            foreach (var action in _multiPickWithRayActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void setPointerOverMesh(AbstractMesh mesh)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setPointerOverMesh" }, mesh
                }
            );
        }

        public AbstractMesh getPointerOverMesh()
        {
            return EventHorizonBlazorInteropt.FuncClass<AbstractMesh>(
                entity => new AbstractMesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getPointerOverMesh" }
                }
            );
        }

        #region getMeshesByTags TODO: Get Comments as metadata identification
        private bool _isGetMeshesByTagsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getMeshesByTagsActionMap = new Dictionary<string, Func<Task>>();

        public string getMeshesByTags(
            Func<Task> callback
        )
        {
            SetupGetMeshesByTagsLoop();

            var handle = Guid.NewGuid().ToString();
            _getMeshesByTagsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupGetMeshesByTagsLoop()
        {
            if (_isGetMeshesByTagsEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "getMeshesByTags",
                "CallGetMeshesByTagsActions",
                _invokableReference
            );
            _isGetMeshesByTagsEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetMeshesByTagsActions()
        {
            foreach (var action in _getMeshesByTagsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region getCamerasByTags TODO: Get Comments as metadata identification
        private bool _isGetCamerasByTagsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getCamerasByTagsActionMap = new Dictionary<string, Func<Task>>();

        public string getCamerasByTags(
            Func<Task> callback
        )
        {
            SetupGetCamerasByTagsLoop();

            var handle = Guid.NewGuid().ToString();
            _getCamerasByTagsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupGetCamerasByTagsLoop()
        {
            if (_isGetCamerasByTagsEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "getCamerasByTags",
                "CallGetCamerasByTagsActions",
                _invokableReference
            );
            _isGetCamerasByTagsEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetCamerasByTagsActions()
        {
            foreach (var action in _getCamerasByTagsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region getLightsByTags TODO: Get Comments as metadata identification
        private bool _isGetLightsByTagsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getLightsByTagsActionMap = new Dictionary<string, Func<Task>>();

        public string getLightsByTags(
            Func<Task> callback
        )
        {
            SetupGetLightsByTagsLoop();

            var handle = Guid.NewGuid().ToString();
            _getLightsByTagsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupGetLightsByTagsLoop()
        {
            if (_isGetLightsByTagsEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "getLightsByTags",
                "CallGetLightsByTagsActions",
                _invokableReference
            );
            _isGetLightsByTagsEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetLightsByTagsActions()
        {
            foreach (var action in _getLightsByTagsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region getMaterialByTags TODO: Get Comments as metadata identification
        private bool _isGetMaterialByTagsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getMaterialByTagsActionMap = new Dictionary<string, Func<Task>>();

        public string getMaterialByTags(
            Func<Task> callback
        )
        {
            SetupGetMaterialByTagsLoop();

            var handle = Guid.NewGuid().ToString();
            _getMaterialByTagsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupGetMaterialByTagsLoop()
        {
            if (_isGetMaterialByTagsEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "getMaterialByTags",
                "CallGetMaterialByTagsActions",
                _invokableReference
            );
            _isGetMaterialByTagsEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetMaterialByTagsActions()
        {
            foreach (var action in _getMaterialByTagsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void setRenderingOrder(decimal renderingGroupId, SubMesh opaqueSortCompareFn = null, SubMesh alphaTestSortCompareFn = null, SubMesh transparentSortCompareFn = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRenderingOrder" }, renderingGroupId, opaqueSortCompareFn, alphaTestSortCompareFn, transparentSortCompareFn
                }
            );
        }

        public void setRenderingAutoClearDepthStencil(decimal renderingGroupId, bool autoClearDepthStencil, System.Nullable<bool> depth = null, System.Nullable<bool> stencil = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRenderingAutoClearDepthStencil" }, renderingGroupId, autoClearDepthStencil, depth, stencil
                }
            );
        }

        public IRenderingManagerAutoClearSetup getAutoClearDepthStencilSetup(decimal index)
        {
            return EventHorizonBlazorInteropt.FuncClass<IRenderingManagerAutoClearSetup>(
                entity => new IRenderingManagerAutoClearSetupCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getAutoClearDepthStencilSetup" }, index
                }
            );
        }

        #region markAllMaterialsAsDirty TODO: Get Comments as metadata identification
        private bool _isMarkAllMaterialsAsDirtyEnabled = false;
        private readonly IDictionary<string, Func<Task>> _markAllMaterialsAsDirtyActionMap = new Dictionary<string, Func<Task>>();

        public string markAllMaterialsAsDirty(
            Func<Task> callback
        )
        {
            SetupMarkAllMaterialsAsDirtyLoop();

            var handle = Guid.NewGuid().ToString();
            _markAllMaterialsAsDirtyActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupMarkAllMaterialsAsDirtyLoop()
        {
            if (_isMarkAllMaterialsAsDirtyEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "markAllMaterialsAsDirty",
                "CallMarkAllMaterialsAsDirtyActions",
                _invokableReference
            );
            _isMarkAllMaterialsAsDirtyEnabled = true;
        }

        [JSInvokable]
        public async Task CallMarkAllMaterialsAsDirtyActions()
        {
            foreach (var action in _markAllMaterialsAsDirtyActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion
    }
}