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
        public async ValueTask<Collider> createCollider()
        {
            return await EventHorizonBlazorInterop.FuncClass<Collider>(
                entity => new Collider() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createCollider" }
                }
            );
        }

        public async ValueTask getNewPosition(Vector3 position, Vector3 displacement, Collider collider, decimal maximumRetry, AbstractMesh excludedMesh, ActionCallback<decimal, Vector3, AbstractMesh> onNewPosition, decimal collisionIndex)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getNewPosition" }, position, displacement, collider, maximumRetry, excludedMesh, onNewPosition, collisionIndex
                }
            );
        }

        public async ValueTask init(Scene scene)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "init" }, scene
                }
            );
        }
        #endregion
    }
}