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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Animation>))]
    public class Animation : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static bool AllowMatricesInterpolation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Animation.AllowMatricesInterpolation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Animation.AllowMatricesInterpolation",
                    value
                );
            }
        }

        
        public static bool AllowMatrixDecomposeForInterpolation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Animation.AllowMatrixDecomposeForInterpolation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Animation.AllowMatrixDecomposeForInterpolation",
                    value
                );
            }
        }

        
        public static string SnippetUrl
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "Animation.SnippetUrl"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Animation.SnippetUrl",
                    value
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_FLOAT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_FLOAT"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_VECTOR3
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_VECTOR3"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_QUATERNION
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_QUATERNION"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_MATRIX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_MATRIX"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_COLOR3
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_COLOR3"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_COLOR4
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_COLOR4"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_VECTOR2
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_VECTOR2"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_SIZE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_SIZE"
                );
            }
        }

        
        public static decimal ANIMATIONLOOPMODE_RELATIVE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONLOOPMODE_RELATIVE"
                );
            }
        }

        
        public static decimal ANIMATIONLOOPMODE_CYCLE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONLOOPMODE_CYCLE"
                );
            }
        }

        
        public static decimal ANIMATIONLOOPMODE_CONSTANT
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONLOOPMODE_CONSTANT"
                );
            }
        }
        #endregion

        #region Static Methods
        public static Animation CreateAnimation(string property, decimal animationType, decimal framePerSecond, EasingFunction easingFunction)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "CreateAnimation" }, property, animationType, framePerSecond, easingFunction
                }
            );
        }

        public static Animatable CreateAndStartAnimation(string name, Node node, string targetProperty, decimal framePerSecond, decimal totalFrame, object from, object to, System.Nullable<decimal> loopMode = null, EasingFunction easingFunction = null, ActionCallback onAnimationEnd = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "CreateAndStartAnimation" }, name, node, targetProperty, framePerSecond, totalFrame, from, to, loopMode, easingFunction, onAnimationEnd
                }
            );
        }

        public static Animatable[] CreateAndStartHierarchyAnimation(string name, Node node, bool directDescendantsOnly, string targetProperty, decimal framePerSecond, decimal totalFrame, object from, object to, System.Nullable<decimal> loopMode = null, EasingFunction easingFunction = null, ActionCallback onAnimationEnd = null)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "CreateAndStartHierarchyAnimation" }, name, node, directDescendantsOnly, targetProperty, framePerSecond, totalFrame, from, to, loopMode, easingFunction, onAnimationEnd
                }
            );
        }

        public static Animatable CreateMergeAndStartAnimation(string name, Node node, string targetProperty, decimal framePerSecond, decimal totalFrame, object from, object to, System.Nullable<decimal> loopMode = null, EasingFunction easingFunction = null, ActionCallback onAnimationEnd = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "CreateMergeAndStartAnimation" }, name, node, targetProperty, framePerSecond, totalFrame, from, to, loopMode, easingFunction, onAnimationEnd
                }
            );
        }

        public static Animation MakeAnimationAdditive(Animation sourceAnimation, System.Nullable<decimal> referenceFrame = null, string range = null, System.Nullable<bool> cloneOriginal = null, string clonedName = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "MakeAnimationAdditive" }, sourceAnimation, referenceFrame, range, cloneOriginal, clonedName
                }
            );
        }

        public static Animatable TransitionTo(string property, object targetValue, object host, Scene scene, decimal frameRate, Animation transition, decimal duration, ActionCallback onAnimationEnd = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "TransitionTo" }, property, targetValue, host, scene, frameRate, transition, duration, onAnimationEnd
                }
            );
        }

        public static Animation Parse(object parsedAnimation)
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "Parse" }, parsedAnimation
                }
            );
        }

        public static void AppendSerializedAnimations(IAnimatable source, object destination)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "AppendSerializedAnimations" }, source, destination
                }
            );
        }

        public static ValueTask<Animation> ParseFromFileAsync(string url, string name = null)
        {
            return EventHorizonBlazorInterop.TaskClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "ParseFromFileAsync" }, name, url
                }
            );
        }

        public static ValueTask<Animation> CreateFromSnippetAsync(string snippetId)
        {
            return EventHorizonBlazorInterop.TaskClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "CreateFromSnippetAsync" }, snippetId
                }
            );
        }
        #endregion

        #region Accessors
        
        public RuntimeAnimation[] runtimeAnimations
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<RuntimeAnimation>(
                    this.___guid,
                    "runtimeAnimations",
                    (entity) =>
                    {
                        return new RuntimeAnimation() { ___guid = entity.___guid };
                    }
                );
            }
        }

        
        public bool hasRunningRuntimeAnimations
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasRunningRuntimeAnimations"
                );
            }
        }
        #endregion

        #region Properties
        
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

        
        public string targetProperty
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "targetProperty"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "targetProperty",
                    value
                );
            }
        }

        
        public decimal framePerSecond
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "framePerSecond"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "framePerSecond",
                    value
                );
            }
        }

        
        public decimal dataType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "dataType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dataType",
                    value
                );
            }
        }

        
        public decimal loopMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loopMode"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loopMode",
                    value
                );
            }
        }

        
        public bool enableBlending
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableBlending"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableBlending",
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

        
        public string[] targetPropertyPath
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "targetPropertyPath"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "targetPropertyPath",
                    value
                );
            }
        }

        
        public decimal blendingSpeed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blendingSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendingSpeed",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Animation() : base() { }

        public Animation(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Animation(
            string name, string targetProperty, decimal framePerSecond, decimal dataType, System.Nullable<decimal> loopMode = null, System.Nullable<bool> enableBlending = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Animation" },
                name, targetProperty, framePerSecond, dataType, loopMode, enableBlending
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }

        public void addEvent(AnimationEvent @event)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEvent" }, @event
                }
            );
        }

        public void removeEvents(decimal frame)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeEvents" }, frame
                }
            );
        }

        public AnimationEvent[] getEvents()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<AnimationEvent>(
                entity => new AnimationEvent() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEvents" }
                }
            );
        }

        public void createRange(string name, decimal from, decimal to)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "createRange" }, name, from, to
                }
            );
        }

        public void deleteRange(string name, System.Nullable<bool> deleteFrames = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "deleteRange" }, name, deleteFrames
                }
            );
        }

        public AnimationRange getRange(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<AnimationRange>(
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRange" }, name
                }
            );
        }

        public IAnimationKeyCachedEntity[] getKeys()
        {
            return EventHorizonBlazorInterop.FuncArrayClass<IAnimationKeyCachedEntity>(
                entity => new IAnimationKeyCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getKeys" }
                }
            );
        }

        public decimal getHighestFrame()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getHighestFrame" }
                }
            );
        }

        public IEasingFunctionCachedEntity getEasingFunction()
        {
            return EventHorizonBlazorInterop.FuncClass<IEasingFunctionCachedEntity>(
                entity => new IEasingFunctionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEasingFunction" }
                }
            );
        }

        public void setEasingFunction(EasingFunction easingFunction)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setEasingFunction" }, easingFunction
                }
            );
        }

        public decimal floatInterpolateFunction(decimal startValue, decimal endValue, decimal gradient)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "floatInterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public decimal floatInterpolateFunctionWithTangents(decimal startValue, decimal outTangent, decimal endValue, decimal inTangent, decimal gradient)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "floatInterpolateFunctionWithTangents" }, startValue, outTangent, endValue, inTangent, gradient
                }
            );
        }

        public Quaternion quaternionInterpolateFunction(Quaternion startValue, Quaternion endValue, decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "quaternionInterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public Quaternion quaternionInterpolateFunctionWithTangents(Quaternion startValue, Quaternion outTangent, Quaternion endValue, Quaternion inTangent, decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "quaternionInterpolateFunctionWithTangents" }, startValue, outTangent, endValue, inTangent, gradient
                }
            );
        }

        public Vector3 vector3InterpolateFunction(Vector3 startValue, Vector3 endValue, decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "vector3InterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public Vector3 vector3InterpolateFunctionWithTangents(Vector3 startValue, Vector3 outTangent, Vector3 endValue, Vector3 inTangent, decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "vector3InterpolateFunctionWithTangents" }, startValue, outTangent, endValue, inTangent, gradient
                }
            );
        }

        public Vector2 vector2InterpolateFunction(Vector2 startValue, Vector2 endValue, decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "vector2InterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public Vector2 vector2InterpolateFunctionWithTangents(Vector2 startValue, Vector2 outTangent, Vector2 endValue, Vector2 inTangent, decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "vector2InterpolateFunctionWithTangents" }, startValue, outTangent, endValue, inTangent, gradient
                }
            );
        }

        public Size sizeInterpolateFunction(Size startValue, Size endValue, decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "sizeInterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public Color3 color3InterpolateFunction(Color3 startValue, Color3 endValue, decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "color3InterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public Color4 color4InterpolateFunction(Color4 startValue, Color4 endValue, decimal gradient)
        {
            return EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "color4InterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public Matrix matrixInterpolateFunction(Matrix startValue, Matrix endValue, decimal gradient, Matrix result = null)
        {
            return EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "matrixInterpolateFunction" }, startValue, endValue, gradient, result
                }
            );
        }

        public Animation clone()
        {
            return EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public void setKeys(IAnimationKey[] values)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setKeys" }, values
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