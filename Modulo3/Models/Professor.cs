namespace Modulo3.Models;

// Professor Herdando de Pessoa
public class Professor : Pessoa
{
    public decimal Salario { get; set; }
    public void FalarSalario()
    {
        Console.WriteLine($"Meu Salário é {Salario}");
    }
    
    // Polimorfismo!
    public override void Apresentar()
    {
        Console.WriteLine($"Olá. Sou professor! Meu nome é {Nome} e tenho {Idade} anos");
    }
}
