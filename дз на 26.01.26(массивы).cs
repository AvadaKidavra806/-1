using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_19._01._26__обработка_массивов__Юшина_и_Ильенко
{
    internal class Program
    {
        static void Main()
        {
            /*№1
            int[] massiv = { 37, 0, 50, 46, 34, 46, 0, 13 };
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{massiv[i]}.");
                else
                    Console.Write($"{massiv[i]}, ");
            }*/
            //========================================================
            /*№2
            double[] massiv = new double [10];
            for (int i=0;i<massiv.Length;i++)
            {
                Console.Write($"Введите {i+1} элемент массива ");
                while (!double.TryParse(Console.ReadLine(), out massiv[i]))
                    Console.Write($"Ошибка! Введите {i+1} элемент массива еще раз ");
            }
            Console.Write("Получившийся массив: ");
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{massiv[i]}.");
                else
                    Console.Write($"{massiv[i]}, ");
            }*/
            //==================================================
            /*№3
            int a, b;
            Random s = new Random();
            Console.Write("Введите кол-во элементов ");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.Write("Ошибка!Введите кол-во элементов еще раз ");
            int[] massiv = new int[a];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = s.Next();
                    if (i == massiv.Length - 1)
                        Console.Write($"{massiv[i]}.");
                    else
                        Console.Write($"{massiv[i]}, ");
            }
            Console.Write("\nВведите индекс необходимого элемента ");
            while (!int.TryParse(Console.ReadLine(), out b) || !(b < a))
            {
                if (b >= a)
                    Console.Write("Ошибка! Индекс не может быть больше чем (кол-во элементов - 1)\nВведите индекс необходимого элемента еще раз ");
                else
                    Console.Write("Ошибка! Введите индекс необходимого элемента еще раз ");
            }
            Console.WriteLine($"Ваш элемент по индексу: {massiv[b]}");*/
            //==========================================
            /*№4
            Random s = new Random();
            int a;
            Console.Write("Введите кол-во элементов ");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.Write("Ошибка!Введите кол-во элементов еще раз ");
            int[] massiv = new int [a];
            for (int i=0; i< massiv.Length;i++)
            {
                massiv[i] = s.Next();
            }
            Console.Write("Исходный массив: ");
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{massiv[i]}.");
                else
                    Console.Write($"{massiv[i]}, ");
            }
            Array.Reverse(massiv);
            Console.Write("\nОбратный массив: ");
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{massiv[i]}.");
                else
                    Console.Write($"{massiv[i]}, ");
            }*/
            //=============================================
            /*№5*/
            Random s = new Random();
            double[] massiv = new double[15];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = s.NextDouble();
                //rnd.NextDouble() * (max - min) + min.
            }
            Console.Write("Массив от 0 до 1: ");
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{Math.Round(massiv[i],3)}.");
                else
                    Console.Write($"{Math.Round(massiv[i],3)}; ");
            }
            //=========================================
            for(int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = s.NextDouble() + 22;
            }
            Console.Write("\nМассив от 22 до 23: ");
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{Math.Round(massiv[i], 3)}.");
                else
                    Console.Write($"{Math.Round(massiv[i], 3)}; ");
            }
            //========================================
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = s.NextDouble() * 10;
            }
            Console.Write("\nМассив от 0 до 10: ");
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{Math.Round(massiv[i], 3)}.");
                else
                    Console.Write($"{Math.Round(massiv[i], 3)}; ");
            }
            //========================================
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = s.NextDouble() * 100 -50;
            }
            Console.Write("\nМассив от -50 до 50: ");
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{Math.Round(massiv[i], 3)}.");
                else
                    Console.Write($"{Math.Round(massiv[i], 3)}; ");
            }
            //========================================
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = s.Next(0, 11);
            }
            Console.Write("\nМассив от 0 до 10: ");
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{massiv[i]}.");
                else
                    Console.Write($"{massiv[i]}; ");
            }
            //rnd.NextDouble() * (max - min) + min.
            
            //=================================================
            /*№6
            Random s = new Random();
            int[] massiv = new int[12];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = s.Next(163,191);
            }
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{massiv[i]}.");
                else
                    Console.Write($"{massiv[i]}, ");
            }*/
            //===================================================
            /*№7
            Random s = new Random();
            int[] massiv = new int[20];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = s.Next(50, 101);
            }
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{massiv[i]}.");
                else
                    Console.Write($"{massiv[i]}, ");
            }*/
            //=====================================================
            /*8. Заполнить массив из двенадцати элементов так: 1 2... 12.
            Console.Write("Введите числа от 1 до 12 включительно, через пробел или запятую ");
            string s = Console.ReadLine();
            string[] chisla = s.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < chisla.Length; i++)
            {
                if (i != chisla.Length-1)
                    Console.Write($"{chisla[i]}, ");
                else
                    Console.Write($"{chisla[i]} ");
            }
            /*8.1
            int[] chisla = new int[12];
            Console.Write("Получившийся массив: ");
            for (int i = 0; i < chisla.Length; i++)
            {
                    chisla[i] = 1 + i;
                    if (i != chisla.Length - 1)
                    Console.Write($"{chisla[i]}, ");
                else
                    Console.Write($"{chisla[i]} ");
            }*/
            //=================================================
            /*№9
            //9. Заполнить массив из двадцати элементов так: 20 19 ... 1.
            int[] chisla1 = new int[20];
            Console.Write("\nПолучившийся массив: ");
            for (int i = 0; i < chisla1.Length; i++)
            {
                chisla1[i] = 20 - i;
                if (i != chisla1.Length - 1)
                    Console.Write($"{chisla1[i]}, ");
                else
                    Console.Write($"{chisla1[i]} ");
            }*/
            //========================================================
            /*№10
            int a;
            Random s = new Random();
            Console.Write("Введите кол-во элементов ");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.Write("Ошибка!Введите кол-во элементов еще раз ");
            int[] massiv = new int[a];
            Console.Write("Полученный массив: ");
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = s.Next(-100, 100);
                if (i == massiv.Length - 1)
                    Console.Write($"{massiv[i]}.");
                else
                    Console.Write($"{massiv[i]}, ");
            }
            Console.Write("\nОтсортированный массив: ");
            Array.Sort(massiv);
            Array.Reverse(massiv);
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{massiv[i]}.");
                else
                    Console.Write($"{massiv[i]}, ");
            }
            Array.Reverse( massiv );
            Console.Write("\nРеверс массив: ");
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i == massiv.Length - 1)
                    Console.Write($"{massiv[i]}.");
                else
                    Console.Write($"{massiv[i]}, ");
            }*/
            Console.ReadKey();
        }
    }
}
