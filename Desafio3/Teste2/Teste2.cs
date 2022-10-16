// https://github.com/AndersonMazah/DIO.ProgramandoEmCSharp/blob/master/Desafio_AumentoDeSalario/Program.cs

using System;


namespace Desafio3.Teste2;

public class minhaClasse
{
    public static void Main(string[] args)
    {
        decimal salario = 0.00M;
        decimal reajuste = 0.00M;
        decimal novoSalario = 0.00M;
        decimal percentual = 0.00M;

        salario = Decimal.Parse(Console.ReadLine());

        //TODO: Complete os espaços em branco com uma possível solução para o problema:
        if (salario < 0)
        {
            return;
        }
        else if (salario <= 400M)
        {
            percentual = 15;
            reajuste = salario * percentual * 0.01M;
            novoSalario = salario + reajuste;
        }
        else if (salario <= 800M)
        {
            percentual = 12;
            reajuste = salario * percentual * 0.01M;
            novoSalario = salario + reajuste;
        }
        else if (salario <= 1200M)
        {
            percentual = 10;
            reajuste = salario * percentual * 0.01M;
            novoSalario = salario + reajuste;
        }
        else if (salario <= 2000M)
        {
            percentual = 7;
            reajuste = salario * percentual * 0.01M;
            novoSalario = salario + reajuste;
        }
        else
        {
            percentual = 4;
            reajuste = salario * percentual * 0.01M;
            novoSalario = salario + reajuste;
        }

        Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
        Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
        Console.WriteLine("Em percentual: {0} %", percentual);
    }
}