using System;
using System.Globalization;

namespace DividindoXporY_URI1116
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //.Split(' '); para capturar os valores entre um espaço e outro.
                string[] vet = Console.ReadLine().Split(' ');

                //Identifica os valores de X e Y que foram atribuídos ao vetor.
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);                

                //Caso o Y seja igual a zero.
                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }

                //Imprime o resultado com uma casa decimal ("F1"), CultureInfo.InvariantCulture, para imprimir os valores com ponto "10.0".
                else
                {
                    double total = (double) x / y;
                    Console.WriteLine(total.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}
