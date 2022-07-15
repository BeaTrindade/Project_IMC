using System;

namespace Projeto_IMC_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----> Índice de Massa Corporal (IMC) <----");

            Console.WriteLine("\n ---> Qual seu Nome?");
            string name = Console.ReadLine();

            Console.WriteLine("\n ---> Qual sua idade?");
            string age = Console.ReadLine();

            Console.WriteLine("\n ---> Qual o seu peso? (Use vírgula)");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n ---> Qual sua altura? (Use vírgula)");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            float imc = peso / (altura * altura);

            Console.WriteLine("\n Seu IMC é \n" + imc);
        }
    }
}