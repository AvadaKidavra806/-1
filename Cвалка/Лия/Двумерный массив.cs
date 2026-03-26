using System;

//Dvumerny_massiv.Ghf Ghf = new Dvumerny_massiv.Ghf(); Ghf.Edf();
namespace Dvumerny_massiv
{
    public class Ghf
	{
        public void Edf()
        {
            Console.WriteLine("Двумерный массив");
            Console.Write("Введите номер задания: ");
            byte NomerZadaniy = 1; bool NomerZadaniyOut = true;
            while (NomerZadaniyOut)
            {
                if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy))
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                else if (NomerZadaniy <= 0 || NomerZadaniy > 21)
                    Console.Write("В дз всего 21 заданий, Введите номер задания еще раз ");
                else
                    NomerZadaniyOut = false;

            }
            switch (NomerZadaniy)
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
                    break;
                case 11:
                    n11();
                    break;
                case 12:
                    n12();
                    break;
                case 13:
                    n13();
                    break;
                case 14:
                    n14();
                    break;
                case 15:
                    n15();
                    break;
                case 16:
                    n16();
                    break;
                case 17:
                    n17();
                    break;
                case 18:
                    n18();
                    break;
                case 19:
                    n19();
                    break;
                case 20:
                    n20();  
                    break;
                case 21:
                    n21();
                    break;
                default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;
            }
            void n1()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("a) элемент расположенный в правом верхнем углу массива: " + nums[0, kolvostolb - 1]);
                Console.WriteLine("б) элемент расположенный в левом нижнем углу массива: " + nums[kolvostrok - 1, 0]);

            }
            void n2()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("a) элемент расположенный в правом нижнем углу массива: " + nums[kolvostrok - 1, kolvostolb - 1]);
                Console.WriteLine("б) элемент расположенный в левом верхнем углу массива: " + nums[0, 0]);
            }
            void n3()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                //===============================
                {
                    Console.Write("Введите номер элемента из второй строки, который необходимо вывести: ");
                    int t = 0; bool outt = true;
                    while (outt)
                    {
                        if (!int.TryParse(Console.ReadLine(), out t))
                            Console.Write("Ошибка! Введите номер элемента из 2-й строки еще раз ");
                        else if (t <= 0 || t > kolvostolb)
                            Console.Write($"Номер элемента не может быть неположительным и больше кол-ва стобцов в строке ({kolvostolb}.\nВведите номер элемента еше раз )");
                        else
                            outt = false;
                    }
                    Console.WriteLine($"a) элемент из второй строки, под номером {t}: " + nums[1, t - 1]);
                }
                //==========================
                {
                    Console.Write("Введите номер строки элемента, который необходимо вывести: ");
                    int t = 0; bool outt = true;
                    while (outt)
                    {
                        if (!int.TryParse(Console.ReadLine(), out t))
                            Console.Write("Ошибка! Введите номер строки еще раз ");
                        else if (t <= 0 || t > kolvostrok)
                            Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                        else
                            outt = false;
                    }
                    Console.Write("Введите номер столбца элемента, который необходимо вывести: ");
                    int x = 0; bool outx = true;
                    while (outx)
                    {
                        if (!int.TryParse(Console.ReadLine(), out x))
                            Console.Write("Ошибка! Введите номер столбца еще раз ");
                        else if (x <= 0 || x > kolvostolb)
                            Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                        else
                            outx = false;
                    }
                    Console.WriteLine("б) элемент, который необходимо вывести: " + nums[t - 1, x - 1]);
                }
            }
            void n4()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                //===============================
                {
                    Console.Write("Введите номер элемента из третьего столбца, который необходимо вывести: ");
                    int t = 0; bool outt = true;
                    while (outt)
                    {
                        if (!int.TryParse(Console.ReadLine(), out t))
                            Console.Write("Ошибка! Введите номер элемента из 3-его столбца еще раз ");
                        else if (t <= 0 || t > kolvostrok)
                            Console.Write($"Номер элемента не может быть неположительным и больше кол-ва строк в массиве ({kolvostrok}.\nВведите номер элемента еще раз )");
                        else
                            outt = false;
                    }
                    Console.WriteLine($"a) элемент из третьего столбца, под номером {t}: " + nums[t - 1, 2]);
                }
                //==========================
                {
                    Console.Write("Введите номер строки элемента, который необходимо вывести: ");
                    int t = 0; bool outt = true;
                    while (outt)
                    {
                        if (!int.TryParse(Console.ReadLine(), out t))
                            Console.Write("Ошибка! Введите номер строки еще раз ");
                        else if (t <= 0 || t > kolvostrok)
                            Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                        else
                            outt = false;
                    }
                    Console.Write("Введите номер столбца элемента, который необходимо вывести: ");
                    int x = 0; bool outx = true;
                    while (outx)
                    {
                        if (!int.TryParse(Console.ReadLine(), out x))
                            Console.Write("Ошибка! Введите номер столбца еще раз ");
                        else if (x <= 0 || t > kolvostolb)
                            Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                        else
                            outx = false;
                    }
                    Console.WriteLine("б) элемент, который необходимо вывести: " + nums[t - 1, x - 1]);
                }
            }
            void n5()
            {

                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                //===============================
                {
                    int[] nums1 = new int[kolvostolb];
                    for (int i = 0; i < kolvostolb; i++)
                    {
                        nums1[i] = nums[4, i];
                    }
                    Console.WriteLine($"a) элементы из пятой строки: " + String.Join(", ", nums1));
                }
                //==========================
                {
                    Console.Write("Введите s ");
                    int s = 0; bool outs = true;
                    while (outs)
                    {
                        if (!int.TryParse(Console.ReadLine(), out s))
                            Console.Write("Ошибка! Введите s еще раз ");
                        else if (s <= 0 || s > kolvostrok)
                            Console.Write("S должно быть неотрицательным и небольше кол-ва строк (" + kolvostrok + "). Введите s еще раз ");
                        else
                            outs = false;
                    }
                    int[] nums1 = new int[kolvostrok];
                    for (int i = 0; i < kolvostrok; i++)
                    {
                        nums1[i] = nums[i, s - 1];
                    }
                    Console.WriteLine($"б) элементы из s-ого столбца: " + String.Join(", ", nums1));
                }

            }
            void n6()

            {

                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                {
                    int[] nums1 = new int[kolvostrok];
                    for (int i = 0; i < kolvostrok; i++)
                    {
                        nums1[i] = nums[i, 1];
                    }
                    Console.WriteLine($"a) элементы из второго столбца: " + String.Join(", ", nums1));
                }
                //==========================
                {
                    Console.Write("Введите m ");
                    int s = 0; bool outs = true;
                    while (outs)
                    {
                        if (!int.TryParse(Console.ReadLine(), out s))
                            Console.Write("Ошибка! Введите m еще раз ");
                        else if (s <= 0 || s > kolvostrok)
                            Console.Write("m должно быть неотрицательным и небольше кол-ва строк (" + kolvostrok + "). Введите m еще раз ");
                        else
                            outs = false;
                    }
                    int[] nums1 = new int[kolvostolb];
                    for (int i = 0; i < kolvostolb; i++)
                    {
                        nums1[i] = nums[s - 1, i];
                    }
                    Console.WriteLine($"б) элементы из m строки: " + String.Join(", ", nums1));
                }

            }
            void n7()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (kolvostrok < 5)
                        Console.Write("При таком кол-ве строк не получается выполнить замену в 5-й строке. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                Console.Write("Введите номер элемента 5-й сроки, который необходимо заменить числом 1949 ");
                int nomereleventa = 0; bool outnomerelementa = true;
                while (outnomerelementa)
                {
                    if (!int.TryParse(Console.ReadLine(), out nomereleventa))
                        Console.Write("Ошибка! Введите номер элемента еще раз ");
                    else if (nomereleventa <= 0 || nomereleventa > kolvostolb)
                        Console.Write($"Номер элемента не может быть неположительным и больше кол-ва столбцов ({kolvostolb}).Введите номер элемента еще раз ");
                    else 
                        outnomerelementa = false;
                }
                nums[4, nomereleventa - 1] = 1949;
                Console.WriteLine("a) изменненый двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                {
                    Console.Write("Введите номер строки элемента, который необходимо заменить: ");
                    int t = 0; bool outt = true;
                    while (outt)
                    {
                        if (!int.TryParse(Console.ReadLine(), out t))
                            Console.Write("Ошибка! Введите номер строки еще раз ");
                        else if (t <= 0 || t > kolvostrok)
                            Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                        else
                            outt = false;
                    }
                    Console.Write("Введите номер столбца элемента, который необходимо заменить: ");
                    int x = 0; bool outx = true;
                    while (outx)
                    {
                        if (!int.TryParse(Console.ReadLine(), out x))
                            Console.Write("Ошибка! Введите номер столбца еще раз ");
                        else if (x <= 0 || t > kolvostolb)
                            Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                        else
                            outx = false;
                    }
                    Console.Write("Введите а (целочисленным должно быть) ");
                    int a = 0; bool outa = true;
                    while (outa)
                    {
                        if (!int.TryParse(Console.ReadLine(), out a))
                            Console.Write("Ошибка! Введите а еще раз ");
                        else 
                            outa = false;
                    }
                    nums[t - 1, x - 1] = a;
                    Console.WriteLine( "б) изменненый двумерный массив: ");
                    for (int i = 0; i < kolvostrok; i++)
                    {
                        for (int j = 0; j < kolvostolb; j++)
                        {
                            Console.Write(nums[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
            void n8()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (kolvostrok < 5)
                        Console.Write("При таком кол-ве строк не получается выполнить замену в 5-й строке. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                Console.Write("Введите номер элемента 2-ого столбца, который необходимо заменить числом 13 ");
                int nomereleventa = 0; bool outnomerelementa = true;
                while (outnomerelementa)
                {
                    if (!int.TryParse(Console.ReadLine(), out nomereleventa))
                        Console.Write("Ошибка! Введите номер элемента еще раз ");
                    else if (nomereleventa <= 0 || nomereleventa > kolvostrok)
                        Console.Write($"Номер элемента не может быть неположительным и больше кол-ва строк ({kolvostrok}).Введите номер элемента еще раз ");
                    else
                        outnomerelementa = false;
                }
                nums[nomereleventa - 1, 1] = 13;
                Console.WriteLine("a) изменненый двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                {
                    Console.Write("Введите номер строки элемента, который необходимо заменить: ");
                    int t = 0; bool outt = true;
                    while (outt)
                    {
                        if (!int.TryParse(Console.ReadLine(), out t))
                            Console.Write("Ошибка! Введите номер строки еще раз ");
                        else if (t <= 0 || t > kolvostrok)
                            Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                        else
                            outt = false;
                    }
                    Console.Write("Введите номер столбца элемента, который необходимо заменить: ");
                    int x = 0; bool outx = true;
                    while (outx)
                    {
                        if (!int.TryParse(Console.ReadLine(), out x))
                            Console.Write("Ошибка! Введите номер столбца еще раз ");
                        else if (x <= 0 || x > kolvostolb)
                            Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                        else
                            outx = false;
                    }
                    Console.Write("Введите b (целочисленным должно быть) ");
                    int a = 0; bool outa = true;
                    while (outa)
                    {
                        if (!int.TryParse(Console.ReadLine(), out a))
                            Console.Write("Ошибка! Введите b еще раз ");
                        else
                            outa = false;
                    }
                    nums[t - 1, x - 1] = a;
                    Console.WriteLine("б) изменненый двумерный массив: ");
                    for (int i = 0; i < kolvostrok; i++)
                    {
                        for (int j = 0; j < kolvostolb; j++)
                        {
                            Console.Write(nums[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
            void n9()

            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                int hellp = nums[0, 0];
                nums[0, 0] = nums[kolvostrok - 1, kolvostolb - 1];
                nums[kolvostrok - 1, kolvostolb - 1] = hellp;
                Console.WriteLine("Изменненый двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        Console.Write(nums[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            void n10()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                {
                    int t = 0; int t1 = 0; int x = 0; int x1 = 0;
                    {
                        Console.Write("Введите номер строки элемента, который необходимо заменить: ");
                        bool outt = true;
                        while (outt)
                        {
                            if (!int.TryParse(Console.ReadLine(), out t))
                                Console.Write("Ошибка! Введите номер строки еще раз ");
                            else if (t <= 0 || t > kolvostrok)
                                Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                            else
                                outt = false;
                        }
                        Console.Write("Введите номер столбца элемента, который необходимо заменить: ");
                        bool outx = true;
                        while (outx)
                        {
                            if (!int.TryParse(Console.ReadLine(), out x))
                                Console.Write("Ошибка! Введите номер столбца еще раз ");
                            else if (x <= 0 || x > kolvostolb)
                                Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                            else
                                outx = false;
                        }
                    }
                    //================
                    {
                        Console.Write("Введите номер строки элемента, который необходимо заменить: ");
                        bool outt1 = true;
                        while (outt1)
                        {
                            if (!int.TryParse(Console.ReadLine(), out t1))
                                Console.Write("Ошибка! Введите номер строки еще раз ");
                            else if (t1 <= 0 || t1 > kolvostrok)
                                Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                            else
                                outt1 = false;
                        }
                        Console.Write("Введите номер столбца элемента, который необходимо заменить: ");
                        bool outx1 = true;
                        while (outx1)
                        {
                            if (!int.TryParse(Console.ReadLine(), out x1))
                                Console.Write("Ошибка! Введите номер столбца еще раз ");
                            else if (x1 <= 0 || x1 > kolvostolb)
                                Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                            else
                                outx1 = false;
                        }
                    }
                    int hellp = nums[t - 1, x - 1];
                    nums[t - 1, x - 1] = nums[t1 - 1, x1 - 1];
                    nums[t1 - 1, x1 - 1] = hellp;
                    Console.WriteLine("Изменненый двумерный массив: ");
                    for (int i = 0; i < kolvostrok; i++)
                    {
                        for (int j = 0; j < kolvostolb; j++)
                        {
                            Console.Write(nums[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
            void n11()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //======================
                Console.WriteLine($"Cумма элементов расположенных в левом верхнем и правом нижнем углах равна: " + (nums[0, 0] + nums[kolvostrok - 1, kolvostolb - 1]));
                //====================
                Console.WriteLine($"Среднее арифметическое элементов расположенных во всех углах равна: " + ((nums[0, 0] + nums[kolvostrok - 1, kolvostolb - 1] + nums[0, kolvostolb - 1] + nums[kolvostrok - 1, 0]) / 4.0));
            }
            void n12()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //======================
                Console.WriteLine($"Cумма элементов расположенных в правом верхнем и левом нижнем углах равна: " + (nums[kolvostrok - 1, 0] + nums[0, kolvostolb - 1]));
                //====================
                Console.WriteLine($"Среднее геометрическое элементов расположенных во всех углах равна: " + (Math.Pow(nums[0, 0] * nums[kolvostrok - 1, kolvostolb - 1] * nums[0, kolvostolb - 1] * nums[kolvostrok - 1, 0], 1.0 / 4.0)));
            }
            void n13()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                {
                    int t = 0; int x = 0;
                    {
                        Console.Write("Введите номер строки 1 элемента 3 столбца, который необходим для суммы: ");
                        bool outt = true;
                        while (outt)
                        {
                            if (!int.TryParse(Console.ReadLine(), out t))
                                Console.Write("Ошибка! Введите номер строки еще раз ");
                            else if (t <= 0 || t > kolvostrok)
                                Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                            else
                                outt = false;
                        }
                        Console.Write("Введите номер строки 2 элемента 3 столбца, который необходим для суммы: ");
                        bool outx = true;
                        while (outx)
                        {
                            if (!int.TryParse(Console.ReadLine(), out x))
                                Console.Write("Ошибка! Введите номер строки еще раз ");
                            else if (x <= 0 || x > kolvostrok)
                                Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                            else
                                outx = false;
                        }
                        Console.WriteLine("a) Сумма двух элементов массива 3 столбца равна: " + (nums[t - 1, 2] + nums[x - 1, 2]));
                    }
                    //================
                    {
                        Console.Write("Введите номер столбца 1 элемента 2 строки, который необходим для произведения: ");
                        bool outx = true;
                        while (outx)
                        {
                            if (!int.TryParse(Console.ReadLine(), out x))
                                Console.Write("Ошибка! Введите номер столбца еще раз ");
                            else if (x <= 0 || x > kolvostolb)
                                Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                            else
                                outx = false;
                        }
                        Console.Write("Введите номер столбца 2 элемента 2 строки, который необходим для произведения: ");
                        bool outt = true;
                        while (outt)
                        {
                            if (!int.TryParse(Console.ReadLine(), out t))
                                Console.Write("Ошибка! Введите номер столбца еще раз ");
                            else if (t <= 0 || t > kolvostolb)
                                Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                            else
                                outt = false;
                        }
                        Console.WriteLine("б) Произведение двух элементов массива 2 строки равна: " + (nums[1, x - 1] * nums[1, t - 1]));
                    }

                }
            }
            void n14()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                {
                    int t = 0; int x = 0;
                    {
                        Console.Write("Введите номер столбца 1 элемента 2 строки, который необходим для суммы: ");
                        bool outx = true;
                        while (outx)
                        {
                            if (!int.TryParse(Console.ReadLine(), out x))
                                Console.Write("Ошибка! Введите номер столбца еще раз ");
                            else if (x <= 0 || x > kolvostolb)
                                Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                            else
                                outx = false;
                        }
                        Console.Write("Введите номер столбца 2 элемента 2 строки, который необходим для суммы: ");
                        bool outt = true;
                        while (outt)
                        {
                            if (!int.TryParse(Console.ReadLine(), out t))
                                Console.Write("Ошибка! Введите номер столбца еще раз ");
                            else if (t <= 0 || t > kolvostolb)
                                Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                            else
                                outt = false;
                        }
                        Console.WriteLine("а) Сумма двух элементов массива 2 строки равна: " + (nums[1, x - 1] + nums[1, t - 1]));
                    }
                    //=================================
                    {
                        Console.Write("Введите номер строки 1 элемента 5 столбца, который необходим для произведения: ");
                        bool outt = true;
                        while (outt)
                        {
                            if (!int.TryParse(Console.ReadLine(), out t))
                                Console.Write("Ошибка! Введите номер строки еще раз ");
                            else if (t <= 0 || t > kolvostrok)
                                Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                            else
                                outt = false;
                        }
                        Console.Write("Введите номер строки 2 элемента 5 столбца, который необходим для произведения: ");
                        bool outx = true;
                        while (outx)
                        {
                            if (!int.TryParse(Console.ReadLine(), out x))
                                Console.Write("Ошибка! Введите номер строки еще раз ");
                            else if (x <= 0 || x > kolvostrok)
                                Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                            else
                                outx = false;
                        }
                        Console.WriteLine("б) Произведение двух элементов массива 3 столбца равна: " + (nums[t - 1, 4] * nums[x - 1, 4]));
                    }
                }
            }
            void n15()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                {
                    {
                        int t = 0; int t1 = 0; int x = 0; int x1 = 0;
                        {
                            Console.Write("Введите номер строки элемента, который необходим для суммы: ");
                            bool outt = true;
                            while (outt)
                            {
                                if (!int.TryParse(Console.ReadLine(), out t))
                                    Console.Write("Ошибка! Введите номер строки еще раз ");
                                else if (t <= 0 || t > kolvostrok)
                                    Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                                else
                                    outt = false;
                            }
                            Console.Write("Введите номер столбца элемента, который необходим для суммы: ");
                            bool outx = true;
                            while (outx)
                            {
                                if (!int.TryParse(Console.ReadLine(), out x))
                                    Console.Write("Ошибка! Введите номер столбца еще раз ");
                                else if (x <= 0 || x > kolvostolb)
                                    Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                                else
                                    outx = false;
                            }
                        }
                        //================
                        {
                            Console.Write("Введите номер строки элемента, который необходим для суммы: ");
                            bool outt1 = true;
                            while (outt1)
                            {
                                if (!int.TryParse(Console.ReadLine(), out t1))
                                    Console.Write("Ошибка! Введите номер строки еще раз ");
                                else if (t1 <= 0 || t1 > kolvostrok)
                                    Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                                else
                                    outt1 = false;
                            }
                            Console.Write("Введите номер столбца элемента, который необходим для суммы: ");
                            bool outx1 = true;
                            while (outx1)
                            {
                                if (!int.TryParse(Console.ReadLine(), out x1))
                                    Console.Write("Ошибка! Введите номер столбца еще раз ");
                                else if (x1 <= 0 || x1 > kolvostolb)
                                    Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                                else
                                    outx1 = false;
                            }
                        }
                        //Console.WriteLine(massiv[t - 1, x - 1] + " "+ massiv[t1 - 1, x1 - 1]);
                        Console.WriteLine("а) Сумма двух элементов массива равна: " + (nums[t - 1, x - 1] + nums[t1 - 1, x1 - 1]));
                    }
                //============================
                    {
                        {
                            int t = 0; int t1 = 0; int x = 0; int x1 = 0; int t2 = 0; int x2 = 0;
                            {
                                Console.Write("Введите номер строки элемента, который необходим для суммы: ");
                                bool outt = true;
                                while (outt)
                                {
                                    if (!int.TryParse(Console.ReadLine(), out t))
                                        Console.Write("Ошибка! Введите номер строки еще раз ");
                                    else if (t <= 0 || t > kolvostrok)
                                        Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                                    else
                                        outt = false;
                                }
                                Console.Write("Введите номер столбца элемента, который необходим для суммы: ");
                                bool outx = true;
                                while (outx)
                                {
                                    if (!int.TryParse(Console.ReadLine(), out x))
                                        Console.Write("Ошибка! Введите номер столбца еще раз ");
                                    else if (x <= 0 || x > kolvostolb)
                                        Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                                    else
                                        outx = false;
                                }
                            }
                            //================
                            {
                                Console.Write("Введите номер строки элемента, который необходим для суммы: ");
                                bool outt1 = true;
                                while (outt1)
                                {
                                    if (!int.TryParse(Console.ReadLine(), out t1))
                                        Console.Write("Ошибка! Введите номер строки еще раз ");
                                    else if (t1 <= 0 || t1 > kolvostrok)
                                        Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                                    else
                                        outt1 = false;
                                }
                                Console.Write("Введите номер столбца элемента, который необходим для суммы: ");
                                bool outx1 = true;
                                while (outx1)
                                {
                                    if (!int.TryParse(Console.ReadLine(), out x1))
                                        Console.Write("Ошибка! Введите номер столбца еще раз ");
                                    else if (x1 <= 0 || x1 > kolvostolb)
                                        Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                                    else
                                        outx1 = false;
                                }
                            }
                            //[====================
                            {
                                Console.Write("Введите номер строки элемента, который необходим для суммы: ");
                                bool outt2 = true;
                                while (outt2)
                                {
                                    if (!int.TryParse(Console.ReadLine(), out t2))
                                        Console.Write("Ошибка! Введите номер строки еще раз ");
                                    else if (t2 <= 0 || t2 > kolvostrok)
                                        Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                                    else
                                        outt2 = false;
                                }
                                Console.Write("Введите номер столбца элемента, который необходим для суммы: ");
                                bool outx2 = true;
                                while (outx2)
                                {
                                    if (!int.TryParse(Console.ReadLine(), out x2))
                                        Console.Write("Ошибка! Введите номер столбца еще раз ");
                                    else if (x2 <= 0 || x2 > kolvostolb)
                                        Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                                    else
                                        outx2 = false;
                                }
                            }
                            //Console.WriteLine(massiv[t - 1, x - 1] + " "+ massiv[t1 - 1, x1 - 1]);
                            Console.WriteLine("б) Среднее арифметическое трёх элементов массива равно: " + ((nums[t - 1, x - 1] + nums[t1 - 1, x1 - 1] + nums[t2 - 1, x2 - 1]) / 3.0));
                        }
                    }
                }
            }
            void n16()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                {
                    {
                        int t = 0; int t1 = 0; int x = 0; int x1 = 0;
                        {
                            Console.Write("Введите номер строки элемента, который необходим для разности: ");
                            bool outt = true;
                            while (outt)
                            {
                                if (!int.TryParse(Console.ReadLine(), out t))
                                    Console.Write("Ошибка! Введите номер строки еще раз ");
                                else if (t <= 0 || t > kolvostrok)
                                    Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                                else
                                    outt = false;
                            }
                            Console.Write("Введите номер столбца элемента, который необходим для разности: ");
                            bool outx = true;
                            while (outx)
                            {
                                if (!int.TryParse(Console.ReadLine(), out x))
                                    Console.Write("Ошибка! Введите номер столбца еще раз ");
                                else if (x <= 0 || x > kolvostolb)
                                    Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                                else
                                    outx = false;
                            }
                        }
                        //================
                        {
                            Console.Write("Введите номер строки элемента, который необходим для разности: ");
                            bool outt1 = true;
                            while (outt1)
                            {
                                if (!int.TryParse(Console.ReadLine(), out t1))
                                    Console.Write("Ошибка! Введите номер строки еще раз ");
                                else if (t1 <= 0 || t1 > kolvostrok)
                                    Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                                else
                                    outt1 = false;
                            }
                            Console.Write("Введите номер столбца элемента, который необходим для разности: ");
                            bool outx1 = true;
                            while (outx1)
                            {
                                if (!int.TryParse(Console.ReadLine(), out x1))
                                    Console.Write("Ошибка! Введите номер столбца еще раз ");
                                else if (x1 <= 0 || x1 > kolvostolb)
                                    Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                                else
                                    outx1 = false;
                            }
                        }
                        //Console.WriteLine(massiv[t - 1, x - 1] + " "+ massiv[t1 - 1, x1 - 1]);
                        Console.WriteLine("а) Разность двух элементов массива равна: " + (nums[t - 1, x - 1] - nums[t1 - 1, x1 - 1]));
                    }
                    //============================
                    {
                        {
                            int t = 0; int t1 = 0; int x = 0; int x1 = 0;
                            {
                                Console.Write("Введите номер строки элемента, который необходим для среднего геометрического: ");
                                bool outt = true;
                                while (outt)
                                {
                                    if (!int.TryParse(Console.ReadLine(), out t))
                                        Console.Write("Ошибка! Введите номер строки еще раз ");
                                    else if (t <= 0 || t > kolvostrok)
                                        Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                                    else
                                        outt = false;
                                }
                                Console.Write("Введите номер столбца элемента, который необходим для среднего геометрического: ");
                                bool outx = true;
                                while (outx)
                                {
                                    if (!int.TryParse(Console.ReadLine(), out x))
                                        Console.Write("Ошибка! Введите номер столбца еще раз ");
                                    else if (x <= 0 || x > kolvostolb)
                                        Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                                    else
                                        outx = false;
                                }
                            }
                            //================
                            {
                                Console.Write("Введите номер строки элемента, который необходим для среднего геометрического: ");
                                bool outt1 = true;
                                while (outt1)
                                {
                                    if (!int.TryParse(Console.ReadLine(), out t1))
                                        Console.Write("Ошибка! Введите номер строки еще раз ");
                                    else if (t1 <= 0 || t1 > kolvostrok)
                                        Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                                    else
                                        outt1 = false;
                                }
                                Console.Write("Введите номер столбца элемента, который необходим для среднего геометрического: ");
                                bool outx1 = true;
                                while (outx1)
                                {
                                    if (!int.TryParse(Console.ReadLine(), out x1))
                                        Console.Write("Ошибка! Введите номер столбца еще раз ");
                                    else if (x1 <= 0 || x1 > kolvostolb)
                                        Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                                    else
                                        outx1 = false;
                                }
                            }
                            //[====================
                            //Console.WriteLine(massiv[t - 1, x - 1] + " "+ massiv[t1 - 1, x1 - 1]);
                            Console.WriteLine("б) Среднее геометрическое двух элементов массива равно: " + (Math.Pow(nums[t - 1, x - 1] * nums[t1 - 1, x1 - 1], 1.0 / 2.0)));
                        }
                    }
                }
            }
            void n17()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        massiv[i, j] = rnd.Next(100);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //==========================
                string s, s1;
                if (massiv[kolvostrok - 1, kolvostolb - 1] > massiv[kolvostrok - 1, 0])
                    s = "больше";
                else
                    s = "меньше";
                if (massiv[0, kolvostolb - 1] > massiv[kolvostrok - 1, 0])
                    s1 = "больше";
                else
                    s1 = "меньше";
                Console.WriteLine($"а) элемент расположенный в правом нижнем углу массива ({massiv[kolvostrok - 1, kolvostolb - 1]}) {s}, чем в левом нижнем ({massiv[kolvostrok - 1, 0]})");
                Console.WriteLine($"б) элемент расположенный в правом верхнем углу массива ({massiv[0, kolvostolb - 1]}) {s1}, чем в левом нижнем ({massiv[kolvostrok - 1, 0]})");
            }
            void n18()

            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        massiv[i, j] = rnd.Next(100);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //==========================
                string s, s1;
                if (massiv[0, 0] > massiv[0, kolvostolb - 1])
                    s = "больше";
                else
                    s = "меньше";
                if (massiv[kolvostrok - 1, kolvostolb - 1] > massiv[0, 0])
                    s1 = "больше";
                else
                    s1 = "меньше";
                Console.WriteLine($"а) элемент расположенный в левом верхнем углу массива ({massiv[0, 0]}) {s}, чем в правом верхнем ({massiv[0, kolvostolb - 1]})");
                Console.WriteLine($"б) элемент расположенный в правом нижнем углу массива ({massiv[kolvostrok - 1, kolvostolb - 1]}) {s1}, чем в левом верхнем ({massiv[0, 0]})");
            }
            void n19()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(-100, 100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                {
                    int t = 0; int x = 0;
                    {
                        Console.Write("Введите номер строки элемента: ");
                        bool outt = true;
                        while (outt)
                        {
                            if (!int.TryParse(Console.ReadLine(), out t))
                                Console.Write("Ошибка! Введите номер строки еще раз ");
                            else if (t <= 0 || t > kolvostrok)
                                Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                            else
                                outt = false;
                        }
                        Console.Write("Введите номер столбца элемента: ");
                        bool outx = true;
                        while (outx)
                        {
                            if (!int.TryParse(Console.ReadLine(), out x))
                                Console.Write("Ошибка! Введите номер столбца еще раз ");
                            else if (x <= 0 || x > kolvostolb)
                                Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                            else
                                outx = false;
                        }
                    }
                    if (Math.Abs(nums[0, kolvostolb - 1]) > Math.Abs(nums[t - 1, x - 1]))
                        Console.WriteLine($"a) абсолютная величина элемента, расположенного в верхнем правом углу ({nums[0, kolvostolb - 1]}) больше, чем  абсолютная величина элемента, выбранного пользователем ({nums[t - 1, x - 1]})");
                    else if (Math.Abs(nums[0, kolvostolb - 1]) < Math.Abs(nums[t - 1, x - 1]))
                        Console.WriteLine($"a) абсолютная величина элемента, расположенного в верхнем правом углу ({nums[0, kolvostolb - 1]}) меньше, чем  абсолютная величина элемента, выбранного пользователем ({nums[t - 1, x - 1]})");
                    else
                        Console.WriteLine($"a) абсолютная величина элемента, расположенного в верхнем правом углу ({nums[0, kolvostolb - 1]}) равна абсолютной величине элемента, выбранного пользователем ({nums[t - 1, x - 1]})");
                }
                //================================
                {
                    int t = 0; int t1 = 0; int x = 0; int x1 = 0;
                    {
                        Console.Write("Введите номер строки 1 элемента: ");
                        bool outt = true;
                        while (outt)
                        {
                            if (!int.TryParse(Console.ReadLine(), out t))
                                Console.Write("Ошибка! Введите номер строки еще раз ");
                            else if (t <= 0 || t > kolvostrok)
                                Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                            else
                                outt = false;
                        }
                        Console.Write("Введите номер столбца 1 элемента: ");
                        bool outx = true;
                        while (outx)
                        {
                            if (!int.TryParse(Console.ReadLine(), out x))
                                Console.Write("Ошибка! Введите номер столбца еще раз ");
                            else if (x <= 0 || x > kolvostolb)
                                Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                            else
                                outx = false;
                        }
                    }
                    //================
                    {
                        Console.Write("Введите номер строки 2 элемента: ");
                        bool outt1 = true;
                        while (outt1)
                        {
                            if (!int.TryParse(Console.ReadLine(), out t1))
                                Console.Write("Ошибка! Введите номер строки еще раз ");
                            else if (t1 <= 0 || t1 > kolvostrok)
                                Console.Write($"Номер строки не может быть неположительным и больше кол-ва  строк в массиве ({kolvostrok})\nВведите номер строки еще раз ");
                            else
                                outt1 = false;
                        }
                        Console.Write("Введите номер столбца 2 элемента: ");
                        bool outx1 = true;
                        while (outx1)
                        {
                            if (!int.TryParse(Console.ReadLine(), out x1))
                                Console.Write("Ошибка! Введите номер столбца еще раз ");
                            else if (x1 <= 0 || x1 > kolvostolb)
                                Console.Write($"Номер столбца не может быть неположительным и больше кол-ва  столбов в массиве ({kolvostolb})\nВведите номер столбца еще раз ");
                            else
                                outx1 = false;
                        }
                    }
                    if (Math.Abs(nums[t - 1, x - 1]) > Math.Abs(nums[t1 - 1, x1 - 1]))
                        Console.WriteLine($"б) абсолютная величина 1 элемента ({nums[t - 1, x - 1]}) больше, чем  абсолютная величина 2 элемента ({nums[t1 - 1, x1 - 1]})");
                    else if (Math.Abs(nums[0, kolvostolb - 1]) < Math.Abs(nums[t - 1, x - 1]))
                        Console.WriteLine($"б) абсолютная величина 1 элемента ({nums[t - 1, x - 1]}) меньше, чем  абсолютная величина 2 элемента ({nums[t1 - 1, x1 - 1]})");
                    else
                        Console.WriteLine($"б) абсолютная величина 1 элемента ({nums[t - 1, x - 1]}) равна  абсолютной величине 2 элемента ({nums[t1 - 1, x1 - 1]})");
                }
            }
            void n20() 
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(-100, 100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                if ((nums[0, 0] % 2 == 0 || nums[kolvostrok-1, 0] % 2 == 0) && (nums[0, 0] != 0 && nums[0, kolvostolb - 1] != 0))
                    Console.WriteLine($"a) в левом верхнем ({nums[0, 0]}) или левом нижнем ({nums[kolvostrok - 1, 0]}) углах есть четные числа");
                else
                    Console.WriteLine($"a) в левом верхнем ({nums[0, 0]}) или левом нижнем ({nums[kolvostrok - 1, 0]}) углах нет четные числа");
                //==============================
                if ((nums[0, kolvostolb-1] % 10 == 0 || nums[kolvostrok-1, kolvostolb - 1] % 10 == 0))
                    Console.WriteLine($"б) в правом верхнем ({nums[0, kolvostolb - 1]}) или правом нижнем ({nums[kolvostrok - 1, kolvostolb - 1]}) углах есть числа, оканчивающиеся 0");
                else
                    Console.WriteLine($"б) в правом верхнем ({nums[0, kolvostolb - 1]}) или правом нижнем ({nums[kolvostrok - 1, kolvostolb - 1]}) углах нет числа, оканчивающегося 0");
            }
            void n21()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int kolvostolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (kolvostolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        nums[i, j] = rnd.Next(-100, 100);
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                if ((nums[0, kolvostolb - 1] % 2 != 0 || nums[kolvostrok - 1, kolvostolb - 1] % 2 != 0))
                    Console.WriteLine($"a) в правом верхнем ({nums[0, kolvostolb-1]}) или правом нижнем ({nums[kolvostrok - 1, kolvostolb-1]}) углах есть четные числа");
                else
                    Console.WriteLine($"a) в правом верхнем ({nums[0, kolvostolb - 1]}) или правом нижнем ({nums[kolvostrok - 1, kolvostolb - 1]}) углах нет четных чисел");
                //==============================
                if ((nums[0, 0] % 10 == 5 || nums[kolvostrok - 1, 0] % 10 == 5))
                    Console.WriteLine($"б) в левом верхнем ({nums[0, 0]}) или левом нижнем ({nums[kolvostrok - 1, 0]}) углах есть числа, оканчивающиеся 5");
                else
                    Console.WriteLine($"б) в левом верхнем ({nums[0, 0]}) или левом нижнем ({nums[kolvostrok - 1, 0]}) углах нет числа, оканчивающегося 5");
            }
        }
    }
}