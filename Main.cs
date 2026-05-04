using System;

//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
namespace Main
{
    internal class ClaasMain
    {
        static void Main()
        {
            //Черновик.Черновик черновик = new Черновик.Черновик(); черновик.Решение();
            //ProverkaUslovia.PosleRaschetov posle = new ProverkaUslovia.PosleRaschetov(); posle.DmumerMassiv();
            //Rabota.KvadratMassiv massiv = new Rabota.KvadratMassiv(); massiv.DmumerMassiv();
            //RabotaSNeskolkimi.Dvumerniye mas = new RabotaSNeskolkimi.Dvumerniye(); mas.Massivami();
            //Zadaniy.For hgf = new Zadaniy.For(); hgf.TipoMain(); //дз до конца
            Stroki.Simvol simvol = new Stroki.Simvol(); simvol.TipoMain(); //дз по 14 
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
}
