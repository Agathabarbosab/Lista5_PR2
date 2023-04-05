using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menu

            float exercicio;
            Console.WriteLine(" ======Menu====== ");
            Console.WriteLine(" exercício 1 - Digite1 ");
            Console.WriteLine(" exercício 2 - Digite2 ");
            Console.WriteLine(" exercício 3 - Digite3 ");
            Console.WriteLine(" exercício 4 - Digite4 ");
            Console.WriteLine(" exercício 5 _ Digite5 ");
            Console.WriteLine(" exercício 6 - Digite6 ");
            Console.WriteLine(" exercício 6 - Digite7 ");

            exercicio = float.Parse(Console.ReadLine());

            switch (exercicio)
            {
                case 1:

                    int n;
                    Console.WriteLine("Digite um numero:");
                    n = int.Parse(Console.ReadLine());

                    for (int i=1; i<=n; i++)
                    { 
                        Console.WriteLine(i);
                    }
                   
                    


                    break;


                case 2:
                    int n;
                    Console.WriteLine("Digite um numero:");
                    n = int.Parse(Console.ReadLine());
                    for()

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;


                    default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
            Console.ReadKey();
        }
    }
}
