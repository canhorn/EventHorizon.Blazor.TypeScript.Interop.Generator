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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MeshBuilder>))]
    public class MeshBuilder : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Mesh CreateBox(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateBox" }, name, options, scene
                }
            );
        }

        public static Mesh CreateTiledBox(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateTiledBox" }, name, options, scene
                }
            );
        }

        public static Mesh CreateSphere(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateSphere" }, name, options, scene
                }
            );
        }

        public static Mesh CreateDisc(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateDisc" }, name, options, scene
                }
            );
        }

        public static Mesh CreateIcoSphere(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateIcoSphere" }, name, options, scene
                }
            );
        }

        public static Mesh CreateRibbon(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateRibbon" }, name, options, scene
                }
            );
        }

        public static Mesh CreateCylinder(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateCylinder" }, name, options, scene
                }
            );
        }

        public static Mesh CreateTorus(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateTorus" }, name, options, scene
                }
            );
        }

        public static Mesh CreateTorusKnot(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateTorusKnot" }, name, options, scene
                }
            );
        }

        public static LinesMesh CreateLineSystem(string name, object options, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<LinesMesh>(
                entity => new LinesMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateLineSystem" }, name, options, scene
                }
            );
        }

        public static LinesMesh CreateLines(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LinesMesh>(
                entity => new LinesMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateLines" }, name, options, scene
                }
            );
        }

        public static LinesMesh CreateDashedLines(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<LinesMesh>(
                entity => new LinesMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateDashedLines" }, name, options, scene
                }
            );
        }

        public static Mesh ExtrudeShape(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "ExtrudeShape" }, name, options, scene
                }
            );
        }

        public static Mesh ExtrudeShapeCustom(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "ExtrudeShapeCustom" }, name, options, scene
                }
            );
        }

        public static Mesh CreateLathe(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateLathe" }, name, options, scene
                }
            );
        }

        public static Mesh CreateTiledPlane(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateTiledPlane" }, name, options, scene
                }
            );
        }

        public static Mesh CreatePlane(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreatePlane" }, name, options, scene
                }
            );
        }

        public static Mesh CreateGround(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateGround" }, name, options, scene
                }
            );
        }

        public static Mesh CreateTiledGround(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateTiledGround" }, name, options, scene
                }
            );
        }

        public static GroundMesh CreateGroundFromHeightMap(string name, string url, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<GroundMesh>(
                entity => new GroundMesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateGroundFromHeightMap" }, name, url, options, scene
                }
            );
        }

        public static Mesh CreatePolygon(string name, object options, Scene scene = null, object earcutInjection = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreatePolygon" }, name, options, scene, earcutInjection
                }
            );
        }

        public static Mesh ExtrudePolygon(string name, object options, Scene scene = null, object earcutInjection = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "ExtrudePolygon" }, name, options, scene, earcutInjection
                }
            );
        }

        public static Mesh CreateTube(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateTube" }, name, options, scene
                }
            );
        }

        public static Mesh CreatePolyhedron(string name, object options, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreatePolyhedron" }, name, options, scene
                }
            );
        }

        public static Mesh CreateDecal(string name, AbstractMesh sourceMesh, object options)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateDecal" }, name, sourceMesh, options
                }
            );
        }

        public static Mesh CreateCapsule(string name, ICreateCapsuleOptions options = null, Scene scene = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Mesh>(
                entity => new Mesh() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MeshBuilder", "CreateCapsule" }, name, options, scene
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public MeshBuilder() : base() { }

        public MeshBuilder(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}