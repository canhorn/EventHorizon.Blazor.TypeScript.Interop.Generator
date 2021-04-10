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

    
    
    [JsonConverter(typeof(CachedEntityConverter<NodeMaterial>))]
    public class NodeMaterial : PushMaterial
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<string> get_EditorURL()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "NodeMaterial.EditorURL"
                );
        }
        public static ValueTask set_EditorURL(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "NodeMaterial.EditorURL",
                    value
                );
        }

        
        public static async ValueTask<string> get_SnippetUrl()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "NodeMaterial.SnippetUrl"
                );
        }
        public static ValueTask set_SnippetUrl(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "NodeMaterial.SnippetUrl",
                    value
                );
        }

        
        public static async ValueTask<bool> get_IgnoreTexturesAtLoadTime()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "NodeMaterial.IgnoreTexturesAtLoadTime"
                );
        }
        public static ValueTask set_IgnoreTexturesAtLoadTime(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "NodeMaterial.IgnoreTexturesAtLoadTime",
                    value
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<NodeMaterial> Parse(object source, Scene scene, string rootUrl = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "NodeMaterial", "Parse" }, source, scene, rootUrl
                }
            );
        }

        public static async ValueTask<NodeMaterial> ParseFromFileAsync(string name, string url, Scene scene)
        {
            return await EventHorizonBlazorInterop.TaskClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "NodeMaterial", "ParseFromFileAsync" }, name, url, scene
                }
            );
        }

        public static async ValueTask<NodeMaterial> ParseFromSnippetAsync(string snippetId, Scene scene, string rootUrl = null, NodeMaterial nodeMaterial = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "NodeMaterial", "ParseFromSnippetAsync" }, snippetId, scene, rootUrl, nodeMaterial
                }
            );
        }

        public static async ValueTask<NodeMaterial> CreateDefault(string name, Scene scene = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
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
        public async ValueTask<INodeMaterialOptionsCachedEntity> get_options()
        {
            if(__options == null)
            {
                __options = await EventHorizonBlazorInterop.GetClass<INodeMaterialOptionsCachedEntity>(
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
        public ValueTask set_options(INodeMaterialOptionsCachedEntity value)
        {
__options = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "options",
                    value
                );
        }

        private ImageProcessingConfiguration __imageProcessingConfiguration;
        public async ValueTask<ImageProcessingConfiguration> get_imageProcessingConfiguration()
        {
            if(__imageProcessingConfiguration == null)
            {
                __imageProcessingConfiguration = await EventHorizonBlazorInterop.GetClass<ImageProcessingConfiguration>(
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
        public ValueTask set_imageProcessingConfiguration(ImageProcessingConfiguration value)
        {
__imageProcessingConfiguration = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageProcessingConfiguration",
                    value
                );
        }

        
        public async ValueTask<int> get_mode()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "mode"
                );
        }

        
        public async ValueTask<string> get_compiledShaders()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "compiledShaders"
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<string> get_snippetId()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "snippetId"
                );
        }
        public ValueTask set_snippetId(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "snippetId",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_editorData()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "editorData",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_editorData(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "editorData",
                    value
                );
        }

        
        public async ValueTask<bool> get_ignoreAlpha()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreAlpha"
                );
        }
        public ValueTask set_ignoreAlpha(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "ignoreAlpha",
                    value
                );
        }

        
        public async ValueTask<decimal> get_maxSimultaneousLights()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxSimultaneousLights"
                );
        }
        public ValueTask set_maxSimultaneousLights(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxSimultaneousLights",
                    value
                );
        }

        private Observable<NodeMaterial> __onBuildObservable;
        public async ValueTask<Observable<NodeMaterial>> get_onBuildObservable()
        {
            if(__onBuildObservable == null)
            {
                __onBuildObservable = await EventHorizonBlazorInterop.GetClass<Observable<NodeMaterial>>(
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
        public ValueTask set_onBuildObservable(Observable<NodeMaterial> value)
        {
__onBuildObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBuildObservable",
                    value
                );
        }

        
        public async ValueTask<NodeMaterialBlock[]> get_attachedBlocks()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "attachedBlocks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_attachedBlocks(NodeMaterialBlock[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attachedBlocks",
                    value
                );
        }

        
        public async ValueTask<string> get_comment()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "comment"
                );
        }
        public ValueTask set_comment(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "comment",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public NodeMaterial() : base() { }

        public NodeMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public static async ValueTask<NodeMaterial> NewNodeMaterial(
            string name, Scene scene = null, INodeMaterialOptions options = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "NodeMaterial" },
                name, scene, options
            );

            return new NodeMaterial(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<NodeMaterialBlock> getBlockByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getBlockByName" }, name
                }
            );
        }

        public async ValueTask<NodeMaterialBlock> getBlockByPredicate(ActionCallback<NodeMaterialBlock> predicate)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterialBlock>(
                entity => new NodeMaterialBlock() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getBlockByPredicate" }, predicate
                }
            );
        }

        public async ValueTask<InputBlock> getInputBlockByPredicate(ActionCallback<InputBlock> predicate)
        {
            return await EventHorizonBlazorInterop.FuncClass<InputBlock>(
                entity => new InputBlock() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getInputBlockByPredicate" }, predicate
                }
            );
        }

        public async ValueTask<InputBlock[]> getInputBlocks()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<InputBlock>(
                entity => new InputBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getInputBlocks" }
                }
            );
        }

        public async ValueTask<NodeMaterial> registerOptimizer(NodeMaterialOptimizer optimizer)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "registerOptimizer" }, optimizer
                }
            );
        }

        public async ValueTask<NodeMaterial> unregisterOptimizer(NodeMaterialOptimizer optimizer)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "unregisterOptimizer" }, optimizer
                }
            );
        }

        public async ValueTask<NodeMaterial> addOutputNode(NodeMaterialBlock node)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addOutputNode" }, node
                }
            );
        }

        public async ValueTask<NodeMaterial> removeOutputNode(NodeMaterialBlock node)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
                entity => new NodeMaterial() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeOutputNode" }, node
                }
            );
        }

        public async ValueTask<bool> needAlphaBlending()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaBlending" }
                }
            );
        }

        public async ValueTask<bool> needAlphaTesting()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "needAlphaTesting" }
                }
            );
        }

        public async ValueTask removeBlock(NodeMaterialBlock block)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeBlock" }, block
                }
            );
        }

        public async ValueTask build(System.Nullable<bool> verbose = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "build" }, verbose
                }
            );
        }

        public async ValueTask optimize()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "optimize" }
                }
            );
        }

        public async ValueTask<PostProcess> createPostProcess(Camera camera, System.Nullable<decimal> options = null, System.Nullable<decimal> samplingMode = null, Engine engine = null, System.Nullable<bool> reusable = null, System.Nullable<decimal> textureType = null, System.Nullable<decimal> textureFormat = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<PostProcess>(
                entity => new PostProcess() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createPostProcess" }, camera, options, samplingMode, engine, reusable, textureType, textureFormat
                }
            );
        }

        public async ValueTask createEffectForPostProcess(PostProcess postProcess)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "createEffectForPostProcess" }, postProcess
                }
            );
        }

        public async ValueTask<ProceduralTexture> createProceduralTexture(decimal size, Scene scene)
        {
            return await EventHorizonBlazorInterop.FuncClass<ProceduralTexture>(
                entity => new ProceduralTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createProceduralTexture" }, size, scene
                }
            );
        }

        public async ValueTask createEffectForParticles(IParticleSystem particleSystem, ActionCallback<Effect> onCompiled = null, ActionCallback<Effect, string> onError = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "createEffectForParticles" }, particleSystem, onCompiled, onError
                }
            );
        }

        public async ValueTask<bool> isReadyForSubMesh(AbstractMesh mesh, SubMesh subMesh, System.Nullable<bool> useInstances = null)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, mesh, subMesh, useInstances
                }
            );
        }

        public async ValueTask bindOnlyWorldMatrix(Matrix world)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindOnlyWorldMatrix" }, world
                }
            );
        }

        public async ValueTask bindForSubMesh(Matrix world, Mesh mesh, SubMesh subMesh)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindForSubMesh" }, world, mesh, subMesh
                }
            );
        }

        public async ValueTask<BaseTexture[]> getActiveTextures()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<BaseTexture>(
                entity => new BaseTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getActiveTextures" }
                }
            );
        }

        public async ValueTask<TextureBlock[]> getTextureBlocks()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<TextureBlock>(
                entity => new TextureBlock() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getTextureBlocks" }
                }
            );
        }

        public async ValueTask<bool> hasTexture(BaseTexture texture)
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> forceDisposeEffect = null, System.Nullable<bool> forceDisposeTextures = null, System.Nullable<bool> notBoundToMesh = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask clear()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public async ValueTask setToDefault()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setToDefault" }
                }
            );
        }

        public async ValueTask setToDefaultPostProcess()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setToDefaultPostProcess" }
                }
            );
        }

        public async ValueTask setToDefaultProceduralTexture()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setToDefaultProceduralTexture" }
                }
            );
        }

        public async ValueTask setToDefaultParticle()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
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

        public async ValueTask<string> generateCode()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "generateCode" }
                }
            );
        }

        public async ValueTask<CachedEntity> serialize(NodeMaterialBlock[] selectedBlocks = null)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, selectedBlocks
                }
            );
        }

        public async ValueTask loadFromSerialization(object source, string rootUrl = null, System.Nullable<bool> merge = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "loadFromSerialization" }, source, rootUrl, merge
                }
            );
        }

        public async ValueTask<NodeMaterial> clone(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<NodeMaterial>(
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