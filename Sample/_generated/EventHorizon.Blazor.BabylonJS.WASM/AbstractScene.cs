/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class AbstractScene : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void AddParser(string name, BabylonFileParser parser)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "AbstractScene", "AddParser" }, name, parser
                }
            );
        }

        public static BabylonFileParser GetParser(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<BabylonFileParser>(
                entity => new BabylonFileParser(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "AbstractScene", "GetParser" }, name
                }
            );
        }

        public static void AddIndividualParser(string name, IndividualBabylonFileParser parser)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "AbstractScene", "AddIndividualParser" }, name, parser
                }
            );
        }

        public static IndividualBabylonFileParser GetIndividualParser(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<IndividualBabylonFileParser>(
                entity => new IndividualBabylonFileParser(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "AbstractScene", "GetIndividualParser" }, name
                }
            );
        }

        public static void Parse(object jsonData, Scene scene, AssetContainer container, string rootUrl)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "AbstractScene", "Parse" }, jsonData, scene, container, rootUrl
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public Node[] rootNodes
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Node>(
                    this.___guid,
                    "rootNodes",
                    (entity) =>
                    {
                        return new Node(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<Camera>(
                    this.___guid,
                    "cameras",
                    (entity) =>
                    {
                        return new Camera(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<Light>(
                    this.___guid,
                    "lights",
                    (entity) =>
                    {
                        return new Light(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "meshes",
                    (entity) =>
                    {
                        return new AbstractMesh(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<Skeleton>(
                    this.___guid,
                    "skeletons",
                    (entity) =>
                    {
                        return new Skeleton(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "skeletons",
                    value
                );
            }
        }

        
        public IParticleSystem[] particleSystems
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<IParticleSystem>(
                    this.___guid,
                    "particleSystems",
                    (entity) =>
                    {
                        return new IParticleSystemCachedEntity(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<AnimationGroup>(
                    this.___guid,
                    "animationGroups",
                    (entity) =>
                    {
                        return new AnimationGroup(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<MultiMaterial>(
                    this.___guid,
                    "multiMaterials",
                    (entity) =>
                    {
                        return new MultiMaterial(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<Material>(
                    this.___guid,
                    "materials",
                    (entity) =>
                    {
                        return new Material(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<MorphTargetManager>(
                    this.___guid,
                    "morphTargetManagers",
                    (entity) =>
                    {
                        return new MorphTargetManager(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<Geometry>(
                    this.___guid,
                    "geometries",
                    (entity) =>
                    {
                        return new Geometry(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<TransformNode>(
                    this.___guid,
                    "transformNodes",
                    (entity) =>
                    {
                        return new TransformNode(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<AbstractActionManager>(
                    this.___guid,
                    "actionManagers",
                    (entity) =>
                    {
                        return new AbstractActionManager(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<BaseTexture>(
                    this.___guid,
                    "textures",
                    (entity) =>
                    {
                        return new BaseTexture(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "textures",
                    value
                );
            }
        }

        private BaseTexture __environmentTexture;
        public BaseTexture environmentTexture
        {
            get
            {
            if(__environmentTexture == null)
            {
                __environmentTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
                    this.___guid,
                    "environmentTexture",
                    (entity) =>
                    {
                        return new BaseTexture(entity);
                    }
                );
            }
            return __environmentTexture;
            }
            set
            {
__environmentTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "environmentTexture",
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
            return EventHorizonBlazorInteropt.FuncArrayClass<Node>(
                entity => new Node(entity),
                new object[]
                {
                    new string[] { this.___guid, "getNodes" }
                }
            );
        }
        #endregion
    }
}