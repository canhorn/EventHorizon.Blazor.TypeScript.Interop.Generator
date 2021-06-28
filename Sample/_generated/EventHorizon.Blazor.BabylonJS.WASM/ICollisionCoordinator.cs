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

    public interface ICollisionCoordinator : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<ICollisionCoordinatorCachedEntity>))]
    public class ICollisionCoordinatorCachedEntity : CachedEntityObject, ICollisionCoordinator
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

        #endregion
        
        #region Constructor
        public ICollisionCoordinatorCachedEntity() : base() { }

        public ICollisionCoordinatorCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public Collider createCollider()
        {
            return EventHorizonBlazorInterop.FuncClass<Collider>(
                entity => new Collider() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createCollider" }
                }
            );
        }

        public void getNewPosition(Vector3 position, Vector3 displacement, Collider collider, decimal maximumRetry, AbstractMesh excludedMesh, ActionCallback<decimal, Vector3, AbstractMesh> onNewPosition, decimal collisionIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "getNewPosition" }, position, displacement, collider, maximumRetry, excludedMesh, onNewPosition, collisionIndex
                }
            );
        }

        public void init(Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "init" }, scene
                }
            );
        }
        #endregion
    }
}