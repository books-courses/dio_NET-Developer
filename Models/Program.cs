// --------------------------------------

using Models.Pessoa;
using Models.Venda;
using Models.MeuArray;
using Newtonsoft.Json;

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


// --------------------------------------
// Model: Venda
// Serializar
// ISO 8601
DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de software", 100.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
Console.WriteLine($"{serializado}");

string serializado2 = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
File.WriteAllText("data/output/vendas.json", serializado2);


// Deserializar

//string conteudoArquivo = File.ReadAllText("data/output/vendas.json");
string conteudoArquivo = File.ReadAllText("data/input/vendas edit.json");
List<Venda> listaVendas2 = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVendas2)
{
    Console.WriteLine(
        $"{venda.Id},\n" +
        $"{venda.Produto},\n" +
        $"{venda.Preco},\n" +
        $"{venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}\n" +
        $"{(venda.Desconto.HasValue ? $"Desconto de {venda.Desconto}": "Sem Desconto")}"
        );
}


// Tipo anônimo em coleções
Console.WriteLine("// Tipo anônimo em coleções");
var listaAnonimo = listaVendas2.Select(x => new{x.Produto, x.Preco});

foreach (var vendaSel in listaAnonimo)
{
    Console.WriteLine($"{vendaSel.Produto}");
}


// Classes Genéricas
Console.WriteLine("// Classes Genéricas");

MeuArray<int> arrayInteiro = new MeuArray<int>();
arrayInteiro.AdicionarElementoArray(30);
Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();
arrayString.AdicionarElementoArray("Texto");
Console.WriteLine(arrayString[0]);

