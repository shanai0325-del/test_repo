using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void BubbleSort(int[] array)
        {
            bool swapped;
            int n = array.Length;

            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        // Swap
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        swapped = true;
                    }
                }
                // After each pass, the largest element is at the end, so we can reduce n
                n--;
            } while (swapped);
        }

        static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;

        }

        private static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = new int[50];
            Random random = new Random();
            // Fill with random numbers between 0 and 99
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            Print(array);
            Console.WriteLine("Bubble Sort: ");
            BubbleSort(array);
            Print(array);

            Console.ReadLine();
        }
    }
}
