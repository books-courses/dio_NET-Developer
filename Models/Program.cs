// --------------------------------------

using Models.Pessoa;

Console.WriteLine("Models");

// --------------------------------------

// Módulo 2

var p1 = new Pessoa
{
    Nome = "Michel",
    Sobrenome = "Metran",
    Idade = 35
};

p1.Apresentar();
p1.Aniversario();


// p1._nome(); // Não é possível acessar propriedades privadas!

Console.WriteLine("Fim");
