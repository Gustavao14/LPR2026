using System;
using System.Collections.Generic;

class Program
{
    // Define uma classe abstrata para personagem
    abstract class Personagem
    {
        public string Nome { get; set; }
        public abstract void MostrarHabilidades();
    }

    class Guerreiro : Personagem
    {
        public override void MostrarHabilidades()
        {
            Console.WriteLine("Habilidades especiais do Guerreiro:");
            Console.WriteLine("- Ataque Poderoso");
            Console.WriteLine("- Defesa Implacável");
            Console.WriteLine("- Fúria Guerreira");
        }
    }

    class Mago : Personagem
    {
        public override void MostrarHabilidades()
        {
            Console.WriteLine("Habilidades especiais do Mago:");
            Console.WriteLine("- Bola de Fogo");
            Console.WriteLine("- Teletransporte");
            Console.WriteLine("- Barreira Mágica");
        }
    }

    class Arqueiro : Personagem
    {
        public override void MostrarHabilidades()
        {
            Console.WriteLine("Habilidades especiais do Arqueiro:");
            Console.WriteLine("- Tiro Preciso");
            Console.WriteLine("- Chuva de Flechas");
            Console.WriteLine("- Invisibilidade Temporária");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Escolha sua classe de personagem:");
        Console.WriteLine("1 - Guerreiro");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueiro");

        Console.Write("Digite o número da classe desejada: ");
        string escolha = Console.ReadLine();

        Personagem personagem = null;

        switch (escolha)
        {
            case "1":
                personagem = new Guerreiro();
                break;
            case "2":
                personagem = new Mago();
                break;
            case "3":
                personagem = new Arqueiro();
                break;
            default:
                Console.WriteLine("Opção inválida. Escolha 1, 2 ou 3.");
                return;
        }

        personagem.MostrarHabilidades();
    }
}