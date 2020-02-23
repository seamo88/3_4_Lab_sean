using System;
using System.Text.RegularExpressions;

namespace _3_4_Lab_sean
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Z]";
            string pattern1 = @"[d-e]";
            string pattern2 = @"[d-e][*d]";
            string pattern3 = @"[a][a-z][a]";
            string pattern4 = @"[ ][p][a-z]* ";
            string pattern5 = @"[a-z]*[e][ ]";
            



            string input = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....
";
            RegexOptions options = RegexOptions.Multiline;

            //1
            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }
            //2
            foreach (Match m in Regex.Matches(input, pattern1, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }
            //3
            foreach (Match m in Regex.Matches(input, pattern2, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }
            //4
            foreach (Match m in Regex.Matches(input, pattern3, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }
            //5
            foreach (Match m in Regex.Matches(input, pattern4, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }
            //6
            foreach (Match m in Regex.Matches(input, pattern5, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }
            //7
        }
    }
}
