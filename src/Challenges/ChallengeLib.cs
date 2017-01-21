using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges
{
    public class ChallengeLib
    {
        public int Fib(int n) {
            int a = 0;
            int b = 1;
            int c;
            for (var i = 0; i <=n;  i++)
            {
                c = a;
                a = b;
                b = c + a;
            }
            return a;
        }

        public bool IsPalindrome(string testString)
        {
            return testString.SequenceEqual(testString.Reverse());
        }

        public void FizzBuzz ()
        {
            for (var k = 0; k <=25; k++)
            {
                bool fizz = k % 5 == 0;
                bool buzz = k % 3 == 0;
                if (fizz && buzz)
                {
                    Console.WriteLine("fizzbuzz");
                  
                    }
                    else if (fizz)
                {
                    Console.WriteLine("fizz");
                }
                else if (buzz)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(k);
                }
                }
            }
        }
    
}
