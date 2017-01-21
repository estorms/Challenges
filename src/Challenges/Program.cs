using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ChallengeLib challengeLib = new ChallengeLib();
            challengeLib.FizzBuzz();
            Console.WriteLine(challengeLib.IsPalindrome("koala"));
            Console.WriteLine(challengeLib.IsPalindrome("kayak"));
            for (var j = 0; j <=15; j++)
            {
                Console.WriteLine(challengeLib.Fib(j));
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
