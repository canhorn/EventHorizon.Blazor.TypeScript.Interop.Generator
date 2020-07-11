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
    public class TransformNode : Node
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal BILLBOARDMODE_NONE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".TransformNode.BILLBOARDMODE_NONE"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".TransformNode.BILLBOARDMODE_NONE",
                    value
                );
            }
        }

        
        public static decimal BILLBOARDMODE_X
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".TransformNode.BILLBOARDMODE_X"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".TransformNode.BILLBOARDMODE_X",
                    value
                );
            }
        }

        
        public static decimal BILLBOARDMODE_Y
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".TransformNode.BILLBOARDMODE_Y"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".TransformNode.BILLBOARDMODE_Y",
                    value
                );
            }
        }

        
        public static decimal BILLBOARDMODE_Z
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".TransformNode.BILLBOARDMODE_Z"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".TransformNode.BILLBOARDMODE_Z",
                    value
                );
            }
        }

        
        public static decimal BILLBOARDMODE_ALL
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".TransformNode.BILLBOARDMODE_ALL"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".TransformNode.BILLBOARDMODE_ALL",
                    value
                );
            }
        }

        
        public static decimal BILLBOARDMODE_USE_POSITION
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".TransformNode.BILLBOARDMODE_USE_POSITION"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".TransformNode.BILLBOARDMODE_USE_POSITION",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static TransformNode Parse(CachedEntity parsedTransformNode, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "TransformNode", "Parse" }, parsedTransformNode, scene, rootUrl
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal billboardMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "billboardMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "billboardMode",
                    value
                );
            }
        }

        
        public bool preserveParentRotationForBillboard
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "preserveParentRotationForBillboard"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "preserveParentRotationForBillboard",
                    value
                );
            }
        }

        
        public bool infiniteDistance
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "infiniteDistance"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "infiniteDistance",
                    value
                );
            }
        }

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

        private Vector3 __rotation;
        public Vector3 rotation
        {
            get
            {
            if(__rotation == null)
            {
                __rotation = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "rotation",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __rotation;
            }
            set
            {
__rotation = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "rotation",
                    value
                );
            }
        }

        private Vector3 __scaling;
        public Vector3 scaling
        {
            get
            {
            if(__scaling == null)
            {
                __scaling = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "scaling",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __scaling;
            }
            set
            {
__scaling = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "scaling",
                    value
                );
            }
        }

        private Quaternion __rotationQuaternion;
        public Quaternion rotationQuaternion
        {
            get
            {
            if(__rotationQuaternion == null)
            {
                __rotationQuaternion = EventHorizonBlazorInteropt.GetClass<Quaternion>(
                    this.___guid,
                    "rotationQuaternion",
                    (entity) =>
                    {
                        return new Quaternion(entity);
                    }
                );
            }
            return __rotationQuaternion;
            }
            set
            {
__rotationQuaternion = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "rotationQuaternion",
                    value
                );
            }
        }

        private Vector3 __forward;
        public Vector3 forward
        {
            get
            {
            if(__forward == null)
            {
                __forward = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "forward",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __forward;
            }
        }

        private Vector3 __up;
        public Vector3 up
        {
            get
            {
            if(__up == null)
            {
                __up = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "up",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __up;
            }
        }

        private Vector3 __right;
        public Vector3 right
        {
            get
            {
            if(__right == null)
            {
                __right = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "right",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __right;
            }
        }

        private Vector3 __absolutePosition;
        public Vector3 absolutePosition
        {
            get
            {
            if(__absolutePosition == null)
            {
                __absolutePosition = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "absolutePosition",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __absolutePosition;
            }
        }

        private Vector3 __absoluteScaling;
        public Vector3 absoluteScaling
        {
            get
            {
            if(__absoluteScaling == null)
            {
                __absoluteScaling = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "absoluteScaling",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __absoluteScaling;
            }
        }

        private Quaternion __absoluteRotationQuaternion;
        public Quaternion absoluteRotationQuaternion
        {
            get
            {
            if(__absoluteRotationQuaternion == null)
            {
                __absoluteRotationQuaternion = EventHorizonBlazorInteropt.GetClass<Quaternion>(
                    this.___guid,
                    "absoluteRotationQuaternion",
                    (entity) =>
                    {
                        return new Quaternion(entity);
                    }
                );
            }
            return __absoluteRotationQuaternion;
            }
        }

        
        public bool isWorldMatrixFrozen
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isWorldMatrixFrozen"
                );
            }
        }

        
        public bool nonUniformScaling
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "nonUniformScaling"
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal scalingDeterminant
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "scalingDeterminant"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "scalingDeterminant",
                    value
                );
            }
        }

        
        public bool ignoreNonUniformScaling
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "ignoreNonUniformScaling"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "ignoreNonUniformScaling",
                    value
                );
            }
        }

        
        public bool reIntegrateRotationIntoRotationQuaternion
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "reIntegrateRotationIntoRotationQuaternion"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "reIntegrateRotationIntoRotationQuaternion",
                    value
                );
            }
        }

        private Observable __onAfterWorldMatrixUpdateObservable;
        public Observable onAfterWorldMatrixUpdateObservable
        {
            get
            {
            if(__onAfterWorldMatrixUpdateObservable == null)
            {
                __onAfterWorldMatrixUpdateObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onAfterWorldMatrixUpdateObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onAfterWorldMatrixUpdateObservable;
            }
            set
            {
__onAfterWorldMatrixUpdateObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onAfterWorldMatrixUpdateObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public TransformNode() : base() { }

        public TransformNode(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public TransformNode(
            string name, Scene scene = null, System.Nullable<bool> isPure = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "TransformNode" },
                name, scene, isPure
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public TransformNode updatePoseMatrix(Matrix matrix)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "updatePoseMatrix" }, matrix
                }
            );
        }

        public Matrix getPoseMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getPoseMatrix" }
                }
            );
        }

        public TransformNode markAsDirty(string property)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "markAsDirty" }, property
                }
            );
        }

        public TransformNode setPreTransformMatrix(Matrix matrix)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setPreTransformMatrix" }, matrix
                }
            );
        }

        public TransformNode setPivotMatrix(Matrix matrix, System.Nullable<bool> postMultiplyPivotMatrix = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setPivotMatrix" }, matrix, postMultiplyPivotMatrix
                }
            );
        }

        public Matrix getPivotMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getPivotMatrix" }
                }
            );
        }

        #region instantiateHierarchy TODO: Get Comments as metadata identification
        private bool _isInstantiateHierarchyEnabled = false;
        private readonly IDictionary<string, Func<Task>> _instantiateHierarchyActionMap = new Dictionary<string, Func<Task>>();

        public string instantiateHierarchy(
            Func<Task> callback
        )
        {
            SetupInstantiateHierarchyLoop();

            var handle = Guid.NewGuid().ToString();
            _instantiateHierarchyActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupInstantiateHierarchyLoop()
        {
            if (_isInstantiateHierarchyEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "instantiateHierarchy",
                "CallInstantiateHierarchyActions",
                _invokableReference
            );
            _isInstantiateHierarchyEnabled = true;
        }

        [JSInvokable]
        public async Task CallInstantiateHierarchyActions()
        {
            foreach (var action in _instantiateHierarchyActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public TransformNode freezeWorldMatrix(Matrix newWorldMatrix = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "freezeWorldMatrix" }, newWorldMatrix
                }
            );
        }

        public TransformNode unfreezeWorldMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "unfreezeWorldMatrix" }
                }
            );
        }

        public Vector3 getAbsolutePosition()
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getAbsolutePosition" }
                }
            );
        }

        public TransformNode setAbsolutePosition(Vector3 absolutePosition)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setAbsolutePosition" }, absolutePosition
                }
            );
        }

        public TransformNode setPositionWithLocalVector(Vector3 vector3)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setPositionWithLocalVector" }, vector3
                }
            );
        }

        public Vector3 getPositionExpressedInLocalSpace()
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getPositionExpressedInLocalSpace" }
                }
            );
        }

        public TransformNode locallyTranslate(Vector3 vector3)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "locallyTranslate" }, vector3
                }
            );
        }

        public TransformNode lookAt(Vector3 targetPoint, System.Nullable<decimal> yawCor = null, System.Nullable<decimal> pitchCor = null, System.Nullable<decimal> rollCor = null, Space space = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "lookAt" }, targetPoint, yawCor, pitchCor, rollCor, space
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

        public TransformNode getDirectionToRef(Vector3 localAxis, Vector3 result)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getDirectionToRef" }, localAxis, result
                }
            );
        }

        public TransformNode setDirection(Vector3 localAxis, System.Nullable<decimal> yawCor = null, System.Nullable<decimal> pitchCor = null, System.Nullable<decimal> rollCor = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setDirection" }, localAxis, yawCor, pitchCor, rollCor
                }
            );
        }

        public TransformNode setPivotPoint(Vector3 point, Space space = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setPivotPoint" }, point, space
                }
            );
        }

        public Vector3 getPivotPoint()
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getPivotPoint" }
                }
            );
        }

        public TransformNode getPivotPointToRef(Vector3 result)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getPivotPointToRef" }, result
                }
            );
        }

        public Vector3 getAbsolutePivotPoint()
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getAbsolutePivotPoint" }
                }
            );
        }

        public TransformNode getAbsolutePivotPointToRef(Vector3 result)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getAbsolutePivotPointToRef" }, result
                }
            );
        }

        public TransformNode setParent(Node node)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setParent" }, node
                }
            );
        }

        public TransformNode attachToBone(Bone bone, TransformNode affectedTransformNode)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "attachToBone" }, bone, affectedTransformNode
                }
            );
        }

        public TransformNode detachFromBone()
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "detachFromBone" }
                }
            );
        }

        public TransformNode rotate(Vector3 axis, decimal amount, Space space = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "rotate" }, axis, amount, space
                }
            );
        }

        public TransformNode rotateAround(Vector3 point, Vector3 axis, decimal amount)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "rotateAround" }, point, axis, amount
                }
            );
        }

        public TransformNode translate(Vector3 axis, decimal distance, Space space = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "translate" }, axis, distance, space
                }
            );
        }

        public TransformNode addRotation(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addRotation" }, x, y, z
                }
            );
        }

        public Matrix computeWorldMatrix(System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "computeWorldMatrix" }, force
                }
            );
        }

        public void resetLocalMatrix(System.Nullable<bool> independentOfChildren = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resetLocalMatrix" }, independentOfChildren
                }
            );
        }

        #region registerAfterWorldMatrixUpdate TODO: Get Comments as metadata identification
        private bool _isRegisterAfterWorldMatrixUpdateEnabled = false;
        private readonly IDictionary<string, Func<Task>> _registerAfterWorldMatrixUpdateActionMap = new Dictionary<string, Func<Task>>();

        public string registerAfterWorldMatrixUpdate(
            Func<Task> callback
        )
        {
            SetupRegisterAfterWorldMatrixUpdateLoop();

            var handle = Guid.NewGuid().ToString();
            _registerAfterWorldMatrixUpdateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupRegisterAfterWorldMatrixUpdateLoop()
        {
            if (_isRegisterAfterWorldMatrixUpdateEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "registerAfterWorldMatrixUpdate",
                "CallRegisterAfterWorldMatrixUpdateActions",
                _invokableReference
            );
            _isRegisterAfterWorldMatrixUpdateEnabled = true;
        }

        [JSInvokable]
        public async Task CallRegisterAfterWorldMatrixUpdateActions()
        {
            foreach (var action in _registerAfterWorldMatrixUpdateActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region unregisterAfterWorldMatrixUpdate TODO: Get Comments as metadata identification
        private bool _isUnregisterAfterWorldMatrixUpdateEnabled = false;
        private readonly IDictionary<string, Func<Task>> _unregisterAfterWorldMatrixUpdateActionMap = new Dictionary<string, Func<Task>>();

        public string unregisterAfterWorldMatrixUpdate(
            Func<Task> callback
        )
        {
            SetupUnregisterAfterWorldMatrixUpdateLoop();

            var handle = Guid.NewGuid().ToString();
            _unregisterAfterWorldMatrixUpdateActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUnregisterAfterWorldMatrixUpdateLoop()
        {
            if (_isUnregisterAfterWorldMatrixUpdateEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "unregisterAfterWorldMatrixUpdate",
                "CallUnregisterAfterWorldMatrixUpdateActions",
                _invokableReference
            );
            _isUnregisterAfterWorldMatrixUpdateEnabled = true;
        }

        [JSInvokable]
        public async Task CallUnregisterAfterWorldMatrixUpdateActions()
        {
            foreach (var action in _unregisterAfterWorldMatrixUpdateActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public Vector3 getPositionInCameraSpace(Camera camera = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getPositionInCameraSpace" }, camera
                }
            );
        }

        public decimal getDistanceToCamera(Camera camera = null)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDistanceToCamera" }, camera
                }
            );
        }

        public TransformNode clone(string name, Node newParent, System.Nullable<bool> doNotCloneChildren = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren
                }
            );
        }

        public CachedEntity serialize(CachedEntity currentSerializationObject = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, currentSerializationObject
                }
            );
        }

        #region getChildTransformNodes TODO: Get Comments as metadata identification
        private bool _isGetChildTransformNodesEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getChildTransformNodesActionMap = new Dictionary<string, Func<Task>>();

        public string getChildTransformNodes(
            Func<Task> callback
        )
        {
            SetupGetChildTransformNodesLoop();

            var handle = Guid.NewGuid().ToString();
            _getChildTransformNodesActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupGetChildTransformNodesLoop()
        {
            if (_isGetChildTransformNodesEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "getChildTransformNodes",
                "CallGetChildTransformNodesActions",
                _invokableReference
            );
            _isGetChildTransformNodesEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetChildTransformNodesActions()
        {
            foreach (var action in _getChildTransformNodesActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void dispose(System.Nullable<bool> doNotRecurse = null, System.Nullable<bool> disposeMaterialAndTextures = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, doNotRecurse, disposeMaterialAndTextures
                }
            );
        }

        public TransformNode normalizeToUnitCube(System.Nullable<bool> includeDescendants = null, System.Nullable<bool> ignoreRotation = null, AbstractMesh predicate = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<TransformNode>(
                entity => new TransformNode(entity),
                new object[] 
                {
                    new string[] { this.___guid, "normalizeToUnitCube" }, includeDescendants, ignoreRotation, predicate
                }
            );
        }
        #endregion
    }
}