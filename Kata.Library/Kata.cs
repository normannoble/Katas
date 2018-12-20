using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.Library
{
    public class Kata
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a==null || b==null){
                return false;
            }

            var listA = new List<int>(a);
            var listB = new List<int>(b);

            if (listA.Count()==0 && listB.Count()==0){
                return true;
            }
            
            if (listA.Count() != listB.Count()){
                return false;
            }

            listA = listA.OrderBy(x => x).ToList();
            listB = listB.OrderBy(x => x).ToList();
            
            if (listA.Max() > listB.Max()){
                listB = listB.Select(x => x * x).ToList();
            } else if (listB.Max() > listA.Max()) {
                listA = listA.Select(x => x * x).ToList();
            }

            return listA.SequenceEqual(listB);
        }
    }
}
