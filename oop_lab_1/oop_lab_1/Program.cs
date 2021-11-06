using System;

namespace oop_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Обчислення об'єму циліндра по відомим значенням висоти та радіуса основи
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть радіус основи - ");
            
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть висоту - ");
            
            int sOsn = Convert.ToInt32(Console.ReadLine());
            double v = 3.14 * Math.Pow(r, 2) * sOsn;

            if (r > 0 || sOsn > 0)
            {
                Console.WriteLine("Об'єм циліндра - " + v);
            }

            else
            {
                Console.WriteLine("Об'єм та радіус повинні бути більшими за 0");
               
            }
            
        }
    }
}
