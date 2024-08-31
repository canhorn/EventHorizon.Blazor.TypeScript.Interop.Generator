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

    [JsonConverter(typeof(CachedEntityConverter<MorphTargetManager>))]
    public class MorphTargetManager : CachedEntityObject, _IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static bool EnableTextureStorage
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "MorphTargetManager.EnableTextureStorage"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "MorphTargetManager.EnableTextureStorage",
                    value
                );
            }
        }

        public static decimal MaxActiveMorphTargetsInVertexAttributeMode
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "MorphTargetManager.MaxActiveMorphTargetsInVertexAttributeMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "MorphTargetManager.MaxActiveMorphTargetsInVertexAttributeMode",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static MorphTargetManager Parse(object serializationObject, Scene scene)
        {
            return EventHorizonBlazorInterop.FuncClass<MorphTargetManager>(
                entity => new MorphTargetManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "MorphTargetManager", "Parse" },
                    serializationObject,
                    scene
                }
            );
        }
        #endregion

        #region Accessors

        public bool areUpdatesFrozen
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "areUpdatesFrozen"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "areUpdatesFrozen", value);
            }
        }

        public decimal numMaxInfluencers
        {
            get
            {
                return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "numMaxInfluencers");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "numMaxInfluencers", value);
            }
        }

        public decimal uniqueId
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "uniqueId"); }
        }

        public decimal vertexCount
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "vertexCount"); }
        }

        public bool supportsNormals
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "supportsNormals"); }
        }

        public bool supportsTangents
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "supportsTangents"); }
        }

        public bool supportsUVs
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "supportsUVs"); }
        }

        public decimal numTargets
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "numTargets"); }
        }

        public decimal numInfluencers
        {
            get { return EventHorizonBlazorInterop.Get<decimal>(this.___guid, "numInfluencers"); }
        }

        public decimal[] influences
        {
            get { return EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "influences"); }
        }

        public bool useTextureToStoreTargets
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useTextureToStoreTargets"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "useTextureToStoreTargets", value);
            }
        }

        public bool isUsingTextureForTargets
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isUsingTextureForTargets"
                );
            }
        }
        #endregion

        #region Properties

        public bool optimizeInfluencers
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "optimizeInfluencers"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "optimizeInfluencers", value);
            }
        }

        public bool enableNormalMorphing
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "enableNormalMorphing");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "enableNormalMorphing", value);
            }
        }

        public bool enableTangentMorphing
        {
            get
            {
                return EventHorizonBlazorInterop.Get<bool>(this.___guid, "enableTangentMorphing");
            }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "enableTangentMorphing", value);
            }
        }

        public bool enableUVMorphing
        {
            get { return EventHorizonBlazorInterop.Get<bool>(this.___guid, "enableUVMorphing"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "enableUVMorphing", value);
            }
        }
        #endregion

        #region Constructor
        public MorphTargetManager()
            : base() { }

        public MorphTargetManager(ICachedEntity entity)
            : base(entity) { }

        public MorphTargetManager(Scene scene = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MorphTargetManager" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public MorphTarget getActiveTarget(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getActiveTarget" }, index }
            );
        }

        public MorphTarget getTarget(decimal index)
        {
            return EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getTarget" }, index }
            );
        }

        public MorphTarget getTargetByName(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getTargetByName" }, name }
            );
        }

        public void addTarget(MorphTarget target)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addTarget" }, target }
            );
        }

        public void removeTarget(MorphTarget target)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeTarget" }, target }
            );
        }

        public MorphTargetManager clone()
        {
            return EventHorizonBlazorInterop.FuncClass<MorphTargetManager>(
                entity => new MorphTargetManager() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
            );
        }

        public void synchronize()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "synchronize" } }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
