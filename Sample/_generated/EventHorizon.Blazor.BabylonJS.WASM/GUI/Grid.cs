/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Grid>))]
    public class Grid : Container
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public decimal columnCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "columnCount"
                );
            }
        }

        
        public decimal rowCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rowCount"
                );
            }
        }

        
        public Control[] children
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Control>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new Control() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public CachedEntity cells
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "cells"
                );
            }
        }
        #endregion

        #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Grid() : base() { }

        public Grid(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Grid(
            string name = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Grid" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public ValueAndUnit getRowDefinition(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<ValueAndUnit>(
                entity => new ValueAndUnit() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRowDefinition" }, index
                }
            );
        }

        public ValueAndUnit getColumnDefinition(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<ValueAndUnit>(
                entity => new ValueAndUnit() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getColumnDefinition" }, index
                }
            );
        }

        public Grid addRowDefinition(decimal height, System.Nullable<bool> isPixel = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addRowDefinition" }, height, isPixel
                }
            );
        }

        public Grid addColumnDefinition(decimal width, System.Nullable<bool> isPixel = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addColumnDefinition" }, width, isPixel
                }
            );
        }

        public Grid setRowDefinition(decimal index, decimal height, System.Nullable<bool> isPixel = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setRowDefinition" }, index, height, isPixel
                }
            );
        }

        public Grid setColumnDefinition(decimal index, decimal width, System.Nullable<bool> isPixel = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setColumnDefinition" }, index, width, isPixel
                }
            );
        }

        public Control[] getChildrenAt(decimal row, decimal column)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildrenAt" }, row, column
                }
            );
        }

        public string getChildCellInfo(Control child)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getChildCellInfo" }, child
                }
            );
        }

        public Grid removeColumnDefinition(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeColumnDefinition" }, index
                }
            );
        }

        public Grid removeRowDefinition(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeRowDefinition" }, index
                }
            );
        }

        public Grid addControl(Control control, System.Nullable<decimal> row = null, System.Nullable<decimal> column = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addControl" }, control, row, column
                }
            );
        }

        public Container removeControl(Control control)
        {
            return EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeControl" }, control
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}