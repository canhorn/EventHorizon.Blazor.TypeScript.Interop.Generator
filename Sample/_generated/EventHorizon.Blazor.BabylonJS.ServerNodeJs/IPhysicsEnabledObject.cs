/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    public interface IPhysicsEnabledObject : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IPhysicsEnabledObjectCachedEntity>))]
    public class IPhysicsEnabledObjectCachedEntity : CachedEntityObject, IPhysicsEnabledObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        private Vector3 __position;

        public async ValueTask<Vector3> get_position()
        {
            if (__position == null)
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
            return EventHorizonBlazorInterop.Set(this.___guid, "position", value);
        }

        private Quaternion __rotationQuaternion;

        public async ValueTask<Quaternion> get_rotationQuaternion()
        {
            if (__rotationQuaternion == null)
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
            return EventHorizonBlazorInterop.Set(this.___guid, "rotationQuaternion", value);
        }

        private Vector3 __scaling;

        public async ValueTask<Vector3> get_scaling()
        {
            if (__scaling == null)
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
            return EventHorizonBlazorInterop.Set(this.___guid, "scaling", value);
        }

        private Vector3 __rotation;

        public async ValueTask<Vector3> get_rotation()
        {
            if (__rotation == null)
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
            return EventHorizonBlazorInterop.Set(this.___guid, "rotation", value);
        }

        public async ValueTask<CachedEntity> get_parent()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                this.___guid,
                "parent",
                (entity) =>
                {
                    return new CachedEntity() { ___guid = entity.___guid };
                }
            );
        }

        public ValueTask set_parent(CachedEntity value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "parent", value);
        }
        #endregion

        #region Constructor
        public IPhysicsEnabledObjectCachedEntity()
            : base() { }

        public IPhysicsEnabledObjectCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public async ValueTask<BoundingInfo> getBoundingInfo()
        {
            return await EventHorizonBlazorInterop.FuncClass<BoundingInfo>(
                entity => new BoundingInfo() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBoundingInfo" } }
            );
        }

        public async ValueTask<Matrix> computeWorldMatrix(bool force)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "computeWorldMatrix" }, force }
            );
        }

        public async ValueTask<Matrix> getWorldMatrix()
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getWorldMatrix" } }
            );
        }

        public async ValueTask<AbstractMesh[]> getChildMeshes(
            System.Nullable<bool> directDescendantsOnly = null
        )
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildMeshes" },
                    directDescendantsOnly
                }
            );
        }

        public async ValueTask<decimal[]> getVerticesData(string kind)
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { this.___guid, "getVerticesData" }, kind }
            );
        }

        public async ValueTask<decimal[]> getIndices()
        {
            return await EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { this.___guid, "getIndices" } }
            );
        }

        public async ValueTask<Scene> getScene()
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getScene" } }
            );
        }

        public async ValueTask<Vector3> getAbsolutePosition()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAbsolutePosition" } }
            );
        }

        public async ValueTask<Vector3> getAbsolutePivotPoint()
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAbsolutePivotPoint" } }
            );
        }

        public async ValueTask<TransformNode> rotate(
            Vector3 axis,
            decimal amount,
            System.Nullable<int> space = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "rotate" }, axis, amount, space }
            );
        }

        public async ValueTask<TransformNode> translate(
            Vector3 axis,
            decimal distance,
            System.Nullable<int> space = null
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "translate" }, axis, distance, space }
            );
        }

        public async ValueTask<TransformNode> setAbsolutePosition(Vector3 absolutePosition)
        {
            return await EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAbsolutePosition" },
                    absolutePosition
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }
        #endregion
    }
}
