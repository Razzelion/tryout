using System;
using System.Linq;
using System.Collections.Generic;
namespace MirrorString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mirror("--vv"); // Output: --vvvv--

            char[] s = {'-','-','v','v'};
            Console.Write("String = ");
            foreach(char arr in s) {
            Console.Write(arr);
            }

            IQueryable<char> res = s.AsQueryable().Reverse(); 
            Console.Write("\nMirror = ");
            Console.Write(s);
            foreach (char c in res) {
            Console.Write(c); 
            }
        }



        
    }
}
