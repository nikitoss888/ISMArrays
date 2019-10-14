using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Array2Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер матрицы: "); int N = int.Parse(Console.ReadLine());
            float[] mtx = new float[N]; int index;
            Console.WriteLine("Введите члены матрицы по-очереди");
            for (int i = 0; i < N; i++)
                mtx[i] = float.Parse(Console.ReadLine());
            Console.WriteLine("Произведение элементов матрицы после минимального равно: {0}\n", multipl_1(N, mtx));
            Console.WriteLine("Сумма элементов между первым отрицательным и вторым положительным равна: {0}\n", sum_1(N, mtx));
            Console.WriteLine("Сумма элементов после первого нуля и перед последним равна: {0}\n", sum_2(N, mtx));
            Console.WriteLine("Произведение элементов матрицы между минимальным и максимальным по модулю равно: {0}\n", multipl_2(N, mtx));
            Console.ReadKey();
        }
        static float multipl_1(int n, float[] a)
        {
            int minindex = 0; float res = 1, min = float.MaxValue;
            for (int i = 0; i < n; i++)
                if (min > a[i])
                {
                    min = a[i];
                    minindex = i + 1;
                }
            if (minindex >= n)
                return 0;
            else
            {
                for (; minindex < n; minindex++)
                    res *= a[minindex];
                return res;
            }
        }
        static float sum_1(int n, float[] a)
        {
            int minindex = 0, maxindex = n, c = 0; float sum = 0;
            for (int i = 0; i < n; i++)
                if (a[i] < 0)
                {
                    minindex = i + 1;
                    break;
                }
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                    c++;
                if (c == 2)
                {
                    maxindex = i;
                    break;
                }
            }
            if (minindex > maxindex)
            {
                int o = minindex;
                minindex = maxindex + 1;
                maxindex = o - 1;
            }
            for (; minindex < maxindex; minindex++)
                sum += a[minindex];
            return sum;
        }
        static float sum_2(int n, float[] a)
        {
            int minind = 0, maxind = n, c = 0; float sum = 0;
            for (int i = 0; i<n; i++)
                if (a[i] == 0)
                {
                    c++;
                    switch (c)
                    {
                        case 1:
                            minind = i + 1;
                            break;
                        case 2:
                            maxind = i;
                            break;
                    }
                }
            if (minind == 0 || maxind == n)
            {
                Console.WriteLine("Одного из нулей нет, дается сумма всех элементов/всех после первого нуля.\n");
            }
            if (minind > maxind)
            {
                int o = minind;
                minind = maxind + 1;
                maxind = o;
            }
            for (; minind < maxind; minind++)
                sum += a[minind];
            return sum;
        }
        static float multipl_2(int n, float[] a)
        {
            float res = 1, min = float.MaxValue, max = float.MinValue; int minind = 0, maxind = n;
            for (int i = 0; i < n; i++)
            {
                if (max < Math.Abs(a[i]))
                {
                    max = a[i];
                    maxind = i;
                }
                if (min > Math.Abs(a[i]))
                {
                    min = a[i];
                    minind = i + 1;
                }
            }
            if (minind > maxind)
            {
                int o = minind;
                minind = maxind + 1;
                maxind = o - 1;
            }
            for (; minind < maxind; minind++)
                res *= a[minind];
            return res;
        }
    }
}