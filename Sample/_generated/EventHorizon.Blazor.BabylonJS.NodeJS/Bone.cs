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
        private Bone __parent;
        public Bone parent
        {
            get
            {
                if (__parent == null)
                {
                    __parent = EventHorizonBlazorInterop.GetClass<Bone>(
                        this.___guid,
                        "parent",
                        (entity) =>
                        {
                            return new Bone() { ___guid = entity.___guid };
                        }
                    );
                }
                return __parent;
            }
            set
            {
                __parent = null;
                EventHorizonBlazorInterop.Set(this.___guid, "parent", value);
            }
        }

        private Vector3 __position;
        public Vector3 position
        {
            get
            {
                if (__position == null)
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
                EventHorizonBlazorInterop.Set(this.___guid, "position", value);
            }
        }

        private Vector3 __rotation;
        public Vector3 rotation
        {
            get
            {
                if (__rotation == null)
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
                EventHorizonBlazorInterop.Set(this.___guid, "rotation", value);
            }
        }

        private Quaternion __rotationQuaternion;
        public Quaternion rotationQuaternion
        {
            get
            {
                if (__rotationQuaternion == null)
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
                EventHorizonBlazorInterop.Set(this.___guid, "rotationQuaternion", value);
            }
        }

        private Vector3 __scaling;
        public Vector3 scaling
        {
            get
            {
                if (__scaling == null)
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
                EventHorizonBlazorInterop.Set(this.___guid, "scaling", value);
            }
        }

        private AnimationPropertiesOverride __animationPropertiesOverride;
        public AnimationPropertiesOverride animationPropertiesOverride
        {
            get
            {
                if (__animationPropertiesOverride == null)
                {
                    __animationPropertiesOverride =
                        EventHorizonBlazorInterop.GetClass<AnimationPropertiesOverride>(
                            this.___guid,
                            "animationPropertiesOverride",
                            (entity) =>
                            {
                                return new AnimationPropertiesOverride()
                                {
                                    ___guid = entity.___guid
                                };
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
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
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

                EventHorizonBlazorInterop.Set(this.___guid, "children", value);
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

                EventHorizonBlazorInterop.Set(this.___guid, "animations", value);
            }
        }

        public decimal length
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "length"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "length", value);
            }
        }
        #endregion

        #region Constructor
        public Bone()
            : base() { }

        public Bone(ICachedEntity entity)
            : base(entity) { }

        public Bone(
            string name,
            Skeleton skeleton,
            Bone parentBone = null,
            Matrix localMatrix = null,
            Matrix restMatrix = null,
            Matrix bindMatrix = null,
            System.Nullable<decimal> index = null
        )
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Bone" },
                name,
                skeleton,
                parentBone,
                localMatrix,
                restMatrix,
                bindMatrix,
                index
            );
            ___guid = entity.___guid;
        }

        public Bone(string name, Scene scene = null, System.Nullable<bool> isPure = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Bone" },
                name,
                scene,
                isPure
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }

        public Skeleton getSkeleton()
        {
            return EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getSkeleton" } }
            );
        }

        public Bone getParent()
        {
            return EventHorizonBlazorInterop.FuncClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getParent" } }
            );
        }

        public Bone[] getChildren()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getChildren" } }
            );
        }

        public decimal getIndex()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getIndex" } }
            );
        }

        public void setParent(Bone parent, System.Nullable<bool> updateAbsoluteBindMatrices = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setParent" },
                    parent,
                    updateAbsoluteBindMatrices
                }
            );
        }

        public Matrix getLocalMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getLocalMatrix" } }
            );
        }

        public Matrix getBindMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBindMatrix" } }
            );
        }

        public Matrix getBaseMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBaseMatrix" } }
            );
        }

        public Matrix getRestMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRestMatrix" } }
            );
        }

        public Matrix getRestPose()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRestPose" } }
            );
        }

        public void setRestMatrix(Matrix matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setRestMatrix" }, matrix }
            );
        }

        public void setRestPose(Matrix matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setRestPose" }, matrix }
            );
        }

        public Matrix getBindPose()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBindPose" } }
            );
        }

        public void setBindMatrix(Matrix matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setBindMatrix" }, matrix }
            );
        }

        public void setBindPose(Matrix matrix)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setBindPose" }, matrix }
            );
        }

        public Matrix getFinalMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getFinalMatrix" } }
            );
        }

        public Matrix getWorldMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getWorldMatrix" } }
            );
        }

        public void returnToRest()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "returnToRest" } }
            );
        }

        public Matrix getAbsoluteInverseBindMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAbsoluteInverseBindMatrix" } }
            );
        }

        public Matrix getInvertedAbsoluteTransform()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getInvertedAbsoluteTransform" } }
            );
        }

        public Matrix getAbsoluteMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAbsoluteMatrix" } }
            );
        }

        public Matrix getAbsoluteTransform()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAbsoluteTransform" } }
            );
        }

        public void linkTransformNode(TransformNode transformNode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "linkTransformNode" }, transformNode }
            );
        }

        public TransformNode getTransformNode()
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getTransformNode" } }
            );
        }

        public void updateMatrix(
            Matrix bindMatrix,
            System.Nullable<bool> updateAbsoluteBindMatrices = null,
            System.Nullable<bool> updateLocalMatrix = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateMatrix" },
                    bindMatrix,
                    updateAbsoluteBindMatrices,
                    updateLocalMatrix
                }
            );
        }

        public Bone markAsDirty()
        {
            return EventHorizonBlazorInterop.FuncClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "markAsDirty" } }
            );
        }

        public void translate(
            Vector3 vec,
            System.Nullable<int> space = null,
            TransformNode tNode = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "translate" }, vec, space, tNode }
            );
        }

        public void setPosition(
            Vector3 position,
            System.Nullable<int> space = null,
            TransformNode tNode = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setPosition" },
                    position,
                    space,
                    tNode
                }
            );
        }

        public void setAbsolutePosition(Vector3 position, TransformNode tNode = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAbsolutePosition" },
                    position,
                    tNode
                }
            );
        }

        public void scale(
            decimal x,
            decimal y,
            decimal z,
            System.Nullable<bool> scaleChildren = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "scale" }, x, y, z, scaleChildren }
            );
        }

        public void setScale(Vector3 scale)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setScale" }, scale }
            );
        }

        public Vector3 getScale()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getScale" } }
            );
        }

        public void getScaleToRef(Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "getScaleToRef" }, result }
            );
        }

        public void setYawPitchRoll(
            decimal yaw,
            decimal pitch,
            decimal roll,
            System.Nullable<int> space = null,
            TransformNode tNode = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setYawPitchRoll" },
                    yaw,
                    pitch,
                    roll,
                    space,
                    tNode
                }
            );
        }

        public void rotate(
            Vector3 axis,
            decimal amount,
            System.Nullable<int> space = null,
            TransformNode tNode = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "rotate" }, axis, amount, space, tNode }
            );
        }

        public void setAxisAngle(
            Vector3 axis,
            decimal angle,
            System.Nullable<int> space = null,
            TransformNode tNode = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setAxisAngle" },
                    axis,
                    angle,
                    space,
                    tNode
                }
            );
        }

        public void setRotation(
            Vector3 rotation,
            System.Nullable<int> space = null,
            TransformNode tNode = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRotation" },
                    rotation,
                    space,
                    tNode
                }
            );
        }

        public void setRotationQuaternion(
            Quaternion quat,
            System.Nullable<int> space = null,
            TransformNode tNode = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRotationQuaternion" },
                    quat,
                    space,
                    tNode
                }
            );
        }

        public void setRotationMatrix(
            Matrix rotMat,
            System.Nullable<int> space = null,
            TransformNode tNode = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setRotationMatrix" },
                    rotMat,
                    space,
                    tNode
                }
            );
        }

        public Vector3 getPosition(System.Nullable<int> space = null, TransformNode tNode = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getPosition" }, space, tNode }
            );
        }

        public void getPositionToRef(
            TransformNode tNode,
            Vector3 result,
            System.Nullable<int> space = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getPositionToRef" },
                    space,
                    tNode,
                    result
                }
            );
        }

        public Vector3 getAbsolutePosition(TransformNode tNode = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAbsolutePosition" }, tNode }
            );
        }

        public void getAbsolutePositionToRef(TransformNode tNode, Vector3 result)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAbsolutePositionToRef" },
                    tNode,
                    result
                }
            );
        }

        public void computeAbsoluteMatrices()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "computeAbsoluteMatrices" } }
            );
        }

        public void computeAbsoluteTransforms()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "computeAbsoluteTransforms" } }
            );
        }

        public Vector3 getDirection(Vector3 localAxis, TransformNode tNode = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getDirection" }, localAxis, tNode }
            );
        }

        public void getDirectionToRef(Vector3 localAxis, Vector3 result, TransformNode tNode = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getDirectionToRef" },
                    localAxis,
                    tNode,
                    result
                }
            );
        }

        public Vector3 getRotation(System.Nullable<int> space = null, TransformNode tNode = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRotation" }, space, tNode }
            );
        }

        public void getRotationToRef(
            Vector3 result,
            System.Nullable<int> space = null,
            TransformNode tNode = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getRotationToRef" },
                    space,
                    tNode,
                    result
                }
            );
        }

        public Quaternion getRotationQuaternion(
            System.Nullable<int> space = null,
            TransformNode tNode = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRotationQuaternion" },
                    space,
                    tNode
                }
            );
        }

        public void getRotationQuaternionToRef(
            Quaternion result,
            System.Nullable<int> space = null,
            TransformNode tNode = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getRotationQuaternionToRef" },
                    space,
                    tNode,
                    result
                }
            );
        }

        public Matrix getRotationMatrix(TransformNode tNode, System.Nullable<int> space = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getRotationMatrix" }, space, tNode }
            );
        }

        public void getRotationMatrixToRef(
            TransformNode tNode,
            Matrix result,
            System.Nullable<int> space = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getRotationMatrixToRef" },
                    space,
                    tNode,
                    result
                }
            );
        }

        public Vector3 getAbsolutePositionFromLocal(Vector3 position, TransformNode tNode = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAbsolutePositionFromLocal" },
                    position,
                    tNode
                }
            );
        }

        public void getAbsolutePositionFromLocalToRef(
            Vector3 position,
            Vector3 result,
            TransformNode tNode = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getAbsolutePositionFromLocalToRef" },
                    position,
                    tNode,
                    result
                }
            );
        }

        public Vector3 getLocalPositionFromAbsolute(Vector3 position, TransformNode tNode = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLocalPositionFromAbsolute" },
                    position,
                    tNode
                }
            );
        }

        public void getLocalPositionFromAbsoluteToRef(
            Vector3 position,
            Vector3 result,
            TransformNode tNode = null
        )
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getLocalPositionFromAbsoluteToRef" },
                    position,
                    tNode,
                    result
                }
            );
        }

        public void setCurrentPoseAsRest()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "setCurrentPoseAsRest" } }
            );
        }
        #endregion
    }
}
