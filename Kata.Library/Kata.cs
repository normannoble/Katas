using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.Library
{
    public class Kata
    {
        public static string[] Bald(string x)
        {
            var hairCount = x.Count(y => y == '/');
            var hairDescription = (hairCount > 5) ? "Hobo!" : 
                (hairCount >= 3 && hairCount <= 5) ? "Careless!" : 
                (hairCount == 2) ? "Homer!" : 
                (hairCount == 1) ? "Unicorn!" : 
                "Clean!";

            return new string[]{ x.Replace("/", "-"), hairDescription };
        }
    }
}
