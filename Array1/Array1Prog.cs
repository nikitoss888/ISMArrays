using System;
using static System.Math;

namespace Array1
{
    class Array1Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер матрицы: "); int N = int.Parse(Console.ReadLine());
            float[] mtx = new float[N]; int index;
            Console.WriteLine("Введите члены матрицы по-очереди");
            for (int i = 0; i < N; i++)
                mtx[i] = float.Parse(Console.ReadLine());
            Console.WriteLine("Сумма негативных чисел массива равна {0}\n", lessthan0sum(N, mtx));
            Console.WriteLine("Наибольший член массива равен {0}, его индекс: {1}\n", maxElem(N, mtx, out index), index);
            Console.WriteLine("Наибольший по модулю член массива равен {0}\n", absmax(N, mtx));
            Console.WriteLine("Сумма индексов позитивных членов массива равна {0}\n", morethan0indsum(N, mtx));
            Console.WriteLine("Количество целых чисел в массиве: {0}\n", intnums(N, mtx));
            Console.ReadKey();
        }
        static float lessthan0sum(int N, float[] mtx)
        {
            float sum = 0;
            for (int i = 0; i < N; i++)
                if (mtx[i] < 0)
                    sum += mtx[i];
            return sum;
        }
        static float maxElem(int N, float[] mtx, out int ind)
        {
            float max = float.MinValue;
            ind = 0;
            for (int i = 0; i < N; i++)
                if (mtx[i] > max)
                {
                    max = mtx[i];
                    ind = i;
                }
            return max;
        }
        static float absmax(int n, float[] a)
        {
            float absmax = a[0];
            for (int i = 1; i < n; i++)
                if (Abs(absmax) < Abs(a[i]))
                    absmax = a[i];
            return absmax;
        }
        static int morethan0indsum(int n, float[] a)
        {
            int mt0is = 0;
            for (int i = 0; i < n; i++)
                if (a[i] > 0)
                    mt0is += i;
            return mt0is;
        }
        static int intnums(int n, float[] a)
        {
            int intn = 0;
            for (int i = 0; i < n; i++)
                if (a[i] % 1 == 0)
                    intn++;
            return intn;
        }
    }
}
