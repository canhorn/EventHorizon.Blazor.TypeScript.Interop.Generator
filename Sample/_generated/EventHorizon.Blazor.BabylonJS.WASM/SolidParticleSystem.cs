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
    public class SolidParticleSystem : CachedEntityObject, IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public bool isAlwaysVisible
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isAlwaysVisible"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isAlwaysVisible",
                    value
                );
            }
        }

        
        public bool isVisibilityBoxLocked
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isVisibilityBoxLocked"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isVisibilityBoxLocked",
                    value
                );
            }
        }

        
        public bool computeParticleRotation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "computeParticleRotation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "computeParticleRotation",
                    value
                );
            }
        }

        
        public bool computeParticleColor
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "computeParticleColor"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "computeParticleColor",
                    value
                );
            }
        }

        
        public bool computeParticleTexture
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "computeParticleTexture"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "computeParticleTexture",
                    value
                );
            }
        }

        
        public bool computeParticleVertex
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "computeParticleVertex"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "computeParticleVertex",
                    value
                );
            }
        }

        
        public bool computeBoundingBox
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "computeBoundingBox"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "computeBoundingBox",
                    value
                );
            }
        }

        
        public bool depthSortParticles
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "depthSortParticles"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "depthSortParticles",
                    value
                );
            }
        }

        
        public bool expandable
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "expandable"
                );
            }
        }

        
        public bool multimaterialEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "multimaterialEnabled"
                );
            }
        }

        
        public bool useModelMaterial
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useModelMaterial"
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
        }

        private MultiMaterial __multimaterial;
        public MultiMaterial multimaterial
        {
            get
            {
            if(__multimaterial == null)
            {
                __multimaterial = EventHorizonBlazorInteropt.GetClass<MultiMaterial>(
                    this.___guid,
                    "multimaterial",
                    (entity) =>
                    {
                        return new MultiMaterial(entity);
                    }
                );
            }
            return __multimaterial;
            }
            set
            {
__multimaterial = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "multimaterial",
                    value
                );
            }
        }

        
        public bool autoUpdateSubMeshes
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "autoUpdateSubMeshes"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "autoUpdateSubMeshes",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public SolidParticle[] particles
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<SolidParticle>(
                    this.___guid,
                    "particles",
                    (entity) =>
                    {
                        return new SolidParticle(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "particles",
                    value
                );
            }
        }

        
        public decimal nbParticles
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "nbParticles"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "nbParticles",
                    value
                );
            }
        }

        
        public bool billboard
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "billboard"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "billboard",
                    value
                );
            }
        }

        
        public bool recomputeNormals
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "recomputeNormals"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "recomputeNormals",
                    value
                );
            }
        }

        
        public decimal counter
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "counter"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "counter",
                    value
                );
            }
        }

        
        public string name
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        private Mesh __mesh;
        public Mesh mesh
        {
            get
            {
            if(__mesh == null)
            {
                __mesh = EventHorizonBlazorInteropt.GetClass<Mesh>(
                    this.___guid,
                    "mesh",
                    (entity) =>
                    {
                        return new Mesh(entity);
                    }
                );
            }
            return __mesh;
            }
            set
            {
__mesh = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "mesh",
                    value
                );
            }
        }

        
        public CachedEntity vars
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "vars"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "vars",
                    value
                );
            }
        }

        
        public CachedEntity[] pickedParticles
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<CachedEntity>(
                    this.___guid,
                    "pickedParticles"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "pickedParticles",
                    value
                );
            }
        }

        
        public DepthSortedParticle[] depthSortedParticles
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<DepthSortedParticle>(
                    this.___guid,
                    "depthSortedParticles",
                    (entity) =>
                    {
                        return new DepthSortedParticle(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "depthSortedParticles",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SolidParticleSystem() : base() { }

        public SolidParticleSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SolidParticleSystem(
            string name, Scene scene, CachedEntity options = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "SolidParticleSystem" },
                name, scene, options
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Mesh buildMesh()
        {
            return EventHorizonBlazorInteropt.FuncClass<Mesh>(
                entity => new Mesh(entity),
                new object[] 
                {
                    new string[] { this.___guid, "buildMesh" }
                }
            );
        }

        public CachedEntity digest(Mesh mesh, CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "digest" }, mesh, options
                }
            );
        }

        public decimal addShape(Mesh mesh, decimal nb, CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "addShape" }, mesh, nb, options
                }
            );
        }

        public SolidParticleSystem rebuildMesh(System.Nullable<bool> reset = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<SolidParticleSystem>(
                entity => new SolidParticleSystem(entity),
                new object[] 
                {
                    new string[] { this.___guid, "rebuildMesh" }, reset
                }
            );
        }

        public SolidParticle[] removeParticles(decimal start, decimal end)
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<SolidParticle>(
                entity => new SolidParticle(entity),
                new object[]
                {
                    new string[] { this.___guid, "removeParticles" }, start, end
                }
            );
        }

        public SolidParticleSystem insertParticlesFromArray(SolidParticle[] solidParticleArray)
        {
            return EventHorizonBlazorInteropt.FuncClass<SolidParticleSystem>(
                entity => new SolidParticleSystem(entity),
                new object[] 
                {
                    new string[] { this.___guid, "insertParticlesFromArray" }, solidParticleArray
                }
            );
        }

        public SolidParticleSystem setParticles(System.Nullable<decimal> start = null, System.Nullable<decimal> end = null, System.Nullable<bool> update = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<SolidParticleSystem>(
                entity => new SolidParticleSystem(entity),
                new object[] 
                {
                    new string[] { this.___guid, "setParticles" }, start, end, update
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public SolidParticle getParticleById(decimal id)
        {
            return EventHorizonBlazorInteropt.FuncClass<SolidParticle>(
                entity => new SolidParticle(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getParticleById" }, id
                }
            );
        }

        public SolidParticle[] getParticlesByShapeId(decimal shapeId)
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<SolidParticle>(
                entity => new SolidParticle(entity),
                new object[]
                {
                    new string[] { this.___guid, "getParticlesByShapeId" }, shapeId
                }
            );
        }

        public SolidParticleSystem getParticlesByShapeIdToRef(decimal shapeId, SolidParticle[] @ref)
        {
            return EventHorizonBlazorInteropt.FuncClass<SolidParticleSystem>(
                entity => new SolidParticleSystem(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getParticlesByShapeIdToRef" }, shapeId, @ref
                }
            );
        }

        public SolidParticleSystem computeSubMeshes()
        {
            return EventHorizonBlazorInteropt.FuncClass<SolidParticleSystem>(
                entity => new SolidParticleSystem(entity),
                new object[] 
                {
                    new string[] { this.___guid, "computeSubMeshes" }
                }
            );
        }

        public SolidParticleSystem refreshVisibleSize()
        {
            return EventHorizonBlazorInteropt.FuncClass<SolidParticleSystem>(
                entity => new SolidParticleSystem(entity),
                new object[] 
                {
                    new string[] { this.___guid, "refreshVisibleSize" }
                }
            );
        }

        public void setVisibilityBox(decimal size)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setVisibilityBox" }, size
                }
            );
        }

        public void setMultiMaterial(Material[] materials)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setMultiMaterial" }, materials
                }
            );
        }

        public void initParticles()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "initParticles" }
                }
            );
        }

        public SolidParticle recycleParticle(SolidParticle particle)
        {
            return EventHorizonBlazorInteropt.FuncClass<SolidParticle>(
                entity => new SolidParticle(entity),
                new object[] 
                {
                    new string[] { this.___guid, "recycleParticle" }, particle
                }
            );
        }

        public SolidParticle updateParticle(SolidParticle particle)
        {
            return EventHorizonBlazorInteropt.FuncClass<SolidParticle>(
                entity => new SolidParticle(entity),
                new object[] 
                {
                    new string[] { this.___guid, "updateParticle" }, particle
                }
            );
        }

        public Vector3 updateParticleVertex(SolidParticle particle, Vector3 vertex, decimal pt)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "updateParticleVertex" }, particle, vertex, pt
                }
            );
        }

        public void beforeUpdateParticles(System.Nullable<decimal> start = null, System.Nullable<decimal> stop = null, System.Nullable<bool> update = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "beforeUpdateParticles" }, start, stop, update
                }
            );
        }

        public void afterUpdateParticles(System.Nullable<decimal> start = null, System.Nullable<decimal> stop = null, System.Nullable<bool> update = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "afterUpdateParticles" }, start, stop, update
                }
            );
        }
        #endregion
    }
}