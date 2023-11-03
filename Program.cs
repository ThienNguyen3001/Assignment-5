using Microsoft.SqlServer.Server;
using System;
using System.Linq;

namespace BaiTap
{
    class Program
    {
        static void NhapMang(out int[] a, out int n)
        {
            Console.WriteLine("Nhap so luong phan tu : ");
            n = int.Parse(Console.ReadLine());

            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }

        }
        static int Max(int[] a, int n)
        {
            int max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }

            return max;
        }
        static int Min(int[] a, int n)
        {
            int min = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }

            return min;
        }
        static void BT1(int[] a, int n)
        {
            int max = Max(a, n), min = Min(a, n);
            Console.WriteLine($"max : {max}\nmin : {min}");
        }
        static void BT2(int[] a, int n)
        {
            Console.WriteLine("Nhap so nguyen x : ");
            int x = int.Parse(Console.ReadLine());

            foreach (int i in a)
            {
                if (i == x)
                {
                    Console.WriteLine($"{x} trong mang a");
                    return;
                }
            }
            Console.WriteLine($"{x} khong trong mang a");
        }
        static void BT3(int[] a, int n)
        {
            Console.WriteLine("Nhap so nguyen x : ");
            int x = int.Parse(Console.ReadLine());

            int dau = 0;

            Console.Write($"Vi tri cac phan tu bang {x} la : ");
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    Console.Write($"{i} ");
                    dau = 1;
                }
            }

            if (dau == 0)
            {
                Console.WriteLine($"-1");
            }

        }
        static void BT4(int[] a, int n)
        {
            int x;
            Console.Write("Nhap x : ");

            x = int.Parse(Console.ReadLine());

            int s = 0;

            for (int i = 0; i < n; i++)
            {
                s += (a[i] * (int)Math.Pow(x, i));
            }
            Console.WriteLine($"Ket qua la : {s}");
        }
        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void BT5(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
        static void BT6(int[] a, int n)
        {
            int soDuong = 0, soAm = 0, tongDuong = 0, tongAm = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    soDuong++;
                    tongDuong += a[i];
                }
                else
                {
                    soAm++;
                    tongAm += a[i];
                }
            }
            Console.WriteLine($"So am : {soAm} , tong so am : {tongAm}");
            Console.WriteLine($"So duong : {soDuong} , tong so duong {tongDuong}");

        }
        static void BT7()
        {
            int n;
            Console.WriteLine("Nhap so n : ");
            n = int.Parse(Console.ReadLine());

            int[] fib = new int[n];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            Console.WriteLine($"{n} so hang fibonacci dau tien la : ");

            foreach (int i in fib)
            {
                Console.Write($"{i} ");
            }
        }
        static void BT8()
        {
            int[] _31ngay = { 0, 1, 3, 5, 7, 8, 10, 12 };
            int[] _30ngay = { 0, 4, 6, 9, 11 };

            Console.WriteLine("Nhap vao thang t : ");
            int t = int.Parse(Console.ReadLine());

            if (t == 2)
            {
                Console.WriteLine($"Thang {t} co 28 ngay");
            }
            else if (t > 12 || t < 1)
            {
                Console.WriteLine($"Thang {t} khong hop le");
            }
            else
            {
                if (_30ngay.Contains(t))
                {
                    Console.WriteLine($"Thang {t} co 30 ngay");
                }
                else
                    Console.WriteLine($"Thang {t} co 31 ngay");

            }
        }
        static void XuatMang(int[] a, int n)
        {
            foreach (int i in a)
            {
                Console.WriteLine($"{i} ");
            }
        }


        static void Main(string[] args)
        {
            int[] a;
            int n;

            //NhapMang(out a, out n);

            BT8();

            //XuatMang(a, n);
        }
    }
}
