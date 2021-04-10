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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Camera>))]
    public class Camera : Node
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_PERSPECTIVE_CAMERA()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.PERSPECTIVE_CAMERA"
                );
        }

        
        public static async ValueTask<decimal> get_ORTHOGRAPHIC_CAMERA()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.ORTHOGRAPHIC_CAMERA"
                );
        }

        
        public static async ValueTask<decimal> get_FOVMODE_VERTICAL_FIXED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.FOVMODE_VERTICAL_FIXED"
                );
        }

        
        public static async ValueTask<decimal> get_FOVMODE_HORIZONTAL_FIXED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.FOVMODE_HORIZONTAL_FIXED"
                );
        }

        
        public static async ValueTask<decimal> get_RIG_MODE_NONE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_NONE"
                );
        }

        
        public static async ValueTask<decimal> get_RIG_MODE_STEREOSCOPIC_ANAGLYPH()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_ANAGLYPH"
                );
        }

        
        public static async ValueTask<decimal> get_RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_PARALLEL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_PARALLEL"
                );
        }

        
        public static async ValueTask<decimal> get_RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_CROSSEYED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_CROSSEYED"
                );
        }

        
        public static async ValueTask<decimal> get_RIG_MODE_STEREOSCOPIC_OVERUNDER()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_OVERUNDER"
                );
        }

        
        public static async ValueTask<decimal> get_RIG_MODE_STEREOSCOPIC_INTERLACED()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_INTERLACED"
                );
        }

        
        public static async ValueTask<decimal> get_RIG_MODE_VR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_VR"
                );
        }

        
        public static async ValueTask<decimal> get_RIG_MODE_WEBVR()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_WEBVR"
                );
        }

        
        public static async ValueTask<decimal> get_RIG_MODE_CUSTOM()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_CUSTOM"
                );
        }

        
        public static async ValueTask<bool> get_ForceAttachControlToAlwaysPreventDefault()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Camera.ForceAttachControlToAlwaysPreventDefault"
                );
        }
        public static ValueTask set_ForceAttachControlToAlwaysPreventDefault(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Camera.ForceAttachControlToAlwaysPreventDefault",
                    value
                );
        }
        #endregion

        #region Static Methods
        #region GetConstructorFromName TODO: Get Comments as metadata identification
        private static bool IsGetConstructorFromNameEnabled = false;
        private static readonly IDictionary<string, Func<Task>> GetConstructorFromNameActionMap = new Dictionary<string, Func<Task>>();

        public static async ValueTask<string> GetConstructorFromName(
            Func<Task> callback
        )
        {
            await SetupGetConstructorFromNameStaticLoop();

            var handle = Guid.NewGuid().ToString();
            GetConstructorFromNameActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static async ValueTask SetupGetConstructorFromNameStaticLoop()
        {
            if (IsGetConstructorFromNameEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.Server",
                "BABYLON.Camera.GetConstructorFromName",
                "CallGetConstructorFromNameStaticActions"
            );
            IsGetConstructorFromNameEnabled = true;
        }

        [JSInvokable]
        public static async Task CallGetConstructorFromNameStaticActions()
        {
            foreach (var action in GetConstructorFromNameActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public static async ValueTask<Camera> Parse(object parsedCamera, Scene scene)
        {
            return await EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Camera", "Parse" }, parsedCamera, scene
                }
            );
        }
        #endregion

        #region Accessors
        private Vector3 __position;
        public async ValueTask<Vector3> get_position()
        {
            if(__position == null)
            {
                __position = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
        }
        public ValueTask set_position(Vector3 value)
        {
__position = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
        }

        private Vector3 __upVector;
        public async ValueTask<Vector3> get_upVector()
        {
            if(__upVector == null)
            {
                __upVector = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "upVector",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __upVector;
        }
        public ValueTask set_upVector(Vector3 value)
        {
__upVector = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upVector",
                    value
                );
        }

        private Vector3 __globalPosition;
        public async ValueTask<Vector3> get_globalPosition()
        {
            if(__globalPosition == null)
            {
                __globalPosition = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "globalPosition",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __globalPosition;
        }

        
        public async ValueTask<Camera[]> get_rigCameras()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Camera>(
                    this.___guid,
                    "rigCameras",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
        }

        private PostProcess __rigPostProcess;
        public async ValueTask<PostProcess> get_rigPostProcess()
        {
            if(__rigPostProcess == null)
            {
                __rigPostProcess = await EventHorizonBlazorInterop.GetClass<PostProcess>(
                    this.___guid,
                    "rigPostProcess",
                    (entity) =>
                    {
                        return new PostProcess() { ___guid = entity.___guid };
                    }
                );
            }
            return __rigPostProcess;
        }

        
        public async ValueTask<bool> get_isLeftCamera()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLeftCamera"
                );
        }

        
        public async ValueTask<bool> get_isRightCamera()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRightCamera"
                );
        }

        private FreeCamera __leftCamera;
        public async ValueTask<FreeCamera> get_leftCamera()
        {
            if(__leftCamera == null)
            {
                __leftCamera = await EventHorizonBlazorInterop.GetClass<FreeCamera>(
                    this.___guid,
                    "leftCamera",
                    (entity) =>
                    {
                        return new FreeCamera() { ___guid = entity.___guid };
                    }
                );
            }
            return __leftCamera;
        }

        private FreeCamera __rightCamera;
        public async ValueTask<FreeCamera> get_rightCamera()
        {
            if(__rightCamera == null)
            {
                __rightCamera = await EventHorizonBlazorInterop.GetClass<FreeCamera>(
                    this.___guid,
                    "rightCamera",
                    (entity) =>
                    {
                        return new FreeCamera() { ___guid = entity.___guid };
                    }
                );
            }
            return __rightCamera;
        }

        private Quaternion __absoluteRotation;
        public async ValueTask<Quaternion> get_absoluteRotation()
        {
            if(__absoluteRotation == null)
            {
                __absoluteRotation = await EventHorizonBlazorInterop.GetClass<Quaternion>(
                    this.___guid,
                    "absoluteRotation",
                    (entity) =>
                    {
                        return new Quaternion() { ___guid = entity.___guid };
                    }
                );
            }
            return __absoluteRotation;
        }
        #endregion

        #region Properties
        private CameraInputsManager<Camera> __inputs;
        public async ValueTask<CameraInputsManager<Camera>> get_inputs()
        {
            if(__inputs == null)
            {
                __inputs = await EventHorizonBlazorInterop.GetClass<CameraInputsManager<Camera>>(
                    this.___guid,
                    "inputs",
                    (entity) =>
                    {
                        return new CameraInputsManager<Camera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __inputs;
        }
        public ValueTask set_inputs(CameraInputsManager<Camera> value)
        {
__inputs = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputs",
                    value
                );
        }

        
        public async ValueTask<decimal> get_orthoLeft()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "orthoLeft"
                );
        }
        public ValueTask set_orthoLeft(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orthoLeft",
                    value
                );
        }

        
        public async ValueTask<decimal> get_orthoRight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "orthoRight"
                );
        }
        public ValueTask set_orthoRight(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orthoRight",
                    value
                );
        }

        
        public async ValueTask<decimal> get_orthoBottom()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "orthoBottom"
                );
        }
        public ValueTask set_orthoBottom(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orthoBottom",
                    value
                );
        }

        
        public async ValueTask<decimal> get_orthoTop()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "orthoTop"
                );
        }
        public ValueTask set_orthoTop(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orthoTop",
                    value
                );
        }

        
        public async ValueTask<decimal> get_fov()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fov"
                );
        }
        public ValueTask set_fov(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fov",
                    value
                );
        }

        
        public async ValueTask<decimal> get_minZ()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minZ"
                );
        }
        public ValueTask set_minZ(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minZ",
                    value
                );
        }

        
        public async ValueTask<decimal> get_maxZ()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxZ"
                );
        }
        public ValueTask set_maxZ(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxZ",
                    value
                );
        }

        
        public async ValueTask<decimal> get_inertia()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertia"
                );
        }
        public ValueTask set_inertia(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertia",
                    value
                );
        }

        
        public async ValueTask<decimal> get_mode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mode"
                );
        }
        public ValueTask set_mode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mode",
                    value
                );
        }

        
        public async ValueTask<bool> get_isIntermediate()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isIntermediate"
                );
        }
        public ValueTask set_isIntermediate(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isIntermediate",
                    value
                );
        }

        private Viewport __viewport;
        public async ValueTask<Viewport> get_viewport()
        {
            if(__viewport == null)
            {
                __viewport = await EventHorizonBlazorInterop.GetClass<Viewport>(
                    this.___guid,
                    "viewport",
                    (entity) =>
                    {
                        return new Viewport() { ___guid = entity.___guid };
                    }
                );
            }
            return __viewport;
        }
        public ValueTask set_viewport(Viewport value)
        {
__viewport = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "viewport",
                    value
                );
        }

        
        public async ValueTask<decimal> get_layerMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
        }
        public ValueTask set_layerMask(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "layerMask",
                    value
                );
        }

        
        public async ValueTask<decimal> get_fovMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fovMode"
                );
        }
        public ValueTask set_fovMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fovMode",
                    value
                );
        }

        
        public async ValueTask<decimal> get_cameraRigMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cameraRigMode"
                );
        }
        public ValueTask set_cameraRigMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraRigMode",
                    value
                );
        }

        
        public async ValueTask<decimal> get_interaxialDistance()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "interaxialDistance"
                );
        }
        public ValueTask set_interaxialDistance(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "interaxialDistance",
                    value
                );
        }

        
        public async ValueTask<bool> get_isStereoscopicSideBySide()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isStereoscopicSideBySide"
                );
        }
        public ValueTask set_isStereoscopicSideBySide(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isStereoscopicSideBySide",
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

        private RenderTargetTexture __outputRenderTarget;
        public async ValueTask<RenderTargetTexture> get_outputRenderTarget()
        {
            if(__outputRenderTarget == null)
            {
                __outputRenderTarget = await EventHorizonBlazorInterop.GetClass<RenderTargetTexture>(
                    this.___guid,
                    "outputRenderTarget",
                    (entity) =>
                    {
                        return new RenderTargetTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __outputRenderTarget;
        }
        public ValueTask set_outputRenderTarget(RenderTargetTexture value)
        {
__outputRenderTarget = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outputRenderTarget",
                    value
                );
        }

        private Observable<Camera> __onViewMatrixChangedObservable;
        public async ValueTask<Observable<Camera>> get_onViewMatrixChangedObservable()
        {
            if(__onViewMatrixChangedObservable == null)
            {
                __onViewMatrixChangedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
                    this.___guid,
                    "onViewMatrixChangedObservable",
                    (entity) =>
                    {
                        return new Observable<Camera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onViewMatrixChangedObservable;
        }
        public ValueTask set_onViewMatrixChangedObservable(Observable<Camera> value)
        {
__onViewMatrixChangedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onViewMatrixChangedObservable",
                    value
                );
        }

        private Observable<Camera> __onProjectionMatrixChangedObservable;
        public async ValueTask<Observable<Camera>> get_onProjectionMatrixChangedObservable()
        {
            if(__onProjectionMatrixChangedObservable == null)
            {
                __onProjectionMatrixChangedObservable = await EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
                    this.___guid,
                    "onProjectionMatrixChangedObservable",
                    (entity) =>
                    {
                        return new Observable<Camera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onProjectionMatrixChangedObservable;
        }
        public ValueTask set_onProjectionMatrixChangedObservable(Observable<Camera> value)
        {
__onProjectionMatrixChangedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onProjectionMatrixChangedObservable",
                    value
                );
        }

        private Observable<Camera> __onAfterCheckInputsObservable;
        public async ValueTask<Observable<Camera>> get_onAfterCheckInputsObservable()
        {
            if(__onAfterCheckInputsObservable == null)
            {
                __onAfterCheckInputsObservable = await EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
                    this.___guid,
                    "onAfterCheckInputsObservable",
                    (entity) =>
                    {
                        return new Observable<Camera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterCheckInputsObservable;
        }
        public ValueTask set_onAfterCheckInputsObservable(Observable<Camera> value)
        {
__onAfterCheckInputsObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterCheckInputsObservable",
                    value
                );
        }

        private Observable<Camera> __onRestoreStateObservable;
        public async ValueTask<Observable<Camera>> get_onRestoreStateObservable()
        {
            if(__onRestoreStateObservable == null)
            {
                __onRestoreStateObservable = await EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
                    this.___guid,
                    "onRestoreStateObservable",
                    (entity) =>
                    {
                        return new Observable<Camera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onRestoreStateObservable;
        }
        public ValueTask set_onRestoreStateObservable(Observable<Camera> value)
        {
__onRestoreStateObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onRestoreStateObservable",
                    value
                );
        }

        
        public async ValueTask<bool> get_isRigCamera()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRigCamera"
                );
        }
        public ValueTask set_isRigCamera(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isRigCamera",
                    value
                );
        }

        private Camera __rigParent;
        public async ValueTask<Camera> get_rigParent()
        {
            if(__rigParent == null)
            {
                __rigParent = await EventHorizonBlazorInterop.GetClass<Camera>(
                    this.___guid,
                    "rigParent",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            return __rigParent;
        }
        public ValueTask set_rigParent(Camera value)
        {
__rigParent = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rigParent",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Camera() : base() { }

        public Camera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Camera> NewCamera(
            string name, Vector3 position, Scene scene, System.Nullable<bool> setActiveOnSceneIfNoneActive = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Camera" },
                name, position, scene, setActiveOnSceneIfNoneActive
            );

            return new Camera(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<Camera> storeState()
        {
            return await EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "storeState" }
                }
            );
        }

        public async ValueTask<bool> restoreState()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "restoreState" }
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

        public async ValueTask<bool> isActiveMesh(Mesh mesh)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isActiveMesh" }, mesh
                }
            );
        }

        public async ValueTask<bool> isReady(System.Nullable<bool> completeCheck = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, completeCheck
                }
            );
        }

        public async ValueTask attachControl(System.Nullable<bool> noPreventDefault = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachControl" }, noPreventDefault
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

        public async ValueTask update()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public async ValueTask<decimal> attachPostProcess(PostProcess postProcess, System.Nullable<decimal> insertAt = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "attachPostProcess" }, postProcess, insertAt
                }
            );
        }

        public async ValueTask detachPostProcess(PostProcess postProcess)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachPostProcess" }, postProcess
                }
            );
        }

        public async ValueTask<Matrix> getWorldMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getWorldMatrix" }
                }
            );
        }

        public async ValueTask<Matrix> getViewMatrix(System.Nullable<bool> force = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getViewMatrix" }, force
                }
            );
        }

        public async ValueTask freezeProjectionMatrix(Matrix projection = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freezeProjectionMatrix" }, projection
                }
            );
        }

        public async ValueTask unfreezeProjectionMatrix()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unfreezeProjectionMatrix" }
                }
            );
        }

        public async ValueTask<Matrix> getProjectionMatrix(System.Nullable<bool> force = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getProjectionMatrix" }, force
                }
            );
        }

        public async ValueTask<Matrix> getTransformationMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTransformationMatrix" }
                }
            );
        }

        public async ValueTask<bool> isInFrustum(ICullable target, System.Nullable<bool> checkRigCameras = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isInFrustum" }, target, checkRigCameras
                }
            );
        }

        public async ValueTask<bool> isCompletelyInFrustum(ICullable target)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isCompletelyInFrustum" }, target
                }
            );
        }

        public async ValueTask<Ray> getForwardRay(System.Nullable<decimal> length = null, Matrix transform = null, Vector3 origin = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getForwardRay" }, length, transform, origin
                }
            );
        }

        public async ValueTask<Ray> getForwardRayToRef(Ray refRay, System.Nullable<decimal> length = null, Matrix transform = null, Vector3 origin = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getForwardRayToRef" }, refRay, length, transform, origin
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

        public async ValueTask<Vector3> getLeftTarget()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLeftTarget" }
                }
            );
        }

        public async ValueTask<Vector3> getRightTarget()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRightTarget" }
                }
            );
        }

        public async ValueTask setCameraRigMode(decimal mode, object rigParams)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setCameraRigMode" }, mode, rigParams
                }
            );
        }

        public async ValueTask setCameraRigParameter(string name, object value)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setCameraRigParameter" }, name, value
                }
            );
        }

        public async ValueTask<Camera> createRigCamera(string name, decimal cameraIndex)
        {
            return await EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createRigCamera" }, name, cameraIndex
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

        public async ValueTask<Camera> clone(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name
                }
            );
        }

        public async ValueTask<Vector3> getDirection(Vector3 localAxis)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getDirection" }, localAxis
                }
            );
        }

        public async ValueTask getDirectionToRef(Vector3 localAxis, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getDirectionToRef" }, localAxis, result
                }
            );
        }

        public async ValueTask<Matrix> computeWorldMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "computeWorldMatrix" }
                }
            );
        }
        #endregion
    }
}