using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Изменение_исходного_массива
{
    public class Изменение_исходного_массива
    {
        public void Номера()
        {
            Console.WriteLine("Изменение исходного массива");
            Console.Write("Введите номер задания: ");
            byte a1 = 1; bool b1 = true;
            while (b1)
            {
                if (!byte.TryParse(Console.ReadLine(), out a1))
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                else if (a1 <= 0 || a1 > 10)
                    Console.Write("В дз всего 10 заданий, Введите номер задания еще раз ");
                else
                    b1 = false;
            }
            switch (a1)
            {
                case 1:
                    n1();
                    break;
                case 2:
                    n2();
                    break;
                case 3:
                    n3();
                    break;
                case 4:
                    n4();
                    break;
                case 5:
                    n5();
                    break;
                case 6:
                    n6();
                    break;
                case 7:
                    n7();
                    break;
                case 8:
                    n8();
                    break;
                case 9:
                    n9();
                    break;
                case 10:
                    n10();
                    break;/*
                default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;*/
            }
            void n1()
            {
                Console.Write("Введите кол-во элементов массива ");
                int a = 1; bool c = true;
                while (c)
                {
                    if (!int.TryParse(Console.ReadLine(), out a))
                        Console.Write("Ошибка! Введите кол-во элементов еще раз ");
                    else if (a <= 0)
                        Console.Write("Ошибка! Кол-во элементов массива не может быть неположительным ");
                    else if (a < 5)
                        Console.Write("Ошибка! При таком кол-ве элементов массива невозможно поменять 2-й и 5-й элементы местами\nВведите кол-во элементов еще раз ");
                    else
                        c = false;

                }
                double[] massiv = new double[a];
                Random random = new Random();
                Console.Write("Начальный массив: ");
                for (int i = 0; i < a; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 150 - 50, 3);
                    //massiv[i] = random.Next(-50, 100);
                }
                Console.WriteLine(string.Join("; ", massiv));
                Console.WriteLine("a) Поменяны местами 2-й и 5-й элементы: ");
                double hellp = massiv[1];
                massiv[1] = massiv[4];
                massiv[4] = hellp;
                Console.WriteLine(string.Join("; ", massiv));
                //=========================
                Console.WriteLine("Поменять местами m-й и n-й элементы массива");
                Console.Write("Введите число m ");
                int m = 1; byte outm = 0;
                while (outm == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out m))
                        Console.Write("Ошибка! Введите m еще раз ");
                    else if (m <= 0 || m > a)
                        Console.Write("Число m не может быть неположительным и больше, чем кол-во элементов\nВведите m еще раз ");
                    else
                        outm++;
                }
                Console.Write("Введите число n ");
                int n = 1; byte outn = 0;
                while (outn == 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out n))
                        Console.Write("Ошибка! Введите n еще раз ");
                    else if (n <= 0 || n > a)
                        Console.Write("Число n не может быть неположительным и больше, чем кол-во элементов\nВведите n еще раз ");
                    else
                        outn++;
                }
                double hellp1 = massiv[m - 1];
                massiv[m - 1] = massiv[n - 1];
                massiv[n - 1] = hellp1;
                Console.WriteLine($"б) Поменяны местами {m}-й и {n}-й элементы: " + string.Join("; ", massiv));
                //==============================
                int maxind = Array.FindIndex(massiv, f => f == massiv.Max());
                double hellp2 = massiv[2];
                massiv[2] = massiv[maxind];
                massiv[maxind] = hellp2;
                Console.WriteLine("в) 3 и макс элементы поменяны местами: " + string.Join("; ", massiv));
                //===============================
                int minind = Array.FindLastIndex(massiv, f => f == massiv.Min());
                double hellp3 = massiv[0];
                massiv[0] = massiv[minind];
                massiv[minind] = hellp3;
                Console.WriteLine("г) 1 и мин элементы поменяны местами: " + string.Join("; ", massiv));
            }
            void n2()
            {
                Console.Write("Введите кол-во элементов массива (должно быть четным!) ");
                int kolvoElenents = 0; bool outkolvoElements = true;
                while (outkolvoElements)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvoElenents))
                        Console.Write("Ошибка! Введите кол-во элементов массива еще раз ");
                    else if (kolvoElenents <= 0)
                        Console.Write("Кол-во элементов массива не может быть неположительным! Введите кол-во элементов массива еще раз ");
                    else if (kolvoElenents % 2 != 0)
                        Console.Write("Кол-во элементов массива ДОЛЖНО БЫТЬ ЧЕТНЫМ. Введите кол-во элементов массива еще раз ");
                    else
                        outkolvoElements = false;
                }
                //Console.WriteLine("Длин массива: " + kolvoElenents);
                double[] massiv = new double[kolvoElenents];
                Random random = new Random();
                for (int i = 0; i < kolvoElenents; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 101 - 50, 3);
                }
                Console.WriteLine("Первоначальный массив: " + string.Join("; ", massiv));
                //==========================
                double hellp;
                for (int i = 0; i < kolvoElenents / 2; i++)
                {
                    hellp = massiv[i];
                    massiv[i] = massiv[(kolvoElenents / 2) + i];
                    massiv[(kolvoElenents / 2) + i] = hellp;
                }
                Console.WriteLine("а) Поменяны местами половины массива: " + string.Join("; ", massiv));
                //==========================
                for (int i = 0; i < kolvoElenents; i += 2)
                {
                    hellp = massiv[i];
                    massiv[i] = massiv[i + 1];
                    massiv[i + 1] = hellp;
                }
                Console.WriteLine("б) Поменяны местами первый со вторым, третий с четвертым и т.д.: " + string.Join("; ", massiv));
                //==========================
                for (int i = 0; i < kolvoElenents / 2; i++)
                {
                    hellp = massiv[i];
                    massiv[i] = massiv[kolvoElenents - i - 1];
                    massiv[kolvoElenents - i - 1] = hellp;
                }
                Console.WriteLine("в) Поменяны местами первый с последним, второй с предпоследним и т.д.: " + string.Join("; ", massiv));
            }
            void n3()
            {
                double[] massiv = new double[20];
                Random random = new Random();
                for (int i = 0; i < 20; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 101 - 50, 3);
                }
                Console.WriteLine("Первоначальный массив: " + string.Join("; ", massiv));
                double hellp;
                for (int i = 0; i < 3; i++)
                {
                    hellp = massiv[i];
                    massiv[i] = massiv[20 - 3 + i];
                    massiv[20 - 3 + i] = hellp;
                }
                Console.WriteLine("Поменяны последние три элемента и первые три элемента: " + string.Join("; ", massiv));
            }
            void n4()
            {
                double[] massiv = new double[15], massiv1 = new double[8];
                Random random = new Random();
                for (int i = 0; i < 15; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 101 - 50, 3);
                }
                Console.WriteLine("Первоначальный массив: " + string.Join("; ", massiv));
                //==================================
                Array.ConstrainedCopy(massiv, 2, massiv1, 0, 8);
                Array.Reverse(massiv1);
                Array.ConstrainedCopy(massiv1, 0, massiv, 2, 8);
                Console.WriteLine("а) Поменяны элементы, расположенные м/у 2 и 10 элементами: " + string.Join("; ", massiv));
                //=======================================
                kipish();
                int k;
                void vvodk()
                {
                    bool outk;
                    k = 0;
                    outk = true;
                    Console.Write("Введите k ");
                    while (outk)
                    {
                        if (!int.TryParse(Console.ReadLine(), out k))
                            Console.Write("Ошибка! Введите k еще раз ");
                        else if (k <= 0 || k > 15)
                            Console.Write("k не может быть неположительным и больше длины массива (15)\nВведите k еще раз ");
                        else
                            outk = false;
                    }
                }
                int s;
                void vvods()
                {
                    bool outs;
                    s = 0;
                    outs = true;
                    string h;
                    Console.Write("Введите s ");
                    while (outs)
                    {
                        h = Console.ReadLine();
                        if (h.ToLower() == "повторить")
                            kipish();
                        else if (!int.TryParse(h, out s))
                            Console.Write("Ошибка! Введите s еще раз ");
                        else if (s <= 0 || s > 15)
                            Console.Write("s не может быть неположительным и больше длины массива (15)\nВведите s еще раз ");
                        else if (k >= s)
                            Console.Write($"s должно быть больше чем k ({k}), введите k еще раз или введите \"Повторить\", для того чтобы ввести k еще раз ");
                        else
                            outs = false;
                    }
                }
                void kipish()
                {
                    vvodk();
                    vvods();
                }
                double[] massiv2 = new double[s - k - 1];
                Array.ConstrainedCopy(massiv, k, massiv2, 0, s - k - 1);
                Array.Reverse(massiv2);
                Array.ConstrainedCopy(massiv2, 0, massiv, k, s - k - 1);
                Console.WriteLine($"б) Поменяны элементы, расположенные м/у {k} и {s} элементами: " + string.Join("; ", massiv));
                //Console.WriteLine("k: " + k + "\ns: " + s);
                //=====================================
                //massiv[0] = -60; massiv[1] = -60; massiv[4] = 60; massiv[8] = 60;
                int indexMin = 0, indexMax = 0;
                if (Array.FindAll(massiv, g => g == massiv.Min()).Length != 1)
                {
                    var kol = new List<int>();
                    for (int i = 0; i < massiv.Length; i++)
                    {
                        if (massiv[i] == massiv.Min())
                            kol.Add(i);
                    }
                    Console.WriteLine("В массиве несколько минимальных элементов их индексы: " + string.Join(", ", kol));
                    Console.Write($"Введите индекс мин элемента, который необходим ({string.Join(", ", kol)}) ");
                    bool outindexMin = true;
                    while (outindexMin)
                    {
                        if (!int.TryParse(Console.ReadLine(), out indexMin))
                            Console.Write("Ошибка! Введите индекс мин элемента, который необходим еще раз ");
                        else if (!kol.Contains(indexMin)) //нао отработку доделать, на ввод индексов
                            Console.Write($"Введенное значение не соответствует ни одному из нужных индексов\nВведите индекс мин элемента, который необходим ({string.Join(", ", kol)}) ");
                        else
                            outindexMin = false;
                    }
                }
                else
                    indexMin = Array.FindIndex(massiv, g => g == massiv.Min());
                if (Array.FindAll(massiv, g => g == massiv.Max()).Length != 1)
                {
                    var kol = new List<int>();
                    for (int i = 0; i < massiv.Length; i++)
                    {
                        if (massiv[i] == massiv.Max())
                            kol.Add(i);
                    }
                    Console.WriteLine("В массиве несколько максимальных элементов их индексы: " + string.Join(", ", kol));
                    Console.Write($"Введите индекс макс элемента, который необходим ({string.Join(", ", kol)}) ");
                    bool outindexMax = true;
                    while (outindexMax)
                    {
                        if (!int.TryParse(Console.ReadLine(), out indexMax))
                            Console.Write("Ошибка! Введите индекс макс элемента, который необходим еще раз ");
                        else if (!kol.Contains(indexMax))
                            Console.Write($"Введенное значение не соответствует ни одному из нужных индексов\nВведите индекс макс элемента, который необходим ({string.Join(", ", kol)}) ");
                        else
                            outindexMax = false;
                    }
                }
                else
                    indexMax = Array.FindIndex(massiv, g => g == massiv.Max());
                //Console.WriteLine("it's min: " + indexMin + "it's max: " + indexMax);
                if (indexMin < indexMax) //не могут быть равны т.к. элементов массива 15, а не 1
                {
                    double[] massiv3 = new double[indexMax - indexMin + 1];
                    Array.ConstrainedCopy(massiv, indexMin, massiv3, 0, indexMax - indexMin + 1);
                    //Console.WriteLine("Срез: " + string.Join("; ", massiv3));
                    Array.Reverse(massiv3);
                    Array.ConstrainedCopy(massiv3, 0, massiv, indexMin, indexMax - indexMin + 1);
                    Console.WriteLine("в) Поменяны элементы, расположенные м/у max и min элементами: " + string.Join("; ", massiv));
                }
                else
                {
                    double[] massiv3 = new double[indexMin - indexMax + 1];
                    Array.ConstrainedCopy(massiv, indexMax, massiv3, 0, indexMin - indexMax + 1);
                    //Console.WriteLine("Срез: " + string.Join("; ", massiv3));
                    Array.Reverse(massiv3);
                    Array.ConstrainedCopy(massiv3, 0, massiv, indexMax, indexMin - indexMax + 1);
                    Console.WriteLine("в) Поменяны элементы, расположенные м/у max и min элементами: " + string.Join("; ", massiv));
                }
            }
            void n5()
            {
                Console.Write("Введите кол-во элементов массива ");
                int kolvoElenents = 0; bool outkolvoElements = true;
                while (outkolvoElements)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvoElenents))
                        Console.Write("Ошибка! Введите кол-во элементов массива еще раз ");
                    else if (kolvoElenents <= 0)
                        Console.Write("Кол-во элементов массива не может быть неположительным! Введите кол-во элементов массива еще раз ");
                    else
                        outkolvoElements = false;
                }
                //Console.WriteLine("Длин массива: " + kolvoElenents);
                double[] massiv = new double[kolvoElenents];
                Random random = new Random();
                for (int i = 0; i < kolvoElenents; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 101 - 50, 3);
                }
                Console.WriteLine("Первоначальный массив: " + string.Join("; ", massiv));
                //======================
                int firstotr = Array.FindIndex(massiv, d => d < 0);
                int lastpol = Array.FindLastIndex(massiv, d => d > 0);
                if (Array.Find(massiv, f => f < 0) == 0)
                {
                    Console.WriteLine("В массиве нет отрицательных элементов ");
                    return;
                }
                if (Array.FindLast(massiv, g => g > 0) == 0)
                {
                    Console.WriteLine("в массиве нет положительных элементов ");
                    return;
                }
                double hellp = massiv[firstotr];
                massiv[firstotr] = massiv[lastpol];
                massiv[lastpol] = hellp;
                Console.WriteLine("Поменяны местами первый отрицательный и последний положительный элементы: " + string.Join("; ", massiv));
            }
            void n6()
            {
                Console.Write("Введите длину массива: ");
                byte outa = 0, a = 1;
                while (outa == 0)
                {
                    if (!byte.TryParse(Console.ReadLine(), out a))
                        Console.Write("оШИБКА, введите длину массива еще раз: ");
                    else if (a <= 0)
                        Console.Write("Длина массива не может быть неположительной\nВведите длину массива еще раз ");
                    else if (a < 3)
                        Console.Write("При такой длине массива невозможно удалить 3-й элемент\nВведите длину массива еще раз ");
                    else
                        outa++;
                }
                double[] massiv = new double[a];
                Random random = new Random();
                for (int i = 0; i < a; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 101 - 50, 3);
                }
                Console.WriteLine("Исходный массив: " + String.Join("; ", massiv));
                //=====================================
                const int tri = 3;
                double[] massiv1 = new double[a - tri + 1];
                Array.Copy(massiv, tri, massiv1, 0, a - tri);
                Array.Copy(massiv1, 0, massiv, tri - 1, massiv1.Length);
                Console.WriteLine("а) исключен 3-й элемент: " + String.Join("; ", massiv));
                //=======================================
                int k;
                vvodk();
                void vvodk()
                {
                    bool outk;
                    k = 0;
                    outk = true;
                    Console.Write("Введите k ");
                    while (outk)
                    {
                        if (!int.TryParse(Console.ReadLine(), out k))
                            Console.Write("Ошибка! Введите k еще раз ");
                        else if (k <= 0 || k > a)
                            Console.Write($"k не может быть неположительным и больше длины массива ({a})\nВведите k еще раз ");
                        else
                            outk = false;
                    }
                }
                double[] massiv2 = new double[a - k + 1];
                Array.Copy(massiv, k, massiv2, 0, a - k);
                Array.Copy(massiv2, 0, massiv, k - 1, massiv2.Length);
                Console.WriteLine($"б) исключен {k}-й элемент: " + String.Join("; ", massiv));
            }
            void n7()
            {
                const int a = 20;
                double[] massiv = new double[a];
                Random random = new Random();
                for (int i = 0; i < a; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 101, 3);
                }
                Console.WriteLine($"Исходная информация о стоимости {a} товаров: " + String.Join("; ", massiv));
                //=============================
                int n;
                vvodn();
                void vvodn()
                {
                    bool outn;
                    n = 0;
                    outn = true;
                    Console.Write("Введите n ");
                    while (outn)
                    {
                        if (!int.TryParse(Console.ReadLine(), out n))
                            Console.Write("Ошибка! Введите n еще раз ");
                        else if (n <= 0 || n > a)
                            Console.Write($"n не может быть неположительным и больше длины массива ({a})\nВведите n еще раз ");
                        else
                            outn = false;
                    }
                }
                double[] massiv2 = new double[a - n + 1];
                Array.Copy(massiv, n, massiv2, 0, a - n);
                Array.Copy(massiv2, 0, massiv, n - 1, massiv2.Length);
                Console.WriteLine($"Информация о стоимости остальных товаров: " + String.Join("; ", massiv));
            }
            void n8()
            {
                Console.Write("Введите кол-во элементов массива ");
                int kolvoElenents = 0; bool outkolvoElements = true;
                while (outkolvoElements)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvoElenents))
                        Console.Write("Ошибка! Введите кол-во элементов массива еще раз ");
                    else if (kolvoElenents <= 0)
                        Console.Write("Кол-во элементов массива не может быть неположительным! Введите кол-во элементов массива еще раз ");
                    else
                        outkolvoElements = false;
                }
                //Console.WriteLine("Длин массива: " + kolvoElenents);
                double[] massiv = new double[kolvoElenents];
                Random random = new Random();
                for (int i = 0; i < kolvoElenents; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 101 - 50, 3); //условие на различность прописать надо будет
                }
                Console.WriteLine("Первоначальный массив: " + string.Join("; ", massiv));
                //===============================
                {
                    int n = Array.IndexOf(massiv, massiv.Max()) + 1;
                    double[] massiv2 = new double[kolvoElenents - n + 1];
                    Array.Copy(massiv, n, massiv2, 0, kolvoElenents - n);
                    Array.Copy(massiv2, 0, massiv, n - 1, massiv2.Length);
                    Console.WriteLine($"a) Удален макс элемент: " + String.Join("; ", massiv));
                }
                //==========================================
                {
                    int n = Array.IndexOf(massiv, massiv.Min()) + 1;
                    double[] massiv2 = new double[kolvoElenents - n + 1];
                    Array.Copy(massiv, n, massiv2, 0, kolvoElenents - n);
                    Array.Copy(massiv2, 0, massiv, n - 1, massiv2.Length);
                    Console.WriteLine($"б) Удален мин элемент: " + String.Join("; ", massiv));
                }
            }
            void n9()
            {
                const int a = 25;
                double[] massiv = new double[a];
                Random random = new Random();
                for (int i = 0; i < a; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() *141 +60, 3);
                }
                Array.Sort(massiv);
                Console.WriteLine($"Исходная информация о росте {a} учеников: " + String.Join("; ", massiv));
                //===========================
                {
                    Console.Write("Введите порядковый номер выбывшего ученика ");
                    byte nom = 0; bool nomout = true;
                    while (nomout)
                    {
                        if (!byte.TryParse(Console.ReadLine(), out nom))
                            Console.Write("Ошибка! Введите порядковый номер выбывшего ученика еще раз ");
                        else if (nom <= 0 || nom > a)
                            Console.Write($"Порядковый номер ученика не может быть неположительным и больше {a}. Введите порядковый номер ученика еще раз ");
                        else
                            nomout = false;
                    }
                    massiv = Array.FindAll(massiv, h => (Array.IndexOf(massiv, h)) != nom - 1);
                    Console.WriteLine($"а) Информация о всех учениках, без учета выбывшего: " + string.Join("; ", massiv));
                }
                //========================================
                { 
                    Console.Write("Введите рост выбывшего ученика ");
                    double nom = 0; bool nomout = true;
                    while (nomout)
                    {
                        if (!double.TryParse(Console.ReadLine(), out nom))
                            Console.Write("Ошибка! Введите рост выбывшего ученика еще раз ");
                        else if (Array.Find(massiv, j => j == nom) is 0)
                            Console.Write($"Такого роста нет в списке. Введите рост ученика еще раз ");
                        else
                            nomout = false;
                    }
                    massiv = Array.FindAll(massiv, h => h != nom);
                    Console.WriteLine($"б) Информация о всех учениках, без учета выбывшего: " + string.Join("; ", massiv));
                }
            }
            void n10()
            {
                Console.Write("Введите кол-во элементов массива ");
                int kolvoelements = 0; bool outkolvoelements = true;
                while (outkolvoelements)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvoelements))
                        Console.Write("Ошибка! Введите кол-во элементов массива еще раз ");
                    else if (kolvoelements <= 0)
                        Console.Write("Кол-во элементов массива не может быть неположительным! Введите кол-во элементов массива еще раз ");
                    else
                        outkolvoelements = false;
                }
                Random random = new Random();
                double[] massiv = new double[kolvoelements];
                for (int i = 0; i < kolvoelements; i++)
                {
                    massiv[i] = Math.Round(random.NextDouble() * 201 - 100, 3);
                }
                Console.WriteLine("Первоначальный массив: "+string.Join("; ", massiv));
                //===============================
                {
                    if (massiv.Min() < 0)
                    {
                        massiv = Array.FindAll(massiv, g => g != Array.Find(massiv, k => k < 0));
                        Console.WriteLine("Массив без первого отрицательного элемента: " + string.Join("; ",massiv));
                    }
                    else
                        Console.WriteLine("В массиве нет отрицательных элементов");
                }
                //=====================================
                {
                    if (massiv.Max() > 0)
                    {
                        massiv = Array.FindAll(massiv, g => g != Array.Find(massiv, k => k > 0));
                        Console.WriteLine("Массив без первого положительного элемента: " + string.Join("; ", massiv));
                    }
                    else
                        Console.WriteLine("В массиве нет положительных элементов");
                }
            }
            //Изменение_исходного_массива.Изменение_исходного_массива ы = new Изменение_исходного_массива.Изменение_исходного_массива(); ы.Номера();
            Console.Write($"Для завершения программы нажмите Enter");
            Console.ReadLine();
        }
    }
}
