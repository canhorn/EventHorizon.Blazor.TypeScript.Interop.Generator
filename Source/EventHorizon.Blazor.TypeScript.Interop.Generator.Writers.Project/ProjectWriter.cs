using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model;
using EventHorizon.Blazor.TypeScript.Interop.Generator.Model.Writer;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Writers.Project;

public class ProjectWriter : IWriter
{
    private readonly string _projectPath;
    private readonly string _projectName;
    private readonly string _projectDirectory;

    public ProjectWriter(string path, string name)
    {
        _projectPath = path;
        _projectName = name;
        _projectDirectory = Path.Combine(_projectPath, _projectName);
    }

    public void Write(IList<GeneratedStatement> generatedStatementList)
    {
        // Generate Directory with ProjectName in ProjectPath
        GenerateProjectDirectory();

        // Create Project File, with ProjectName
        GenerateProjectFile();

        // Create Files from GeneratedStatementList
        foreach (var generatedStatement in generatedStatementList)
        {
            GeneratedStatementFile(generatedStatement);
        }
    }

    private void GeneratedStatementFile(GeneratedStatement generatedStatement)
    {
        // Get Path/File
        var namespaceToPath = Path.Combine(
            generatedStatement.ClassStatement.Namespace.Split('.').Skip(1).ToArray()
        );
        var namepacePath = Path.Combine(_projectDirectory, namespaceToPath);
        var filePath = Path.Combine(namepacePath, $"{generatedStatement.ClassStatement.Name}.cs");
        if (!Directory.Exists(namepacePath))
        {
            Directory.CreateDirectory(namepacePath);
        }
        File.WriteAllText(filePath, generatedStatement.GeneratedString);
    }

    private void GenerateProjectFile()
    {
        var templatesPath =
            "EventHorizon.Blazor.TypeScript.Interop.Generator.Writers.Project.Templates";
        var template = ReadAllText($"{templatesPath}.ProjectFileTemplate.txt");
        File.WriteAllText(Path.Combine(_projectDirectory, $"{_projectName}.csproj"), template);
    }

    public static string ReadAllText(string templatePath)
    {
        var assembly = typeof(ProjectWriter).Assembly;
        var resourceStream = assembly.GetManifestResourceStream(templatePath);
        using var reader = new StreamReader(resourceStream, Encoding.UTF8);
        return reader.ReadToEnd();
    }

    private void GenerateProjectDirectory()
    {
        if (
            Directory.Exists(_projectDirectory)
            && (
                Directory.GetFiles(_projectDirectory).Any()
                || Directory.GetDirectories(_projectDirectory).Any()
            )
        )
        {
            throw new Exception($"{_projectDirectory} already exists.");
        }
        Directory.CreateDirectory(_projectDirectory);
    }
}
