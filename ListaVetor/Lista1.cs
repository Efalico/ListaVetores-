using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetor
{
    internal class Lista1
    {
        public void menu01()
        {


            string op;

            do
            {

                Console.WriteLine("Exercicio 1");
                Console.WriteLine("Exercicio 2");
                Console.WriteLine("Exercicio 3");
                Console.WriteLine("Exercicio 4");
                Console.WriteLine("Exercicio 5");
                Console.WriteLine("Exercicio 6");
                Console.WriteLine("Exercicio 7");
                Console.WriteLine("Exercicio 8");
                Console.WriteLine("Exercicio 9");
                Console.WriteLine("Exercicio 10");


                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)


                {

                    case 1:
                        exercicio1();
                        break;


                    case 2:
                        //exercicio2();
                        break;


                    case 3:
                        // exercicio3();
                        break;
                    case 4:
                        // exercicio4();
                        break;
                    case 5:
                        //exercicio5();
                        break;
                    case 6:
                        //exercicio6();
                        break;
                    case 7:
                        // exercicio7();
                        break;
                    case 8:
                        //exercicio8();
                        break;
                    case 9:
                        //exercicio9();
                        break;
                    case 10:
                        //exercicio10();
                        break;


                    default:
                        Console.WriteLine("Operação inválida.");

                        break;
                }

                Console.WriteLine("Deseja continuar \n");
                op = Console.ReadLine().ToLower();

            } while (op == "s");

        }




        public void exercicio1()
        {
            double[] numeros = new double[10];
            double resultado = 0, total=0;
            Random random = new Random();

            Console.Clear();
            Console.WriteLine("Digite as 4 notas: ");
          
           
            for (int i = 0; i <10; i++)
            {
               
                resultado += double.Parse(Console.ReadLine());
        

            }

            Console.WriteLine("---------------------------------------");
            total = resultado / 10;
            Console.WriteLine("Resultado é: " + total);



        }







 
    
    
    
    }
}