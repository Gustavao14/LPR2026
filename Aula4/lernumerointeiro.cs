using System;

class ProgramaParidade
{
    static void Main()
    {
        try
        {
            // Solicita a entrada do usuário
            Console.Write("Digite um número inteiro: ");
            string input = Console.ReadLine();

            // Converte a entrada para número inteiro
            int numero = int.Parse(input);

            // Verifica se o número é par
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }
        }
        catch (FormatException)
        {
            // Caso o usuário não digite um número válido
            Console.WriteLine("Erro: Por favor, digite um número inteiro válido.");
        }
    }
}