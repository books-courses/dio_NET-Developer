Desenvolver uma API usando o Entity Framework

- https://www.jetbrains.com/help/rider/Running_IISExpress.html

```bash
dotnet new webapi
dotnet watch run

NuGet Package
Swashbuckle.AspNetCore
```

<br>

----

### Entity Framework (EF)

É um ORM (Object Relational Mapping) para promover a integração com o banco de dados

Usar apenas uma vez

```
dotnet tool install --global dotnet-ef
```

Uma vez que as configurações estão definidas em `appsettings.json` e `appsettings.Development.json`

```bash
cd MyAPI
dotnet-ef migrations add CriacaoTabelaContato
dotnet-ef migrations remove

# Atualiza DB
dotnet-ef database update
```
