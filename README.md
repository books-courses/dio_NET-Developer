# .NET

Em setembro de 2022 passei a estudar [DotNet](https://dotnet.microsoft.com), em um BootCamp da DIO. O instrutor é o [Leonardo Buta](https://www.linkedin.com/in/leonardo-buta).

> O Pottencial .NET Developer é o bootcamp para profissionais que buscam aperfeiçoar suas habilidades em desenvolvimento back-end com .NET e C#, e querem ganhar mais confiança no desenvolvimento de projetos. Uma trilha completa em .NET, Banco de Dados SQL e projetos práticos que te preparam para atuar em grandes cases de mercado. Ao final do programa, você ainda ficará disponível para o processo seletivo da Pottencial, maior insurtech do Brasil, com vagas full remotas.

<br>

O Dotnet surgiu em um contexto de concorrência com plataforma Java (da Sub), que era multiplataforma.

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
sudo apt-get update && sudo apt-get install -y dotnet6

# Runtime: para executar (não precisa caso )
sudo apt-get install -y dotnet-runtime-6.0

# Avalia informações
dotnet --info
```

<br>

---

## Criando Projeto

Existem vários tipos de projetos.
Dentre eles há o tipo console, onde todas as saídas dos programas serão feitos no console.
- https://aka.ms/new-console-template

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
