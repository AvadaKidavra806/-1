using System;

namespace Zadaniy
{
    public class For
    {
        public void TipoMain()
        {
            Console.WriteLine("Задания для экзамена ");
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
                case 1: n1(); break;/*
                case 2: n2(); break;
                case 3: n3(); break;
                case 4: n4(); break;
                case 5: n5(); break;
                case 6: n6(); break;
                case 7: n7(); break;
                case 8: n8(); break;
                case 9: n9(); break;*/
                default:
                    Console.WriteLine("Пока что не готов этот номер");
                    break;
            }
            void SozdanieKvadratnogoMassiva(out int Razryad)
            {
                Console.Write("Введите разрядность квадратной матрицы: ");
                Razryad = 0; bool OutRazryad = true;
                while (OutRazryad)
                {
                    if (!int.TryParse(Console.ReadLine(), out Razryad))
                        Console.Write("Ошибка! Введите разрядность квадратной матрицы еще раз ");
                    else if (Razryad <= 0)
                        Console.Write("Разрядность квадратной матрицы не может быть неположительным. Введите разряд квадратной матрицы еще раз ");
                    else
                        OutRazryad = false;
                }
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
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                //int sum1 = 0;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                        /*if (i == 0)
                            sum1 += massiv[i, j];*/
                    }
                    Console.WriteLine();
                }
                //=============================
                if ((massiv[0, 0] % 10 == 0 && massiv[0, 0] != 0) || (massiv[0, KolvoStrok - 1] % 10 == 0 && massiv[0, KolvoStrok - 1] != 0))
                    Console.WriteLine("a) В левом верхнем или левом нижнем углах есть четные числа");
                else
                    Console.WriteLine("a) В левом верхнем или левом нижнем углах нет четных чисел");
                //=================
                if ((massiv[0, 0] % 10 == 0 && massiv[0, 0] != 0) || (massiv[0, KolvoStrok - 1] % 10 == 0 && massiv[0, KolvoStrok - 1] != 0))
                    Console.WriteLine("a) В левом верхнем или левом нижнем углах есть четные числа");
            }

        }
    }
}