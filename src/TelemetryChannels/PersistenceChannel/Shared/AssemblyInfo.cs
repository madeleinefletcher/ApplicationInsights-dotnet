﻿// <copyright file="AssemblyInfo.cs" company="Microsoft">
// Copyright © Microsoft. All Rights Reserved.
// </copyright>

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Microsoft.ApplicationInsights.Channel.PersistenceChannel")]
[assembly: AssemblyDescription("Application Insights SDK Persistence channel")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("Application Insights SDK Windows Persistence channel")]
[assembly: AssemblyCopyright("Copyright © Microsoft. All Rights Reserved.")]

[assembly: ComVisible(false)]
[assembly: InternalsVisibleTo("Microsoft.ApplicationInsights.PersistenceChannel.Net40.Tests" + AssemblyInfo.PublicKey)]
[assembly: InternalsVisibleTo("Microsoft.ApplicationInsights.PersistenceChannel.Net45.Tests" + AssemblyInfo.PublicKey)]
[assembly: InternalsVisibleTo("Microsoft.ApplicationInsights.PersistenceChannel.Wrt81.Tests" + AssemblyInfo.PublicKey)]
[assembly: InternalsVisibleTo("Microsoft.ApplicationInsights.PersistenceChannel.Wp80.Tests" + AssemblyInfo.PublicKey)]

[assembly: InternalsVisibleTo("Microsoft.ApplicationInsights.TestFramework" + AssemblyInfo.PublicKey)]

// Assembly dynamically generated by Moq in unit tests
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2" + AssemblyInfo.MoqPublicKey)]