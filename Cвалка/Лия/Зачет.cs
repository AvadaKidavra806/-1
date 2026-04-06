using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классворк_12._01._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*№1 */
            double x, y, z, q, w, e, r, t;
            Console.Write("Введите x ");
            while (!double.TryParse(Console.ReadLine(), out x) )
             Console.Write("Ошибка! Введите x еще раз ");
            if (x-1 < 0)
            {
                Console.WriteLine("Введенный x создает ситуацию, в которой подкоренное выражение отрицательно");
                return ;
            }
            q = Math.Pow((x - 1), 1.0 / 3.0);
            Console.Write("Введите y ");
            while (!double.TryParse(Console.ReadLine(), out y))
                Console.Write("Ошибка! Введите y еще раз ");
            if (y + q < 0)
            {
                Console.WriteLine("Введенные x и y создают ситуацию, в которой подкоренное выражение отрицательно");
                return;
            }
            else if (Math.Abs(x - y) == 0)
            {
                Console.WriteLine("Введенные x и y создают ситуацию, в которой знаменатель равен 0 ");
                return;
            }
                Console.Write("Введите z ");
            while (!double.TryParse(Console.ReadLine(), out z))
                Console.Write("Ошибка! Введите z еще раз ");
            r = Math.Pow(Math.Sin(z), 2) + Math.Tan(z);
            if (r == 0)
            {
                Console.WriteLine("Введеный z создает ситуацию, в которой знаменатель равен 0 ");
                return;
            }
            w = Math.Pow((y+q),1.0/4.0); //числитель
            e=Math.Abs(x-y);
            t = w/(e * r);
            Console.WriteLine($"ответ: {Math.Round(t, 3)}");
            

            /*№2 */
            //русский язык не воспринимает у меня :(
            Console.Write("Введите возрастную категорию человека мужского пола (mladenes, rebenok, podrostok, unosha, mushina, poshiloy chelovek) ");
            string u =Convert.ToString (Console.ReadLine());
            switch (u)
            {
                case "mladenes":
                    Console.WriteLine("Возраст: до года");
                    break;
                case "rebenok":
                    Console.WriteLine("Возраст: от года до 11 лет");
                    break;
                case "podrostok":
                    Console.WriteLine("Возраст: от 12 до 15 лет");
                    break;
                case "unosha":
                    Console.WriteLine("Возраст: от 16 до 25 лет");
                    break;
                case "mushina":
                    Console.WriteLine("Возраст: от 26 до 70 лет");
                    break;
                case "poshiloy chelovek":
                    Console.WriteLine("Возраст: более 70 лет");
                    break;
                default:
                    Console.WriteLine("Введенное значение не является верным");
                    break;

            }
            

            /*№3*/
            double v,p;
            Console.Write("Введите вес ");
            while (!double.TryParse(Console.ReadLine(), out v) || v<=0)
                Console.Write("Ошибка! Введите вес еще раз ");
            Console.Write("Введите рост ");
            while (!double.TryParse(Console.ReadLine(), out p) || p <= 0)
                Console.Write("Ошибка! Введите рост еще раз ");
            if ((v < ((p - 100) * 1.1)) && ((v > ((p - 100) * 0.9))))
                Console.WriteLine("Норма");
            else if ((v > ((p - 100) * 1.1)))
                Console.WriteLine("Нужно похудеть");
            else
                Console.WriteLine("Нужно поправиться");
            

            /*№4*/
            double vklad, mec;
            Console.Write("Введите сумму вклада ");
            while (!double.TryParse(Console.ReadLine(), out vklad) || vklad <= 0)
                Console.Write("Ошибка! Вклад введен не верно, попробуйте еще раз ");
            Console.Write("Введите колво месяцев ");
            while (!double.TryParse(Console.ReadLine(),out mec) || mec <= 0)
                Console.Write("Ошибка! Колво месяцев введено не верно, попробуйте еще раз ");
            for (int i = 1; i <= mec; i++)
            {
                vklad *= 1.07;
            }
            Console.WriteLine($"Конечная сумма: {Math.Round(vklad,2)}");
            

            /*№5*/
            int nat, nat1, sem = 0, chet = 0;
            Console.Write("Введите натуральное число ");
            while (!int.TryParse(Console.ReadLine(), out nat) || nat <= 0)
                Console.Write("Ошибка! Введите натуральное число еще раз ");
            while (nat > 0)
            {
                nat1 = nat % 10;
                if (nat1 == 7)
                    sem++;
                if (nat1 % 2 == 0)
                    chet++;
                nat /= 10;
            }
            Console.WriteLine($"Колво чисел 7: {sem}\nКолво четных чисел: {chet}");
            

            Console.ReadLine(); 
        }
    }
}
