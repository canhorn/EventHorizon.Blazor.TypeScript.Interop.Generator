/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<PostProcessManager>))]
    public class PostProcessManager : CachedEntityObject
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

        #endregion
        
        #region Constructor
        public PostProcessManager() : base() { } 

        public PostProcessManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<PostProcessManager> NewPostProcessManager(
            Scene scene
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "PostProcessManager" },
                scene
            );

            return new PostProcessManager(entity);
        }
        #endregion

        #region Methods
        public async ValueTask directRender(PostProcess[] postProcesses, InternalTexture targetTexture = null, System.Nullable<bool> forceFullscreenViewport = null, System.Nullable<decimal> faceIndex = null, System.Nullable<decimal> lodLevel = null, System.Nullable<bool> doNotBindFrambuffer = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "directRender" }, postProcesses, targetTexture, forceFullscreenViewport, faceIndex, lodLevel, doNotBindFrambuffer
                }
            );
        }

        public async ValueTask dispose()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}