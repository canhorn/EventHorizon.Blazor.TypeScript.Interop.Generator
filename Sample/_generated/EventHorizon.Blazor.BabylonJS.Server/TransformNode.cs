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

    
    
    [JsonConverter(typeof(CachedEntityConverter<TransformNode>))]
    public class TransformNode : Node
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_BILLBOARDMODE_NONE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_NONE"
                );
        }
        public static ValueTask set_BILLBOARDMODE_NONE(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_NONE",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_BILLBOARDMODE_X()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_X"
                );
        }
        public static ValueTask set_BILLBOARDMODE_X(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_X",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_BILLBOARDMODE_Y()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_Y"
                );
        }
        public static ValueTask set_BILLBOARDMODE_Y(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_Y",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_BILLBOARDMODE_Z()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_Z"
                );
        }
        public static ValueTask set_BILLBOARDMODE_Z(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_Z",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_BILLBOARDMODE_ALL()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_ALL"
                );
        }
        public static ValueTask set_BILLBOARDMODE_ALL(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_ALL",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_BILLBOARDMODE_USE_POSITION()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_USE_POSITION"
                );
        }
        public static ValueTask set_BILLBOARDMODE_USE_POSITION(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "TransformNode.BILLBOARDMODE_USE_POSITION",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<TransformNode> Parse(object parsedTransformNode, Scene scene, string rootUrl)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "TransformNode", "Parse" }, parsedTransformNode, scene, rootUrl
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_billboardMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "billboardMode"
                );
        }
        public ValueTask set_billboardMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "billboardMode",
                    value
                );
        }

        
        public async ValueTask<bool> get_preserveParentRotationForBillboard()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preserveParentRotationForBillboard"
                );
        }
        public ValueTask set_preserveParentRotationForBillboard(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preserveParentRotationForBillboard",
                    value
                );
        }

        
        public async ValueTask<bool> get_infiniteDistance()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "infiniteDistance"
                );
        }
        public ValueTask set_infiniteDistance(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "infiniteDistance",
                    value
                );
        }

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

        private Vector3 __rotation;
        public async ValueTask<Vector3> get_rotation()
        {
            if(__rotation == null)
            {
                __rotation = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_rotation(Vector3 value)
        {
__rotation = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotation",
                    value
                );
        }

        private Vector3 __scaling;
        public async ValueTask<Vector3> get_scaling()
        {
            if(__scaling == null)
            {
                __scaling = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_scaling(Vector3 value)
        {
__scaling = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scaling",
                    value
                );
        }

        private Quaternion __rotationQuaternion;
        public async ValueTask<Quaternion> get_rotationQuaternion()
        {
            if(__rotationQuaternion == null)
            {
                __rotationQuaternion = await EventHorizonBlazorInterop.GetClass<Quaternion>(
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
        public ValueTask set_rotationQuaternion(Quaternion value)
        {
__rotationQuaternion = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotationQuaternion",
                    value
                );
        }

        private Vector3 __forward;
        public async ValueTask<Vector3> get_forward()
        {
            if(__forward == null)
            {
                __forward = await EventHorizonBlazorInterop.GetClass<Vector3>(
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

        private Vector3 __up;
        public async ValueTask<Vector3> get_up()
        {
            if(__up == null)
            {
                __up = await EventHorizonBlazorInterop.GetClass<Vector3>(
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

        private Vector3 __right;
        public async ValueTask<Vector3> get_right()
        {
            if(__right == null)
            {
                __right = await EventHorizonBlazorInterop.GetClass<Vector3>(
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

        private Vector3 __absolutePosition;
        public async ValueTask<Vector3> get_absolutePosition()
        {
            if(__absolutePosition == null)
            {
                __absolutePosition = await EventHorizonBlazorInterop.GetClass<Vector3>(
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

        private Vector3 __absoluteScaling;
        public async ValueTask<Vector3> get_absoluteScaling()
        {
            if(__absoluteScaling == null)
            {
                __absoluteScaling = await EventHorizonBlazorInterop.GetClass<Vector3>(
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

        private Quaternion __absoluteRotationQuaternion;
        public async ValueTask<Quaternion> get_absoluteRotationQuaternion()
        {
            if(__absoluteRotationQuaternion == null)
            {
                __absoluteRotationQuaternion = await EventHorizonBlazorInterop.GetClass<Quaternion>(
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

        
        public async ValueTask<bool> get_isWorldMatrixFrozen()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isWorldMatrixFrozen"
                );
        }

        
        public async ValueTask<bool> get_nonUniformScaling()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "nonUniformScaling"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_scalingDeterminant()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "scalingDeterminant"
                );
        }
        public ValueTask set_scalingDeterminant(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scalingDeterminant",
                    value
                );
        }

        
        public async ValueTask<bool> get_ignoreNonUniformScaling()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreNonUniformScaling"
                );
        }
        public ValueTask set_ignoreNonUniformScaling(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignoreNonUniformScaling",
                    value
                );
        }

        
        public async ValueTask<bool> get_reIntegrateRotationIntoRotationQuaternion()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "reIntegrateRotationIntoRotationQuaternion"
                );
        }
        public ValueTask set_reIntegrateRotationIntoRotationQuaternion(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reIntegrateRotationIntoRotationQuaternion",
                    value
                );
        }

        private Observable<TransformNode> __onAfterWorldMatrixUpdateObservable;
        public async ValueTask<Observable<TransformNode>> get_onAfterWorldMatrixUpdateObservable()
        {
            if(__onAfterWorldMatrixUpdateObservable == null)
            {
                __onAfterWorldMatrixUpdateObservable = await EventHorizonBlazorInterop.GetClass<Observable<TransformNode>>(
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
        public ValueTask set_onAfterWorldMatrixUpdateObservable(Observable<TransformNode> value)
        {
__onAfterWorldMatrixUpdateObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterWorldMatrixUpdateObservable",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public TransformNode() : base() { }

        public TransformNode(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<TransformNode> NewTransformNode(
            string name, Scene scene = null, System.Nullable<bool> isPure = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "TransformNode" },
                name, scene, isPure
            );

            return new TransformNode(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<TransformNode> updatePoseMatrix(Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "updatePoseMatrix" }, matrix
                }
            );
        }

        public async ValueTask<Matrix> getPoseMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getPoseMatrix" }
                }
            );
        }

        public async ValueTask<TransformNode> markAsDirty(string property)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "markAsDirty" }, property
                }
            );
        }

        public async ValueTask<TransformNode> setPreTransformMatrix(Matrix matrix)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setPreTransformMatrix" }, matrix
                }
            );
        }

        public async ValueTask<TransformNode> setPivotMatrix(Matrix matrix, System.Nullable<bool> postMultiplyPivotMatrix = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setPivotMatrix" }, matrix, postMultiplyPivotMatrix
                }
            );
        }

        public async ValueTask<Matrix> getPivotMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getPivotMatrix" }
                }
            );
        }

        public async ValueTask<TransformNode> instantiateHierarchy(TransformNode newParent = null, object options = null, ActionCallback<TransformNode, TransformNode> onNewNodeCreated = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "instantiateHierarchy" }, newParent, options, onNewNodeCreated
                }
            );
        }

        public async ValueTask<TransformNode> freezeWorldMatrix(Matrix newWorldMatrix = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "freezeWorldMatrix" }, newWorldMatrix
                }
            );
        }

        public async ValueTask<TransformNode> unfreezeWorldMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "unfreezeWorldMatrix" }
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

        public async ValueTask<TransformNode> setAbsolutePosition(Vector3 absolutePosition)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setAbsolutePosition" }, absolutePosition
                }
            );
        }

        public async ValueTask<TransformNode> setPositionWithLocalVector(Vector3 vector3)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setPositionWithLocalVector" }, vector3
                }
            );
        }

        public async ValueTask<Vector3> getPositionExpressedInLocalSpace()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getPositionExpressedInLocalSpace" }
                }
            );
        }

        public async ValueTask<TransformNode> locallyTranslate(Vector3 vector3)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "locallyTranslate" }, vector3
                }
            );
        }

        public async ValueTask<TransformNode> lookAt(Vector3 targetPoint, System.Nullable<decimal> yawCor = null, System.Nullable<decimal> pitchCor = null, System.Nullable<decimal> rollCor = null, System.Nullable<int> space = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "lookAt" }, targetPoint, yawCor, pitchCor, rollCor, space
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

        public async ValueTask<TransformNode> getDirectionToRef(Vector3 localAxis, Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getDirectionToRef" }, localAxis, result
                }
            );
        }

        public async ValueTask<TransformNode> setDirection(Vector3 localAxis, System.Nullable<decimal> yawCor = null, System.Nullable<decimal> pitchCor = null, System.Nullable<decimal> rollCor = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setDirection" }, localAxis, yawCor, pitchCor, rollCor
                }
            );
        }

        public async ValueTask<TransformNode> setPivotPoint(Vector3 point, System.Nullable<int> space = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setPivotPoint" }, point, space
                }
            );
        }

        public async ValueTask<Vector3> getPivotPoint()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getPivotPoint" }
                }
            );
        }

        public async ValueTask<TransformNode> getPivotPointToRef(Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getPivotPointToRef" }, result
                }
            );
        }

        public async ValueTask<Vector3> getAbsolutePivotPoint()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAbsolutePivotPoint" }
                }
            );
        }

        public async ValueTask<TransformNode> getAbsolutePivotPointToRef(Vector3 result)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAbsolutePivotPointToRef" }, result
                }
            );
        }

        public async ValueTask<TransformNode> setParent(Node node)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setParent" }, node
                }
            );
        }

        public async ValueTask<TransformNode> attachToBone(Bone bone, TransformNode affectedTransformNode)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "attachToBone" }, bone, affectedTransformNode
                }
            );
        }

        public async ValueTask<TransformNode> detachFromBone()
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "detachFromBone" }
                }
            );
        }

        public async ValueTask<TransformNode> rotate(Vector3 axis, decimal amount, System.Nullable<int> space = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "rotate" }, axis, amount, space
                }
            );
        }

        public async ValueTask<TransformNode> rotateAround(Vector3 point, Vector3 axis, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "rotateAround" }, point, axis, amount
                }
            );
        }

        public async ValueTask<TransformNode> translate(Vector3 axis, decimal distance, System.Nullable<int> space = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "translate" }, axis, distance, space
                }
            );
        }

        public async ValueTask<TransformNode> addRotation(decimal x, decimal y, decimal z)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addRotation" }, x, y, z
                }
            );
        }

        public async ValueTask<Matrix> computeWorldMatrix(System.Nullable<bool> force = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "computeWorldMatrix" }, force
                }
            );
        }

        public async ValueTask resetLocalMatrix(System.Nullable<bool> independentOfChildren = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resetLocalMatrix" }, independentOfChildren
                }
            );
        }

        public async ValueTask<TransformNode> registerAfterWorldMatrixUpdate(ActionCallback<TransformNode> func)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "registerAfterWorldMatrixUpdate" }, func
                }
            );
        }

        public async ValueTask<TransformNode> unregisterAfterWorldMatrixUpdate(ActionCallback<TransformNode> func)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "unregisterAfterWorldMatrixUpdate" }, func
                }
            );
        }

        public async ValueTask<Vector3> getPositionInCameraSpace(Camera camera = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getPositionInCameraSpace" }, camera
                }
            );
        }

        public async ValueTask<decimal> getDistanceToCamera(Camera camera = null)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDistanceToCamera" }, camera
                }
            );
        }

        public async ValueTask<TransformNode> clone(string name, Node newParent, System.Nullable<bool> doNotCloneChildren = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newParent, doNotCloneChildren
                }
            );
        }

        public async ValueTask<CachedEntity> serialize(object currentSerializationObject = null)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, currentSerializationObject
                }
            );
        }

        public async ValueTask<TransformNode[]> getChildTransformNodes(System.Nullable<bool> directDescendantsOnly = null, ActionCallback<Node> predicate = null)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildTransformNodes" }, directDescendantsOnly, predicate
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

        public async ValueTask<TransformNode> normalizeToUnitCube(System.Nullable<bool> includeDescendants = null, System.Nullable<bool> ignoreRotation = null, ActionCallback<AbstractMesh> predicate = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
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