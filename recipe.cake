#load nuget:?package=Cake.Recipe&version=1.1.2

Environment.SetVariableNames();

BuildParameters.SetParameters(
    context: Context,
    buildSystem: BuildSystem,
    sourceDirectoryPath: "./src/cake.pandoc",
    title: "Cake.Pandoc",
    repositoryOwner: "JuergenRB",
    repositoryName: "Cake.Pandoc",
    shouldRunGitVersion: true,
    shouldExecuteGitLink: false,
    shouldRunCodecov: true,
    shouldDeployGraphDocumentation: false,
    shouldRunDotNetCorePack: true);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context,
							dupFinderExcludePattern: new string[] {
                            BuildParameters.RootDirectoryPath + "/**/Cake.Pandoc.Tests/**/*.cs",
                            BuildParameters.RootDirectoryPath + "/**/Cake.Pandoc/**/*.AssemblyInfo.cs",
							BuildParameters.RootDirectoryPath + "/**/Cake.Pandoc/PandocSettings.cs"	
							}						
);

Build.RunDotNetCore();
