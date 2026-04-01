using System;

//Dvumerny_massiv_obrabotka.Ghf Ghf = new Dvumerny_massiv_obrabotka.Ghf(); Ghf.Edf();
namespace Dvumerny_massiv_obrabotka
{
	public class Ghf
	{
		public void Edf()
		{
			Console.WriteLine("Двумерный массив обработка");
			Console.Write("Введите номер задания: ");
			byte NomerZadaniy = 1; bool NomerZadaniyOut = true;
			while (NomerZadaniyOut)
			{
				if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
					Console.Write("Ошибка! Введите номер задания еще раз ");
				else if (NomerZadaniy <= 0 || NomerZadaniy > 5)
					Console.Write("В дз всего 5 заданий, Введите номер задания еще раз ");
				else
					NomerZadaniyOut = false;

			}
			switch (NomerZadaniy)
			{
                case 1: n1(); break; //есть косяк по i, j  в др мб тоже
                case 2: n2(); break;
                case 3: n3(); break;
                case 4: n4(); break;
                case 5: n5(); break;
			}
			void n1 ()
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
                        Console.Write("При таком кол-ве строк нельзя найти элемент пятой строки. Введите кол-во строк еще раз ");
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
                    bool d = true;
                    if (i == 4)
                    {
                        while (d)
                        {
                            for (int j = 0; j < kolvostolb; j++)
                            {
                                nums[i, j] = rnd.Next(100);
                                if (nums[i, j] == 13)
                                    d = false;
                            }
                        }
                        for (int j = 0; j < kolvostolb; j++)
                        {
                            Console.Write(nums[i, j] + "\t");
                        }
                    }
                
                    else
                    {
                        for (int j = 0; j < kolvostolb; j++)
                        {
                                nums[i, j] = rnd.Next(100);
                            Console.Write(nums[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
                //============================
                int j2 = 0;
                while (j2 < kolvostolb && nums[4, j2] != 13 )
                    j2++;
                Console.WriteLine("Номер столбца, в котором расположен самый левый элемент 13 в пятой строке: "+(j2+1));
            }
            void n2 ()
            {
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (kolvostrok < 3)
                        Console.Write("При таком кол-ве строк нельзя найти элемент третьей строки. Введите кол-во строк еще раз ");
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
                    bool d = true;
                    if (i == 2)
                    {
                        while (d)
                        {
                            for (int j = 0; j < kolvostolb; j++)
                            {
                                nums[i, j] = rnd.Next(100);
                                if (nums[i, j] == 0)
                                    d = false;
                            }
                        }
                        for (int j = 0; j < kolvostolb; j++)
                        {
                            Console.Write(nums[i , j] + "\t");
                        }
                    }

                    else
                    {
                        for (int j = 0; j < kolvostolb; j++)
                        {
                            nums[i, j] = rnd.Next(100);
                            Console.Write(nums[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
                //============================
                int j2 = kolvostolb-1;
                while (j2 >= 0 && nums[2, j2] != 0)
                {
                    j2--;
                }
                Console.WriteLine("Номер столбца, в котором расположен самый правый элемент 0 в третьей строке: " + (j2 + 1));

            }
            void n3 ()
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
                    else if (kolvostolb < 2)
                        Console.Write("При таком кол-ве столбцов невозможно нельзя найти элемент второго столбца. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                void ZapolnenieMassiva (out bool d)
                {
                    d = true;
                    for (int i = 0; i < kolvostrok; i++)
                    {
                        for (int j = 0; j < kolvostolb; j++)
                        {
                            nums[i, j] = rnd.Next(100);
                            if (j == 1)
                            {
                                if (nums[i, j] == 21)
                                    d = false;
                            }
                            
                        }
                    }
                }
                bool d1 = true;
                while (d1)
                ZapolnenieMassiva(out d1);
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                int j2 = 0;
                while (j2 < kolvostrok && nums[ j2, 1] != 21)
                    j2++;
                Console.WriteLine("Номер строки, в которой расположен самый верхний элемент 21 во втором столбце: " + (j2 + 1));
            }
            void n4 ()
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
                    else if (kolvostolb < 2)
                        Console.Write("При таком кол-ве столбцов невозможно нельзя найти элемент второго столбца. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                void ZapolnenieMassiva(out bool d)
                {
                    d = true;
                    for (int i = 0; i < kolvostrok; i++)
                    {
                        for (int j = 0; j < kolvostolb; j++)
                        {
                            nums[i, j] = rnd.Next(100);
                            if (j == 1)
                            {
                                if (nums[i, j] == 10)
                                    d = false;
                            }

                        }
                    }
                }
                bool d1 = true;
                while (d1)
                    ZapolnenieMassiva(out d1);
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        Console.Write(nums[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                int j2 = kolvostrok - 1;
                while (j2 >= 0 && nums[1, j2] != 10)
                    j2--;
                Console.WriteLine("Номер строки, в которой расположен самый нижний элемент 10 во втором столбце: " + (j2 + 1));
            }
            void n5 ()
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
                        Console.Write("При таком кол-ве строк нельзя найти элемент пятой строки. Введите кол-во строк еще раз ");
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
                //==============
                {
                    Console.Write("Введите номер строки, в которой необходимо провести проверку: ");
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
                    Console.Write("Введите число, для проверки ");
                    int Chislo = 0; bool OutChislo = true;
                    while (OutChislo)
                    {
                        if (!int.TryParse(Console.ReadLine(), out Chislo))
                            Console.Write("Ошибка! Введите число еще раз ");
                        else
                            OutChislo = false;
                    }
                    int j2 = 0;
                    bool asd = true;
                    while (j2 < kolvostolb && asd)
                    {
                        asd = nums[t - 1, j2] != Chislo;
                        j2++;
                    }
                    if (!asd)
                        Console.WriteLine($"a) В {t}-й строке есть {Chislo}. Одна из позиций такого числа: [{t}, {j2}]");
                    else
                        Console.WriteLine($"a) В {t}-й строке нет {Chislo}");
                }
                //============================
                {
                    Console.Write("Введите номер столбца элемента, в котороv необходимо провести проверку: ");
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
                    Console.Write("Введите число, для проверки ");
                    int Chislo = 0; bool OutChislo = true;
                    while (OutChislo)
                    {
                        if (!int.TryParse(Console.ReadLine(), out Chislo))
                            Console.Write("Ошибка! Введите число еще раз ");
                        else
                            OutChislo = false;
                    }
                    int j2 = 0;
                    bool asd = true;
                    while (j2 < kolvostrok && asd)
                    {
                        asd = nums[j2, x - 1] % Chislo != 0;
                        j2++;
                    }
                    if (!asd)
                        Console.WriteLine($"б) В {x}-м столбце есть число кратное {Chislo}. Одна из позиций такого числа: [{j2}, {x}]");
                    else
                        Console.WriteLine($"б) В {x}-м столбце нет {Chislo}");
                }
            }
        }
	}
}