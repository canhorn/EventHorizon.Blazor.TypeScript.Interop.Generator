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
    public class BaseSubMesh : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private MaterialDefines __materialDefines;
        public MaterialDefines materialDefines
        {
            get
            {
            if(__materialDefines == null)
            {
                __materialDefines = EventHorizonBlazorInteropt.GetClass<MaterialDefines>(
                    this.___guid,
                    "materialDefines",
                    (entity) =>
                    {
                        return new MaterialDefines(entity);
                    }
                );
            }
            return __materialDefines;
            }
            set
            {
__materialDefines = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "materialDefines",
                    value
                );
            }
        }

        private Effect __effect;
        public Effect effect
        {
            get
            {
            if(__effect == null)
            {
                __effect = EventHorizonBlazorInteropt.GetClass<Effect>(
                    this.___guid,
                    "effect",
                    (entity) =>
                    {
                        return new Effect(entity);
                    }
                );
            }
            return __effect;
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public BaseSubMesh() : base() { } 

        public BaseSubMesh(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public void setEffect(Effect effect, MaterialDefines defines = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setEffect" }, effect, defines
                }
            );
        }
        #endregion
    }
}