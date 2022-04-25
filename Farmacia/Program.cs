using System;
using System.Collections.Generic;
using System.Threading;


namespace Farmacia
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> remedios = new List<string>();
            remedios.Add("Dipirona");
            remedios.Add("Torsilax");
            remedios.Add("Amoxicilina");
            remedios.Add("Dorflex");
            remedios.Add("Neosaldina");
            remedios.Add("Losartana");
            remedios.Add("Loratadina");

            string nome;

            do
            {



                Console.WriteLine("Remedios disponíveis");
                foreach (var remedio in remedios)
                {
                    Console.WriteLine("Nome dos remedios: " + remedio);
                }



                Console.WriteLine();
                Console.WriteLine("Digite o nome do remédio que quer escolher");
                nome = Console.ReadLine();

                if (remedios.IndexOf(nome) >= 0)
                {
                    Console.WriteLine("Remedio disponivel: " + nome);
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.Clear();
                    
                }
                else
                {
                    Console.WriteLine("Remedio fora de estoque!");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.Clear();

                }
            } while (nome != "0");
        }
    }
}
