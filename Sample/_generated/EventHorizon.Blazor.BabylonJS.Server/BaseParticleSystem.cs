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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BaseParticleSystem>))]
    public class BaseParticleSystem : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<decimal> get_BLENDMODE_ONEONE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_ONEONE"
                );
        }
        public static ValueTask set_BLENDMODE_ONEONE(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_ONEONE",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_BLENDMODE_STANDARD()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_STANDARD"
                );
        }
        public static ValueTask set_BLENDMODE_STANDARD(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_STANDARD",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_BLENDMODE_ADD()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_ADD"
                );
        }
        public static ValueTask set_BLENDMODE_ADD(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_ADD",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_BLENDMODE_MULTIPLY()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_MULTIPLY"
                );
        }
        public static ValueTask set_BLENDMODE_MULTIPLY(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_MULTIPLY",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_BLENDMODE_MULTIPLYADD()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_MULTIPLYADD"
                );
        }
        public static ValueTask set_BLENDMODE_MULTIPLYADD(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_MULTIPLYADD",
                    value
                );
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private ProceduralTexture __noiseTexture;
        public async ValueTask<ProceduralTexture> get_noiseTexture()
        {
            if(__noiseTexture == null)
            {
                __noiseTexture = await EventHorizonBlazorInterop.GetClass<ProceduralTexture>(
                    this.___guid,
                    "noiseTexture",
                    (entity) =>
                    {
                        return new ProceduralTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __noiseTexture;
        }
        public ValueTask set_noiseTexture(ProceduralTexture value)
        {
__noiseTexture = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "noiseTexture",
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

        private Vector3 __direction1;
        public async ValueTask<Vector3> get_direction1()
        {
            if(__direction1 == null)
            {
                __direction1 = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "direction1",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __direction1;
        }
        public ValueTask set_direction1(Vector3 value)
        {
__direction1 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction1",
                    value
                );
        }

        private Vector3 __direction2;
        public async ValueTask<Vector3> get_direction2()
        {
            if(__direction2 == null)
            {
                __direction2 = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "direction2",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __direction2;
        }
        public ValueTask set_direction2(Vector3 value)
        {
__direction2 = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction2",
                    value
                );
        }

        private Vector3 __minEmitBox;
        public async ValueTask<Vector3> get_minEmitBox()
        {
            if(__minEmitBox == null)
            {
                __minEmitBox = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "minEmitBox",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __minEmitBox;
        }
        public ValueTask set_minEmitBox(Vector3 value)
        {
__minEmitBox = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minEmitBox",
                    value
                );
        }

        private Vector3 __maxEmitBox;
        public async ValueTask<Vector3> get_maxEmitBox()
        {
            if(__maxEmitBox == null)
            {
                __maxEmitBox = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "maxEmitBox",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __maxEmitBox;
        }
        public ValueTask set_maxEmitBox(Vector3 value)
        {
__maxEmitBox = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxEmitBox",
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

        private ImageProcessingConfiguration __imageProcessingConfiguration;
        public async ValueTask<ImageProcessingConfiguration> get_imageProcessingConfiguration()
        {
            if(__imageProcessingConfiguration == null)
            {
                __imageProcessingConfiguration = await EventHorizonBlazorInterop.GetClass<ImageProcessingConfiguration>(
                    this.___guid,
                    "imageProcessingConfiguration",
                    (entity) =>
                    {
                        return new ImageProcessingConfiguration() { ___guid = entity.___guid };
                    }
                );
            }
            return __imageProcessingConfiguration;
        }
        public ValueTask set_imageProcessingConfiguration(ImageProcessingConfiguration value)
        {
__imageProcessingConfiguration = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageProcessingConfiguration",
                    value
                );
        }
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

        
        public async ValueTask<decimal> get_uniqueId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
        }
        public ValueTask set_uniqueId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniqueId",
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

        
        public async ValueTask<decimal> get_manualEmitCount()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "manualEmitCount"
                );
        }
        public ValueTask set_manualEmitCount(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "manualEmitCount",
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

        
        public async ValueTask<CachedEntity> get_customShader()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "customShader",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_customShader(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customShader",
                    value
                );
        }

        
        public async ValueTask<bool> get_preventAutoStart()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preventAutoStart"
                );
        }
        public ValueTask set_preventAutoStart(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preventAutoStart",
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

        
        public async ValueTask<ActionCallback> get_onAnimationEnd()
        {
            return await EventHorizonBlazorInterop.Get<ActionCallback>(
                    this.___guid,
                    "onAnimationEnd"
                );
        }
        public ValueTask set_onAnimationEnd(ActionCallback value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAnimationEnd",
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

        
        public async ValueTask<bool> get_forceDepthWrite()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceDepthWrite"
                );
        }
        public ValueTask set_forceDepthWrite(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forceDepthWrite",
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

        private Vector3 __worldOffset;
        public async ValueTask<Vector3> get_worldOffset()
        {
            if(__worldOffset == null)
            {
                __worldOffset = await EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "worldOffset",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __worldOffset;
        }
        public ValueTask set_worldOffset(Vector3 value)
        {
__worldOffset = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "worldOffset",
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

        private Color4 __textureMask;
        public async ValueTask<Color4> get_textureMask()
        {
            if(__textureMask == null)
            {
                __textureMask = await EventHorizonBlazorInterop.GetClass<Color4>(
                    this.___guid,
                    "textureMask",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __textureMask;
        }
        public ValueTask set_textureMask(Color4 value)
        {
__textureMask = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureMask",
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
        #endregion
        
        #region Constructor
        public BaseParticleSystem() : base() { } 

        public BaseParticleSystem(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public static async ValueTask<BaseParticleSystem> NewBaseParticleSystem(
            string name
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "BaseParticleSystem" },
                name
            );

            return new BaseParticleSystem(entity);
        }
        #endregion

        #region Methods
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

        public async ValueTask<HemisphericParticleEmitter> createHemisphericEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> radiusRange = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<HemisphericParticleEmitter>(
                entity => new HemisphericParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createHemisphericEmitter" }, radius, radiusRange
                }
            );
        }

        public async ValueTask<SphereParticleEmitter> createSphereEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> radiusRange = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<SphereParticleEmitter>(
                entity => new SphereParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createSphereEmitter" }, radius, radiusRange
                }
            );
        }

        public async ValueTask<SphereDirectedParticleEmitter> createDirectedSphereEmitter(System.Nullable<decimal> radius = null, Vector3 direction1 = null, Vector3 direction2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<SphereDirectedParticleEmitter>(
                entity => new SphereDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createDirectedSphereEmitter" }, radius, direction1, direction2
                }
            );
        }

        public async ValueTask<CylinderParticleEmitter> createCylinderEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> height = null, System.Nullable<decimal> radiusRange = null, System.Nullable<decimal> directionRandomizer = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<CylinderParticleEmitter>(
                entity => new CylinderParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createCylinderEmitter" }, radius, height, radiusRange, directionRandomizer
                }
            );
        }

        public async ValueTask<CylinderDirectedParticleEmitter> createDirectedCylinderEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> height = null, System.Nullable<decimal> radiusRange = null, Vector3 direction1 = null, Vector3 direction2 = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<CylinderDirectedParticleEmitter>(
                entity => new CylinderDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createDirectedCylinderEmitter" }, radius, height, radiusRange, direction1, direction2
                }
            );
        }

        public async ValueTask<ConeParticleEmitter> createConeEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> angle = null)
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
        #endregion
    }
}