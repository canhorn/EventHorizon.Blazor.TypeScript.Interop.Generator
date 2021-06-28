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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AbstractScene>))]
    public class AbstractScene : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void AddParser(string name, ActionCallback<CachedEntity, Scene, AssetContainer, string> parser)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "AbstractScene", "AddParser" }, name, parser
                }
            );
        }

        public static ActionCallback<CachedEntity, Scene, AssetContainer, string> GetParser(string name)
        {
            return EventHorizonBlazorInterop.Func<ActionCallback<CachedEntity, Scene, AssetContainer, string>>(
                new object[]
                {
                    new string[] { "BABYLON", "AbstractScene", "GetParser" }, name
                }
            );
        }

        public static void AddIndividualParser(string name, ActionResultCallback<CachedEntity, Scene, string, CachedEntity> parser)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "AbstractScene", "AddIndividualParser" }, name, parser
                }
            );
        }

        public static ActionResultCallback<CachedEntity, Scene, string, CachedEntity> GetIndividualParser(string name)
        {
            return EventHorizonBlazorInterop.Func<ActionResultCallback<CachedEntity, Scene, string, CachedEntity>>(
                new object[]
                {
                    new string[] { "BABYLON", "AbstractScene", "GetIndividualParser" }, name
                }
            );
        }

        public static void Parse(object jsonData, Scene scene, AssetContainer container, string rootUrl)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "AbstractScene", "Parse" }, jsonData, scene, container, rootUrl
                }
            );
        }
        #endregion

        #region Accessors
        private BaseTexture __environmentTexture;
        public BaseTexture environmentTexture
        {
            get
            {
            if(__environmentTexture == null)
            {
                __environmentTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
            set
            {
__environmentTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "environmentTexture",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public Node[] rootNodes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Node>(
                    this.___guid,
                    "rootNodes",
                    (entity) =>
                    {
                        return new Node() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rootNodes",
                    value
                );
            }
        }

        
        public Camera[] cameras
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Camera>(
                    this.___guid,
                    "cameras",
                    (entity) =>
                    {
                        return new Camera() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameras",
                    value
                );
            }
        }

        
        public Light[] lights
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Light>(
                    this.___guid,
                    "lights",
                    (entity) =>
                    {
                        return new Light() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lights",
                    value
                );
            }
        }

        
        public AbstractMesh[] meshes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "meshes",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "meshes",
                    value
                );
            }
        }

        
        public Skeleton[] skeletons
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Skeleton>(
                    this.___guid,
                    "skeletons",
                    (entity) =>
                    {
                        return new Skeleton() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skeletons",
                    value
                );
            }
        }

        
        public IParticleSystemCachedEntity[] particleSystems
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IParticleSystemCachedEntity>(
                    this.___guid,
                    "particleSystems",
                    (entity) =>
                    {
                        return new IParticleSystemCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "particleSystems",
                    value
                );
            }
        }

        
        public Animation[] animations
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
            }
        }

        
        public AnimationGroup[] animationGroups
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AnimationGroup>(
                    this.___guid,
                    "animationGroups",
                    (entity) =>
                    {
                        return new AnimationGroup() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationGroups",
                    value
                );
            }
        }

        
        public MultiMaterial[] multiMaterials
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<MultiMaterial>(
                    this.___guid,
                    "multiMaterials",
                    (entity) =>
                    {
                        return new MultiMaterial() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "multiMaterials",
                    value
                );
            }
        }

        
        public Material[] materials
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Material>(
                    this.___guid,
                    "materials",
                    (entity) =>
                    {
                        return new Material() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "materials",
                    value
                );
            }
        }

        
        public MorphTargetManager[] morphTargetManagers
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<MorphTargetManager>(
                    this.___guid,
                    "morphTargetManagers",
                    (entity) =>
                    {
                        return new MorphTargetManager() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "morphTargetManagers",
                    value
                );
            }
        }

        
        public Geometry[] geometries
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Geometry>(
                    this.___guid,
                    "geometries",
                    (entity) =>
                    {
                        return new Geometry() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "geometries",
                    value
                );
            }
        }

        
        public TransformNode[] transformNodes
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<TransformNode>(
                    this.___guid,
                    "transformNodes",
                    (entity) =>
                    {
                        return new TransformNode() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "transformNodes",
                    value
                );
            }
        }

        
        public AbstractActionManager[] actionManagers
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AbstractActionManager>(
                    this.___guid,
                    "actionManagers",
                    (entity) =>
                    {
                        return new AbstractActionManager() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "actionManagers",
                    value
                );
            }
        }

        
        public BaseTexture[] textures
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<BaseTexture>(
                    this.___guid,
                    "textures",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textures",
                    value
                );
            }
        }

        
        public PostProcess[] postProcesses
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<PostProcess>(
                    this.___guid,
                    "postProcesses",
                    (entity) =>
                    {
                        return new PostProcess() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "postProcesses",
                    value
                );
            }
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
        public Node[] getNodes()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Node>(
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