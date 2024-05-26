using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BABYLON;
using BABYLON.GUI;
using EventHorizon.Blazor.BabylonJS.Model;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;

namespace EventHorizon.Blazor.BabylonJS.Pages
{
    public class CannonGroup
    {
        public AnimationGroup animationGroup { get; set; }
        public Particle smokeBlast { get; set; }
        public Sound sound { get; set; }
    }

    public partial class PirateFort : IDisposable
    {
        private IDictionary<string, AnimationGroup> _animationMap =
            new Dictionary<string, AnimationGroup>();
        private AnimationGroup _runningAnimation = null;

        private Engine _engine;
        private Scene _scene;

        private bool _pirateFortLoaded = false;
        private bool _cannonLoaded = false;

        private IDictionary<int, CannonGroup> _cannons = new Dictionary<int, CannonGroup>();
        private AbstractMesh[] _pirateFortMeshes;
        private AbstractMesh _cannon;
        private AnimationGroup[] _importedAnimGroups;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await CreateSceneAsync();
            }
        }

        public void Dispose()
        {
            _engine?.dispose();
        }

        public async Task CreateSceneAsync()
        {
            var canvas = Canvas.GetElementById("game-window");
            var engine = new Engine(canvas, true);

            // This creates a basic Babylon Scene object (non-mesh)
            var scene = new Scene(engine);

            scene.clearColor = new Color4(0.31m, 0.48m, 0.64m, 1);

            //add an arcRotateCamera to the scene
            var camera = new ArcRotateCamera(
                "camera",
                Tools.ToRadians(125),
                Tools.ToRadians(70),
                25,
                new Vector3(0, 3, 0),
                scene
            );
            camera.lowerRadiusLimit = 10;
            camera.upperRadiusLimit = 40;

            // This attaches the camera to the canvas
            camera.attachControl(true);

            //array for holding the cannon and "paired" animation group
            var cannonAnimationPairings = new Dictionary<string, string>();

            //array for holding readyToPlay status for the cannons
            var cannonReadyToPlay = new Dictionary<string, int>();

            //Load the tower assets
            var pirateFortImportEntity = await SceneLoader.ImportMeshAsync(
                "",
                "https://models.babylonjs.com/pirateFort/",
                "pirateFort.glb",
                scene
            );
            var pirateFortImport = pirateFortImportEntity.ToEntity<SceneLoaderImportMeshEntity>();
            pirateFortImport.meshes[0].name = "pirateFort";
            scene.getMeshByName("sea").material.needDepthPrePass = true;
            scene.getLightByName("Sun").intensity = 12;

            //Load the cannon model and create clones
            var cannonImportResult = (
                await SceneLoader.ImportMeshAsync(
                    "",
                    "https://models.babylonjs.com/pirateFort/",
                    "cannon.glb",
                    scene
                )
            ).ToEntity<SceneLoaderImportMeshEntity>();
            //remove the top level root node
            var cannon = cannonImportResult.meshes[0].getChildren()[0];
            cannon.setParent(null);
            cannonImportResult.meshes[0].dispose();

            //set the metadata of each mesh to filter on later
            var cannonMeshes = cannon.getChildMeshes();
            for (var i = 0; i < cannonMeshes.Length; i++)
            {
                var metadata = new NodeMetadata();
                metadata.name = "cannon";
                cannonMeshes[i].metadata = metadata;
            }

            var importedAnimGroups = cannonImportResult.animationGroups;

            //loop through all imported animation groups and copy the animation curve data to an array.
            var animations = new Animation[importedAnimGroups.Length];
            for (var i = 0; i < importedAnimGroups.Length; i++)
            {
                importedAnimGroups[i].stop();
                animations[i] = importedAnimGroups[i].targetedAnimations[0].animation;
                importedAnimGroups[i].dispose();
            }

            //create a new animation group and add targeted animations based on copied curve data from the "animations" array.
            var cannonAnimGroup = new AnimationGroup("cannonAnimGroup");
            cannonAnimGroup.addTargetedAnimation(animations[0], cannon.getChildMeshes()[1]);
            cannonAnimGroup.addTargetedAnimation(animations[1], cannon.getChildMeshes()[0]);

            //create a box for particle emission, position it at the muzzle of the cannon, turn off visibility and parent it to the cannon mesh
            var particleEmitter = MeshBuilder.CreateBox(
                "particleEmitter",
                new { size = 0.05 },
                scene
            );
            particleEmitter.position = new Vector3(0, 0.76m, 1.05m);
            particleEmitter.rotation.x = Tools.ToRadians(78.5m);
            particleEmitter.isVisible = false;
            particleEmitter.setParent(cannon.getChildMeshes()[1]);

            //load particle system from the snippet server and set the emitter to the particleEmitter. Set its stopDuration.
            var baseurl = Tools.BaseUrl;
            var smokeBlast = await ParticleHelper.CreateFromSnippetAsync(
                "LCBQ5Y#6",
                scene,
                false,
                ParticleHelper.SnippetUrl
            );
            smokeBlast.emitter = particleEmitter;
            smokeBlast.targetStopDuration = 0.2m;

            //load a cannon blast sound
            var cannonBlastSound = new Sound(
                "music",
                "https://assets.babylonjs.com/sound/cannonBlast.mp3",
                scene
            );

            //position and rotation data for the placement of the cannon clones
            var cannonPositionArray = new Vector3[][]
            {
                new Vector3[]
                {
                    new Vector3(0.97m, 5.52m, 1.79m),
                    new Vector3(Tools.ToRadians(0), Tools.ToRadians(0), Tools.ToRadians(180))
                },
                new Vector3[]
                {
                    new Vector3(1.08m, 2.32m, 3.05m),
                    new Vector3(Tools.ToRadians(0), Tools.ToRadians(0), Tools.ToRadians(180))
                },
                new Vector3[]
                {
                    new Vector3(1.46m, 2.35m, -0.73m),
                    new Vector3(Tools.ToRadians(0), Tools.ToRadians(90), Tools.ToRadians(180))
                },
                new Vector3[]
                {
                    new Vector3(1.45m, 5.52m, -1.66m),
                    new Vector3(Tools.ToRadians(0), Tools.ToRadians(90), Tools.ToRadians(180))
                },
                new Vector3[]
                {
                    new Vector3(1.49m, 8.69m, -0.35m),
                    new Vector3(Tools.ToRadians(0), Tools.ToRadians(90), Tools.ToRadians(180))
                },
                new Vector3[]
                {
                    new Vector3(-1.37m, 8.69m, -0.39m),
                    new Vector3(Tools.ToRadians(0), Tools.ToRadians(-90), Tools.ToRadians(180))
                },
                new Vector3[]
                {
                    new Vector3(0.58m, 4, -2.18m),
                    new Vector3(Tools.ToRadians(0), Tools.ToRadians(180), Tools.ToRadians(180))
                },
                new Vector3[]
                {
                    new Vector3(1.22m, 8.69m, -2.5m),
                    new Vector3(Tools.ToRadians(0), Tools.ToRadians(180), Tools.ToRadians(180))
                },
                new Vector3[]
                {
                    new Vector3(-1.31m, 2.33m, -2.45m),
                    new Vector3(Tools.ToRadians(0), Tools.ToRadians(180), Tools.ToRadians(180))
                },
                new Vector3[]
                {
                    new Vector3(-3.54m, 5.26m, -2.12m),
                    new Vector3(Tools.ToRadians(0), Tools.ToRadians(-90), Tools.ToRadians(180))
                }
            };

            //create 10 cannon clones, each with unique position/rotation data. Note that particle systems are cloned with parent meshes
            //also create 10 new animation groups with targeted animations applied to the newly cloned meshes
            for (var i = 0; i < 10; i++)
            {
                var cannonClone = cannon.clone<AbstractMesh>("cannonClone" + i);
                cannonClone.position = cannonPositionArray[i][0];
                cannonClone.rotation = cannonPositionArray[i][1];
                var cannonAnimGroupClone = new AnimationGroup("cannonAnimGroupClone" + i);
                cannonAnimGroupClone.addTargetedAnimation(
                    cannonAnimGroup.targetedAnimations[0].animation,
                    cannonClone.getChildMeshes()[1]
                );
                cannonAnimGroupClone.addTargetedAnimation(
                    cannonAnimGroup.targetedAnimations[1].animation,
                    cannonClone.getChildMeshes()[0]
                );

                //store a key/value pair of each clone name and the name of the associated animation group name.
                cannonAnimationPairings[cannonClone.name] = cannonAnimGroupClone.name;

                //store key/value pair for the cannon name and it's readyToPlay status as 1;
                cannonReadyToPlay[cannonClone.name] = 1;
            }
            //dispose of the original cannon, animation group, and particle system
            cannon.dispose();
            cannonAnimGroup.dispose();
            smokeBlast.dispose();

            //create an array for all particle systems in the scene, loop through it and stop all systems from playing.
            var smokeBlasts = scene.particleSystems;
            for (var i = 0; i < smokeBlasts.Length; i++)
            {
                smokeBlasts[i].stop();
            }

            //logic of what happens on a click
            scene.onPointerObservable.add(
                (pointerInfo, eventState) =>
                {
                    // PointerEventTypes.POINTERDOWN
                    if (pointerInfo.type != 1)
                    {
                        return Task.CompletedTask;
                    }
                    var pickResult = pointerInfo.pickInfo;
                    //check if a mesh was picked and if that mesh has specific metadata
                    if (pickResult.pickedMesh != null && pickResult.pickedMesh.metadata != null)
                    {
                        var metadataNode = pickResult.pickedMesh.metadata.ToEntity<NodeMetadata>();
                        if (metadataNode.name != "cannon")
                        {
                            return Task.CompletedTask;
                        }
                        //find the top level parent (necessary since the cannon is an extra layer below the clone root)
                        var topParent = pickResult.pickedMesh.parent;
                        if (topParent.parent != null && topParent.parent.name != null)
                        {
                            topParent = topParent.parent;
                        }
                        //wrap all 'play' elements into a check to make sure the cannon can be played.
                        if (cannonReadyToPlay[topParent.name] == 1)
                        {
                            //set the readyToPlay status to 0
                            cannonReadyToPlay[topParent.name] = 0;
                            //loop through all of the animation groups in the scene and play the correct group based on the top level parent of the picked mesh.
                            var animationToPlay = cannonAnimationPairings[topParent.name];
                            for (var i = 0; i < scene.animationGroups.Length; i++)
                            {
                                if (scene.animationGroups[i].name == animationToPlay)
                                {
                                    scene.animationGroups[i].play();
                                    //after the animation has finished, set the readyToPlay status for this cannon to 1;
                                    scene
                                        .animationGroups[i]
                                        .onAnimationGroupEndObservable.addOnce(
                                            (_, __) =>
                                            {
                                                cannonReadyToPlay[topParent.name] = 1;

                                                return Task.CompletedTask;
                                            }
                                        );
                                }
                            }
                            //loop through all particle systems in the scene, loop through all picked mesh submeshes. if there is a matching mesh and particle system emitter, start the particle system.
                            var childMeshes = pickResult.pickedMesh.getChildMeshes();
                            for (var i = 0; i < smokeBlasts.Length; i++)
                            {
                                for (var j = 0; j < childMeshes.Length; j++)
                                {
                                    if (childMeshes[j].___guid == smokeBlasts[i].emitter.___guid)
                                    {
                                        smokeBlasts[i].start();
                                    }
                                }
                            }
                            cannonBlastSound.play();
                        }
                    }

                    return Task.CompletedTask;
                }
            );
            //scene.onPointerDown = function(evt, pickResult) {
            //    //check if a mesh was picked and if that mesh has specific metadata
            //    if (pickResult.pickedMesh && pickResult.pickedMesh.metadata === "cannon")
            //    {
            //        //find the top level parent (necessary since the cannon is an extra layer below the clone root)
            //        var topParent = pickResult.pickedMesh.parent;
            //        if (topParent.parent)
            //        {
            //            topParent = topParent.parent;
            //        }

            //        //wrap all 'play' elements into a check to make sure the cannon can be played.
            //        if (cannonReadyToPlay[topParent.name] === 1)
            //        {
            //            //set the readyToPlay status to 0
            //            cannonReadyToPlay[topParent.name] = 0;
            //            //loop through all of the animation groups in the scene and play the correct group based on the top level parent of the picked mesh.
            //            var animationToPlay = cannonAnimationPairings[topParent.name];
            //            for (var i = 0; i < scene.animationGroups.length; i++)
            //            {
            //                if (scene.animationGroups[i].name === animationToPlay)
            //                {
            //                    scene.animationGroups[i].play();
            //                    //after the animation has finished, set the readyToPlay status for this cannon to 1;
            //                    scene.animationGroups[i].onAnimationGroupEndObservable.addOnce(() =>
            //                    {
            //                        cannonReadyToPlay[topParent.name] = 1;
            //                    });
            //                }
            //            }
            //            //loop through all particle systems in the scene, loop through all picked mesh submeshes. if there is a matching mesh and particle system emitter, start the particle system.
            //            var childMeshes = pickResult.pickedMesh.getChildMeshes();
            //            for (var i = 0; i < smokeBlasts.length; i++)
            //            {
            //                for (var j = 0; j < childMeshes.length; j++)
            //                {
            //                    if (childMeshes[j] === smokeBlasts[i].emitter)
            //                    {
            //                        smokeBlasts[i].start();
            //                    }
            //                }
            //            }
            //            cannonBlastSound.play();
            //        }
            //    }
            //};

            _scene = scene;
            _scene.activeCamera = camera;
            engine.runRenderLoop(
                new ActionCallback(() => Task.Run(() => _scene.render(true, false)))
            );

            _engine = engine;
        }
    }
}
