/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class BaseParticleSystem : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal BLENDMODE_ONEONE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_ONEONE"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_STANDARD"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_ADD"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_MULTIPLY"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "BaseParticleSystem.BLENDMODE_MULTIPLYADD"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __noiseTexture = EventHorizonBlazorInteropt.GetClass<ProceduralTexture>(
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
                EventHorizonBlazorInteropt.Set(
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

        private Vector3 __direction1;
        public Vector3 direction1
        {
            get
            {
            if(__direction1 == null)
            {
                __direction1 = EventHorizonBlazorInteropt.GetClass<Vector3>(
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
                EventHorizonBlazorInteropt.Set(
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
                __direction2 = EventHorizonBlazorInteropt.GetClass<Vector3>(
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
                EventHorizonBlazorInteropt.Set(
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
                __minEmitBox = EventHorizonBlazorInteropt.GetClass<Vector3>(
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
                EventHorizonBlazorInteropt.Set(
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
                __maxEmitBox = EventHorizonBlazorInteropt.GetClass<Vector3>(
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
                EventHorizonBlazorInteropt.Set(
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

        private ImageProcessingConfiguration __imageProcessingConfiguration;
        public ImageProcessingConfiguration imageProcessingConfiguration
        {
            get
            {
            if(__imageProcessingConfiguration == null)
            {
                __imageProcessingConfiguration = EventHorizonBlazorInteropt.GetClass<ImageProcessingConfiguration>(
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
                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.GetArrayClass<Animation>(
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

        private AbstractMesh __emitter;
        public AbstractMesh emitter
        {
            get
            {
            if(__emitter == null)
            {
                __emitter = EventHorizonBlazorInteropt.GetClass<AbstractMesh>(
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
                EventHorizonBlazorInteropt.Set(
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

        
        public decimal manualEmitCount
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "manualEmitCount"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                        return new Texture() { ___guid = entity.___guid };
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

        
        public CachedEntity customShader
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "customShader"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "preventAutoStart"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                __noiseStrength = EventHorizonBlazorInteropt.GetClass<Vector3>(
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
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "noiseStrength",
                    value
                );
            }
        }

        
        public CachedEntity onAnimationEnd
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<CachedEntity>(
                    this.___guid,
                    "onAnimationEnd"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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

        
        public bool forceDepthWrite
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "forceDepthWrite"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
                        return new Vector2() { ___guid = entity.___guid };
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

        private Vector3 __worldOffset;
        public Vector3 worldOffset
        {
            get
            {
            if(__worldOffset == null)
            {
                __worldOffset = EventHorizonBlazorInteropt.GetClass<Vector3>(
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
                EventHorizonBlazorInteropt.Set(
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
                __gravity = EventHorizonBlazorInteropt.GetClass<Vector3>(
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
                EventHorizonBlazorInteropt.Set(
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
                        return new Color4() { ___guid = entity.___guid };
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
                        return new Color4() { ___guid = entity.___guid };
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
                        return new Color4() { ___guid = entity.___guid };
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

        private Color4 __textureMask;
        public Color4 textureMask
        {
            get
            {
            if(__textureMask == null)
            {
                __textureMask = EventHorizonBlazorInteropt.GetClass<Color4>(
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
                EventHorizonBlazorInteropt.Set(
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
                __particleEmitterType = EventHorizonBlazorInteropt.GetClass<IParticleEmitterTypeCachedEntity>(
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
                EventHorizonBlazorInteropt.Set(
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
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "BaseParticleSystem" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public Scene getScene()
        {
            return EventHorizonBlazorInteropt.FuncClass<Scene>(
                entity => new Scene() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getScene" }
                }
            );
        }

        public FactorGradient[] getDragGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getDragGradients" }
                }
            );
        }

        public FactorGradient[] getLimitVelocityGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLimitVelocityGradients" }
                }
            );
        }

        public ColorGradient[] getColorGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<ColorGradient>(
                entity => new ColorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getColorGradients" }
                }
            );
        }

        public FactorGradient[] getSizeGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getSizeGradients" }
                }
            );
        }

        public FactorGradient[] getColorRemapGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getColorRemapGradients" }
                }
            );
        }

        public FactorGradient[] getAlphaRemapGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAlphaRemapGradients" }
                }
            );
        }

        public FactorGradient[] getLifeTimeGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getLifeTimeGradients" }
                }
            );
        }

        public FactorGradient[] getAngularSpeedGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getAngularSpeedGradients" }
                }
            );
        }

        public FactorGradient[] getVelocityGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getVelocityGradients" }
                }
            );
        }

        public FactorGradient[] getStartSizeGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getStartSizeGradients" }
                }
            );
        }

        public FactorGradient[] getEmitRateGradients()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<FactorGradient>(
                entity => new FactorGradient() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEmitRateGradients" }
                }
            );
        }

        public PointParticleEmitter createPointEmitter(Vector3 direction1, Vector3 direction2)
        {
            return EventHorizonBlazorInteropt.FuncClass<PointParticleEmitter>(
                entity => new PointParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createPointEmitter" }, direction1, direction2
                }
            );
        }

        public HemisphericParticleEmitter createHemisphericEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> radiusRange = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<HemisphericParticleEmitter>(
                entity => new HemisphericParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createHemisphericEmitter" }, radius, radiusRange
                }
            );
        }

        public SphereParticleEmitter createSphereEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> radiusRange = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<SphereParticleEmitter>(
                entity => new SphereParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createSphereEmitter" }, radius, radiusRange
                }
            );
        }

        public SphereDirectedParticleEmitter createDirectedSphereEmitter(System.Nullable<decimal> radius = null, Vector3 direction1 = null, Vector3 direction2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<SphereDirectedParticleEmitter>(
                entity => new SphereDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createDirectedSphereEmitter" }, radius, direction1, direction2
                }
            );
        }

        public CylinderParticleEmitter createCylinderEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> height = null, System.Nullable<decimal> radiusRange = null, System.Nullable<decimal> directionRandomizer = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<CylinderParticleEmitter>(
                entity => new CylinderParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createCylinderEmitter" }, radius, height, radiusRange, directionRandomizer
                }
            );
        }

        public CylinderDirectedParticleEmitter createDirectedCylinderEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> height = null, System.Nullable<decimal> radiusRange = null, Vector3 direction1 = null, Vector3 direction2 = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<CylinderDirectedParticleEmitter>(
                entity => new CylinderDirectedParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createDirectedCylinderEmitter" }, radius, height, radiusRange, direction1, direction2
                }
            );
        }

        public ConeParticleEmitter createConeEmitter(System.Nullable<decimal> radius = null, System.Nullable<decimal> angle = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<ConeParticleEmitter>(
                entity => new ConeParticleEmitter() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "createConeEmitter" }, radius, angle
                }
            );
        }

        public BoxParticleEmitter createBoxEmitter(Vector3 direction1, Vector3 direction2, Vector3 minEmitBox, Vector3 maxEmitBox)
        {
            return EventHorizonBlazorInteropt.FuncClass<BoxParticleEmitter>(
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