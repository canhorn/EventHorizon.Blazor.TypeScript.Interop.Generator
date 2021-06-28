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

    public interface IParticleSystem : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IParticleSystemCachedEntity>))]
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
            return EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        private AbstractMesh __emitter;
        public AbstractMesh emitter
        {
            get
            {
            if(__emitter == null)
            {
                __emitter = EventHorizonBlazorInterop.GetClass<AbstractMesh>(
                    this.___guid,
                    "emitter",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __emitter;
            }
            set
            {
__emitter = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBillboardBased"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderingGroupId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "updateSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "targetStopDuration"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "targetStopDuration",
                    value
                );
            }
        }

        private BaseTexture __particleTexture;
        public BaseTexture particleTexture
        {
            get
            {
            if(__particleTexture == null)
            {
                __particleTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "particleTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __particleTexture;
            }
            set
            {
__particleTexture = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blendMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minLifeTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxLifeTime"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minScaleX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxScaleX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minScaleY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxScaleY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __color1 = EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "color1",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __color1;
            }
            set
            {
__color1 = null;
                EventHorizonBlazorInterop.Set(
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
                __color2 = EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "color2",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __color2;
            }
            set
            {
__color2 = null;
                EventHorizonBlazorInterop.Set(
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
                __colorDead = EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "colorDead",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __colorDead;
            }
            set
            {
__colorDead = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "emitRate"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __gravity = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "gravity",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __gravity;
            }
            set
            {
__gravity = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minEmitPower"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxEmitPower"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minAngularSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxAngularSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minInitialRotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxInitialRotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxInitialRotation",
                    value
                );
            }
        }

        private IParticleEmitterTypeCachedEntity __particleEmitterType;
        public IParticleEmitterTypeCachedEntity particleEmitterType
        {
            get
            {
            if(__particleEmitterType == null)
            {
                __particleEmitterType = EventHorizonBlazorInterop.GetClass<IParticleEmitterTypeCachedEntity>(
                    this.___guid,
                    "particleEmitterType",
                    (entity) =>
                    {
                        return new IParticleEmitterTypeCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __particleEmitterType;
            }
            set
            {
__particleEmitterType = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startDelay"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "preWarmCycles"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "preWarmStepOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "spriteCellChangeSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startSpriteCellID"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "endSpriteCellID"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "spriteCellWidth"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "spriteCellHeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "spriteRandomStartCell"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isAnimationSheetEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
                __translationPivot = EventHorizonBlazorInterop.GetClass<Vector2>(
                    this.___guid,
                    "translationPivot",
                    (entity) =>
                    {
                        return new Vector2() { ___guid = entity.___guid };
                    }
                );
            }
            return __translationPivot;
            }
            set
            {
__translationPivot = null;
                EventHorizonBlazorInterop.Set(
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
                __noiseTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "noiseTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __noiseTexture;
            }
            set
            {
__noiseTexture = null;
                EventHorizonBlazorInterop.Set(
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
                __noiseStrength = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "noiseStrength",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __noiseStrength;
            }
            set
            {
__noiseStrength = null;
                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "billboardMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "limitVelocityDamping"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "beginAnimationOnStart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "beginAnimationFrom"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "beginAnimationTo"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "beginAnimationLoop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disposeOnStop"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
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

        
        public string snippetId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "snippetId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "snippetId",
                    value
                );
            }
        }

        private Matrix __defaultProjectionMatrix;
        public Matrix defaultProjectionMatrix
        {
            get
            {
            if(__defaultProjectionMatrix == null)
            {
                __defaultProjectionMatrix = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "defaultProjectionMatrix",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __defaultProjectionMatrix;
            }
            set
            {
__defaultProjectionMatrix = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultProjectionMatrix",
                    value
                );
            }
        }

        private Observable<IParticleSystemCachedEntity> __onDisposeObservable;
        public Observable<IParticleSystemCachedEntity> onDisposeObservable
        {
            get
            {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = EventHorizonBlazorInterop.GetClass<Observable<IParticleSystemCachedEntity>>(
                    this.___guid,
                    "onDisposeObservable",
                    (entity) =>
                    {
                        return new Observable<IParticleSystemCachedEntity>() { ___guid = entity.___guid };
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

        private Observable<IParticleSystemCachedEntity> __onStoppedObservable;
        public Observable<IParticleSystemCachedEntity> onStoppedObservable
        {
            get
            {
            if(__onStoppedObservable == null)
            {
                __onStoppedObservable = EventHorizonBlazorInterop.GetClass<Observable<IParticleSystemCachedEntity>>(
                    this.___guid,
                    "onStoppedObservable",
                    (entity) =>
                    {
                        return new Observable<IParticleSystemCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onStoppedObservable;
            }
            set
            {
__onStoppedObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onStoppedObservable",
                    value
                );
            }
        }

        private Observable<Effect> __onBeforeDrawParticlesObservable;
        public Observable<Effect> onBeforeDrawParticlesObservable
        {
            get
            {
            if(__onBeforeDrawParticlesObservable == null)
            {
                __onBeforeDrawParticlesObservable = EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
                    this.___guid,
                    "onBeforeDrawParticlesObservable",
                    (entity) =>
                    {
                        return new Observable<Effect>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeDrawParticlesObservable;
            }
            set
            {
__onBeforeDrawParticlesObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeDrawParticlesObservable",
                    value
                );
            }
        }

        
        public string vertexShaderName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "vertexShaderName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexShaderName",
                    value
                );
            }
        }

        
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
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getCapacity" }
                }
            );
        }

        public decimal getActiveCount()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getActiveCount" }
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

        public void animate()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "animate" }
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

        public IParticleSystemCachedEntity clone(string name, object newEmitter)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, name, newEmitter
                }
            );
        }

        public CachedEntity serialize(bool serializeTexture)
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }, serializeTexture
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

        public void forceRefreshGradients()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "forceRefreshGradients" }
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

        public void stop()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "stop" }
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

        public bool isStopping()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isStopping" }
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

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public Effect getCustomEffect(decimal blendMode)
        {
            return EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getCustomEffect" }, blendMode
                }
            );
        }

        public void setCustomEffect(Effect effect, decimal blendMode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setCustomEffect" }, effect, blendMode
                }
            );
        }

        public void fillDefines(string[] defines, decimal blendMode)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fillDefines" }, defines, blendMode
                }
            );
        }

        public void fillUniformsAttributesAndSamplerNames(string[] uniforms, string[] attributes, string[] samplers)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "fillUniformsAttributesAndSamplerNames" }, uniforms, attributes, samplers
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

        public ColorGradient[] getColorGradients()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<ColorGradient>(
                entity => new ColorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getColorGradients" }
                }
            );
        }

        public FactorGradient[] getSizeGradients()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSizeGradients" }
                }
            );
        }

        public FactorGradient[] getAngularSpeedGradients()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAngularSpeedGradients" }
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

        public FactorGradient[] getVelocityGradients()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getVelocityGradients" }
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

        public FactorGradient[] getLimitVelocityGradients()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLimitVelocityGradients" }
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

        public FactorGradient[] getDragGradients()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDragGradients" }
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

        public FactorGradient[] getEmitRateGradients()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEmitRateGradients" }
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

        public FactorGradient[] getStartSizeGradients()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getStartSizeGradients" }
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

        public FactorGradient[] getLifeTimeGradients()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLifeTimeGradients" }
                }
            );
        }

        public IParticleSystemCachedEntity addRampGradient(decimal gradient, Color3 color)
        {
            return EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addRampGradient" }, gradient, color
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

        public FactorGradient[] getColorRemapGradients()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getColorRemapGradients" }
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

        public FactorGradient[] getAlphaRemapGradients()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAlphaRemapGradients" }
                }
            );
        }

        public PointParticleEmitter createPointEmitter(Vector3 direction1, Vector3 direction2)
        {
            return EventHorizonBlazorInterop.FuncClass<PointParticleEmitter>(
                entity => new PointParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createPointEmitter" }, direction1, direction2
                }
            );
        }

        public HemisphericParticleEmitter createHemisphericEmitter(decimal radius, decimal radiusRange)
        {
            return EventHorizonBlazorInterop.FuncClass<HemisphericParticleEmitter>(
                entity => new HemisphericParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createHemisphericEmitter" }, radius, radiusRange
                }
            );
        }

        public SphereParticleEmitter createSphereEmitter(decimal radius, decimal radiusRange)
        {
            return EventHorizonBlazorInterop.FuncClass<SphereParticleEmitter>(
                entity => new SphereParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createSphereEmitter" }, radius, radiusRange
                }
            );
        }

        public SphereDirectedParticleEmitter createDirectedSphereEmitter(decimal radius, Vector3 direction1, Vector3 direction2)
        {
            return EventHorizonBlazorInterop.FuncClass<SphereDirectedParticleEmitter>(
                entity => new SphereDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDirectedSphereEmitter" }, radius, direction1, direction2
                }
            );
        }

        public CylinderParticleEmitter createCylinderEmitter(decimal radius, decimal height, decimal radiusRange, decimal directionRandomizer)
        {
            return EventHorizonBlazorInterop.FuncClass<CylinderParticleEmitter>(
                entity => new CylinderParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createCylinderEmitter" }, radius, height, radiusRange, directionRandomizer
                }
            );
        }

        public SphereDirectedParticleEmitter createDirectedCylinderEmitter(decimal radius, decimal height, decimal radiusRange, Vector3 direction1, Vector3 direction2)
        {
            return EventHorizonBlazorInterop.FuncClass<SphereDirectedParticleEmitter>(
                entity => new SphereDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDirectedCylinderEmitter" }, radius, height, radiusRange, direction1, direction2
                }
            );
        }

        public ConeParticleEmitter createConeEmitter(decimal radius, decimal angle)
        {
            return EventHorizonBlazorInterop.FuncClass<ConeParticleEmitter>(
                entity => new ConeParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createConeEmitter" }, radius, angle
                }
            );
        }

        public BoxParticleEmitter createBoxEmitter(Vector3 direction1, Vector3 direction2, Vector3 minEmitBox, Vector3 maxEmitBox)
        {
            return EventHorizonBlazorInterop.FuncClass<BoxParticleEmitter>(
                entity => new BoxParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createBoxEmitter" }, direction1, direction2, minEmitBox, maxEmitBox
                }
            );
        }

        public Scene getScene()
        {
            return EventHorizonBlazorInterop.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }
        #endregion
    }
}