// See https://aka.ms/new-console-template for more information

using Modulo3.Models;

// -------------------------------------------
// Pessoa
Pessoa p1 = new Pessoa();

p1.Nome = "Michel";
p1.Idade = 34;
p1.Apresentar();



// -------------------------------------------
// Conta Corrente
ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(6442);
c1.ExibirSaldo();


// -------------------------------------------
// Aluno: Herança!
Aluno a1 = new Aluno();
a1.Nome = "Zé";
a1.Idade = 24;
a1.Nota = 3.4M;
a1.FalarNota();
a1.Apresentar();

Professor prof1 = new Professor();
prof1.Nome = "Reinaldo";
prof1.Idade = 67;
prof1.Salario = 10.400M;
prof1.FalarSalario();
prof1.Apresentar();
