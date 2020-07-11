/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IShadowGenerator { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
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
            return EventHorizonBlazorInteropt.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getShadowMap" }
                }
            );
        }

        public bool isReady(SubMesh subMesh, bool useInstances)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }, subMesh, useInstances
                }
            );
        }

        public void prepareDefines(MaterialDefines defines, decimal lightIndex)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "prepareDefines" }, defines, lightIndex
                }
            );
        }

        public void bindShadowLight(string lightIndex, Effect effect)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindShadowLight" }, lightIndex, effect
                }
            );
        }

        public Matrix getTransformMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getTransformMatrix" }
                }
            );
        }

        public void recreateShadowMap()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "recreateShadowMap" }
                }
            );
        }

        #region forceCompilation TODO: Get Comments as metadata identification
        private bool _isForceCompilationEnabled = false;
        private readonly IDictionary<string, Func<Task>> _forceCompilationActionMap = new Dictionary<string, Func<Task>>();

        public string forceCompilation(
            Func<Task> callback
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
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "forceCompilation",
                "CallForceCompilationActions",
                _invokableReference
            );
            _isForceCompilationEnabled = true;
        }

        [JSInvokable]
        public async Task CallForceCompilationActions()
        {
            foreach (var action in _forceCompilationActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public CachedEntity forceCompilationAsync(CachedEntity options = null)
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceCompilationAsync" }, options
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
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
        #endregion
    }
}