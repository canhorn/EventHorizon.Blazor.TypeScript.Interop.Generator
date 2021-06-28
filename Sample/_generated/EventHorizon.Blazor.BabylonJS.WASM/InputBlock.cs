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
        
        public int type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "type"
                );
            }
        }

        private NodeMaterialConnectionPoint __output;
        public NodeMaterialConnectionPoint output
        {
            get
            {
            if(__output == null)
            {
                __output = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
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
        }

        
        public CachedEntity value
        {
            get
            {
            return EventHorizonBlazorInterop.Get<CachedEntity>(
                    this.___guid,
                    "value"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "value",
                    value
                );
            }
        }

        
        public ActionResultCallback<CachedEntity> valueCallback
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionResultCallback<CachedEntity>>(
                    this.___guid,
                    "valueCallback"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "valueCallback",
                    value
                );
            }
        }

        
        public string associatedVariableName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "associatedVariableName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "associatedVariableName",
                    value
                );
            }
        }

        
        public int animationType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "animationType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationType",
                    value
                );
            }
        }

        
        public bool isUndefined
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUndefined"
                );
            }
        }

        
        public bool isUniform
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUniform"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isUniform",
                    value
                );
            }
        }

        
        public bool isAttribute
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isAttribute"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isAttribute",
                    value
                );
            }
        }

        
        public bool isVarying
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isVarying"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isVarying",
                    value
                );
            }
        }

        
        public bool isSystemValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isSystemValue"
                );
            }
        }

        
        public int systemValue
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "systemValue"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "systemValue",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal min
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "min"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "min",
                    value
                );
            }
        }

        
        public decimal max
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "max"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "max",
                    value
                );
            }
        }

        
        public bool isBoolean
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBoolean"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isBoolean",
                    value
                );
            }
        }

        
        public decimal matrixMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "matrixMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrixMode",
                    value
                );
            }
        }

        
        public bool isConstant
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isConstant"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isConstant",
                    value
                );
            }
        }

        
        public string groupInInspector
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "groupInInspector"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groupInInspector",
                    value
                );
            }
        }

        private Observable<InputBlock> __onValueChangedObservable;
        public Observable<InputBlock> onValueChangedObservable
        {
            get
            {
            if(__onValueChangedObservable == null)
            {
                __onValueChangedObservable = EventHorizonBlazorInterop.GetClass<Observable<InputBlock>>(
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
            set
            {
__onValueChangedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onValueChangedObservable",
                    value
                );
            }
        }

        
        public bool convertToGammaSpace
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "convertToGammaSpace"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "convertToGammaSpace",
                    value
                );
            }
        }

        
        public bool convertToLinearSpace
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "convertToLinearSpace"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "convertToLinearSpace",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public InputBlock() : base() { }

        public InputBlock(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public InputBlock(
            string name, System.Nullable<int> target = null, System.Nullable<int> type = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "InputBlock" },
                name, target, type
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool validateBlockName(string newName)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "validateBlockName" }, newName
                }
            );
        }

        public InputBlock setAsAttribute(string attributeName = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InputBlock>(
                entity => new InputBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAsAttribute" }, attributeName
                }
            );
        }

        public InputBlock setAsSystemValue(int value)
        {
            return EventHorizonBlazorInterop.FuncClass<InputBlock>(
                entity => new InputBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setAsSystemValue" }, value
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

        public void animate(Scene scene)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "animate" }, scene
                }
            );
        }

        public void initialize(NodeMaterialBuildState state)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initialize" }, state
                }
            );
        }

        public void setDefaultValue()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setDefaultValue" }
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

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}