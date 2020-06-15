using System;

namespace _4thTaskPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите точность e, e>0");
            double e = Convert.ToDouble(Console.ReadLine());

            int i = 0;
            double function = 1 / (Math.Pow(4, i) + Math.Pow(5, i + 2));
            double sum = 0;
            while(Math.Abs(function)>e)
            {
                sum = sum+function;
                i++;
                function = 1 / (Math.Pow(4, i) + Math.Pow(5, i + 2));
            }
            Console.WriteLine(sum);
        }
    }
}
