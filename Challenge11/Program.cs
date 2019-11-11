using System.Linq;  
using System;

namespace SumArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;  
            int[] a = new int[30];
            Console.Write("jumlah angka : ");  
            
            int n = Convert.ToInt16(Console.ReadLine());   
            
            for (i = 1; i <= n; i++)  
            {  
            Console.Write("masukkan angka ke " + i + ":");  
            
            a[i] = Convert.ToInt16(Console.ReadLine());   
            }  
            
            for (i = 1; i <= n; i++)  
            {  
            for (int j = 1; j <= n - 1; j++)  
            {  
                if (a[j] > a[j + 1])  
                {  
                    int temp = a[j];  
                    a[j] = a[j + 1];  
                    a[j + 1] = temp;  
                }  
            }  
            }  
       
        Console.Write("Jumlah : "); 
        int sum = 0; 
        for (i = 1; i <= n; i++)  
        {  
            sum += a[i];
        }
        Console.Write($"{sum} ");
        }
    }
}
