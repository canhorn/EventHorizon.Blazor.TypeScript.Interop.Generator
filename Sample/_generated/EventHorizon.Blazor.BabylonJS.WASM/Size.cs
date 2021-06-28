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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Size>))]
    public class Size : CachedEntityObject, ISize
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Size Zero()
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Size", "Zero" }
                }
            );
        }

        public static Size Lerp(Size start, Size end, decimal amount)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Size", "Lerp" }, start, end, amount
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal surface
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "surface"
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Size() : base() { }

        public Size(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Size(
            decimal width, decimal height
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Size" },
                width, height
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string toString()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public decimal getHashCode()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getHashCode" }
                }
            );
        }

        public void copyFrom(Size src)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "copyFrom" }, src
                }
            );
        }

        public Size copyFromFloats(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "copyFromFloats" }, width, height
                }
            );
        }

        public Size set(decimal width, decimal height)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "set" }, width, height
                }
            );
        }

        public Size multiplyByFloats(decimal w, decimal h)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "multiplyByFloats" }, w, h
                }
            );
        }

        public Size clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public bool equals(Size other)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "equals" }, other
                }
            );
        }

        public Size add(Size otherSize)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "add" }, otherSize
                }
            );
        }

        public Size subtract(Size otherSize)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
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