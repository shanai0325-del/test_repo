using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {

        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < n- i -1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            } 
        }

        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                Swap(ref array[i], ref array[min]);
            }
        }

        static void InsertionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i <= n - 1; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
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
            int[] array = new int[1000];
            Random random = new Random();
            // Fill with random numbers between 0 and 99
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(30);
            }

            // Reverse
            /*            for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = array.Length - i;
                        }*/

            // Sorted
            /*for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }*/


            int[] array2 = (int[]) array.Clone();
            int[] array3 = (int[]) array.Clone();
            
//            Print(array);
            Console.WriteLine("Bubble Sort: ");
            BubbleSort(array);
//            Print(array);
            Console.WriteLine("Selection Sort: ");
            SelectionSort(array2);
 //           Print(array2);
            Console.WriteLine("Insertion Sort: ");
            InsertionSort(array3);
 //           Print(array3);
            Console.ReadLine();
        }


    }
}
