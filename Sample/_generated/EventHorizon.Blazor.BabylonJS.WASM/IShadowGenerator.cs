/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using Microsoft.JSInterop;

    public interface IShadowGenerator : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IShadowGeneratorCachedEntity>))]
    public class IShadowGeneratorCachedEntity : CachedEntityObject, IShadowGenerator
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
        public IShadowGeneratorCachedEntity() : base() { }

        public IShadowGeneratorCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public RenderTargetTexture getShadowMap()
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getShadowMap" }
                }
            );
        }

        public bool isReady(SubMesh subMesh, bool useInstances)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, subMesh, useInstances
                }
            );
        }

        public void prepareDefines(MaterialDefines defines, decimal lightIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareDefines" }, defines, lightIndex
                }
            );
        }

        public void bindShadowLight(string lightIndex, Effect effect)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindShadowLight" }, lightIndex, effect
                }
            );
        }

        public Matrix getTransformMatrix()
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTransformMatrix" }
                }
            );
        }

        public void recreateShadowMap()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "recreateShadowMap" }
                }
            );
        }

        #region forceCompilation TODO: Get Comments as metadata identification
        private bool _isForceCompilationEnabled = false;
        private readonly IDictionary<string, Func<IShadowGeneratorCachedEntity, Task>> _forceCompilationActionMap = new Dictionary<string, Func<IShadowGeneratorCachedEntity, Task>>();

        public string forceCompilation(
            Func<IShadowGeneratorCachedEntity, Task> callback
        )
        {
            SetupForceCompilationLoop();

            var handle = Guid.NewGuid().ToString();
            _forceCompilationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupForceCompilationLoop()
        {
            if (_isForceCompilationEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "forceCompilation",
                "CallForceCompilationActions",
                _invokableReference
            );
            _isForceCompilationEnabled = true;
        }

        [JSInvokable]
        public async Task CallForceCompilationActions(IShadowGeneratorCachedEntity generator)
        {
            foreach (var action in _forceCompilationActionMap.Values)
            {
                await action(generator);
            }
        }
        #endregion

        public void forceCompilationAsync(object options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceCompilationAsync" }, options
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
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
        #endregion
    }
}