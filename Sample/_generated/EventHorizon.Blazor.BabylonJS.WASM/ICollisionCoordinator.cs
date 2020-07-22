/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface ICollisionCoordinator : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            return EventHorizonBlazorInteropt.FuncClass<Collider>(
                entity => new Collider() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createCollider" }
                }
            );
        }

// getNewPosition is not supported by the platform yet

        public void init(Scene scene)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "init" }, scene
                }
            );
        }
        #endregion
    }
}