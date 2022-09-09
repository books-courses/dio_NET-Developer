// Isso é o entrypoint.
// Equivalente ao main.py do python



// Importa coisas
using dio_NET_Developer.Models;

// Printa
Console.WriteLine("Hello, World!");

// Printa com variáveis
string variavel = "ABC";
Console.WriteLine($"Hello, World! {variavel}");

// Variáveis
int quantidade = 1;
string textos = "texto";
double valor = 1.50;
decimal salario = 2.00M;
bool verdade = true;
Console.WriteLine("Valor da variável: " + quantidade);
Console.WriteLine(textos);
Console.WriteLine(valor);
Console.WriteLine(salario);
Console.WriteLine(verdade);

Console.WriteLine(valor.ToString("0.00"));

// Trabalhando com datas
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

dataAtual = dataAtual.AddDays(5);
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));





// Cria a variável p com objeto "Pessoa"
Pessoa p = new Pessoa();

// Atribuí variáveis
p.Nome = "Michel";
p.Idade = 38;

// Usa o método
p.Apresentar();

// Usa o método Aniversário
p.Aniversario();
