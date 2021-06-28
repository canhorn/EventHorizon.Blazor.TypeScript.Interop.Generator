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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Bone>))]
    public class Bone : Node
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

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
        }
        #endregion

        #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public Bone[] children
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Bone>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new Bone() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "children",
                    value
                );
            }
        }

        
        public Animation[] animations
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
            }
        }

        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "length",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Bone() : base() { }

        public Bone(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Bone(
            string name, Skeleton skeleton, Bone parentBone = null, Matrix localMatrix = null, Matrix restPose = null, Matrix baseMatrix = null, System.Nullable<decimal> index = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Bone" },
                name, skeleton, parentBone, localMatrix, restPose, baseMatrix, index
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

        public Skeleton getSkeleton()
        {
            return EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSkeleton" }
                }
            );
        }

        public Bone getParent()
        {
            return EventHorizonBlazorInterop.FuncClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getParent" }
                }
            );
        }

        public Bone[] getChildren()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildren" }
                }
            );
        }

        public decimal getIndex()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndex" }
                }
            );
        }

        public void setParent(Bone parent, System.Nullable<bool> updateDifferenceMatrix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setParent" }, parent, updateDifferenceMatrix
                }
            );
        }

        public Matrix getLocalMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalMatrix" }
                }
            );
        }

        public Matrix getBaseMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBaseMatrix" }
                }
            );
        }

        public Matrix getRestPose()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRestPose" }
                }
            );
        }

        public void setRestPose(Matrix matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRestPose" }, matrix
                }
            );
        }

        public Matrix getBindPose()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBindPose" }
                }
            );
        }

        public void setBindPose(Matrix matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setBindPose" }, matrix
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

        public void returnToRest()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "returnToRest" }
                }
            );
        }

        public Matrix getInvertedAbsoluteTransform()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getInvertedAbsoluteTransform" }
                }
            );
        }

        public Matrix getAbsoluteTransform()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAbsoluteTransform" }
                }
            );
        }

        public void linkTransformNode(TransformNode transformNode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "linkTransformNode" }, transformNode
                }
            );
        }

        public TransformNode getTransformNode()
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTransformNode" }
                }
            );
        }

        public void updateMatrix(Matrix matrix, System.Nullable<bool> updateDifferenceMatrix = null, System.Nullable<bool> updateLocalMatrix = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateMatrix" }, matrix, updateDifferenceMatrix, updateLocalMatrix
                }
            );
        }

        public void markAsDirty()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "markAsDirty" }
                }
            );
        }

        public void translate(Vector3 vec, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "translate" }, vec, space, mesh
                }
            );
        }

        public void setPosition(Vector3 position, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPosition" }, position, space, mesh
                }
            );
        }

        public void setAbsolutePosition(Vector3 position, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAbsolutePosition" }, position, mesh
                }
            );
        }

        public void scale(decimal x, decimal y, decimal z, System.Nullable<bool> scaleChildren = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "scale" }, x, y, z, scaleChildren
                }
            );
        }

        public void setScale(Vector3 scale)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setScale" }, scale
                }
            );
        }

        public Vector3 getScale()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getScale" }
                }
            );
        }

        public void getScaleToRef(Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getScaleToRef" }, result
                }
            );
        }

        public void setYawPitchRoll(decimal yaw, decimal pitch, decimal roll, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setYawPitchRoll" }, yaw, pitch, roll, space, mesh
                }
            );
        }

        public void rotate(Vector3 axis, decimal amount, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "rotate" }, axis, amount, space, mesh
                }
            );
        }

        public void setAxisAngle(Vector3 axis, decimal angle, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisAngle" }, axis, angle, space, mesh
                }
            );
        }

        public void setRotation(Vector3 rotation, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRotation" }, rotation, space, mesh
                }
            );
        }

        public void setRotationQuaternion(Quaternion quat, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRotationQuaternion" }, quat, space, mesh
                }
            );
        }

        public void setRotationMatrix(Matrix rotMat, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRotationMatrix" }, rotMat, space, mesh
                }
            );
        }

        public Vector3 getPosition(System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPosition" }, space, mesh
                }
            );
        }

        public void getPositionToRef(AbstractMesh mesh, Vector3 result, System.Nullable<int> space = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getPositionToRef" }, space, mesh, result
                }
            );
        }

        public Vector3 getAbsolutePosition(AbstractMesh mesh = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAbsolutePosition" }, mesh
                }
            );
        }

        public void getAbsolutePositionToRef(AbstractMesh mesh, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAbsolutePositionToRef" }, mesh, result
                }
            );
        }

        public void computeAbsoluteTransforms()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "computeAbsoluteTransforms" }
                }
            );
        }

        public Vector3 getDirection(Vector3 localAxis, AbstractMesh mesh = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDirection" }, localAxis, mesh
                }
            );
        }

        public void getDirectionToRef(Vector3 localAxis, Vector3 result, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getDirectionToRef" }, localAxis, mesh, result
                }
            );
        }

        public Vector3 getRotation(System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRotation" }, space, mesh
                }
            );
        }

        public void getRotationToRef(Vector3 result, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getRotationToRef" }, space, mesh, result
                }
            );
        }

        public Quaternion getRotationQuaternion(System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRotationQuaternion" }, space, mesh
                }
            );
        }

        public void getRotationQuaternionToRef(Quaternion result, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getRotationQuaternionToRef" }, space, mesh, result
                }
            );
        }

        public Matrix getRotationMatrix(AbstractMesh mesh, System.Nullable<int> space = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRotationMatrix" }, space, mesh
                }
            );
        }

        public void getRotationMatrixToRef(AbstractMesh mesh, Matrix result, System.Nullable<int> space = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getRotationMatrixToRef" }, space, mesh, result
                }
            );
        }

        public Vector3 getAbsolutePositionFromLocal(Vector3 position, AbstractMesh mesh = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAbsolutePositionFromLocal" }, position, mesh
                }
            );
        }

        public void getAbsolutePositionFromLocalToRef(Vector3 position, Vector3 result, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAbsolutePositionFromLocalToRef" }, position, mesh, result
                }
            );
        }

        public Vector3 getLocalPositionFromAbsolute(Vector3 position, AbstractMesh mesh = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalPositionFromAbsolute" }, position, mesh
                }
            );
        }

        public void getLocalPositionFromAbsoluteToRef(Vector3 position, Vector3 result, AbstractMesh mesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getLocalPositionFromAbsoluteToRef" }, position, mesh, result
                }
            );
        }

        public void setCurrentPoseAsRest()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCurrentPoseAsRest" }
                }
            );
        }
        #endregion
    }
}