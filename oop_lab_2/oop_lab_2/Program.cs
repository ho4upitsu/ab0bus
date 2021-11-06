using System;

namespace oop_lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть n - ");
            int n = Convert.ToInt32(Console.ReadLine());

            double k = Math.Pow(n,2), i = 0;
            double a = 0D;
            
            while (n*k != k)
            {
                
                a += (Math.Pow(k, 2) + Math.Pow(-1,k-1) * 2 * k - 1)/(Math.Pow(k,2)+2);
                Console.WriteLine("a[" + i + "] = " + a);
                i++;
            }
            
        }
    }
}
