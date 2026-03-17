using System;
using System.Globalization;


class Program
{
    static void Main()
    {
        int numero = int.Parse(Console.ReadLine());
        int horas = int.Parse(Console.ReadLine());
        double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Cálculo
        double salario = horas * valorHora;

        // Saída formatada
        Console.WriteLine($" O Número é = {numero}");
        Console.WriteLine($"sálario total é = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}