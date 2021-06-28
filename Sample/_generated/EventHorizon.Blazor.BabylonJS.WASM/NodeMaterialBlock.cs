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

        
        public bool isUnique
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUnique"
                );
            }
        }

        
        public bool isFinalMerger
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isFinalMerger"
                );
            }
        }

        
        public bool isInput
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isInput"
                );
            }
        }

        
        public decimal buildId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "buildId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buildId",
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

        
        public NodeMaterialConnectionPoint[] inputs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<NodeMaterialConnectionPoint>(
                    this.___guid,
                    "inputs",
                    (entity) =>
                    {
                        return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public NodeMaterialConnectionPoint[] outputs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<NodeMaterialConnectionPoint>(
                    this.___guid,
                    "outputs",
                    (entity) =>
                    {
                        return new NodeMaterialConnectionPoint() { ___guid = entity.___guid };
                    }
                );
            }
        }
        #endregion

        #region Properties
        
        public bool inputsAreExclusive
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "inputsAreExclusive"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputsAreExclusive",
                    value
                );
            }
        }

        
        public decimal uniqueId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniqueId",
                    value
                );
            }
        }

        
        public string comments
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "comments"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "comments",
                    value
                );
            }
        }

        
        public bool visibleInInspector
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "visibleInInspector"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "visibleInInspector",
                    value
                );
            }
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

        public NodeMaterialBlock(
            string name, System.Nullable<int> target = null, System.Nullable<bool> isFinalMerger = null, System.Nullable<bool> isInput = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "NodeMaterialBlock" },
                name, target, isFinalMerger, isInput
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public NodeMaterialConnectionPoint getInputByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getInputByName" }, name
                }
            );
        }

        public NodeMaterialConnectionPoint getOutputByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getOutputByName" }, name
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

        public void bind(Effect effect, NodeMaterial nodeMaterial, Mesh mesh = null, SubMesh subMesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bind" }, effect, nodeMaterial, mesh, subMesh
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

        public NodeMaterialBlock registerInput(string name, int type, System.Nullable<bool> isOptional = null, System.Nullable<int> target = null, NodeMaterialConnectionPoint point = null)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "registerInput" }, name, type, isOptional, target, point
                }
            );
        }

        public NodeMaterialBlock registerOutput(string name, int type, System.Nullable<int> target = null, NodeMaterialConnectionPoint point = null)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "registerOutput" }, name, type, target, point
                }
            );
        }

        public NodeMaterialConnectionPoint getFirstAvailableInput(NodeMaterialConnectionPoint forOutput = null)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFirstAvailableInput" }, forOutput
                }
            );
        }

        public NodeMaterialConnectionPoint getFirstAvailableOutput(NodeMaterialBlock forBlock = null)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getFirstAvailableOutput" }, forBlock
                }
            );
        }

        public NodeMaterialConnectionPoint getSiblingOutput(NodeMaterialConnectionPoint current)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialConnectionPoint>(
                entity => new NodeMaterialConnectionPoint() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSiblingOutput" }, current
                }
            );
        }

        public NodeMaterialBlock connectTo(NodeMaterialBlock other, object options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "connectTo" }, other, options
                }
            );
        }

        public void updateUniformsAndSamples(NodeMaterialBuildState state, NodeMaterial nodeMaterial, NodeMaterialDefines defines, string[] uniformBuffers)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateUniformsAndSamples" }, state, nodeMaterial, defines, uniformBuffers
                }
            );
        }

        public void provideFallbacks(AbstractMesh mesh, EffectFallbacks fallbacks)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "provideFallbacks" }, mesh, fallbacks
                }
            );
        }

        public void initializeDefines(AbstractMesh mesh, NodeMaterial nodeMaterial, NodeMaterialDefines defines, System.Nullable<bool> useInstances = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initializeDefines" }, mesh, nodeMaterial, defines, useInstances
                }
            );
        }

        public void prepareDefines(AbstractMesh mesh, NodeMaterial nodeMaterial, NodeMaterialDefines defines, System.Nullable<bool> useInstances = null, SubMesh subMesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareDefines" }, mesh, nodeMaterial, defines, useInstances, subMesh
                }
            );
        }

        public void autoConfigure(NodeMaterial material)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "autoConfigure" }, material
                }
            );
        }

        public void replaceRepeatableContent(NodeMaterialBuildState vertexShaderState, NodeMaterialBuildState fragmentShaderState, AbstractMesh mesh, NodeMaterialDefines defines)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "replaceRepeatableContent" }, vertexShaderState, fragmentShaderState, mesh, defines
                }
            );
        }

        public bool isReady(AbstractMesh mesh, NodeMaterial nodeMaterial, NodeMaterialDefines defines, System.Nullable<bool> useInstances = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReady" }, mesh, nodeMaterial, defines, useInstances
                }
            );
        }

        public bool validateBlockName(string newName)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "validateBlockName" }, newName
                }
            );
        }

        public bool build(NodeMaterialBuildState state, NodeMaterialBlock[] activeBlocks)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "build" }, state, activeBlocks
                }
            );
        }

        public NodeMaterialBlock clone(Scene scene, string rootUrl = null)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, scene, rootUrl
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