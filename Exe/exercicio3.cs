using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rascunho
{

    class Nave
    {

        void verificarTipo(dados c)
        {
            if (c.categoria == "1")
            {
                Console.WriteLine("Nave tipoA");
            }
            if (c.categoria == "2")
            {

                Console.WriteLine("Nave tipoB");
            }
            if (c.categoria == "3")
            {

                Console.WriteLine("Nave tipoC");
            }

        }




        public static string defineResistencia()
        {
            Random rnd = new Random();
            int valor = rnd.Next(60, 101);
            return valor.ToString();
        }


        public struct dados
        {

            public string categoria;
            public string nome;
            public string resistencia;
        }



        class Program
        {
            static void Main(string[] args)
            {
                List<dados> listaNaves = new List<dados>();
                dados entrada;


                bool parada = true;
                String n;
                int cont = 0;

                Nave navi = new Nave();

                while (parada)
                {
                    Console.WriteLine("\n\nDefina um nome para a Nave");
                    entrada.nome = Console.ReadLine();

                    Console.WriteLine("Informe a categoria da nave (1) para A, (2) para B, (3) para C: ");
                    entrada.categoria = Console.ReadLine();

                    entrada.resistencia = defineResistencia();

                    listaNaves.Add(entrada);

                    Console.WriteLine("Digite 0 para parar ou 1 para continuar");
                    n = Console.ReadLine();

                    if (n == "0")
                    {
                        parada = false;
                    }

                    cont++;
                }


                Console.Clear();

                foreach (dados umaNave in listaNaves)
                {
                    Console.WriteLine("\nNome : " + umaNave.nome);
                    Console.WriteLine("Categoria : ");
                    navi.verificarTipo(umaNave);
                    Console.WriteLine("Resistencia: " + umaNave.resistencia);
                }
                Console.WriteLine("\nQuantidade de Naves criadas: " + cont);

                Console.ReadKey();
            }
        }
    }
}
