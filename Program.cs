using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature:");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter celsius or fahrenheit (C/F):");
            char type = Convert.ToChar(Console.ReadLine().ToLower());

            switch(type)
            {
                case 'c':
                    F(temp);
                    break;
                case 'f':
                    C(temp);
                    break;
            }
        }

        static void C(int a)
        {
            int result = (a - 32) * 5 / 9;
            Console.WriteLine($"Temperature is {result} celsius");
        }

        static void F(int a)
        {
            int result = (a * 9 / 5) + 32;
            Console.WriteLine($"Temperature is {result} fahrenheit");
        }
    }
}
