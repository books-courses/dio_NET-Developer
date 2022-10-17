# Gerenciador de Pacote: NuGet

- [NuGet](https://learn.microsoft.com/en-us/nuget/)

```bash
dotnet add package {Package Name}
dotnet add package Newtonsoft.Json
```

## Tipos de Classes

### Classe Abstrata

Não permite que o usuário chame a classe diretamente. Ela deve servir de modelo para outras classes.

Por exemplo.
"Conta" (de banco) seria uma classe abstrata.
"Conta Corrente" seria uma classe herdada de "Conta".

### Classe Selada

Inpossibilita que o usuário tente criar uma classe herdada desta classe selada!

Impede que o usuário customize a classe!

## Interfaces

Contrato que pode ser implantado por uma classe

Interface não pode ser instanciada

Sempre começa com "I"
