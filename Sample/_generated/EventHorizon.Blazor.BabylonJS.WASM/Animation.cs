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
    public class Animation : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static bool AllowMatricesInterpolation
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "Animation.AllowMatricesInterpolation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    "BABYLON",
                    "Animation.AllowMatrixDecomposeForInterpolation"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "Animation.AllowMatrixDecomposeForInterpolation",
                    value
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_FLOAT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_FLOAT"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_VECTOR3
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_VECTOR3"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_QUATERNION
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_QUATERNION"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_MATRIX
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_MATRIX"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_COLOR3
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_COLOR3"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_COLOR4
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_COLOR4"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_VECTOR2
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_VECTOR2"
                );
            }
        }

        
        public static decimal ANIMATIONTYPE_SIZE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONTYPE_SIZE"
                );
            }
        }

        
        public static decimal ANIMATIONLOOPMODE_RELATIVE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONLOOPMODE_RELATIVE"
                );
            }
        }

        
        public static decimal ANIMATIONLOOPMODE_CYCLE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONLOOPMODE_CYCLE"
                );
            }
        }

        
        public static decimal ANIMATIONLOOPMODE_CONSTANT
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    "Animation.ANIMATIONLOOPMODE_CONSTANT"
                );
            }
        }
        #endregion

        #region Static Methods
        public static Animation CreateAnimation(string property, decimal animationType, decimal framePerSecond, EasingFunction easingFunction)
        {
            return EventHorizonBlazorInteropt.FuncClass<Animation>(
                entity => new Animation(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Animation", "CreateAnimation" }, property, animationType, framePerSecond, easingFunction
                }
            );
        }

        #region CreateAndStartAnimation TODO: Get Comments as metadata identification
        private static bool IsCreateAndStartAnimationEnabled = false;
        private static readonly IDictionary<string, Func<Task>> CreateAndStartAnimationActionMap = new Dictionary<string, Func<Task>>();

        public static string CreateAndStartAnimation(
            Func<Task> callback
        )
        {
            SetupCreateAndStartAnimationStaticLoop();

            var handle = Guid.NewGuid().ToString();
            CreateAndStartAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static void SetupCreateAndStartAnimationStaticLoop()
        {
            if (IsCreateAndStartAnimationEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.Animation.CreateAndStartAnimation",
                "CallCreateAndStartAnimationStaticActions"
            );
            IsCreateAndStartAnimationEnabled = true;
        }

        [JSInvokable]
        public static async Task CallCreateAndStartAnimationStaticActions()
        {
            foreach (var action in CreateAndStartAnimationActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region CreateAndStartHierarchyAnimation TODO: Get Comments as metadata identification
        private static bool IsCreateAndStartHierarchyAnimationEnabled = false;
        private static readonly IDictionary<string, Func<Task>> CreateAndStartHierarchyAnimationActionMap = new Dictionary<string, Func<Task>>();

        public static string CreateAndStartHierarchyAnimation(
            Func<Task> callback
        )
        {
            SetupCreateAndStartHierarchyAnimationStaticLoop();

            var handle = Guid.NewGuid().ToString();
            CreateAndStartHierarchyAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static void SetupCreateAndStartHierarchyAnimationStaticLoop()
        {
            if (IsCreateAndStartHierarchyAnimationEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.Animation.CreateAndStartHierarchyAnimation",
                "CallCreateAndStartHierarchyAnimationStaticActions"
            );
            IsCreateAndStartHierarchyAnimationEnabled = true;
        }

        [JSInvokable]
        public static async Task CallCreateAndStartHierarchyAnimationStaticActions()
        {
            foreach (var action in CreateAndStartHierarchyAnimationActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region CreateMergeAndStartAnimation TODO: Get Comments as metadata identification
        private static bool IsCreateMergeAndStartAnimationEnabled = false;
        private static readonly IDictionary<string, Func<Task>> CreateMergeAndStartAnimationActionMap = new Dictionary<string, Func<Task>>();

        public static string CreateMergeAndStartAnimation(
            Func<Task> callback
        )
        {
            SetupCreateMergeAndStartAnimationStaticLoop();

            var handle = Guid.NewGuid().ToString();
            CreateMergeAndStartAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static void SetupCreateMergeAndStartAnimationStaticLoop()
        {
            if (IsCreateMergeAndStartAnimationEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.Animation.CreateMergeAndStartAnimation",
                "CallCreateMergeAndStartAnimationStaticActions"
            );
            IsCreateMergeAndStartAnimationEnabled = true;
        }

        [JSInvokable]
        public static async Task CallCreateMergeAndStartAnimationStaticActions()
        {
            foreach (var action in CreateMergeAndStartAnimationActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region TransitionTo TODO: Get Comments as metadata identification
        private static bool IsTransitionToEnabled = false;
        private static readonly IDictionary<string, Func<Task>> TransitionToActionMap = new Dictionary<string, Func<Task>>();

        public static string TransitionTo(
            Func<Task> callback
        )
        {
            SetupTransitionToStaticLoop();

            var handle = Guid.NewGuid().ToString();
            TransitionToActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static void SetupTransitionToStaticLoop()
        {
            if (IsTransitionToEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.Animation.TransitionTo",
                "CallTransitionToStaticActions"
            );
            IsTransitionToEnabled = true;
        }

        [JSInvokable]
        public static async Task CallTransitionToStaticActions()
        {
            foreach (var action in TransitionToActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public static Animation Parse(object parsedAnimation)
        {
            return EventHorizonBlazorInteropt.FuncClass<Animation>(
                entity => new Animation(entity),
                new object[] 
                {
                    new string[] { "BABYLON", "Animation", "Parse" }, parsedAnimation
                }
            );
        }

        public static void AppendSerializedAnimations(IAnimatable source, object destination)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { "BABYLON", "Animation", "AppendSerializedAnimations" }, source, destination
                }
            );
        }
        #endregion

        #region Accessors
        
        public RuntimeAnimation[] runtimeAnimations
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<RuntimeAnimation>(
                    this.___guid,
                    "runtimeAnimations",
                    (entity) =>
                    {
                        return new RuntimeAnimation(entity);
                    }
                );
            }
        }

        
        public bool hasRunningRuntimeAnimations
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
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

        
        public string targetProperty
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "targetProperty"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "framePerSecond"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "dataType"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "loopMode"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "enableBlending"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "enableBlending",
                    value
                );
            }
        }

        
        public string[] targetPropertyPath
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<string>(
                    this.___guid,
                    "targetPropertyPath"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "blendingSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
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
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Animation" },
                name, targetProperty, framePerSecond, dataType, loopMode, enableBlending
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string toString(System.Nullable<bool> fullDetails = null)
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "toString" }, fullDetails
                }
            );
        }

        public void addEvent(AnimationEvent @event)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addEvent" }, @event
                }
            );
        }

        public void removeEvents(decimal frame)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeEvents" }, frame
                }
            );
        }

        public AnimationEvent[] getEvents()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<AnimationEvent>(
                entity => new AnimationEvent(entity),
                new object[]
                {
                    new string[] { this.___guid, "getEvents" }
                }
            );
        }

        public void createRange(string name, decimal from, decimal to)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "createRange" }, name, from, to
                }
            );
        }

        public void deleteRange(string name, System.Nullable<bool> deleteFrames = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "deleteRange" }, name, deleteFrames
                }
            );
        }

        public AnimationRange getRange(string name)
        {
            return EventHorizonBlazorInteropt.FuncClass<AnimationRange>(
                entity => new AnimationRange(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getRange" }, name
                }
            );
        }

        public IAnimationKey[] getKeys()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<IAnimationKey>(
                entity => new IAnimationKeyCachedEntity(entity),
                new object[]
                {
                    new string[] { this.___guid, "getKeys" }
                }
            );
        }

        public decimal getHighestFrame()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getHighestFrame" }
                }
            );
        }

        public IEasingFunction getEasingFunction()
        {
            return EventHorizonBlazorInteropt.FuncClass<IEasingFunction>(
                entity => new IEasingFunctionCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getEasingFunction" }
                }
            );
        }

        public void setEasingFunction(EasingFunction easingFunction)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setEasingFunction" }, easingFunction
                }
            );
        }

        public decimal floatInterpolateFunction(decimal startValue, decimal endValue, decimal gradient)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "floatInterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public decimal floatInterpolateFunctionWithTangents(decimal startValue, decimal outTangent, decimal endValue, decimal inTangent, decimal gradient)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "floatInterpolateFunctionWithTangents" }, startValue, outTangent, endValue, inTangent, gradient
                }
            );
        }

        public Quaternion quaternionInterpolateFunction(Quaternion startValue, Quaternion endValue, decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<Quaternion>(
                entity => new Quaternion(entity),
                new object[] 
                {
                    new string[] { this.___guid, "quaternionInterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public Quaternion quaternionInterpolateFunctionWithTangents(Quaternion startValue, Quaternion outTangent, Quaternion endValue, Quaternion inTangent, decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<Quaternion>(
                entity => new Quaternion(entity),
                new object[] 
                {
                    new string[] { this.___guid, "quaternionInterpolateFunctionWithTangents" }, startValue, outTangent, endValue, inTangent, gradient
                }
            );
        }

        public Vector3 vector3InterpolateFunction(Vector3 startValue, Vector3 endValue, decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "vector3InterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public Vector3 vector3InterpolateFunctionWithTangents(Vector3 startValue, Vector3 outTangent, Vector3 endValue, Vector3 inTangent, decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "vector3InterpolateFunctionWithTangents" }, startValue, outTangent, endValue, inTangent, gradient
                }
            );
        }

        public Vector2 vector2InterpolateFunction(Vector2 startValue, Vector2 endValue, decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector2>(
                entity => new Vector2(entity),
                new object[] 
                {
                    new string[] { this.___guid, "vector2InterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public Vector2 vector2InterpolateFunctionWithTangents(Vector2 startValue, Vector2 outTangent, Vector2 endValue, Vector2 inTangent, decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector2>(
                entity => new Vector2(entity),
                new object[] 
                {
                    new string[] { this.___guid, "vector2InterpolateFunctionWithTangents" }, startValue, outTangent, endValue, inTangent, gradient
                }
            );
        }

        public Size sizeInterpolateFunction(Size startValue, Size endValue, decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<Size>(
                entity => new Size(entity),
                new object[] 
                {
                    new string[] { this.___guid, "sizeInterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public Color3 color3InterpolateFunction(Color3 startValue, Color3 endValue, decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color3>(
                entity => new Color3(entity),
                new object[] 
                {
                    new string[] { this.___guid, "color3InterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public Color4 color4InterpolateFunction(Color4 startValue, Color4 endValue, decimal gradient)
        {
            return EventHorizonBlazorInteropt.FuncClass<Color4>(
                entity => new Color4(entity),
                new object[] 
                {
                    new string[] { this.___guid, "color4InterpolateFunction" }, startValue, endValue, gradient
                }
            );
        }

        public Matrix matrixInterpolateFunction(Matrix startValue, Matrix endValue, decimal gradient, Matrix result = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix>(
                entity => new Matrix(entity),
                new object[] 
                {
                    new string[] { this.___guid, "matrixInterpolateFunction" }, startValue, endValue, gradient, result
                }
            );
        }

        public Animation clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<Animation>(
                entity => new Animation(entity),
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public void setKeys(IAnimationKey[] values)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setKeys" }, values
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
        #endregion
    }
}