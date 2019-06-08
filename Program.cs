using System;

namespace demo07.whileLoop.pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many floor? :");
            int pyramid_floor = int.Parse(Console.ReadLine());
            string pyramid_print = "";

            while(pyramid_floor > 0)
            {
                pyramid_print += "*";
                Console.WriteLine(pyramid_print);
                pyramid_floor--;
            }


        }
    }
}
