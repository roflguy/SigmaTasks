using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace Helper
{
    public static class HelperClass
    {
        public static T[] UserCreateArray<T>()
        {
            int n = 0;
            WriteLine("Input quantity of elements: ");
            n = VerifyUserIntInput();
            T[] Array = new T[n];
            return Array;
        }

        public static T[] CreateArray<T>(int length)
        {
            T[] Array = new T[length];
            return Array;
        }

        public static int VerifyUserIntInput()
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

        public static void DisplayArray<T>(T[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                WriteLine("[{0}] {1}", i , Arr[i]);
            }
        }

        public static void DisplayArrayHorizontalWithoutIndexes<T>(T[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Write("{0} ",Arr[i]);
            }
        }

        public static void RandomIntFillArray(int[] Arr, int min_value, int max_value)
        {
            Random random = new Random();
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = random.Next(min_value, max_value+1);
            }
        }

        public static void UserRandomIntFillArray(int[] Arr)
        {
            Random random = new Random();
            int min_value = 0;
            int max_value = 0;

            WriteLine("Input min value of element(inclusive): ");
            min_value = VerifyUserIntInput();
            WriteLine("Input max value of element(inclusive): ");
            max_value = VerifyUserIntInput();

            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = random.Next(min_value, max_value + 1);
            }
        }

        public static T[] ConcatArrays<T>(params T[][] list)
        {
            var result = new T[list.Sum(a => a.Length)];
            int offset = 0;
            for (int x = 0; x < list.Length; x++)
            {
                list[x].CopyTo(result, offset);
                offset += list[x].Length;
            }
            return result;
        }
    }
}
