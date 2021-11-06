using System;

namespace oop_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даний масив цілих чисел розміру N. Видалити з масиву всі елементи, що зустрічаються 1) менше двох разів; 2) більше двох разів; 3) рівно двічі; 4) рівно тричі. 

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть розмір масиву - ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0, 20);
                Console.WriteLine("arr[" + i + "] = " + arr[i]);
            }

            Console.WriteLine();

            int temp, counter = 0, maxCount = 0, maxID = 0;
            int[] countArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                temp = arr[i];
                
                for (int j = 0; j < n; j++)
                {
                    if (temp == arr[j])
                    {
                        counter++;
                    }
                }
                countArr[i] = counter;
                counter = 0;
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (countArr[i] > countArr[i+1])
                {
                   
                    maxID = i;
                }
            }

            Console.WriteLine("Найбільше повторюється число " + arr[maxID] + "(" + countArr[maxID] + " разів)");
            

            
        }
    }
}
