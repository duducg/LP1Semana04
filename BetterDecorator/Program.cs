using System;

namespace BetterDecorator
{/// <summary>
/// Contains the static "Main" and "Decor" methods.
/// </summary>
    class Program
    
    {/// <summary>
    /// Takes in 3 arguments and prints an interpolated string to Console.
    /// </summary>
    /// <param name="args">string array passed in via CMD</param>
        private static void Main(string[] args)
        {
            string out_ = "";
            
            if (args.Length == 0)
            {
                out_ = Decor();
            } 
            else
            {
                string s_ = args[0];
                char dec_ = char.Parse(args[1]);
                int rep_ = int.Parse(args[2]);
                out_ = Decor(s_, dec_, rep_);
            }
            

            Console.WriteLine(out_);            

            
        }
        private static string out_ = "User did not specify args!";
        
        /// <summary>
        /// Takes in no arguments.
        /// </summary>
        /// <returns>A custom error string</returns>
        private static string Decor() => Decor(out_,'=',3);

        /// <summary>
        /// Takes in a string, a char and an int argument.
        /// </summary>
        /// <param name="s">string that will sit between the chars</param>
        /// <param name="dec">chars that will repeat</param>
        /// <param name="rep">Number of repetitions for the char</param>
        /// <returns>An interpolated string</returns>
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
