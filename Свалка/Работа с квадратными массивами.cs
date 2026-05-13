using System;

//Rabota.KvadratMassiv massiv = new Rabota.KvadratMassiv(); massiv.DmumerMassiv();
namespace Rabota
{
	public class KvadratMassiv
	{
		public void DmumerMassiv()
		{
			Console.WriteLine("Работа с квадратными массивами ");
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
				case 3: n3(); break;
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
				case 17: n17(); break;
				default:
					Console.WriteLine("Пока что не готов этот номер");
					break;
			}
			void n1()
			{
				SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//=============================
				Console.Write($"Введите номер строки для нахождения элемента, находящегося на главной диагонали матрицы ");
				int NomerStroki = 0; bool OutNomerStroki = true;
				while (OutNomerStroki)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerStroki))
						Console.Write("Ошибка! Введите номер строки еще раз ");
					else if (NomerStroki <= 0 || NomerStroki > Razryad)
						Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({Razryad}). Введите номер строки еще раз ");
					else
						OutNomerStroki = false;
				}
				Console.WriteLine($"Элемент, находящийся на пересечении главной диагонали матрицы и {NomerStroki}-ий строки: {massiv[NomerStroki - 1,   NomerStroki - 1]} ");
			}
			void n2()
			{
                SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//=============================
				Console.Write($"Введите номер столбца для нахождения элемента, находящегося на побочной диагонали матрицы ");
				int NomerStolb = 0; bool OutNomerStolb = true;
				while (OutNomerStolb)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerStolb))
						Console.Write("Ошибка! Введите номер столбца еще раз ");
					else if (NomerStolb <= 0 || NomerStolb > Razryad)
						Console.Write($"Номер столбца не может быть неположительным и больше кол-ва столбцов в массиве ({Razryad}). Введите номер столбца еще раз ");
					else
						OutNomerStolb = false;
				}
				Console.WriteLine($"Элемент, находящийся на пересечении побочной диагонали матрицы и {NomerStolb}-ого столбца: {massiv[Razryad - NomerStolb, NomerStolb - 1]} ");
			}
			void n3()
			{
                SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
				int[] glav = new int[Razryad];
				int[] poboch = new int[Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
						if (i == j)
							glav[i] = massiv[i, j];
						if (i + j == Razryad - 1)
							poboch[i] = massiv[i,j];
					}
					Console.WriteLine();
				}
				Array.Reverse(poboch);
				Console.WriteLine($"Элементы главной диагонали: {string.Join(", ", glav)}");
				Console.WriteLine($"Элементы побочной диагонали: {string.Join(", ", poboch)}");
			}
			void n4()
			{
                SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
				int[] glav = new int[Razryad];
				int[] poboch = new int[Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
						if (i == j)
							glav[i] = massiv[i, j];
						if (i + j == Razryad - 1)
							poboch[i] = massiv[i, j];
					}
					Console.WriteLine();
				}
				Array.Reverse(glav);
				Console.WriteLine($"Элементы главной диагонали: {string.Join(", ", glav)}");
				Console.WriteLine($"Элементы побочной диагонали: {string.Join(", ", poboch)}");
			}
			void n5()
			{
                SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//=============================
				Console.Write($"Введите номер строки первого элемента для расчета суммы, находящегося на главной диагонали матрицы ");
				int NomerStroki = 0; bool OutNomerStroki = true;
				while (OutNomerStroki)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerStroki))
						Console.Write("Ошибка! Введите номер строки еще раз ");
					else if (NomerStroki <= 0 || NomerStroki > Razryad)
						Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({Razryad}). Введите номер строки еще раз ");
					else
						OutNomerStroki = false;
				}
				Console.Write($"Введите номер строки второго элемента для расчета суммы, находящегося на главной диагонали матрицы ");
				int NomerStroki1 = 0; bool OutNomerStroki1 = true;
				while (OutNomerStroki1)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerStroki1))
						Console.Write("Ошибка! Введите номер строки еще раз ");
					else if (NomerStroki1 <= 0 || NomerStroki1 > Razryad)
						Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({Razryad}). Введите номер строки еще раз ");
					else
						OutNomerStroki1 = false;
				}
				Console.WriteLine($"Сумма элементов, находящихся на пересечении главной диагонали и {NomerStroki}-й и {NomerStroki1}-й равна: {massiv[NomerStroki -1, NomerStroki -1] + massiv[NomerStroki1 - 1, NomerStroki1 - 1]}");
			}
			void n6()
			{
                SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//=============================
				Console.Write($"Введите номер строки первого элемента для расчета произведения, находящегося на побочной диагонали матрицы ");
				int NomerStroki = 0; bool OutNomerStroki = true;
				while (OutNomerStroki)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerStroki))
						Console.Write("Ошибка! Введите номер строки еще раз ");
					else if (NomerStroki <= 0 || NomerStroki > Razryad)
						Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({Razryad}). Введите номер строки еще раз ");
					else
						OutNomerStroki = false;
				}
				Console.Write($"Введите номер строки второго элемента для расчета произведения, находящегося на побочной диагонали матрицы ");
				int NomerStroki1 = 0; bool OutNomerStroki1 = true;
				while (OutNomerStroki1)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerStroki1))
						Console.Write("Ошибка! Введите номер строки еще раз ");
					else if (NomerStroki1 <= 0 || NomerStroki1 > Razryad)
						Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({Razryad}). Введите номер строки еще раз ");
					else
						OutNomerStroki1 = false;
				}
				Console.WriteLine($"Произведение элементов, находящихся на пересечении побочной диагонали и {NomerStroki}-й и {NomerStroki1}-й равна: {massiv[NomerStroki - 1, Razryad - NomerStroki] * massiv[NomerStroki1 - 1, Razryad - NomerStroki1]}");
			}
			void n7()
			{
                SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//=============================
				Console.WriteLine("Измененный двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						if (i == j)
						massiv[i, j] = 0;
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
			}
			void n8()
			{
                SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//=============================
				Console.WriteLine("Измененный двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						if (i + j == Razryad - 1)
							massiv[i, j] = 100;
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
			}
			void n9()
			{
                SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				int sumglav = 0;
				int sumpoboch = 0;
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
						if (i == j)
							sumglav += massiv[i, j];
						if (i + j == Razryad - 1)
							sumpoboch += massiv[i, j];
					}
					Console.WriteLine();
				}
				//=======================
				Console.WriteLine("a)Сумма элементов главной диагонали равна: " + sumglav);
				Console.WriteLine("б)Сумма элементов побочной диагонали равна: " + sumpoboch);
			
			}
			void n10()
			{
                SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				double sumglav = 0;
				double sumpoboch = 0;
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
						if (i == j)
							sumglav += massiv[i, j];
						if (i + j == Razryad - 1)
							sumpoboch += massiv[i, j];
					}
					Console.WriteLine();
				}
				//=======================
				Console.WriteLine("a)Среднее арифметическое элементов главной диагонали равна: " + sumglav / Razryad);
				Console.WriteLine("б)Среднее арифметическое элементов побочной диагонали равна: " + Math.Round(sumpoboch / Razryad, 2));
			}
			void n11()
			{
                SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < Razryad; i++)
                {
                    for (int j = 0; j < Razryad; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
				//=======================
				Console.WriteLine("Найти для каждой строки суммму элементов главной и побочной диагоналей");
				Console.WriteLine("Способ 1 ");
                Console.WriteLine("№ Строки\tСумма элементов ");
                int[] chisla = new int[Razryad * 2];
				for (int i = 0; i < Razryad; i++)
				{
					chisla[i] = massiv[i, i];
					chisla[i + Razryad] = massiv[i, Razryad - i - 1];
				}
                for (int i = 0; i < Razryad; i++)
                {
                    if (Razryad % 2 == 0)
                        Console.WriteLine($"{i + 1}\t\t{chisla[i] + chisla[i+Razryad]}");
                    else
                    {
                        if (i != Razryad / 2)
                            Console.WriteLine($"{i + 1}\t\t{chisla[i] + chisla[i + Razryad]}");
                        else
                            Console.WriteLine($"{i + 1}\t\t{chisla[i]}");
                    }
                }
				//Console.WriteLine("Одномерный массив: " + String.Join(", ", chisla));
                //==================
                Console.WriteLine("Способ 2 ");
				Console.WriteLine("№ Строки\tСумма элементов ");
				for (int i = 0; i < Razryad; i++)
				{
					if (Razryad % 2 == 0)
						Console.WriteLine($"{i + 1}\t\t{massiv[i, i] + massiv[i, Razryad - 1 - i]}");
					else
					{
						if (i != Razryad / 2)
							Console.WriteLine($"{i + 1}\t\t{massiv[i, i] + massiv[i, Razryad - 1 - i]}");
						else
							Console.WriteLine($"{i + 1}\t\t{massiv[i, i]}");
                    }
                }
            }
			void n12()
			{
				SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < Razryad; i++)
                {
                    for (int j = 0; j < Razryad; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //=======================
                Console.WriteLine("Найти для каждого столбца суммму элементов главной и побочной диагоналей");
                Console.WriteLine("Способ 1 ");
                Console.WriteLine("№ Столбца\tСумма элементов ");
                int[] chisla = new int[Razryad * 2];
                for (int i = 0; i < Razryad; i++)
                {
                    chisla[i] = massiv[i, i];
                    chisla[i + Razryad] = massiv[Razryad - i - 1, i];
                }
                for (int i = 0; i < Razryad; i++)
                {
                    if (Razryad % 2 == 0)
                        Console.WriteLine($"{i + 1}\t\t{chisla[i] + chisla[i + Razryad]}");
                    else
                    {
                        if (i != Razryad / 2)
                            Console.WriteLine($"{i + 1}\t\t{chisla[i] + chisla[i + Razryad]}");
                        else
                            Console.WriteLine($"{i + 1}\t\t{chisla[i]}");
                    }
                }
                //==================
                Console.WriteLine("Способ 2 ");
                Console.WriteLine("№ Столбца\tСумма элементов ");
                for (int i = 0; i < Razryad; i++)
                {
                    if (Razryad % 2 == 0)
                        Console.WriteLine($"{i + 1}\t\t{massiv[i, i] + massiv[Razryad - 1 - i, i]}");
                    else
                    {
                        if (i != Razryad / 2)
                            Console.WriteLine($"{i + 1}\t\t{massiv[i, i] + massiv[Razryad - 1 - i, i]}");
                        else
                            Console.WriteLine($"{i + 1}\t\t{massiv[i, i]}");
                    }
                }
            }
			void n13()
			{
				SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < Razryad; i++)
                {
                    for (int j = 0; j < Razryad; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
				//=======================
				Console.WriteLine("Поменять местами два любых элемента главной диагонали ");
				int FirstElement = ZaprosStroki(1) - 1;
                int SecondElement = ZaprosStroki(2) - 1;
				int ZaprosStroki(int da = 1)
				{
					Console.Write($"Введите номер сторки {da}-го элемента ");
					int NomerStroki = 0; bool OutNomerStroki = true;
					while (OutNomerStroki)
					{
						if (!int.TryParse(Console.ReadLine(), out NomerStroki))
							Console.Write("Ошибка! Введите номер строки еще раз ");
						else if (NomerStroki <= 0)
							Console.Write("Номер строки не может быть неположительным. Введите номер строки еще раз ");
						else if (NomerStroki > Razryad)
							Console.Write("Номер строки не может быть больше кол-ва строк в массиве. Введите номер строки еще раз ");
						else
							OutNomerStroki = false;
					}
					return NomerStroki;
				}
				(massiv[FirstElement, FirstElement], massiv[SecondElement, SecondElement]) = (massiv[SecondElement, SecondElement], massiv[FirstElement, FirstElement]);
				Console.WriteLine("Поменяны местами выбранные элементы: ");
                for (int i = 0; i < Razryad; i++)
                {
                    for (int j = 0; j < Razryad; j++)
					{                     
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            void n14()
            {
                SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < Razryad; i++)
                {
                    for (int j = 0; j < Razryad; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //=======================
                Console.WriteLine("Поменять местами два любых элемента побочной диагонали ");
                int FE = ZaprosStroki(1) - 1;
                int SE = ZaprosStroki(2) - 1;
                int ZaprosStroki(int da = 1)
                {
                    Console.Write($"Введите номер сторки {da}-го элемента ");
                    int NomerStroki = 0; bool OutNomerStroki = true;
                    while (OutNomerStroki)
                    {
                        if (!int.TryParse(Console.ReadLine(), out NomerStroki))
                            Console.Write("Ошибка! Введите номер строки еще раз ");
                        else if (NomerStroki <= 0)
                            Console.Write("Номер строки не может быть неположительным. Введите номер строки еще раз ");
                        else if (NomerStroki > Razryad)
                            Console.Write("Номер строки не может быть больше кол-ва строк в массиве. Введите номер строки еще раз ");
                        else
                            OutNomerStroki = false;
                    }
                    return NomerStroki;
                }
				(massiv[FE, Razryad - FE - 1], massiv[SE, Razryad - SE - 1]) = (massiv[SE, Razryad - SE - 1], massiv[FE, Razryad - FE - 1]);
                Console.WriteLine("Поменяны местами выбранные элементы: ");
                for (int i = 0; i < Razryad; i++)
                {
                    for (int j = 0; j < Razryad; j++)
                    {
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
			void n15()
			{
				SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
                Random rnd = new Random();
				int sumgl = 0;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < Razryad; i++)
                {
                    for (int j = 0; j < Razryad; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
						if(i == j)
							sumgl += massiv[i, j];
                    }
                    Console.WriteLine();
                }
				//=======================
				if (sumgl <= 100)
					Console.WriteLine($"Верно, сумма главной диагонали матрицы не превышает 100 (sumgl: {sumgl})");
				else
					Console.WriteLine($"Не верно, сумма главной диагонали матрицы превышает или равна 100 (sumgl: {sumgl})");
				
            }
            void n16()
            {
                SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
                Random rnd = new Random();
                int sumpob = 0;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < Razryad; i++)
                {
                    for (int j = 0; j < Razryad; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                        if (i + j == Razryad - 1)
                            sumpob += massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //=======================
                if (sumpob % 10 == 0)
                    Console.WriteLine($"Верно, сумма побочной диагонали матрицы оканчивается 0 (sumpob: {sumpob})");
                else
                    Console.WriteLine($"Не верно, сумма побочной диагонали матрицы не оканчивается 0 (sumpob: {sumpob})");

            }
			void n17()
			{
				SozdanieKvadratnogoMassiva(out int Razryad);
                int[,] massiv = new int[Razryad, Razryad];
                Random rnd = new Random();
                int sumgl = 0;
                int sumpob = 0;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < Razryad; i++)
                {
                    for (int j = 0; j < Razryad; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                        if (i == j)
                            sumgl += massiv[i, j];
                        if (i + j == Razryad - 1)
                            sumpob += massiv[i, j];
                    }
                    Console.WriteLine();
                }
				//=======================
				if (sumgl == sumpob)
					Console.WriteLine($"Сумма элементов главной диагонали равна сумме элементов побочной диагонали (sumgl: {sumgl}, sumpob: {sumpob})");
				else if (sumgl > sumpob)
                    Console.WriteLine($"Сумма элементов главной диагонали больше суммы элементов побочной диагонали (sumgl: {sumgl}, sumpob: {sumpob})");
				else
                    Console.WriteLine($"Сумма элементов главной диагонали меньше суммы элементов побочной диагонали (sumgl: {sumgl}, sumpob: {sumpob})");
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
				
		}
	}
}