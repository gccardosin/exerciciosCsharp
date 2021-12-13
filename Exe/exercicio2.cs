using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{

    class Personagem
    {

        void verificarCategoria(dados c)
        {
            if (c.categoria == "1")
            {
                Console.WriteLine("ladrao");
            }
            if (c.categoria == "2")
            {

                Console.WriteLine("clerico");
            }
            if (c.categoria == "3")
            {

                Console.WriteLine("guerreiro");
            }
         
        }

        public struct dados
        {
            public string nome;
            public string categoria;

        }

        class Program
        {
            static void Main(string[] args)
            {
                List<dados> listaPersonagens = new List<dados>();
                dados entrada;


                bool parada = true;
                String n;
                int cont = 0;

                Personagem personagem = new Personagem();

                while (parada)
                {
                    Console.WriteLine("\n\nDefina um nome para o personagem");
                    entrada.nome = Console.ReadLine();

                    Console.WriteLine("Informe a categoria do personagem (1) PARA LADRAO, (2) PARA CLERICO, (3) PARA GUERREIRO ");
                    entrada.categoria = Console.ReadLine();



                    listaPersonagens.Add(entrada);

                    Console.WriteLine("Digite 0 para parar ou 1 para continuar");
                    n = Console.ReadLine();

                    if (n == "0")
                    {
                        parada = false;
                    }

                    cont++;
                }


                Console.Clear();

                foreach (dados umPersonagem in listaPersonagens)
                {
                    Console.WriteLine("\nNome : " + umPersonagem.nome);
                    Console.WriteLine("\nCategoria : ");
                    personagem.verificarCategoria(umPersonagem);
                    Console.WriteLine("\nQuantidade de personagens criados: " + cont);

                }
                Console.ReadKey();
            }
        }
    }
}
