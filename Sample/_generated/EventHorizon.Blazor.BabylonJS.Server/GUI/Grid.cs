/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
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
        
        public async ValueTask<decimal> get_columnCount()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "columnCount"
                );
        }

        
        public async ValueTask<decimal> get_rowCount()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rowCount"
                );
        }

        
        public async ValueTask<Control[]> get_children()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Control>(
                    this.___guid,
                    "children",
                    (entity) =>
                    {
                        return new Control() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<CachedEntity> get_cells()
        {
            return await EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "cells"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public Grid() : base() { }

        public Grid(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<Grid> NewGrid(
            string name = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Grid" },
                name
            );

            return new Grid(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<ValueAndUnit> getRowDefinition(decimal index)
        {
            return await EventHorizonBlazorInterop.FuncClass<ValueAndUnit>(
                entity => new ValueAndUnit() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRowDefinition" }, index
                }
            );
        }

        public async ValueTask<ValueAndUnit> getColumnDefinition(decimal index)
        {
            return await EventHorizonBlazorInterop.FuncClass<ValueAndUnit>(
                entity => new ValueAndUnit() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getColumnDefinition" }, index
                }
            );
        }

        public async ValueTask<Grid> addRowDefinition(decimal height, System.Nullable<bool> isPixel = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addRowDefinition" }, height, isPixel
                }
            );
        }

        public async ValueTask<Grid> addColumnDefinition(decimal width, System.Nullable<bool> isPixel = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addColumnDefinition" }, width, isPixel
                }
            );
        }

        public async ValueTask<Grid> setRowDefinition(decimal index, decimal height, System.Nullable<bool> isPixel = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setRowDefinition" }, index, height, isPixel
                }
            );
        }

        public async ValueTask<Grid> setColumnDefinition(decimal index, decimal width, System.Nullable<bool> isPixel = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setColumnDefinition" }, index, width, isPixel
                }
            );
        }

        public async ValueTask<Control[]> getChildrenAt(decimal row, decimal column)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Control>(
                entity => new Control() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getChildrenAt" }, row, column
                }
            );
        }

        public async ValueTask<string> getChildCellInfo(Control child)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getChildCellInfo" }, child
                }
            );
        }

        public async ValueTask<Grid> removeColumnDefinition(decimal index)
        {
            return await EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeColumnDefinition" }, index
                }
            );
        }

        public async ValueTask<Grid> removeRowDefinition(decimal index)
        {
            return await EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeRowDefinition" }, index
                }
            );
        }

        public async ValueTask<Grid> addControl(Control control, System.Nullable<decimal> row = null, System.Nullable<decimal> column = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Grid>(
                entity => new Grid() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addControl" }, control, row, column
                }
            );
        }

        public async ValueTask<Container> removeControl(Control control)
        {
            return await EventHorizonBlazorInterop.FuncClass<Container>(
                entity => new Container() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeControl" }, control
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}