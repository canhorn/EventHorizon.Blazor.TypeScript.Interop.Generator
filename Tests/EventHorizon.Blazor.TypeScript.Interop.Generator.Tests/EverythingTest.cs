using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Sdcb.TypeScript;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests
{
    public class EverythingTest
    {
        [Fact]
        public void ShouldGenerateString()
        {
            // Given
            var sourceFile = "Everything.ts";
            var source = File.ReadAllText(Path.Combine(
                ".", 
                "SourceFiles", 
                sourceFile
            ));
            var ast = new TypeScriptAST(
                source, 
                sourceFile
            );

            // When
            var generated = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "Everything",
                ast
            );
            var actual = GenerateClassStatementString.Generate(
                generated
            );

            // Then
            actual.Should().Be(expected);

        }

        string expected = @"/// Generated - Do Not Edit
namespace BabylonJS.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Everything : Otherthing, IDisposable
    {
        #region Static Accessors
        
        public static decimal Now
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    ""BABYLON"",
                    ""GUI.Everything.Now""
                );
            }
        }

        
        public static decimal[] NowValues
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    ""BABYLON"",
                    ""GUI.Everything.NowValues""
                );
            }
        }

        
        public static decimal UNITMODE_PERCENTAGE
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    ""BABYLON"",
                    ""GUI.Everything.UNITMODE_PERCENTAGE""
                );
            }
        }

        private static Vector3 __Up;
        public static Vector3 Up
        {
            get
            {
            if(__Up == null)
            {
                __Up = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    ""BABYLON"",
                    ""GUI.Everything.Up"",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __Up;
            }
        }

        
        public static Vector3[] Downs
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Vector3>(
                    ""BABYLON"",
                    ""GUI.Everything.Downs"",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
        }

        private static IInterfaceResponseType __InterfaceResponseType;
        public static IInterfaceResponseType InterfaceResponseType
        {
            get
            {
            if(__InterfaceResponseType == null)
            {
                __InterfaceResponseType = EventHorizonBlazorInteropt.GetClass<IInterfaceResponseType>(
                    ""BABYLON"",
                    ""GUI.Everything.InterfaceResponseType"",
                    (entity) =>
                    {
                        return new IInterfaceResponseTypeCachedEntity(entity);
                    }
                );
            }
            return __InterfaceResponseType;
            }
        }
        #endregion

        #region Static Properties
        
        public static decimal NoneLogLevel
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    ""BABYLON"",
                    ""GUI.Everything.NoneLogLevel""
                );
            }
        }

        
        public static decimal[] LogLevels
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    ""BABYLON"",
                    ""GUI.Everything.LogLevels""
                );
            }
        }

        private static Vector3 __Vector3LogLevel;
        public static Vector3 Vector3LogLevel
        {
            get
            {
            if(__Vector3LogLevel == null)
            {
                __Vector3LogLevel = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    ""BABYLON"",
                    ""GUI.Everything.Vector3LogLevel"",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
            return __Vector3LogLevel;
            }
        }

        
        public static Vector3[] Vector3List
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Vector3>(
                    ""BABYLON"",
                    ""GUI.Everything.Vector3List"",
                    (entity) =>
                    {
                        return new Vector3(entity);
                    }
                );
            }
        }
        #endregion

        #region Static Methods
        public static void makeObserverTopPriority(Observer observer)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { ""BABYLON"", ""GUI"", ""Everything"", ""makeObserverTopPriority"" }, observer
                }
            );
        }

        #region OnNewCacheEntry TODO: Get Comments as metadata identification
        private static bool IsOnNewCacheEntryEnabled = false;
        private static readonly IDictionary<string, Func<Task>> OnNewCacheEntryActionMap = new Dictionary<string, Func<Task>>();

        public static string OnNewCacheEntry(
            Func<Task> callback
        )
        {
            SetupOnNewCacheEntryStaticLoop();

            var handle = Guid.NewGuid().ToString();
            OnNewCacheEntryActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static void SetupOnNewCacheEntryStaticLoop()
        {
            if (IsOnNewCacheEntryEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.AssemblyFuncCallback(
                ""ProjectAssembly"",
                ""BABYLON.GUI.Everything.OnNewCacheEntry"",
                ""CallOnNewCacheEntryStaticActions""
            );
            IsOnNewCacheEntryEnabled = true;
        }

        [JSInvokable]
        public static async Task CallOnNewCacheEntryStaticActions()
        {
            foreach (var action in OnNewCacheEntryActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public static Matrix2D Identity()
        {
            return EventHorizonBlazorInteropt.FuncClass<Matrix2D>(
                entity => new Matrix2D(entity),
                new object[] 
                {
                    new string[] { ""BABYLON"", ""GUI"", ""Everything"", ""Identity"" }
                }
            );
        }

        public static Matrix2D[] Identitys()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<Matrix2D>(
                entity => new Matrix2D(entity),
                new object[]
                {
                    new string[] { ""BABYLON"", ""GUI"", ""Everything"", ""Identitys"" }
                }
            );
        }

        public static decimal[] numberArray()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { ""BABYLON"", ""GUI"", ""Everything"", ""numberArray"" }
                }
            );
        }

        public static decimal numberMethod()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { ""BABYLON"", ""GUI"", ""Everything"", ""numberMethod"" }
                }
            );
        }

        public static decimal[] numberArrayObj()
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { ""BABYLON"", ""GUI"", ""Everything"", ""numberArrayObj"" }
                }
            );
        }

        public static Vector3 FromArray(decimal[] array, System.Nullable<decimal> offset = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector3>(
                entity => new Vector3(entity),
                new object[] 
                {
                    new string[] { ""BABYLON"", ""GUI"", ""Everything"", ""FromArray"" }, array, offset
                }
            );
        }
        #endregion

        #region Accessors
        private AbstractMesh __linkedMesh;
        public AbstractMesh linkedMesh
        {
            get
            {
            if(__linkedMesh == null)
            {
                __linkedMesh = EventHorizonBlazorInteropt.GetClass<AbstractMesh>(
                    this.___guid,
                    ""linkedMesh"",
                    (entity) =>
                    {
                        return new AbstractMesh(entity);
                    }
                );
            }
            return __linkedMesh;
            }
        }

        
        public Observer[] observers
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Observer>(
                    this.___guid,
                    ""observers"",
                    (entity) =>
                    {
                        return new Observer(entity);
                    }
                );
            }
        }

        
        public string[] texts
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<string>(
                    this.___guid,
                    ""texts""
                );
            }
        }

        
        public string text
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    ""text""
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    ""text"",
                    value
                );
            }
        }

        private Style __style;
        public Style style
        {
            get
            {
            if(__style == null)
            {
                __style = EventHorizonBlazorInteropt.GetClass<Style>(
                    this.___guid,
                    ""style"",
                    (entity) =>
                    {
                        return new Style(entity);
                    }
                );
            }
            return __style;
            }
            set
            {
__style = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    ""style"",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal num
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    ""num""
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    ""num"",
                    value
                );
            }
        }

        
        public string width
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    ""width""
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    ""width"",
                    value
                );
            }
        }

        
        public string[] widths
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<string>(
                    this.___guid,
                    ""widths""
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    ""widths"",
                    value
                );
            }
        }

        private Vector2 __height;
        public Vector2 height
        {
            get
            {
            if(__height == null)
            {
                __height = EventHorizonBlazorInteropt.GetClass<Vector2>(
                    this.___guid,
                    ""height"",
                    (entity) =>
                    {
                        return new Vector2(entity);
                    }
                );
            }
            return __height;
            }
            set
            {
__height = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    ""height"",
                    value
                );
            }
        }

        
        public Vector2[] matrix
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Vector2>(
                    this.___guid,
                    ""matrix"",
                    (entity) =>
                    {
                        return new Vector2(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    ""matrix"",
                    value
                );
            }
        }

        
        public decimal[] floatArrayExample
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    ""floatArrayExample""
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    ""floatArrayExample"",
                    value
                );
            }
        }

        
        public decimal[] float32ArrayExample
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    ""float32ArrayExample""
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    ""float32ArrayExample"",
                    value
                );
            }
        }

        
        public decimal[] indicesArrayExample
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    ""indicesArrayExample""
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    ""indicesArrayExample"",
                    value
                );
            }
        }

        
        public decimal[] uint8ArrayExample
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    ""uint8ArrayExample""
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    ""uint8ArrayExample"",
                    value
                );
            }
        }

        private URL __webkitURL;
        public URL webkitURL
        {
            get
            {
            if(__webkitURL == null)
            {
                __webkitURL = EventHorizonBlazorInteropt.GetClass<URL>(
                    this.___guid,
                    ""webkitURL"",
                    (entity) =>
                    {
                        return new URL(entity);
                    }
                );
            }
            return __webkitURL;
            }
            set
            {
__webkitURL = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    ""webkitURL"",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Everything() : base() { }

        public Everything(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public Everything(
            string arg1, object arg2, System.Nullable<decimal> arg3 = null, System.Nullable<decimal> arg4 = null, Class3 arg5 = null, object arg6 = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { ""BABYLON"", ""GUI"", ""Everything"" },
                arg1, arg2, arg3, arg4, arg5, arg6
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void javaScriptApiFunctionClass()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, ""javaScriptApiFunctionClass"" }
                }
            );
        }

        public void literalTypeArgument(object literal)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, ""literalTypeArgument"" }, literal
                }
            );
        }

        public bool isEqualsTo(Measure other)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, ""isEqualsTo"" }, other
                }
            );
        }

        public bool[] isBooleans()
        {
            return EventHorizonBlazorInteropt.FuncArray<bool>(
                new object[]
                {
                    new string[] { this.___guid, ""isBooleans"" }
                }
            );
        }

        public Vector2[] Matrixices()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<Vector2>(
                entity => new Vector2(entity),
                new object[]
                {
                    new string[] { this.___guid, ""Matrixices"" }
                }
            );
        }

        public Vector2 TheMatrix()
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector2>(
                entity => new Vector2(entity),
                new object[] 
                {
                    new string[] { this.___guid, ""TheMatrix"" }
                }
            );
        }

        public void makeObserverTopPriority(Observer observer)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, ""makeObserverTopPriority"" }, observer
                }
            );
        }

        #region add TODO: Get Comments as metadata identification
        private bool _isAddEnabled = false;
        private readonly IDictionary<string, Func<Task>> _addActionMap = new Dictionary<string, Func<Task>>();

        public string add(
            Func<Task> callback
        )
        {
            SetupAddLoop();

            var handle = Guid.NewGuid().ToString();
            _addActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupAddLoop()
        {
            if (_isAddEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                ""add"",
                ""CallAddActions"",
                _invokableReference
            );
            _isAddEnabled = true;
        }

        [JSInvokable]
        public async Task CallAddActions()
        {
            foreach (var action in _addActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public Vector2 theOtherMatrix(object methodData, object classData)
        {
            return EventHorizonBlazorInteropt.FuncClass<Vector2>(
                entity => new Vector2(entity),
                new object[] 
                {
                    new string[] { this.___guid, ""theOtherMatrix"" }, methodData, classData
                }
            );
        }

        public void promiseVoid()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, ""promiseVoid"" }
                }
            );
        }

        public Style nullableClassStyle()
        {
            return EventHorizonBlazorInteropt.FuncClass<Style>(
                entity => new Style(entity),
                new object[] 
                {
                    new string[] { this.___guid, ""nullableClassStyle"" }
                }
            );
        }

        public decimal nullableGenericNumber()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, ""nullableGenericNumber"" }
                }
            );
        }

        public void orderNullArguments(Animatable[] animatables, Scene scene = null, Node targetConverter = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, ""orderNullArguments"" }, scene, animatables, targetConverter
                }
            );
        }
        #endregion
    }
}";
    }
}
