using System;

namespace BetterDecorator
{
    class Program
    
    {
        static void Main(string[] args)
        {
            //take in 3 arguments from args[]
            //parsing
            string s_ = args[0];
            char dec_ = char.Parse(args[1]);
            int rep_ = int.Parse(args[2]);

            Console.WriteLine(Decor(s_, dec_, rep_));            

            
        }
        //Decor() - takes in "int" that indicates how many "char"
            private static string Decor(string s, char dec, int rep)
            {
                //build the prefix and suffix
                string pre_suff = "";
                for (int i = 0; i < rep; i++)
                {
                    pre_suff += dec;
                }
                string output = $"{pre_suff} {s} {pre_suff}";
                
                return output;

            }

    }
}
