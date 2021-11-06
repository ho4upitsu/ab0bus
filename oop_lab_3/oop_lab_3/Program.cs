using System;

namespace oop_lab_3
{
    class Program
    {

        static bool horseSimulator(int x, int y)
        {
            if (x + 2 >= 1 && x + 2 <= 8 || x - 2 >= 1 && x - 2 <= 8)
            {
                if (y + 1 >= 1 && y + 1 <= 8 || y - 1 >= 1 && y - 1 <= 8)
                {
                    return true;
                }
            }
            else if (x + 1 >= 1 && x + 1 <= 8 || x - 1 >= 1 && x - 1 <= 8)
            {
                if (y + 2 >= 1 && y + 2 <= 8 || y - 2 >= 1 && y - 2 <= 8)
                {
                    return true;
                }
            }

            // Сам не знаю, навіщо я це написав, адже інший метод теж повинен правильно працювати
            //¯\_(ツ)_/¯

            return false;

        }

        static bool horseSimulator2(int x, int y)
        {
            if (x >= 1 && x <= 8)
            {
                if (y >= 1 && y <= 8)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть х - ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть y - ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (horseSimulator2(x,y) == true)
            {
                Console.WriteLine("Кінь може перейти");
            }
            else
            {
                Console.WriteLine("Кінь не може перейти");
            }

            Console.ReadLine();
        }

        
    }
}
