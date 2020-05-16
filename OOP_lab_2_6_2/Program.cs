using System;

namespace OOP_lab_2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1;

            while (x <= 2)
            {
                double y = Math.Log2(x);

                Console.WriteLine("x = {0:f3}, y = {1:f4}", x, y);

                x += 0.025;
            }
        }
    }
}
