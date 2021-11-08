# Cake.Pandoc

[![standard-readme compliant][]][standard-readme]
[![NuGet package][nugetimage]][nuget]

Alias to assist with running Pandoc from Cake build scripts

## Table of Contents

- [Install](#install)
- [Usage](#usage)
- [Maintainer](#maintainer)
- [Contributing](#contributing)
- [License](#license)

## Install

```cs
#addin nuget:?package=Cake.Pandoc&version={Version}
```

## Usage

This addin exposes the functionality of [Pandoc] to the Cake by being a very thin wrapper around its command line interface; this means that you can use Cake.Pandoc in the same way as you would normally use [Pandoc CLI].

```cs
#addin nuget:?package=Cake.Pandoc={Version}
// Install Pandoc.Windows as a Cake Tool
#tool nuget:?package=Pandoc.Windows&version=2.1.0

Task("Pandoc-Example-Html")
    .Does(() =>
    {
        var settings = new PandocSettings();
        settings.Output = File("output.html");
        settings.Files.Add(File("path/to/input.txt"));
        Pandoc(settings);
    });
```

## Maintainer

[Jürgen Rosenthal-Buroh @JuergenRB][maintainer]

## Contributing

Cake.Pandoc follows the [Contributor Covenant][contrib-covenant] Code of Conduct.

We accept Pull Requests.

Small note: If editing the Readme, please conform to the [standard-readme][] specification.

## License

[MIT License © Jürgen Rosenthal-Buroh][license]

[contrib-covenant]: https://www.contributor-covenant.org/version/1/4/code-of-conduct
[maintainer]: https://github.com/JuergenRB
[nuget]: https://nuget.org/packages/Cake.Pandoc
[nugetimage]: https://img.shields.io/nuget/v/Cake.Pandoc.svg?logo=nuget&style=flat-square
[license]: LICENSE.txt
[standard-readme]: https://github.com/RichardLitt/standard-readme
[standard-readme compliant]: https://img.shields.io/badge/readme%20style-standard-brightgreen.svg?style=flat-square
[Pandoc]: https://pandoc.org/
[Pandoc CLI]: https://pandoc.org/MANUAL.html#options
