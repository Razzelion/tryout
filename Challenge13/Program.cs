using System;
using System.Linq;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            CountWords("Hello"); // Output: 1
            CountWords("Hello World"); // Output: 2
            CountWords("Lorem ipsum dolor sit amet"); // Output: 5

            
        }

        static int CountWords(string str)
        {
            int a = 0 , myWord = 1;
            while (a <= str.Length - 1) {
              if(str[a]==' ' || str[a]=='\n' || str[a]=='\t') 
              {
              myWord++;
              }
              a++;
              }

              Console.Write("Jumlah kata = {0}\n", myWord);

            return 0;
        }
    }
}
