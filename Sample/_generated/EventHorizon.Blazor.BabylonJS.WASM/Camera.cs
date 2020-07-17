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
    public class Camera : Node
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal PERSPECTIVE_CAMERA
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.PERSPECTIVE_CAMERA"
                );
            }
        }

        
        public static decimal ORTHOGRAPHIC_CAMERA
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.ORTHOGRAPHIC_CAMERA"
                );
            }
        }

        
        public static decimal FOVMODE_VERTICAL_FIXED
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.FOVMODE_VERTICAL_FIXED"
                );
            }
        }

        
        public static decimal FOVMODE_HORIZONTAL_FIXED
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.FOVMODE_HORIZONTAL_FIXED"
                );
            }
        }

        
        public static decimal RIG_MODE_NONE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_NONE"
                );
            }
        }

        
        public static decimal RIG_MODE_STEREOSCOPIC_ANAGLYPH
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_ANAGLYPH"
                );
            }
        }

        
        public static decimal RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_PARALLEL
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_PARALLEL"
                );
            }
        }

        
        public static decimal RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_CROSSEYED
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_CROSSEYED"
                );
            }
        }

        
        public static decimal RIG_MODE_STEREOSCOPIC_OVERUNDER
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_OVERUNDER"
                );
            }
        }

        
        public static decimal RIG_MODE_STEREOSCOPIC_INTERLACED
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_STEREOSCOPIC_INTERLACED"
                );
            }
        }

        
        public static decimal RIG_MODE_VR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_VR"
                );
            }
        }

        
        public static decimal RIG_MODE_WEBVR
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_WEBVR"
                );
            }
        }

        
        public static decimal RIG_MODE_CUSTOM
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Camera.RIG_MODE_CUSTOM"
                );
            }
        }

        
        public static bool ForceAttachControlToAlwaysPreventDefault
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "Camera.ForceAttachControlToAlwaysPreventDefault"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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

        private static void SetupGetConstructorFromNameStaticLoop()
        {
            if (IsGetConstructorFromNameEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.AssemblyFuncCallback(
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
            return EventHorizonBlazorInteropt.FuncClass<Camera>(
                entity => new Camera(entity),
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
                __position = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __position;
            }
            set
            {
__position = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "position",
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
                __globalPosition = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "globalPosition",
                    (entity) =>
                    {
                        return new Vector3(entity);
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
            return EventHorizonBlazorInteropt.GetArrayClass<Camera>(
                    this.___guid,
                    "rigCameras",
                    (entity) =>
                    {
                        return new Camera(entity);
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
                __rigPostProcess = EventHorizonBlazorInteropt.GetClass<PostProcess>(
                    this.___guid,
                    "rigPostProcess",
                    (entity) =>
                    {
                        return new PostProcess(entity);
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isLeftCamera"
                );
            }
        }

        
        public bool isRightCamera
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
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
                __leftCamera = EventHorizonBlazorInteropt.GetClass<FreeCamera>(
                    this.___guid,
                    "leftCamera",
                    (entity) =>
                    {
                        return new FreeCamera(entity);
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
                __rightCamera = EventHorizonBlazorInteropt.GetClass<FreeCamera>(
                    this.___guid,
                    "rightCamera",
                    (entity) =>
                    {
                        return new FreeCamera(entity);
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
                __absoluteRotation = EventHorizonBlazorInteropt.GetClass<Quaternion>(
                    this.___guid,
                    "absoluteRotation",
                    (entity) =>
                    {
                        return new Quaternion(entity);
                    }
                );
            }
            return __absoluteRotation;
            }
        }
        #endregion

        #region Properties
        private Camera __inputs;
        public Camera inputs
        {
            get
            {
            if(__inputs == null)
            {
                __inputs = EventHorizonBlazorInteropt.GetClass<Camera>(
                    this.___guid,
                    "inputs",
                    (entity) =>
                    {
                        return new Camera(entity);
                    }
                );
            }
            return __inputs;
            }
            set
            {
__inputs = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "inputs",
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
                __upVector = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "upVector",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __upVector;
            }
            set
            {
__upVector = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "upVector",
                    value
                );
            }
        }

        
        public decimal orthoLeft
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "orthoLeft"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "orthoRight"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "orthoBottom"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "orthoTop"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "fov"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "minZ"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxZ"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "inertia"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "mode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isIntermediate"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __viewport = EventHorizonBlazorInteropt.GetClass<Viewport>(
                    this.___guid,
                    "viewport",
                    (entity) =>
                    {
                        return new Viewport(entity);
                    }
                );
            }
            return __viewport;
            }
            set
            {
__viewport = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "fovMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "cameraRigMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "interaxialDistance"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isStereoscopicSideBySide"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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

        private RenderTargetTexture __outputRenderTarget;
        public RenderTargetTexture outputRenderTarget
        {
            get
            {
            if(__outputRenderTarget == null)
            {
                __outputRenderTarget = EventHorizonBlazorInteropt.GetClass<RenderTargetTexture>(
                    this.___guid,
                    "outputRenderTarget",
                    (entity) =>
                    {
                        return new RenderTargetTexture(entity);
                    }
                );
            }
            return __outputRenderTarget;
            }
            set
            {
__outputRenderTarget = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "outputRenderTarget",
                    value
                );
            }
        }

        private Observable __onViewMatrixChangedObservable;
        public Observable onViewMatrixChangedObservable
        {
            get
            {
            if(__onViewMatrixChangedObservable == null)
            {
                __onViewMatrixChangedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onViewMatrixChangedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onViewMatrixChangedObservable;
            }
            set
            {
__onViewMatrixChangedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onViewMatrixChangedObservable",
                    value
                );
            }
        }

        private Observable __onProjectionMatrixChangedObservable;
        public Observable onProjectionMatrixChangedObservable
        {
            get
            {
            if(__onProjectionMatrixChangedObservable == null)
            {
                __onProjectionMatrixChangedObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onProjectionMatrixChangedObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onProjectionMatrixChangedObservable;
            }
            set
            {
__onProjectionMatrixChangedObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onProjectionMatrixChangedObservable",
                    value
                );
            }
        }

        private Observable __onAfterCheckInputsObservable;
        public Observable onAfterCheckInputsObservable
        {
            get
            {
            if(__onAfterCheckInputsObservable == null)
            {
                __onAfterCheckInputsObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterCheckInputsObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterCheckInputsObservable;
            }
            set
            {
__onAfterCheckInputsObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterCheckInputsObservable",
                    value
                );
            }
        }

        private Observable __onRestoreStateObservable;
        public Observable onRestoreStateObservable
        {
            get
            {
            if(__onRestoreStateObservable == null)
            {
                __onRestoreStateObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onRestoreStateObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onRestoreStateObservable;
            }
            set
            {
__onRestoreStateObservable = null;
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isRigCamera"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __rigParent = EventHorizonBlazorInteropt.GetClass<Camera>(
                    this.___guid,
                    "rigParent",
                    (entity) =>
                    {
                        return new Camera(entity);
                    }
                );
            }
            return __rigParent;
            }
            set
            {
__rigParent = null;
                EventHorizonBlazorInteropt.Set(
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
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Camera" },
                name, position, scene, setActiveOnSceneIfNoneActive
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Camera storeState()
        {
            return EventHorizonBlazorInteropt.FuncClass<Camera>(
                entity => new Camera(entity),
                new object[] 
                {
                    new string[] { this.___guid, "storeState" }
                }
            );
        }

        public bool restoreState()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "restoreState" }
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

        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
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

        public bool isActiveMesh(Mesh mesh)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isActiveMesh" }, mesh
                }
            );
        }

        public bool isReady(System.Nullable<bool> completeCheck = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, completeCheck
                }
            );
        }

        public void attachControl(object element, System.Nullable<bool> noPreventDefault = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "attachControl" }, element, noPreventDefault
                }
            );
        }

        public void detachControl(object element)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachControl" }, element
                }
            );
        }

        public void update()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "update" }
                }
            );
        }

        public decimal attachPostProcess(PostProcess postProcess, System.Nullable<decimal> insertAt = null)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "attachPostProcess" }, postProcess, insertAt
                }
            );
        }

        public void detachPostProcess(PostProcess postProcess)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "detachPostProcess" }, postProcess
                }
            );
        }

        public Matrix getWorldMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getWorldMatrix" }
                }
            );
        }

        public Matrix getViewMatrix(System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getViewMatrix" }, force
                }
            );
        }

        public void freezeProjectionMatrix(Matrix projection = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "freezeProjectionMatrix" }, projection
                }
            );
        }

        public void unfreezeProjectionMatrix()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unfreezeProjectionMatrix" }
                }
            );
        }

        public Matrix getProjectionMatrix(System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getProjectionMatrix" }, force
                }
            );
        }

        public Matrix getTransformationMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getTransformationMatrix" }
                }
            );
        }

        public bool isInFrustum(ICullable target, System.Nullable<bool> checkRigCameras = null)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isInFrustum" }, target, checkRigCameras
                }
            );
        }

        public bool isCompletelyInFrustum(ICullable target)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isCompletelyInFrustum" }, target
                }
            );
        }

        public Ray getForwardRay(System.Nullable<decimal> length = null, Matrix transform = null, Vector3 origin = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Ray>(
                entity => new Ray(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getForwardRay" }, length, transform, origin
                }
            );
        }

        public void dispose(System.Nullable<bool> doNotRecurse = null, System.Nullable<bool> disposeMaterialAndTextures = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, doNotRecurse, disposeMaterialAndTextures
                }
            );
        }

        public Vector3 getLeftTarget()
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getLeftTarget" }
                }
            );
        }

        public Vector3 getRightTarget()
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getRightTarget" }
                }
            );
        }

        public void setCameraRigMode(decimal mode, object rigParams)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setCameraRigMode" }, mode, rigParams
                }
            );
        }

        public void setCameraRigParameter(string name, object value)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setCameraRigParameter" }, name, value
                }
            );
        }

        public Camera createRigCamera(string name, decimal cameraIndex)
        {
            return EventHorizonBlazorInteropt.FuncClass<Camera>(
                entity => new Camera(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createRigCamera" }, name, cameraIndex
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public Camera clone(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<Camera>(
                entity => new Camera(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name
                }
            );
        }

        public Vector3 getDirection(Vector3 localAxis)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getDirection" }, localAxis
                }
            );
        }

        public void getDirectionToRef(Vector3 localAxis, Vector3 result)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getDirectionToRef" }, localAxis, result
                }
            );
        }

        public Matrix computeWorldMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "computeWorldMatrix" }
                }
            );
        }
        #endregion
    }
}