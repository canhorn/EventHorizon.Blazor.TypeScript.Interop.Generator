/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IParticleSystem { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IParticleSystemCachedEntity : CachedEntityObject, IParticleSystem
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
        
        public Animation[] animations
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "animations",
                    value
                );
            }
        }

        
        public string id
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "id",
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

        private Vector3 __emitter;
        public Vector3 emitter
        {
            get
            {
            if(__emitter == null)
            {
                __emitter = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "emitter",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __emitter;
            }
            set
            {
__emitter = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "emitter",
                    value
                );
            }
        }

        
        public bool isBillboardBased
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isBillboardBased"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isBillboardBased",
                    value
                );
            }
        }

        
        public decimal renderingGroupId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "renderingGroupId"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "renderingGroupId",
                    value
                );
            }
        }

        
        public decimal layerMask
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "layerMask",
                    value
                );
            }
        }

        
        public decimal updateSpeed
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "updateSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "updateSpeed",
                    value
                );
            }
        }

        
        public decimal targetStopDuration
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "targetStopDuration"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "targetStopDuration",
                    value
                );
            }
        }

        private Texture __particleTexture;
        public Texture particleTexture
        {
            get
            {
            if(__particleTexture == null)
            {
                __particleTexture = EventHorizonBlazorInteropt.GetClass<Texture>(
                    this.___guid,
                    "particleTexture",
                    (entity) =>
                    {
                        return new Texture(entity);
                    }
                );
            }
            return __particleTexture;
            }
            set
            {
__particleTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "particleTexture",
                    value
                );
            }
        }

        
        public decimal blendMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "blendMode",
                    value
                );
            }
        }

        
        public decimal minLifeTime
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "minLifeTime"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "minLifeTime",
                    value
                );
            }
        }

        
        public decimal maxLifeTime
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxLifeTime"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxLifeTime",
                    value
                );
            }
        }

        
        public decimal minSize
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "minSize"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "minSize",
                    value
                );
            }
        }

        
        public decimal maxSize
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxSize"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxSize",
                    value
                );
            }
        }

        
        public decimal minScaleX
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "minScaleX"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "minScaleX",
                    value
                );
            }
        }

        
        public decimal maxScaleX
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxScaleX"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxScaleX",
                    value
                );
            }
        }

        
        public decimal minScaleY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "minScaleY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "minScaleY",
                    value
                );
            }
        }

        
        public decimal maxScaleY
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxScaleY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxScaleY",
                    value
                );
            }
        }

        private Color4 __color1;
        public Color4 color1
        {
            get
            {
            if(__color1 == null)
            {
                __color1 = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "color1",
                    (entity) =>
                    {
                        return new Color4(entity);
                    }
                );
            }
            return __color1;
            }
            set
            {
__color1 = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "color1",
                    value
                );
            }
        }

        private Color4 __color2;
        public Color4 color2
        {
            get
            {
            if(__color2 == null)
            {
                __color2 = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "color2",
                    (entity) =>
                    {
                        return new Color4(entity);
                    }
                );
            }
            return __color2;
            }
            set
            {
__color2 = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "color2",
                    value
                );
            }
        }

        private Color4 __colorDead;
        public Color4 colorDead
        {
            get
            {
            if(__colorDead == null)
            {
                __colorDead = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "colorDead",
                    (entity) =>
                    {
                        return new Color4(entity);
                    }
                );
            }
            return __colorDead;
            }
            set
            {
__colorDead = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "colorDead",
                    value
                );
            }
        }

        
        public decimal emitRate
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "emitRate"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "emitRate",
                    value
                );
            }
        }

        private Vector3 __gravity;
        public Vector3 gravity
        {
            get
            {
            if(__gravity == null)
            {
                __gravity = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "gravity",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __gravity;
            }
            set
            {
__gravity = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "gravity",
                    value
                );
            }
        }

        
        public decimal minEmitPower
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "minEmitPower"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "minEmitPower",
                    value
                );
            }
        }

        
        public decimal maxEmitPower
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxEmitPower"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxEmitPower",
                    value
                );
            }
        }

        
        public decimal minAngularSpeed
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "minAngularSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "minAngularSpeed",
                    value
                );
            }
        }

        
        public decimal maxAngularSpeed
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxAngularSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxAngularSpeed",
                    value
                );
            }
        }

        
        public decimal minInitialRotation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "minInitialRotation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "minInitialRotation",
                    value
                );
            }
        }

        
        public decimal maxInitialRotation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "maxInitialRotation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "maxInitialRotation",
                    value
                );
            }
        }

        private IParticleEmitterType __particleEmitterType;
        public IParticleEmitterType particleEmitterType
        {
            get
            {
            if(__particleEmitterType == null)
            {
                __particleEmitterType = EventHorizonBlazorInteropt.GetClass<IParticleEmitterType>(
                    this.___guid,
                    "particleEmitterType",
                    (entity) =>
                    {
                        return new IParticleEmitterTypeCachedEntity(entity);
                    }
                );
            }
            return __particleEmitterType;
            }
            set
            {
__particleEmitterType = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "particleEmitterType",
                    value
                );
            }
        }

        
        public decimal startDelay
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "startDelay"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "startDelay",
                    value
                );
            }
        }

        
        public decimal preWarmCycles
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "preWarmCycles"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "preWarmCycles",
                    value
                );
            }
        }

        
        public decimal preWarmStepOffset
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "preWarmStepOffset"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "preWarmStepOffset",
                    value
                );
            }
        }

        
        public decimal spriteCellChangeSpeed
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "spriteCellChangeSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "spriteCellChangeSpeed",
                    value
                );
            }
        }

        
        public decimal startSpriteCellID
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "startSpriteCellID"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "startSpriteCellID",
                    value
                );
            }
        }

        
        public decimal endSpriteCellID
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "endSpriteCellID"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "endSpriteCellID",
                    value
                );
            }
        }

        
        public decimal spriteCellWidth
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "spriteCellWidth"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "spriteCellWidth",
                    value
                );
            }
        }

        
        public decimal spriteCellHeight
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "spriteCellHeight"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "spriteCellHeight",
                    value
                );
            }
        }

        
        public bool spriteRandomStartCell
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "spriteRandomStartCell"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "spriteRandomStartCell",
                    value
                );
            }
        }

        
        public bool isAnimationSheetEnabled
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isAnimationSheetEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isAnimationSheetEnabled",
                    value
                );
            }
        }

        private Vector2 __translationPivot;
        public Vector2 translationPivot
        {
            get
            {
            if(__translationPivot == null)
            {
                __translationPivot = EventHorizonBlazorInteropt.GetClass<Vector2>(
                    this.___guid,
                    "translationPivot",
                    (entity) =>
                    {
                        return new Vector2(entity);
                    }
                );
            }
            return __translationPivot;
            }
            set
            {
__translationPivot = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "translationPivot",
                    value
                );
            }
        }

        private BaseTexture __noiseTexture;
        public BaseTexture noiseTexture
        {
            get
            {
            if(__noiseTexture == null)
            {
                __noiseTexture = EventHorizonBlazorInteropt.GetClass<BaseTexture>(
                    this.___guid,
                    "noiseTexture",
                    (entity) =>
                    {
                        return new BaseTexture(entity);
                    }
                );
            }
            return __noiseTexture;
            }
            set
            {
__noiseTexture = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "noiseTexture",
                    value
                );
            }
        }

        private Vector3 __noiseStrength;
        public Vector3 noiseStrength
        {
            get
            {
            if(__noiseStrength == null)
            {
                __noiseStrength = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "noiseStrength",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __noiseStrength;
            }
            set
            {
__noiseStrength = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "noiseStrength",
                    value
                );
            }
        }

        
        public decimal billboardMode
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "billboardMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "billboardMode",
                    value
                );
            }
        }

        
        public decimal limitVelocityDamping
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "limitVelocityDamping"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "limitVelocityDamping",
                    value
                );
            }
        }

        
        public bool beginAnimationOnStart
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "beginAnimationOnStart"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "beginAnimationOnStart",
                    value
                );
            }
        }

        
        public decimal beginAnimationFrom
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "beginAnimationFrom"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "beginAnimationFrom",
                    value
                );
            }
        }

        
        public decimal beginAnimationTo
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "beginAnimationTo"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "beginAnimationTo",
                    value
                );
            }
        }

        
        public bool beginAnimationLoop
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "beginAnimationLoop"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "beginAnimationLoop",
                    value
                );
            }
        }

        
        public bool disposeOnStop
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "disposeOnStop"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "disposeOnStop",
                    value
                );
            }
        }

        
        public bool isLocal
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isLocal"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isLocal",
                    value
                );
            }
        }

        
        public bool useRampGradients
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useRampGradients"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useRampGradients",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IParticleSystemCachedEntity() : base() { }

        public IParticleSystemCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public decimal getCapacity()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getCapacity" }
                }
            );
        }

        public bool isStarted()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isStarted" }
                }
            );
        }

        public void animate()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "animate" }
                }
            );
        }

        public decimal render()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }
                }
            );
        }

        public void dispose(System.Nullable<bool> disposeTexture = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, disposeTexture
                }
            );
        }

        public IParticleSystem clone(string name, object newEmitter)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newEmitter
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

        public void rebuild()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "rebuild" }
                }
            );
        }

        public void start(System.Nullable<decimal> delay = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "start" }, delay
                }
            );
        }

        public void stop()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public void reset()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public bool isReady()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public IParticleSystem addColorGradient(decimal gradient, Color4 color1, Color4 color2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addColorGradient" }, gradient, color1, color2
                }
            );
        }

        public IParticleSystem removeColorGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeColorGradient" }, gradient
                }
            );
        }

        public IParticleSystem addSizeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addSizeGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeSizeGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeSizeGradient" }, gradient
                }
            );
        }

        public ColorGradient[] getColorGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<ColorGradient>(
                entity => new ColorGradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getColorGradients" }
                }
            );
        }

        public FactorGradient[] getSizeGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getSizeGradients" }
                }
            );
        }

        public FactorGradient[] getAngularSpeedGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getAngularSpeedGradients" }
                }
            );
        }

        public IParticleSystem addAngularSpeedGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addAngularSpeedGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeAngularSpeedGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeAngularSpeedGradient" }, gradient
                }
            );
        }

        public FactorGradient[] getVelocityGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getVelocityGradients" }
                }
            );
        }

        public IParticleSystem addVelocityGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addVelocityGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeVelocityGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeVelocityGradient" }, gradient
                }
            );
        }

        public FactorGradient[] getLimitVelocityGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getLimitVelocityGradients" }
                }
            );
        }

        public IParticleSystem addLimitVelocityGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addLimitVelocityGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeLimitVelocityGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeLimitVelocityGradient" }, gradient
                }
            );
        }

        public IParticleSystem addDragGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addDragGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeDragGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeDragGradient" }, gradient
                }
            );
        }

        public FactorGradient[] getDragGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getDragGradients" }
                }
            );
        }

        public IParticleSystem addEmitRateGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addEmitRateGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeEmitRateGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeEmitRateGradient" }, gradient
                }
            );
        }

        public FactorGradient[] getEmitRateGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getEmitRateGradients" }
                }
            );
        }

        public IParticleSystem addStartSizeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addStartSizeGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeStartSizeGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeStartSizeGradient" }, gradient
                }
            );
        }

        public FactorGradient[] getStartSizeGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getStartSizeGradients" }
                }
            );
        }

        public IParticleSystem addLifeTimeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addLifeTimeGradient" }, gradient, factor, factor2
                }
            );
        }

        public IParticleSystem removeLifeTimeGradient(decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "removeLifeTimeGradient" }, gradient
                }
            );
        }

        public FactorGradient[] getLifeTimeGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getLifeTimeGradients" }
                }
            );
        }

        public IParticleSystem addRampGradient(decimal gradient, Color3 color)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addRampGradient" }, gradient, color
                }
            );
        }

        public Color3Gradient[] getRampGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<Color3Gradient>(
                entity => new Color3Gradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getRampGradients" }
                }
            );
        }

        public IParticleSystem addColorRemapGradient(decimal gradient, decimal min, decimal max)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addColorRemapGradient" }, gradient, min, max
                }
            );
        }

        public FactorGradient[] getColorRemapGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getColorRemapGradients" }
                }
            );
        }

        public IParticleSystem addAlphaRemapGradient(decimal gradient, decimal min, decimal max)
        {
            return EventHorizonBlazorInteropt.FuncClass<IParticleSystem>(
                entity => new IParticleSystemCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "addAlphaRemapGradient" }, gradient, min, max
                }
            );
        }

        public FactorGradient[] getAlphaRemapGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient(entity),
                new object[]
                {
                    new string[] { this.___guid, "getAlphaRemapGradients" }
                }
            );
        }

        public PointParticleEmitter createPointEmitter(Vector3 direction1, Vector3 direction2)
        {
            return EventHorizonBlazorInteropt.FuncClass<PointParticleEmitter>(
                entity => new PointParticleEmitter(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createPointEmitter" }, direction1, direction2
                }
            );
        }

        public HemisphericParticleEmitter createHemisphericEmitter(decimal radius, decimal radiusRange)
        {
            return EventHorizonBlazorInteropt.FuncClass<HemisphericParticleEmitter>(
                entity => new HemisphericParticleEmitter(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createHemisphericEmitter" }, radius, radiusRange
                }
            );
        }

        public SphereParticleEmitter createSphereEmitter(decimal radius, decimal radiusRange)
        {
            return EventHorizonBlazorInteropt.FuncClass<SphereParticleEmitter>(
                entity => new SphereParticleEmitter(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createSphereEmitter" }, radius, radiusRange
                }
            );
        }

        public SphereDirectedParticleEmitter createDirectedSphereEmitter(decimal radius, Vector3 direction1, Vector3 direction2)
        {
            return EventHorizonBlazorInteropt.FuncClass<SphereDirectedParticleEmitter>(
                entity => new SphereDirectedParticleEmitter(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createDirectedSphereEmitter" }, radius, direction1, direction2
                }
            );
        }

        public CylinderParticleEmitter createCylinderEmitter(decimal radius, decimal height, decimal radiusRange, decimal directionRandomizer)
        {
            return EventHorizonBlazorInteropt.FuncClass<CylinderParticleEmitter>(
                entity => new CylinderParticleEmitter(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createCylinderEmitter" }, radius, height, radiusRange, directionRandomizer
                }
            );
        }

        public SphereDirectedParticleEmitter createDirectedCylinderEmitter(decimal radius, decimal height, decimal radiusRange, Vector3 direction1, Vector3 direction2)
        {
            return EventHorizonBlazorInteropt.FuncClass<SphereDirectedParticleEmitter>(
                entity => new SphereDirectedParticleEmitter(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createDirectedCylinderEmitter" }, radius, height, radiusRange, direction1, direction2
                }
            );
        }

        public ConeParticleEmitter createConeEmitter(decimal radius, decimal angle)
        {
            return EventHorizonBlazorInteropt.FuncClass<ConeParticleEmitter>(
                entity => new ConeParticleEmitter(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createConeEmitter" }, radius, angle
                }
            );
        }

        public BoxParticleEmitter createBoxEmitter(Vector3 direction1, Vector3 direction2, Vector3 minEmitBox, Vector3 maxEmitBox)
        {
            return EventHorizonBlazorInteropt.FuncClass<BoxParticleEmitter>(
                entity => new BoxParticleEmitter(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createBoxEmitter" }, direction1, direction2, minEmitBox, maxEmitBox
                }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }
        #endregion
    }
}