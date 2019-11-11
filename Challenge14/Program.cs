using System;
using System.Linq;

namespace PalindromeDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please read the palindrome definition
            IsPalindrome("ipsum"); // false
            IsPalindrome("malam"); // true
            IsPalindrome("tidur"); // false
            IsPalindrome("kasur rusak"); // true
            IsPalindrome("ibu ratna antar ubi"); // true
        }

        private static bool IsPalindrome(string text)
        {
            string string1, rev;
            string1 = text;
            char[] ch = string1.ToCharArray();

            Array.Reverse(ch);
            rev = new string(ch);

            bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true) {
                Console.WriteLine("TRUE");
            } else {
                Console.WriteLine("FALSE");
            }
            
            
            return true;
        }
    }
}
