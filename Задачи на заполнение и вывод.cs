using System;

//Zadachi.Zapolnenie zapolnenie = new Zadachi.Zapolnenie(); zapolnenie.Vuvod();
namespace Zadachi
{
    class Zapolnenie
    {
        public void Vuvod()
        {
            Console.WriteLine("Заполнение и вывод");
            Console.Write("Введите номер задания: ");
            byte NomerZadaniy = 1; bool NomerZadaniyOut = true;
            while (NomerZadaniyOut)
            {
                if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                /*else if (NomerZadaniy <= 0 || NomerZadaniy > 21)
                    Console.Write("В дз всего 21 заданий, Введите номер задания еще раз ");*/
                else
                    NomerZadaniyOut = false;
            }
            switch (NomerZadaniy)
            {
                case 1: n1(); break;
                case 2: n2(); break;
                case 3: n3(); break;
                case 4: n4(); break;
                default:
                    Console.WriteLine("Пока что не готов этот номер ");
                    break;
            }
            void n1 ()
            {
                const int kolvostrok = 9;
                const int kolvostolb = 9;
                int[,] massiv = new int[kolvostrok, kolvostolb];
                for(int i = 0; i <kolvostrok; i++)
                {
                    for(int j = 0; j <kolvostolb; j++)
                    {
                        massiv[i, j] = (i + 1) * (j + 1);
                        Console.Write(massiv[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            void n2 ()
            {
                Console.WriteLine("Задание а ");
                const int kolvostrok = 13;
                const int kolvostolb = 13;
                int[,] massiv = new int[kolvostrok, kolvostolb];
                for (int i = 0; i  < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        if (i == j || (i + j == kolvostrok - 1))
                        {
                            massiv[i, j] = 1;
                        }
                        else
                        {
                            massiv[i, j] = 0;
                        }
                        Console.Write(massiv[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Задание б ");
                for (int i = 0; i <kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        if (i == j || i + j == kolvostrok - 1 || j == kolvostolb / 2|| i == kolvostrok/2)
                        {
                            massiv[i, j] = 1;
                        }
                        else
                        {
                            massiv[i, j] = 0;
                        }
                        Console.Write(massiv[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Задание в ");
                for (int i = 0; i <kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        if ((i <= j || kolvostrok - 1 - i <= j) && (j <= kolvostolb - 1 - i || i >= j))
                        {
                            massiv[i, j] = 1;
                        }
                        else
                        {
                            massiv[i, j] = 0;
                        }
                        Console.Write(massiv[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            void n3 ()
            {
                Console.WriteLine("Задание а ");
                const int kolvostrok = 6;
                const int kolvostolb = 6;
                int[,] massiv = new int[kolvostrok, kolvostolb];
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        if (i == 0 || j == 0)
                        {
                            massiv[i, j] = 1;
                        }
                        else
                        massiv[i, j] = massiv[i - 1, j] + massiv[i, j - 1];
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Задание б ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        if (i == 0)
                            massiv[i, j] = 1 + j;
                        else if (massiv[i - 1, j] == 6)
                            massiv[i, j] = 1;
                        else
                            massiv[i, j] = massiv[i - 1, j] + 1;
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            void n4 ()
            { 
                
                int kolvostrok = 12;
                int kolvostolb = 10;
                int[,] massiv = new int[kolvostrok, kolvostolb];
                Console.WriteLine("4а) ");
                int hellp = 1;
                for (int i = 0; i< kolvostrok; i++)
                {
                    for(int j = 0; j< kolvostolb; j++)
                    {
                        massiv[i, j] = hellp;
                        hellp ++;
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //====================
                Console.WriteLine("4б) ");
                hellp = 1;
                for (int i = 0; i< kolvostrok; i++)
                {
                    for(int j = 0; j< kolvostolb; j++)
                    {
                        massiv[i, j] = hellp;
                        hellp +=12;
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                    hellp -= 119;
                }
                //==========
                Console.WriteLine("4в) ");
                hellp = 10;
                for (int i = 0; i< kolvostrok; i++)
                {
                    for(int j = 0; j< kolvostolb; j++)
                    {
                        massiv[i, j] = hellp;
                        hellp --;
                        Console.Write(massiv[i, j] + "\t");
                    }
                    hellp += 20;
                    Console.WriteLine();
                }
                //==============
                Console.WriteLine("4г) ");
                hellp = 12;
                for (int i = 0; i< kolvostrok; i++)
                {
                    for(int j = 0; j< kolvostolb; j++)
                    {
                        massiv[i, j] = hellp;
                        hellp +=12;
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                    hellp -= 121;
                }
                //====================
                kolvostolb = 12;
                kolvostrok = 10;
                Console.WriteLine("4д) ");
                hellp = 1;
                massiv = new int[kolvostrok, kolvostolb]; 
                for (int i = 0; i< kolvostrok; i++)
                {

                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < kolvostolb; j++)
                        {
                            massiv[i, j] = hellp;
                            hellp += 1;
                            Console.Write(massiv[i, j] + "\t");
                        }
                        Console.WriteLine();
                        hellp += 11;
                    }
                    else
                    {
                        for (int j = 0; j < kolvostolb; j++)
                        {
                            massiv[i, j] = hellp;
                            hellp -= 1;
                            Console.Write(massiv[i, j] + "\t");
                        }
                        Console.WriteLine();
                        hellp += 13;
                    }
                }
                //==================
                kolvostolb = 10;
                kolvostrok = 12;
                Console.WriteLine("4е) ");
                hellp = 1;
                massiv = new int[kolvostrok, kolvostolb];
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        if (j % 2 == 0)
                        {
                            massiv[i, j] = hellp + i + j * 12;
                        }
                        else
                        {
                            //massiv[i, j] = ((j / 2) + 1) * hellp + 23 * (j / 2) - i + 23;
                            massiv[i, j] = ((j / 2) + 1) * (hellp + 23)- i;
                        }


                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                    //hellp -= 119;
                    
                }
            }
        }
    }
}