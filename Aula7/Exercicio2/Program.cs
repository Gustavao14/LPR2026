
using System;
using System.Reflection;
class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int ocorrencias = 0;
        
        for ( int i = 0; i < 10; i++)
        {
            Console.Write($"Posição [{i}] = ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine ("Digite o número que você quer ver no vetor:");
        int numeropesquisado = int.Parse(Console.ReadLine());

        Console.WriteLine($"procurando o número {numeropesquisado}");
        for(int i = 0; i<10; i++)
        {
            if(numeros[i] == numeropesquisado)
            {
                    Console.WriteLine($"Encontrei, está na posição (indice): {i}");
                    ocorrencias = 1;
            }
        }
        if (ocorrencias > 0)
        {
            Console.WriteLine($"Busca feita e o número {numeropesquisado} apareceu {ocorrencias} vezes no vetor");
        }else
        {
            Console.WriteLine($"Busca feita e o número {numeropesquisado} não foi encontrado no vetor");
        }

    }
}