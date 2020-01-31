### Console app setup

Based on articles penned by Larry Schoeneman

[How to take advantage of Dependency Injection in .Net Core 2.2 + Console Applications](https://medium.com/swlh/how-to-take-advantage-of-dependency-injection-in-net-core-2-2-console-applications-274e50a6c350)
[Taking advantage of configuration in .net core 2.2+ console applications](https://medium.com/@lschoeneman/taking-advantage-configuration-in-net-core-2-2-console-applications-edbcdb2e2c1b)
[How to take advantage of logging in .net Core 2.2 console application](https://medium.com/@lschoeneman/how-to-take-advantage-of-logging-in-net-core-2-2-console-applications-e9266f93892d)

```
dotnet new console --framework netcoreapp3.1
dotnet add package Microsoft.Extensions.DependencyInjection
dotnet new gitignore
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.Json
dotnet add package Microsoft.Extensions.Logging
dotnet add package Microsoft.Extensions.Logging.Console
```