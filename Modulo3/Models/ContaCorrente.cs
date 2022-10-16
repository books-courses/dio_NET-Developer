namespace Modulo3.Models;

public class ContaCorrente
{
    // Define Construtor
    public ContaCorrente(int numeroConta, decimal saldoInicial)
    {
        NumeroConta = numeroConta;
        saldo = saldoInicial;
    }
    
    // Define Propriedade (prop+Tab)
    public int NumeroConta { get; set; }
    private decimal saldo;  // Por ser método privado, só a classe consegue alterar 

    public void Sacar(decimal valor)
    {
        if (saldo >= valor)
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso");
            ExibirSaldo();
        }
        else
        {
            Console.WriteLine("Valor desejado é maior que o saldo disponível");
            ExibirSaldo();
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo disponível é {saldo}");
    }
}