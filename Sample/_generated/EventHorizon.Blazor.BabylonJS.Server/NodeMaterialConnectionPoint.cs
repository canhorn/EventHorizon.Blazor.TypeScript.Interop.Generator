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

    
    
    [JsonConverter(typeof(CachedEntityConverter<NodeMaterialConnectionPoint>))]
    public class NodeMaterialConnectionPoint : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask<bool> AreEquivalentTypes(decimal type1, decimal type2)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "NodeMaterialConnectionPoint", "AreEquivalentTypes" }, type1, type2
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<int> get_direction()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "direction"
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

        
        public async ValueTask<int> get_innerType()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "innerType"
                );
        }

        
        public async ValueTask<int> get_type()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "type"
                );
        }
        public ValueTask set_type(int value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
        }

        
        public async ValueTask<int> get_target()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "target"
                );
        }
        public ValueTask set_target(int value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
        }

        
        public async ValueTask<bool> get_isConnected()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isConnected"
                );
        }

        
        public async ValueTask<bool> get_isConnectedToInputBlock()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isConnectedToInputBlock"
                );
        }

        private InputBlock __connectInputBlock;
        public async ValueTask<InputBlock> get_connectInputBlock()
        {
            if(__connectInputBlock == null)
            {
                __connectInputBlock = await EventHorizonBlazorInterop.GetClass<InputBlock>(
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

        private NodeMaterialConnectionPoint __connectedPoint;
        public async ValueTask<NodeMaterialConnectionPoint> get_connectedPoint()
        {
            if(__connectedPoint == null)
            {
                __connectedPoint = await EventHorizonBlazorInterop.GetClass<NodeMaterialConnectionPoint>(
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

        private NodeMaterialBlock __ownerBlock;
        public async ValueTask<NodeMaterialBlock> get_ownerBlock()
        {
            if(__ownerBlock == null)
            {
                __ownerBlock = await EventHorizonBlazorInterop.GetClass<NodeMaterialBlock>(
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

        private NodeMaterialBlock __sourceBlock;
        public async ValueTask<NodeMaterialBlock> get_sourceBlock()
        {
            if(__sourceBlock == null)
            {
                __sourceBlock = await EventHorizonBlazorInterop.GetClass<NodeMaterialBlock>(
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

        
        public async ValueTask<NodeMaterialBlock[]> get_connectedBlocks()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "connectedBlocks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<NodeMaterialConnectionPoint[]> get_endpoints()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<NodeMaterialConnectionPoint>(
                    this.___guid,
                    "endpoints",
                    (entity) =>
                    {
                        return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<bool> get_hasEndpoints()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasEndpoints"
                );
        }

        
        public async ValueTask<bool> get_isConnectedInVertexShader()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isConnectedInVertexShader"
                );
        }

        
        public async ValueTask<bool> get_isConnectedInFragmentShader()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isConnectedInFragmentShader"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<bool> get_needDualDirectionValidation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "needDualDirectionValidation"
                );
        }
        public ValueTask set_needDualDirectionValidation(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "needDualDirectionValidation",
                    value
                );
        }

        
        public async ValueTask<int[]> get_acceptedConnectionPointTypes()
        {
            return await EventHorizonBlazorInterop.Get<int[]>(
                    this.___guid,
                    "acceptedConnectionPointTypes"
                );
        }
        public ValueTask set_acceptedConnectionPointTypes(int[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "acceptedConnectionPointTypes",
                    value
                );
        }

        
        public async ValueTask<int[]> get_excludedConnectionPointTypes()
        {
            return await EventHorizonBlazorInterop.Get<int[]>(
                    this.___guid,
                    "excludedConnectionPointTypes"
                );
        }
        public ValueTask set_excludedConnectionPointTypes(int[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "excludedConnectionPointTypes",
                    value
                );
        }

        private Observable<NodeMaterialConnectionPoint> __onConnectionObservable;
        public async ValueTask<Observable<NodeMaterialConnectionPoint>> get_onConnectionObservable()
        {
            if(__onConnectionObservable == null)
            {
                __onConnectionObservable = await EventHorizonBlazorInterop.GetClass<Observable<NodeMaterialConnectionPoint>>(
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
        public ValueTask set_onConnectionObservable(Observable<NodeMaterialConnectionPoint> value)
        {
__onConnectionObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onConnectionObservable",
                    value
                );
        }

        
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

        
        public async ValueTask<string> get_displayName()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "displayName"
                );
        }
        public ValueTask set_displayName(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "displayName",
                    value
                );
        }

        
        public async ValueTask<bool> get_isOptional()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isOptional"
                );
        }
        public ValueTask set_isOptional(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isOptional",
                    value
                );
        }

        
        public async ValueTask<bool> get_isExposedOnFrame()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isExposedOnFrame"
                );
        }
        public ValueTask set_isExposedOnFrame(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isExposedOnFrame",
                    value
                );
        }

        
        public async ValueTask<decimal> get_exposedPortPosition()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "exposedPortPosition"
                );
        }
        public ValueTask set_exposedPortPosition(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "exposedPortPosition",
                    value
                );
        }

        
        public async ValueTask<string> get_define()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "define"
                );
        }
        public ValueTask set_define(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "define",
                    value
                );
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

        public static async ValueTask<NodeMaterialConnectionPoint> NewNodeMaterialConnectionPoint(
            string name, NodeMaterialBlock ownerBlock, int direction
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "NodeMaterialConnectionPoint" },
                name, ownerBlock, direction
            );

            return new NodeMaterialConnectionPoint(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<NodeMaterialBlock> createCustomInputBlock()
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createCustomInputBlock" }
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

        public async ValueTask<bool> canConnectTo(NodeMaterialConnectionPoint connectionPoint)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "canConnectTo" }, connectionPoint
                }
            );
        }

        public async ValueTask<int> checkCompatibilityState(NodeMaterialConnectionPoint connectionPoint)
        {
            return await EventHorizonBlazorInterop.Func<int>(
                new object[] 
                {
                    new string[] { this.___guid, "checkCompatibilityState" }, connectionPoint
                }
            );
        }

        public async ValueTask<NodeMaterialConnectionPoint> connectTo(NodeMaterialConnectionPoint connectionPoint, System.Nullable<bool> ignoreConstraints = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "connectTo" }, connectionPoint, ignoreConstraints
                }
            );
        }

        public async ValueTask<NodeMaterialConnectionPoint> disconnectFrom(NodeMaterialConnectionPoint endpoint)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "disconnectFrom" }, endpoint
                }
            );
        }

        public async ValueTask<CachedEntity> serialize(System.Nullable<bool> isInput = null)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, isInput
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