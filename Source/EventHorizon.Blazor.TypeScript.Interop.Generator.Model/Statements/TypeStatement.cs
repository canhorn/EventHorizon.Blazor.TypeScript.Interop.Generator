namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Statements;

using System;
using System.Collections.Generic;
using System.Linq;

// TypeStatement.Name<...TypeStatement.GenericTypes>
public class TypeStatement
{
    public string Name { get; set; }
    public bool IsArray { get; set; } = false;
    public bool IsTypeAlias { get; set; } = false;
    public TypeStatement AliasType { get; set; } = null;
    public bool IsTypeReference { get; set; } = false;
    public IEnumerable<TypeStatement> GenericTypes { get; set; } = [];
    public IEnumerable<ArgumentStatement> Arguments { get; set; } = [];
    public bool IsNullable { get; set; }
    public bool IsOptional { get; set; }
    public bool IsReadonly { get; set; }
    public bool IsAction { get; set; }
    public bool IsVoid { get; set; }
    public bool IsTask { get; set; }
    public bool IsLiteral { get; set; }
    public bool IsModifier { get; set; }
    public bool IsInterface { get; set; }
    public bool IsEnum { get; set; }
    public bool IsThisType { get; set; }

    public bool IsTypeQuery { get; set; }
    public bool IsTypeOperator { get; set; }
    public bool IsTypeParameter { get; set; }
    public TypeQueryStatement TypeQuery { get; set; }
    public TypeStatement ActionResultType { get; set; }

    public override string ToString()
    {
        var array = IsArray ? "[]" : string.Empty;
        var nullable = IsNullable ? "?" : string.Empty;
        var modifier = IsModifier ? "(M)" : string.Empty;
        var @readonly = IsReadonly ? "(RO)" : string.Empty;
        var interfaceString = IsInterface ? "(I)" : string.Empty;
        var enumString = IsEnum ? $"(E)" : string.Empty;
        var thisType = IsThisType ? "(T)" : string.Empty;
        var voidString = IsVoid ? "(V)" : string.Empty;
        var arguments = string.Join(", ", Arguments.Select(generic => generic.ToString()));
        var action = IsAction ? $"({arguments}) => " : string.Empty;
        var task = IsTask ? $"({arguments}) => " : string.Empty;
        var genericsJoined = string.Join(", ", GenericTypes.Select(generic => generic.ToString()));
        var generics = GenericTypes.Any() ? $"<{genericsJoined}>" : string.Empty;

        var typeReference = IsTypeReference ? $" = {Name}" : string.Empty;
        var type = IsTypeAlias ? $" = {AliasType}" : string.Empty;
        var typeQuery = IsTypeQuery ? $" {TypeQuery}" : string.Empty;
        var typeOperator = IsTypeOperator ? $" {TypeQuery}" : string.Empty;
        var typeParameter = IsTypeParameter ? $" {TypeQuery}" : string.Empty;
        var literal = IsLiteral ? $" = {Name}" : string.Empty;

        return $"{(IsTask ? task : action)}{enumString}{thisType}{modifier}{@readonly}{voidString}{Name}{generics}{array}{nullable}{typeReference}{type}{typeQuery}{typeOperator}{typeParameter}{literal}";
    }

    public string ToType()
    {
        if (IsNullable)
        {
            return GenericTypes.First().ToType();
        }

        var array = IsArray ? "[]" : string.Empty;
        var nullable = IsNullable ? "?" : string.Empty;
        var modifier = IsModifier ? "(M)" : string.Empty;
        var @readonly = IsReadonly ? "(RO)" : string.Empty;
        var interfaceString = IsInterface ? "(I)" : string.Empty;
        var enumString = IsEnum ? $"(E)" : string.Empty;
        var thisType = IsThisType ? "(T)" : string.Empty;
        var voidString = IsVoid ? "(V)" : string.Empty;
        var arguments = string.Join(", ", Arguments.Select(generic => generic.ToString()));
        var action = IsAction ? $"({arguments}) => " : string.Empty;
        var task = IsTask ? $"({arguments}) => " : string.Empty;
        var genericsJoined = string.Join(", ", GenericTypes.Select(generic => generic.ToString()));
        var generics = GenericTypes.Any() ? $"<{genericsJoined}>" : string.Empty;

        var typeReference = IsTypeReference ? $" = {Name}" : string.Empty;
        var type = IsTypeAlias ? $" = {AliasType}" : string.Empty;
        var typeQuery = IsTypeQuery ? $" {TypeQuery}" : string.Empty;
        var typeOperator = IsTypeOperator ? $" {TypeQuery}" : string.Empty;
        var typeParameter = IsTypeParameter ? $" {TypeQuery}" : string.Empty;
        var literal = IsLiteral ? $" = {Name}" : string.Empty;

        return $"{(IsTask ? task : action)}{enumString}{thisType}{modifier}{@readonly}{voidString}{Name}{generics}{array}{nullable}{typeReference}{type}{typeQuery}{typeOperator}{typeParameter}{literal}";
    }

    /// <summary>
    /// Score the TypeStatement based on the properties that are set.
    /// The more complex the TypeStatement the higher the score.
    /// This helps to flatten multiple TypeStatement's to a single TypeStatement.
    /// </summary>
    /// <returns></returns>
    public int Score()
    {
        var score = 0;
        if (IsArray)
        {
            score += 1;
        }
        if (IsTypeAlias)
        {
            score += 1;
        }
        if (IsTypeReference)
        {
            score += 1;
        }
        if (GenericTypes.Any())
        {
            score += 1;
        }
        if (Arguments.Any())
        {
            score += 1;
        }
        if (IsNullable)
        {
            score += 1;
        }
        if (IsReadonly)
        {
            score += 1;
        }
        if (IsAction)
        {
            score += 1;
        }
        if (IsVoid)
        {
            score += 1;
        }
        if (IsTask)
        {
            score += 1;
        }
        if (IsLiteral)
        {
            score += 1;
        }
        if (IsModifier)
        {
            score += 1;
        }
        if (IsInterface)
        {
            score += 1;
        }
        if (IsEnum)
        {
            score += 1;
        }
        if (IsThisType)
        {
            score += 1;
        }
        if (IsTypeQuery)
        {
            score += 1;
        }
        if (IsTypeOperator)
        {
            score += 1;
        }
        if (IsTypeParameter)
        {
            score += 1;
        }
        return score;
    }
}
