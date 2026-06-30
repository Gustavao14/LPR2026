using System;

class Program
{
    static string ClassificarAluno(int nota )
    {
        if (nota < 60)
        {

            return "Reprovado";
        }
        else if (nota > 60 && nota < 79)
        {
            return "Recuperacao";
        }
        else 
        {
            return "Aprovado";
        }
    }
    static void Main(string[] args)
    {
        int aprovados = 0;
        int recuperacao = 0;
        int reprovados = 0;
        int soma = 0;
       string[] alunos = new string[10];
       Console.WriteLine("Digite o nome de 10 alunos:");
       for (int i = 0; i < 10; i++)
        {
            Console.Write($"nomes dos alunos:{i + 1}");
            alunos[i] = Console.ReadLine();
        }
        int[] nota = new int[10];
       Console.WriteLine("Digite a nota dos 10 alunos:");
       for (int i = 0; i < 10; i++)
        {
            Console.Write($"notas de{alunos(i)}");
            nota[i] = int.Parse(Console.ReadLine()); // o int.Parse converte de texto para número
            soma += nota(i);
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"O aluno {alunos[i]} foi {ClassificarAluno(nota[i])}");
             
        }
      float media = soma / 10; 
      Console.WriteLine($"Aprovados: {aprovados}");
        Console.WriteLine($"Recuperação: {recuperacao}");
        Console.WriteLine($"Reprovados: {reprovados}");
        Console.WriteLine($"Média da turma: {media}");
    }
}