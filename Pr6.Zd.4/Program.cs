using System;
using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            Console.WriteLine("Введите 3 числа");
            Console.Write("a= ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("c= ");
            c = Convert.ToInt16(Console.ReadLine());
            x = (a * b * c) / 2;
            Console.WriteLine("Результат вычисления :{0}", x);

        }
    }
}
