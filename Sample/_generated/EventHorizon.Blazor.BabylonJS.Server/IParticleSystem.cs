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
        
        public async ValueTask<Animation[]> get_animations()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_animations(Animation[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animations",
                    value
                );
        }

        
        public async ValueTask<string> get_id()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
        }
        public ValueTask set_id(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
        }

        
        public async ValueTask<string> get_name()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "name"
                );
        }
        public ValueTask set_name(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "name",
                    value
                );
        }

        private AbstractMesh __emitter;
        public async ValueTask<AbstractMesh> get_emitter()
        {
            if(__emitter == null)
            {
                __emitter = await EventHorizonBlazorInterop.GetClass<AbstractMesh>(
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
        public ValueTask set_emitter(AbstractMesh value)
        {
__emitter = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emitter",
                    value
                );
        }

        
        public async ValueTask<bool> get_isBillboardBased()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isBillboardBased"
                );
        }
        public ValueTask set_isBillboardBased(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isBillboardBased",
                    value
                );
        }

        
        public async ValueTask<decimal> get_renderingGroupId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "renderingGroupId"
                );
        }
        public ValueTask set_renderingGroupId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "renderingGroupId",
                    value
                );
        }

        
        public async ValueTask<decimal> get_layerMask()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
        }
        public ValueTask set_layerMask(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "layerMask",
                    value
                );
        }

        
        public async ValueTask<decimal> get_updateSpeed()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "updateSpeed"
                );
        }
        public ValueTask set_updateSpeed(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "updateSpeed",
                    value
                );
        }

        
        public async ValueTask<decimal> get_targetStopDuration()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "targetStopDuration"
                );
        }
        public ValueTask set_targetStopDuration(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "targetStopDuration",
                    value
                );
        }

        private BaseTexture __particleTexture;
        public async ValueTask<BaseTexture> get_particleTexture()
        {
            if(__particleTexture == null)
            {
                __particleTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
        public ValueTask set_particleTexture(BaseTexture value)
        {
__particleTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "particleTexture",
                    value
                );
        }

        
        public async ValueTask<decimal> get_blendMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blendMode"
                );
        }
        public ValueTask set_blendMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendMode",
                    value
                );
        }

        
        public async ValueTask<decimal> get_minLifeTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minLifeTime"
                );
        }
        public ValueTask set_minLifeTime(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minLifeTime",
                    value
                );
        }

        
        public async ValueTask<decimal> get_maxLifeTime()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxLifeTime"
                );
        }
        public ValueTask set_maxLifeTime(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxLifeTime",
                    value
                );
        }

        
        public async ValueTask<decimal> get_minSize()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minSize"
                );
        }
        public ValueTask set_minSize(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minSize",
                    value
                );
        }

        
        public async ValueTask<decimal> get_maxSize()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxSize"
                );
        }
        public ValueTask set_maxSize(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxSize",
                    value
                );
        }

        
        public async ValueTask<decimal> get_minScaleX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minScaleX"
                );
        }
        public ValueTask set_minScaleX(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minScaleX",
                    value
                );
        }

        
        public async ValueTask<decimal> get_maxScaleX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxScaleX"
                );
        }
        public ValueTask set_maxScaleX(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxScaleX",
                    value
                );
        }

        
        public async ValueTask<decimal> get_minScaleY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minScaleY"
                );
        }
        public ValueTask set_minScaleY(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minScaleY",
                    value
                );
        }

        
        public async ValueTask<decimal> get_maxScaleY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxScaleY"
                );
        }
        public ValueTask set_maxScaleY(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxScaleY",
                    value
                );
        }

        private Color4 __color1;
        public async ValueTask<Color4> get_color1()
        {
            if(__color1 == null)
            {
                __color1 = await EventHorizonBlazorInterop.GetClass<Color4>(
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
        public ValueTask set_color1(Color4 value)
        {
__color1 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color1",
                    value
                );
        }

        private Color4 __color2;
        public async ValueTask<Color4> get_color2()
        {
            if(__color2 == null)
            {
                __color2 = await EventHorizonBlazorInterop.GetClass<Color4>(
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
        public ValueTask set_color2(Color4 value)
        {
__color2 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "color2",
                    value
                );
        }

        private Color4 __colorDead;
        public async ValueTask<Color4> get_colorDead()
        {
            if(__colorDead == null)
            {
                __colorDead = await EventHorizonBlazorInterop.GetClass<Color4>(
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
        public ValueTask set_colorDead(Color4 value)
        {
__colorDead = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "colorDead",
                    value
                );
        }

        
        public async ValueTask<decimal> get_emitRate()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "emitRate"
                );
        }
        public ValueTask set_emitRate(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emitRate",
                    value
                );
        }

        private Vector3 __gravity;
        public async ValueTask<Vector3> get_gravity()
        {
            if(__gravity == null)
            {
                __gravity = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_gravity(Vector3 value)
        {
__gravity = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "gravity",
                    value
                );
        }

        
        public async ValueTask<decimal> get_minEmitPower()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minEmitPower"
                );
        }
        public ValueTask set_minEmitPower(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minEmitPower",
                    value
                );
        }

        
        public async ValueTask<decimal> get_maxEmitPower()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxEmitPower"
                );
        }
        public ValueTask set_maxEmitPower(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxEmitPower",
                    value
                );
        }

        
        public async ValueTask<decimal> get_minAngularSpeed()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minAngularSpeed"
                );
        }
        public ValueTask set_minAngularSpeed(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minAngularSpeed",
                    value
                );
        }

        
        public async ValueTask<decimal> get_maxAngularSpeed()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxAngularSpeed"
                );
        }
        public ValueTask set_maxAngularSpeed(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxAngularSpeed",
                    value
                );
        }

        
        public async ValueTask<decimal> get_minInitialRotation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "minInitialRotation"
                );
        }
        public ValueTask set_minInitialRotation(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minInitialRotation",
                    value
                );
        }

        
        public async ValueTask<decimal> get_maxInitialRotation()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxInitialRotation"
                );
        }
        public ValueTask set_maxInitialRotation(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxInitialRotation",
                    value
                );
        }

        private IParticleEmitterTypeCachedEntity __particleEmitterType;
        public async ValueTask<IParticleEmitterTypeCachedEntity> get_particleEmitterType()
        {
            if(__particleEmitterType == null)
            {
                __particleEmitterType = await EventHorizonBlazorInterop.GetClass<IParticleEmitterTypeCachedEntity>(
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
        public ValueTask set_particleEmitterType(IParticleEmitterTypeCachedEntity value)
        {
__particleEmitterType = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "particleEmitterType",
                    value
                );
        }

        
        public async ValueTask<decimal> get_startDelay()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startDelay"
                );
        }
        public ValueTask set_startDelay(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "startDelay",
                    value
                );
        }

        
        public async ValueTask<decimal> get_preWarmCycles()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "preWarmCycles"
                );
        }
        public ValueTask set_preWarmCycles(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preWarmCycles",
                    value
                );
        }

        
        public async ValueTask<decimal> get_preWarmStepOffset()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "preWarmStepOffset"
                );
        }
        public ValueTask set_preWarmStepOffset(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preWarmStepOffset",
                    value
                );
        }

        
        public async ValueTask<decimal> get_spriteCellChangeSpeed()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "spriteCellChangeSpeed"
                );
        }
        public ValueTask set_spriteCellChangeSpeed(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "spriteCellChangeSpeed",
                    value
                );
        }

        
        public async ValueTask<decimal> get_startSpriteCellID()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "startSpriteCellID"
                );
        }
        public ValueTask set_startSpriteCellID(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "startSpriteCellID",
                    value
                );
        }

        
        public async ValueTask<decimal> get_endSpriteCellID()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "endSpriteCellID"
                );
        }
        public ValueTask set_endSpriteCellID(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "endSpriteCellID",
                    value
                );
        }

        
        public async ValueTask<decimal> get_spriteCellWidth()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "spriteCellWidth"
                );
        }
        public ValueTask set_spriteCellWidth(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "spriteCellWidth",
                    value
                );
        }

        
        public async ValueTask<decimal> get_spriteCellHeight()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "spriteCellHeight"
                );
        }
        public ValueTask set_spriteCellHeight(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "spriteCellHeight",
                    value
                );
        }

        
        public async ValueTask<bool> get_spriteRandomStartCell()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "spriteRandomStartCell"
                );
        }
        public ValueTask set_spriteRandomStartCell(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "spriteRandomStartCell",
                    value
                );
        }

        
        public async ValueTask<bool> get_isAnimationSheetEnabled()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isAnimationSheetEnabled"
                );
        }
        public ValueTask set_isAnimationSheetEnabled(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isAnimationSheetEnabled",
                    value
                );
        }

        private Vector2 __translationPivot;
        public async ValueTask<Vector2> get_translationPivot()
        {
            if(__translationPivot == null)
            {
                __translationPivot = await EventHorizonBlazorInterop.GetClass<Vector2>(
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
        public ValueTask set_translationPivot(Vector2 value)
        {
__translationPivot = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "translationPivot",
                    value
                );
        }

        private BaseTexture __noiseTexture;
        public async ValueTask<BaseTexture> get_noiseTexture()
        {
            if(__noiseTexture == null)
            {
                __noiseTexture = await EventHorizonBlazorInterop.GetClass<BaseTexture>(
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
        public ValueTask set_noiseTexture(BaseTexture value)
        {
__noiseTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "noiseTexture",
                    value
                );
        }

        private Vector3 __noiseStrength;
        public async ValueTask<Vector3> get_noiseStrength()
        {
            if(__noiseStrength == null)
            {
                __noiseStrength = await EventHorizonBlazorInterop.GetClass<Vector3>(
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
        public ValueTask set_noiseStrength(Vector3 value)
        {
__noiseStrength = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "noiseStrength",
                    value
                );
        }

        
        public async ValueTask<decimal> get_billboardMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "billboardMode"
                );
        }
        public ValueTask set_billboardMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "billboardMode",
                    value
                );
        }

        
        public async ValueTask<decimal> get_limitVelocityDamping()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "limitVelocityDamping"
                );
        }
        public ValueTask set_limitVelocityDamping(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "limitVelocityDamping",
                    value
                );
        }

        
        public async ValueTask<bool> get_beginAnimationOnStart()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "beginAnimationOnStart"
                );
        }
        public ValueTask set_beginAnimationOnStart(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "beginAnimationOnStart",
                    value
                );
        }

        
        public async ValueTask<decimal> get_beginAnimationFrom()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "beginAnimationFrom"
                );
        }
        public ValueTask set_beginAnimationFrom(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "beginAnimationFrom",
                    value
                );
        }

        
        public async ValueTask<decimal> get_beginAnimationTo()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "beginAnimationTo"
                );
        }
        public ValueTask set_beginAnimationTo(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "beginAnimationTo",
                    value
                );
        }

        
        public async ValueTask<bool> get_beginAnimationLoop()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "beginAnimationLoop"
                );
        }
        public ValueTask set_beginAnimationLoop(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "beginAnimationLoop",
                    value
                );
        }

        
        public async ValueTask<bool> get_disposeOnStop()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disposeOnStop"
                );
        }
        public ValueTask set_disposeOnStop(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disposeOnStop",
                    value
                );
        }

        
        public async ValueTask<bool> get_isLocal()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isLocal"
                );
        }
        public ValueTask set_isLocal(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isLocal",
                    value
                );
        }

        
        public async ValueTask<string> get_snippetId()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "snippetId"
                );
        }
        public ValueTask set_snippetId(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "snippetId",
                    value
                );
        }

        private Matrix __defaultProjectionMatrix;
        public async ValueTask<Matrix> get_defaultProjectionMatrix()
        {
            if(__defaultProjectionMatrix == null)
            {
                __defaultProjectionMatrix = await EventHorizonBlazorInterop.GetClass<Matrix>(
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
        public ValueTask set_defaultProjectionMatrix(Matrix value)
        {
__defaultProjectionMatrix = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultProjectionMatrix",
                    value
                );
        }

        private Observable<IParticleSystemCachedEntity> __onDisposeObservable;
        public async ValueTask<Observable<IParticleSystemCachedEntity>> get_onDisposeObservable()
        {
            if(__onDisposeObservable == null)
            {
                __onDisposeObservable = await EventHorizonBlazorInterop.GetClass<Observable<IParticleSystemCachedEntity>>(
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
        public ValueTask set_onDisposeObservable(Observable<IParticleSystemCachedEntity> value)
        {
__onDisposeObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onDisposeObservable",
                    value
                );
        }

        private Observable<IParticleSystemCachedEntity> __onStoppedObservable;
        public async ValueTask<Observable<IParticleSystemCachedEntity>> get_onStoppedObservable()
        {
            if(__onStoppedObservable == null)
            {
                __onStoppedObservable = await EventHorizonBlazorInterop.GetClass<Observable<IParticleSystemCachedEntity>>(
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
        public ValueTask set_onStoppedObservable(Observable<IParticleSystemCachedEntity> value)
        {
__onStoppedObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onStoppedObservable",
                    value
                );
        }

        private Observable<Effect> __onBeforeDrawParticlesObservable;
        public async ValueTask<Observable<Effect>> get_onBeforeDrawParticlesObservable()
        {
            if(__onBeforeDrawParticlesObservable == null)
            {
                __onBeforeDrawParticlesObservable = await EventHorizonBlazorInterop.GetClass<Observable<Effect>>(
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
        public ValueTask set_onBeforeDrawParticlesObservable(Observable<Effect> value)
        {
__onBeforeDrawParticlesObservable = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeDrawParticlesObservable",
                    value
                );
        }

        
        public async ValueTask<string> get_vertexShaderName()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "vertexShaderName"
                );
        }
        public ValueTask set_vertexShaderName(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "vertexShaderName",
                    value
                );
        }

        
        public async ValueTask<bool> get_useRampGradients()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useRampGradients"
                );
        }
        public ValueTask set_useRampGradients(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useRampGradients",
                    value
                );
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
        public async ValueTask<decimal> getCapacity()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getCapacity" }
                }
            );
        }

        public async ValueTask<decimal> getActiveCount()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getActiveCount" }
                }
            );
        }

        public async ValueTask<bool> isStarted()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isStarted" }
                }
            );
        }

        public async ValueTask animate()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "animate" }
                }
            );
        }

        public async ValueTask<decimal> render()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }
                }
            );
        }

        public async ValueTask dispose(System.Nullable<bool> disposeTexture = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }, disposeTexture
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> clone(string name, object newEmitter)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }, name, newEmitter
                }
            );
        }

        public async ValueTask<CachedEntity> serialize(bool serializeTexture)
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }, serializeTexture
                }
            );
        }

        public async ValueTask rebuild()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "rebuild" }
                }
            );
        }

        public async ValueTask forceRefreshGradients()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "forceRefreshGradients" }
                }
            );
        }

        public async ValueTask start(System.Nullable<decimal> delay = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "start" }, delay
                }
            );
        }

        public async ValueTask stop()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stop" }
                }
            );
        }

        public async ValueTask reset()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "reset" }
                }
            );
        }

        public async ValueTask<bool> isStopping()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isStopping" }
                }
            );
        }

        public async ValueTask<bool> isReady()
        {
            return await EventHorizonBlazorInterop.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isReady" }
                }
            );
        }

        public async ValueTask<string> getClassName()
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public async ValueTask<Effect> getCustomEffect(decimal blendMode)
        {
            return await EventHorizonBlazorInterop.FuncClass<Effect>(
                entity => new Effect() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getCustomEffect" }, blendMode
                }
            );
        }

        public async ValueTask setCustomEffect(Effect effect, decimal blendMode)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setCustomEffect" }, effect, blendMode
                }
            );
        }

        public async ValueTask fillDefines(string[] defines, decimal blendMode)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "fillDefines" }, defines, blendMode
                }
            );
        }

        public async ValueTask fillUniformsAttributesAndSamplerNames(string[] uniforms, string[] attributes, string[] samplers)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "fillUniformsAttributesAndSamplerNames" }, uniforms, attributes, samplers
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addColorGradient(decimal gradient, Color4 color1, Color4 color2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addColorGradient" }, gradient, color1, color2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeColorGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeColorGradient" }, gradient
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addSizeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addSizeGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeSizeGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeSizeGradient" }, gradient
                }
            );
        }

        public async ValueTask<ColorGradient[]> getColorGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<ColorGradient>(
                entity => new ColorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getColorGradients" }
                }
            );
        }

        public async ValueTask<FactorGradient[]> getSizeGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSizeGradients" }
                }
            );
        }

        public async ValueTask<FactorGradient[]> getAngularSpeedGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAngularSpeedGradients" }
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addAngularSpeedGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addAngularSpeedGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeAngularSpeedGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeAngularSpeedGradient" }, gradient
                }
            );
        }

        public async ValueTask<FactorGradient[]> getVelocityGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getVelocityGradients" }
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addVelocityGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addVelocityGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeVelocityGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeVelocityGradient" }, gradient
                }
            );
        }

        public async ValueTask<FactorGradient[]> getLimitVelocityGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLimitVelocityGradients" }
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addLimitVelocityGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addLimitVelocityGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeLimitVelocityGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeLimitVelocityGradient" }, gradient
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addDragGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addDragGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeDragGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeDragGradient" }, gradient
                }
            );
        }

        public async ValueTask<FactorGradient[]> getDragGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDragGradients" }
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addEmitRateGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addEmitRateGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeEmitRateGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeEmitRateGradient" }, gradient
                }
            );
        }

        public async ValueTask<FactorGradient[]> getEmitRateGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEmitRateGradients" }
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addStartSizeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addStartSizeGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeStartSizeGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeStartSizeGradient" }, gradient
                }
            );
        }

        public async ValueTask<FactorGradient[]> getStartSizeGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getStartSizeGradients" }
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addLifeTimeGradient(decimal gradient, decimal factor, System.Nullable<decimal> factor2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addLifeTimeGradient" }, gradient, factor, factor2
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> removeLifeTimeGradient(decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "removeLifeTimeGradient" }, gradient
                }
            );
        }

        public async ValueTask<FactorGradient[]> getLifeTimeGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLifeTimeGradients" }
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addRampGradient(decimal gradient, Color3 color)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addRampGradient" }, gradient, color
                }
            );
        }

        public async ValueTask<Color3Gradient[]> getRampGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Color3Gradient>(
                entity => new Color3Gradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRampGradients" }
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addColorRemapGradient(decimal gradient, decimal min, decimal max)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addColorRemapGradient" }, gradient, min, max
                }
            );
        }

        public async ValueTask<FactorGradient[]> getColorRemapGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getColorRemapGradients" }
                }
            );
        }

        public async ValueTask<IParticleSystemCachedEntity> addAlphaRemapGradient(decimal gradient, decimal min, decimal max)
        {
            return await EventHorizonBlazorInterop.FuncClass<IParticleSystemCachedEntity>(
                entity => new IParticleSystemCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "addAlphaRemapGradient" }, gradient, min, max
                }
            );
        }

        public async ValueTask<FactorGradient[]> getAlphaRemapGradients()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAlphaRemapGradients" }
                }
            );
        }

        public async ValueTask<PointParticleEmitter> createPointEmitter(Vector3 direction1, Vector3 direction2)
        {
            return await EventHorizonBlazorInterop.FuncClass<PointParticleEmitter>(
                entity => new PointParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createPointEmitter" }, direction1, direction2
                }
            );
        }

        public async ValueTask<HemisphericParticleEmitter> createHemisphericEmitter(decimal radius, decimal radiusRange)
        {
            return await EventHorizonBlazorInterop.FuncClass<HemisphericParticleEmitter>(
                entity => new HemisphericParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createHemisphericEmitter" }, radius, radiusRange
                }
            );
        }

        public async ValueTask<SphereParticleEmitter> createSphereEmitter(decimal radius, decimal radiusRange)
        {
            return await EventHorizonBlazorInterop.FuncClass<SphereParticleEmitter>(
                entity => new SphereParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createSphereEmitter" }, radius, radiusRange
                }
            );
        }

        public async ValueTask<SphereDirectedParticleEmitter> createDirectedSphereEmitter(decimal radius, Vector3 direction1, Vector3 direction2)
        {
            return await EventHorizonBlazorInterop.FuncClass<SphereDirectedParticleEmitter>(
                entity => new SphereDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createDirectedSphereEmitter" }, radius, direction1, direction2
                }
            );
        }

        public async ValueTask<CylinderParticleEmitter> createCylinderEmitter(decimal radius, decimal height, decimal radiusRange, decimal directionRandomizer)
        {
            return await EventHorizonBlazorInterop.FuncClass<CylinderParticleEmitter>(
                entity => new CylinderParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createCylinderEmitter" }, radius, height, radiusRange, directionRandomizer
                }
            );
        }

        public async ValueTask<SphereDirectedParticleEmitter> createDirectedCylinderEmitter(decimal radius, decimal height, decimal radiusRange, Vector3 direction1, Vector3 direction2)
        {
            return await EventHorizonBlazorInterop.FuncClass<SphereDirectedParticleEmitter>(
                entity => new SphereDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createDirectedCylinderEmitter" }, radius, height, radiusRange, direction1, direction2
                }
            );
        }

        public async ValueTask<ConeParticleEmitter> createConeEmitter(decimal radius, decimal angle)
        {
            return await EventHorizonBlazorInterop.FuncClass<ConeParticleEmitter>(
                entity => new ConeParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createConeEmitter" }, radius, angle
                }
            );
        }

        public async ValueTask<BoxParticleEmitter> createBoxEmitter(Vector3 direction1, Vector3 direction2, Vector3 minEmitBox, Vector3 maxEmitBox)
        {
            return await EventHorizonBlazorInterop.FuncClass<BoxParticleEmitter>(
                entity => new BoxParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createBoxEmitter" }, direction1, direction2, minEmitBox, maxEmitBox
                }
            );
        }

        public async ValueTask<Scene> getScene()
        {
            return await EventHorizonBlazorInterop.FuncClass<Scene>(
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