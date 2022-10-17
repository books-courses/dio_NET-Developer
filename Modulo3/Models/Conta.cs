// Estudos de Classes Abstratas
// Classe Abstrata serve para que que classes filhas herdem!
// Não é possível chamar uma classe abstratas com o "new"
// Classe Abstrata são modelos!

namespace Modulo3.Models;

public abstract class Conta
{
    protected decimal saldo; // Possibilita que classes filhas possam alterar as propriedades protected!!

    public abstract void Creditar(decimal valor); // Não tem função! Querm herdar a classe conta, precisará definir esse método!

    public void ExibirSaldo()
    {
        Console.WriteLine($"O seu saldo é {saldo}");
    }
}
