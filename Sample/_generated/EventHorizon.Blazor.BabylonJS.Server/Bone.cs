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
        #endregion

        #region Properties
        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        
        public async ValueTask<Bone[]> get_children()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Bone>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new Bone() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_children(Bone[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "children",
                    value
                );
        }

        
        public async ValueTask<Animation[]> get_animations()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_animations(Animation[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
        }

        
        public async ValueTask<decimal> get_length()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
        }
        public ValueTask set_length(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "length",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Bone() : base() { }

        public Bone(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Bone> NewBone(
            string name, Skeleton skeleton, Bone parentBone = null, Matrix localMatrix = null, Matrix restPose = null, Matrix baseMatrix = null, System.Nullable<decimal> index = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Bone" },
                name, skeleton, parentBone, localMatrix, restPose, baseMatrix, index
            );

            return new Bone(entity);
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

        public async ValueTask<Skeleton> getSkeleton()
        {
            return await EventHorizonBlazorInterop.FuncClass<Skeleton>(
                entity => new Skeleton() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getSkeleton" }
                }
            );
        }

        public async ValueTask<Bone> getParent()
        {
            return await EventHorizonBlazorInterop.FuncClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getParent" }
                }
            );
        }

        public async ValueTask<Bone[]> getChildren()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Bone>(
                entity => new Bone() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildren" }
                }
            );
        }

        public async ValueTask<decimal> getIndex()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getIndex" }
                }
            );
        }

        public async ValueTask setParent(Bone parent, System.Nullable<bool> updateDifferenceMatrix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setParent" }, parent, updateDifferenceMatrix
                }
            );
        }

        public async ValueTask<Matrix> getLocalMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLocalMatrix" }
                }
            );
        }

        public async ValueTask<Matrix> getBaseMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getBaseMatrix" }
                }
            );
        }

        public async ValueTask<Matrix> getRestPose()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRestPose" }
                }
            );
        }

        public async ValueTask setRestPose(Matrix matrix)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRestPose" }, matrix
                }
            );
        }

        public async ValueTask<Matrix> getBindPose()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getBindPose" }
                }
            );
        }

        public async ValueTask setBindPose(Matrix matrix)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setBindPose" }, matrix
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

        public async ValueTask returnToRest()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "returnToRest" }
                }
            );
        }

        public async ValueTask<Matrix> getInvertedAbsoluteTransform()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getInvertedAbsoluteTransform" }
                }
            );
        }

        public async ValueTask<Matrix> getAbsoluteTransform()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAbsoluteTransform" }
                }
            );
        }

        public async ValueTask linkTransformNode(TransformNode transformNode)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "linkTransformNode" }, transformNode
                }
            );
        }

        public async ValueTask<TransformNode> getTransformNode()
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTransformNode" }
                }
            );
        }

        public async ValueTask updateMatrix(Matrix matrix, System.Nullable<bool> updateDifferenceMatrix = null, System.Nullable<bool> updateLocalMatrix = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateMatrix" }, matrix, updateDifferenceMatrix, updateLocalMatrix
                }
            );
        }

        public async ValueTask markAsDirty()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "markAsDirty" }
                }
            );
        }

        public async ValueTask translate(Vector3 vec, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "translate" }, vec, space, mesh
                }
            );
        }

        public async ValueTask setPosition(Vector3 position, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setPosition" }, position, space, mesh
                }
            );
        }

        public async ValueTask setAbsolutePosition(Vector3 position, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setAbsolutePosition" }, position, mesh
                }
            );
        }

        public async ValueTask scale(decimal x, decimal y, decimal z, System.Nullable<bool> scaleChildren = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, x, y, z, scaleChildren
                }
            );
        }

        public async ValueTask setScale(Vector3 scale)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setScale" }, scale
                }
            );
        }

        public async ValueTask<Vector3> getScale()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getScale" }
                }
            );
        }

        public async ValueTask getScaleToRef(Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getScaleToRef" }, result
                }
            );
        }

        public async ValueTask setYawPitchRoll(decimal yaw, decimal pitch, decimal roll, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setYawPitchRoll" }, yaw, pitch, roll, space, mesh
                }
            );
        }

        public async ValueTask rotate(Vector3 axis, decimal amount, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "rotate" }, axis, amount, space, mesh
                }
            );
        }

        public async ValueTask setAxisAngle(Vector3 axis, decimal angle, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setAxisAngle" }, axis, angle, space, mesh
                }
            );
        }

        public async ValueTask setRotation(Vector3 rotation, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRotation" }, rotation, space, mesh
                }
            );
        }

        public async ValueTask setRotationQuaternion(Quaternion quat, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRotationQuaternion" }, quat, space, mesh
                }
            );
        }

        public async ValueTask setRotationMatrix(Matrix rotMat, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setRotationMatrix" }, rotMat, space, mesh
                }
            );
        }

        public async ValueTask<Vector3> getPosition(System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getPosition" }, space, mesh
                }
            );
        }

        public async ValueTask getPositionToRef(AbstractMesh mesh, Vector3 result, System.Nullable<int> space = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getPositionToRef" }, space, mesh, result
                }
            );
        }

        public async ValueTask<Vector3> getAbsolutePosition(AbstractMesh mesh = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAbsolutePosition" }, mesh
                }
            );
        }

        public async ValueTask getAbsolutePositionToRef(AbstractMesh mesh, Vector3 result)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getAbsolutePositionToRef" }, mesh, result
                }
            );
        }

        public async ValueTask computeAbsoluteTransforms()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "computeAbsoluteTransforms" }
                }
            );
        }

        public async ValueTask<Vector3> getDirection(Vector3 localAxis, AbstractMesh mesh = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getDirection" }, localAxis, mesh
                }
            );
        }

        public async ValueTask getDirectionToRef(Vector3 localAxis, Vector3 result, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getDirectionToRef" }, localAxis, mesh, result
                }
            );
        }

        public async ValueTask<Vector3> getRotation(System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRotation" }, space, mesh
                }
            );
        }

        public async ValueTask getRotationToRef(Vector3 result, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getRotationToRef" }, space, mesh, result
                }
            );
        }

        public async ValueTask<Quaternion> getRotationQuaternion(System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRotationQuaternion" }, space, mesh
                }
            );
        }

        public async ValueTask getRotationQuaternionToRef(Quaternion result, System.Nullable<int> space = null, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getRotationQuaternionToRef" }, space, mesh, result
                }
            );
        }

        public async ValueTask<Matrix> getRotationMatrix(AbstractMesh mesh, System.Nullable<int> space = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRotationMatrix" }, space, mesh
                }
            );
        }

        public async ValueTask getRotationMatrixToRef(AbstractMesh mesh, Matrix result, System.Nullable<int> space = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getRotationMatrixToRef" }, space, mesh, result
                }
            );
        }

        public async ValueTask<Vector3> getAbsolutePositionFromLocal(Vector3 position, AbstractMesh mesh = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAbsolutePositionFromLocal" }, position, mesh
                }
            );
        }

        public async ValueTask getAbsolutePositionFromLocalToRef(Vector3 position, Vector3 result, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getAbsolutePositionFromLocalToRef" }, position, mesh, result
                }
            );
        }

        public async ValueTask<Vector3> getLocalPositionFromAbsolute(Vector3 position, AbstractMesh mesh = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getLocalPositionFromAbsolute" }, position, mesh
                }
            );
        }

        public async ValueTask getLocalPositionFromAbsoluteToRef(Vector3 position, Vector3 result, AbstractMesh mesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getLocalPositionFromAbsoluteToRef" }, position, mesh, result
                }
            );
        }

        public async ValueTask setCurrentPoseAsRest()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setCurrentPoseAsRest" }
                }
            );
        }
        #endregion
    }
}