using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2___Udemy___Solução_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "";
            int urgencia;

            Console.WriteLine("Olá, Digite seu nome, por favor.");
            name = Console.ReadLine();
            Console.Write("Prazer,");
            Console.WriteLine(name);
            Console.WriteLine("Com base na sua urgência, digite de 0 a 10.");
            urgencia = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------");

            if (urgencia >= 0 & urgencia <= 3)
            {
                Console.WriteLine("Seu nível de urgência é, Baixa");
            }
            else if (urgencia >= 3 & urgencia <= 6)
            {
                Console.WriteLine("Seu nível de urgência é, Média");
            }
            else if (urgencia >= 6 & urgencia <= 9)
            {
                Console.WriteLine("Seu nível de urgência é, Alta");
            }
            else if (urgencia >= 9)
            {
                Console.WriteLine("Seu nível de urgência é, Grave");
            }

            else
            {
                Console.WriteLine("Erro na Digitação, tente novamente");
            }
            Console.ReadLine();
        }
    }
}
