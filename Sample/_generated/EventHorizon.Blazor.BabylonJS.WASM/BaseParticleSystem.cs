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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BaseParticleSystem>))]
    public class BaseParticleSystem : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal BLENDMODE_ONEONE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_ONEONE"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_ONEONE",
                    value
                );
            }
        }

        
        public static decimal BLENDMODE_STANDARD
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_STANDARD"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_STANDARD",
                    value
                );
            }
        }

        
        public static decimal BLENDMODE_ADD
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_ADD"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_ADD",
                    value
                );
            }
        }

        
        public static decimal BLENDMODE_MULTIPLY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_MULTIPLY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_MULTIPLY",
                    value
                );
            }
        }

        
        public static decimal BLENDMODE_MULTIPLYADD
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_MULTIPLYADD"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_MULTIPLYADD",
                    value
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private ProceduralTexture __noiseTexture;
        public ProceduralTexture noiseTexture
        {
            get
            {
            if(__noiseTexture == null)
            {
                __noiseTexture = EventHorizonBlazorInterop.GetClass<ProceduralTexture>(
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

        private Vector3 __direction1;
        public Vector3 direction1
        {
            get
            {
            if(__direction1 == null)
            {
                __direction1 = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__direction1 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction1",
                    value
                );
            }
        }

        private Vector3 __direction2;
        public Vector3 direction2
        {
            get
            {
            if(__direction2 == null)
            {
                __direction2 = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__direction2 = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction2",
                    value
                );
            }
        }

        private Vector3 __minEmitBox;
        public Vector3 minEmitBox
        {
            get
            {
            if(__minEmitBox == null)
            {
                __minEmitBox = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__minEmitBox = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "minEmitBox",
                    value
                );
            }
        }

        private Vector3 __maxEmitBox;
        public Vector3 maxEmitBox
        {
            get
            {
            if(__maxEmitBox == null)
            {
                __maxEmitBox = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__maxEmitBox = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxEmitBox",
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

        private ImageProcessingConfiguration __imageProcessingConfiguration;
        public ImageProcessingConfiguration imageProcessingConfiguration
        {
            get
            {
            if(__imageProcessingConfiguration == null)
            {
                __imageProcessingConfiguration = EventHorizonBlazorInterop.GetClass<ImageProcessingConfiguration>(
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
            set
            {
__imageProcessingConfiguration = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageProcessingConfiguration",
                    value
                );
            }
        }
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

        
        public decimal uniqueId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniqueId",
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

        
        public decimal manualEmitCount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "manualEmitCount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "manualEmitCount",
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

        
        public CachedEntity customShader
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "customShader",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "customShader",
                    value
                );
            }
        }

        
        public bool preventAutoStart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "preventAutoStart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "preventAutoStart",
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

        
        public ActionCallback onAnimationEnd
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback>(
                    this.___guid,
                    "onAnimationEnd"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAnimationEnd",
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

        
        public bool forceDepthWrite
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "forceDepthWrite"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "forceDepthWrite",
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

        private Vector3 __worldOffset;
        public Vector3 worldOffset
        {
            get
            {
            if(__worldOffset == null)
            {
                __worldOffset = EventHorizonBlazorInterop.GetClass<Vector3>(
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
            set
            {
__worldOffset = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "worldOffset",
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

        private Color4 __textureMask;
        public Color4 textureMask
        {
            get
            {
            if(__textureMask == null)
            {
                __textureMask = EventHorizonBlazorInterop.GetClass<Color4>(
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
            set
            {
__textureMask = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureMask",
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
        #endregion
        
        #region Constructor
        public BaseParticleSystem() : base() { }

        public BaseParticleSystem(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public BaseParticleSystem(
            string name
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "BaseParticleSystem" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
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

        public HemisphericParticleEmitter createHemisphericEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> radiusRange = null)
        {
            return EventHorizonBlazorInterop.FuncClass<HemisphericParticleEmitter>(
                entity => new HemisphericParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createHemisphericEmitter" }, radius, radiusRange
                }
            );
        }

        public SphereParticleEmitter createSphereEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> radiusRange = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SphereParticleEmitter>(
                entity => new SphereParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createSphereEmitter" }, radius, radiusRange
                }
            );
        }

        public SphereDirectedParticleEmitter createDirectedSphereEmitter(System.Nullable<decimal> radius = null, Vector3 direction1 = null, Vector3 direction2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<SphereDirectedParticleEmitter>(
                entity => new SphereDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDirectedSphereEmitter" }, radius, direction1, direction2
                }
            );
        }

        public CylinderParticleEmitter createCylinderEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> height = null, System.Nullable<decimal> radiusRange = null, System.Nullable<decimal> directionRandomizer = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CylinderParticleEmitter>(
                entity => new CylinderParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createCylinderEmitter" }, radius, height, radiusRange, directionRandomizer
                }
            );
        }

        public CylinderDirectedParticleEmitter createDirectedCylinderEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> height = null, System.Nullable<decimal> radiusRange = null, Vector3 direction1 = null, Vector3 direction2 = null)
        {
            return EventHorizonBlazorInterop.FuncClass<CylinderDirectedParticleEmitter>(
                entity => new CylinderDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createDirectedCylinderEmitter" }, radius, height, radiusRange, direction1, direction2
                }
            );
        }

        public ConeParticleEmitter createConeEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> angle = null)
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
        #endregion
    }
}