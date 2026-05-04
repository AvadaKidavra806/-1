using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Zadaniy
{
    public class For
    {
        public void TipoMain()
        {
            Main.Obchee obchee = new Main.Obchee();
            Console.WriteLine("Задания для экзамена ");
            byte NomerZadaniy; bool NomerZadaniyOut;
            bool OutZadanie = true;
            do
            {
                Console.Write("Введите номер задания: ");
                NomerZadaniy = 1; NomerZadaniyOut = true;
                while (NomerZadaniyOut)
                {
                    if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
                        Console.Write("Ошибка! Введите номер задания еще раз ");
                    /*else if (NomerZadaniy <= 0 || NomerZadaniy > 6)
                        Console.Write("В дз всего 6 заданий, Введите номер задания еще раз ");*/
                    else
                        NomerZadaniyOut = false;

                }
                ConsoleKey Klavisha;
                switch (NomerZadaniy)
                {
                    case 1: n1(); break;
                    case 2: n2(); break;
                    case 3: n3(); break;
                    case 4: n4(); break;
                    case 5: n5(); break;
                    case 6: n6(); break;
                    case 7: n7(); break;
                case 8: n8(); break;
                case 9: n9(); break;
                    default:
                        Console.WriteLine("Пока что не готов этот номер");
                        break;
                }
                do
                {
                    Console.WriteLine("Y or N");
                    Klavisha = Console.ReadKey(true).Key;
                }
                while (Klavisha != ConsoleKey.Y && Klavisha != ConsoleKey.N);
                if (Klavisha == ConsoleKey.Y)
                    OutZadanie = true;
                else if (Klavisha == ConsoleKey.N)
                    OutZadanie = false;
            }
            while (OutZadanie);
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
                obchee.InicilzasiyMassiva(UslovieStrok, UslovieStolb, UslovieStokStr, UslovieStolbStr, out int KolvoStrok, out int KolvoStolb);
                //========================
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //=============================
                if ((massiv[0, 0] % 2 == 0 && massiv[0, 0] != 0) || (massiv[0, KolvoStolb - 1] % 2 == 0 && massiv[0, KolvoStolb - 1] != 0))
                    Console.WriteLine("a) В левом верхнем или левом нижнем углах есть четные числа");
                else
                    Console.WriteLine("a) В левом верхнем или левом нижнем углах нет четных чисел");
                //=================
                if ((massiv[0, KolvoStolb - 1] % 10 == 0) || (massiv[KolvoStrok - 1, KolvoStolb - 1] % 10 == 0))
                    Console.WriteLine("б) В правом верхнем или правом нижнем углах есть числа, оканчивающиеся 0");
                else
                    Console.WriteLine("б) В правом верхнем или правом нижнем углах нет чисел, оканчивающихся 0");
            }
            void n2()
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
                obchee.InicilzasiyMassiva(UslovieStrok, UslovieStolb, UslovieStokStr, UslovieStolbStr, out int KolvoStrok, out int KolvoStolb);
                //========================
                double[,] massiv = new double[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = Math.Round(rnd.NextDouble() * 201 - 100, 3);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //=============================
                {
                    Console.WriteLine("Вывести на экран все элементы k-го столбца, начиная с нижнего элемента этого столбца");
                    Console.Write($"Введите номер k-го столбца ");
                    int NomerStolb = 0; bool OutNomerStolb = true;
                    while (OutNomerStolb)
                    {
                        if (!int.TryParse(Console.ReadLine(), out NomerStolb))
                            Console.Write("Ошибка! Введите номер столбца еще раз ");
                        else if (NomerStolb <= 0 || NomerStolb > KolvoStolb)
                            Console.Write($"Номер столбца не может быть неположительным и больше кол-ва столбцов в массиве ({KolvoStolb}). Введите номер столбца еще раз ");
                        else
                            OutNomerStolb = false;
                    }
                    double[] ElementsKStolba = new double[KolvoStrok];
                    for (int i = 0; i < KolvoStrok; i++) ElementsKStolba[KolvoStrok - 1 - i] = massiv[i, NomerStolb - 1];
                    Console.WriteLine($"Все элементы {NomerStolb}-го столбца, начиная с нижнего: " + string.Join(", ", ElementsKStolba));
                }
                //===================
                {
                    Console.WriteLine("Вывести на экран все элементы n-й строки, начиная с нижнего (?) элемента этой строки"); //ват чтото не так //взял от правого
                    Console.Write($"Введите номер n-й строки ");
                    int NomerStroki = 0; bool OutNomerStroki = true;
                    while (OutNomerStroki)
                    {
                        if (!int.TryParse(Console.ReadLine(), out NomerStroki))
                            Console.Write("Ошибка! Введите номер строки еще раз ");
                        else if (NomerStroki <= 0 || NomerStroki > KolvoStrok)
                            Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({KolvoStrok}). Введите номер строки еще раз ");
                        else
                            OutNomerStroki = false;
                    }
                    double[] ElementsNStroki = new double[KolvoStolb];
                    for (int i = 0; i < KolvoStolb; i++) ElementsNStroki[KolvoStolb - 1 - i] = massiv[NomerStroki - 1, i];
                    Console.WriteLine($"Все элементы {NomerStroki}-й строки, начиная с правого: " + string.Join(", ", ElementsNStroki));
                }
            }
            void n3()
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
                obchee.InicilzasiyMassiva(UslovieStrok, UslovieStolb, UslovieStokStr, UslovieStolbStr, out int KolvoStrok, out int KolvoStolb);
                //========================
                //int KolvoStrok = 5; int KolvoStolb = 5;
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random random = new Random();
                double sum = 0;
                double sumkv = 0;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = random.Next(-50, 50);
                        Console.Write(massiv[i, j] + "\t");
                        sum += massiv[i, j];
                        sumkv += Math.Pow(massiv[i, j], 2);
                    }
                    Console.WriteLine();
                }
                //=====================
                Console.WriteLine("Сумма всех элементов массива: " + sum);
                Console.WriteLine("Сумма квадратов всех элементов массива: " + sumkv);
                Console.WriteLine("Среднее арифметическое всех элементов массива: " + sum / (KolvoStolb * KolvoStrok));

            }
            void n4()
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
                obchee.InicilzasiyMassiva(UslovieStrok, UslovieStolb, UslovieStokStr, UslovieStolbStr, out int KolvoStrok, out int KolvoStolb);
                //========================
                //int KolvoStrok = 2; int KolvoStolb = 3;
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random random = new Random();
                int[] sumstolb = new int[KolvoStolb];
                int[] sumstrok = new int[KolvoStrok];
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = random.Next(-50, 50);
                        Console.Write(massiv[i, j] + "\t");
                        sumstolb[j] += massiv[i, j];
                        sumstrok[i] += massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //=====================
                /*Console.WriteLine("Сумма по строкам " + string.Join(", ", sumstrok));
                Console.WriteLine("Сумма по столбцам " + string.Join(", ",  sumstolb));*/
                //=================
                Console.WriteLine("Номер строки с мин суммой элементов: " + (Array.FindIndex(sumstrok, f => f == sumstrok.Min()) + 1)+$" ({sumstrok.Min()})");
                Console.WriteLine("Номер столбца с макс суммой элементов: " + (Array.FindLastIndex(sumstolb, f => f == sumstolb.Max()) + 1) + $" ({sumstrok.Max()})");
            }
            void n5()
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
                obchee.InicilzasiyMassiva(UslovieStrok, UslovieStolb, UslovieStokStr, UslovieStolbStr, out int KolvoStrok, out int KolvoStolb);
                //========================
                //int KolvoStrok = 2; int KolvoStolb = 3;
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random random = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = random.Next(-50, 50);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //================
                Console.WriteLine("Определить большее из суммы k-й строки и суммы n-го столбца");
                Console.Write($"Введите номер k-й строки ");
                int NomerStroki = 0; bool OutNomerStroki = true;
                while (OutNomerStroki)
                {
                    if (!int.TryParse(Console.ReadLine(), out NomerStroki))
                        Console.Write("Ошибка! Введите номер строки еще раз ");
                    else if (NomerStroki <= 0 || NomerStroki > KolvoStrok)
                        Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({KolvoStrok}). Введите номер строки еще раз ");
                    else
                        OutNomerStroki = false;
                }
                int sumk = 0;
                for (int i = 0; i < KolvoStolb; i++) sumk += massiv[NomerStroki - 1, i];
                //===============
                Console.Write($"Введите номер n-го столбца ");
                int NomerStolb = 0; bool OutNomerStolb = true;
                while (OutNomerStolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out NomerStolb))
                        Console.Write("Ошибка! Введите номер столбца еще раз ");
                    else if (NomerStolb <= 0 || NomerStolb > KolvoStolb)
                        Console.Write($"Номер столбца не может быть неположительным и больше кол-ва столбцов в массиве ({KolvoStolb}). Введите номер столбца еще раз ");
                    else
                        OutNomerStolb = false;
                }
                int sumn = 0;
                for (int i = 0; i < KolvoStrok; i++) sumn += massiv[i, NomerStolb - 1];
                if (sumk == sumn)
                    Console.WriteLine($"Сумма {NomerStroki}-й строки равна сумме {NomerStolb}-го столбца (sumk: {sumk}, sumn: {sumn})");
                else if (sumk > sumn)
                    Console.WriteLine($"Большее из суммы {NomerStroki}-й строки и суммы {NomerStolb}-го столбца - сумма {NomerStroki}-й строки (sumk: {sumk}, sumn: {sumn})");
                else
                    Console.WriteLine($"Большее из суммы {NomerStroki}-й строки и суммы {NomerStolb}-го столбца - сумма {NomerStolb}-го столбца (sumk: {sumk}, sumn: {sumn})");

            }
            void n6() 
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
                obchee.InicilzasiyMassiva(UslovieStrok, UslovieStolb, UslovieStokStr, UslovieStolbStr, out int KolvoStrok, out int KolvoStolb);
                //========================
                //int KolvoStrok = 5; int KolvoStolb = 5;
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random random = new Random();
                void ZapolnenieMassiva()
                {
                    for (int i = 0; i < KolvoStrok; i++)
                    {
                        for (int j = 0; j < KolvoStolb; j++)
                        {
                            massiv[i, j] = random.Next(-10, 10);
                        }
                    }
                }
                bool ProverkaUsloviy() //true если все ок, false если в строчке нет и того, и того
                {
                    bool Otrizat = false;
                    bool Chetnost = false;
                    for (int i = 0; i < KolvoStrok; i++)
                    {
                        Otrizat = false;
                        Chetnost = false;
                        for (int j = 0; j < KolvoStolb; j++)
                        {
                            Otrizat |= (massiv[i, j] < 0);
                            Chetnost |= (massiv[i, j] % 2 == 0 && massiv[i, j] != 0);
                        }
                        if (Otrizat == false || Chetnost == false)
                            return false;
                    }
                    return true;
                }
                void VuvodMassiva()
                {
                    for (int i = 0; i < KolvoStrok; i++)
                    {
                        for (int j = 0; j < KolvoStolb; j++)
                        {
                            Console.Write(massiv[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
                do
                {
                    ZapolnenieMassiva();
                }
                while (!ProverkaUsloviy());
                VuvodMassiva();
                //==========================
                Console.WriteLine("№ строки\t1st отриц элем");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    int[] Stroki = new int[KolvoStolb];
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        Stroki[j] = massiv[i, j];
                    }
                    Console.WriteLine($"{i + 1}\t\t{Array.Find(Stroki, h => h < 0)}");
                }
                //========================
                Console.WriteLine("№ строки\tlast четн элем");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    int[] Stroki = new int[KolvoStolb];
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        Stroki[j] = massiv[i, j];
                    }
                    Console.WriteLine($"{i + 1}\t\t{Array.FindLast(Stroki, h => h % 2 == 0 && h != 0)}");
                }
            }
            void n7()
            {
                obchee.SozdanieKvadratnogoMassiva(out int Razryd);
                //===========
                //int Razryd = 4;
                int[,] Matrica = new int[Razryd, Razryd];
                Random random = new Random();
                Console.WriteLine("Матрица: ");
                for (int i = 0; i < Razryd; i++)
                {
                    for (int j = 0; j < Razryd; j++)
                    {
                        Matrica[i, j] = random.Next(-10, 10);
                        Console.Write(Matrica[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===================
                {
                    int[] GlavDiagon = new int[Razryd];
                    for (int i = 0; i < Razryd; i++) GlavDiagon[i] = Matrica[i, i];
                    Console.WriteLine("Мин элемент главной диагонали: " + GlavDiagon.Min());
                }
                //==============
                {
                    int[] GlavDiagon = new int[Razryd];
                    for (int i = 0; i < Razryd; i++) GlavDiagon[i] = Matrica[i, Razryd - 1 - i];
                    Console.WriteLine("Макс элемент побочной диагонали: " + GlavDiagon.Max());
                }
            }
            void n8() //прописать условие для предпоследней строки и вторую строку
            {
                bool UslovieStrok(int x)
                {
                    return x<2; //при отсутствии условий оставить false
                }
                bool UslovieStolb(int x)
                {
                    return x<2; //при отсутствии условий оставить false
                }
                string UslovieStokStr = "При таком кол-ве строк нельзя поменять элементы второй строки.";
                string UslovieStolbStr = "При таком кол-ве столбцов нельзя поменять элементы предпоследнего столбца (Первый столбец - последний, предпоследний не существует).";
                obchee.InicilzasiyMassiva(UslovieStrok, UslovieStolb, UslovieStokStr, UslovieStolbStr, out int KolvoStrok, out int KolvoStolb);
                //========================
                //int KolvoStrok = 2; int KolvoStolb = 3;
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random random = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = random.Next(-50, 50);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //================
                Console.WriteLine("Поменяны местами первый и предпоследний столбцы ");
                int[,] massiva = new int[KolvoStrok, KolvoStolb];
                Array.Copy(massiv, massiva, KolvoStolb*KolvoStrok);
                for (int i = 0; i < KolvoStrok; i++)
                {
                    (massiva[i, 0], massiva[i, KolvoStolb - 1 - 1]) = (massiva[i, KolvoStolb - 1 - 1], massiva[i, 0]);
                }
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        Console.Write(massiva[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //===============================
                Console.WriteLine("Поменяны местами вторая и последняя строки");
                int[,] massivb= new int[KolvoStrok, KolvoStolb];
                Array.Copy(massiv, massivb, KolvoStolb * KolvoStrok);
                for (int i = 0; i < KolvoStolb; i++)
                {
                    (massivb[1, i], massivb[KolvoStrok - 1, i]) = (massivb[KolvoStrok - 1, i], massivb[1, i]);
                }
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        Console.Write(massivb[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            }
            void n9()
            {
                obchee.SozdanieKvadratnogoMassiva(out int Razryd);
                //============
                //int Razryd = 4;
                int[,] Matrica = new int[Razryd, Razryd];
                Random random = new Random();
                List<int> Otriz = new List<int>();
                List<int> Chetn = new List<int>();
                List<int> Nechetn = new List<int>();
                Console.WriteLine($"Двумерный массив {Razryd}x{Razryd}");
                for (int i = 0; i < Razryd; i++)
                {
                    for (int j = 0; j < Razryd; j++)
                    {
                        Matrica[i, j] = random.Next(-10, 10);
                        Console.Write(Matrica[i, j] + "\t");
                        if (Matrica[i, j] < 0)
                            Otriz.Add(Matrica[i, j]);
                        if (Matrica[i, j] % 2 == 0 && Matrica[i, j] != 0)
                            Chetn.Add(Matrica[i, j]);
                        else if (Matrica[i, j] != 0)
                            Nechetn.Add(Matrica[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Все отрицательные элементы: " + string.Join(", ", Otriz.ToArray()));
                Console.WriteLine("Все четные элементы: " + string.Join(", ", Chetn.ToArray()));
                Console.WriteLine("Все нечетные элементы: " + string.Join(", ", Nechetn.ToArray()));
            }
        }
    }
}