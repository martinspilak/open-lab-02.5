using System;

namespace open_lab_02._5
{
    class Program
    {


        public static bool DivisibleByFive(int a)
        {
            return (a % 5 == 0);
        }
    
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (DivisibleByFive(a))
            { 
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}

