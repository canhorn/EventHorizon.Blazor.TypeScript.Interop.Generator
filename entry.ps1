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
        "client:run",
        "client:test",
        "client:watch:test",
        "client:publish",
        "client:serve",
        "server:run",
        "server:test",
        "generate:sample"
    )]
    $Command,
    [string] $Configuration = "Release"
)

function Invoke-LocationChangeBlock {
    Param(
        [Parameter(Mandatory = $true)]
        [scriptblock]$ScriptBlock
    )
    $currentDir = $PWD
    try {
        & $scriptBlock
    }
    finally {
        Set-Location $currentDir
    }
}

$consoleSampleDirectory = "./Sample/EventHorizon.BabylonJS.Interop.Generator.ConsoleApp"
$wasmSampleProject = "./Sample/EventHorizon.Blazor.BabylonJS/EventHorizon.Blazor.BabylonJS.csproj"
$serverSampleProject = "./Sample/EventHorizon.Blazor.Server.BabylonJS/EventHorizon.Blazor.Server.BabylonJS.csproj"
$generatedSampleDirectory = "./Sample/_generated"

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
        dotnet build --no-cache
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
        ./entry.ps1 client:test
        ./entry.ps1 server:test
    }
    "client:run" {
        dotnet run --project $wasmSampleProject
    }
    "client:test" { 
        dotnet test --verbosity normal /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info $testProject
    }
    "client:watch:test" { 
        dotnet watch --project $testProject test --no-restore --verbosity normal /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info
    }
    "client:publish" {
        dotnet publish -c $Configuration -o ./published $wasmSampleProject
    }
    "client:serve" {
        ./entry.ps1 client:publish

        dotnet serve -d="./published/wwwroot"
    }
    "server:test" { 
        dotnet test --no-restore --verbosity normal /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info $testServerProject
    }
    "generate:sample" {
        Invoke-LocationChangeBlock {
            cd $consoleSampleDirectory
            dotnet clean
            dotnet run -c $Configuration
        }

        Invoke-LocationChangeBlock {
            cd $generatedSampleDirectory/EventHorizon.Blazor.BabylonJS.NodeJS
            dotnet build -c $Configuration
        }
        # Invoke-LocationChangeBlock {
        #     cd $generatedSampleDirectory/EventHorizon.Blazor.BabylonJS.WASM
        #     dotnet build -c $Configuration
        # }
        # Invoke-LocationChangeBlock {
        #     cd $generatedSampleDirectory/EventHorizon.Blazor.BabylonJS.Server
        #     dotnet build -c $Configuration
        # }
    }
    Default {
        Write-Output "Invalid Command"
    }
}