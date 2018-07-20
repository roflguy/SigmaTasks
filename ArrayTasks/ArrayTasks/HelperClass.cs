using System;
using static System.Console;
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

        static int VerifyUserIntInput()
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
            min_value = VerifyUserIntInput();
            WriteLine("Input max value of element(inclusive): ");
            max_value = VerifyUserIntInput();

            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = random.Next(min_value, max_value + 1);
            }
        }
    }
}
