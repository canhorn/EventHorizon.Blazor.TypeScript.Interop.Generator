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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AbstractScene>))]
    public class AbstractScene : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static async ValueTask AddParser(string name, ActionCallback<CachedEntity, Scene, AssetContainer, string> parser)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "AbstractScene", "AddParser" }, name, parser
                }
            );
        }

        public static async ValueTask<ActionCallback<CachedEntity, Scene, AssetContainer, string>> GetParser(string name)
        {
            return await EventHorizonBlazorInterop.Func<ActionCallback<CachedEntity, Scene, AssetContainer, string>>(
                new object[] 
                {
                    new string[] { "BABYLON", "AbstractScene", "GetParser" }, name
                }
            );
        }

        public static async ValueTask AddIndividualParser(string name, ActionCallback<CachedEntity, Scene, string> parser)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "AbstractScene", "AddIndividualParser" }, name, parser
                }
            );
        }

        public static async ValueTask<ActionCallback<CachedEntity, Scene, string>> GetIndividualParser(string name)
        {
            return await EventHorizonBlazorInterop.Func<ActionCallback<CachedEntity, Scene, string>>(
                new object[] 
                {
                    new string[] { "BABYLON", "AbstractScene", "GetIndividualParser" }, name
                }
            );
        }

        public static async ValueTask Parse(object jsonData, Scene scene, AssetContainer container, string rootUrl)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "AbstractScene", "Parse" }, jsonData, scene, container, rootUrl
                }
            );
        }
        #endregion

        #region Accessors
        private BaseTexture __environmentTexture;
        public async ValueTask<BaseTexture> get_environmentTexture()
        {
            if(__environmentTexture == null)
            {
                __environmentTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "environmentTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __environmentTexture;
        }
        public ValueTask set_environmentTexture(BaseTexture value)
        {
__environmentTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "environmentTexture",
                    value
                );
        }
        #endregion

        #region Properties
        
        public async ValueTask<Node[]> get_rootNodes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Node>(
                    this.___guid,
                    "rootNodes",
                    (entity) =>
                    {
                        return new Node() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_rootNodes(Node[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rootNodes",
                    value
                );
        }

        
        public async ValueTask<Camera[]> get_cameras()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Camera>(
                    this.___guid,
                    "cameras",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_cameras(Camera[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameras",
                    value
                );
        }

        
        public async ValueTask<Light[]> get_lights()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Light>(
                    this.___guid,
                    "lights",
                    (entity) =>
                    {
                        return new Light() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_lights(Light[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lights",
                    value
                );
        }

        
        public async ValueTask<AbstractMesh[]> get_meshes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "meshes",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_meshes(AbstractMesh[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "meshes",
                    value
                );
        }

        
        public async ValueTask<Skeleton[]> get_skeletons()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Skeleton>(
                    this.___guid,
                    "skeletons",
                    (entity) =>
                    {
                        return new Skeleton() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_skeletons(Skeleton[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skeletons",
                    value
                );
        }

        
        public async ValueTask<IParticleSystemCachedEntity[]> get_particleSystems()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<IParticleSystemCachedEntity>(
                    this.___guid,
                    "particleSystems",
                    (entity) =>
                    {
                        return new IParticleSystemCachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_particleSystems(IParticleSystemCachedEntity[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "particleSystems",
                    value
                );
        }

        
        public async ValueTask<Animation[]> get_animations()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_animations(Animation[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
        }

        
        public async ValueTask<AnimationGroup[]> get_animationGroups()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AnimationGroup>(
                    this.___guid,
                    "animationGroups",
                    (entity) =>
                    {
                        return new AnimationGroup() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_animationGroups(AnimationGroup[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationGroups",
                    value
                );
        }

        
        public async ValueTask<MultiMaterial[]> get_multiMaterials()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<MultiMaterial>(
                    this.___guid,
                    "multiMaterials",
                    (entity) =>
                    {
                        return new MultiMaterial() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_multiMaterials(MultiMaterial[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "multiMaterials",
                    value
                );
        }

        
        public async ValueTask<Material[]> get_materials()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Material>(
                    this.___guid,
                    "materials",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_materials(Material[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "materials",
                    value
                );
        }

        
        public async ValueTask<MorphTargetManager[]> get_morphTargetManagers()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<MorphTargetManager>(
                    this.___guid,
                    "morphTargetManagers",
                    (entity) =>
                    {
                        return new MorphTargetManager() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_morphTargetManagers(MorphTargetManager[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "morphTargetManagers",
                    value
                );
        }

        
        public async ValueTask<Geometry[]> get_geometries()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Geometry>(
                    this.___guid,
                    "geometries",
                    (entity) =>
                    {
                        return new Geometry() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_geometries(Geometry[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "geometries",
                    value
                );
        }

        
        public async ValueTask<TransformNode[]> get_transformNodes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<TransformNode>(
                    this.___guid,
                    "transformNodes",
                    (entity) =>
                    {
                        return new TransformNode() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_transformNodes(TransformNode[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transformNodes",
                    value
                );
        }

        
        public async ValueTask<AbstractActionManager[]> get_actionManagers()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AbstractActionManager>(
                    this.___guid,
                    "actionManagers",
                    (entity) =>
                    {
                        return new AbstractActionManager() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_actionManagers(AbstractActionManager[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "actionManagers",
                    value
                );
        }

        
        public async ValueTask<BaseTexture[]> get_textures()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<BaseTexture>(
                    this.___guid,
                    "textures",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_textures(BaseTexture[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textures",
                    value
                );
        }

        
        public async ValueTask<PostProcess[]> get_postProcesses()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<PostProcess>(
                    this.___guid,
                    "postProcesses",
                    (entity) =>
                    {
                        return new PostProcess() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_postProcesses(PostProcess[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "postProcesses",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public AbstractScene() : base() { } 

        public AbstractScene(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public async ValueTask<Node[]> getNodes()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Node>(
                entity => new Node() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getNodes" }
                }
            );
        }
        #endregion
    }
}