using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            //invoke GetMethod() here.
            Console.Write("Insert n-th number of the special sequence: ");
            int user_in = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(user_in));
        }
        //recursive method
        private static int a = 0, b = 1,c;
        private static int GetSpecial(int n)
        {       


            //n is the number of iterations this goes for
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                c = b;
                b = b  + (a * 2);
                a = c;
                GetSpecial(n - 1);//solely used as a counter
            }
            return b;
        


        }
    }
}
