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

    public interface IShadowLight : ICachedEntity { }

    [JsonConverter(typeof(CachedEntityConverter<IShadowLightCachedEntity>))]
    public class IShadowLightCachedEntity : CachedEntityObject, IShadowLight
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

        public string id
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "id"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "id", value);
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

        private Vector3 __direction;
        public Vector3 direction
        {
            get
            {
                if (__direction == null)
                {
                    __direction = EventHorizonBlazorInterop.GetClass<Vector3>(
                        this.___guid,
                        "direction",
                        (entity) =>
                        {
                            return new Vector3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __direction;
            }
            set
            {
                __direction = null;
                EventHorizonBlazorInterop.Set(this.___guid, "direction", value);
            }
        }

        private Vector3 __transformedPosition;
        public Vector3 transformedPosition
        {
            get
            {
                if (__transformedPosition == null)
                {
                    __transformedPosition = EventHorizonBlazorInterop.GetClass<Vector3>(
                        this.___guid,
                        "transformedPosition",
                        (entity) =>
                        {
                            return new Vector3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __transformedPosition;
            }
            set
            {
                __transformedPosition = null;
                EventHorizonBlazorInterop.Set(this.___guid, "transformedPosition", value);
            }
        }

        private Vector3 __transformedDirection;
        public Vector3 transformedDirection
        {
            get
            {
                if (__transformedDirection == null)
                {
                    __transformedDirection = EventHorizonBlazorInterop.GetClass<Vector3>(
                        this.___guid,
                        "transformedDirection",
                        (entity) =>
                        {
                            return new Vector3() { ___guid = entity.___guid };
                        }
                    );
                }
                return __transformedDirection;
            }
            set
            {
                __transformedDirection = null;
                EventHorizonBlazorInterop.Set(this.___guid, "transformedDirection", value);
            }
        }

        public string name
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
            }
        }

        public decimal shadowMinZ
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowMinZ"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shadowMinZ", value);
            }
        }

        public decimal shadowMaxZ
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "shadowMaxZ"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "shadowMaxZ", value);
            }
        }
        #endregion

        #region Constructor
        public IShadowLightCachedEntity()
            : base() { }

        public IShadowLightCachedEntity(ICachedEntity entity)
            : base(entity) { }

        #endregion

        #region Methods
        public bool computeTransformedInformation()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "computeTransformedInformation" } }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getScene" } }
            );
        }

        #region customProjectionMatrixBuilder TODO: Get Comments as metadata identification
        private bool _isCustomProjectionMatrixBuilderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customProjectionMatrixBuilderActionMap =
            new Dictionary<string, Func<Task>>();

        public string customProjectionMatrixBuilder(Func<Task> callback)
        {
            SetupCustomProjectionMatrixBuilderLoop();

            var handle = Guid.NewGuid().ToString();
            _customProjectionMatrixBuilderActionMap.Add(handle, callback);

            return handle;
        }

        public bool customProjectionMatrixBuilder_Remove(string handle)
        {
            return _customProjectionMatrixBuilderActionMap.Remove(handle);
        }

        private void SetupCustomProjectionMatrixBuilderLoop()
        {
            if (_isCustomProjectionMatrixBuilderEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "customProjectionMatrixBuilder",
                "CallCustomProjectionMatrixBuilderActions",
                _invokableReference
            );
            _isCustomProjectionMatrixBuilderEnabled = true;
        }

        [JSInvokable]
        public async Task CallCustomProjectionMatrixBuilderActions()
        {
            foreach (var action in _customProjectionMatrixBuilderActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public IShadowLightCachedEntity setShadowProjectionMatrix(
            Matrix matrix,
            Matrix viewMatrix,
            AbstractMesh[] renderList
        )
        {
            return EventHorizonBlazorInterop.FuncClass<IShadowLightCachedEntity>(
                entity => new IShadowLightCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setShadowProjectionMatrix" },
                    matrix,
                    viewMatrix,
                    renderList
                }
            );
        }

        public decimal getDepthScale()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getDepthScale" } }
            );
        }

        public bool needCube()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "needCube" } }
            );
        }

        public bool needProjectionMatrixCompute()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] { new string[] { this.___guid, "needProjectionMatrixCompute" } }
            );
        }

        public void forceProjectionMatrixCompute()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "forceProjectionMatrixCompute" } }
            );
        }

        public Vector3 getShadowDirection(System.Nullable<decimal> faceIndex = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getShadowDirection" }, faceIndex }
            );
        }

        public decimal getDepthMinZ(Camera activeCamera)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getDepthMinZ" }, activeCamera }
            );
        }

        public decimal getDepthMaxZ(Camera activeCamera)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] { new string[] { this.___guid, "getDepthMaxZ" }, activeCamera }
            );
        }
        #endregion
    }
}
