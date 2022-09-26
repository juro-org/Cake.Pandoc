#load nuget:?package=Cake.Recipe&version=3.0.1

Environment.SetVariableNames();

BuildParameters.SetParameters(
    context: Context,
    buildSystem: BuildSystem,
    sourceDirectoryPath: "./src/cake.pandoc",
    title: "Cake.Pandoc",
    masterBranchName: "main",
    repositoryOwner: "juro-org",
    repositoryName: "Cake.Pandoc",
    shouldRunDotNetCorePack: true,
    shouldUseDeterministicBuilds: true,
    shouldRunCodecov: false,
    preferredBuildAgentOperatingSystem: PlatformFamily.Linux,
    preferredBuildProviderType: BuildProviderType.GitHubActions);



BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context,
							dupFinderExcludePattern: new string[] {
                            BuildParameters.RootDirectoryPath + "/**/Cake.Pandoc.Tests/**/*.cs",
                            BuildParameters.RootDirectoryPath + "/**/Cake.Pandoc/**/*.AssemblyInfo.cs",
							BuildParameters.RootDirectoryPath + "/**/Cake.Pandoc/PandocSettings.cs"
							}
);

Build.RunDotNetCore();
