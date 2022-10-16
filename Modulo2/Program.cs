// Etapa 1: Propriedades, métodos e construtores
// Etapa 2: Manipulando Valores
// Etapa 3: Excessões e Coleções
// Etapa 4: Tuplas, operadores ternários e descontrução de objeto
// Etapa 5: Nuget, serializar e atributos no C#
// Etapa 6: Tipos Especiais no C#
// Etapa 7: Stack, Heap e Garbage Collecotr


using System.Security.Principal;
using Models.IntExtension;
using Models.Pessoa;
using Modulo2.Etapa02;
using Modulo2.Etapa03;
using Modulo2.Etapa04;
using Modulo2.Etapa06;
using Modulo2.Etapa07;

// --------------------------------------
// Etapa 2: Manipulando Valores

// var d = new Etapa_02();
// Etapa_02.SubCap01();
// Etapa_02.SubCap02();
// Etapa_02.SubCap03();
// Etapa_02.SubCap04();


// --------------------------------------
// Etapa 3: Excessões e Coleções (pilhas e filas)

// var tr = new Etapa_03();
// Etapa_03.SubCap01();
// Etapa_03.SubCap02_In();
// Etapa_03.SubCap03();
// Etapa_03.SubCap04();
// Etapa_03.SubCap05();



// --------------------------------------
// Etapa 4: Tuplas, operadores ternários e descontrução de objeto

var trd = new Etapa_04();

Etapa_04.SubCap01();

// Tupla no método! Ler arquivo!
var(sucesso, linhasArquivo, quantidadeLinhas) = Etapa_04.SubCap02("data/input/exemplo.txt");
Console.WriteLine($"{sucesso}");
if (sucesso)
{
    Console.WriteLine($"Quantidade de linhas: {quantidadeLinhas}");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine($"{linha}");
    }
}
else
{
    Console.WriteLine($"Não foi possível ler o arquivo");
}


// Deconstruct
Pessoa p1 = new Pessoa("Michel", "Metran");
(string nome, string sobrenome) = p1;
Console.WriteLine($"{nome} {sobrenome}");

// IF Ternário
Etapa_04.SubCap03();


// --------------------------------------
// Etapa 6: Tipos Especiais no C#

var t2 = new Etapa_06();
Console.WriteLine($"{t2.GetType()}");
// Etapa_06.SubCap01();  // Aceitando Nulos
// Etapa_06.SubCap02(); // Tipo Anônimo
// Etapa_06.SubCap03(); // Estudando tipo 'Dynamic'
// Etapa_06.SubCap04(); // Classes Genéricas
// Etapa_06.SubCap05(); // Métodos de Extensão

// Ver Model.IntExtension
int numero = 20;
bool par = false;
par = numero.EhPar();
Console.WriteLine($"{par}");





// --------------------------------------
// Etapa 7: Stack, Heap e Garbage Collecotr

var t23 = new Etapa_07();
Console.WriteLine($"{t23.GetType()}");
Etapa_07.SubCap01(); // Tipos complexos, armazenados no Heap
Etapa_07.SubCap02(); // Tipos primitivos, armazenamdos na Stack
