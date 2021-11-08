 // build artifacts first by executing ./build.ps1 in root
 #r "..\..\cake.pandoc\Cake.Pandoc\bin\Release\netstandard2.0\Cake.pandoc.dll"

 // Install Pandoc.Windows as a Cake Tool
 #tool nuget:?package=Pandoc.Windows&version=2.1.0


 var mathFile = @"..\data\math.txt";
 var manualFile = @"..\data\manual.txt";
 var outputFile = @".\output.html";
 var outputMathFile = @".\output.html";


Task("Pandoc-Example-Html")
    .Does(() =>
    {
        var settings = new PandocSettings();
        settings.Output = File(outputFile);
        settings.Files.Add(File(manualFile));
        Pandoc(settings);
    });

Task("Pandoc-Example")
    .IsDependentOn("Pandoc-Example-Html")
    .Does(() => { Information("Done");});

RunTarget("Pandoc-Example");
