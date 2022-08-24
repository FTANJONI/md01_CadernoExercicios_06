using System;

namespace md01_CadernoExercicios_06
{
    class Program
    {
        static void Main(string[] args)
        /*
         6. Faça um algoritmo que calcule e apresente o valor do volume de uma lata de óleo, utilizando a
         fórmula VOLUME = 3,14159 * RAIO2 * ALTURA.
        */
        {
            double r, a, v;

            Console.WriteLine("Digite o Raio:");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura:");
            a = Convert.ToDouble(Console.ReadLine());
            v = 3.14159 * (r * r) * a;
            Console.WriteLine("Volume da Lata: {0}", v.ToString("0.00"));
        }
    }
}
