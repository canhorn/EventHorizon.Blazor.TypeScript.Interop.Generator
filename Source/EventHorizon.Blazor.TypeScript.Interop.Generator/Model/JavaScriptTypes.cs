using System;
using System.Collections.Generic;
using System.Text;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model
{
    public static class JavaScriptTypes
    {
        #region General Types - Types provided by the JavaScript framework
        public static string Promise => "Promise";
        public static string Function => "Function";
        public static string Boolean => "Boolean";
        public static string String => "String";
        public static string Array => "Array";
        public static string ArrayLike => "ArrayLike";
        public static string FloatArray => "FloatArray";
        public static string Float32Array => "Float32Array";
        public static string IndicesArray => "IndicesArray";
        public static string Uint8Array => "Uint8Array";
        public static string HTMLElement => "HTMLElement";

        public static IList<string> NumberArrayTypes = new List<string>
        {
            FloatArray,
            Float32Array,
            IndicesArray,
            Uint8Array,
        };
        public static IList<string> AllArrayTypes = new List<string>
        {
            Array,
            ArrayLike,
            FloatArray,
            Float32Array,
            IndicesArray,
            Uint8Array,
        };
        #endregion

        #region Special BabylonJS Types - We want to track these because they have special cases for performance
        public static string Nullable => "Nullable";
        public static string Observer => "Observer";
        public static string Observable => "Observable";
        public static string DeepImmutable => "DeepImmutable";
        public static string Int => "int";
        public static string Float => "float";
        #endregion
    }
}
