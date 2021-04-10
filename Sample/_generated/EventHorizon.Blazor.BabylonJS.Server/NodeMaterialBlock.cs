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

    
    
    [JsonConverter(typeof(CachedEntityConverter<NodeMaterialBlock>))]
    public class NodeMaterialBlock : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
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

        
        public async ValueTask<bool> get_isUnique()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUnique"
                );
        }

        
        public async ValueTask<bool> get_isFinalMerger()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isFinalMerger"
                );
        }

        
        public async ValueTask<bool> get_isInput()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isInput"
                );
        }

        
        public async ValueTask<decimal> get_buildId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "buildId"
                );
        }
        public ValueTask set_buildId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buildId",
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

        
        public async ValueTask<NodeMaterialConnectionPoint[]> get_inputs()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<NodeMaterialConnectionPoint>(
                    this.___guid,
                    "inputs",
                    (entity) =>
                    {
                        return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<NodeMaterialConnectionPoint[]> get_outputs()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<NodeMaterialConnectionPoint>(
                    this.___guid,
                    "outputs",
                    (entity) =>
                    {
                        return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                    }
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<bool> get_inputsAreExclusive()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputsAreExclusive"
                );
        }
        public ValueTask set_inputsAreExclusive(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputsAreExclusive",
                    value
                );
        }

        
        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
        }
        public ValueTask set_uniqueId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniqueId",
                    value
                );
        }

        
        public async ValueTask<string> get_comments()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "comments"
                );
        }
        public ValueTask set_comments(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "comments",
                    value
                );
        }

        
        public async ValueTask<bool> get_visibleInInspector()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "visibleInInspector"
                );
        }
        public ValueTask set_visibleInInspector(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visibleInInspector",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public NodeMaterialBlock() : base() { } 

        public NodeMaterialBlock(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<NodeMaterialBlock> NewNodeMaterialBlock(
            string name, System.Nullable<int> target = null, System.Nullable<bool> isFinalMerger = null, System.Nullable<bool> isInput = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "NodeMaterialBlock" },
                name, target, isFinalMerger, isInput
            );

            return new NodeMaterialBlock(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<NodeMaterialConnectionPoint> getInputByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getInputByName" }, name
                }
            );
        }

        public async ValueTask<NodeMaterialConnectionPoint> getOutputByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getOutputByName" }, name
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

        public async ValueTask bind(Effect effect, NodeMaterial nodeMaterial, Mesh mesh = null, SubMesh subMesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bind" }, effect, nodeMaterial, mesh, subMesh
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

        public async ValueTask<NodeMaterialBlock> registerInput(string name, int type, System.Nullable<bool> isOptional = null, System.Nullable<int> target = null, NodeMaterialConnectionPoint point = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "registerInput" }, name, type, isOptional, target, point
                }
            );
        }

        public async ValueTask<NodeMaterialBlock> registerOutput(string name, int type, System.Nullable<int> target = null, NodeMaterialConnectionPoint point = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "registerOutput" }, name, type, target, point
                }
            );
        }

        public async ValueTask<NodeMaterialConnectionPoint> getFirstAvailableInput(NodeMaterialConnectionPoint forOutput = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getFirstAvailableInput" }, forOutput
                }
            );
        }

        public async ValueTask<NodeMaterialConnectionPoint> getFirstAvailableOutput(NodeMaterialBlock forBlock = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getFirstAvailableOutput" }, forBlock
                }
            );
        }

        public async ValueTask<NodeMaterialConnectionPoint> getSiblingOutput(NodeMaterialConnectionPoint current)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getSiblingOutput" }, current
                }
            );
        }

        public async ValueTask<NodeMaterialBlock> connectTo(NodeMaterialBlock other, object options = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "connectTo" }, other, options
                }
            );
        }

        public async ValueTask updateUniformsAndSamples(NodeMaterialBuildState state, NodeMaterial nodeMaterial, NodeMaterialDefines defines, string[] uniformBuffers)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateUniformsAndSamples" }, state, nodeMaterial, defines, uniformBuffers
                }
            );
        }

        public async ValueTask provideFallbacks(AbstractMesh mesh, EffectFallbacks fallbacks)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "provideFallbacks" }, mesh, fallbacks
                }
            );
        }

        public async ValueTask initializeDefines(AbstractMesh mesh, NodeMaterial nodeMaterial, NodeMaterialDefines defines, System.Nullable<bool> useInstances = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "initializeDefines" }, mesh, nodeMaterial, defines, useInstances
                }
            );
        }

        public async ValueTask prepareDefines(AbstractMesh mesh, NodeMaterial nodeMaterial, NodeMaterialDefines defines, System.Nullable<bool> useInstances = null, SubMesh subMesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareDefines" }, mesh, nodeMaterial, defines, useInstances, subMesh
                }
            );
        }

        public async ValueTask autoConfigure(NodeMaterial material)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "autoConfigure" }, material
                }
            );
        }

        public async ValueTask replaceRepeatableContent(NodeMaterialBuildState vertexShaderState, NodeMaterialBuildState fragmentShaderState, AbstractMesh mesh, NodeMaterialDefines defines)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "replaceRepeatableContent" }, vertexShaderState, fragmentShaderState, mesh, defines
                }
            );
        }

        public async ValueTask<bool> isReady(AbstractMesh mesh, NodeMaterial nodeMaterial, NodeMaterialDefines defines, System.Nullable<bool> useInstances = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, mesh, nodeMaterial, defines, useInstances
                }
            );
        }

        public async ValueTask<bool> validateBlockName(string newName)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "validateBlockName" }, newName
                }
            );
        }

        public async ValueTask<bool> build(NodeMaterialBuildState state, NodeMaterialBlock[] activeBlocks)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "build" }, state, activeBlocks
                }
            );
        }

        public async ValueTask<NodeMaterialBlock> clone(Scene scene, string rootUrl = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, scene, rootUrl
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