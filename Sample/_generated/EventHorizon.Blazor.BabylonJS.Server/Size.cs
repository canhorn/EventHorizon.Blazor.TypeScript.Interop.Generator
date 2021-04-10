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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Size>))]
    public class Size : CachedEntityObject, ISize
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<Size> Zero()
        {
            return await EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Size", "Zero" }
                }
            );
        }

        public static async ValueTask<Size> Lerp(Size start, Size end, decimal amount)
        {
            return await EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Size", "Lerp" }, start, end, amount
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<decimal> get_surface()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "surface"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_width()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
        }
        public ValueTask set_width(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
        }

        
        public async ValueTask<decimal> get_height()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
        }
        public ValueTask set_height(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Size() : base() { }

        public Size(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Size> NewSize(
            decimal width, decimal height
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Size" },
                width, height
            );

            return new Size(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> toString()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<decimal> getHashCode()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getHashCode" }
                }
            );
        }

        public async ValueTask copyFrom(Size src)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "copyFrom" }, src
                }
            );
        }

        public async ValueTask<Size> copyFromFloats(decimal width, decimal height)
        {
            return await EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "copyFromFloats" }, width, height
                }
            );
        }

        public async ValueTask<Size> set(decimal width, decimal height)
        {
            return await EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "set" }, width, height
                }
            );
        }

        public async ValueTask<Size> multiplyByFloats(decimal w, decimal h)
        {
            return await EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "multiplyByFloats" }, w, h
                }
            );
        }

        public async ValueTask<Size> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask<bool> equals(Size other)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equals" }, other
                }
            );
        }

        public async ValueTask<Size> add(Size otherSize)
        {
            return await EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "add" }, otherSize
                }
            );
        }

        public async ValueTask<Size> subtract(Size otherSize)
        {
            return await EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "subtract" }, otherSize
                }
            );
        }
        #endregion
    }
}