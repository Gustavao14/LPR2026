  using System;
  class Program{
    static void Main()
    {
        try
        {
            Console.Write("Informe a quantidade de números que serão digitados: ");
            if (!int.TryParse(Console.ReadLine(), out int quantidade) || quantidade <= 0)
            {
                Console.WriteLine("Quantidade inválida. Digite um número inteiro positivo.");
                return;
            }

            int somaPares = 0;
            int contadorPares = 0;

            // Loop para ler os números
            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                if (!int.TryParse(Console.ReadLine(), out int numero))
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                    i--; // repete a leitura para esta posição
                    continue;
                }

                // Verifica se é par
                if (numero % 2 == 0)
                {
                    somaPares += numero;
                    contadorPares++;
                }
            }

            // Exibe o resultado
            if (contadorPares > 0)
            {
                double media = (double)somaPares / contadorPares;
                Console.WriteLine($"\nMédia dos números pares: {media:F2}");
            }
            else
            {
                Console.WriteLine("\nNenhum número par foi digitado.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
  }