using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Helper.HelperClass;
using static System.Console;

namespace ArrayTasks
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = CreateArray<int>(10);
            RandomIntFillArray(Arr, 0, 9);
            WriteLine("Array: \n");
            DisplayArray<int>(Arr);
            WriteLine();
            Write("Input task number:");
            WriteLine();
            int x = VerifyUserIntInput();
            switch (x)
            {
                case 1:
                    Task_4_1(Arr);
                    break;

                case 2:
                    Task_4_2(Arr);
                    break;
                default:
                    WriteLine("Task {0} is not implemented", x);
                    break;
            }

            ReadKey();
        }

        static void Task_4_1(int[] Array)
        {
            //4.1 Удалить в массиве все числа, которые повторяются более двух раз.
            //int[] NewArr = Array.Distinct().ToArray();

            int[] NewArr = Array.GroupBy(x => x).Where(g => g.Count() <= 2).Select(g => g.Key).ToArray();
            WriteLine("Array w/o double duplicates: \n");
            DisplayArray<int>(NewArr);
        }

        static void Task_4_2(int[] Array)
        {
            //4.2 Введите одномерный целочисленный массив. Найдите наибольший
            //нечетный элемент. Далее трижды осуществите циклический сдвиг влево
            //элементов, стоящих справа от найденного максимума, и один раз сдвиг
            //элементов вправо, стоящих слева от найденного максимума.
            //int odd_max_index = Array.Select((item, index) => new { Item = item, Index = index }).Where(x => x.Item % 2 != 0).Select(x =>x.Index).Max();
            //int odd_max_index = 0;
            //for (int i = 0; i < Array.Length; i++)
            //{
            //    if (Array[i] == odd_max)
            //    {
            //        odd_max_index = i;
            //    }
            //}
            int[] odd_max = { Array.Where(x => x % 2 != 0).Max() };
            int odd_max_index = Array.ToList().IndexOf(Array.Where(x => x % 2 != 0).Max());
            int[] rightArr = Array.Skip(odd_max_index + 1).ToArray();
            int[] leftArr = Array.Take(odd_max_index).ToArray();
            for (int i = 0; i < 3; i++)
            {
                arrayRotateLeft(rightArr);
            }
            arrayRotateRight(leftArr);
            //int[] resultArray = ConcatArrays(leftArr,odd_max,rightArr);
            int[] resultArray = new int[Array.Length];
            leftArr.CopyTo(resultArray, 0);
            odd_max.CopyTo(resultArray, leftArr.Length);
            rightArr.CopyTo(resultArray, leftArr.Length + 1);
            WriteLine("Max Odd number: {0}\n", odd_max[0]);
            DisplayArrayHorizontalWithoutIndexes<int>(resultArray);
        }

        static void arrayRotateRight(int[] array)
        {
            if (array.Length == 0)
            {
                return;
            }
            int size = array.Length;
            int temp = array[size - 1];
            while (size > 1)
            {
                array[size - 1] = array[size - 2];
                size--;
            }
            array[0] = temp;
        }

        static void arrayRotateLeft(int[] array)
        {
            if (array.Length == 0)
            {
                return;
            }
            int size = array.Length;
            int i, temp = array[0];
            for (i = 0, size--; i < size; i++)
            {
                array[i] = array[i + 1];
            }
            array[size] = temp;
        }
        static void Task_4_3()
        {
            //4.3 Найдите сумму отрицательных элементов массива.
        }

        static void Task_4_4()
        {
            //4.4 Найдите произведение элементов массива с нечетными номерами.
        }

        static void Task_4_5()
        {
            //4.5 Найдите сумму элементов массива между двумя первыми нулями.
            //Если двух нулей нет в массиве, то выведите ноль.
        }

        static void Task_4_6()
        {
            //4.6 Найдите наибольший элемент массива.
        }

        static void Task_4_7()
        {
            //4.7 Найдите наименьший четный элемент массива.Если такого нет, то
            //выведите первый элемент.
        }

        static void Task_4_8()
        {
            //4.8 Преобразовать массив так, чтобы сначала шли нулевые элементы, а
            //затем все остальные.
        }

        static void Task_4_9()
        {
            //4.9 Найдите сумму номеров минимального и максимального элементов.
        }

        static void Task_4_10()
        {
            //4.10 Найтиподмножество данного множества чисел такое, что сумма его
            //элементов равна заданному числу.
        }

        static void Task_4_11()
        {
            //4.11 Напишите программу бинарного поиска по ключу в массиве целых
            //чисел.
        }
    }
}
