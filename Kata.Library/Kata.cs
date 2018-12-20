using System;
using System.Collections.Generic;

namespace Kata.Library
{
    public class Kata
    {
        public static bool ValidBraces(String inputString)
        {
            var characters = inputString.ToCharArray();
            var openingBraces = new List<char>(){'(','{','['};
            var closingBraces = new List<char>(){')','}',']'};
            
           if (characters.Length % 2 != 0){
               return false;
           }

           if (characters.Length == 0){
               return false;
           }

           if (!openingBraces.Contains(characters[0])){
               return false;
           }

           if (!closingBraces.Contains(characters[characters.Length - 1])){
               return false;
           }
            
            var braces = new List<char>(){ ')', '{', '[', '(' };
            var curlyBraces = new List<char>(){ '}', '(', '[', '{' };
            var brackets = new List<char>(){ ']', '{', '(', '[' };
            
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == '(' && !braces.Contains(characters[i + 1])){
                    return false;
                }

                if (characters[i] == '{' && !curlyBraces.Contains(characters[i + 1])){
                    return false;
                }

                if (characters[i] == '[' && !brackets.Contains(characters[i + 1])){
                    return false;
                }
            }

            return true;
        }
    }
}
