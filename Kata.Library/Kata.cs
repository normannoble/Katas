using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.Library
{
    public class Kata
    {
        public static string[] Bald(string x)
        {
            var hairs = new Dictionary<int,string>()
            {
                {0,"Clean!"},
                {1,"Unicorn!"},
                {2,"Homer!"},
                {3,"Careless!"},
                {4,"Careless!"},
                {5,"Careless!"}
            };

            string hairDescription = "Hobo!"; 
            hairs.TryGetValue(key: x.Count(f => f == '/'), value: out hairDescription);

            if (hairDescription==null)
            {
                hairDescription = "Hobo!";
            }

            return new string[]{ x.Replace("/", "-"), hairDescription };
        }
    }
}
