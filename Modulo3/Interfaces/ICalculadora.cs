// Interface!
// Contrato!
// Por padrão, não implanta métodos! Podo ocorrer.... mas é excessão!
// Se tiver o método definido, a classe que herda a interface é opcional...


namespace Modulo3.Interfaces;

public interface ICalculadora
{
    int Somar(int num1, int num2);
    int Subtrair(int num1, int num2);
    int Multiplicar(int num1, int num2);
    int Dividir(int num1, int num2);
}
