// https://github.com/AndersonMazah/DIO.ProgramandoEmCSharp/blob/master/Desafio_ElementoMajoritario/Program.cs


namespace Desafio3.Teste1;


public class Program2
{
    public static void Main(String[] args)
    {
        int qtde = int.Parse(Console.ReadLine());
        List<int> listaNum = new List<int>();
        for (int i = 0; i < qtde; i++)
        {
            listaNum.Add(int.Parse(Console.ReadLine()));
        }
        int maiorNum = listaNum.GroupBy(nr => nr).OrderByDescending(q => q.Count()).FirstOrDefault().Key;
        Console.WriteLine(maiorNum);
    }
}




/*
public class Program
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] num = new int[n];

        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < n; i++) // Preencher
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));
    }

    public static int MajorityElement(int[] nums)
    {
        int major = nums[0];
        int count = 1;
        for ( )
        {
            if ()
            {
                major = nums[i];
                count;
            }
            else
            {
                if (major == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }
        return;
    }
}*/



