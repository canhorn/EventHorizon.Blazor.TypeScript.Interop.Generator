/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Camera>))]
    public class Camera : Node
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal PERSPECTIVE_CAMERA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.PERSPECTIVE_CAMERA"
                );
            }
        }

        
        public static decimal ORTHOGRAPHIC_CAMERA
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.ORTHOGRAPHIC_CAMERA"
                );
            }
        }

        
        public static decimal FOVMODE_VERTICAL_FIXED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.FOVMODE_VERTICAL_FIXED"
                );
            }
        }

        
        public static decimal FOVMODE_HORIZONTAL_FIXED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.FOVMODE_HORIZONTAL_FIXED"
                );
            }
        }

        
        public static decimal RIG_MODE_NONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_NONE"
                );
            }
        }

        
        public static decimal RIG_MODE_STEREOSCOPIC_ANAGLYPH
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_ANAGLYPH"
                );
            }
        }

        
        public static decimal RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_PARALLEL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_PARALLEL"
                );
            }
        }

        
        public static decimal RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_CROSSEYED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_CROSSEYED"
                );
            }
        }

        
        public static decimal RIG_MODE_STEREOSCOPIC_OVERUNDER
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_OVERUNDER"
                );
            }
        }

        
        public static decimal RIG_MODE_STEREOSCOPIC_INTERLACED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_INTERLACED"
                );
            }
        }

        
        public static decimal RIG_MODE_VR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_VR"
                );
            }
        }

        
        public static decimal RIG_MODE_WEBVR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_WEBVR"
                );
            }
        }

        
        public static decimal RIG_MODE_CUSTOM
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_CUSTOM"
                );
            }
        }

        
        public static bool ForceAttachControlToAlwaysPreventDefault
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Camera.ForceAttachControlToAlwaysPreventDefault"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Camera.ForceAttachControlToAlwaysPreventDefault",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        #region GetConstructorFromName TODO: Get Comments as metadata identification
        private static bool IsGetConstructorFromNameEnabled = false;
        private static readonly IDictionary<string, Func<Task>> GetConstructorFromNameActionMap = new Dictionary<string, Func<Task>>();

        public static string GetConstructorFromName(
            Func<Task> callback
        )
        {
            SetupGetConstructorFromNameStaticLoop();

            var handle = Guid.NewGuid().ToString();
            GetConstructorFromNameActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public static bool GetConstructorFromName_Remove(
            string handle
        )
        {
            return GetConstructorFromNameActionMap.Remove(
                handle
            );
        }

        private static void SetupGetConstructorFromNameStaticLoop()
        {
            if (IsGetConstructorFromNameEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
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

        public static Camera Parse(object parsedCamera, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
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
        public Vector3 position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__position = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        private Vector3 __upVector;
        public Vector3 upVector
        {
            get
            {
            if(__upVector == null)
            {
                __upVector = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__upVector = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upVector",
                    value
                );
            }
        }

        private Vector3 __globalPosition;
        public Vector3 globalPosition
        {
            get
            {
            if(__globalPosition == null)
            {
                __globalPosition = EventHorizonBlazorInterop.GetClass<Vector3>(
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
        }

        
        public Camera[] rigCameras
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Camera>(
                    this.___guid,
                    "rigCameras",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
        }

        private PostProcess __rigPostProcess;
        public PostProcess rigPostProcess
        {
            get
            {
            if(__rigPostProcess == null)
            {
                __rigPostProcess = EventHorizonBlazorInterop.GetClass<PostProcess>(
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
        }

        
        public bool isLeftCamera
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLeftCamera"
                );
            }
        }

        
        public bool isRightCamera
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRightCamera"
                );
            }
        }

        private FreeCamera __leftCamera;
        public FreeCamera leftCamera
        {
            get
            {
            if(__leftCamera == null)
            {
                __leftCamera = EventHorizonBlazorInterop.GetClass<FreeCamera>(
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
        }

        private FreeCamera __rightCamera;
        public FreeCamera rightCamera
        {
            get
            {
            if(__rightCamera == null)
            {
                __rightCamera = EventHorizonBlazorInterop.GetClass<FreeCamera>(
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
        }

        private Quaternion __absoluteRotation;
        public Quaternion absoluteRotation
        {
            get
            {
            if(__absoluteRotation == null)
            {
                __absoluteRotation = EventHorizonBlazorInterop.GetClass<Quaternion>(
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
        }
        #endregion

        #region Properties
        private CameraInputsManager<Camera> __inputs;
        public CameraInputsManager<Camera> inputs
        {
            get
            {
            if(__inputs == null)
            {
                __inputs = EventHorizonBlazorInterop.GetClass<CameraInputsManager<Camera>>(
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
            set
            {
__inputs = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputs",
                    value
                );
            }
        }

        
        public decimal orthoLeft
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "orthoLeft"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orthoLeft",
                    value
                );
            }
        }

        
        public decimal orthoRight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "orthoRight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orthoRight",
                    value
                );
            }
        }

        
        public decimal orthoBottom
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "orthoBottom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orthoBottom",
                    value
                );
            }
        }

        
        public decimal orthoTop
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "orthoTop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orthoTop",
                    value
                );
            }
        }

        
        public decimal fov
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fov"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fov",
                    value
                );
            }
        }

        
        public decimal minZ
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minZ"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minZ",
                    value
                );
            }
        }

        
        public decimal maxZ
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxZ"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxZ",
                    value
                );
            }
        }

        
        public decimal inertia
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inertia"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inertia",
                    value
                );
            }
        }

        
        public decimal mode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "mode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mode",
                    value
                );
            }
        }

        
        public bool isIntermediate
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isIntermediate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isIntermediate",
                    value
                );
            }
        }

        private Viewport __viewport;
        public Viewport viewport
        {
            get
            {
            if(__viewport == null)
            {
                __viewport = EventHorizonBlazorInterop.GetClass<Viewport>(
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
            set
            {
__viewport = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "viewport",
                    value
                );
            }
        }

        
        public decimal layerMask
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "layerMask",
                    value
                );
            }
        }

        
        public decimal fovMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fovMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fovMode",
                    value
                );
            }
        }

        
        public decimal cameraRigMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cameraRigMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraRigMode",
                    value
                );
            }
        }

        
        public decimal interaxialDistance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "interaxialDistance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "interaxialDistance",
                    value
                );
            }
        }

        
        public bool isStereoscopicSideBySide
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isStereoscopicSideBySide"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isStereoscopicSideBySide",
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

        private RenderTargetTexture __outputRenderTarget;
        public RenderTargetTexture outputRenderTarget
        {
            get
            {
            if(__outputRenderTarget == null)
            {
                __outputRenderTarget = EventHorizonBlazorInterop.GetClass<RenderTargetTexture>(
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
            set
            {
__outputRenderTarget = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "outputRenderTarget",
                    value
                );
            }
        }

        private Observable<Camera> __onViewMatrixChangedObservable;
        public Observable<Camera> onViewMatrixChangedObservable
        {
            get
            {
            if(__onViewMatrixChangedObservable == null)
            {
                __onViewMatrixChangedObservable = EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
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
            set
            {
__onViewMatrixChangedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onViewMatrixChangedObservable",
                    value
                );
            }
        }

        private Observable<Camera> __onProjectionMatrixChangedObservable;
        public Observable<Camera> onProjectionMatrixChangedObservable
        {
            get
            {
            if(__onProjectionMatrixChangedObservable == null)
            {
                __onProjectionMatrixChangedObservable = EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
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
            set
            {
__onProjectionMatrixChangedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onProjectionMatrixChangedObservable",
                    value
                );
            }
        }

        private Observable<Camera> __onAfterCheckInputsObservable;
        public Observable<Camera> onAfterCheckInputsObservable
        {
            get
            {
            if(__onAfterCheckInputsObservable == null)
            {
                __onAfterCheckInputsObservable = EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
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
            set
            {
__onAfterCheckInputsObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterCheckInputsObservable",
                    value
                );
            }
        }

        private Observable<Camera> __onRestoreStateObservable;
        public Observable<Camera> onRestoreStateObservable
        {
            get
            {
            if(__onRestoreStateObservable == null)
            {
                __onRestoreStateObservable = EventHorizonBlazorInterop.GetClass<Observable<Camera>>(
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
            set
            {
__onRestoreStateObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onRestoreStateObservable",
                    value
                );
            }
        }

        
        public bool isRigCamera
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isRigCamera"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isRigCamera",
                    value
                );
            }
        }

        private Camera __rigParent;
        public Camera rigParent
        {
            get
            {
            if(__rigParent == null)
            {
                __rigParent = EventHorizonBlazorInterop.GetClass<Camera>(
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
            set
            {
__rigParent = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rigParent",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Camera() : base() { }

        public Camera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Camera(
            string name, Vector3 position, Scene scene, System.Nullable<bool> setActiveOnSceneIfNoneActive = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Camera" },
                name, position, scene, setActiveOnSceneIfNoneActive
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Camera storeState()
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "storeState" }
                }
            );
        }

        public bool restoreState()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "restoreState" }
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

        public bool isActiveMesh(Mesh mesh)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isActiveMesh" }, mesh
                }
            );
        }

        public bool isReady(System.Nullable<bool> completeCheck = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }, completeCheck
                }
            );
        }

        public void attachControl(System.Nullable<bool> noPreventDefault = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "attachControl" }, noPreventDefault
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

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public decimal attachPostProcess(PostProcess postProcess, System.Nullable<decimal> insertAt = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "attachPostProcess" }, postProcess, insertAt
                }
            );
        }

        public void detachPostProcess(PostProcess postProcess)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "detachPostProcess" }, postProcess
                }
            );
        }

        public Matrix getWorldMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWorldMatrix" }
                }
            );
        }

        public Matrix getViewMatrix(System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getViewMatrix" }, force
                }
            );
        }

        public void freezeProjectionMatrix(Matrix projection = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "freezeProjectionMatrix" }, projection
                }
            );
        }

        public void unfreezeProjectionMatrix()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unfreezeProjectionMatrix" }
                }
            );
        }

        public Matrix getProjectionMatrix(System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getProjectionMatrix" }, force
                }
            );
        }

        public Matrix getTransformationMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformationMatrix" }
                }
            );
        }

        public bool isInFrustum(ICullable target, System.Nullable<bool> checkRigCameras = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isInFrustum" }, target, checkRigCameras
                }
            );
        }

        public bool isCompletelyInFrustum(ICullable target)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isCompletelyInFrustum" }, target
                }
            );
        }

        public Ray getForwardRay(System.Nullable<decimal> length = null, Matrix transform = null, Vector3 origin = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getForwardRay" }, length, transform, origin
                }
            );
        }

        public Ray getForwardRayToRef(Ray refRay, System.Nullable<decimal> length = null, Matrix transform = null, Vector3 origin = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Ray>(
                entity => new Ray() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getForwardRayToRef" }, refRay, length, transform, origin
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

        public Vector3 getLeftTarget()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLeftTarget" }
                }
            );
        }

        public Vector3 getRightTarget()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRightTarget" }
                }
            );
        }

        public void setCameraRigMode(decimal mode, object rigParams)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCameraRigMode" }, mode, rigParams
                }
            );
        }

        public void setCameraRigParameter(string name, object value)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCameraRigParameter" }, name, value
                }
            );
        }

        public Camera createRigCamera(string name, decimal cameraIndex)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createRigCamera" }, name, cameraIndex
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

        public Camera clone(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<Camera>(
                entity => new Camera() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, name
                }
            );
        }

        public Vector3 getDirection(Vector3 localAxis)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDirection" }, localAxis
                }
            );
        }

        public void getDirectionToRef(Vector3 localAxis, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getDirectionToRef" }, localAxis, result
                }
            );
        }

        public Matrix computeWorldMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
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