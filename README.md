# Cake.Pandoc

[![standard-readme compliant][]][standard-readme]
[![Appveyor build][appveyorimage]][appveyor]
[![Codecov Report][codecovimage]][codecov]
[![NuGet package][nugetimage]][nuget]

Pandoc

## Table of Contents

- [Install](#install)
- [Usage](#usage)
- [Maintainer](#maintainer)
- [Contributing](#contributing)
- [License](#license)

## Install

```cs
#addin nuget:?package=Cake.Pandoc
```

## Usage

```cs
#addin nuget:?package=Cake.Pandoc

Task("MyTask").Does(() => {
  Pandoc();
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

[appveyor]: https://ci.appveyor.com/project/juergenrb/cake-pandoc
[appveyorimage]: https://img.shields.io/appveyor/ci/juergenrb/cake-pandoc.svg?logo=appveyor&style=flat-square
[codecov]: https://codecov.io/gh/JuergenRB/Cake.Pandoc
[codecovimage]: https://img.shields.io/codecov/c/github/JuergenRB/Cake.Pandoc.svg?logo=codecov&style=flat-square
[contrib-covenant]: https://www.contributor-covenant.org/version/1/4/code-of-conduct
[maintainer]: https://github.com/JuergenRB
[nuget]: https://nuget.org/packages/Cake.Pandoc
[nugetimage]: https://img.shields.io/nuget/v/Cake.Pandoc.svg?logo=nuget&style=flat-square
[license]: LICENSE.txt
[standard-readme]: https://github.com/RichardLitt/standard-readme
[standard-readme compliant]: https://img.shields.io/badge/readme%20style-standard-brightgreen.svg?style=flat-square
