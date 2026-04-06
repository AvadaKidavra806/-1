using System;
using System.Collections.Generic;
using System.Linq;

namespace Metod
{
	public class Hellp
	{
		public void Heellp()
		{
			Treugolnik treugolnik = new Treugolnik();
			treugolnik.VvodStoron();

			if (treugolnik.ProverkaNaSuch())
			{
				Console.WriteLine("Площадь такого треугольника равна " + treugolnik.Ploshad());
				Console.WriteLine("Периметр такого треугольника равна " + treugolnik.Perimetr());
				
			}
		}
	}
	internal class Treugolnik
	{
		/*double a;
		double b;
		double c;*/
		double[] abc = new double[3];
		public void VvodStoron()
		{
			double[] abc = new double[3];
			Console.Write("Введите стороны треугольника через зпт или пробел (а, b, c) ");
			bool OutStoron = true;
			while (OutStoron)
			{
				List<string> Storon = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
				if (Storon.Count() != 3)
					Console.Write("Ошибка! Введите стороны еще раз ");
				else
				{
					int i = 0;
					while (i < Storon.Count())  //знаю, что можно написать просто 3
					{
						if (!double.TryParse(Storon[i], out abc[i]))
						{
							Console.Write($"Ошибка! Введите {i + 1}-ю сторону треугольника еще раз ");
							while (!double.TryParse(Console.ReadLine(), out abc[i]))
								Console.Write($"Ошибка! Введите {i + 1}-ю сторону треугольника еще раз ");
						}
						if (abc[i] <= 0)
							Console.Write($"Сторона не может быть неположительной. Введите {i + 1}-у сторону еще раз ");
						else
							i++;
					}
					OutStoron = false;
				}

			}
			InizialStoron(abc);
		}
		private void InizialStoron(double[] abc)
		{
			for (int i = 0; i < abc.Length; i++)
			{
				this.abc[i] = abc[i];
			}
		}
		public bool ProverkaNaSuch()
		{
			sbyte asd = 0;
			while (asd < abc.Length)
			{
				if (abc[asd % 3] >= (abc[(asd+1) % 3] + abc[(asd + 2) % 3]))
				{
					Console.WriteLine($"Треугольник с такими сторонами не существует");
					return false;
				}
				asd++;
			}
			return true;
		}
		public double Ploshad()
		{
			double PolPer = Perimetr() / 2;
			return Math.Sqrt(PolPer * (PolPer - abc[0]) * (PolPer - abc[1]) * (PolPer - abc[2]));
		}
		public double Perimetr()
		{
			return abc[0] + abc[1] + abc[2];
		}
	}
}