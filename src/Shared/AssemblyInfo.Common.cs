﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyDescription("A cross-platform library for processing of image files; written in C#")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Six Labors")]
[assembly: AssemblyProduct("SixLabors.ImageSharp.Web")]
[assembly: AssemblyCopyright("Copyright (c) Six Labor and contributors.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0.0")]

// Ensure the internals can be built and tested.
[assembly: InternalsVisibleTo("ImageSharp.Drawing")]
[assembly: InternalsVisibleTo("ImageSharp.Benchmarks")]
[assembly: InternalsVisibleTo("ImageSharp.Tests")]
[assembly: InternalsVisibleTo("ImageSharp.Sandbox46")]
[assembly: InternalsVisibleTo("ImageSharp.Web")]
[assembly: InternalsVisibleTo("ImageSharp.Web.Tests")]