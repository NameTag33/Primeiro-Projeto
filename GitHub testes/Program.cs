using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_testes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Pescolha;
            Console.WriteLine("======= Calculadora =======");
            Console.Write("\nDigite\n [1] Para soma\n [2] Para subtrair\n [0] Para sair\n Opção: ");
            while(!int.TryParse(Console.ReadLine(), out Pescolha))
            {
                Console.WriteLine("Digite apenas numeros inteiros entr [0-2]");
                Console.Write("Nova opção: ");
            }

        }
    }
}
