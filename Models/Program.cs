// --------------------------------------

using Models.Pessoa;

Console.WriteLine("Working with Models\n");

// --------------------------------------

// Módulo 2

// Etapa 1: Propriedades, métodos e construtores

var p0 = new Pessoa();
p0.Nome = "Zé";
p0.Sobrenome = "das Couves";
p0.Idade = 27;



var p1 = new Pessoa
{
    Nome = "Antônio",
    Sobrenome = "Silva",
    Idade = 37
};

// p1.Apresentar();
// p1.Aniversario();
// p1._nome(); // Não é possível acessar propriedades privadas!

// Usando Construtores
var p2 = new Pessoa("Maria", "Bruaca");
p2.Idade = 33;
// p2.Apresentar();


// --------------------------------------
// Model: Curso

var cursoDio = new Curso();
cursoDio.Nome = "C Sharp";
Console.WriteLine($"Estamos trabalhando com o Curso de {cursoDio.Nome}");

// Instancia Lista e Add Alunos
cursoDio.Alunos = new List<Pessoa>(); // Cria Lista em Branco
cursoDio.AdicionarAlunos(p0);
cursoDio.AdicionarAlunos(p1);
cursoDio.AdicionarAlunos(p2);

// Pega Quantidade de Alunos
var nAlunos = cursoDio.ObterQuantidadeDeAlunosMatriculados();
Console.WriteLine("");
Console.WriteLine($"Nº Alunos {nAlunos}\n");

// Lista
cursoDio.ListarAlunos();


// Remove Aluno
cursoDio.RemoverAlunos(p1);


// Pega Quantidade de Alunos
var nAlunos2 = cursoDio.ObterQuantidadeDeAlunosMatriculados();
Console.WriteLine("");
Console.WriteLine($"Nº Alunos {nAlunos2}\n");


Console.WriteLine("Fim");
