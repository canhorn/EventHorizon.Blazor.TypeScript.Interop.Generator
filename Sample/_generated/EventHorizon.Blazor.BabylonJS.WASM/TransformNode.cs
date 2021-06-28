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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TransformNode>))]
    public class TransformNode : Node
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal BILLBOARDMODE_NONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_NONE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_NONE",
                    value
                );
            }
        }

        
        public static decimal BILLBOARDMODE_X
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_X"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_X",
                    value
                );
            }
        }

        
        public static decimal BILLBOARDMODE_Y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_Y"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_Y",
                    value
                );
            }
        }

        
        public static decimal BILLBOARDMODE_Z
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_Z"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_Z",
                    value
                );
            }
        }

        
        public static decimal BILLBOARDMODE_ALL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_ALL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_ALL",
                    value
                );
            }
        }

        
        public static decimal BILLBOARDMODE_USE_POSITION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_USE_POSITION"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_USE_POSITION",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static TransformNode Parse(object parsedTransformNode, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "billboardMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preserveParentRotationForBillboard"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "infiniteDistance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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

        private Vector3 __rotation;
        public Vector3 rotation
        {
            get
            {
            if(__rotation == null)
            {
                __rotation = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "rotation",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __rotation;
            }
            set
            {
__rotation = null;
                EventHorizonBlazorInterop.Set(
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
                __scaling = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "scaling",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __scaling;
            }
            set
            {
__scaling = null;
                EventHorizonBlazorInterop.Set(
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
                __rotationQuaternion = EventHorizonBlazorInterop.GetClass<Quaternion>(
                    this.___guid,
                    "rotationQuaternion",
                    (entity) =>
                    {
                        return new Quaternion() { ___guid = entity.___guid };
                    }
                );
            }
            return __rotationQuaternion;
            }
            set
            {
__rotationQuaternion = null;
                EventHorizonBlazorInterop.Set(
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
                __forward = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "forward",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
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
                __up = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "up",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
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
                __right = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "right",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
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
                __absolutePosition = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "absolutePosition",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
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
                __absoluteScaling = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "absoluteScaling",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
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
                __absoluteRotationQuaternion = EventHorizonBlazorInterop.GetClass<Quaternion>(
                    this.___guid,
                    "absoluteRotationQuaternion",
                    (entity) =>
                    {
                        return new Quaternion() { ___guid = entity.___guid };
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isWorldMatrixFrozen"
                );
            }
        }

        
        public bool nonUniformScaling
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scalingDeterminant"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreNonUniformScaling"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "reIntegrateRotationIntoRotationQuaternion"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reIntegrateRotationIntoRotationQuaternion",
                    value
                );
            }
        }

        private Observable<TransformNode> __onAfterWorldMatrixUpdateObservable;
        public Observable<TransformNode> onAfterWorldMatrixUpdateObservable
        {
            get
            {
            if(__onAfterWorldMatrixUpdateObservable == null)
            {
                __onAfterWorldMatrixUpdateObservable = EventHorizonBlazorInterop.GetClass<Observable<TransformNode>>(
                    this.___guid,
                    "onAfterWorldMatrixUpdateObservable",
                    (entity) =>
                    {
                        return new Observable<TransformNode>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterWorldMatrixUpdateObservable;
            }
            set
            {
__onAfterWorldMatrixUpdateObservable = null;
                EventHorizonBlazorInterop.Set(
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
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "TransformNode" },
                name, scene, isPure
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public TransformNode updatePoseMatrix(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "updatePoseMatrix" }, matrix
                }
            );
        }

        public Matrix getPoseMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPoseMatrix" }
                }
            );
        }

        public TransformNode markAsDirty(string property)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "markAsDirty" }, property
                }
            );
        }

        public TransformNode setPreTransformMatrix(Matrix matrix)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPreTransformMatrix" }, matrix
                }
            );
        }

        public TransformNode setPivotMatrix(Matrix matrix, System.Nullable<bool> postMultiplyPivotMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPivotMatrix" }, matrix, postMultiplyPivotMatrix
                }
            );
        }

        public Matrix getPivotMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPivotMatrix" }
                }
            );
        }

        public TransformNode instantiateHierarchy(TransformNode newParent = null, object options = null, ActionCallback<TransformNode, TransformNode> onNewNodeCreated = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "instantiateHierarchy" }, newParent, options, onNewNodeCreated
                }
            );
        }

        public TransformNode freezeWorldMatrix(Matrix newWorldMatrix = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "freezeWorldMatrix" }, newWorldMatrix
                }
            );
        }

        public TransformNode unfreezeWorldMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "unfreezeWorldMatrix" }
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

        public TransformNode setAbsolutePosition(Vector3 absolutePosition)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAbsolutePosition" }, absolutePosition
                }
            );
        }

        public TransformNode setPositionWithLocalVector(Vector3 vector3)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPositionWithLocalVector" }, vector3
                }
            );
        }

        public Vector3 getPositionExpressedInLocalSpace()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPositionExpressedInLocalSpace" }
                }
            );
        }

        public TransformNode locallyTranslate(Vector3 vector3)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "locallyTranslate" }, vector3
                }
            );
        }

        public TransformNode lookAt(Vector3 targetPoint, System.Nullable<decimal> yawCor = null, System.Nullable<decimal> pitchCor = null, System.Nullable<decimal> rollCor = null, System.Nullable<int> space = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "lookAt" }, targetPoint, yawCor, pitchCor, rollCor, space
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

        public TransformNode getDirectionToRef(Vector3 localAxis, Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDirectionToRef" }, localAxis, result
                }
            );
        }

        public TransformNode setDirection(Vector3 localAxis, System.Nullable<decimal> yawCor = null, System.Nullable<decimal> pitchCor = null, System.Nullable<decimal> rollCor = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setDirection" }, localAxis, yawCor, pitchCor, rollCor
                }
            );
        }

        public TransformNode setPivotPoint(Vector3 point, System.Nullable<int> space = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setPivotPoint" }, point, space
                }
            );
        }

        public Vector3 getPivotPoint()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPivotPoint" }
                }
            );
        }

        public TransformNode getPivotPointToRef(Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPivotPointToRef" }, result
                }
            );
        }

        public Vector3 getAbsolutePivotPoint()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAbsolutePivotPoint" }
                }
            );
        }

        public TransformNode getAbsolutePivotPointToRef(Vector3 result)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAbsolutePivotPointToRef" }, result
                }
            );
        }

        public TransformNode setParent(Node node)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setParent" }, node
                }
            );
        }

        public TransformNode attachToBone(Bone bone, TransformNode affectedTransformNode)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "attachToBone" }, bone, affectedTransformNode
                }
            );
        }

        public TransformNode detachFromBone()
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "detachFromBone" }
                }
            );
        }

        public TransformNode rotate(Vector3 axis, decimal amount, System.Nullable<int> space = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, axis, amount, space
                }
            );
        }

        public TransformNode rotateAround(Vector3 point, Vector3 axis, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "rotateAround" }, point, axis, amount
                }
            );
        }

        public TransformNode translate(Vector3 axis, decimal distance, System.Nullable<int> space = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "translate" }, axis, distance, space
                }
            );
        }

        public TransformNode addRotation(decimal x, decimal y, decimal z)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addRotation" }, x, y, z
                }
            );
        }

        public Matrix computeWorldMatrix(System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "computeWorldMatrix" }, force
                }
            );
        }

        public void resetLocalMatrix(System.Nullable<bool> independentOfChildren = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetLocalMatrix" }, independentOfChildren
                }
            );
        }

        public TransformNode registerAfterWorldMatrixUpdate(ActionCallback<TransformNode> func)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "registerAfterWorldMatrixUpdate" }, func
                }
            );
        }

        public TransformNode unregisterAfterWorldMatrixUpdate(ActionCallback<TransformNode> func)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "unregisterAfterWorldMatrixUpdate" }, func
                }
            );
        }

        public Vector3 getPositionInCameraSpace(Camera camera = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPositionInCameraSpace" }, camera
                }
            );
        }

        public decimal getDistanceToCamera(Camera camera = null)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getDistanceToCamera" }, camera
                }
            );
        }

        public TransformNode clone(string name, Node newParent, System.Nullable<bool> doNotCloneChildren = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren
                }
            );
        }

        public CachedEntity serialize(object currentSerializationObject = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }, currentSerializationObject
                }
            );
        }

        public TransformNode[] getChildTransformNodes(System.Nullable<bool> directDescendantsOnly = null, ActionResultCallback<Node, bool> predicate = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildTransformNodes" }, directDescendantsOnly, predicate
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

        public TransformNode normalizeToUnitCube(System.Nullable<bool> includeDescendants = null, System.Nullable<bool> ignoreRotation = null, ActionResultCallback<AbstractMesh, bool> predicate = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "normalizeToUnitCube" }, includeDescendants, ignoreRotation, predicate
                }
            );
        }
        #endregion
    }
}