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

    
    
    [JsonConverter(typeof(CachedEntityConverter<AssetContainer>))]
    public class AssetContainer : AbstractScene
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        private Scene __scene;
        public Scene scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInterop.GetClass<Scene>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __scene;
            }
            set
            {
__scene = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public AssetContainer() : base() { }

        public AssetContainer(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public AssetContainer(
            Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "AssetContainer" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public InstantiatedEntries instantiateModelsToScene(ActionResultCallback<string, string> nameFunction = null, System.Nullable<bool> cloneMaterials = null)
        {
            return EventHorizonBlazorInterop.FuncClass<InstantiatedEntries>(
                entity => new InstantiatedEntries() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "instantiateModelsToScene" }, nameFunction, cloneMaterials
                }
            );
        }

        public void addAllToScene()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addAllToScene" }
                }
            );
        }

        public void removeAllFromScene()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeAllFromScene" }
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

        public void moveAllFromScene(KeepAssets keepAssets = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "moveAllFromScene" }, keepAssets
                }
            );
        }

        public Mesh createRootMesh()
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createRootMesh" }
                }
            );
        }

        public AnimationGroup[] mergeAnimationsTo(Animatable[] animatables, Scene scene = null, ActionResultCallback<CachedEntity, Node> targetConverter = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationGroup>(
                entity => new AnimationGroup() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "mergeAnimationsTo" }, scene, animatables, targetConverter
                }
            );
        }
        #endregion
    }
}