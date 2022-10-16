namespace Models.MeuArray;

public class MeuArray<T>
{
    // Método Tradicional para definir um array
    private int[] array = new int[10];
    
    // Classe Genérica
    private static int capacidade = 10;
    private int contador = 0;
    private T[] array2 = new T[capacidade];

    public void AdicionarElementoArray(T elemento)
    {
        if (contador + 1 < 11)
        {
            array2[contador] = elemento;
        }
        contador++;
    }

    public T this[int index]
    {
        get { return array2[index]; }
        set { array2[index] = value; }
    }
}