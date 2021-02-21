using System.Collections.Generic;
using System.Linq;

public class Challenge_100
{
        //challenge-100

        static int[] FinMaxMin(int[] arr)
        {
            return new int[] { arr.Min(), arr.Max() };
        }

        static string NameShuffle(string s)
        {
            List<string> result = s.Split(' ').ToList();
            result.Reverse();
            return string.Join(" ", result); ;
        }

        static bool SameCase(string s)
        {
            return (s.Equals(s.ToUpper()) || s.Equals(s.ToLower()));
        }

        static bool IsIsogram(string s)
        {
            s = s.ToLower();
            return !(s.Distinct().Count() < s.Length);
        }

 }

