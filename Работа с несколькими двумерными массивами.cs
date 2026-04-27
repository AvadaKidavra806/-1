using System;

//RabotaSNeskolkimi.Dvumerniye mas = new RabotaSNeskolkimi.Dvumerniye(); mas.Massivami();
namespace RabotaSNeskolkimi
{
    public class Dvumerniye
    {
        public void Massivami()
        {
            /*Console.SetWindowSize(240, 63);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetBufferSize(1000, 1000);
            Console.Title = "DFFGGG";*/
            Console.WriteLine("Работа с несколькими двумерными массивами ");
            Console.Write("Введите номер задания: ");
            byte NomerZadaniy = 1; bool NomerZadaniyOut = true;
            while (NomerZadaniyOut)
            {
                if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                /*else if (NomerZadaniy <= 0 || NomerZadaniy > 6)
                    Console.Write("В дз всего 6 заданий, Введите номер задания еще раз ");*/
                else
                    NomerZadaniyOut = false;

            }
            switch (NomerZadaniy)
            {
                case 1: n1(); break;
                case 2: n2(); break;
                case 3: n3(); break;/*
                case 4: n4(); break;
                case 5: n5(); break;
                case 6: n6(); break;
                case 7: n7(); break;
                case 8: n8(); break;
                case 9: n9(); break;
                case 10: n10(); break;
                case 11: n11(); break;
                case 12: n12(); break;
                case 13: n13(); break;
                case 14: n14(); break;
                case 15: n15(); break;
                case 16: n16(); break;
                case 17: n17(); break;*/
                default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;
            }
            void InicilzasiyMassiva(Predicate<int> UslovieStok, Predicate<int> UslovieStolb, string UslovieStokStr, string UslovieStolbStr, out int KolvoStrok, out int KolvoStolb)
            {
                Console.Write("Введите кол-во строк в массиве ");
                KolvoStrok = 0; bool OutKolvoStrok = true;
                while (OutKolvoStrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (KolvoStrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (UslovieStok(KolvoStrok))
                        Console.Write($"{UslovieStokStr} Введите кол-во строк еще раз ");
                    else
                        OutKolvoStrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                KolvoStolb = 0; bool OutKolvoStolb = true;
                while (OutKolvoStolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else if (UslovieStolb(KolvoStolb))
                        Console.Write($"{UslovieStolbStr} Введите кол-во столбцов еще раз ");
                    else
                        OutKolvoStolb = false;
                }
            }
            void n1()
            {
                bool UslovieStrok(int x)
                {
                    return false; //при отсутствии условий оставить false
                }
                bool UslovieStolb(int x)
                {
                    return false; //при отсутствии условий оставить false
                }
                string UslovieStokStr = "";
                string UslovieStolbStr = "";
                InicilzasiyMassiva(UslovieStrok, UslovieStolb, UslovieStokStr, UslovieStolbStr, out int KolvoStrok, out int KolvoStolb);
                //========================
                double[,] massiv1 = new double[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                Console.WriteLine("Первый двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv1[i, j] = Math.Round(rnd.NextDouble() * 200 - 100, 2);
                        Console.Write(massiv1[i, j] + "\t\t");
                    }
                    Console.WriteLine();
                }
                //===================
                double[,] massiv2 = new double[KolvoStrok, KolvoStolb];
                Console.WriteLine("Второй двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv2[i, j] = 0; //Math.Round(rnd.NextDouble() * 200 - 100, 2);
                        Console.Write(massiv2[i, j] + "\t\t");
                    }
                    Console.WriteLine();
                }
                //============================
                //===========================
                double[,] massiv3a = new double[KolvoStrok, KolvoStolb];
                Console.WriteLine("a) Третий двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv3a[i, j] = Math.Round(massiv1[i, j] + massiv2[i, j], 2);
                        Console.Write(massiv3a[i, j] + "\t\t");
                    }
                    Console.WriteLine();
                }
                //========================
                double[,] massiv3б = new double[KolvoStrok, KolvoStolb];
                Console.WriteLine("б) Третий двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        if (massiv1[i, j] * massiv2[i, j] >= 0)
                            massiv3б[i, j] = 100;
                        else
                            massiv3б[i, j] = 0;
                        Console.Write(massiv3б[i, j] + "\t\t");
                    }
                    Console.WriteLine();
                }
                //=======================
                double[,] massiv3в = new double[KolvoStrok, KolvoStolb];
                Console.WriteLine("в) Третий двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv3в[i, j] = Math.Round(massiv1[i, j] - massiv2[i, j], 2);
                        Console.Write(massiv3в[i, j] + "\t\t");
                    }
                    Console.WriteLine();
                }
                //=====================================
                double[,] massiv3г = new double[KolvoStrok, KolvoStolb];
                Console.WriteLine("г) Третий двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        if (massiv1[i, j] + massiv2[i, j] > 100)
                            massiv3г[i, j] = 13;
                        else
                            massiv3г[i, j] = 12;
                        Console.Write(massiv3г[i, j] + "\t\t");
                    }
                    Console.WriteLine();
                }
            }
            void n2()
            {
                const int KolvoStrok = 28;
                const int KolvoStolb = 12;
                Random random = new Random();
                double[,] massiv = new double[KolvoStrok, KolvoStolb];
                Console.WriteLine("Информация о кол-ве осадков в 2023 году:");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = Math.Round(random.NextDouble() * 200, 2);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===========
                double[,] massiv1 = new double[KolvoStrok, KolvoStolb];
                Console.WriteLine("Информация о кол-ве осадков в 2024 году:");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = Math.Round(random.NextDouble() * 200, 2);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //====================
                double[,] massiv2 = new double[KolvoStrok, KolvoStolb];
                Console.WriteLine("Информация о разнице осадков в 2024 и 2023 годах:");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv2[i, j] = Math.Round(Math.Abs(massiv1[i, j] - massiv[i, j]), 2);
                        Console.Write(massiv2[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            void n3()
            {
                const int KolvoStrok = 28;
                const int KolvoStolb = 12;
                Random random = new Random();
                double[,] massiv = new double[KolvoStrok, KolvoStolb];
                Console.WriteLine("Информация о температуре в 2023 году:");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = Math.Round(random.NextDouble() * 200, 3);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===========
                double[,] massiv1 = new double[KolvoStrok, KolvoStolb];
                Console.WriteLine("Информация о температуре в 2024 году:");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv1[i, j] = Math.Round(random.NextDouble() * 200, 3);
                        Console.Write(massiv1[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //====================
                double[,] massiv2 = new double[KolvoStrok, KolvoStolb];
                Console.WriteLine("Информация о разнице температур в 2023 и 2024 годах:");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv2[i, j] = Math.Round(((massiv1[i, j] - massiv[i, j]) / massiv[i ,j]) * 100, 2);
                        Console.Write(massiv2[i, j] + "%\t");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}