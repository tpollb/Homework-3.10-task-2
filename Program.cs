using System;
using System.Linq;

namespace Homework_3._10_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rules: Weight of Jack to Ace = 10 (j q k a), 2 to 10 = 2 to 10");

            Console.WriteLine("Enter number of cards");
            int CardNumber = int.Parse(Console.ReadLine());
            string Weight;
            int WeightInt;
            int i = 1;
            int result;

            //Console.WriteLine($"{CardNumber}"); контроль переменной

            int[] array = new int[CardNumber + 1];
            
            for (i = 1; i < (CardNumber + 1); i++) //помещаем веса в массив
            {
                Console.WriteLine("Enter weight:");
                Weight = Console.ReadLine();

                if (Weight == "j" || Weight == "q" || Weight == "k" || Weight == "a") {
                    WeightInt = 10;
                    array[i] = WeightInt;
                } else
                {
                    array[i] = Convert.ToInt32(Weight);
                }
            }
            /* контроль наличия данных в массиве
            for (i = 1; i < (CardNumber+ 1); i++) 
            {
                Console.Write($"{array[i]}");
            }
            */
            result = array.Sum();

            Console.WriteLine($"Weight is: {result}");
            
            Console.ReadKey();

        }
    }
}
