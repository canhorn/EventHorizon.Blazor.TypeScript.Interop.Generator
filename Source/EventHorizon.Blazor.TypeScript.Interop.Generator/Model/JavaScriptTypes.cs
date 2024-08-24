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
    public const string ReadonlyArray = "ReadonlyArray";
    public const string ArrayLike = "ArrayLike";
    public const string FloatArray = "FloatArray";
    public const string Float32Array = "Float32Array";
    public const string IndicesArray = "IndicesArray";
    public const string Uint8Array = "Uint8Array";
    public const string HTMLElement = "HTMLElement";

    public const string Map = "Map";
    public const string Exclude = "Exclude";

    public static readonly IList<string> NumberArrayTypes =
    [
        FloatArray,
        Float32Array,
        IndicesArray,
        Uint8Array,
    ];
    public static readonly IList<string> AllArrayTypes =
    [
        Array,
        ReadonlyArray,
        ArrayLike,
        FloatArray,
        Float32Array,
        IndicesArray,
        Uint8Array,
    ];
    public static readonly IList<string> MapTypes = [Map,];
    #endregion

    #region Special BabylonJS Types - We want to track these because they have special cases for performance
    public const string Nullable = "Nullable";
    public const string Observable = "Observable";
    public const string DeepImmutable = "DeepImmutable";
    public const string Partial = "Partial";
    public const string Int = "int";
    public const string Float = "float";
    #endregion
}
