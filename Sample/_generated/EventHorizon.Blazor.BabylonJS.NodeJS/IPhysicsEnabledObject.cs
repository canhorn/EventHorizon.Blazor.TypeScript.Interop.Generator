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

        public CachedEntity parent
        {
            get
            {
                return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "parent",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "parent", value);
            }
        }
        #endregion

        #region Constructor
        public IPhysicsEnabledObjectCachedEntity()
            : base() { }

        public IPhysicsEnabledObjectCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public BoundingInfo getBoundingInfo()
        {
            return EventHorizonBlazorInterop.FuncClass<BoundingInfo>(
                entity => new BoundingInfo() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getBoundingInfo" } }
            );
        }

        public Matrix computeWorldMatrix(bool force)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "computeWorldMatrix" }, force }
            );
        }

        public Matrix getWorldMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getWorldMatrix" } }
            );
        }

        public AbstractMesh[] getChildMeshes(System.Nullable<bool> directDescendantsOnly = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AbstractMesh>(
                entity => new AbstractMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildMeshes" },
                    directDescendantsOnly
                }
            );
        }

        public decimal[] getVerticesData(string kind)
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { this.___guid, "getVerticesData" }, kind }
            );
        }

        public decimal[] getIndices()
        {
            return EventHorizonBlazorInterop.FuncArray<decimal>(
                new object[] { new string[] { this.___guid, "getIndices" } }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getScene" } }
            );
        }

        public Vector3 getAbsolutePosition()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAbsolutePosition" } }
            );
        }

        public Vector3 getAbsolutePivotPoint()
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getAbsolutePivotPoint" } }
            );
        }

        public TransformNode rotate(Vector3 axis, decimal amount, System.Nullable<int> space = null)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "rotate" }, axis, amount, space }
            );
        }

        public TransformNode translate(
            Vector3 axis,
            decimal distance,
            System.Nullable<int> space = null
        )
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "translate" }, axis, distance, space }
            );
        }

        public TransformNode setAbsolutePosition(Vector3 absolutePosition)
        {
            return EventHorizonBlazorInterop.FuncClass<TransformNode>(
                entity => new TransformNode() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAbsolutePosition" },
                    absolutePosition
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] { new string[] { this.___guid, "getClassName" } }
            );
        }
        #endregion
    }
}
