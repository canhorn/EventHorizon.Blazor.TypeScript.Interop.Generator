/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface ISpriteManager : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class ISpriteManagerCachedEntity : CachedEntityObject, ISpriteManager
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
        
        public decimal layerMask
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "layerMask",
                    value
                );
            }
        }

        
        public bool isPickable
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isPickable"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isPickable",
                    value
                );
            }
        }

        
        public decimal renderingGroupId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "renderingGroupId"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "renderingGroupId",
                    value
                );
            }
        }

        
        public Sprite[] sprites
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Sprite>(
                    this.___guid,
                    "sprites",
                    (entity) =>
                    {
                        return new Sprite() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sprites",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ISpriteManagerCachedEntity() : base() { }

        public ISpriteManagerCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
// intersects is not supported by the platform yet

// multiIntersects is not supported by the platform yet

        public void render()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }
                }
            );
        }
        #endregion
    }
}