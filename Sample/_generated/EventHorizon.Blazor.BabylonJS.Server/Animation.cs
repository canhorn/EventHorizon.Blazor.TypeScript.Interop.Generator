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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Animation>))]
    public class Animation : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static async ValueTask<bool> get_AllowMatricesInterpolation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Animation.AllowMatricesInterpolation"
                );
        }
        public static ValueTask set_AllowMatricesInterpolation(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Animation.AllowMatricesInterpolation",
                    value
                );
        }

        
        public static async ValueTask<bool> get_AllowMatrixDecomposeForInterpolation()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    "BABYLON",
                    "Animation.AllowMatrixDecomposeForInterpolation"
                );
        }
        public static ValueTask set_AllowMatrixDecomposeForInterpolation(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Animation.AllowMatrixDecomposeForInterpolation",
                    value
                );
        }

        
        public static async ValueTask<string> get_SnippetUrl()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    "BABYLON",
                    "Animation.SnippetUrl"
                );
        }
        public static ValueTask set_SnippetUrl(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Animation.SnippetUrl",
                    value
                );
        }

        
        public static async ValueTask<decimal> get_ANIMATIONTYPE_FLOAT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_FLOAT"
                );
        }

        
        public static async ValueTask<decimal> get_ANIMATIONTYPE_VECTOR3()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_VECTOR3"
                );
        }

        
        public static async ValueTask<decimal> get_ANIMATIONTYPE_QUATERNION()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_QUATERNION"
                );
        }

        
        public static async ValueTask<decimal> get_ANIMATIONTYPE_MATRIX()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_MATRIX"
                );
        }

        
        public static async ValueTask<decimal> get_ANIMATIONTYPE_COLOR3()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_COLOR3"
                );
        }

        
        public static async ValueTask<decimal> get_ANIMATIONTYPE_COLOR4()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_COLOR4"
                );
        }

        
        public static async ValueTask<decimal> get_ANIMATIONTYPE_VECTOR2()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_VECTOR2"
                );
        }

        
        public static async ValueTask<decimal> get_ANIMATIONTYPE_SIZE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_SIZE"
                );
        }

        
        public static async ValueTask<decimal> get_ANIMATIONLOOPMODE_RELATIVE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONLOOPMODE_RELATIVE"
                );
        }

        
        public static async ValueTask<decimal> get_ANIMATIONLOOPMODE_CYCLE()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONLOOPMODE_CYCLE"
                );
        }

        
        public static async ValueTask<decimal> get_ANIMATIONLOOPMODE_CONSTANT()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONLOOPMODE_CONSTANT"
                );
        }
        #endregion

        #region Static Methods
        public static async ValueTask<Animation> CreateAnimation(string property, decimal animationType, decimal framePerSecond, EasingFunction easingFunction)
        {
            return await EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Animation", "CreateAnimation" }, property, animationType, framePerSecond, easingFunction
                }
            );
        }

        public static async ValueTask<Animatable> CreateAndStartAnimation(string name, Node node, string targetProperty, decimal framePerSecond, decimal totalFrame, object from, object to, System.Nullable<decimal> loopMode = null, EasingFunction easingFunction = null, ActionCallback onAnimationEnd = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Animation", "CreateAndStartAnimation" }, name, node, targetProperty, framePerSecond, totalFrame, from, to, loopMode, easingFunction, onAnimationEnd
                }
            );
        }

        public static async ValueTask<Animatable[]> CreateAndStartHierarchyAnimation(string name, Node node, bool directDescendantsOnly, string targetProperty, decimal framePerSecond, decimal totalFrame, object from, object to, System.Nullable<decimal> loopMode = null, EasingFunction easingFunction = null, ActionCallback onAnimationEnd = null)
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "CreateAndStartHierarchyAnimation" }, name, node, directDescendantsOnly, targetProperty, framePerSecond, totalFrame, from, to, loopMode, easingFunction, onAnimationEnd
                }
            );
        }

        public static async ValueTask<Animatable> CreateMergeAndStartAnimation(string name, Node node, string targetProperty, decimal framePerSecond, decimal totalFrame, object from, object to, System.Nullable<decimal> loopMode = null, EasingFunction easingFunction = null, ActionCallback onAnimationEnd = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Animation", "CreateMergeAndStartAnimation" }, name, node, targetProperty, framePerSecond, totalFrame, from, to, loopMode, easingFunction, onAnimationEnd
                }
            );
        }

        public static async ValueTask<Animation> MakeAnimationAdditive(Animation sourceAnimation, System.Nullable<decimal> referenceFrame = null, string range = null, System.Nullable<bool> cloneOriginal = null, string clonedName = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Animation", "MakeAnimationAdditive" }, sourceAnimation, referenceFrame, range, cloneOriginal, clonedName
                }
            );
        }

        public static async ValueTask<Animatable> TransitionTo(string property, object targetValue, object host, Scene scene, decimal frameRate, Animation transition, decimal duration, ActionCallback onAnimationEnd = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Animatable>(
                entity => new Animatable() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Animation", "TransitionTo" }, property, targetValue, host, scene, frameRate, transition, duration, onAnimationEnd
                }
            );
        }

        public static async ValueTask<Animation> Parse(object parsedAnimation)
        {
            return await EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "Animation", "Parse" }, parsedAnimation
                }
            );
        }

        public static async ValueTask AppendSerializedAnimations(IAnimatable source, object destination)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Animation", "AppendSerializedAnimations" }, source, destination
                }
            );
        }

        public static async ValueTask<Animation> ParseFromFileAsync(string url, string name = null)
        {
            return await EventHorizonBlazorInterop.TaskClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "ParseFromFileAsync" }, name, url
                }
            );
        }

        public static async ValueTask<Animation> CreateFromSnippetAsync(string snippetId)
        {
            return await EventHorizonBlazorInterop.TaskClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "Animation", "CreateFromSnippetAsync" }, snippetId
                }
            );
        }
        #endregion

        #region Accessors
        
        public async ValueTask<RuntimeAnimation[]> get_runtimeAnimations()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<RuntimeAnimation>(
                    this.___guid,
                    "runtimeAnimations",
                    (entity) =>
                    {
                        return new RuntimeAnimation() { ___guid = entity.___guid };
                    }
                );
        }

        
        public async ValueTask<bool> get_hasRunningRuntimeAnimations()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasRunningRuntimeAnimations"
                );
        }
        #endregion

        #region Properties
        
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

        
        public async ValueTask<string> get_targetProperty()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "targetProperty"
                );
        }
        public ValueTask set_targetProperty(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "targetProperty",
                    value
                );
        }

        
        public async ValueTask<decimal> get_framePerSecond()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "framePerSecond"
                );
        }
        public ValueTask set_framePerSecond(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "framePerSecond",
                    value
                );
        }

        
        public async ValueTask<decimal> get_dataType()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "dataType"
                );
        }
        public ValueTask set_dataType(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dataType",
                    value
                );
        }

        
        public async ValueTask<decimal> get_loopMode()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "loopMode"
                );
        }
        public ValueTask set_loopMode(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "loopMode",
                    value
                );
        }

        
        public async ValueTask<bool> get_enableBlending()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableBlending"
                );
        }
        public ValueTask set_enableBlending(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableBlending",
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

        
        public async ValueTask<string[]> get_targetPropertyPath()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "targetPropertyPath"
                );
        }
        public ValueTask set_targetPropertyPath(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "targetPropertyPath",
                    value
                );
        }

        
        public async ValueTask<decimal> get_blendingSpeed()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blendingSpeed"
                );
        }
        public ValueTask set_blendingSpeed(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blendingSpeed",
                    value
                );
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

        public static async ValueTask<Animation> NewAnimation(
            string name, string targetProperty, decimal framePerSecond, decimal dataType, System.Nullable<decimal> loopMode = null, System.Nullable<bool> enableBlending = null
        )
        {
            var entity = await EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Animation" },
                name, targetProperty, framePerSecond, dataType, loopMode, enableBlending
            );

            return new Animation(entity);
        }
        #endregion

        #region Methods
        public async ValueTask<string> toString(System.Nullable<bool> fullDetails = null)
        {
            return await EventHorizonBlazorInterop.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }

        public async ValueTask addEvent(AnimationEvent @event)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addEvent" }, @event
                }
            );
        }

        public async ValueTask removeEvents(decimal frame)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeEvents" }, frame
                }
            );
        }

        public async ValueTask<AnimationEvent[]> getEvents()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<AnimationEvent>(
                entity => new AnimationEvent() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEvents" }
                }
            );
        }

        public async ValueTask createRange(string name, decimal from, decimal to)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "createRange" }, name, from, to
                }
            );
        }

        public async ValueTask deleteRange(string name, System.Nullable<bool> deleteFrames = null)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "deleteRange" }, name, deleteFrames
                }
            );
        }

        public async ValueTask<AnimationRange> getRange(string name)
        {
            return await EventHorizonBlazorInterop.FuncClass<AnimationRange>(
                entity => new AnimationRange() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getRange" }, name
                }
            );
        }

        public async ValueTask<IAnimationKeyCachedEntity[]> getKeys()
        {
            return await EventHorizonBlazorInterop.FuncArrayClass<IAnimationKeyCachedEntity>(
                entity => new IAnimationKeyCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getKeys" }
                }
            );
        }

        public async ValueTask<decimal> getHighestFrame()
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getHighestFrame" }
                }
            );
        }

        public async ValueTask<IEasingFunctionCachedEntity> getEasingFunction()
        {
            return await EventHorizonBlazorInterop.FuncClass<IEasingFunctionCachedEntity>(
                entity => new IEasingFunctionCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getEasingFunction" }
                }
            );
        }

        public async ValueTask setEasingFunction(EasingFunction easingFunction)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setEasingFunction" }, easingFunction
                }
            );
        }

        public async ValueTask<decimal> floatInterpolateFunction(decimal startValue, decimal endValue, decimal gradient)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "floatInterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public async ValueTask<decimal> floatInterpolateFunctionWithTangents(decimal startValue, decimal outTangent, decimal endValue, decimal inTangent, decimal gradient)
        {
            return await EventHorizonBlazorInterop.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "floatInterpolateFunctionWithTangents" }, startValue, outTangent, endValue, inTangent, gradient
                }
            );
        }

        public async ValueTask<Quaternion> quaternionInterpolateFunction(Quaternion startValue, Quaternion endValue, decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "quaternionInterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public async ValueTask<Quaternion> quaternionInterpolateFunctionWithTangents(Quaternion startValue, Quaternion outTangent, Quaternion endValue, Quaternion inTangent, decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<Quaternion>(
                entity => new Quaternion() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "quaternionInterpolateFunctionWithTangents" }, startValue, outTangent, endValue, inTangent, gradient
                }
            );
        }

        public async ValueTask<Vector3> vector3InterpolateFunction(Vector3 startValue, Vector3 endValue, decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "vector3InterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public async ValueTask<Vector3> vector3InterpolateFunctionWithTangents(Vector3 startValue, Vector3 outTangent, Vector3 endValue, Vector3 inTangent, decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector3>(
                entity => new Vector3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "vector3InterpolateFunctionWithTangents" }, startValue, outTangent, endValue, inTangent, gradient
                }
            );
        }

        public async ValueTask<Vector2> vector2InterpolateFunction(Vector2 startValue, Vector2 endValue, decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "vector2InterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public async ValueTask<Vector2> vector2InterpolateFunctionWithTangents(Vector2 startValue, Vector2 outTangent, Vector2 endValue, Vector2 inTangent, decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<Vector2>(
                entity => new Vector2() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "vector2InterpolateFunctionWithTangents" }, startValue, outTangent, endValue, inTangent, gradient
                }
            );
        }

        public async ValueTask<Size> sizeInterpolateFunction(Size startValue, Size endValue, decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<Size>(
                entity => new Size() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "sizeInterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public async ValueTask<Color3> color3InterpolateFunction(Color3 startValue, Color3 endValue, decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color3>(
                entity => new Color3() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "color3InterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public async ValueTask<Color4> color4InterpolateFunction(Color4 startValue, Color4 endValue, decimal gradient)
        {
            return await EventHorizonBlazorInterop.FuncClass<Color4>(
                entity => new Color4() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "color4InterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public async ValueTask<Matrix> matrixInterpolateFunction(Matrix startValue, Matrix endValue, decimal gradient, Matrix result = null)
        {
            return await EventHorizonBlazorInterop.FuncClass<Matrix>(
                entity => new Matrix() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "matrixInterpolateFunction" }, startValue, endValue, gradient, result
                }
            );
        }

        public async ValueTask<Animation> clone()
        {
            return await EventHorizonBlazorInterop.FuncClass<Animation>(
                entity => new Animation() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public async ValueTask setKeys(IAnimationKey[] values)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setKeys" }, values
                }
            );
        }

        public async ValueTask<CachedEntity> serialize()
        {
            return await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}