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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Scene>))]
    public class Scene : AbstractScene, IAnimatable, IClipPlanesHolder
    {
        #region Static Accessors
        
        public static async ValueTask<decimal> get_DragMovementThreshold()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.DragMovementThreshold"
                );
        }
        public static ValueTask set_DragMovementThreshold(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Scene.DragMovementThreshold",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_LongPressDelay()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.LongPressDelay"
                );
        }
        public static ValueTask set_LongPressDelay(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Scene.LongPressDelay",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_DoubleClickDelay()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.DoubleClickDelay"
                );
        }
        public static ValueTask set_DoubleClickDelay(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Scene.DoubleClickDelay",
                    value
                );
        }

        
        public static async ValueTask<bool> get_ExclusiveDoubleClickMode()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Scene.ExclusiveDoubleClickMode"
                );
        }
        public static ValueTask set_ExclusiveDoubleClickMode(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Scene.ExclusiveDoubleClickMode",
                    value
                );
        }
        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_FOGMODE_NONE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.FOGMODE_NONE"
                );
        }

        
        public static async ValueTask<decimal> get_FOGMODE_EXP()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.FOGMODE_EXP"
                );
        }

        
        public static async ValueTask<decimal> get_FOGMODE_EXP2()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.FOGMODE_EXP2"
                );
        }

        
        public static async ValueTask<decimal> get_FOGMODE_LINEAR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.FOGMODE_LINEAR"
                );
        }

        
        public static async ValueTask<decimal> get_MinDeltaTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.MinDeltaTime"
                );
        }
        public static ValueTask set_MinDeltaTime(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Scene.MinDeltaTime",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_MaxDeltaTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Scene.MaxDeltaTime"
                );
        }
        public static ValueTask set_MaxDeltaTime(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Scene.MaxDeltaTime",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<Material> DefaultMaterialFactory(Scene scene)
        {
            return await EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Scene", "DefaultMaterialFactory" }, scene
                }
            );
        }

        public static async ValueTask<ICollisionCoordinatorCachedEntity> CollisionCoordinatorFactory()
        {
            return await EventHorizonBlazorInterop.FuncClass<ICollisionCoordinatorCachedEntity>(
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
        public async ValueTask<BaseTexture> get_environmentTexture()
        {
            if(__environmentTexture == null)
            {
                __environmentTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
        public ValueTask set_environmentTexture(BaseTexture value)
        {
__environmentTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "environmentTexture",
                    value
                );
        }

        
        public async ValueTask<decimal> get_environmentIntensity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "environmentIntensity"
                );
        }
        public ValueTask set_environmentIntensity(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "environmentIntensity",
                    value
                );
        }

        private ImageProcessingConfiguration __imageProcessingConfiguration;
        public async ValueTask<ImageProcessingConfiguration> get_imageProcessingConfiguration()
        {
            if(__imageProcessingConfiguration == null)
            {
                __imageProcessingConfiguration = await EventHorizonBlazorInterop.GetClass<ImageProcessingConfiguration>(
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

        
        public async ValueTask<bool> get_forceWireframe()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceWireframe"
                );
        }
        public ValueTask set_forceWireframe(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forceWireframe",
                    value
                );
        }

        
        public async ValueTask<bool> get_skipFrustumClipping()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skipFrustumClipping"
                );
        }
        public ValueTask set_skipFrustumClipping(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skipFrustumClipping",
                    value
                );
        }

        
        public async ValueTask<bool> get_forcePointsCloud()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forcePointsCloud"
                );
        }
        public ValueTask set_forcePointsCloud(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forcePointsCloud",
                    value
                );
        }

        private AnimationPropertiesOverride __animationPropertiesOverride;
        public async ValueTask<AnimationPropertiesOverride> get_animationPropertiesOverride()
        {
            if(__animationPropertiesOverride == null)
            {
                __animationPropertiesOverride = await EventHorizonBlazorInterop.GetClass<AnimationPropertiesOverride>(
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
        public ValueTask set_animationPropertiesOverride(AnimationPropertiesOverride value)
        {
__animationPropertiesOverride = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationPropertiesOverride",
                    value
                );
        }

        private Vector2 __unTranslatedPointer;
        public async ValueTask<Vector2> get_unTranslatedPointer()
        {
            if(__unTranslatedPointer == null)
            {
                __unTranslatedPointer = await EventHorizonBlazorInterop.GetClass<Vector2>(
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

        
        public async ValueTask<bool> get_useRightHandedSystem()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useRightHandedSystem"
                );
        }
        public ValueTask set_useRightHandedSystem(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useRightHandedSystem",
                    value
                );
        }

        
        public async ValueTask<bool> get_fogEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "fogEnabled"
                );
        }
        public ValueTask set_fogEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogEnabled",
                    value
                );
        }

        
        public async ValueTask<decimal> get_fogMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fogMode"
                );
        }
        public ValueTask set_fogMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogMode",
                    value
                );
        }

        
        public async ValueTask<bool> get_shadowsEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "shadowsEnabled"
                );
        }
        public ValueTask set_shadowsEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowsEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_lightsEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "lightsEnabled"
                );
        }
        public ValueTask set_lightsEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lightsEnabled",
                    value
                );
        }

        private Camera __activeCamera;
        public async ValueTask<Camera> get_activeCamera()
        {
            if(__activeCamera == null)
            {
                __activeCamera = await EventHorizonBlazorInterop.GetClass<Camera>(
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
        public ValueTask set_activeCamera(Camera value)
        {
__activeCamera = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "activeCamera",
                    value
                );
        }

        private Material __defaultMaterial;
        public async ValueTask<Material> get_defaultMaterial()
        {
            if(__defaultMaterial == null)
            {
                __defaultMaterial = await EventHorizonBlazorInterop.GetClass<Material>(
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
        public ValueTask set_defaultMaterial(Material value)
        {
__defaultMaterial = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultMaterial",
                    value
                );
        }

        
        public async ValueTask<bool> get_texturesEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "texturesEnabled"
                );
        }
        public ValueTask set_texturesEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "texturesEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_skeletonsEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "skeletonsEnabled"
                );
        }
        public ValueTask set_skeletonsEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skeletonsEnabled",
                    value
                );
        }

        private ICollisionCoordinatorCachedEntity __collisionCoordinator;
        public async ValueTask<ICollisionCoordinatorCachedEntity> get_collisionCoordinator()
        {
            if(__collisionCoordinator == null)
            {
                __collisionCoordinator = await EventHorizonBlazorInterop.GetClass<ICollisionCoordinatorCachedEntity>(
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

        
        public async ValueTask<Plane[]> get_frustumPlanes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Plane>(
                    this.___guid,
                    "frustumPlanes",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
        }

        private AbstractMesh __meshUnderPointer;
        public async ValueTask<AbstractMesh> get_meshUnderPointer()
        {
            if(__meshUnderPointer == null)
            {
                __meshUnderPointer = await EventHorizonBlazorInterop.GetClass<AbstractMesh>(
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

        
        public async ValueTask<decimal> get_pointerX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pointerX"
                );
        }
        public ValueTask set_pointerX(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointerX",
                    value
                );
        }

        
        public async ValueTask<decimal> get_pointerY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "pointerY"
                );
        }
        public ValueTask set_pointerY(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "pointerY",
                    value
                );
        }

        private PerfCounter __totalVerticesPerfCounter;
        public async ValueTask<PerfCounter> get_totalVerticesPerfCounter()
        {
            if(__totalVerticesPerfCounter == null)
            {
                __totalVerticesPerfCounter = await EventHorizonBlazorInterop.GetClass<PerfCounter>(
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

        private PerfCounter __totalActiveIndicesPerfCounter;
        public async ValueTask<PerfCounter> get_totalActiveIndicesPerfCounter()
        {
            if(__totalActiveIndicesPerfCounter == null)
            {
                __totalActiveIndicesPerfCounter = await EventHorizonBlazorInterop.GetClass<PerfCounter>(
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

        private PerfCounter __activeParticlesPerfCounter;
        public async ValueTask<PerfCounter> get_activeParticlesPerfCounter()
        {
            if(__activeParticlesPerfCounter == null)
            {
                __activeParticlesPerfCounter = await EventHorizonBlazorInterop.GetClass<PerfCounter>(
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

        private PerfCounter __activeBonesPerfCounter;
        public async ValueTask<PerfCounter> get_activeBonesPerfCounter()
        {
            if(__activeBonesPerfCounter == null)
            {
                __activeBonesPerfCounter = await EventHorizonBlazorInterop.GetClass<PerfCounter>(
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

        
        public async ValueTask<bool> get_isLoading()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLoading"
                );
        }

        
        public async ValueTask<Animatable[]> get_animatables()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Animatable>(
                    this.___guid,
                    "animatables",
                    (entity) =>
                    {
                        return new Animatable() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<string> get_uid()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "uid"
                );
        }

        
        public async ValueTask<bool> get_blockfreeActiveMeshesAndRenderingGroups()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "blockfreeActiveMeshesAndRenderingGroups"
                );
        }
        public ValueTask set_blockfreeActiveMeshesAndRenderingGroups(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blockfreeActiveMeshesAndRenderingGroups",
                    value
                );
        }

        
        public async ValueTask<bool> get_isDisposed()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isDisposed"
                );
        }

        
        public async ValueTask<bool> get_blockMaterialDirtyMechanism()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "blockMaterialDirtyMechanism"
                );
        }
        public ValueTask set_blockMaterialDirtyMechanism(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blockMaterialDirtyMechanism",
                    value
                );
        }
        #endregion

        #region Properties
        private Camera __cameraToUseForPointers;
        public async ValueTask<Camera> get_cameraToUseForPointers()
        {
            if(__cameraToUseForPointers == null)
            {
                __cameraToUseForPointers = await EventHorizonBlazorInterop.GetClass<Camera>(
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
        public ValueTask set_cameraToUseForPointers(Camera value)
        {
__cameraToUseForPointers = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraToUseForPointers",
                    value
                );
        }

        
        public async ValueTask<bool> get_autoClear()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClear"
                );
        }
        public ValueTask set_autoClear(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClear",
                    value
                );
        }

        
        public async ValueTask<bool> get_autoClearDepthAndStencil()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "autoClearDepthAndStencil"
                );
        }
        public ValueTask set_autoClearDepthAndStencil(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "autoClearDepthAndStencil",
                    value
                );
        }

        private Color4 __clearColor;
        public async ValueTask<Color4> get_clearColor()
        {
            if(__clearColor == null)
            {
                __clearColor = await EventHorizonBlazorInterop.GetClass<Color4>(
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
        public ValueTask set_clearColor(Color4 value)
        {
__clearColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clearColor",
                    value
                );
        }

        private Color3 __ambientColor;
        public async ValueTask<Color3> get_ambientColor()
        {
            if(__ambientColor == null)
            {
                __ambientColor = await EventHorizonBlazorInterop.GetClass<Color3>(
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
        public ValueTask set_ambientColor(Color3 value)
        {
__ambientColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ambientColor",
                    value
                );
        }

        private BaseTexture __environmentBRDFTexture;
        public async ValueTask<BaseTexture> get_environmentBRDFTexture()
        {
            if(__environmentBRDFTexture == null)
            {
                __environmentBRDFTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
        public ValueTask set_environmentBRDFTexture(BaseTexture value)
        {
__environmentBRDFTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "environmentBRDFTexture",
                    value
                );
        }

        private Plane __clipPlane;
        public async ValueTask<Plane> get_clipPlane()
        {
            if(__clipPlane == null)
            {
                __clipPlane = await EventHorizonBlazorInterop.GetClass<Plane>(
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
        public ValueTask set_clipPlane(Plane value)
        {
__clipPlane = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane",
                    value
                );
        }

        private Plane __clipPlane2;
        public async ValueTask<Plane> get_clipPlane2()
        {
            if(__clipPlane2 == null)
            {
                __clipPlane2 = await EventHorizonBlazorInterop.GetClass<Plane>(
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
        public ValueTask set_clipPlane2(Plane value)
        {
__clipPlane2 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane2",
                    value
                );
        }

        private Plane __clipPlane3;
        public async ValueTask<Plane> get_clipPlane3()
        {
            if(__clipPlane3 == null)
            {
                __clipPlane3 = await EventHorizonBlazorInterop.GetClass<Plane>(
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
        public ValueTask set_clipPlane3(Plane value)
        {
__clipPlane3 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane3",
                    value
                );
        }

        private Plane __clipPlane4;
        public async ValueTask<Plane> get_clipPlane4()
        {
            if(__clipPlane4 == null)
            {
                __clipPlane4 = await EventHorizonBlazorInterop.GetClass<Plane>(
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
        public ValueTask set_clipPlane4(Plane value)
        {
__clipPlane4 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane4",
                    value
                );
        }

        private Plane __clipPlane5;
        public async ValueTask<Plane> get_clipPlane5()
        {
            if(__clipPlane5 == null)
            {
                __clipPlane5 = await EventHorizonBlazorInterop.GetClass<Plane>(
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
        public ValueTask set_clipPlane5(Plane value)
        {
__clipPlane5 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane5",
                    value
                );
        }

        private Plane __clipPlane6;
        public async ValueTask<Plane> get_clipPlane6()
        {
            if(__clipPlane6 == null)
            {
                __clipPlane6 = await EventHorizonBlazorInterop.GetClass<Plane>(
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
        public ValueTask set_clipPlane6(Plane value)
        {
__clipPlane6 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "clipPlane6",
                    value
                );
        }

        
        public async ValueTask<bool> get_animationsEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "animationsEnabled"
                );
        }
        public ValueTask set_animationsEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationsEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_useConstantAnimationDeltaTime()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useConstantAnimationDeltaTime"
                );
        }
        public ValueTask set_useConstantAnimationDeltaTime(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useConstantAnimationDeltaTime",
                    value
                );
        }

        
        public async ValueTask<bool> get_constantlyUpdateMeshUnderPointer()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "constantlyUpdateMeshUnderPointer"
                );
        }
        public ValueTask set_constantlyUpdateMeshUnderPointer(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "constantlyUpdateMeshUnderPointer",
                    value
                );
        }

        
        public async ValueTask<string> get_hoverCursor()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "hoverCursor"
                );
        }
        public ValueTask set_hoverCursor(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hoverCursor",
                    value
                );
        }

        
        public async ValueTask<string> get_defaultCursor()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "defaultCursor"
                );
        }
        public ValueTask set_defaultCursor(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultCursor",
                    value
                );
        }

        
        public async ValueTask<bool> get_doNotHandleCursors()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "doNotHandleCursors"
                );
        }
        public ValueTask set_doNotHandleCursors(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "doNotHandleCursors",
                    value
                );
        }

        
        public async ValueTask<bool> get_preventDefaultOnPointerDown()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preventDefaultOnPointerDown"
                );
        }
        public ValueTask set_preventDefaultOnPointerDown(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preventDefaultOnPointerDown",
                    value
                );
        }

        
        public async ValueTask<bool> get_preventDefaultOnPointerUp()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preventDefaultOnPointerUp"
                );
        }
        public ValueTask set_preventDefaultOnPointerUp(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preventDefaultOnPointerUp",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_metadata()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "metadata",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_metadata(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "metadata",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_reservedDataStore()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "reservedDataStore",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_reservedDataStore(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reservedDataStore",
                    value
                );
        }

        
        public async ValueTask<string> get_loadingPluginName()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "loadingPluginName"
                );
        }
        public ValueTask set_loadingPluginName(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loadingPluginName",
                    value
                );
        }

        
        public async ValueTask<RegExp[]> get_disableOfflineSupportExceptionRules()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<RegExp>(
                    this.___guid,
                    "disableOfflineSupportExceptionRules",
                    (entity) =>
                    {
                        return new RegExp() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_disableOfflineSupportExceptionRules(RegExp[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableOfflineSupportExceptionRules",
                    value
                );
        }

        private Observable<Scene> __onDisposeObservable;
        public async ValueTask<Observable<Scene>> get_onDisposeObservable()
        {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onDisposeObservable(Observable<Scene> value)
        {
__onDisposeObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
        }

        private Observable<Scene> __onBeforeRenderObservable;
        public async ValueTask<Observable<Scene>> get_onBeforeRenderObservable()
        {
            if(__onBeforeRenderObservable == null)
            {
                __onBeforeRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onBeforeRenderObservable(Observable<Scene> value)
        {
__onBeforeRenderObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeRenderObservable",
                    value
                );
        }

        private Observable<Scene> __onAfterRenderObservable;
        public async ValueTask<Observable<Scene>> get_onAfterRenderObservable()
        {
            if(__onAfterRenderObservable == null)
            {
                __onAfterRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onAfterRenderObservable(Observable<Scene> value)
        {
__onAfterRenderObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterRenderObservable",
                    value
                );
        }

        private Observable<Camera> __onAfterRenderCameraObservable;
        public async ValueTask<Observable<Camera>> get_onAfterRenderCameraObservable()
        {
            if(__onAfterRenderCameraObservable == null)
            {
                __onAfterRenderCameraObservable = await EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
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
        public ValueTask set_onAfterRenderCameraObservable(Observable<Camera> value)
        {
__onAfterRenderCameraObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterRenderCameraObservable",
                    value
                );
        }

        private Observable<Scene> __onBeforeAnimationsObservable;
        public async ValueTask<Observable<Scene>> get_onBeforeAnimationsObservable()
        {
            if(__onBeforeAnimationsObservable == null)
            {
                __onBeforeAnimationsObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onBeforeAnimationsObservable(Observable<Scene> value)
        {
__onBeforeAnimationsObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeAnimationsObservable",
                    value
                );
        }

        private Observable<Scene> __onAfterAnimationsObservable;
        public async ValueTask<Observable<Scene>> get_onAfterAnimationsObservable()
        {
            if(__onAfterAnimationsObservable == null)
            {
                __onAfterAnimationsObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onAfterAnimationsObservable(Observable<Scene> value)
        {
__onAfterAnimationsObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterAnimationsObservable",
                    value
                );
        }

        private Observable<Scene> __onBeforeDrawPhaseObservable;
        public async ValueTask<Observable<Scene>> get_onBeforeDrawPhaseObservable()
        {
            if(__onBeforeDrawPhaseObservable == null)
            {
                __onBeforeDrawPhaseObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onBeforeDrawPhaseObservable(Observable<Scene> value)
        {
__onBeforeDrawPhaseObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeDrawPhaseObservable",
                    value
                );
        }

        private Observable<Scene> __onAfterDrawPhaseObservable;
        public async ValueTask<Observable<Scene>> get_onAfterDrawPhaseObservable()
        {
            if(__onAfterDrawPhaseObservable == null)
            {
                __onAfterDrawPhaseObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onAfterDrawPhaseObservable(Observable<Scene> value)
        {
__onAfterDrawPhaseObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterDrawPhaseObservable",
                    value
                );
        }

        private Observable<Scene> __onReadyObservable;
        public async ValueTask<Observable<Scene>> get_onReadyObservable()
        {
            if(__onReadyObservable == null)
            {
                __onReadyObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onReadyObservable(Observable<Scene> value)
        {
__onReadyObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onReadyObservable",
                    value
                );
        }

        private Observable<Camera> __onBeforeCameraRenderObservable;
        public async ValueTask<Observable<Camera>> get_onBeforeCameraRenderObservable()
        {
            if(__onBeforeCameraRenderObservable == null)
            {
                __onBeforeCameraRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
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
        public ValueTask set_onBeforeCameraRenderObservable(Observable<Camera> value)
        {
__onBeforeCameraRenderObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeCameraRenderObservable",
                    value
                );
        }

        private Observable<Camera> __onAfterCameraRenderObservable;
        public async ValueTask<Observable<Camera>> get_onAfterCameraRenderObservable()
        {
            if(__onAfterCameraRenderObservable == null)
            {
                __onAfterCameraRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
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
        public ValueTask set_onAfterCameraRenderObservable(Observable<Camera> value)
        {
__onAfterCameraRenderObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterCameraRenderObservable",
                    value
                );
        }

        private Observable<Scene> __onBeforeActiveMeshesEvaluationObservable;
        public async ValueTask<Observable<Scene>> get_onBeforeActiveMeshesEvaluationObservable()
        {
            if(__onBeforeActiveMeshesEvaluationObservable == null)
            {
                __onBeforeActiveMeshesEvaluationObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onBeforeActiveMeshesEvaluationObservable(Observable<Scene> value)
        {
__onBeforeActiveMeshesEvaluationObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeActiveMeshesEvaluationObservable",
                    value
                );
        }

        private Observable<Scene> __onAfterActiveMeshesEvaluationObservable;
        public async ValueTask<Observable<Scene>> get_onAfterActiveMeshesEvaluationObservable()
        {
            if(__onAfterActiveMeshesEvaluationObservable == null)
            {
                __onAfterActiveMeshesEvaluationObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onAfterActiveMeshesEvaluationObservable(Observable<Scene> value)
        {
__onAfterActiveMeshesEvaluationObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterActiveMeshesEvaluationObservable",
                    value
                );
        }

        private Observable<Scene> __onBeforeParticlesRenderingObservable;
        public async ValueTask<Observable<Scene>> get_onBeforeParticlesRenderingObservable()
        {
            if(__onBeforeParticlesRenderingObservable == null)
            {
                __onBeforeParticlesRenderingObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onBeforeParticlesRenderingObservable(Observable<Scene> value)
        {
__onBeforeParticlesRenderingObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeParticlesRenderingObservable",
                    value
                );
        }

        private Observable<Scene> __onAfterParticlesRenderingObservable;
        public async ValueTask<Observable<Scene>> get_onAfterParticlesRenderingObservable()
        {
            if(__onAfterParticlesRenderingObservable == null)
            {
                __onAfterParticlesRenderingObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onAfterParticlesRenderingObservable(Observable<Scene> value)
        {
__onAfterParticlesRenderingObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterParticlesRenderingObservable",
                    value
                );
        }

        private Observable<Scene> __onDataLoadedObservable;
        public async ValueTask<Observable<Scene>> get_onDataLoadedObservable()
        {
            if(__onDataLoadedObservable == null)
            {
                __onDataLoadedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onDataLoadedObservable(Observable<Scene> value)
        {
__onDataLoadedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDataLoadedObservable",
                    value
                );
        }

        private Observable<Camera> __onNewCameraAddedObservable;
        public async ValueTask<Observable<Camera>> get_onNewCameraAddedObservable()
        {
            if(__onNewCameraAddedObservable == null)
            {
                __onNewCameraAddedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
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
        public ValueTask set_onNewCameraAddedObservable(Observable<Camera> value)
        {
__onNewCameraAddedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewCameraAddedObservable",
                    value
                );
        }

        private Observable<Camera> __onCameraRemovedObservable;
        public async ValueTask<Observable<Camera>> get_onCameraRemovedObservable()
        {
            if(__onCameraRemovedObservable == null)
            {
                __onCameraRemovedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
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
        public ValueTask set_onCameraRemovedObservable(Observable<Camera> value)
        {
__onCameraRemovedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onCameraRemovedObservable",
                    value
                );
        }

        private Observable<Light> __onNewLightAddedObservable;
        public async ValueTask<Observable<Light>> get_onNewLightAddedObservable()
        {
            if(__onNewLightAddedObservable == null)
            {
                __onNewLightAddedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Light>>(
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
        public ValueTask set_onNewLightAddedObservable(Observable<Light> value)
        {
__onNewLightAddedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewLightAddedObservable",
                    value
                );
        }

        private Observable<Light> __onLightRemovedObservable;
        public async ValueTask<Observable<Light>> get_onLightRemovedObservable()
        {
            if(__onLightRemovedObservable == null)
            {
                __onLightRemovedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Light>>(
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
        public ValueTask set_onLightRemovedObservable(Observable<Light> value)
        {
__onLightRemovedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onLightRemovedObservable",
                    value
                );
        }

        private Observable<Geometry> __onNewGeometryAddedObservable;
        public async ValueTask<Observable<Geometry>> get_onNewGeometryAddedObservable()
        {
            if(__onNewGeometryAddedObservable == null)
            {
                __onNewGeometryAddedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Geometry>>(
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
        public ValueTask set_onNewGeometryAddedObservable(Observable<Geometry> value)
        {
__onNewGeometryAddedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewGeometryAddedObservable",
                    value
                );
        }

        private Observable<Geometry> __onGeometryRemovedObservable;
        public async ValueTask<Observable<Geometry>> get_onGeometryRemovedObservable()
        {
            if(__onGeometryRemovedObservable == null)
            {
                __onGeometryRemovedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Geometry>>(
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
        public ValueTask set_onGeometryRemovedObservable(Observable<Geometry> value)
        {
__onGeometryRemovedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onGeometryRemovedObservable",
                    value
                );
        }

        private Observable<TransformNode> __onNewTransformNodeAddedObservable;
        public async ValueTask<Observable<TransformNode>> get_onNewTransformNodeAddedObservable()
        {
            if(__onNewTransformNodeAddedObservable == null)
            {
                __onNewTransformNodeAddedObservable = await EventHorizonBlazorInterop.GetClass<Observable<TransformNode>>(
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
        public ValueTask set_onNewTransformNodeAddedObservable(Observable<TransformNode> value)
        {
__onNewTransformNodeAddedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewTransformNodeAddedObservable",
                    value
                );
        }

        private Observable<TransformNode> __onTransformNodeRemovedObservable;
        public async ValueTask<Observable<TransformNode>> get_onTransformNodeRemovedObservable()
        {
            if(__onTransformNodeRemovedObservable == null)
            {
                __onTransformNodeRemovedObservable = await EventHorizonBlazorInterop.GetClass<Observable<TransformNode>>(
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
        public ValueTask set_onTransformNodeRemovedObservable(Observable<TransformNode> value)
        {
__onTransformNodeRemovedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onTransformNodeRemovedObservable",
                    value
                );
        }

        private Observable<AbstractMesh> __onNewMeshAddedObservable;
        public async ValueTask<Observable<AbstractMesh>> get_onNewMeshAddedObservable()
        {
            if(__onNewMeshAddedObservable == null)
            {
                __onNewMeshAddedObservable = await EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
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
        public ValueTask set_onNewMeshAddedObservable(Observable<AbstractMesh> value)
        {
__onNewMeshAddedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewMeshAddedObservable",
                    value
                );
        }

        private Observable<AbstractMesh> __onMeshRemovedObservable;
        public async ValueTask<Observable<AbstractMesh>> get_onMeshRemovedObservable()
        {
            if(__onMeshRemovedObservable == null)
            {
                __onMeshRemovedObservable = await EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
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
        public ValueTask set_onMeshRemovedObservable(Observable<AbstractMesh> value)
        {
__onMeshRemovedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onMeshRemovedObservable",
                    value
                );
        }

        private Observable<Skeleton> __onNewSkeletonAddedObservable;
        public async ValueTask<Observable<Skeleton>> get_onNewSkeletonAddedObservable()
        {
            if(__onNewSkeletonAddedObservable == null)
            {
                __onNewSkeletonAddedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Skeleton>>(
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
        public ValueTask set_onNewSkeletonAddedObservable(Observable<Skeleton> value)
        {
__onNewSkeletonAddedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewSkeletonAddedObservable",
                    value
                );
        }

        private Observable<Skeleton> __onSkeletonRemovedObservable;
        public async ValueTask<Observable<Skeleton>> get_onSkeletonRemovedObservable()
        {
            if(__onSkeletonRemovedObservable == null)
            {
                __onSkeletonRemovedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Skeleton>>(
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
        public ValueTask set_onSkeletonRemovedObservable(Observable<Skeleton> value)
        {
__onSkeletonRemovedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onSkeletonRemovedObservable",
                    value
                );
        }

        private Observable<Material> __onNewMaterialAddedObservable;
        public async ValueTask<Observable<Material>> get_onNewMaterialAddedObservable()
        {
            if(__onNewMaterialAddedObservable == null)
            {
                __onNewMaterialAddedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Material>>(
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
        public ValueTask set_onNewMaterialAddedObservable(Observable<Material> value)
        {
__onNewMaterialAddedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewMaterialAddedObservable",
                    value
                );
        }

        private Observable<MultiMaterial> __onNewMultiMaterialAddedObservable;
        public async ValueTask<Observable<MultiMaterial>> get_onNewMultiMaterialAddedObservable()
        {
            if(__onNewMultiMaterialAddedObservable == null)
            {
                __onNewMultiMaterialAddedObservable = await EventHorizonBlazorInterop.GetClass<Observable<MultiMaterial>>(
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
        public ValueTask set_onNewMultiMaterialAddedObservable(Observable<MultiMaterial> value)
        {
__onNewMultiMaterialAddedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewMultiMaterialAddedObservable",
                    value
                );
        }

        private Observable<Material> __onMaterialRemovedObservable;
        public async ValueTask<Observable<Material>> get_onMaterialRemovedObservable()
        {
            if(__onMaterialRemovedObservable == null)
            {
                __onMaterialRemovedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Material>>(
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
        public ValueTask set_onMaterialRemovedObservable(Observable<Material> value)
        {
__onMaterialRemovedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onMaterialRemovedObservable",
                    value
                );
        }

        private Observable<MultiMaterial> __onMultiMaterialRemovedObservable;
        public async ValueTask<Observable<MultiMaterial>> get_onMultiMaterialRemovedObservable()
        {
            if(__onMultiMaterialRemovedObservable == null)
            {
                __onMultiMaterialRemovedObservable = await EventHorizonBlazorInterop.GetClass<Observable<MultiMaterial>>(
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
        public ValueTask set_onMultiMaterialRemovedObservable(Observable<MultiMaterial> value)
        {
__onMultiMaterialRemovedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onMultiMaterialRemovedObservable",
                    value
                );
        }

        private Observable<BaseTexture> __onNewTextureAddedObservable;
        public async ValueTask<Observable<BaseTexture>> get_onNewTextureAddedObservable()
        {
            if(__onNewTextureAddedObservable == null)
            {
                __onNewTextureAddedObservable = await EventHorizonBlazorInterop.GetClass<Observable<BaseTexture>>(
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
        public ValueTask set_onNewTextureAddedObservable(Observable<BaseTexture> value)
        {
__onNewTextureAddedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onNewTextureAddedObservable",
                    value
                );
        }

        private Observable<BaseTexture> __onTextureRemovedObservable;
        public async ValueTask<Observable<BaseTexture>> get_onTextureRemovedObservable()
        {
            if(__onTextureRemovedObservable == null)
            {
                __onTextureRemovedObservable = await EventHorizonBlazorInterop.GetClass<Observable<BaseTexture>>(
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
        public ValueTask set_onTextureRemovedObservable(Observable<BaseTexture> value)
        {
__onTextureRemovedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onTextureRemovedObservable",
                    value
                );
        }

        private Observable<Scene> __onBeforeRenderTargetsRenderObservable;
        public async ValueTask<Observable<Scene>> get_onBeforeRenderTargetsRenderObservable()
        {
            if(__onBeforeRenderTargetsRenderObservable == null)
            {
                __onBeforeRenderTargetsRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onBeforeRenderTargetsRenderObservable(Observable<Scene> value)
        {
__onBeforeRenderTargetsRenderObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeRenderTargetsRenderObservable",
                    value
                );
        }

        private Observable<Scene> __onAfterRenderTargetsRenderObservable;
        public async ValueTask<Observable<Scene>> get_onAfterRenderTargetsRenderObservable()
        {
            if(__onAfterRenderTargetsRenderObservable == null)
            {
                __onAfterRenderTargetsRenderObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onAfterRenderTargetsRenderObservable(Observable<Scene> value)
        {
__onAfterRenderTargetsRenderObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterRenderTargetsRenderObservable",
                    value
                );
        }

        private Observable<Scene> __onBeforeStepObservable;
        public async ValueTask<Observable<Scene>> get_onBeforeStepObservable()
        {
            if(__onBeforeStepObservable == null)
            {
                __onBeforeStepObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onBeforeStepObservable(Observable<Scene> value)
        {
__onBeforeStepObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeStepObservable",
                    value
                );
        }

        private Observable<Scene> __onAfterStepObservable;
        public async ValueTask<Observable<Scene>> get_onAfterStepObservable()
        {
            if(__onAfterStepObservable == null)
            {
                __onAfterStepObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onAfterStepObservable(Observable<Scene> value)
        {
__onAfterStepObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterStepObservable",
                    value
                );
        }

        private Observable<Scene> __onActiveCameraChanged;
        public async ValueTask<Observable<Scene>> get_onActiveCameraChanged()
        {
            if(__onActiveCameraChanged == null)
            {
                __onActiveCameraChanged = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onActiveCameraChanged(Observable<Scene> value)
        {
__onActiveCameraChanged = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onActiveCameraChanged",
                    value
                );
        }

        private Observable<RenderingGroupInfo> __onBeforeRenderingGroupObservable;
        public async ValueTask<Observable<RenderingGroupInfo>> get_onBeforeRenderingGroupObservable()
        {
            if(__onBeforeRenderingGroupObservable == null)
            {
                __onBeforeRenderingGroupObservable = await EventHorizonBlazorInterop.GetClass<Observable<RenderingGroupInfo>>(
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
        public ValueTask set_onBeforeRenderingGroupObservable(Observable<RenderingGroupInfo> value)
        {
__onBeforeRenderingGroupObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeRenderingGroupObservable",
                    value
                );
        }

        private Observable<RenderingGroupInfo> __onAfterRenderingGroupObservable;
        public async ValueTask<Observable<RenderingGroupInfo>> get_onAfterRenderingGroupObservable()
        {
            if(__onAfterRenderingGroupObservable == null)
            {
                __onAfterRenderingGroupObservable = await EventHorizonBlazorInterop.GetClass<Observable<RenderingGroupInfo>>(
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
        public ValueTask set_onAfterRenderingGroupObservable(Observable<RenderingGroupInfo> value)
        {
__onAfterRenderingGroupObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterRenderingGroupObservable",
                    value
                );
        }

        private Observable<AbstractMesh> __onMeshImportedObservable;
        public async ValueTask<Observable<AbstractMesh>> get_onMeshImportedObservable()
        {
            if(__onMeshImportedObservable == null)
            {
                __onMeshImportedObservable = await EventHorizonBlazorInterop.GetClass<Observable<AbstractMesh>>(
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
        public ValueTask set_onMeshImportedObservable(Observable<AbstractMesh> value)
        {
__onMeshImportedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onMeshImportedObservable",
                    value
                );
        }

        private Observable<Scene> __onAnimationFileImportedObservable;
        public async ValueTask<Observable<Scene>> get_onAnimationFileImportedObservable()
        {
            if(__onAnimationFileImportedObservable == null)
            {
                __onAnimationFileImportedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Scene>>(
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
        public ValueTask set_onAnimationFileImportedObservable(Observable<Scene> value)
        {
__onAnimationFileImportedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAnimationFileImportedObservable",
                    value
                );
        }

        private Observable<PointerInfoPre> __onPrePointerObservable;
        public async ValueTask<Observable<PointerInfoPre>> get_onPrePointerObservable()
        {
            if(__onPrePointerObservable == null)
            {
                __onPrePointerObservable = await EventHorizonBlazorInterop.GetClass<Observable<PointerInfoPre>>(
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
        public ValueTask set_onPrePointerObservable(Observable<PointerInfoPre> value)
        {
__onPrePointerObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onPrePointerObservable",
                    value
                );
        }

        private Observable<PointerInfo> __onPointerObservable;
        public async ValueTask<Observable<PointerInfo>> get_onPointerObservable()
        {
            if(__onPointerObservable == null)
            {
                __onPointerObservable = await EventHorizonBlazorInterop.GetClass<Observable<PointerInfo>>(
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
        public ValueTask set_onPointerObservable(Observable<PointerInfo> value)
        {
__onPointerObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onPointerObservable",
                    value
                );
        }

        private Observable<KeyboardInfoPre> __onPreKeyboardObservable;
        public async ValueTask<Observable<KeyboardInfoPre>> get_onPreKeyboardObservable()
        {
            if(__onPreKeyboardObservable == null)
            {
                __onPreKeyboardObservable = await EventHorizonBlazorInterop.GetClass<Observable<KeyboardInfoPre>>(
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
        public ValueTask set_onPreKeyboardObservable(Observable<KeyboardInfoPre> value)
        {
__onPreKeyboardObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onPreKeyboardObservable",
                    value
                );
        }

        private Observable<KeyboardInfo> __onKeyboardObservable;
        public async ValueTask<Observable<KeyboardInfo>> get_onKeyboardObservable()
        {
            if(__onKeyboardObservable == null)
            {
                __onKeyboardObservable = await EventHorizonBlazorInterop.GetClass<Observable<KeyboardInfo>>(
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
        public ValueTask set_onKeyboardObservable(Observable<KeyboardInfo> value)
        {
__onKeyboardObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onKeyboardObservable",
                    value
                );
        }

        private Color3 __fogColor;
        public async ValueTask<Color3> get_fogColor()
        {
            if(__fogColor == null)
            {
                __fogColor = await EventHorizonBlazorInterop.GetClass<Color3>(
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
        public ValueTask set_fogColor(Color3 value)
        {
__fogColor = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogColor",
                    value
                );
        }

        
        public async ValueTask<decimal> get_fogDensity()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fogDensity"
                );
        }
        public ValueTask set_fogDensity(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogDensity",
                    value
                );
        }

        
        public async ValueTask<decimal> get_fogStart()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fogStart"
                );
        }
        public ValueTask set_fogStart(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogStart",
                    value
                );
        }

        
        public async ValueTask<decimal> get_fogEnd()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fogEnd"
                );
        }
        public ValueTask set_fogEnd(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fogEnd",
                    value
                );
        }

        
        public async ValueTask<bool> get_prePass()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "prePass"
                );
        }
        public ValueTask set_prePass(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "prePass",
                    value
                );
        }

        
        public async ValueTask<Camera[]> get_activeCameras()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Camera>(
                    this.___guid,
                    "activeCameras",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_activeCameras(Camera[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "activeCameras",
                    value
                );
        }

        
        public async ValueTask<bool> get_physicsEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "physicsEnabled"
                );
        }
        public ValueTask set_physicsEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "physicsEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_particlesEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "particlesEnabled"
                );
        }
        public ValueTask set_particlesEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "particlesEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_spritesEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "spritesEnabled"
                );
        }
        public ValueTask set_spritesEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "spritesEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_lensFlaresEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "lensFlaresEnabled"
                );
        }
        public ValueTask set_lensFlaresEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lensFlaresEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_collisionsEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "collisionsEnabled"
                );
        }
        public ValueTask set_collisionsEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "collisionsEnabled",
                    value
                );
        }

        private Vector3 __gravity;
        public async ValueTask<Vector3> get_gravity()
        {
            if(__gravity == null)
            {
                __gravity = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_gravity(Vector3 value)
        {
__gravity = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gravity",
                    value
                );
        }

        
        public async ValueTask<bool> get_postProcessesEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "postProcessesEnabled"
                );
        }
        public ValueTask set_postProcessesEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "postProcessesEnabled",
                    value
                );
        }

        private PostProcessManager __postProcessManager;
        public async ValueTask<PostProcessManager> get_postProcessManager()
        {
            if(__postProcessManager == null)
            {
                __postProcessManager = await EventHorizonBlazorInterop.GetClass<PostProcessManager>(
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
        public ValueTask set_postProcessManager(PostProcessManager value)
        {
__postProcessManager = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "postProcessManager",
                    value
                );
        }

        
        public async ValueTask<bool> get_renderTargetsEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "renderTargetsEnabled"
                );
        }
        public ValueTask set_renderTargetsEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderTargetsEnabled",
                    value
                );
        }

        
        public async ValueTask<bool> get_dumpNextRenderTargets()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "dumpNextRenderTargets"
                );
        }
        public ValueTask set_dumpNextRenderTargets(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dumpNextRenderTargets",
                    value
                );
        }

        
        public async ValueTask<RenderTargetTexture[]> get_customRenderTargets()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<RenderTargetTexture>(
                    this.___guid,
                    "customRenderTargets",
                    (entity) =>
                    {
                        return new RenderTargetTexture() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_customRenderTargets(RenderTargetTexture[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customRenderTargets",
                    value
                );
        }

        
        public async ValueTask<bool> get_useDelayedTextureLoading()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useDelayedTextureLoading"
                );
        }
        public ValueTask set_useDelayedTextureLoading(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useDelayedTextureLoading",
                    value
                );
        }

        
        public async ValueTask<string[]> get_importedMeshesFiles()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "importedMeshesFiles"
                );
        }
        public ValueTask set_importedMeshesFiles(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "importedMeshesFiles",
                    value
                );
        }

        
        public async ValueTask<bool> get_probesEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "probesEnabled"
                );
        }
        public ValueTask set_probesEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "probesEnabled",
                    value
                );
        }

        private IOfflineProviderCachedEntity __offlineProvider;
        public async ValueTask<IOfflineProviderCachedEntity> get_offlineProvider()
        {
            if(__offlineProvider == null)
            {
                __offlineProvider = await EventHorizonBlazorInterop.GetClass<IOfflineProviderCachedEntity>(
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
        public ValueTask set_offlineProvider(IOfflineProviderCachedEntity value)
        {
__offlineProvider = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offlineProvider",
                    value
                );
        }

        private AbstractActionManager __actionManager;
        public async ValueTask<AbstractActionManager> get_actionManager()
        {
            if(__actionManager == null)
            {
                __actionManager = await EventHorizonBlazorInterop.GetClass<AbstractActionManager>(
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
        public ValueTask set_actionManager(AbstractActionManager value)
        {
__actionManager = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "actionManager",
                    value
                );
        }

        
        public async ValueTask<bool> get_proceduralTexturesEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "proceduralTexturesEnabled"
                );
        }
        public ValueTask set_proceduralTexturesEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "proceduralTexturesEnabled",
                    value
                );
        }

        
        public async ValueTask<decimal> get_animationTimeScale()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "animationTimeScale"
                );
        }
        public ValueTask set_animationTimeScale(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationTimeScale",
                    value
                );
        }

        
        public async ValueTask<bool> get_dispatchAllSubMeshesOfActiveMeshes()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "dispatchAllSubMeshesOfActiveMeshes"
                );
        }
        public ValueTask set_dispatchAllSubMeshesOfActiveMeshes(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dispatchAllSubMeshesOfActiveMeshes",
                    value
                );
        }

        
        public async ValueTask<bool> get_requireLightSorting()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "requireLightSorting"
                );
        }
        public ValueTask set_requireLightSorting(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "requireLightSorting",
                    value
                );
        }

        
        public async ValueTask<bool> get_useMaterialMeshMap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useMaterialMeshMap"
                );
        }

        
        public async ValueTask<bool> get_useClonedMeshMap()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useClonedMeshMap"
                );
        }
        #endregion
        
        #region Constructor
        public Scene() : base() { }

        public Scene(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Scene> NewScene(
            Engine engine, SceneOptions options = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Scene" },
                engine, options
            );

            return new Scene(entity);
        }
        #endregion

        #region Methods
        #region customLODSelector TODO: Get Comments as metadata identification
        private bool _isCustomLODSelectorEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customLODSelectorActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> customLODSelector(
            Func<Task> callback
        )
        {
            await SetupCustomLODSelectorLoop();

            var handle = Guid.NewGuid().ToString();
            _customLODSelectorActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupCustomLODSelectorLoop()
        {
            if (_isCustomLODSelectorEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> pointerDownPredicate(
            Func<Task> callback
        )
        {
            await SetupPointerDownPredicateLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerDownPredicateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupPointerDownPredicateLoop()
        {
            if (_isPointerDownPredicateEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> pointerUpPredicate(
            Func<Task> callback
        )
        {
            await SetupPointerUpPredicateLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerUpPredicateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupPointerUpPredicateLoop()
        {
            if (_isPointerUpPredicateEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> pointerMovePredicate(
            Func<Task> callback
        )
        {
            await SetupPointerMovePredicateLoop();

            var handle = Guid.NewGuid().ToString();
            _pointerMovePredicateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupPointerMovePredicateLoop()
        {
            if (_isPointerMovePredicateEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> onPointerMove(
            Func<Task> callback
        )
        {
            await SetupOnPointerMoveLoop();

            var handle = Guid.NewGuid().ToString();
            _onPointerMoveActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupOnPointerMoveLoop()
        {
            if (_isOnPointerMoveEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> onPointerDown(
            Func<Task> callback
        )
        {
            await SetupOnPointerDownLoop();

            var handle = Guid.NewGuid().ToString();
            _onPointerDownActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupOnPointerDownLoop()
        {
            if (_isOnPointerDownEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> onPointerUp(
            Func<Task> callback
        )
        {
            await SetupOnPointerUpLoop();

            var handle = Guid.NewGuid().ToString();
            _onPointerUpActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupOnPointerUpLoop()
        {
            if (_isOnPointerUpEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> onPointerPick(
            Func<Task> callback
        )
        {
            await SetupOnPointerPickLoop();

            var handle = Guid.NewGuid().ToString();
            _onPointerPickActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupOnPointerPickLoop()
        {
            if (_isOnPointerPickEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask setStepId(decimal newStepId)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setStepId" }, newStepId
                }
            );
        }

        public async ValueTask<decimal> getStepId()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getStepId" }
                }
            );
        }

        public async ValueTask<decimal> getInternalStep()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getInternalStep" }
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

        public async ValueTask setDefaultCandidateProviders()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDefaultCandidateProviders" }
                }
            );
        }

        public async ValueTask<Material> getCachedMaterial()
        {
            return await EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getCachedMaterial" }
                }
            );
        }

        public async ValueTask<Effect> getCachedEffect()
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getCachedEffect" }
                }
            );
        }

        public async ValueTask<decimal> getCachedVisibility()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getCachedVisibility" }
                }
            );
        }

        public async ValueTask<bool> isCachedMaterialInvalid(Material material, Effect effect, System.Nullable<decimal> visibility = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isCachedMaterialInvalid" }, material, effect, visibility
                }
            );
        }

        public async ValueTask<Engine> getEngine()
        {
            return await EventHorizonBlazorInterop.FuncClass<Engine>(
                entity => new Engine() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEngine" }
                }
            );
        }

        public async ValueTask<decimal> getTotalVertices()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getTotalVertices" }
                }
            );
        }

        public async ValueTask<decimal> getActiveIndices()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getActiveIndices" }
                }
            );
        }

        public async ValueTask<decimal> getActiveParticles()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getActiveParticles" }
                }
            );
        }

        public async ValueTask<decimal> getActiveBones()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getActiveBones" }
                }
            );
        }

        public async ValueTask<SmartArray<AbstractMesh>> getActiveMeshes()
        {
            return await EventHorizonBlazorInterop.FuncClass<SmartArray<AbstractMesh>>(
                entity => new SmartArray<AbstractMesh>() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getActiveMeshes" }
                }
            );
        }

        public async ValueTask<decimal> getAnimationRatio()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getAnimationRatio" }
                }
            );
        }

        public async ValueTask<decimal> getRenderId()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderId" }
                }
            );
        }

        public async ValueTask<decimal> getFrameId()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getFrameId" }
                }
            );
        }

        public async ValueTask incrementRenderId()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "incrementRenderId" }
                }
            );
        }

        public async ValueTask<Scene> simulatePointerMove(PickingInfo pickResult, PointerEventInit pointerEventInit = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "simulatePointerMove" }, pickResult, pointerEventInit
                }
            );
        }

        public async ValueTask<Scene> simulatePointerDown(PickingInfo pickResult, PointerEventInit pointerEventInit = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "simulatePointerDown" }, pickResult, pointerEventInit
                }
            );
        }

        public async ValueTask<Scene> simulatePointerUp(PickingInfo pickResult, PointerEventInit pointerEventInit = null, System.Nullable<bool> doubleTap = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "simulatePointerUp" }, pickResult, pointerEventInit, doubleTap
                }
            );
        }

        public async ValueTask<bool> isPointerCaptured(System.Nullable<decimal> pointerId = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isPointerCaptured" }, pointerId
                }
            );
        }

        public async ValueTask attachControl(System.Nullable<bool> attachUp = null, System.Nullable<bool> attachDown = null, System.Nullable<bool> attachMove = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachControl" }, attachUp, attachDown, attachMove
                }
            );
        }

        public async ValueTask detachControl()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachControl" }
                }
            );
        }

        public async ValueTask<bool> isReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public async ValueTask resetCachedMaterial()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resetCachedMaterial" }
                }
            );
        }

        public async ValueTask registerBeforeRender(ActionCallback func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "registerBeforeRender" }, func
                }
            );
        }

        public async ValueTask unregisterBeforeRender(ActionCallback func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unregisterBeforeRender" }, func
                }
            );
        }

        public async ValueTask registerAfterRender(ActionCallback func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "registerAfterRender" }, func
                }
            );
        }

        public async ValueTask unregisterAfterRender(ActionCallback func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unregisterAfterRender" }, func
                }
            );
        }

        public async ValueTask executeOnceBeforeRender(ActionCallback func, System.Nullable<decimal> timeout = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "executeOnceBeforeRender" }, func, timeout
                }
            );
        }

        public async ValueTask<decimal> getWaitingItemsCount()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getWaitingItemsCount" }
                }
            );
        }

        public async ValueTask executeWhenReady(ActionCallback func)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask resetLastAnimationTimeFrame()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resetLastAnimationTimeFrame" }
                }
            );
        }

        public async ValueTask<Matrix> getViewMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getViewMatrix" }
                }
            );
        }

        public async ValueTask<Matrix> getProjectionMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getProjectionMatrix" }
                }
            );
        }

        public async ValueTask<Matrix> getTransformMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTransformMatrix" }
                }
            );
        }

        public async ValueTask setTransformMatrix(Matrix viewL, Matrix projectionL, Matrix viewR = null, Matrix projectionR = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTransformMatrix" }, viewL, projectionL, viewR, projectionR
                }
            );
        }

        public async ValueTask<UniformBuffer> getSceneUniformBuffer()
        {
            return await EventHorizonBlazorInterop.FuncClass<UniformBuffer>(
                entity => new UniformBuffer() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getSceneUniformBuffer" }
                }
            );
        }

        public async ValueTask<decimal> getUniqueId()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getUniqueId" }
                }
            );
        }

        public async ValueTask addMesh(AbstractMesh newMesh, System.Nullable<bool> recursive = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addMesh" }, newMesh, recursive
                }
            );
        }

        public async ValueTask<decimal> removeMesh(AbstractMesh toRemove, System.Nullable<bool> recursive = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeMesh" }, toRemove, recursive
                }
            );
        }

        public async ValueTask addTransformNode(TransformNode newTransformNode)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addTransformNode" }, newTransformNode
                }
            );
        }

        public async ValueTask<decimal> removeTransformNode(TransformNode toRemove)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeTransformNode" }, toRemove
                }
            );
        }

        public async ValueTask<decimal> removeSkeleton(Skeleton toRemove)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeSkeleton" }, toRemove
                }
            );
        }

        public async ValueTask<decimal> removeMorphTargetManager(MorphTargetManager toRemove)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeMorphTargetManager" }, toRemove
                }
            );
        }

        public async ValueTask<decimal> removeLight(Light toRemove)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeLight" }, toRemove
                }
            );
        }

        public async ValueTask<decimal> removeCamera(Camera toRemove)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeCamera" }, toRemove
                }
            );
        }

        public async ValueTask<decimal> removeParticleSystem(IParticleSystem toRemove)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeParticleSystem" }, toRemove
                }
            );
        }

        public async ValueTask<decimal> removeAnimation(Animation toRemove)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeAnimation" }, toRemove
                }
            );
        }

        public async ValueTask stopAnimation(object target, string animationName = null, ActionCallback<object> targetMask = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stopAnimation" }, target, animationName, targetMask
                }
            );
        }

        public async ValueTask<decimal> removeAnimationGroup(AnimationGroup toRemove)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeAnimationGroup" }, toRemove
                }
            );
        }

        public async ValueTask<decimal> removeMultiMaterial(MultiMaterial toRemove)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeMultiMaterial" }, toRemove
                }
            );
        }

        public async ValueTask<decimal> removeMaterial(Material toRemove)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeMaterial" }, toRemove
                }
            );
        }

        public async ValueTask<decimal> removeActionManager(AbstractActionManager toRemove)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeActionManager" }, toRemove
                }
            );
        }

        public async ValueTask<decimal> removeTexture(BaseTexture toRemove)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "removeTexture" }, toRemove
                }
            );
        }

        public async ValueTask addLight(Light newLight)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addLight" }, newLight
                }
            );
        }

        public async ValueTask sortLightsByPriority()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "sortLightsByPriority" }
                }
            );
        }

        public async ValueTask addCamera(Camera newCamera)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addCamera" }, newCamera
                }
            );
        }

        public async ValueTask addSkeleton(Skeleton newSkeleton)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addSkeleton" }, newSkeleton
                }
            );
        }

        public async ValueTask addParticleSystem(IParticleSystem newParticleSystem)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addParticleSystem" }, newParticleSystem
                }
            );
        }

        public async ValueTask addAnimation(Animation newAnimation)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addAnimation" }, newAnimation
                }
            );
        }

        public async ValueTask addAnimationGroup(AnimationGroup newAnimationGroup)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addAnimationGroup" }, newAnimationGroup
                }
            );
        }

        public async ValueTask addMultiMaterial(MultiMaterial newMultiMaterial)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addMultiMaterial" }, newMultiMaterial
                }
            );
        }

        public async ValueTask addMaterial(Material newMaterial)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addMaterial" }, newMaterial
                }
            );
        }

        public async ValueTask addMorphTargetManager(MorphTargetManager newMorphTargetManager)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addMorphTargetManager" }, newMorphTargetManager
                }
            );
        }

        public async ValueTask addGeometry(Geometry newGeometry)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addGeometry" }, newGeometry
                }
            );
        }

        public async ValueTask addActionManager(AbstractActionManager newActionManager)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addActionManager" }, newActionManager
                }
            );
        }

        public async ValueTask addTexture(BaseTexture newTexture)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addTexture" }, newTexture
                }
            );
        }

        public async ValueTask switchActiveCamera(Camera newCamera, System.Nullable<bool> attachControl = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "switchActiveCamera" }, newCamera, attachControl
                }
            );
        }

        public async ValueTask<Camera> setActiveCameraByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setActiveCameraByID" }, id
                }
            );
        }

        public async ValueTask<Camera> setActiveCameraByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setActiveCameraByName" }, name
                }
            );
        }

        public async ValueTask<AnimationGroup> getAnimationGroupByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAnimationGroupByName" }, name
                }
            );
        }

        public async ValueTask<Material> getMaterialByUniqueID(decimal uniqueId)
        {
            return await EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getMaterialByUniqueID" }, uniqueId
                }
            );
        }

        public async ValueTask<Material> getMaterialByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getMaterialByID" }, id
                }
            );
        }

        public async ValueTask<Material> getLastMaterialByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLastMaterialByID" }, id
                }
            );
        }

        public async ValueTask<Material> getMaterialByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getMaterialByName" }, name
                }
            );
        }

        public async ValueTask<BaseTexture> getTextureByUniqueID(decimal uniqueId)
        {
            return await EventHorizonBlazorInterop.FuncClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTextureByUniqueID" }, uniqueId
                }
            );
        }

        public async ValueTask<Camera> getCameraByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getCameraByID" }, id
                }
            );
        }

        public async ValueTask<Camera> getCameraByUniqueID(decimal uniqueId)
        {
            return await EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getCameraByUniqueID" }, uniqueId
                }
            );
        }

        public async ValueTask<Camera> getCameraByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getCameraByName" }, name
                }
            );
        }

        public async ValueTask<Bone> getBoneByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getBoneByID" }, id
                }
            );
        }

        public async ValueTask<Bone> getBoneByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getBoneByName" }, name
                }
            );
        }

        public async ValueTask<Light> getLightByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLightByName" }, name
                }
            );
        }

        public async ValueTask<Light> getLightByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLightByID" }, id
                }
            );
        }

        public async ValueTask<Light> getLightByUniqueID(decimal uniqueId)
        {
            return await EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLightByUniqueID" }, uniqueId
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> getParticleSystemByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getParticleSystemByID" }, id
                }
            );
        }

        public async ValueTask<Geometry> getGeometryByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getGeometryByID" }, id
                }
            );
        }

        public async ValueTask<bool> pushGeometry(Geometry geometry, System.Nullable<bool> force = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "pushGeometry" }, geometry, force
                }
            );
        }

        public async ValueTask<bool> removeGeometry(Geometry geometry)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "removeGeometry" }, geometry
                }
            );
        }

        public async ValueTask<Geometry[]> getGeometries()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Geometry>(
                entity => new Geometry() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getGeometries" }
                }
            );
        }

        public async ValueTask<AbstractMesh> getMeshByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getMeshByID" }, id
                }
            );
        }

        public async ValueTask<AbstractMesh[]> getMeshesByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMeshesByID" }, id
                }
            );
        }

        public async ValueTask<TransformNode> getTransformNodeByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTransformNodeByID" }, id
                }
            );
        }

        public async ValueTask<TransformNode> getTransformNodeByUniqueID(decimal uniqueId)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTransformNodeByUniqueID" }, uniqueId
                }
            );
        }

        public async ValueTask<TransformNode[]> getTransformNodesByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformNodesByID" }, id
                }
            );
        }

        public async ValueTask<AbstractMesh> getMeshByUniqueID(decimal uniqueId)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getMeshByUniqueID" }, uniqueId
                }
            );
        }

        public async ValueTask<AbstractMesh> getLastMeshByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLastMeshByID" }, id
                }
            );
        }

        public async ValueTask<Node> getLastEntryByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLastEntryByID" }, id
                }
            );
        }

        public async ValueTask<Node> getNodeByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getNodeByID" }, id
                }
            );
        }

        public async ValueTask<Node> getNodeByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getNodeByName" }, name
                }
            );
        }

        public async ValueTask<AbstractMesh> getMeshByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getMeshByName" }, name
                }
            );
        }

        public async ValueTask<TransformNode> getTransformNodeByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTransformNodeByName" }, name
                }
            );
        }

        public async ValueTask<Skeleton> getLastSkeletonByID(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLastSkeletonByID" }, id
                }
            );
        }

        public async ValueTask<Skeleton> getSkeletonByUniqueId(decimal uniqueId)
        {
            return await EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getSkeletonByUniqueId" }, uniqueId
                }
            );
        }

        public async ValueTask<Skeleton> getSkeletonById(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getSkeletonById" }, id
                }
            );
        }

        public async ValueTask<Skeleton> getSkeletonByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getSkeletonByName" }, name
                }
            );
        }

        public async ValueTask<MorphTargetManager> getMorphTargetManagerById(decimal id)
        {
            return await EventHorizonBlazorInterop.FuncClass<MorphTargetManager>(
                entity => new MorphTargetManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getMorphTargetManagerById" }, id
                }
            );
        }

        public async ValueTask<MorphTarget> getMorphTargetById(string id)
        {
            return await EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getMorphTargetById" }, id
                }
            );
        }

        public async ValueTask<MorphTarget> getMorphTargetByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getMorphTargetByName" }, name
                }
            );
        }

        public async ValueTask<PostProcess> getPostProcessByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<PostProcess>(
                entity => new PostProcess() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getPostProcessByName" }, name
                }
            );
        }

        public async ValueTask<bool> isActiveMesh(AbstractMesh mesh)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isActiveMesh" }, mesh
                }
            );
        }

        public async ValueTask<bool> addExternalData<T>(string key, T data)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "addExternalData" }, key, data
                }
            );
        }

        public async ValueTask<T> getExternalData<T>(string key) where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getExternalData" }, key
                }
            );
        }

        public async ValueTask<T> getOrAddExternalDataWithFactory<T>(string key, ActionCallback<string> factory) where T : CachedEntity, new()
        {
            return await EventHorizonBlazorInterop.FuncClass<T>(
                entity => new T() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getOrAddExternalDataWithFactory" }, key, factory
                }
            );
        }

        public async ValueTask<bool> removeExternalData(string key)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "removeExternalData" }, key
                }
            );
        }

        public async ValueTask freeProcessedMaterials()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freeProcessedMaterials" }
                }
            );
        }

        public async ValueTask freeActiveMeshes()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freeActiveMeshes" }
                }
            );
        }

        public async ValueTask freeRenderingGroups()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freeRenderingGroups" }
                }
            );
        }

        #region getActiveMeshCandidates TODO: Get Comments as metadata identification
        private bool _isGetActiveMeshCandidatesEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getActiveMeshCandidatesActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> getActiveMeshCandidates(
            Func<Task> callback
        )
        {
            await SetupGetActiveMeshCandidatesLoop();

            var handle = Guid.NewGuid().ToString();
            _getActiveMeshCandidatesActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupGetActiveMeshCandidatesLoop()
        {
            if (_isGetActiveMeshCandidatesEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> getActiveSubMeshCandidates(
            Func<Task> callback
        )
        {
            await SetupGetActiveSubMeshCandidatesLoop();

            var handle = Guid.NewGuid().ToString();
            _getActiveSubMeshCandidatesActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupGetActiveSubMeshCandidatesLoop()
        {
            if (_isGetActiveSubMeshCandidatesEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> getIntersectingSubMeshCandidates(
            Func<Task> callback
        )
        {
            await SetupGetIntersectingSubMeshCandidatesLoop();

            var handle = Guid.NewGuid().ToString();
            _getIntersectingSubMeshCandidatesActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupGetIntersectingSubMeshCandidatesLoop()
        {
            if (_isGetIntersectingSubMeshCandidatesEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<string> getCollidingSubMeshCandidates(
            Func<Task> callback
        )
        {
            await SetupGetCollidingSubMeshCandidatesLoop();

            var handle = Guid.NewGuid().ToString();
            _getCollidingSubMeshCandidatesActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupGetCollidingSubMeshCandidatesLoop()
        {
            if (_isGetCollidingSubMeshCandidatesEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<Scene> freezeActiveMeshes(System.Nullable<bool> skipEvaluateActiveMeshes = null, ActionCallback onSuccess = null, ActionCallback<string> onError = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "freezeActiveMeshes" }, skipEvaluateActiveMeshes, onSuccess, onError
                }
            );
        }

        public async ValueTask<Scene> unfreezeActiveMeshes()
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "unfreezeActiveMeshes" }
                }
            );
        }

        public async ValueTask updateTransformMatrix(System.Nullable<bool> force = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateTransformMatrix" }, force
                }
            );
        }

        #region getDeterministicFrameTime TODO: Get Comments as metadata identification
        private bool _isGetDeterministicFrameTimeEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getDeterministicFrameTimeActionMap = new Dictionary<string, Func<Task>>();

        public async ValueTask<string> getDeterministicFrameTime(
            Func<Task> callback
        )
        {
            await SetupGetDeterministicFrameTimeLoop();

            var handle = Guid.NewGuid().ToString();
            _getDeterministicFrameTimeActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupGetDeterministicFrameTimeLoop()
        {
            if (_isGetDeterministicFrameTimeEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask animate()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "animate" }
                }
            );
        }

        public async ValueTask render(System.Nullable<bool> updateCameras = null, System.Nullable<bool> ignoreAnimations = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }, updateCameras, ignoreAnimations
                }
            );
        }

        public async ValueTask freezeMaterials()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freezeMaterials" }
                }
            );
        }

        public async ValueTask unfreezeMaterials()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unfreezeMaterials" }
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

        public async ValueTask clearCachedVertexData()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clearCachedVertexData" }
                }
            );
        }

        public async ValueTask cleanCachedTextureBuffer()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "cleanCachedTextureBuffer" }
                }
            );
        }

        public async ValueTask<CachedEntity> getWorldExtends(ActionCallback<AbstractMesh> filterPredicate = null)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getWorldExtends" }, filterPredicate
                }
            );
        }

        public async ValueTask<Ray> createPickingRay(decimal x, decimal y, Matrix world, Camera camera, System.Nullable<bool> cameraViewSpace = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createPickingRay" }, x, y, world, camera, cameraViewSpace
                }
            );
        }

        public async ValueTask<Scene> createPickingRayToRef(decimal x, decimal y, Matrix world, Ray result, Camera camera, System.Nullable<bool> cameraViewSpace = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createPickingRayToRef" }, x, y, world, result, camera, cameraViewSpace
                }
            );
        }

        public async ValueTask<Ray> createPickingRayInCameraSpace(decimal x, decimal y, Camera camera = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createPickingRayInCameraSpace" }, x, y, camera
                }
            );
        }

        public async ValueTask<Scene> createPickingRayInCameraSpaceToRef(decimal x, decimal y, Ray result, Camera camera = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createPickingRayInCameraSpaceToRef" }, x, y, result, camera
                }
            );
        }

        public async ValueTask<PickingInfo> pick(decimal x, decimal y, ActionCallback<AbstractMesh> predicate = null, System.Nullable<bool> fastCheck = null, Camera camera = null, ActionCallback<Vector3, Vector3, Vector3, Ray> trianglePredicate = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "pick" }, x, y, predicate, fastCheck, camera, trianglePredicate
                }
            );
        }

        public async ValueTask<PickingInfo> pickWithBoundingInfo(decimal x, decimal y, ActionCallback<AbstractMesh> predicate = null, System.Nullable<bool> fastCheck = null, Camera camera = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "pickWithBoundingInfo" }, x, y, predicate, fastCheck, camera
                }
            );
        }

        public async ValueTask<PickingInfo> pickWithRay(Ray ray, ActionCallback<AbstractMesh> predicate = null, System.Nullable<bool> fastCheck = null, ActionCallback<Vector3, Vector3, Vector3, Ray> trianglePredicate = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "pickWithRay" }, ray, predicate, fastCheck, trianglePredicate
                }
            );
        }

        public async ValueTask<PickingInfo[]> multiPick(decimal x, decimal y, ActionCallback<AbstractMesh> predicate = null, Camera camera = null, ActionCallback<Vector3, Vector3, Vector3, Ray> trianglePredicate = null)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiPick" }, x, y, predicate, camera, trianglePredicate
                }
            );
        }

        public async ValueTask<PickingInfo[]> multiPickWithRay(Ray ray, ActionCallback<AbstractMesh> predicate, ActionCallback<Vector3, Vector3, Vector3, Ray> trianglePredicate = null)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<PickingInfo>(
                entity => new PickingInfo() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiPickWithRay" }, ray, predicate, trianglePredicate
                }
            );
        }

        public async ValueTask setPointerOverMesh(AbstractMesh mesh, System.Nullable<decimal> pointerId = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setPointerOverMesh" }, mesh, pointerId
                }
            );
        }

        public async ValueTask<AbstractMesh> getPointerOverMesh()
        {
            return await EventHorizonBlazorInterop.FuncClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getPointerOverMesh" }
                }
            );
        }

        public async ValueTask<Mesh[]> getMeshesByTags(string tagsQuery, ActionCallback<AbstractMesh> forEach = null)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMeshesByTags" }, tagsQuery, forEach
                }
            );
        }

        public async ValueTask<Camera[]> getCamerasByTags(string tagsQuery, ActionCallback<Camera> forEach = null)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCamerasByTags" }, tagsQuery, forEach
                }
            );
        }

        public async ValueTask<Light[]> getLightsByTags(string tagsQuery, ActionCallback<Light> forEach = null)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLightsByTags" }, tagsQuery, forEach
                }
            );
        }

        public async ValueTask<Material[]> getMaterialByTags(string tagsQuery, ActionCallback<Material> forEach = null)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Material>(
                entity => new Material() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getMaterialByTags" }, tagsQuery, forEach
                }
            );
        }

        public async ValueTask<TransformNode[]> getTransformNodesByTags(string tagsQuery, ActionCallback<TransformNode> forEach = null)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformNodesByTags" }, tagsQuery, forEach
                }
            );
        }

        public async ValueTask setRenderingOrder(decimal renderingGroupId, ActionCallback<SubMesh, SubMesh> opaqueSortCompareFn = null, ActionCallback<SubMesh, SubMesh> alphaTestSortCompareFn = null, ActionCallback<SubMesh, SubMesh> transparentSortCompareFn = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRenderingOrder" }, renderingGroupId, opaqueSortCompareFn, alphaTestSortCompareFn, transparentSortCompareFn
                }
            );
        }

        public async ValueTask setRenderingAutoClearDepthStencil(decimal renderingGroupId, bool autoClearDepthStencil, System.Nullable<bool> depth = null, System.Nullable<bool> stencil = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRenderingAutoClearDepthStencil" }, renderingGroupId, autoClearDepthStencil, depth, stencil
                }
            );
        }

        public async ValueTask<IRenderingManagerAutoClearSetupCachedEntity> getAutoClearDepthStencilSetup(decimal index)
        {
            return await EventHorizonBlazorInterop.FuncClass<IRenderingManagerAutoClearSetupCachedEntity>(
                entity => new IRenderingManagerAutoClearSetupCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAutoClearDepthStencilSetup" }, index
                }
            );
        }

        public async ValueTask markAllMaterialsAsDirty(decimal flag, ActionCallback<Material> predicate = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAllMaterialsAsDirty" }, flag, predicate
                }
            );
        }
        #endregion
    }
}