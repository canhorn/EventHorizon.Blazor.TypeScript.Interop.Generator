using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Templates
{
    public static class ReadTemplates
    {
        private static ClassGenerationTemplates GeneratedTemplates;
        public static ClassGenerationTemplates Read()
        {
            if (GeneratedTemplates != null)
            {
                return GeneratedTemplates;
            }
            var templatesPath = "EventHorizon.Blazor.TypeScript.Interop.Generator.Templates";

            // Class Template
            var classTemplate = ReadAllText(
                $"{templatesPath}.ClassTemplate.txt"
            );
            // Class Shim Template
            var classShimTemplate = ReadAllText(
                $"{templatesPath}.ClassShimTemplate.txt"
            );
            // Cached Entity Object Template
            var cachedEntityObjectTemplate = ReadAllText(
                $"{templatesPath}.CachedEntityObjectTemplate.txt"
            );
            // Accessor/Property Template
            var accessorTemplate = ReadAllText($"{templatesPath}.AccessorTemplate.txt"
            );
            // Accessor/Property With Setter Template
            var accessorWithSetterTemplate = ReadAllText(
                $"{templatesPath}.AccessorWithSetterTemplate.txt"
            );
            // Constructor Template
            var constructorTemplate = ReadAllText(
                $"{templatesPath}.ConstructorTemplate.txt"
            );
            // Constructor To Base Template
            var constructorToBaseTemplate = ReadAllText(
                $"{templatesPath}.ConstructorToBaseTemplate.txt"
            );
            // Constructor With Arguments Template
            var constructorWithArgumentsTemplate = ReadAllText(
                $"{templatesPath}.ConstructorWithArgumentsTemplate.txt"
            );
            // Method Template
            var methodTemplate = ReadAllText(
                $"{templatesPath}.MethodTemplate.txt"
            );
            var methodActionTemplate = ReadAllText(
                $"{templatesPath}.MethodActionTemplate.txt"
            );
            var methodStaticActionTemplate = ReadAllText(
                $"{templatesPath}.MethodStaticActionTemplate.txt"
            );
            var returnTypePrimitiveTemplate = ReadAllText(
                $"{templatesPath}.ReturnTypePrimitiveTemplate.txt"
            );
            var returnTypeClassTemplate = ReadAllText(
                $"{templatesPath}.ReturnTypeClassTemplate.txt")
            ;
            var returnTypeVoidTemplate = ReadAllText(
                $"{templatesPath}.ReturnTypeVoidTemplate.txt"
            );

            // Interop Templates
            var interopCacheClassEntityTemplate = ReadAllText(
                $"{templatesPath}.InteropCacheClassEntityTemplate.txt"
            );
            var interopStaticCacheClassEntityTemplate = ReadAllText(
                $"{templatesPath}.InteropStaticCacheClassEntityTemplate.txt"
            );
            var interopGetTemplate = ReadAllText(
                $"{templatesPath}.InteropGetTemplate.txt"
            );
            var interopSetTemplate = ReadAllText(
                $"{templatesPath}.InteropSetTemplate.txt"
            );
            var interopCallTemplate = ReadAllText(
                $"{templatesPath}.InteropCallTemplate.txt"
            );
            var interopFuncTemplate = ReadAllText(
                $"{templatesPath}.InteropFuncTemplate.txt"
            );
            var interopFuncArrayTemplate = ReadAllText(
                $"{templatesPath}.InteropFuncArrayTemplate.txt"
            );
            var interopFuncClassTemplate = ReadAllText(
                $"{templatesPath}.InteropFuncClassTemplate.txt"
            );
            var interopFuncArrayClassTemplate = ReadAllText(
                $"{templatesPath}.InteropFuncArrayClassTemplate.txt"
            );
            var interopGetArrayClassTemplate = ReadAllText(
                $"{templatesPath}.InteropGetArrayClassTemplate.txt"
            );
            var interopGetArrayTemplate = ReadAllText(
                $"{templatesPath}.InteropGetArrayTemplate.txt"
            );
            var interopGetClassTemplate = ReadAllText(
                $"{templatesPath}.InteropGetClassTemplate.txt"
            );

            GeneratedTemplates = new ClassGenerationTemplates
            {
                Class = classTemplate,
                ClassShim = classShimTemplate,
                CachedEntityObject = cachedEntityObjectTemplate,
                Accessor = accessorTemplate,
                AccessorWithSetter = accessorWithSetterTemplate,
                Constructor = constructorTemplate,
                ConstructorToBase = constructorToBaseTemplate,
                ConstructorWithArgumentsTemplate = constructorWithArgumentsTemplate,
                Method = methodTemplate,
                MethodActionTemplate = methodActionTemplate,
                MethodStaticActionTemplate = methodStaticActionTemplate,
                ReturnTypePrimitiveTemplate = returnTypePrimitiveTemplate,
                ReturnTypeClass = returnTypeClassTemplate,
                ReturnTypeVoidTemplate = returnTypeVoidTemplate,

                InteropCacheClassEntity = interopCacheClassEntityTemplate,
                InteropCall = interopCallTemplate,
                InteropFunc = interopFuncTemplate,
                InteropFuncClass = interopFuncClassTemplate,
                InteropFuncArray = interopFuncArrayTemplate,
                InteropFuncArrayClass = interopFuncArrayClassTemplate,
                InteropGetArrayClass = interopGetArrayClassTemplate,
                InteropGetArray = interopGetArrayTemplate,
                InteropGetClass = interopGetClassTemplate,
                InteropGet = interopGetTemplate,
                InteropSet = interopSetTemplate,
                InteropStaticCacheClassEntity = interopStaticCacheClassEntityTemplate,
            };

            return GeneratedTemplates;
        }
        private static string ReadAllText(
            string templatePath
        )
        {
            var assembly = typeof(ReadTemplates).Assembly;
            var resourceStream = assembly.GetManifestResourceStream(
                templatePath
            );
            using var reader = new StreamReader(
                resourceStream, 
                Encoding.UTF8
            );
            return reader.ReadToEnd();
        }
    }
}
