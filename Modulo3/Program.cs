// See https://aka.ms/new-console-template for more information

using Modulo3.Models;

// -------------------------------------------
// Pessoa
Pessoa p1 = new Pessoa("Michel");

p1.Idade = 34;
p1.Apresentar();


// -------------------------------------------
// Aluno: Herança!

Aluno a1 = new Aluno("Zé");
a1.Nome = "Zezinho!";
a1.Idade = 24;
a1.Nota = 3.4M;
a1.FalarNota();
a1.Apresentar();

// -------------------------------------------
// Professor: Herança!
Professor prof1 = new Professor("Reinaldo");
prof1.Idade = 67;
prof1.Salario = 10.400M;
prof1.FalarSalario();
prof1.Apresentar();


// -------------------------------------------
// Diretor: Herança!
Diretor dir1 = new Diretor("Afonso");
dir1.Idade = 67;
dir1.Salario = 10.400M;
dir1.FalarSalario();
dir1.Apresentar();


// -------------------------------------------
// Conta Corrente

// ContaCorrente conta1 = new ContaCorrente();
Corrente c1 = new Corrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(642);
c1.Creditar(4322);
c1.ExibirSaldo();


// -------------------------------------------
// Calculadora

Calculadora calc = new Calculadora();
calc.Dividir(30, 7);
calc.Multiplicar(30, 7);




