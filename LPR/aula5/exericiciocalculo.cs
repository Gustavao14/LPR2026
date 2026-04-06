using System;

class Program
{
    static void Main()
    {
        // Inicializa a variável para armazenar a soma
        int soma = 0;

        // Percorre todos os números de 1 até 99 (menores que 100)
        for (int numero = 1; numero < 100; numero++)
        {
            // Verifica se o número é ímpar e múltiplo de 3
            if (numero % 2 != 0 && numero % 3 == 0)
            {
                soma += numero; // Adiciona o número à soma
            }
        }

        // Exibe o resultado
        Console.WriteLine($"A soma de todos os números ímpares múltiplos de 3 menores que 100 é: {soma}");
    }
}