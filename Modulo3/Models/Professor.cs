namespace Modulo3.Models;

// Professor Herdando de Pessoa
public class Professor : Pessoa
{
    // Como o construtor de Pessoa requer nome!, é necessário passar 
    // nome para o objeto pessoa!
    public Professor(string nome) : base(nome)
    {
        
    }
    
    
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
