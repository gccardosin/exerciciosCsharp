using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] listaPalavras = new string[20];

            for (int cont = 0; cont < 20; cont++)
            {
                Console.WriteLine("Desja Continuar (1) sim (2) nao: ");
                    String opcao = Console.ReadLine();
                if(opcao.Equals("2"))
                {
                    break;
                }

                Console.WriteLine("Digite uma palavra : ");
                listaPalavras[cont] = Console.ReadLine()
               
                    .Replace('a', 'X')

               .Replace('e', 'X')

               .Replace('i', 'X')

               .Replace('o', 'X')

               .Replace('u', 'X');


            }
            
            Console.Clear();

            

            foreach (string umaPalavra in listaPalavras)
            {
               

                Console.WriteLine("Palavra    : " + umaPalavra);

            }


            Console.ReadKey();
        }
    }
}