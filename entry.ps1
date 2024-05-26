param(
    [string]
    [ValidateSet(
        "clean",
        "restore",
        "build",
        "run",
        "format",
        "check",
        "test",
        "client:test",
        "client:watch:test",
        "server:test"
    )]
    $Command,
    [string] $Configuration = "Release"
)

$wasmSampleProject = "./Sample/EventHorizon.Blazor.BabylonJS/EventHorizon.Blazor.BabylonJS.csproj"
$serverSampleProject = "./Sample/EventHorizon.Blazor.Server.BabylonJS/EventHorizon.Blazor.Server.BabylonJS.csproj"

$testProject = "./Tests/EventHorizon.Blazor.TypeScript.Interop.Generator.Tests/EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.csproj"
$testServerProject = "./Tests/EventHorizon.Blazor.Interop.Generator.Tests/EventHorizon.Blazor.Interop.Generator.Tests.csproj"

switch ($Command) {
    "clean" {
        dotnet clean
    }
    "restore" {
        dotnet restore --no-cache
    }
    "build" {
        dotnet csharpier .
        dotnet build
    }
    "run" {
        dotnet run --project $serverProject
    }
    "format" { 
        dotnet csharpier .
    }
    "check" {
        dotnet build --no-incremental -c $Configuration
        dotnet csharpier --check .
    }
    "test" { 
        dotnet test --no-restore --verbosity normal /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info $testProject
        dotnet test --no-restore --verbosity normal /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info $testServerProject
    }
    "client:test" { 
        dotnet test --verbosity normal /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info $testProject
    }
    "client:watch:test" { 
        dotnet watch --project $testProject test --no-restore --verbosity normal /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info
    }
    "server:test" { 
        dotnet test --no-restore --verbosity normal /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info $testServerProject
    }
    Default {
        Write-Output "Invalid Command"
    }
}