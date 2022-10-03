// --------------------------------------

using Models.Pessoa;

Console.WriteLine("Models");

// --------------------------------------

// Módulo 2

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

p1.Apresentar();
p1.Aniversario();
// p1._nome(); // Não é possível acessar propriedades privadas!

// Usando Construtores
var p2 = new Pessoa("Maria", "Bruaca");
p2.Idade = 33;


p2.Apresentar();


// --------------------------------------

var cursoDio = new Curso();
cursoDio.Nome = "C Sharp";


cursoDio.Alunos = new List<Pessoa>(); // Cria Lista em Branco
cursoDio.AdicionarAlunos(p0);
cursoDio.AdicionarAlunos(p1);
cursoDio.AdicionarAlunos(p2);

var nAlunos = cursoDio.ObterQuantidadeDeAlunosMatriculados();
Console.WriteLine($"Nº Alunos {nAlunos}");

cursoDio.ListarAlunos();

Console.WriteLine("Fim");
