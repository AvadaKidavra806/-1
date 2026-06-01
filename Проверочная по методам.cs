using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public class ProverochnayMetodu
{
	public void TipoMain()
	{
		Console.WriteLine("Проверочная работа по методам ");
		byte NomerZadaniy; bool NomerZadaniyOut;
		while (true)
		{
			Console.Write("Введите номер задания: ");
			NomerZadaniy = 1; NomerZadaniyOut = true;
			while (NomerZadaniyOut)
			{
				if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
					Console.Write("Ошибка! Введите номер задания еще раз ");/*
                else if (NomerZadaniy <= 0 || NomerZadaniy > 15)
                    Console.Write("В дз всего 15 заданий, Введите номер задания еще раз ");*/
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
				default:
					Console.WriteLine("Пока что не готов этот номер");
					break;
			}
			ConsoleKey Klavisha;
			Console.WriteLine("Для выбора след задания нажмите Y, Для завершения программы N (Y or N)");
			do
			{
				Klavisha = Console.ReadKey(true).Key;
			}
			while (Klavisha != ConsoleKey.Y && Klavisha != ConsoleKey.N);
			if (Klavisha == ConsoleKey.N)
				break;
		}
	}
	void n1()
	{
		int a = Vvod("a");
		int b = Vvod("b");
		int c = Vvod("c");
		int d = Vvod("d");

		Console.WriteLine("Минимальное из a, b, c, d: " + min(d, min(c, min(a, b))));
	}
	int min(int x, int y)
	{
		if (x < y)
			return x;
		else
			return y;
	}
	double min(double x, double y)
	{
		if (x < y)
			return x;
		else
			return y;
	}
	void n2()
	{
		int a = Vvod("a");
		int b = Vvod("b");
		int c = Vvod("c");
		int d = Vvod("d");
		Console.WriteLine("Максимальное из a, b, c, d: " + max(d, max(c, max(a, b))));
	}
	int max(int x, int y)
	{
		if (x > y)
			return x;
		else
			return y;
	}
	double max(double x, double y)
	{
		if (x > y)
			return x;
		else
			return y;
	}
	void n3()
	{
		Console.Write("Введите х ");
		double x = Vvodd("x");
		double sum = 0;
		for (int i = 1; i <= 10; i++)
		{
			sum += nxi((uint)i, x);
		}
		Console.WriteLine("Сумма равна: " + sum);
	}
	void n4()
	{
		double x = Vvodd("x");
		double proiz = 1;
		for (int i = 1; i <= 10; i++)
		{
			proiz *= nxi((uint)i, x);
		}
		Console.WriteLine("Произведение равна: " + proiz);
	}
	double nxi(uint n, double x)
	{
		return n / Math.Pow(x, n);
	}
	void n5()
	{
		double x = Vvodd("x");
		double sum = 0;
		for (int i = 1; i <= 10; i++)
		{
			sum += xnnx((uint)i, x);
		}
		Console.WriteLine("Сумма равна: " + sum);
	}
	double xnnx(uint n, double x)
	{
		return Math.Pow(x, n) / (x + n);
	}
	void n6()
	{
		double a = Vvodd("a");
		double b = Vvodd("b");
		double c = Vvodd("c");
		double asincos = sincos(a);
		double bsincos = sincos(b);
		double csincos = sincos(c);
		Console.WriteLine($"Минимальное значение среди asincos ({asincos}), bsincos ({bsincos}), csincos ({csincos}): " + min(asincos, min(bsincos, csincos)));
	}
	double sincos(double x)
	{
		return Math.Sin(x) + Math.Cos(2 * x);
	}
	void n7()
	{
		double a = Vvodd("a");
		double b = Vvodd("b");
		double c = Vvodd("c");
		double d = Vvodd("d");
		double abx2y2 = x2y2(a, b);
		double cdx2y2 = x2y2(c, d);
		Console.WriteLine($"Большее значение среди abx2y2 ({abx2y2}), cdx2y2 ({cdx2y2}): " + max(abx2y2, cdx2y2));
	}
	double x2y2(double x, double y)
	{
		return Math.Pow(x, 2) + Math.Pow(y, 2);
	}
	void n8()
	{
		double a = Vvodd("a");
		double b = Vvodd("b");
		double c = Vvodd("c");
		double d = Vvodd("d");
		double e = Vvodd("e");
		double f = Vvodd("f");
		double abcx2y3z = x2y3z(a, b, c);
		double defx2y3z = x2y3z(d, e, f);
		Console.WriteLine($"Большее значение среди abcx2y3z ({abcx2y3z}), defx2y3z ({defx2y3z}): " + max(abcx2y3z, defx2y3z));
	}
	double x2y3z(double x, double y, double z)
	{
		return (x * x) + (y * y * y) * Math.Sqrt(z);
	}
	void n9()
	{
		Console.WriteLine("Число\tИзмененное число");
		for (int i = 1; i <= 10; i++)
		{
			Console.WriteLine($"{i}\t\t{ChetNeChet(i)}");
		}
	}
	int ChetNeChet(int x)
	{
		if (x % 2 == 0)
			return -x;
		else
			return x;
	}
	void n10()
	{
		Console.WriteLine("Число\tИзмененное число");
		for (int i = -10; i <= 10; i++)
		{
			Console.WriteLine($"{i}\t\t{OtrPolosh(i)}");
		}
	}
	double OtrPolosh(int x)
	{
		if (x > 0)
			return x * x;
		else
			return x * x * x;
	}
	void n11()
	{
		Console.WriteLine("Аргумент\tЗначение функции x\tЗначение функции y");
		for (double i = -Math.PI; i <= Math.PI; i+=Math.PI/4)
		{
			sincos2(i, out double x, out double y);
			Console.WriteLine($"{Math.Round(i, 3)}\t\t\t{Math.Round(x, 3)}\t\t\t{Math.Round(y, 3)}");
		}
	}
	void sincos2(double a, out double x, out double y)
	{
		x = Math.Pow(Math.Sin(a), 2);
		y = Math.Pow(Math.Cos(a), 2);
	}
	void n12()
	{
		Console.WriteLine("пай\tx = a^2\t\ty = sqrt(a)");
		for (double i = -10; i <= 10; i++)
		{
			xa2ya(i, out double x, out double y);
			Console.Write(i + "\t" + Math.Round(x, 4));
			if (i < 0)
				Console.WriteLine("\t\tНельзя извлечь");
			else
				Console.WriteLine("\t\t" + Math.Round(y, 4));
		}
		void xa2ya(double a, out double x, out double y)
		{
			x = a * a;
			y = Math.Sqrt(a);
		}
	}
	void n13()
	{
		const int kolvostrok = 5;
		var Stroki = new string[kolvostrok];  
		for (int i = 0; i < kolvostrok; i++)
		{
			Stroki[i] = VvodStroki($"{i + 1}-ю");
		}
		for (int i = 0; i < kolvostrok; i++)
		{
			Console.WriteLine($"Измененная {i+1}-я строка: " + ReplaceTchkNaTriTchk(Stroki[i]));
		}
	}
	string ReplaceTchkNaTriTchk(string Stroka)
	{
		var Podstroki = Stroka.Split('.');
		return string.Join("...", Podstroki);
	}
	void n14()
	{
		const int kolvostrok = 5;
		var Stroki = new string[kolvostrok];
		for (int i = 0; i < kolvostrok; i++)
		{
			Stroki[i] = VvodStroki($"{i + 1}-ю");
		}
		for (int i = 0; i < kolvostrok; i++)
		{
			Console.WriteLine($"Измененная {i + 1}-я строка: " + ReplaceLowerUpper(Stroki[i]));
		}

	}
	string ReplaceLowerUpper(string slovo)
	{
		char[] chars = slovo.ToCharArray();
		slovo = string.Empty;
		for (int i = 0; i < chars.Length; i++)
		{
			if (chars[i] == char.Parse(chars[i].ToString().ToUpper()) )
				chars[i] = char.Parse(chars[i].ToString().ToLower());
			else
				chars[i] = char.Parse(chars[i].ToString().ToUpper());
			slovo += chars[i];
		}
		return slovo;
	}
	void n15()
	{

		const int kolvostrok = 5;
		var Stroki = new string[kolvostrok];
		for (int i = 0; i < kolvostrok; i++)
		{
			Stroki[i] = VvodStroki($"{i + 1}-ю");
		}
		Console.WriteLine("Предложения до точки и после точки");
		for (int i = 0; i < kolvostrok; i++)
		{
			RasdelitNaDoIPoslePervoyTchk(Stroki[i], out string slovodo, out string slovoposle);
			Console.WriteLine(slovodo + "\t" + slovoposle);
		}
	}
	void RasdelitNaDoIPoslePervoyTchk(string slovo, out string slovodo, out string slovoposle)
	{
		char[] chars = slovo.ToCharArray();
		slovodo = string.Empty; slovoposle = string.Empty;
		for (int i = 0; i < chars.Length; i++)
		{
			if (i < slovo.IndexOf('.'))
				slovodo += chars[i];
			else if (slovo.IndexOf('.') == -1)
				slovodo += chars[i];
			else if (i > slovo.IndexOf('.'))
				slovoposle += chars[i];
		}
	}
	string VvodStroki(string name)
	{
		Console.Write($"Введите {name} строку ");
		return Console.ReadLine();
	}
	int Vvod(string bukva)
	{
		Console.Write($"Введите {bukva} ");
		int x;
		while (true)
		{
			try
			{
				x = int.Parse(Console.ReadLine());
				break;
			}
			catch
			{
				Console.Write($"Ошибка. Введите {bukva} еще раз ");
			}
		}
		return x;
	}
	double Vvodd(string bukva)
	{
		Console.Write($"Введите {bukva} ");
		double x;
		while (true)
		{
			try
			{
				x = double.Parse(Console.ReadLine());
				break;
			}
			catch
			{
				Console.Write($"Ошибка. Введите {bukva} еще раз ");
			}
		}
		return x;
	}

}