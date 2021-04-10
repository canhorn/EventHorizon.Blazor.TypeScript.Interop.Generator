namespace EventHorizon.Blazor.Interop.Generator.Templates
{
    using System.IO;
    using System.Text;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Templates;

    public static class ReadInteropTemplates
    {
        public static void SetReadTemplates()
        {
            var templatesPath = "EventHorizon.Blazor.Interop.Generator.Templates";

            // Class Template
            var classTemplate = ReadAllText(
                $"{templatesPath}.ClassTemplate.txt"
            );
            // Class With No Namespace Template
            var classWithNoNamespaceTemplate = ReadAllText(
                $"{templatesPath}.ClassWithNoNamespaceTemplate.txt"
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
            var accessorTemplate = ReadAllText(
                $"{templatesPath}.AccessorTemplate.txt"
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
            var interopGetTemplate = ReadAllText(
                $"{templatesPath}.InteropGetTemplate.txt"
            );
            var interopSetTemplate = ReadAllText(
                $"{templatesPath}.InteropSetTemplate.txt"
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

            // Promise/Tasks Interop 
            var interopTaskTemplate = ReadAllText(
                $"{templatesPath}.InteropTaskTemplate.txt"
            );
            var interopTaskArrayTemplate = ReadAllText(
                $"{templatesPath}.InteropTaskArrayTemplate.txt"
            );
            var interopTaskClassTemplate = ReadAllText(
                $"{templatesPath}.InteropTaskClassTemplate.txt"
            );
            var interopTaskArrayClassTemplate = ReadAllText(
                $"{templatesPath}.InteropTaskArrayClassTemplate.txt"
            );

            var generatedTemplates = ReadTemplates.Read();

            generatedTemplates.Class = classTemplate;
            generatedTemplates.ClassWithNoNamespace = classWithNoNamespaceTemplate;
            generatedTemplates.ClassShim = classShimTemplate;
            generatedTemplates.CachedEntityObject = cachedEntityObjectTemplate;

            generatedTemplates.Accessor = accessorTemplate;
            generatedTemplates.AccessorWithSetter = accessorWithSetterTemplate;

            generatedTemplates.Constructor = constructorTemplate;
            generatedTemplates.ConstructorToBase = constructorToBaseTemplate;
            generatedTemplates.ConstructorWithArgumentsTemplate = constructorWithArgumentsTemplate;

            generatedTemplates.Method = methodTemplate;
            generatedTemplates.MethodActionTemplate = methodActionTemplate;
            generatedTemplates.MethodStaticActionTemplate = methodStaticActionTemplate;
            generatedTemplates.ReturnTypePrimitiveTemplate = returnTypePrimitiveTemplate;
            generatedTemplates.ReturnTypeClass = returnTypeClassTemplate;
            generatedTemplates.ReturnTypeVoidTemplate = returnTypeVoidTemplate;

            generatedTemplates.InteropGet = interopGetTemplate;
            generatedTemplates.InteropSet = interopSetTemplate;
            generatedTemplates.InteropFunc = interopFuncTemplate;
            generatedTemplates.InteropFuncClass = interopFuncClassTemplate;
            generatedTemplates.InteropFuncArray = interopFuncArrayTemplate;
            generatedTemplates.InteropFuncArrayClass = interopFuncArrayClassTemplate;
            generatedTemplates.InteropGetArrayClass = interopGetArrayClassTemplate;
            generatedTemplates.InteropGetArray = interopGetArrayTemplate;
            generatedTemplates.InteropGetClass = interopGetClassTemplate;

            generatedTemplates.InteropTask = interopTaskTemplate;
            generatedTemplates.InteropTaskClass = interopTaskClassTemplate;
            generatedTemplates.InteropTaskArray = interopTaskArrayTemplate;
            generatedTemplates.InteropTaskArrayClass = interopTaskArrayClassTemplate;
        }
        private static string ReadAllText(
            string templatePath
        )
        {
            var assembly = typeof(ReadInteropTemplates).Assembly;
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
