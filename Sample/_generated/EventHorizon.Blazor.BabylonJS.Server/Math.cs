/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using Microsoft.JSInterop;

public interface Math : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<MathCachedEntity>))]
public class MathCachedEntity : CachedEntityObject, Math
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
        public MathCachedEntity() : base() { }

        public MathCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public async ValueTask<decimal> fround(decimal x)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "fround" }, x
                }
            );
        }

        public async ValueTask<decimal> imul(decimal a, decimal b)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "imul" }, a, b
                }
            );
        }
    #endregion
}