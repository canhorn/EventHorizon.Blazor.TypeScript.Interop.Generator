namespace EventHorizon.Blazor.Interop.Generator.Writers.Project
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Writer;
    using EventHorizon.Blazor.TypeScript.Interop.Generator.Writers;
    using Microsoft.CodeAnalysis;

    public class ServerProjectWriter : IWriter
    {
        private readonly string _projectPath;
        private readonly string _projectName;
        private readonly string _projectDirectory;

        public ServerProjectWriter(
            string path,
            string name
        )
        {
            _projectPath = path;
            _projectName = name;
            _projectDirectory = Path.Combine(
                _projectPath,
                _projectName
            );
        }

        public void Write(
            IList<GeneratedStatement> generatedStatementList
        )
        {
            // Generate Directory with ProjectName in ProjectPath
            GenerateProjectDirectory();

            // Create Project File, with ProjectName
            GenerateProjectFile();

            // Create Files from GeneratedStatementList
            foreach (var generatedStatement in generatedStatementList)
            {
                GeneratedStatementFile(
                    generatedStatement
                );
            }
        }

        private void GeneratedStatementFile(
            GeneratedStatement generatedStatement
        )
        {
            // Get Path/File
            var namespaceToPath = Path.Combine(
                generatedStatement.ClassStatement.Namespace.Split(
                    '.'
                ).Skip(1).ToArray()
            );
            var namepacePath = Path.Combine(
                _projectDirectory,
                namespaceToPath
            );
            var filePath = Path.Combine(
                namepacePath,
                $"{generatedStatement.ClassStatement.Name}.cs"
             );
            if (!Directory.Exists(
                namepacePath
            ))
            {
                Directory.CreateDirectory(
                    namepacePath
                );
            }
            File.WriteAllText(
                filePath,
                CleanupGeneratedStatementString(
                    generatedStatement
                )
            );
        }

        private string CleanupGeneratedStatementString(
            GeneratedStatement generatedStatement
        )
        {
            return generatedStatement.GeneratedString.Replace(
                "ValueTask<void>",
                "ValueTask"
            ).Replace(
                "ValueTask<ValueTask>",
                "ValueTask"
            ).Replace(
                "await await",
                "await"
            ).Replace(
                "Task<void>",
                "CachedEntity"
            ).Replace(
                "ValueTask<Task<void>>",
                "ValueTask"
            ).Replace(
                "set_@",
                "set_"
            ).Replace(
                "get_@",
                "get_"
            ).Replace(
                "[[CLASS_GENERICS]]",
                BuildClassGenerics(
                    generatedStatement
                )
            );
        }

        private static string BuildClassGenerics(
            GeneratedStatement generatedStatement
        )
        {
            var template = "<[[TYPE]]>";

            if (!generatedStatement.ClassStatement.GenericTypes.Any())
            {
                return string.Empty;
            }

            return template.Replace(
                "[[TYPE]]",
                string.Join(
                    ", ",
                    generatedStatement.ClassStatement.GenericTypes.Select(
                        genericType => TypeStatementWriter.Write(
                            genericType
                        )
                    )
                )
            );
        }

        private void GenerateProjectFile()
        {
            var templatesPath = "EventHorizon.Blazor.Interop.Generator.Writers.Project.Templates";
            var template = ReadAllText(
                $"{templatesPath}.ProjectFileTemplate.txt"
            );
            File.WriteAllText(Path.Combine(
                _projectDirectory,
                $"{_projectName}.csproj"
            ), template);
        }

        public static string ReadAllText(
            string templatePath
        )
        {
            var assembly = typeof(ServerProjectWriter).Assembly;
            var resourceStream = assembly.GetManifestResourceStream(
                templatePath
            );
            using var reader = new StreamReader(
                resourceStream,
                Encoding.UTF8
            );
            return reader.ReadToEnd();
        }

        private void GenerateProjectDirectory()
        {
            if (Directory.Exists(_projectDirectory)
                && (Directory.GetFiles(_projectDirectory).Any()
                    || Directory.GetDirectories(_projectDirectory).Any()))
            {
                throw new Exception($"{_projectDirectory} already exists.");
            }
            Directory.CreateDirectory(_projectDirectory);
        }
    }
}
