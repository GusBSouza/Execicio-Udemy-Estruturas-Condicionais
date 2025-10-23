using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execício_2___Estruturas_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = (" ");

            int N1;
            int N2;
            int N3;


            Console.WriteLine("Olá, Qual seu nome ?");
            name = Console.ReadLine();
            Console.Write("Prazer,");
            Console.WriteLine(name);
            Console.WriteLine("Poderia me dar 3 números de 0 a 10 ?");
            Console.Write("Primeiro Número:");
            N1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo Número:");
            N2 = int.Parse(Console.ReadLine());
            Console.Write("Terceiro Número:");
            N3 = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------");

            Console.Write("Resultado é:");

            if (N1 < N2 & N1 < N3 )
            {
                Console.WriteLine("O primeiro número seu, é o menor deles.");
            }
            else if (N2 < N1 & N2 < N3)
            {
                Console.WriteLine(" O segundo número seu, é o menor deles.");
            }
            else if (N3 < N1 & N3 < N2)
            {
                Console.WriteLine(" O terceiro número seu, é o menor deles.");
            }
            else if (N1 == N2 & N2 == N3 & N1 == N3)
            {
                Console.WriteLine(" Todos os seus números são iguais. ");
            }
            else
            {
                Console.WriteLine("A operação falhou, tente novamente.");
            }
            
                Console.ReadLine();





        }
    }
}
