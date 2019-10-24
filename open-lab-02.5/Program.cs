using System;

namespace open_lab_02._5
{
    class Program
    {


        public static bool DivisibleByFive(int a)
        {
            return true;
        }
    
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 5 == 0)
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

