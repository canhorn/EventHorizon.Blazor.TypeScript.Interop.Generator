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
    public class ShadowLight : Light, IShadowLight
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

        #region Properties
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
        #endregion
        
        #region Constructor
        public ShadowLight() : base() { }

        public ShadowLight(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
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

        public bool computeTransformedInformation()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "computeTransformedInformation" }
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

        public Vector3 getAbsolutePosition()
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getAbsolutePosition" }
                }
            );
        }

        public Vector3 setDirectionToTarget(Vector3 target)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setDirectionToTarget" }, target
                }
            );
        }

        public Vector3 getRotation()
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRotation" }
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

        public Matrix computeWorldMatrix(System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "computeWorldMatrix" }, force
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
        #endregion
    }
}