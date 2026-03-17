// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class Program {
    static void Main() {
        string[] peca1 = Console.ReadLine().Split(' ');
        int cod1 = int.Parse(peca1[0]);
        int qte1 = int.Parse(peca1[1]);
        double valor1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

        // --- LEITURA DA PEÇA 2 ---
        string[] peca2 = Console.ReadLine().Split(' ');
        int cod2 = int.Parse(peca2[0]);
        int qte2 = int.Parse(peca2[1]);
        double valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

        // --- CÁLCULO ---
        double total = (qte1 * valor1) + (qte2 * valor2);

        // --- RESULTADO ---
        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }
}
