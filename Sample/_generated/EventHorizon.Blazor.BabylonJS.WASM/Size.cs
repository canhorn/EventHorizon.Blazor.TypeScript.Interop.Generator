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
    public class Size : CachedEntityObject, ISize
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Size Zero()
        {
            return EventHorizonBlazorInteropt.FuncClass<Size>(
                entity => new Size(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Size", "Zero" }
                }
            );
        }

        public static Size Lerp(Size start, Size end, decimal amount)
        {
            return EventHorizonBlazorInteropt.FuncClass<Size>(
                entity => new Size(entity),
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
            return EventHorizonBlazorInteropt.Get<decimal>(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Size" },
                width, height
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string toString()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public decimal getHashCode()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getHashCode" }
                }
            );
        }

        public void copyFrom(Size src)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "copyFrom" }, src
                }
            );
        }

        public Size copyFromFloats(decimal width, decimal height)
        {
            return EventHorizonBlazorInteropt.FuncClass<Size>(
                entity => new Size(entity),
                new object[] 
                {
                    new string[] { this.___guid, "copyFromFloats" }, width, height
                }
            );
        }

        public Size set(decimal width, decimal height)
        {
            return EventHorizonBlazorInteropt.FuncClass<Size>(
                entity => new Size(entity),
                new object[] 
                {
                    new string[] { this.___guid, "set" }, width, height
                }
            );
        }

        public Size multiplyByFloats(decimal w, decimal h)
        {
            return EventHorizonBlazorInteropt.FuncClass<Size>(
                entity => new Size(entity),
                new object[] 
                {
                    new string[] { this.___guid, "multiplyByFloats" }, w, h
                }
            );
        }

        public Size clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<Size>(
                entity => new Size(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public bool equals(Size other)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "equals" }, other
                }
            );
        }

        public Size add(Size otherSize)
        {
            return EventHorizonBlazorInteropt.FuncClass<Size>(
                entity => new Size(entity),
                new object[] 
                {
                    new string[] { this.___guid, "add" }, otherSize
                }
            );
        }

        public Size subtract(Size otherSize)
        {
            return EventHorizonBlazorInteropt.FuncClass<Size>(
                entity => new Size(entity),
                new object[] 
                {
                    new string[] { this.___guid, "subtract" }, otherSize
                }
            );
        }
        #endregion
    }
}