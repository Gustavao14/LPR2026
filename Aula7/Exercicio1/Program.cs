using System;
class ExemploVetor
{
     void Main()
    {
        int[] numeros = new int [10];
        int pares = 0;
        int impares = 0;
        // Solicita ao usuário que insira as alturas
        Console.WriteLine("Digite 10 números inteiros:");
        // Loop para preencher o vetor com as alturas fornecidas pelo usuário
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Numero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

        if (numeros[i] % 2 == 0)
        {
            pares ++;
        }
        else
        {
            impares ++;
        }
        }

        int[] vetorpares = new int[pares];
        int[] vetorimpares = new int[impares];

        int indicepar = 0;
        int indiceimpar = 0;
        for(int i = 0; i < 10; i++)
        {
            if(numeros[i] % 2 == 0)
            {
                vetorpares[indicepar] = numeros[i];
                indicepar++;
            } else
            {
                vetorimpares[indiceimpar] = numeros[i];
                indiceimpar++;
            }

        }
        Console.WriteLine("\n Resultado");
        Console.WriteLine("\n numeros pares digitados:");
        for (int i = 0; i < vetorpares.Length; i++)
        {
            Console.Write(vetorpares[i] + " ");
        }
        Console.WriteLine("\n numeros ímpares digitados:");

        for (int i = 0; i < vetorimpares.Length; i++)
        {
            Console.Write(vetorimpares[i] + " ");
        }
        Console.WriteLine();

    }
}