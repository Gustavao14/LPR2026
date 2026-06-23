
using System;
using System.Globalization;

class Program
{
    static int [,] cadeiras = new int[8,6];
        
    static string consultaassento(int c, int l)
    {
        if(cadeiras [c, l] == 0)
        {
            return "Livre";
        }
        else
        {
            return "Ocupado";
        }
        
    }
    static void main() {
         for ( int i = 0; i < 8; i++) {
            for (int j = 0; j < 6; j++) {
                cadeiras [i, j] = 0;

            }
        }
        while (true)
        {
            Console.WriteLine("-1 Adicionar reserva.");
            Console.WriteLine("-2 Remover reserva.");
            Console.WriteLine("-3 Consultar assento.");
            Console.WriteLine("-4 Mapa da sala.");
            Console.WriteLine("-5 Encerrar aula.");
            Console.WriteLine ("Qual das opções você quer?");
            int opcao;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out opcao))
                {
                    if(opcao > 0 && opcao < 6)
                    {
                        break;    
                    }
                    
                }
                Console.WriteLine("Entrada Invalida."); 
            }            
            if(opcao == 1)
            {
               Console.WriteLine("Digite a coluna:");
               int c = int.Parse (Console.ReadLine());
               Console.WriteLine("Digite a linha:");
               int l = int.Parse (Console.ReadLine()); 
               if(consultaassento(c, l) == "Livre")
                {
                    cadeiras [c,l] = 1;
                    Console.WriteLine("Assento reservado com sucesso");
                }
                else
                {
                    Console.WriteLine("Esse assento já está reservado");
                }
            }
            if(opcao == 2)
            {
                 Console.WriteLine("Digite a coluna:");
               int c = int.Parse (Console.ReadLine());
               Console.WriteLine("Digite a linha:");
               int l = int.Parse (Console.ReadLine());
               cadeiras[c, l] = 0;
               Console.WriteLine("Reserva cancelada com sucesso");
            }
            if(opcao == 3)
            {
                 Console.WriteLine("Digite a coluna:");
               int c = int.Parse (Console.ReadLine());
               Console.WriteLine("Digite a linha:");
               int l = int.Parse (Console.ReadLine()); 
               if(consultaassento(c, l) == "Livre")
                {
                    Console.WriteLine("Este assento está livre.");
                }
                else
                {
                    Console.WriteLine("Este assento está ocupado");
                }
            }
            if (opcao == 4)
            {
                for ( int i = 0; i < 8; i++) {
                    for (int j = 0; j < 6; j++) {
                        cadeiras [i, j] = 0;
                        if(cadeiras[i, j] == 0)
                        {
                            Console.Write("[Livre]");
                        }
                        else
                        {
                            Console.Write("[Ocupado]");
                        }
                    }

                    Console.WriteLine("");
                }
            }

            if (opcao == 5)
            {
                break;
            }
        }
        Console.WriteLine("Programa encerrado");
    }
}