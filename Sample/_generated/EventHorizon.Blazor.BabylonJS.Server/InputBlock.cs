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

    
    
    [JsonConverter(typeof(CachedEntityConverter<InputBlock>))]
    public class InputBlock : NodeMaterialBlock
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public async ValueTask<int> get_type()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "type"
                );
        }

        private NodeMaterialConnectionPoint __output;
        public async ValueTask<NodeMaterialConnectionPoint> get_output()
        {
            if(__output == null)
            {
                __output = await EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                    this.___guid,
                    "output",
                    (entity) =>
                    {
                        return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __output;
        }

        
        public async ValueTask<CachedEntity> get_value()
        {
            return await EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "value"
                );
        }
        public ValueTask set_value(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "value",
                    value
                );
        }

        
        public async ValueTask<ActionCallback> get_valueCallback()
        {
            return await EventHorizonBlazorInterop.Get<ActionCallback>(
                    this.___guid,
                    "valueCallback"
                );
        }
        public ValueTask set_valueCallback(ActionCallback value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "valueCallback",
                    value
                );
        }

        
        public async ValueTask<string> get_associatedVariableName()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "associatedVariableName"
                );
        }
        public ValueTask set_associatedVariableName(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "associatedVariableName",
                    value
                );
        }

        
        public async ValueTask<int> get_animationType()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "animationType"
                );
        }
        public ValueTask set_animationType(int value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationType",
                    value
                );
        }

        
        public async ValueTask<bool> get_isUndefined()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUndefined"
                );
        }

        
        public async ValueTask<bool> get_isUniform()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUniform"
                );
        }
        public ValueTask set_isUniform(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isUniform",
                    value
                );
        }

        
        public async ValueTask<bool> get_isAttribute()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isAttribute"
                );
        }
        public ValueTask set_isAttribute(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isAttribute",
                    value
                );
        }

        
        public async ValueTask<bool> get_isVarying()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isVarying"
                );
        }
        public ValueTask set_isVarying(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isVarying",
                    value
                );
        }

        
        public async ValueTask<bool> get_isSystemValue()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSystemValue"
                );
        }

        
        public async ValueTask<int> get_systemValue()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "systemValue"
                );
        }
        public ValueTask set_systemValue(int value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "systemValue",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<decimal> get_min()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "min"
                );
        }
        public ValueTask set_min(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "min",
                    value
                );
        }

        
        public async ValueTask<decimal> get_max()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "max"
                );
        }
        public ValueTask set_max(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "max",
                    value
                );
        }

        
        public async ValueTask<bool> get_isBoolean()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBoolean"
                );
        }
        public ValueTask set_isBoolean(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isBoolean",
                    value
                );
        }

        
        public async ValueTask<decimal> get_matrixMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "matrixMode"
                );
        }
        public ValueTask set_matrixMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrixMode",
                    value
                );
        }

        
        public async ValueTask<bool> get_isConstant()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isConstant"
                );
        }
        public ValueTask set_isConstant(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isConstant",
                    value
                );
        }

        
        public async ValueTask<string> get_groupInInspector()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "groupInInspector"
                );
        }
        public ValueTask set_groupInInspector(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groupInInspector",
                    value
                );
        }

        private Observable<InputBlock> __onValueChangedObservable;
        public async ValueTask<Observable<InputBlock>> get_onValueChangedObservable()
        {
            if(__onValueChangedObservable == null)
            {
                __onValueChangedObservable = await EventHorizonBlazorInterop.GetClass<Observable<InputBlock>>(
                    this.___guid,
                    "onValueChangedObservable",
                    (entity) =>
                    {
                        return new Observable<InputBlock>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onValueChangedObservable;
        }
        public ValueTask set_onValueChangedObservable(Observable<InputBlock> value)
        {
__onValueChangedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onValueChangedObservable",
                    value
                );
        }

        
        public async ValueTask<bool> get_convertToGammaSpace()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "convertToGammaSpace"
                );
        }
        public ValueTask set_convertToGammaSpace(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "convertToGammaSpace",
                    value
                );
        }

        
        public async ValueTask<bool> get_convertToLinearSpace()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "convertToLinearSpace"
                );
        }
        public ValueTask set_convertToLinearSpace(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "convertToLinearSpace",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public InputBlock() : base() { }

        public InputBlock(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<InputBlock> NewInputBlock(
            string name, System.Nullable<int> target = null, System.Nullable<int> type = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InputBlock" },
                name, target, type
            );

            return new InputBlock(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<bool> validateBlockName(string newName)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "validateBlockName" }, newName
                }
            );
        }

        public async ValueTask<InputBlock> setAsAttribute(string attributeName = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<InputBlock>(
                entity => new InputBlock() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setAsAttribute" }, attributeName
                }
            );
        }

        public async ValueTask<InputBlock> setAsSystemValue(int value)
        {
            return await EventHorizonBlazorInterop.FuncClass<InputBlock>(
                entity => new InputBlock() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "setAsSystemValue" }, value
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

        public async ValueTask animate(Scene scene)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "animate" }, scene
                }
            );
        }

        public async ValueTask initialize(NodeMaterialBuildState state)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "initialize" }, state
                }
            );
        }

        public async ValueTask setDefaultValue()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setDefaultValue" }
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

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}