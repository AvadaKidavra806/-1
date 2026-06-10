using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;

public class Podgotovka
{
    public void TipoMain()
    {
        //n13();
        //n19();
        n3();
    }
    void n13()
    {
        int KolvoStrok = VvodStrStol("кол-во строк");
        int KolvoStolb = VvodStrStol("кол-во столбцов");
        Random random = new Random();
        double[,] massiv = new double[KolvoStrok, KolvoStolb];
        Console.WriteLine("Двумерный массив: ");
        for (int i = 0; i < KolvoStrok; i++)
        {
            for (int j = 0; j < KolvoStolb; j++)
            {
                massiv[i, j] = Math.Round(random.NextDouble() * 100, 3);
                Console.Write(massiv[i, j] + "\t");
            }
            Console.WriteLine();
        }
        //Console.Write("Введите k ");
        int k = VvodKN("k");
        Console.Write("a) Все элементы k-го столбца: ");
        for(int i = KolvoStrok - 1; i >=0; i--)
        {
            if (i==0)
            Console.Write(massiv[i, k - 1] +"." );
            else
                Console.Write(massiv[i,k - 1] + ", ");
        }
        Console.WriteLine();
        //Console.Write("Введите n ");
        int n = VvodKN("n");
        Console.Write("б) Все элементы n-й строки: ");
        for (int i = KolvoStolb - 1; i >= 0; i--)
        {
            if (i == 0)
                Console.Write(massiv[n - 1, i] + ".");
            else
                Console.Write(massiv[n - 1, i] + ", ");
        }
        Console.WriteLine();
        int VvodKN(string name)
        {
            int result;
            Console.Write($"Введите {name} ");
            while (true)
            {
                result = VvodStrStol(name);
                if (name == "n" && result > KolvoStrok)
                    Console.Write($"{name} не может быть больше кол-ва строчек в массиве! Введите {name} еще раз ");
                else if (name == "k" && result > KolvoStolb)
                    Console.Write($"{name} не может быть больше кол-ва столбцов в массиве! Введите {name} еще раз ");
                else
                    break;
            }
            return result;
        }
        
    }
    void n19()
    {
        int KolvoStrok;
        while (true)
        {
            KolvoStrok = VvodStrStol("кол-во строк");
            if (KolvoStrok < 2)
                Console.Write("Ошибка! Строк по условию должно быть мин 2. ");
            else
                break;
        }

        int KolvoStolb;
        while (true)
        {
            KolvoStolb = VvodStrStol("кол-во столбцов");
            if (KolvoStolb < 2)
                Console.Write("Ошибка! Невозможно поменять местами первый и предпоследний столбцы (предпоследнего не сущ, мин 2 столбца). ");
            else
                break;
        }
        Random random = new Random();
        double[,] massiv = new double[KolvoStrok, KolvoStolb];
        Console.WriteLine("Двумерный массив: ");
        for (int i = 0; i < KolvoStrok; i++)
        {
            for (int j = 0; j < KolvoStolb; j++)
            {
                massiv[i, j] = Math.Round(random.NextDouble() * 100, 3);
                Console.Write(massiv[i, j] + "\t");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < KolvoStrok; i++)
        {
            (massiv[i, 0], massiv[i, KolvoStolb - 2]) = (massiv[i, KolvoStolb - 2], massiv[i, 0]);
        }
        Console.WriteLine("Поменяны местами первый и предпоследний столбцы:");
        for (int i = 0; i < KolvoStrok; i++)
        {
            for (int j = 0; j < KolvoStolb; j++)
            {
                Console.Write(massiv[i, j] + "\t");
            }
            Console.WriteLine();
        }
        //==========
        for (int i = 0; i < KolvoStolb; i++)
        {
            (massiv[1, i], massiv[ KolvoStrok - 1, i]) = (massiv[KolvoStrok - 1, i], massiv[1 ,i]);
        }
        Console.WriteLine("Поменяны местами вторая и последняя строчки:");
        for (int i = 0; i < KolvoStrok; i++)
        {
            for (int j = 0; j < KolvoStolb; j++)
            {
                Console.Write(massiv[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    void n3()
    {
    
    }
    int VvodStrStol(string name)
    {
        int result;
        Console.Write($"Введите {name} ");
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write($"Возникла ошибка! Введите {name} еще раз ");
            }
            else if (result <= 0)
                Console.Write($"{name} не может быть неположительным! Введите {name} еще раз ");
            else
                break;
        }
        return result;
    }
}