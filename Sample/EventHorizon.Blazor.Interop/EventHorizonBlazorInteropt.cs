namespace EventHorizon.Blazor.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Microsoft.JSInterop;
    using Mono.WebAssembly.Interop;

    public static class EventHorizonBlazorInteropt
    {
        public static MonoWebAssemblyJSRuntime RUNTIME = new MonoWebAssemblyJSRuntime();
        public static IJSRuntime JSRuntime { get; set; }

        /// <summary>
        /// 
        /// Example:
        /// EventHorizonBlazorInteropt.Call(
        ///     /* ICachedEntity */ this, 
        ///     "attachControl",
        ///     canvas,
        ///     preventDefault
        /// );
        /// </summary>
        /// <param name="args"></param>
        public static void Call(
            params object[] args
        )
        {
            RUNTIME.InvokeVoid(
                "blazorInterop.call",
                args
            );
        }

        public static T Func<T>(
            params object[] args
        )
        {
            // This might need to be JSRuntime
            return RUNTIME.Invoke<T>(
                "blazorInterop.func",
                args
            );
        }

        public static T FuncClass<T>(
            Func<ICachedEntity, T> classBuilder,
            params object[] args
        )
        {
            // This might need to be JSRuntime
            var cacheKey = RUNTIME.Invoke<string>(
                "blazorInterop.funcClass",
                args
            );
            return classBuilder(new CachedEntity { ___guid = cacheKey });
        }

        public static T[] FuncArray<T>(
            params object[] args
        )
        {
            // This might need to be JSRuntime
            return RUNTIME.Invoke<T[]>(
                "blazorInterop.funcArray",
                args
            );
        }

        public static T[] FuncArrayClass<T>(
            Func<ICachedEntity, T> classBuilder,
            params object[] args
        )
        {
            // TODO: Look at binary serialization to move the objects between the layers.
            var results = RUNTIME.Invoke<string[]>(
                "blazorInterop.funcArrayClass",
                args
            );
            var array = new T[results.Length];
            var index = 0;
            foreach (var result in results)
            {
                array[index] = classBuilder(new CachedEntity { ___guid = result });
                index++;
            }

            return array;
        }

        /// https://github.com/jhwcn/BlazorUnmarshalledCanvas/blob/master/UmCanvas/Canvas.cs
        public static T Get<T>(
            string root,
            string prop
        )
        {
            var result = RUNTIME.InvokeUnmarshalled<ValueTuple<string, string>, string>(
                "blazorInterop.get",
                ValueTuple.Create(
                    root,
                    prop
                )
            );
            if (result == null)
            {
                return default;
            }
            return (T)Convert.ChangeType(
                result,
                typeof(T)
            );
        }

        /// https://github.com/jhwcn/BlazorUnmarshalledCanvas/blob/master/UmCanvas/Canvas.cs
        public static T GetClass<T>(
            string root,
            string prop,
            Func<ICachedEntity, T> classBuilder
        )
        {
            var result = RUNTIME.InvokeUnmarshalled<ValueTuple<string, string>, string>(
                "blazorInterop.getClass",
                ValueTuple.Create(
                    root,
                    prop
                )
            );

            return classBuilder(new CachedEntity { ___guid = result });
        }

        public static T[] GetArrayClass<T>(
            string root,
            string prop,
            Func<ICachedEntity, T> classBuilder
        )
        {
            // TODO: Look at binary serialization to move the objects between the layers.
            var results = RUNTIME.Invoke<string[]>(
                "blazorInterop.getArrayClassSlow",
                root,
                prop
            );
            var array = new T[results.Length];
            var index = 0;
            foreach (var result in results)
            {
                array[index] = classBuilder(new CachedEntity { ___guid = result });
                index++;
            }

            return array;
        }

        public static T[] GetArray<T>(
            string root,
            string prop
        )
        {
            return RUNTIME.Invoke<T[]>(
                "blazorInterop.getArraySlow",
                root,
                prop
            );
        }

        public static ICachedEntity New(
            params object[] args
        )
        {
            return RUNTIME.Invoke<CachedEntity>(
                "blazorInterop.new",
                args
            );
        }

        public static ValueTask RunScript(
            string methodName,
            string script,
            object args
        )
        {
            return JSRuntime.InvokeVoidAsync(
                "blazorInterop.runScript",
                new JavaScriptMethodRunner
                {
                    MethodName = methodName,
                    Script = script,
                    Args = args
                }
            );
        }

        public static ValueTask FuncCallback<T>(
            ICachedEntity entity,
            string funcCallbackName,
            string referenceMethod,
            DotNetObjectReference<T> invokableReference
        ) where T : class
        {
            return JSRuntime.InvokeVoidAsync(
                "blazorInterop.funcCallback",
                entity.___guid,
                funcCallbackName,
                referenceMethod,
                invokableReference
            );
        }

        public static ValueTask AssemblyFuncCallback(
            string identifier,
            string assemblyName,
            string referenceCallback
        )
        {
            return JSRuntime.InvokeVoidAsync(
                "blazorInterop.assemblyFuncCallback",
                identifier,
                assemblyName,
                referenceCallback
            );
        }

        public static void Set(
            string root,
            string identifier,
            object value
        )
        {
            // identifier
            JSRuntime.InvokeVoidAsync(
                "blazorInterop.set",
                root,
                identifier,
                value
            );
        }

        public static ICachedEntity cacheEntity(
            string identifier,
            string prop
        )
        {
            return RUNTIME.Invoke<CachedEntity>(
                "blazorInterop.cacheEntity",
                identifier,
                prop
            );
        }
    }
    public struct JavaScriptMethodRunner
    {
        public string MethodName { get; set; }
        public string Script { get; set; }
        public object Args { get; set; }
    }
}
