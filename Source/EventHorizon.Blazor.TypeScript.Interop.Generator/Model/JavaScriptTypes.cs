namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

using System.Collections.Generic;

public static class JavaScriptTypes
{
    #region General Types - Types provided by the JavaScript framework
    public const string Readonly = "Readonly";
    public const string Promise = "Promise";
    public const string Function = "Function";
    public const string Boolean = "Boolean";
    public const string String = "String";
    public const string Array = "Array";
    public const string ArrayLike = "ArrayLike";
    public const string FloatArray = "FloatArray";
    public const string Float32Array = "Float32Array";
    public const string IndicesArray = "IndicesArray";
    public const string Uint8Array = "Uint8Array";
    public const string HTMLElement = "HTMLElement";

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
    public static string Observable => "Observable";
    public static string DeepImmutable => "DeepImmutable";
    public static string Partial => "Partial";
    public static string Int => "int";
    public static string Float => "float";
    #endregion
}
