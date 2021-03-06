using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiklA
{
    class Program
    {

        static void Aa()
        {
            //Лабораторная работа (Арифметический цикл вариант 20 )

            double S = 0;



            Console.WriteLine("Введите число K");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число X");
            int x = Convert.ToInt32(Console.ReadLine());

        



            for (int i = 0; i < k; i++)
            {
                S += (Math.PI / 2) + Math.Pow((-1), (k + 1)) * (Math.Pow((x), (2 * k + 1))) / (2 * k + 1);


            }

            Console.WriteLine(S);
        }



        static void Main(string[] args)
        {
            Aa();
           
        }
    }
}
