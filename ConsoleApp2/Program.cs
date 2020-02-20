using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int GetMin(int[]numbers)
        { 
            int min = numbers[0];
            int min_index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    min_index = i;
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            Console.Write("Ведите число элментов массива:");
            string str_count = Console.ReadLine();
            int count = int.Parse(str_count);
            int[] numbers = new int[count];
            Random rnd = new Random();
            Console.WriteLine("Элементы массива:");
            for (int i = 0; i < numbers.Length; i++)
            {
                // numbers[i] = i; от меньшего к большему
                // numbers[i] = count - i; от большего к меньшему
                numbers[i] = rnd.Next(1000,123456);
               
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Min={0}", GetMin(numbers));
            
            int min1 = numbers.Min();
            int max1 = numbers.Max();
            double average = numbers.Average();
            int sum = numbers.Sum();
            Console.WriteLine("минимум =" + min1);
            Console.WriteLine("максимум =" + max1);
            Console.WriteLine("среднее =" + average);
            Console.WriteLine("сумма =" + sum);
            Console.ReadLine();
        }
    }
}
