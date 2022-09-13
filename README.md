<h1>Study on C# and .NET</h1>

---

<h2>Index</h2>

- [Requirements](#requirements)
- [About C#](#about-c)
  - [C# Language versioning](#c-language-versioning)
- [C# Built-in types](#c-built-in-types)
  - [Value types](#value-types)
    - [Integral numeric types](#integral-numeric-types)
    - [Floating-point numeric types](#floating-point-numeric-types)
  - [Reference types](#reference-types)
- [About .NET](#about-net)
  - [.NET Framework](#net-framework)
  - [.NET Core](#net-core)
  - [.NET SDK](#net-sdk)
- [Docker Environment](#docker-environment)
  - [Development container](#development-container)
    - [Creating and running](#creating-and-running)
    - [Relifting](#relifting)
    - [Executing the source code](#executing-the-source-code)
  - [Deploy container](#deploy-container)
    - [Creating and deploying](#creating-and-deploying)
    - [Watching execution](#watching-execution)
- [References](#references)

---

## Requirements

- [Docker](https://docs.docker.com/get-docker/)

## About C#

The C# programming language was designed by Anders Hejlsberg from Microsoft in 2000 and was later approved as an international standard by Ecma (ECMA-334) in 2002 and ISO/IEC (ISO/IEC 23270) in 2003. Microsoft introduced C# along with .NET Framework and Visual Studio, both of which were closed-source.

### C# Language versioning

The latest C# compiler determines a default language version based on your project's target framework or frameworks. You can change the version by editing the csproj file. The compiler determines a default based on these rules:

<table aria-label="Defaults" class="table table-sm">
  <thead>
    <tr>
      <th>Target framework</th>
      <th>version</th>
      <th>C# language version default</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>.NET</td>
      <td>7.x</td>
      <td>C# 11</td>
    </tr>
    <tr>
      <td>.NET</td>
      <td>6.x</td>
      <td>C# 10</td>
    </tr>
    <tr>
      <td>.NET</td>
      <td>5.x</td>
      <td>C#  9.0</td>
    </tr>
    <tr>
      <td>.NET Core</td>
      <td>3.x</td>
      <td>C#  8.0</td>
    </tr>
    <tr>
      <td>.NET Core</td>
      <td>2.x</td>
      <td>C#  7.3</td>
    </tr>
    <tr>
      <td>.NET Standard</td>
      <td>2.1</td>
      <td>C#  8.0</td>
    </tr>
    <tr>
      <td>.NET Standard</td>
      <td>2.0</td>
      <td>C#  7.3</td>
    </tr>
    <tr>
      <td>.NET Standard</td>
      <td>1.x</td>
      <td>C#  7.3</td>
      </tr>
    <tr>
      <td>.NET Framework</td>
      <td>all</td>
      <td>C#  7.3</td>
    </tr>
  </tbody>
</table>

## C# Built-in types

There are two kinds of types in C#: reference types and value types. Variables of reference types store references to their data (objects), while variables of value types directly contain their data. With reference types, two variables can reference the same object; therefore, operations on one variable can affect the object referenced by the other variable. With value types, each variable has its own copy of the data, and it is not possible for operations on one variable to affect the other (except in the case of in, ref and out parameter variables; see in, ref and out parameter modifier).

### Value types

<table aria-label="Built-in types (C# reference)" class="table table-sm">
<thead>
<tr>
<th>C# type keyword</th>
<th>.NET type</th>
</tr>
</thead>
<tbody>
<tr>
<td><a href="bool" data-linktype="relative-path"><code>bool</code></a></td>
<td><a href="/en-us/dotnet/api/system.boolean" class="no-loc" data-linktype="absolute-path">System.Boolean</a></td>
</tr>
<tr>
<td><a href="integral-numeric-types" data-linktype="relative-path"><code>byte</code></a></td>
<td><a href="/en-us/dotnet/api/system.byte" class="no-loc" data-linktype="absolute-path">System.Byte</a></td>
</tr>
<tr>
<td><a href="integral-numeric-types" data-linktype="relative-path"><code>sbyte</code></a></td>
<td><a href="/en-us/dotnet/api/system.sbyte" class="no-loc" data-linktype="absolute-path">System.SByte</a></td>
</tr>
<tr>
<td><a href="char" data-linktype="relative-path"><code>char</code></a></td>
<td><a href="/en-us/dotnet/api/system.char" class="no-loc" data-linktype="absolute-path">System.Char</a></td>
</tr>
<tr>
<td><a href="floating-point-numeric-types" data-linktype="relative-path"><code>decimal</code></a></td>
<td><a href="/en-us/dotnet/api/system.decimal" class="no-loc" data-linktype="absolute-path">System.Decimal</a></td>
</tr>
<tr>
<td><a href="floating-point-numeric-types" data-linktype="relative-path"><code>double</code></a></td>
<td><a href="/en-us/dotnet/api/system.double" class="no-loc" data-linktype="absolute-path">System.Double</a></td>
</tr>
<tr>
<td><a href="floating-point-numeric-types" data-linktype="relative-path"><code>float</code></a></td>
<td><a href="/en-us/dotnet/api/system.single" class="no-loc" data-linktype="absolute-path">System.Single</a></td>
</tr>
<tr>
<td><a href="integral-numeric-types" data-linktype="relative-path"><code>int</code></a></td>
<td><a href="/en-us/dotnet/api/system.int32" class="no-loc" data-linktype="absolute-path">System.Int32</a></td>
</tr>
<tr>
<td><a href="integral-numeric-types" data-linktype="relative-path"><code>uint</code></a></td>
<td><a href="/en-us/dotnet/api/system.uint32" class="no-loc" data-linktype="absolute-path">System.UInt32</a></td>
</tr>
<tr>
<td><a href="integral-numeric-types" data-linktype="relative-path"><code>nint</code></a></td>
<td><a href="/en-us/dotnet/api/system.intptr" class="no-loc" data-linktype="absolute-path">System.IntPtr</a></td>
</tr>
<tr>
<td><a href="integral-numeric-types" data-linktype="relative-path"><code>nuint</code></a></td>
<td><a href="/en-us/dotnet/api/system.uintptr" class="no-loc" data-linktype="absolute-path">System.UIntPtr</a></td>
</tr>
<tr>
<td><a href="integral-numeric-types" data-linktype="relative-path"><code>long</code></a></td>
<td><a href="/en-us/dotnet/api/system.int64" class="no-loc" data-linktype="absolute-path">System.Int64</a></td>
</tr>
<tr>
<td><a href="integral-numeric-types" data-linktype="relative-path"><code>ulong</code></a></td>
<td><a href="/en-us/dotnet/api/system.uint64" class="no-loc" data-linktype="absolute-path">System.UInt64</a></td>
</tr>
<tr>
<td><a href="integral-numeric-types" data-linktype="relative-path"><code>short</code></a></td>
<td><a href="/en-us/dotnet/api/system.int16" class="no-loc" data-linktype="absolute-path">System.Int16</a></td>
</tr>
<tr>
<td><a href="integral-numeric-types" data-linktype="relative-path"><code>ushort</code></a></td>
<td><a href="/en-us/dotnet/api/system.uint16" class="no-loc" data-linktype="absolute-path">System.UInt16</a></td>
</tr>
</tbody>
</table>

#### Integral numeric types

The integral numeric types represent integer numbers. All integral numeric types are value types. They're also simple types and can be initialized with literals. All integral numeric types support arithmetic, bitwise logical, comparison, and equality operators.

<table aria-label="Characteristics of the integral types" class="table table-sm">
<thead>
<tr>
<th>C# type/keyword</th>
<th>Range</th>
<th>Size</th>
<th>.NET type</th>
</tr>
</thead>
<tbody>
<tr>
<td><code>sbyte</code></td>
<td>-128 to 127</td>
<td>Signed 8-bit integer</td>
<td><a href="/en-us/dotnet/api/system.sbyte" class="no-loc" data-linktype="absolute-path">System.SByte</a></td>
</tr>
<tr>
<td><code>byte</code></td>
<td>0 to 255</td>
<td>Unsigned 8-bit integer</td>
<td><a href="/en-us/dotnet/api/system.byte" class="no-loc" data-linktype="absolute-path">System.Byte</a></td>
</tr>
<tr>
<td><code>short</code></td>
<td>-32,768 to 32,767</td>
<td>Signed 16-bit integer</td>
<td><a href="/en-us/dotnet/api/system.int16" class="no-loc" data-linktype="absolute-path">System.Int16</a></td>
</tr>
<tr>
<td><code>ushort</code></td>
<td>0 to 65,535</td>
<td>Unsigned 16-bit integer</td>
<td><a href="/en-us/dotnet/api/system.uint16" class="no-loc" data-linktype="absolute-path">System.UInt16</a></td>
</tr>
<tr>
<td><code>int</code></td>
<td>-2,147,483,648 to 2,147,483,647</td>
<td>Signed 32-bit integer</td>
<td><a href="/en-us/dotnet/api/system.int32" class="no-loc" data-linktype="absolute-path">System.Int32</a></td>
</tr>
<tr>
<td><code>uint</code></td>
<td>0 to 4,294,967,295</td>
<td>Unsigned 32-bit integer</td>
<td><a href="/en-us/dotnet/api/system.uint32" class="no-loc" data-linktype="absolute-path">System.UInt32</a></td>
</tr>
<tr>
<td><code>long</code></td>
<td>-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807</td>
<td>Signed 64-bit integer</td>
<td><a href="/en-us/dotnet/api/system.int64" class="no-loc" data-linktype="absolute-path">System.Int64</a></td>
</tr>
<tr>
<td><code>ulong</code></td>
<td>0 to 18,446,744,073,709,551,615</td>
<td>Unsigned 64-bit integer</td>
<td><a href="/en-us/dotnet/api/system.uint64" class="no-loc" data-linktype="absolute-path">System.UInt64</a></td>
</tr>
<tr>
<td><code>nint</code></td>
<td>Depends on platform (computed at runtime)</td>
<td>Signed 32-bit or 64-bit integer</td>
<td><a href="/en-us/dotnet/api/system.intptr" class="no-loc" data-linktype="absolute-path">System.IntPtr</a></td>
</tr>
<tr>
<td><code>nuint</code></td>
<td>Depends on platform (computed at runtime)</td>
<td>Unsigned 32-bit or 64-bit integer</td>
<td><a href="/en-us/dotnet/api/system.uintptr" class="no-loc" data-linktype="absolute-path">System.UIntPtr</a></td>
</tr>
</tbody>
</table>

#### Floating-point numeric types

The floating-point numeric types represent real numbers. All floating-point numeric types are value types. They are also simple types and can be initialized with literals. All floating-point numeric types support arithmetic, comparison, and equality operators.

<table aria-label="Characteristics of the floating-point types" class="table table-sm">
<thead>
<tr>
<th>C# type/keyword</th>
<th>Approximate range</th>
<th>Precision</th>
<th>Size</th>
<th>.NET type</th>
</tr>
</thead>
<tbody>
<tr>
<td><code>float</code></td>
<td>±1.5 x 10<sup>−45</sup> to ±3.4 x 10<sup>38</sup></td>
<td>~6-9 digits</td>
<td>4 bytes</td>
<td><a href="/en-us/dotnet/api/system.single" class="no-loc" data-linktype="absolute-path">System.Single</a></td>
</tr>
<tr>
<td><code>double</code></td>
<td>±5.0 × 10<sup>−324</sup> to ±1.7 × 10<sup>308</sup></td>
<td>~15-17 digits</td>
<td>8 bytes</td>
<td><a href="/en-us/dotnet/api/system.double" class="no-loc" data-linktype="absolute-path">System.Double</a></td>
</tr>
<tr>
<td><code>decimal</code></td>
<td>±1.0 x 10<sup>-28</sup> to ±7.9228 x 10<sup>28</sup></td>
<td>28-29 digits</td>
<td>16 bytes</td>
<td><a href="/en-us/dotnet/api/system.decimal" class="no-loc" data-linktype="absolute-path">System.Decimal</a></td>
</tr>
</tbody>
</table>

### Reference types

<table aria-label="Table 2" class="table table-sm">
<thead>
<tr>
<th>C# type keyword</th>
<th>.NET type</th>
</tr>
</thead>
<tbody>
<tr>
<td><a href="reference-types#the-object-type" data-linktype="relative-path"><code>object</code></a></td>
<td><a href="/en-us/dotnet/api/system.object" class="no-loc" data-linktype="absolute-path">System.Object</a></td>
</tr>
<tr>
<td><a href="reference-types#the-string-type" data-linktype="relative-path"><code>string</code></a></td>
<td><a href="/en-us/dotnet/api/system.string" class="no-loc" data-linktype="absolute-path">System.String</a></td>
</tr>
<tr>
<td><a href="reference-types#the-dynamic-type" data-linktype="relative-path"><code>dynamic</code></a></td>
<td><a href="/en-us/dotnet/api/system.object" class="no-loc" data-linktype="absolute-path">System.Object</a></td>
</tr>
</tbody>
</table>

## About .NET

.NET is a free, cross-platform, open source developer platform for building many kinds of applications. .NET is built on a high-performance runtime that is used in production by many high-scale apps.

### .NET Framework

The Dot Net Framework was designed to let developers construct programs that would operate on Microsoft’s Windows platform and dot net framework applications are multi-platform applications. The framework has been decided in such a way that it can be used from any of the following languages: c#, c++, Visual Basic, JScript, COBOL, etc. In the year 2002, the initial version of the dot Net framework was launched.

The .NET Framework is a proprietary software framework developed by Microsoft that runs primarily on Microsoft Windows. It includes a large class library called Framework Class Library (FCL) and provides language interoperability (each language can use code written in other languages) across several programming languages. Programs written for .NET Framework execute in a software environment (in contrast to a hardware environment) named the Common Language Runtime (CLR). The CLR is an application virtual machine that provides services such as security, memory management, and exception handling. As such, computer code written using .NET Framework is called "managed code". FCL and CLR together constitute the .NET Framework.

### .NET Core

Microsoft .NET Core is a free, open-source, general-purpose development platform to build cloud-based software applications on Windows, Linux, and macOS whereas  Microsoft’s .NET Framework is a software development platform for building and running Windows applications. .NET Framework includes developer tools, programming languages, and libraries that are used to develop desktop and web applications. The key difference between .NET Core and .NET Framework is a platform for .NET applications on Windows whereas, .NET Core is the latest version of the .NET Framework which is a cross-platform and open-source framework optimized for modern app needs and developer workflows.

### .NET SDK

The .NET SDK is a set of libraries and tools that allow developers to create .NET applications and libraries. It contains the following components that are used to build and run applications:

- The .NET CLI
- The .NET runtime and libraries
- The dotnet driver

## Docker Environment

### Development container

#### Creating and running

To create a development container, cd into `App` directory and build with Dockerfile:

```bash
cd App/
docker build -t dotnet-app-img-dev -f Dockerfile.dev .
```

To run the container:

```bash
docker run -v $(pwd):/src -it --name dotnet-app-ctr-dev dotnet-app-img-dev
```

#### Relifting

If you ended up exiting the container, start it again and exec bash on it:

```bash
docker start dotnet-app-ctr-dev
docker exec -it dotnet-app-ctr-dev bash
```

#### Executing the source code

From within the running container, change directory into the `/src` dir, build the project then run it:

```bash
cd src/
dotnet build
dotnet run
```

### Deploy container

#### Creating and deploying

To create a deploy container, cd into `App` directory and build with Dockerfile:

```bash
cd App/
docker build -t dotnet-app-img -f Dockerfile.deploy .
```

To run the container:

```bash
docker run -d --name dotnet-app-ctr dotnet-app-img
```

#### Watching execution

Then, to see it being executed:

```bash
docker logs dotnet-app-ctr
```

## References

[1] [C# Language Specification](https://www.ecma-international.org/publications-and-standards/standards/ecma-334/)

[2] [.NET Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/)

[3] [Docker Docs](https://docs.docker.com/)
