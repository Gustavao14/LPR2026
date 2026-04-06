using System;

class ProgramaJedi
{
    static void Main()
    {
        Console.WriteLine("=== Treinamento Jedi ===");
        Console.Write("Digite o número de horas de treinamento por dia: ");
        double horasPorDia = double.Parse(Console.ReadLine());

        // Considerando apenas dias úteis (segunda a sexta)
        double horasPorSemana = horasPorDia * 5;

        double totalHoras = 0;
        int semanas = 0;

        // Estrutura de repetição para acumular até atingir 1000 horas
        while (totalHoras < 1000)
        {
            totalHoras += horasPorSemana;
            semanas++;
        }

        // Cálculos finais
        double dias = semanas * 5;
        double meses = semanas / 4.5;

        Console.WriteLine("\n--- Resultado ---");
        Console.WriteLine($"Total de horas por semana: {horasPorSemana}h");
        Console.WriteLine($"Semanas necessárias: {semanas}");
        Console.WriteLine($"Dias necessários: {dias}");
        Console.WriteLine($"Meses necessários: {meses:F2}");
    }
}