# Structured Query Language (SQL)

<br>

SELECT
UPDATE
INSERT

<br>

---

## Tipos

- DDL - Data Definition Language
- DCL Data Control Language
- DML - Data Manipulation Language
- TCL Transaction Control Language
- DQL - Data Query Language

<br>

![](https://i.imgur.com/gHPof25.png)

![](https://i.imgur.com/OmpAIAm.png)

<br>

---

## DBs padrão do SQL Server

Não mexer!

- master - keeps the information for an instance of SQL Server.
- msdb - used by SQL Server Agent.
- model - template database copied for each new database.
- resource - read only database that keeps system objects that are visible in every database on the server in sys
  schema.
- tempdb - keeps temporary objects for SQL queries.

![](https://i.imgur.com/sxf2RIK.png)

<br>

---

# Docker

```bash
docker-compose up -d
docker-compose down
```

## SQL Server

**DB Management Studio** só instala no Windows!

Estou usando o DataGrip do JetBrains!

Inicialmente instalei um _docker_ do [MySQL Server](https://hub.docker.com/_/microsoft-mssql-server).

```bash
docker run \
-e "ACCEPT_EULA=Y" \
-e "MSSQL_SA_PASSWORD=<YourStrong@Passw0rd>" \
-p 1433:1433 \
--name sql1 \
--hostname sql1 \
-d \
mcr.microsoft.com/mssql/server:2022-latest
```

<br>

Após isso fiz o [Connecting DataGrip to MS SQL Server](https://www.youtube.com/watch?v=0E0sU_z74HM)

> user: sa<br>
> password: <YourStrong@Passw0rd>

<br>

Além disso, dá pra entrar, via _docker_, no DB e fazer alterações.

```bash
# Entrar em Modo Bash
sudo docker exec -it sql1 "bash"

# Acessar DB
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "<YourStrong@Passw0rd>"

# Criar DB
CREATE DATABASE TestDB;

QUIT
```

<br>

Após acessar o DB, obtive os códigos `.sql` no repositório no [_github_ da DIO](https://github.com/digitalinnovationone)
.

- https://github.com/digitalinnovationone/trilha-net-banco-de-dados

<br>

Além disso, é necessário instalar packages NuGet

```
Microsoft.EntityFrameworkCoreDesing
Microsoft.EntityFrameworkCoreSqlServer
```

---

## PostGre

Com o _docker_ pronto

[Problem with PostgresSQL password authentication failed for user when trying to access or fetch data from database?](https://stackoverflow.com/questions/67106691/problem-with-postgressql-password-authentication-failed-for-user-when-trying-to)

Além disso, é necessário instalar packages NuGet

```bash
Npgsql
Npgsql.EntityFrameworkCore.PostgreSQL
Npgsql.EntityFrameworkCore.PostgreSQL.Desing
```

<br>

---

## MySQL

Além disso, é necessário instalar packages NuGet

```bash
Pomelo.EntityFrameworkCore.MySql
```

<br>

---

## Outros

```bash
CREATE USER 'root'@'172.20.0.1' IDENTIFIED BY 'password';
GRANT ALL PRIVILEGES ON *.* TO 'root'@'172.20.0.1' WITH GRANT OPTION;
FLUSH PRIVILEGES;
```
