using ListaVetor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI46
{
    internal class Program
    {
        static void Main(string[] args)

        {

          Lista1 lista1 = new Lista1();

            string op;

            do
            {
                Console.WriteLine("Seja Bem Vindos \n");
                Console.WriteLine("Escolha uma Lista \n");
                Console.WriteLine("Lista 1");
                

                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)


                {

                    case 1:
                        lista1.menu01();
                        break;


                    case 2:
                        //lista2.menu02();
                        break;


                    case 3:
                        //lista3.menu03();
                        break;

                    case 4:
                        //lista4.menu04();
                        break;

                    default:
                        Console.WriteLine("Operação inválida.");

                        break;
                }

                Console.WriteLine("Deseja continuar \n");
                op = Console.ReadLine().ToLower();

            } while (op == "s");



        }


    }

}