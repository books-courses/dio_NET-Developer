# .NET

<br>

Em setembro de 2022 passei a estudar [DotNet](https://dotnet.microsoft.com), em um BootCamp da DIO. O instrutor é
o [Leonardo Buta](https://www.linkedin.com/in/leonardo-buta).

- https://web.dio.me/track/pottencial-net-developer

<br>

> O Pottencial .NET Developer é o bootcamp para profissionais que buscam aperfeiçoar suas habilidades em desenvolvimento
> back-end com .NET e C#, e querem ganhar mais confiança no desenvolvimento de projetos. Uma trilha completa em .NET,
> Banco de Dados SQL e projetos práticos que te preparam para atuar em grandes cases de mercado. Ao final do programa,
> você ainda ficará disponível para o processo seletivo da Pottencial, maior insurtech do Brasil, com vagas full
> remotas.

<br>

O Dotnet surgiu em um contexto de concorrência com plataforma Java (da Sun), que era multiplataforma.

- https://time.graphics/pt/line/291016
- https://web.dio.me/course/introducao-ao-net/learning/44dd0d90-7536-40cc-a344-d813fcc721c8?back=/track/pottencial-net-developer&tab=undefined&moduleId=undefined

<br>

---

## Linguagens

- C#

<br>

---

## Compilador

Converte linguagem de **alto nível** para **baixo nível**

<br>

---

## Transpilador

Converte linguagem de **alto nível** para **alto nível**

<br>

---

## Instalando .NET SDK

```bash
# SDK: para Desenvolver
sudo apt-get update
sudo apt-get install -y dotnet6
sudo apt-get install -y dotnet-sdk-6.0

# Runtime: para executar (não precisa caso o SDK seja instalado)
sudo apt-get install -y dotnet-runtime-6.0

# Avalia informações do Dotnet instalado
dotnet --info

# Remover
sudo apt remove --purge dotnet-sdk-6.0
sudo apt remove --purge dotnet-runtime-6.0
sudo rm -rf /usr/share/dotnet
sudo rm -rf /usr/bin/dotnet
sudo rm -rf /usr/lib/dotnet
sudo rm -rf /etc/dotnet
sudo rm -rf /usr/share/man/man1/dotnet*.gz
sudo apt remove 'dotnet*'
sudo apt remove 'aspnetcore*'
whereis dotnet
whitch dotnet

# https://stackoverflow.com/questions/73312785/dotnet-sdk-is-installed-but-not-recognized-linux-ubuntu-popos-22-04
```

<br>

---

## Criando Projeto

Existem vários tipos de projetos.
Dentre eles há o tipo console, onde todas as saídas dos programas serão feitos no console.

- https://aka.ms/new-console-template

<br>

Tem outras interfaces para web, apis, forms etc.

<br>

---

### Console

```bash
# Para criar
dotnet new console

# Para rodar
dotnet run
```

<br>

---

### Projeto

- .sln (Solução)
- .csprj (Projeto)

<br>

---

### Referências

- https://github.com/AndersonMazah/DIO.ProgramandoEmCSharp
- https://discord.com/channels/689887036110274618/1009886512768356373
