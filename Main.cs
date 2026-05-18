using System;
using System.Text;

namespace Main
{
    internal class ClaasMain
    {
        static void Main()
        {
            //Zadaniy.For hgf = new Zadaniy.For(); hgf.TipoMain();  //тоже показать надо
            //Stroki.Simvol simvol = new Stroki.Simvol(); simvol.TipoMain(); //дз по 14 
            //Nadoelo nadoelo = new Nadoelo(); nadoelo.TipoMain(); //дз по 15
            Vremynka vremynka = new Vremynka();  vremynka.n22();

            Console.Write("Для завершения программы нажмите Enter"); 
            Console.ReadLine(); 
        }
    }
    public class Obchee
    {
        public void SozdanieKvadratnogoMassiva(out int Razryad)
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
        public void InicilzasiyMassiva(Predicate<int> UslovieStok, Predicate<int> UslovieStolb, string UslovieStokStr, string UslovieStolbStr, out int KolvoStrok, out int KolvoStolb)
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
        //Main.Obchee obchee = new Main.Obchee();
       /*
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
        */
    }
    class Vremynka //дз по 26
    {
        string slovostr;
        public void n20()
        {
            Console.Write("Введите слово ");
            while (Proverka(3)) ;
            /*var slovo1 = new StringBuilder(slovostr);
            for (int i = 2; i < slovo1.Length - 1; i++)
            {
                (slovo1[i], slovo1[i + 1]) = (slovo1[i + 1], slovo1[i]);
            }
            slovo1[slovo1.Length - 1] = '_';*/
            Console.WriteLine("a) Удалена третья буква: " + UdalenieOdnoyBukvu(3));
            //============
            Console.WriteLine("Удалить букву с номером k ");
            /*var slovo2 = new StringBuilder(slovostr);
            for (int i = ZaprosNomeraBukvu("k") - 1; i < slovo2.Length - 1; i++)
            {
                (slovo2[i], slovo2[i + 1]) = (slovo2[i + 1], slovo2[i]);
            }
            slovo2[slovo2.Length - 1] = '_';*/
            Console.WriteLine("б) Удалена k-я буква: " + UdalenieOdnoyBukvu(ZaprosNomeraBukvu("k")));
            
        }
        public void n21()
        {
            Console.Write("Введите слово ");
            while (Proverka()) ;
            // var slovo = new StringBuilder(slovostr);
            if (Array.Exists(slovostr.ToCharArray(), g => g == 'о'))
                Console.WriteLine("а) Удалена первая буква о: " + UdalenieOdnoyBukvu(Array.FindIndex(slovostr.ToCharArray(), g => g == 'о') + 1));
            else
                Console.WriteLine("а) В слове нет букв о");
            //==========
            if (Array.Exists(slovostr.ToCharArray(), g => g == 'л'))
                Console.WriteLine("б) Удалена последняя буква л: " + UdalenieOdnoyBukvu(Array.FindLastIndex(slovostr.ToCharArray(), g => g == 'л') + 1));
            else
                Console.WriteLine("б) В слове нет букв л");
        }
        public void n22()
        {
            Console.Write("Введите слово ");
            while (Proverka()) ;
            if (!ProverkaChet())
                Console.WriteLine("Слово состоит из четного кол-ва букв. Измененное слово: " + UdalenieDvuhBukv(slovostr.Length / 2, slovostr.Length / 2));
            else
                Console.WriteLine("Слово состоит из нечетного кол-ва букв. Измененное слово: " +  UdalenieOdnoyBukvu(slovostr.Length / 2 + 1));

        }
        bool ProverkaChet(int minbukv = 1)
        {
            if (slovostr.Length % 2 != 0)
            {
                //Console.Write("Введенное слово содержит нечетное кол-во букв. Введите слово еще раз ");
                return true;
            }
            else
                return false;
        }
        bool Proverka(int minbukv = 1)
        {
            slovostr = Console.ReadLine().Trim();
            if (slovostr.Length < minbukv)
            {
                Console.Write($"Слово должно быть минимум из {minbukv} букв. Введите слово еще раз ");
                return true;
            }
            else if (slovostr.Split(new char[] { ' ' }).Length != 1)
            {
                Console.Write("Введенное значение состоит не из одного слова. Введите слово еще раз ");
                return true;
            }
            /*else if (slovostr.Length % 2 != 0)
            {
                Console.Write("Введенное слово содержит нечетное кол-во букв. Введите слово еще раз ");
                return true;
            }*/
            else
                return false;

        }
        int ZaprosNomeraBukvu(string name)
        {
            Console.Write($"Введите номер {name} буквы ");
            int NomerBukvu;
            while (true)
            {

                if (!int.TryParse(Console.ReadLine(), out NomerBukvu))
                    Console.Write($"Ошибка! Введите номер {name} буквы еще раз ");
                else if (NomerBukvu <= 0 || NomerBukvu > slovostr.Length)
                    Console.Write($"Номер буквы не может быть неположительным и больше кол-ва букв в слове ({slovostr.Length}).Введите номер {name} буквы еще раз  ");
                else
                    break;
            }
            return NomerBukvu;
        }
        string UdalenieOdnoyBukvu(int nomerbukvu)
        {
            var slovo1 = new StringBuilder(slovostr);
            for (int i = nomerbukvu - 1; i < slovo1.Length - 1; i++)
            {
                (slovo1[i], slovo1[i + 1]) = (slovo1[i + 1], slovo1[i]);
            }
            slovo1[slovo1.Length - 1] = '_';
            return slovo1.ToString();
        }
        string UdalenieDvuhBukv(int nomerbukvu1, int nomerbukvu2)
        {
            slovostr = UdalenieOdnoyBukvu(nomerbukvu1);
            return UdalenieOdnoyBukvu(nomerbukvu2);
        }
    }
}
