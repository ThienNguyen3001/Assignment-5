using Microsoft.SqlServer.Server;
using System;
using System.Linq;

namespace BaiTap
{
    class Program
    {
        static int[] a;
        static int n;
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
        static bool TuanHoan(int[] a, int n)
        {
            for (int i = n / 2; i >= 1; i--)
            {
                if (n % i == 0)
                {
                    bool check = true;
                    for (int j = i; j < n; j++)
                    {
                        if (a[j] != a[j - i])
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static void BT14(int[] a, int n)
        {
            if (TuanHoan(a, n))
            {
                Console.Write("a la mang tuan hoan");
            }
            else
            {
                Console.Write("a khong la mang tuan hoan");

            }
        }
        
        //Không biết xử lý trường hợp m = 0;
        static void TimTong(int[] a, int m, int start, int[] res, int index)
        {
            if (m == 0)
            {
                for (int i = 0; i < index; i++)
                {
                    Console.Write(res[i] + " ");
                }
                Console.WriteLine();
                return;
                
            }

            for (int i = start; i < a.Length; i++)
            {
                if (a[i] <= m)
                {
                    res[index] = a[i];
                    TimTong(a, m - a[i], i + 1, res, index + 1);
                }
            }
        }
        static void BT15()
        {
            int m = int.Parse(Console.ReadLine());
            int[] combination = new int[a.Length];
            TimTong(a, m, 0, combination, 0);
        }
        static void SangNguyenTo()
        {
            int n = 1000000;
            bool[] a = new bool[n+1];

            for (int i = 2; i <= n; i++)
            {
                a[i] = true;
            }

            for(int i = 2; i <= n; i++)
            {
                if (a[i] == true)
                {
                    for (int j = 2*i; j <= n; j+=i)
                    {
                        a[j] = false;
                    }
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (a[i] == true)
                {
                    Console.Write(i + " ");
                }
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

            //NhapMang(out a, out n);

            SangNguyenTo();

            //XuatMang(a, n);
            
        }
    }
}
