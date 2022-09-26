// Isso é o entrypoint.
// Equivalente ao main.py do python
// See https://aka.ms/new-console-template for more information


// Importa coisas

using dio_NET_Developer.Model_Pessoa;
using dio_NET_Developer.Capitulo_01;
using dio_NET_Developer.Capitulo_02;
using dio_NET_Developer.Capitulo_03;
using dio_NET_Developer.Model_Calculadora;

// --------------------------------------
// Capitulo 1
// Variáveis
Cap01 c1 = new Cap01();

/*
Cap01.SubCap01();

// Data
Cap01.SubCap02();

// Conversão Formatos
Cap01.SubCap03();
*/


// --------------------------------------
// Capitulo 2
Cap02 c2 = new Cap02();


/*Cap02.SubCap01();

Cap02.SubCap02();*/


// --------------------------------------
// Capitulo 3
Cap03 c3 = new Cap03();

/*
Cap03.SubCap02();
*/


// --------------------------------------
// Calculadora


var calc = new Calculadora();

calc.Somar(3, 6);
calc.Subtrair(3, 6);
calc.Multiplicar(3, 6);
calc.Dividir(3, 6);
calc.Potencia(3, 6);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);


var numero = 10;
numero++;
Console.WriteLine(numero);
numero--;
Console.WriteLine(numero);

calc.RaizQuadrada(30);