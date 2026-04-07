using System;

//Otrabotka.Metodov metodov = new Otrabotka.Metodov(); metodov.TipoMain();
namespace Otrabotka
{

    public class Metodov
    {
        public void TipoMain()
        {
            Vklad();
            //Rasstoynie();
            //90 187.9
            void Vklad()
            {
                Console.Write($"Введите сумму вашего вклада ");
                double chislo = 0; bool outchislo = true;
                while (outchislo)
                {
                    if (!double.TryParse(Console.ReadLine(), out chislo))
                        Console.Write($"Ошибка! Сумма вклада не число, введите еще раз ");
                    else if (chislo <= 0)
                        Console.Write($"Сумма вклада не может быть неположительной, введите сумму еще раз ");
                    else
                        outchislo = false;
                }
                for (int i = 0; i < 12; i++)
                {
                    Procents(ref chislo, out int p);
                    //Console.WriteLine("Сумма вклада с начисленными процентами: " + chislo + ". Начисленно " + p + $"% за {i+1} месяц");
                }
                Console.WriteLine("Сумма вклада с начисленными процентами: " + chislo);
            }
            void Procents(ref double Chislo, out int proc )
            {
                if (Chislo < 100)
                {
                    Chislo *= 1.05;
                    proc = 5;
                }
                else if (Chislo >= 100 && Chislo <= 200)
                {
                    Chislo *= 1.07;
                    proc = 7;
                }
                else
                { 
                    Chislo *= 1.10;
                    proc = 10;
                }
            }
            //===================================================================================================================================
            void Rasstoynie()
            {
                Console.Write("Введите x первой точки отрезка ");
                double x1 = VvodPeremennih();
                Console.Write("Введите y первой точки отрезка ");
                double y1 = VvodPeremennih();
                Console.Write("Введите x второй точки отрезка ");
                double x2 = VvodPeremennih();
                Console.Write("Введите y второй точки отрезка ");
                double y2 = VvodPeremennih();
                Console.WriteLine($"Расстояние между точками с координатами ({x1} ; {y1}) и ({x2} ; {y2}) равно " + Math.Round(Vuchisleni(x1, x2, y1, y2),5));
                //============
                double VvodPeremennih()
                {

                    double q = 1 ; bool outq = true;
                    while (outq)
                    {
                        if (double.TryParse(Console.ReadLine(), out q) == false)
                            Console.Write("Неверный ввод, координата должна быть числом, введите еще раз ");
                        else
                            outq = false;
                    }
                    return q;
                }
                //==============
                
            }
            double Vuchisleni(double x1,double x2,double y1, double y2)
            {
                return Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
            }

        }
    }   
}