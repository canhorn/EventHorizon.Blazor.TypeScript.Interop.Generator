namespace EventHorizon.Blazor.BabylonJS.Model
{
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using BABYLON;
    using EventHorizon.Blazor.Server.Interop;

    [JsonConverter(typeof(CachedEntityConverter<SceneLoaderImportMeshEntity>))]
    public class SceneLoaderImportMeshEntity
        : CachedEntity
    {

        public async ValueTask<AbstractMesh[]> get_meshes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                this.___guid,
                "meshes",
                entity => new AbstractMesh() { ___guid = entity.___guid }
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

        public async ValueTask<AnimationGroup[]> get_animationGroups()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AnimationGroup>(
                this.___guid,
                "animationGroups",
                entity => new AnimationGroup() { ___guid = entity.___guid }
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

        //#region Static Accessors

        //#endregion

        //#region Static Properties

        //#endregion

        //#region Static Methods

        //#endregion

        //#region Accessors

        //#endregion

        //#region Properties

        //public bool isRecording
        //{
        //    get
        //    {
        //        return EventHorizonBlazorInterop.Get<bool>(
        //                this.___guid,
        //                "isRecording"
        //            );
        //    }
        //    set
        //    {

        //        EventHorizonBlazorInterop.Set(
        //            this.___guid,
        //            "isRecording",
        //            value
        //        );
        //    }
        //}
        //#endregion

        //#region Constructor
        //public HTMLCanvasElementCachedEntity() : base() { }

        //public HTMLCanvasElementCachedEntity(
        //    ICachedEntity entity
        //) : base(entity)
        //{
        //}


        //#endregion

        //#region Methods
        //public void requestPointerLock()
        //{
        //    EventHorizonBlazorInterop.Func<CachedEntity>(
        //        new object[]
        //        {
        //            new string[] { this.___guid, "requestPointerLock" }
        //        }
        //    );
        //}

        //public void msRequestPointerLock()
        //{
        //    EventHorizonBlazorInterop.Func<CachedEntity>(
        //        new object[]
        //        {
        //            new string[] { this.___guid, "msRequestPointerLock" }
        //        }
        //    );
        //}

        //public void mozRequestPointerLock()
        //{
        //    EventHorizonBlazorInterop.Func<CachedEntity>(
        //        new object[]
        //        {
        //            new string[] { this.___guid, "mozRequestPointerLock" }
        //        }
        //    );
        //}

        //public void webkitRequestPointerLock()
        //{
        //    EventHorizonBlazorInterop.Func<CachedEntity>(
        //        new object[]
        //        {
        //            new string[] { this.___guid, "webkitRequestPointerLock" }
        //        }
        //    );
        //}

        //public MediaStream captureStream(System.Nullable<decimal> fps = null)
        //{
        //    return EventHorizonBlazorInterop.FuncClass<MediaStream>(
        //        entity => new MediaStream() { ___guid = entity.___guid },
        //        new object[]
        //        {
        //            new string[] { this.___guid, "captureStream" }, fps
        //        }
        //    );
        //}
        //#endregion
    }
}
