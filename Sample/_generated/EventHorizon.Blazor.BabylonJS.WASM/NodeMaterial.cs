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

    
    
    [JsonConverter(typeof(CachedEntityConverter<NodeMaterial>))]
    public class NodeMaterial : PushMaterial
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static string EditorURL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "NodeMaterial.EditorURL"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "NodeMaterial.EditorURL",
                    value
                );
            }
        }

        
        public static string SnippetUrl
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "NodeMaterial.SnippetUrl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "NodeMaterial.SnippetUrl",
                    value
                );
            }
        }

        
        public static bool IgnoreTexturesAtLoadTime
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "NodeMaterial.IgnoreTexturesAtLoadTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "NodeMaterial.IgnoreTexturesAtLoadTime",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static NodeMaterial Parse(object source, Scene scene, string rootUrl = null)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "NodeMaterial", "Parse" }, source, scene, rootUrl
                }
            );
        }

        public static ValueTask<NodeMaterial> ParseFromFileAsync(string name, string url, Scene scene)
        {
            return EventHorizonBlazorInterop.TaskClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "NodeMaterial", "ParseFromFileAsync" }, name, url, scene
                }
            );
        }

        public static ValueTask<NodeMaterial> ParseFromSnippetAsync(string snippetId, Scene scene, string rootUrl = null, NodeMaterial nodeMaterial = null)
        {
            return EventHorizonBlazorInterop.TaskClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "NodeMaterial", "ParseFromSnippetAsync" }, snippetId, scene, rootUrl, nodeMaterial
                }
            );
        }

        public static NodeMaterial CreateDefault(string name, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "NodeMaterial", "CreateDefault" }, name, scene
                }
            );
        }
        #endregion

        #region Accessors
        private INodeMaterialOptionsCachedEntity __options;
        public INodeMaterialOptionsCachedEntity options
        {
            get
            {
            if(__options == null)
            {
                __options = EventHorizonBlazorInterop.GetClass<INodeMaterialOptionsCachedEntity>(
                    this.___guid,
                    "options",
                    (entity) =>
                    {
                        return new INodeMaterialOptionsCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __options;
            }
            set
            {
__options = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "options",
                    value
                );
            }
        }

        private ImageProcessingConfiguration __imageProcessingConfiguration;
        public ImageProcessingConfiguration imageProcessingConfiguration
        {
            get
            {
            if(__imageProcessingConfiguration == null)
            {
                __imageProcessingConfiguration = EventHorizonBlazorInterop.GetClass<ImageProcessingConfiguration>(
                    this.___guid,
                    "imageProcessingConfiguration",
                    (entity) =>
                    {
                        return new ImageProcessingConfiguration() { ___guid = entity.___guid };
                    }
                );
            }
            return __imageProcessingConfiguration;
            }
            set
            {
__imageProcessingConfiguration = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageProcessingConfiguration",
                    value
                );
            }
        }

        
        public int mode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "mode"
                );
            }
        }

        
        public string compiledShaders
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "compiledShaders"
                );
            }
        }
        #endregion

        #region Properties
        
        public string snippetId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "snippetId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "snippetId",
                    value
                );
            }
        }

        
        public CachedEntity editorData
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "editorData",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "editorData",
                    value
                );
            }
        }

        
        public bool ignoreAlpha
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreAlpha"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignoreAlpha",
                    value
                );
            }
        }

        
        public decimal maxSimultaneousLights
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxSimultaneousLights"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxSimultaneousLights",
                    value
                );
            }
        }

        private Observable<NodeMaterial> __onBuildObservable;
        public Observable<NodeMaterial> onBuildObservable
        {
            get
            {
            if(__onBuildObservable == null)
            {
                __onBuildObservable = EventHorizonBlazorInterop.GetClass<Observable<NodeMaterial>>(
                    this.___guid,
                    "onBuildObservable",
                    (entity) =>
                    {
                        return new Observable<NodeMaterial>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBuildObservable;
            }
            set
            {
__onBuildObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBuildObservable",
                    value
                );
            }
        }

        
        public NodeMaterialBlock[] attachedBlocks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "attachedBlocks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attachedBlocks",
                    value
                );
            }
        }

        
        public string comment
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "comment"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "comment",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public NodeMaterial() : base() { }

        public NodeMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public NodeMaterial(
            string name, Scene scene = null, INodeMaterialOptions options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "NodeMaterial" },
                name, scene, options
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public NodeMaterialBlock getBlockByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBlockByName" }, name
                }
            );
        }

        public NodeMaterialBlock getBlockByPredicate(ActionResultCallback<NodeMaterialBlock, bool> predicate)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getBlockByPredicate" }, predicate
                }
            );
        }

        public InputBlock getInputBlockByPredicate(ActionResultCallback<InputBlock, bool> predicate)
        {
            return EventHorizonBlazorInterop.FuncClass<InputBlock>(
                entity => new InputBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getInputBlockByPredicate" }, predicate
                }
            );
        }

        public InputBlock[] getInputBlocks()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<InputBlock>(
                entity => new InputBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getInputBlocks" }
                }
            );
        }

        public NodeMaterial registerOptimizer(NodeMaterialOptimizer optimizer)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "registerOptimizer" }, optimizer
                }
            );
        }

        public NodeMaterial unregisterOptimizer(NodeMaterialOptimizer optimizer)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "unregisterOptimizer" }, optimizer
                }
            );
        }

        public NodeMaterial addOutputNode(NodeMaterialBlock node)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addOutputNode" }, node
                }
            );
        }

        public NodeMaterial removeOutputNode(NodeMaterialBlock node)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "removeOutputNode" }, node
                }
            );
        }

        public bool needAlphaBlending()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "needAlphaBlending" }
                }
            );
        }

        public bool needAlphaTesting()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "needAlphaTesting" }
                }
            );
        }

        public void removeBlock(NodeMaterialBlock block)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeBlock" }, block
                }
            );
        }

        public void build(System.Nullable<bool> verbose = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "build" }, verbose
                }
            );
        }

        public void optimize()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "optimize" }
                }
            );
        }

        public PostProcess createPostProcess(Camera camera, System.Nullable<decimal> options = null, System.Nullable<decimal> samplingMode = null, Engine engine = null, System.Nullable<bool> reusable = null, System.Nullable<decimal> textureType = null, System.Nullable<decimal> textureFormat = null)
        {
            return EventHorizonBlazorInterop.FuncClass<PostProcess>(
                entity => new PostProcess() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createPostProcess" }, camera, options, samplingMode, engine, reusable, textureType, textureFormat
                }
            );
        }

        public void createEffectForPostProcess(PostProcess postProcess)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createEffectForPostProcess" }, postProcess
                }
            );
        }

        public ProceduralTexture createProceduralTexture(decimal size, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createProceduralTexture" }, size, scene
                }
            );
        }

        public void createEffectForParticles(IParticleSystem particleSystem, ActionCallback<Effect> onCompiled = null, ActionCallback<Effect, string> onError = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createEffectForParticles" }, particleSystem, onCompiled, onError
                }
            );
        }

        public bool isReadyForSubMesh(AbstractMesh mesh, SubMesh subMesh, System.Nullable<bool> useInstances = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, mesh, subMesh, useInstances
                }
            );
        }

        public void bindOnlyWorldMatrix(Matrix world)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindOnlyWorldMatrix" }, world
                }
            );
        }

        public void bindForSubMesh(Matrix world, Mesh mesh, SubMesh subMesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindForSubMesh" }, world, mesh, subMesh
                }
            );
        }

        public BaseTexture[] getActiveTextures()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveTextures" }
                }
            );
        }

        public TextureBlock[] getTextureBlocks()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<TextureBlock>(
                entity => new TextureBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTextureBlocks" }
                }
            );
        }

        public bool hasTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public void dispose(System.Nullable<bool> forceDisposeEffect = null, System.Nullable<bool> forceDisposeTextures = null, System.Nullable<bool> notBoundToMesh = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeEffect, forceDisposeTextures, notBoundToMesh
                }
            );
        }

        public async ValueTask edit(INodeMaterialEditorOptions config = null)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "edit" }, config
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public void setToDefault()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setToDefault" }
                }
            );
        }

        public void setToDefaultPostProcess()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setToDefaultPostProcess" }
                }
            );
        }

        public void setToDefaultProceduralTexture()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setToDefaultProceduralTexture" }
                }
            );
        }

        public void setToDefaultParticle()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setToDefaultParticle" }
                }
            );
        }

        public async ValueTask loadAsync(string url)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadAsync" }, url
                }
            );
        }

        public string generateCode()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "generateCode" }
                }
            );
        }

        public CachedEntity serialize(NodeMaterialBlock[] selectedBlocks = null)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }, selectedBlocks
                }
            );
        }

        public void loadFromSerialization(object source, string rootUrl = null, System.Nullable<bool> merge = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "loadFromSerialization" }, source, rootUrl, merge
                }
            );
        }

        public NodeMaterial clone(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, name
                }
            );
        }
        #endregion
    }
}