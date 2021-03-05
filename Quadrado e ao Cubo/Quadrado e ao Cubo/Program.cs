using System;

namespace Quadrado_e_ao_Cubo
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = Int32.Parse(Console.ReadLine());
            int i = 1;
            while (i <= num)
            {
                Console.WriteLine((i * 1) + " " + (i * i) + " " + (i * i) * i);
                i = i + 1;
            }
            Console.ReadLine();
        }
    }

}
