/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<MorphTargetManager>))]
    public class MorphTargetManager : CachedEntityObject, _IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        public static async ValueTask<bool> get_EnableTextureStorage()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                "BABYLON",
                "MorphTargetManager.EnableTextureStorage"
            );
        }

        public static ValueTask set_EnableTextureStorage(bool value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "MorphTargetManager.EnableTextureStorage",
                value
            );
        }

        public static async ValueTask<decimal> get_MaxActiveMorphTargetsInVertexAttributeMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                "BABYLON",
                "MorphTargetManager.MaxActiveMorphTargetsInVertexAttributeMode"
            );
        }

        public static ValueTask set_MaxActiveMorphTargetsInVertexAttributeMode(decimal value)
        {
            return EventHorizonBlazorInterop.Set(
                "BABYLON",
                "MorphTargetManager.MaxActiveMorphTargetsInVertexAttributeMode",
                value
            );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<MorphTargetManager> Parse(
            object serializationObject,
            Scene scene
        )
        {
            return await EventHorizonBlazorInterop.FuncClass<MorphTargetManager>(
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

        public async ValueTask<bool> get_areUpdatesFrozen()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "areUpdatesFrozen");
        }

        public ValueTask set_areUpdatesFrozen(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "areUpdatesFrozen", value);
        }

        public async ValueTask<decimal> get_numMaxInfluencers()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "numMaxInfluencers");
        }

        public ValueTask set_numMaxInfluencers(decimal value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "numMaxInfluencers", value);
        }

        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "uniqueId");
        }

        public async ValueTask<decimal> get_vertexCount()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "vertexCount");
        }

        public async ValueTask<bool> get_supportsNormals()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "supportsNormals");
        }

        public async ValueTask<bool> get_supportsTangents()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "supportsTangents");
        }

        public async ValueTask<bool> get_supportsUVs()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "supportsUVs");
        }

        public async ValueTask<decimal> get_numTargets()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "numTargets");
        }

        public async ValueTask<decimal> get_numInfluencers()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(this.___guid, "numInfluencers");
        }

        public async ValueTask<decimal[]> get_influences()
        {
            return await EventHorizonBlazorInterop.GetArray<decimal>(this.___guid, "influences");
        }

        public async ValueTask<bool> get_useTextureToStoreTargets()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "useTextureToStoreTargets"
            );
        }

        public ValueTask set_useTextureToStoreTargets(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "useTextureToStoreTargets", value);
        }

        public async ValueTask<bool> get_isUsingTextureForTargets()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                this.___guid,
                "isUsingTextureForTargets"
            );
        }
        #endregion

        #region Properties

        public async ValueTask<bool> get_optimizeInfluencers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "optimizeInfluencers");
        }

        public ValueTask set_optimizeInfluencers(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "optimizeInfluencers", value);
        }

        public async ValueTask<bool> get_enableNormalMorphing()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "enableNormalMorphing");
        }

        public ValueTask set_enableNormalMorphing(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "enableNormalMorphing", value);
        }

        public async ValueTask<bool> get_enableTangentMorphing()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "enableTangentMorphing");
        }

        public ValueTask set_enableTangentMorphing(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "enableTangentMorphing", value);
        }

        public async ValueTask<bool> get_enableUVMorphing()
        {
            return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "enableUVMorphing");
        }

        public ValueTask set_enableUVMorphing(bool value)
        {
            return EventHorizonBlazorInterop.Set(this.___guid, "enableUVMorphing", value);
        }
        #endregion

        #region Constructor
        public MorphTargetManager()
            : base() { }

        public MorphTargetManager(ICachedEntity entity)
            : base(entity) { }

        public static async ValueTask<MorphTargetManager> NewMorphTargetManager(Scene scene = null)
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MorphTargetManager" },
                scene
            );

            return new MorphTargetManager(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<MorphTarget> getActiveTarget(decimal index)
        {
            return await EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getActiveTarget" }, index }
            );
        }

        public async ValueTask<MorphTarget> getTarget(decimal index)
        {
            return await EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getTarget" }, index }
            );
        }

        public async ValueTask<MorphTarget> getTargetByName(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "getTargetByName" }, name }
            );
        }

        public async ValueTask addTarget(MorphTarget target)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "addTarget" }, target }
            );
        }

        public async ValueTask removeTarget(MorphTarget target)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "removeTarget" }, target }
            );
        }

        public async ValueTask<MorphTargetManager> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<MorphTargetManager>(
                entity => new MorphTargetManager() { ___guid = entity.___guid },
                new object[] { new string[] { this.___guid, "clone" } }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "serialize" } }
            );
        }

        public async ValueTask synchronize()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "synchronize" } }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "dispose" } }
            );
        }
        #endregion
    }
}
