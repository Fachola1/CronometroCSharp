using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cronômetro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            try
            {
                Console.WriteLine("Digite quantos segundos ou minutos deseja cronometrar: ");
                int numeroUsuario = int.Parse(Console.ReadLine());
                if (numeroUsuario <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O número não pode ser 0 ou negativo");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Menu();
                }
                Console.WriteLine("Em segundos ou minutos? - s / m");
                char escolhaUsuario = char.Parse(Console.ReadLine().ToLower());
                int multiplicador = 1;

                if (escolhaUsuario == 'm')
                {
                    multiplicador = 60;
                    int numeroDepois = numeroUsuario * multiplicador;
                    int contador = 0;

                    while (contador < numeroDepois)
                    {
                        contador++;
                        Console.WriteLine(contador);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                }

                else if (escolhaUsuario == 's')
                {
                    multiplicador = 0;
                    while (multiplicador <= numeroUsuario)
                    {
                        Console.WriteLine(multiplicador);
                        multiplicador++;
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }

                else
                {
                    Console.WriteLine("Escolha não identificada!");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Menu();

                }

                
            }
            catch (Exception)
            {
                Console.WriteLine("Erro! Tente novamente");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Menu();
            }
            

           
        }
        
    }
    
}
