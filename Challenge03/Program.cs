using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new method called "CountString".
            // That method should accept a string and will
            // return length of characters input.

            //Console.WriteLine("'Hello World!' have {0} characters", CountString("Hello World!"));
            //Console.WriteLine("'Hello Universe!' have {0} characters", CountString("Hello Universe!"));

            string str;
            int alp, digit, splch, i,l;
            alp = i = 0;

            Console.Write("Input the string : ");
            str = Console.ReadLine();	
            l=str.Length; 

            while(i<l)
            {
            if((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z'))
            {
                alp++;
            }
            else if(str[i]>='0' && str[i]<='9')
            {
                alp++;
            }
            else
            {
                alp++;
            }

            i++;

            
            }
            Console.WriteLine($"{str} have {alp} characters");
        }    
    }
}
