/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "columnCount"
                );
            }
        }

        
        public decimal rowCount
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "rowCount"
                );
            }
        }

        
        public Control[] children
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Control>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new Control(entity);
                    }
                );
            }
        }

        
        public CachedEntity cells
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
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
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "GUI", "Grid" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public ValueAndUnit getRowDefinition(decimal index)
        {
            return EventHorizonBlazorInteropt.FuncClass<ValueAndUnit>(
                entity => new ValueAndUnit(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getRowDefinition" }, index
                }
            );
        }

        public ValueAndUnit getColumnDefinition(decimal index)
        {
            return EventHorizonBlazorInteropt.FuncClass<ValueAndUnit>(
                entity => new ValueAndUnit(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getColumnDefinition" }, index
                }
            );
        }

        public Grid addRowDefinition(decimal height, System.Nullable<bool> isPixel = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Grid>(
                entity => new Grid(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addRowDefinition" }, height, isPixel
                }
            );
        }

        public Grid addColumnDefinition(decimal width, System.Nullable<bool> isPixel = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Grid>(
                entity => new Grid(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addColumnDefinition" }, width, isPixel
                }
            );
        }

        public Grid setRowDefinition(decimal index, decimal height, System.Nullable<bool> isPixel = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Grid>(
                entity => new Grid(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setRowDefinition" }, index, height, isPixel
                }
            );
        }

        public Grid setColumnDefinition(decimal index, decimal width, System.Nullable<bool> isPixel = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Grid>(
                entity => new Grid(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setColumnDefinition" }, index, width, isPixel
                }
            );
        }

        public Control[] getChildrenAt(decimal row, decimal column)
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<Control>(
                entity => new Control(entity),
                new object[]
                {
                    new string[] { this.___guid, "getChildrenAt" }, row, column
                }
            );
        }

        public string getChildCellInfo(Control child)
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getChildCellInfo" }, child
                }
            );
        }

        public Grid removeColumnDefinition(decimal index)
        {
            return EventHorizonBlazorInteropt.FuncClass<Grid>(
                entity => new Grid(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeColumnDefinition" }, index
                }
            );
        }

        public Grid removeRowDefinition(decimal index)
        {
            return EventHorizonBlazorInteropt.FuncClass<Grid>(
                entity => new Grid(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeRowDefinition" }, index
                }
            );
        }

        public Grid addControl(Control control, System.Nullable<decimal> row = null, System.Nullable<decimal> column = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Grid>(
                entity => new Grid(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addControl" }, control, row, column
                }
            );
        }

        public Container removeControl(Control control)
        {
            return EventHorizonBlazorInteropt.FuncClass<Container>(
                entity => new Container(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeControl" }, control
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}