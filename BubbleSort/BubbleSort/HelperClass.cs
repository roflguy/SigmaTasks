using static System.Console;
using System.Diagnostics;
using System;

namespace Helper
{
    public static class HelperClass
    {
        public static T[] UserCreateArray<T>()
        {
            int n = 0;
            WriteLine("Input quantity of elements: ");
            n = LegitIntInput();
            T[] Array = new T[n];
            return Array;
        }

        public static T[] CreateArray<T>(int length)
        {
            T[] Array = new T[length];
            return Array;
        }

        public static void DisplayArray<T>(T[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                WriteLine("[{0}] {1}", i + 1, Arr[i]);
            }
            WriteLine();
            WriteLine("Press Anykey to continue");
            WriteLine();
            ReadKey();
        }

        public static void RandomIntFillArray(int[] Arr, int min_value, int max_value)
        {
            Random random = new Random();
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = random.Next(min_value, max_value);
            }
        }

        public static void UserRandomIntFillArray(int[] Arr)
        {
            Random random = new Random();
            int min_value = 0;
            int max_value = 0;

            WriteLine("Input min value of element(inclusive): ");
            min_value = LegitIntInput();
            WriteLine("Input max value of element(inclusive): ");
            max_value = LegitIntInput();

            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = random.Next(min_value, max_value + 1);
            }
        }

        public static void Swap<T>(T[] items, int left, int right)
        {
            if (left != right)
            {
                T temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        public static void AlgorithmExecutionTime<T>(Stopwatch timer, T[] Arr)
        {
            TimeSpan ts = timer.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            WriteLine();
            WriteLine("Execution Time " + elapsedTime);
            WriteLine();
            WriteLine("Press Anykey to display sorted array");
            ReadKey();
            WriteLine();
            WriteLine("Sorted Array: ");
            WriteLine();
            DisplayArray<T>(Arr);
        }

        static int LegitIntInput()
        {
            int value;
            while (true)
            {
                if (int.TryParse(ReadLine(), out value))
                {
                    break;
                }
                else
                {
                    WriteLine("Invalid Input");
                }
            }

            return value;
        }
    }
}
