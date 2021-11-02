namespace EventHorizon.Maui.BabylonJS.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BABYLON;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Maui.BabylonJS.Model;

    public class CannonGroup
    {
        public AnimationGroup animationGroup { get; set; }
        public Particle smokeBlast { get; set; }
        public Sound sound { get; set; }
    }

    public partial class PirateFort : IAsyncDisposable
    {
        private IDictionary<string, AnimationGroup> _animationMap = new Dictionary<string, AnimationGroup>();
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
                await InvokeAsync(async () =>
                {
                    await CreateSceneAsync();
                });
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (_engine is not null)
            {
                await _engine.dispose();
            }
        }

        public async Task CreateSceneAsync()
        {
            var canvas = await Canvas.GetElementById(
                "game-window"
            );
            var engine = await Engine.NewEngine(
                canvas,
                true
            );

            // This creates a basic Babylon Scene object (non-mesh)
            var scene = await Scene.NewScene(engine);

            await scene.set_clearColor(
                await Color4.NewColor4(
                    0.31m,
                    0.48m,
                    0.64m,
                    1
                )
            );

            //add an arcRotateCamera to the scene
            var camera = await ArcRotateCamera.NewArcRotateCamera(
                "camera",
                await Tools.ToRadians(125),
                await Tools.ToRadians(70), 25,
                await Vector3.NewVector3(0, 3, 0),
                scene
            );
            await camera.set_lowerRadiusLimit(10);
            await camera.set_upperRadiusLimit(40);

            // This attaches the camera to the canvas
            await camera.attachControl(true);

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
            var meshes = await pirateFortImport.get_meshes();
            await meshes[0].set_name("pirateFort");
            var seaMesh = await scene.getMeshByName("sea");
            await (await seaMesh.get_material()).set_needDepthPrePass(true);
            await (await scene.getLightByName("Sun")).set_intensity(12);

            //Load the cannon model and create clones
            var cannonImportResult = (await SceneLoader.ImportMeshAsync(
                "",
                "https://models.babylonjs.com/pirateFort/",
                "cannon.glb",
                scene
            )).ToEntity<SceneLoaderImportMeshEntity>();
            //remove the top level root node
            var cannonMeshs = await cannonImportResult.get_meshes();
            var cannon = (await cannonMeshs[0].getChildren())[0];
            await cannon.setParent(null);
            await cannonMeshs[0].dispose();

            //set the metadata of each mesh to filter on later
            var cannonMeshes = await cannon.getChildMeshes();
            for (var i = 0; i < cannonMeshes.Length; i++)
            {
                var metadata = await NodeMetadata.NewNodeMetadata();
                await metadata.set_name("cannon");
                await cannonMeshes[i].set_metadata(metadata);
            }

            var importedAnimGroups = await cannonImportResult.get_animationGroups();

            //loop through all imported animation groups and copy the animation curve data to an array.
            var animations = new Animation[importedAnimGroups.Length];
            for (var i = 0; i < importedAnimGroups.Length; i++)
            {
                await importedAnimGroups[i].stop();
                animations[i] = await (await importedAnimGroups[i].get_targetedAnimations())[0].get_animation();
                await importedAnimGroups[i].dispose();
            }

            //create a new animation group and add targeted animations based on copied curve data from the "animations" array.
            var cannonAnimGroup = await AnimationGroup.NewAnimationGroup(
                "cannonAnimGroup"
            );
            await cannonAnimGroup.addTargetedAnimation(
                animations[0],
                (await cannon.getChildMeshes())[1]
            );
            await cannonAnimGroup.addTargetedAnimation(
                animations[1],
                (await cannon.getChildMeshes())[0]
            );

            //create a box for particle emission, position it at the muzzle of the cannon, turn off visibility and parent it to the cannon mesh
            var particleEmitter = await MeshBuilder.CreateBox(
                "particleEmitter",
                new { size = 0.05 },
                scene
            );
            await particleEmitter.set_position(await Vector3.NewVector3(
                0,
                0.76m,
                1.05m
            ));
            await (await particleEmitter.get_rotation()).set_x(await Tools.ToRadians(78.5m));
            await particleEmitter.set_isVisible(false);
            await particleEmitter.setParent(
                (await cannon.getChildMeshes())[1]
            );

            //load particle system from the snippet server and set the emitter to the particleEmitter. Set its stopDuration.
            var baseurl = await Tools.get_BaseUrl();
            var snippetUrl = await ParticleHelper.get_SnippetUrl();
            var smokeBlast = await ParticleHelper.CreateFromSnippetAsync(
                "LCBQ5Y#6",
                scene,
                false,
                await ParticleHelper.get_SnippetUrl()
            );
            await smokeBlast.set_emitter(particleEmitter);
            await smokeBlast.set_targetStopDuration(0.2m);

            //load a cannon blast sound
            var cannonBlastSound = await Sound.NewSound(
                "music",
                "https://assets.babylonjs.com/sound/cannonBlast.mp3",
                scene
            );

            //position and rotation data for the placement of the cannon clones
            var cannonPositionArray = new Vector3[][] {

                new Vector3[]
                {
                    await Vector3.NewVector3(0.97m, 5.52m, 1.79m),
                    await Vector3.NewVector3(await Tools.ToRadians(0), await Tools.ToRadians(0), await Tools.ToRadians(180)) },

                new Vector3[]
                {
                    await Vector3.NewVector3(1.08m, 2.32m, 3.05m),
                    await Vector3.NewVector3(await Tools.ToRadians(0), await Tools.ToRadians(0), await Tools.ToRadians(180)) },

                new Vector3[]
                {
                    await Vector3.NewVector3(1.46m, 2.35m, -0.73m),
                    await Vector3.NewVector3(await Tools.ToRadians(0), await Tools.ToRadians(90), await Tools.ToRadians(180)) },

                new Vector3[]
                {
                    await Vector3.NewVector3(1.45m, 5.52m, -1.66m),
                    await Vector3.NewVector3(await Tools.ToRadians(0), await Tools.ToRadians(90), await Tools.ToRadians(180)) },

                new Vector3[]
                {
                    await Vector3.NewVector3(1.49m, 8.69m, -0.35m),
                    await Vector3.NewVector3(await Tools.ToRadians(0), await Tools.ToRadians(90), await Tools.ToRadians(180)) },

                new Vector3[]
                {
                    await Vector3.NewVector3(-1.37m, 8.69m, -0.39m),
                    await Vector3.NewVector3(await Tools.ToRadians(0), await Tools.ToRadians(-90), await Tools.ToRadians(180)) },

                new Vector3[]
                {
                    await Vector3.NewVector3(0.58m, 4, -2.18m),
                    await Vector3.NewVector3(await Tools.ToRadians(0), await Tools.ToRadians(180), await Tools.ToRadians(180)) },

                new Vector3[]
                {
                    await Vector3.NewVector3(1.22m, 8.69m, -2.5m),
                    await Vector3.NewVector3(await Tools.ToRadians(0), await Tools.ToRadians(180), await Tools.ToRadians(180)) },

                new Vector3[]
                {
                    await Vector3.NewVector3(-1.31m, 2.33m, -2.45m),
                    await Vector3.NewVector3(await Tools.ToRadians(0), await Tools.ToRadians(180), await Tools.ToRadians(180)) },

                new Vector3[]
                {
                    await Vector3.NewVector3(-3.54m, 5.26m, -2.12m),
                    await Vector3.NewVector3(await Tools.ToRadians(0), await Tools.ToRadians(-90), await Tools.ToRadians(180)) }
            };

            //create 10 cannon clones, each with unique position/rotation data. Note that particle systems are cloned with parent meshes
            //also create 10 new animation groups with targeted animations applied to the newly cloned meshes
            for (var i = 0; i < 10; i++)
            {
                var cannonClone = await cannon.clone<AbstractMesh>(
                    "cannonClone" + i
                );
                await cannonClone.set_position(cannonPositionArray[i][0]);
                await cannonClone.set_rotation(cannonPositionArray[i][1]);
                var cannonAnimGroupClone = await AnimationGroup.NewAnimationGroup(
                    "cannonAnimGroupClone" + i
                );
                await cannonAnimGroupClone.addTargetedAnimation(
                    await (await cannonAnimGroup.get_targetedAnimations())[0].get_animation(),
                    (await cannonClone.getChildMeshes())[1]);
                await cannonAnimGroupClone.addTargetedAnimation(
                    await (await cannonAnimGroup.get_targetedAnimations())[1].get_animation(),
                    (await cannonClone.getChildMeshes())[0]);

                //store a key/value pair of each clone name and the name of the associated animation group name.
                cannonAnimationPairings[await cannonClone.get_name()] = await cannonAnimGroupClone.get_name();

                //store key/value pair for the cannon name and it's readyToPlay status as 1;
                cannonReadyToPlay[await cannonClone.get_name()] = 1;

            }
            //dispose of the original cannon, animation group, and particle system
            await cannon.dispose();
            await cannonAnimGroup.dispose();
            await smokeBlast.dispose();

            //create an array for all particle systems in the scene, loop through it and stop all systems from playing.
            var smokeBlasts = await scene.get_particleSystems();
            for (var i = 0; i < smokeBlasts.Length; i++)
            {
                await smokeBlasts[i].stop();
            }

            //logic of what happens on a click
            await (await scene.get_onPointerObservable()).add(async (pointerInfo, eventState) =>
            {
                // PointerEventTypes.POINTERDOWN
                if (await pointerInfo.get_type() != 1)
                {
                    return;
                }
                var pickResult = await pointerInfo.get_pickInfo();
                //check if a mesh was picked and if that mesh has specific metadata
                var pickedMesh = await pickResult.get_pickedMesh();
                if (pickedMesh != null
                    && await pickedMesh.get_metadata() != null)
                {
                    var metadataNode = (await pickedMesh.get_metadata()).ToEntity<NodeMetadata>();
                    if (await metadataNode.get_name() != "cannon")
                    {
                        return;
                    }
                    //find the top level parent (necessary since the cannon is an extra layer below the clone root)
                    var topParent = await (await pickResult.get_pickedMesh()).get_parent();
                    var parent = await topParent.get_parent();
                    if (parent != null
                        && await parent.get_name() != null)
                    {
                        topParent = parent;
                    }
                    var name = await topParent.get_name();
                    //wrap all 'play' elements into a check to make sure the cannon can be played.
                    if (cannonReadyToPlay[name] == 1)
                    {
                        //set the readyToPlay status to 0
                        cannonReadyToPlay[name] = 0;
                        //loop through all of the animation groups in the scene and play the correct group based on the top level parent of the picked mesh.
                        var animationToPlay = cannonAnimationPairings[name];
                        for (var i = 0; i < (await scene.get_animationGroups()).Length; i++)
                        {
                            if (await (await scene.get_animationGroups())[i].get_name() == animationToPlay)
                            {
                                await (await scene.get_animationGroups())[i].play();
                                //after the animation has finished, set the readyToPlay status for this cannon to 1;
                                await (await (await scene.get_animationGroups())[i].get_onAnimationGroupEndObservable()).addOnce(async (_, __) =>
                               {
                                   cannonReadyToPlay[await topParent.get_name()] = 1;
                               });
                            }
                        }
                        //loop through all particle systems in the scene, loop through all picked mesh submeshes. if there is a matching mesh and particle system emitter, start the particle system.
                        var childMeshes = await (await pickResult.get_pickedMesh()).getChildMeshes();
                        for (var i = 0; i < smokeBlasts.Length; i++)
                        {
                            for (var j = 0; j < childMeshes.Length; j++)
                            {
                                if (childMeshes[j].___guid == (await smokeBlasts[i].get_emitter()).___guid)
                                {
                                    await smokeBlasts[i].start();
                                }
                            }
                        }
                        await cannonBlastSound.play();
                    }
                }
            });
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
            await _scene.set_activeCamera(camera);
            await engine.runRenderLoop(new ActionCallback(
                () => Task.Run(() => _scene.render(true, false))
            ));

            _engine = engine;

            await Canvas.RemoveBlur(
                "game-window"
            );
        }
    }
}
