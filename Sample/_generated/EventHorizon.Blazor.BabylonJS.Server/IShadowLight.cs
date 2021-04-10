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
        
        public async ValueTask<string> get_id()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
        }
        public ValueTask set_id(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
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

        private Vector3 __direction;
        public async ValueTask<Vector3> get_direction()
        {
            if(__direction == null)
            {
                __direction = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_direction(Vector3 value)
        {
__direction = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction",
                    value
                );
        }

        private Vector3 __transformedPosition;
        public async ValueTask<Vector3> get_transformedPosition()
        {
            if(__transformedPosition == null)
            {
                __transformedPosition = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_transformedPosition(Vector3 value)
        {
__transformedPosition = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transformedPosition",
                    value
                );
        }

        private Vector3 __transformedDirection;
        public async ValueTask<Vector3> get_transformedDirection()
        {
            if(__transformedDirection == null)
            {
                __transformedDirection = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_transformedDirection(Vector3 value)
        {
__transformedDirection = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transformedDirection",
                    value
                );
        }

        
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

        
        public async ValueTask<decimal> get_shadowMinZ()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowMinZ"
                );
        }
        public ValueTask set_shadowMinZ(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowMinZ",
                    value
                );
        }

        
        public async ValueTask<decimal> get_shadowMaxZ()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowMaxZ"
                );
        }
        public ValueTask set_shadowMaxZ(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowMaxZ",
                    value
                );
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
        public async ValueTask<bool> computeTransformedInformation()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "computeTransformedInformation" }
                }
            );
        }

        public async ValueTask<Scene> getScene()
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
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

        public async ValueTask<string> customProjectionMatrixBuilder(
            Func<Task> callback
        )
        {
            await SetupCustomProjectionMatrixBuilderLoop();

            var handle = Guid.NewGuid().ToString();
            _customProjectionMatrixBuilderActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private async ValueTask SetupCustomProjectionMatrixBuilderLoop()
        {
            if (_isCustomProjectionMatrixBuilderEnabled)
            {
                return;
            }
            await EventHorizonBlazorInterop.FuncCallback(
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

        public async ValueTask<IShadowLightCachedEntity> setShadowProjectionMatrix(Matrix matrix, Matrix viewMatrix, AbstractMesh[] renderList)
        {
            return await EventHorizonBlazorInterop.FuncClass<IShadowLightCachedEntity>(
                entity => new IShadowLightCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setShadowProjectionMatrix" }, matrix, viewMatrix, renderList
                }
            );
        }

        public async ValueTask<decimal> getDepthScale()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDepthScale" }
                }
            );
        }

        public async ValueTask<bool> needCube()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needCube" }
                }
            );
        }

        public async ValueTask<bool> needProjectionMatrixCompute()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needProjectionMatrixCompute" }
                }
            );
        }

        public async ValueTask forceProjectionMatrixCompute()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceProjectionMatrixCompute" }
                }
            );
        }

        public async ValueTask<Vector3> getShadowDirection(System.Nullable<decimal> faceIndex = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getShadowDirection" }, faceIndex
                }
            );
        }

        public async ValueTask<decimal> getDepthMinZ(Camera activeCamera)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDepthMinZ" }, activeCamera
                }
            );
        }

        public async ValueTask<decimal> getDepthMaxZ(Camera activeCamera)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getDepthMaxZ" }, activeCamera
                }
            );
        }
        #endregion
    }
}