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

    
    
    [JsonConverter(typeof(CachedEntityConverter<NodeMaterialConnectionPoint>))]
    public class NodeMaterialConnectionPoint : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static bool AreEquivalentTypes(decimal type1, decimal type2)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "NodeMaterialConnectionPoint", "AreEquivalentTypes" }, type1, type2
                }
            );
        }
        #endregion

        #region Accessors
        
        public int direction
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "direction"
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

        
        public int innerType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "innerType"
                );
            }
        }

        
        public int type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }

        
        public int target
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "target"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
            }
        }

        
        public bool isConnected
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isConnected"
                );
            }
        }

        
        public bool isConnectedToInputBlock
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isConnectedToInputBlock"
                );
            }
        }

        private InputBlock __connectInputBlock;
        public InputBlock connectInputBlock
        {
            get
            {
            if(__connectInputBlock == null)
            {
                __connectInputBlock = EventHorizonBlazorInterop.GetClass<InputBlock>(
                    this.___guid,
                    "connectInputBlock",
                    (entity) =>
                    {
                        return new InputBlock() { ___guid = entity.___guid };
                    }
                );
            }
            return __connectInputBlock;
            }
        }

        private NodeMaterialConnectionPoint __connectedPoint;
        public NodeMaterialConnectionPoint connectedPoint
        {
            get
            {
            if(__connectedPoint == null)
            {
                __connectedPoint = EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
                    this.___guid,
                    "connectedPoint",
                    (entity) =>
                    {
                        return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                    }
                );
            }
            return __connectedPoint;
            }
        }

        private NodeMaterialBlock __ownerBlock;
        public NodeMaterialBlock ownerBlock
        {
            get
            {
            if(__ownerBlock == null)
            {
                __ownerBlock = EventHorizonBlazorInterop.GetClass<NodeMaterialBlock>(
                    this.___guid,
                    "ownerBlock",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
            }
            return __ownerBlock;
            }
        }

        private NodeMaterialBlock __sourceBlock;
        public NodeMaterialBlock sourceBlock
        {
            get
            {
            if(__sourceBlock == null)
            {
                __sourceBlock = EventHorizonBlazorInterop.GetClass<NodeMaterialBlock>(
                    this.___guid,
                    "sourceBlock",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
            }
            return __sourceBlock;
            }
        }

        
        public NodeMaterialBlock[] connectedBlocks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "connectedBlocks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public NodeMaterialConnectionPoint[] endpoints
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<NodeMaterialConnectionPoint>(
                    this.___guid,
                    "endpoints",
                    (entity) =>
                    {
                        return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public bool hasEndpoints
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasEndpoints"
                );
            }
        }

        
        public bool isConnectedInVertexShader
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isConnectedInVertexShader"
                );
            }
        }

        
        public bool isConnectedInFragmentShader
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isConnectedInFragmentShader"
                );
            }
        }
        #endregion

        #region Properties
        
        public bool needDualDirectionValidation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "needDualDirectionValidation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "needDualDirectionValidation",
                    value
                );
            }
        }

        
        public int[] acceptedConnectionPointTypes
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int[]>(
                    this.___guid,
                    "acceptedConnectionPointTypes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "acceptedConnectionPointTypes",
                    value
                );
            }
        }

        
        public int[] excludedConnectionPointTypes
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int[]>(
                    this.___guid,
                    "excludedConnectionPointTypes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "excludedConnectionPointTypes",
                    value
                );
            }
        }

        private Observable<NodeMaterialConnectionPoint> __onConnectionObservable;
        public Observable<NodeMaterialConnectionPoint> onConnectionObservable
        {
            get
            {
            if(__onConnectionObservable == null)
            {
                __onConnectionObservable = EventHorizonBlazorInterop.GetClass<Observable<NodeMaterialConnectionPoint>>(
                    this.___guid,
                    "onConnectionObservable",
                    (entity) =>
                    {
                        return new Observable<NodeMaterialConnectionPoint>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onConnectionObservable;
            }
            set
            {
__onConnectionObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onConnectionObservable",
                    value
                );
            }
        }

        
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

        
        public string displayName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "displayName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayName",
                    value
                );
            }
        }

        
        public bool isOptional
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isOptional"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isOptional",
                    value
                );
            }
        }

        
        public bool isExposedOnFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isExposedOnFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isExposedOnFrame",
                    value
                );
            }
        }

        
        public decimal exposedPortPosition
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "exposedPortPosition"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "exposedPortPosition",
                    value
                );
            }
        }

        
        public string define
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "define"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "define",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public NodeMaterialConnectionPoint() : base() { }

        public NodeMaterialConnectionPoint(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public NodeMaterialConnectionPoint(
            string name, NodeMaterialBlock ownerBlock, int direction
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "NodeMaterialConnectionPoint" },
                name, ownerBlock, direction
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public NodeMaterialBlock createCustomInputBlock()
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createCustomInputBlock" }
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

        public bool canConnectTo(NodeMaterialConnectionPoint connectionPoint)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "canConnectTo" }, connectionPoint
                }
            );
        }

        public int checkCompatibilityState(NodeMaterialConnectionPoint connectionPoint)
        {
            return EventHorizonBlazorInterop.Func<int>(
                new object[]
                {
                    new string[] { this.___guid, "checkCompatibilityState" }, connectionPoint
                }
            );
        }

        public NodeMaterialConnectionPoint connectTo(NodeMaterialConnectionPoint connectionPoint, System.Nullable<bool> ignoreConstraints = null)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "connectTo" }, connectionPoint, ignoreConstraints
                }
            );
        }

        public NodeMaterialConnectionPoint disconnectFrom(NodeMaterialConnectionPoint endpoint)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "disconnectFrom" }, endpoint
                }
            );
        }

        public CachedEntity serialize(System.Nullable<bool> isInput = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }, isInput
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