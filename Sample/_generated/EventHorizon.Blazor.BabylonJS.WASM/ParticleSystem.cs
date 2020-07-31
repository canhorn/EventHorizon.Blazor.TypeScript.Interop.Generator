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

    
    
    [JsonConverter(typeof(CachedEntityConverter<ParticleSystem>))]
    public class ParticleSystem : BaseParticleSystem
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal BILLBOARDMODE_Y
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ParticleSystem.BILLBOARDMODE_Y"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_ALL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ParticleSystem.BILLBOARDMODE_ALL"
                );
            }
        }

        
        public static decimal BILLBOARDMODE_STRETCHED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "ParticleSystem.BILLBOARDMODE_STRETCHED"
                );
            }
        }
        #endregion

        #region Static Methods
        public static ParticleSystem Parse(object parsedParticleSystem, Scene scene, string rootUrl, System.Nullable<bool> doNotStart = null)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleSystem>(
                entity => new ParticleSystem() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "ParticleSystem", "Parse" }, parsedParticleSystem, scene, rootUrl, doNotStart
                }
            );
        }
        #endregion

        #region Accessors
        
        public bool useRampGradients
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useRampGradients"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useRampGradients",
                    value
                );
            }
        }

        
        public Particle[] particles
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<Particle>(
                    this.___guid,
                    "particles",
                    (entity) =>
                    {
                        return new Particle() { ___guid = entity.___guid };
                    }
                );
            }
        }
        #endregion

        #region Properties
        private Observable<ParticleSystem> __onDisposeObservable;
        public Observable<ParticleSystem> onDisposeObservable
        {
            get
            {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = EventHorizonBlazorInterop.GetClass<Observable<ParticleSystem>>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable<ParticleSystem>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onDisposeObservable;
            }
            set
            {
__onDisposeObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
            }
        }

        
        public ParticleSystem[] subEmitters
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<ParticleSystem>(
                    this.___guid,
                    "subEmitters",
                    (entity) =>
                    {
                        return new ParticleSystem() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "subEmitters",
                    value
                );
            }
        }

        
        public ParticleSystem[] activeSubSystems
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<ParticleSystem>(
                    this.___guid,
                    "activeSubSystems",
                    (entity) =>
                    {
                        return new ParticleSystem() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "activeSubSystems",
                    value
                );
            }
        }

        
        public bool isLocal
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLocal"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isLocal",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ParticleSystem() : base() { }

        public ParticleSystem(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public ParticleSystem(
            string name, decimal capacity, Scene scene, Effect customEffect = null, System.Nullable<bool> isAnimationSheetEnabled = null, System.Nullable<decimal> epsilon = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "ParticleSystem" },
                name, capacity, scene, customEffect, isAnimationSheetEnabled, epsilon
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region updateFunction TODO: Get Comments as metadata identification
        private bool _isUpdateFunctionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _updateFunctionActionMap = new Dictionary<string, Func<Task>>();

        public string updateFunction(
            Func<Task> callback
        )
        {
            SetupUpdateFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _updateFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUpdateFunctionLoop()
        {
            if (_isUpdateFunctionEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "updateFunction",
                "CallUpdateFunctionActions",
                _invokableReference
            );
            _isUpdateFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallUpdateFunctionActions()
        {
            foreach (var action in _updateFunctionActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region startDirectionFunction TODO: Get Comments as metadata identification
        private bool _isStartDirectionFunctionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _startDirectionFunctionActionMap = new Dictionary<string, Func<Task>>();

        public string startDirectionFunction(
            Func<Task> callback
        )
        {
            SetupStartDirectionFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _startDirectionFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupStartDirectionFunctionLoop()
        {
            if (_isStartDirectionFunctionEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "startDirectionFunction",
                "CallStartDirectionFunctionActions",
                _invokableReference
            );
            _isStartDirectionFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallStartDirectionFunctionActions()
        {
            foreach (var action in _startDirectionFunctionActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region startPositionFunction TODO: Get Comments as metadata identification
        private bool _isStartPositionFunctionEnabled = false;
        private readonly IDictionary<string, Func<Task>> _startPositionFunctionActionMap = new Dictionary<string, Func<Task>>();

        public string startPositionFunction(
            Func<Task> callback
        )
        {
            SetupStartPositionFunctionLoop();

            var handle = Guid.NewGuid().ToString();
            _startPositionFunctionActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupStartPositionFunctionLoop()
        {
            if (_isStartPositionFunctionEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "startPositionFunction",
                "CallStartPositionFunctionActions",
                _invokableReference
            );
            _isStartPositionFunctionEnabled = true;
        }

        [JSInvokable]
        public async Task CallStartPositionFunctionActions()
        {
            foreach (var action in _startPositionFunctionActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public IParticleSystemCachedEntity addLifeTimeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addLifeTimeGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystemCachedEntity removeLifeTimeGradient(decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeLifeTimeGradient" }, gradient
                }
            );
        }

        public IParticleSystemCachedEntity addSizeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addSizeGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystemCachedEntity removeSizeGradient(decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeSizeGradient" }, gradient
                }
            );
        }

        public IParticleSystemCachedEntity addColorRemapGradient(decimal gradient, decimal min, decimal max)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addColorRemapGradient" }, gradient, min, max
                }
            );
        }

        public IParticleSystemCachedEntity removeColorRemapGradient(decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeColorRemapGradient" }, gradient
                }
            );
        }

        public IParticleSystemCachedEntity addAlphaRemapGradient(decimal gradient, decimal min, decimal max)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addAlphaRemapGradient" }, gradient, min, max
                }
            );
        }

        public IParticleSystemCachedEntity removeAlphaRemapGradient(decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeAlphaRemapGradient" }, gradient
                }
            );
        }

        public IParticleSystemCachedEntity addAngularSpeedGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addAngularSpeedGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystemCachedEntity removeAngularSpeedGradient(decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeAngularSpeedGradient" }, gradient
                }
            );
        }

        public IParticleSystemCachedEntity addVelocityGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addVelocityGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystemCachedEntity removeVelocityGradient(decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeVelocityGradient" }, gradient
                }
            );
        }

        public IParticleSystemCachedEntity addLimitVelocityGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addLimitVelocityGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystemCachedEntity removeLimitVelocityGradient(decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeLimitVelocityGradient" }, gradient
                }
            );
        }

        public IParticleSystemCachedEntity addDragGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addDragGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystemCachedEntity removeDragGradient(decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeDragGradient" }, gradient
                }
            );
        }

        public IParticleSystemCachedEntity addEmitRateGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addEmitRateGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystemCachedEntity removeEmitRateGradient(decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeEmitRateGradient" }, gradient
                }
            );
        }

        public IParticleSystemCachedEntity addStartSizeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addStartSizeGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystemCachedEntity removeStartSizeGradient(decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeStartSizeGradient" }, gradient
                }
            );
        }

        public Color3Gradient[] getRampGradients()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Color3Gradient>(
                entity => new Color3Gradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRampGradients" }
                }
            );
        }

        public ParticleSystem addRampGradient(decimal gradient, Color3 color)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleSystem>(
                entity => new ParticleSystem() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addRampGradient" }, gradient, color
                }
            );
        }

        public ParticleSystem removeRampGradient(decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleSystem>(
                entity => new ParticleSystem() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeRampGradient" }, gradient
                }
            );
        }

        public IParticleSystemCachedEntity addColorGradient(decimal gradient, Color4 color1, Color4 color2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addColorGradient" }, gradient, color1, color2
                }
            );
        }

        public IParticleSystemCachedEntity removeColorGradient(decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeColorGradient" }, gradient
                }
            );
        }

        public decimal getCapacity()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getCapacity" }
                }
            );
        }

        public bool isAlive()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isAlive" }
                }
            );
        }

        public bool isStarted()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isStarted" }
                }
            );
        }

        public void start(System.Nullable<decimal> delay = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "start" }, delay
                }
            );
        }

        public void stop(System.Nullable<bool> stopSubEmitters = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stop" }, stopSubEmitters
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        #region recycleParticle TODO: Get Comments as metadata identification
        private bool _isRecycleParticleEnabled = false;
        private readonly IDictionary<string, Func<Task>> _recycleParticleActionMap = new Dictionary<string, Func<Task>>();

        public string recycleParticle(
            Func<Task> callback
        )
        {
            SetupRecycleParticleLoop();

            var handle = Guid.NewGuid().ToString();
            _recycleParticleActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupRecycleParticleLoop()
        {
            if (_isRecycleParticleEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "recycleParticle",
                "CallRecycleParticleActions",
                _invokableReference
            );
            _isRecycleParticleEnabled = true;
        }

        [JSInvokable]
        public async Task CallRecycleParticleActions()
        {
            foreach (var action in _recycleParticleActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void animate(System.Nullable<bool> preWarmOnly = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "animate" }, preWarmOnly
                }
            );
        }

        public void rebuild()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "rebuild" }
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public decimal render()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }
                }
            );
        }

        public void dispose(System.Nullable<bool> disposeTexture = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, disposeTexture
                }
            );
        }

        public ParticleSystem clone(string name, object newEmitter)
        {
            return EventHorizonBlazorInterop.FuncClass<ParticleSystem>(
                entity => new ParticleSystem() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newEmitter
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
        #endregion
    }
}