/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IShadowLight : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "id",
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
                        return new Vector3() { ___guid = entity.___guid };
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

        private Vector3 __direction;
        public Vector3 direction
        {
            get
            {
            if(__direction == null)
            {
                __direction = EventHorizonBlazorInteropt.GetClass<Vector3>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "direction",
                    value
                );
            }
        }

        private Vector3 __transformedPosition;
        public Vector3 transformedPosition
        {
            get
            {
            if(__transformedPosition == null)
            {
                __transformedPosition = EventHorizonBlazorInteropt.GetClass<Vector3>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "transformedPosition",
                    value
                );
            }
        }

        private Vector3 __transformedDirection;
        public Vector3 transformedDirection
        {
            get
            {
            if(__transformedDirection == null)
            {
                __transformedDirection = EventHorizonBlazorInteropt.GetClass<Vector3>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "transformedDirection",
                    value
                );
            }
        }

        
        public string name
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        
        public decimal shadowMinZ
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "shadowMinZ"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "shadowMinZ",
                    value
                );
            }
        }

        
        public decimal shadowMaxZ
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "shadowMaxZ"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "shadowMaxZ",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IShadowLightCachedEntity() : base() { }

        public IShadowLightCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public bool computeTransformedInformation()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "computeTransformedInformation" }
                }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        #region customProjectionMatrixBuilder TODO: Get Comments as metadata identification
        private bool _isCustomProjectionMatrixBuilderEnabled = false;
        private readonly IDictionary<string, Func<Task>> _customProjectionMatrixBuilderActionMap = new Dictionary<string, Func<Task>>();

        public string customProjectionMatrixBuilder(
            Func<Task> callback
        )
        {
            SetupCustomProjectionMatrixBuilderLoop();

            var handle = Guid.NewGuid().ToString();
            _customProjectionMatrixBuilderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupCustomProjectionMatrixBuilderLoop()
        {
            if (_isCustomProjectionMatrixBuilderEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
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

        public IShadowLightCachedEntity setShadowProjectionMatrix(Matrix matrix, Matrix viewMatrix, AbstractMesh[] renderList)
        {
            return EventHorizonBlazorInteropt.FuncClass<IShadowLightCachedEntity>(
                entity => new IShadowLightCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setShadowProjectionMatrix" }, matrix, viewMatrix, renderList
                }
            );
        }

        public decimal getDepthScale()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDepthScale" }
                }
            );
        }

        public bool needCube()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needCube" }
                }
            );
        }

        public bool needProjectionMatrixCompute()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needProjectionMatrixCompute" }
                }
            );
        }

        public void forceProjectionMatrixCompute()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceProjectionMatrixCompute" }
                }
            );
        }

        public Vector3 getShadowDirection(System.Nullable<decimal> faceIndex = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getShadowDirection" }, faceIndex
                }
            );
        }

        public decimal getDepthMinZ(Camera activeCamera)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDepthMinZ" }, activeCamera
                }
            );
        }

        public decimal getDepthMaxZ(Camera activeCamera)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDepthMaxZ" }, activeCamera
                }
            );
        }
        #endregion
    }
}