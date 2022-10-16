namespace Modulo3.Models;

// Aluno Herdando de Pessoa
public class Aluno : Pessoa
{
    public decimal Nota { get; set; }


    public void FalarNota()
    {
        Console.WriteLine($"Minha nota é {Nota}");
    }
    public override void Apresentar()
    {
        Console.WriteLine($"Olá. Sou Aluno! Meu nome é {Nome} e tenho {Idade} anos");
    }
}