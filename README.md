<h1>Study on C# and .NET</h1>

---

<h2>Index</h2>

- [Requirements](#requirements)
- [About C#](#about-c)
  - [C# Language versioning](#c-language-versioning)
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
