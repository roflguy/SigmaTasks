using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Helper.HelperClass;
using static System.Console;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch bubbletime = new Stopwatch();
            int[] Unsorted;
            int[] Sorted;

            Unsorted = UserCreateArray<int>();
            UserRandomIntFillArray(Unsorted);
            WriteLine("Unsorted Array");
            DisplayArray<int>(Unsorted);
            Sorted = BubbleSort(Unsorted, bubbletime); ;
            AlgorithmExecutionTime<int>(bubbletime, Sorted);

        }

        public static int[] BubbleSort(int[] Arr, Stopwatch stopwatch)
        {
            WriteLine("Program running, wait pls");
            stopwatch.Start();
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 1; i < Arr.Length; i++)
                {
                    if (Arr[i - 1].CompareTo(Arr[i]) > 0)
                    {
                        Swap<int>(Arr, i - 1, i);
                        swapped = true;
                    }
                }
            }
            while (swapped != false);
            stopwatch.Stop();
            return Arr;
        }
    }
}
