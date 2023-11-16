using System;

namespace BaiTap
{
    class Program
    {
        static int[] a;
        static int[,] matrix;
        static int n;
        static int col;
        static int row;

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
            int[] result = new int[a.Length];
            TimTong(a, m, 0, result, 0);
        }
        static void SangNguyenTo()
        {
            int n = 1000000;
            bool[] a = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                a[i] = true;
            }

            for (int i = 2; i <= n; i++)
            {
                if (a[i] == true)
                {
                    for (int j = 2 * i; j <= n; j += i)
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
        static void InTapConBai5(int phanTu, int n, int k, int[] result)
        {
            if (phanTu == k)
            {
                XuatMang(result, k);
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                result[phanTu] = i;
                InTapConBai5(phanTu + 1, n, k, result);
            }
        }
        static void BT_O_Lop_5()
        {
            int n, k;

            Console.Write("Nhap so n : ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Nhap so k : ");
            k = int.Parse(Console.ReadLine());

            int[] result = new int[k];

            InTapConBai5(0, n, k, result);
        }
        static void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }

        static void NhapMaTran(ref int[,] matrix, ref int row, ref int col)
        {
            Console.Write("Nhap vao so dong : ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so cot : ");
            col = int.Parse(Console.ReadLine());

            matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void XuatMaTran(int[,] matrix, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

        }
        static void BT16()
        {
            NhapMaTran(ref matrix, ref row, ref col);
            int max = matrix[0, 0], min = matrix[0, 0];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (max < matrix[i, j])
                        max = matrix[i, j];
                    if (min > matrix[i, j])
                        min = matrix[i, j];
                }
            }
            Console.WriteLine($"Gia tri lon nhat la : {max}");
            Console.WriteLine($"Gia tri nho nhat la : {min}");

        }
        static bool DoiXung(int[,] matrix, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                        return false;
                }
            }
            return true;
        }
        static void BT17()
        {
            NhapMaTran(ref matrix, ref row, ref col);
            XuatMaTran(matrix, row, col);
            if (DoiXung(matrix, row, col))
            {
                Console.WriteLine("Day la ma tran doi xung");
            }
            else { Console.WriteLine("Day la ma tran ko doi xung"); }
        }
        static void BT19()
        {
            NhapMaTran(ref matrix, ref row, ref col);
            Console.WriteLine("Ma tran chuyen vi la : ");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matrix[j, i]} ");
                }
                Console.WriteLine();
            }
        }
        static void BT20()
        {
            NhapMaTran(ref matrix, ref row, ref col);
            Console.WriteLine("Ma tran phan chieu la : ");

            for (int i = 0; i < row; i++)
            {
                for (int j = col - 1; j >= 0; j--)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void BT21()
        {
            int[,] A;
            int[,] B;

            Console.Write("Nhap vao so hang cua ma tran : ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so cot hang cua ma tran : ");
            col = int.Parse(Console.ReadLine());
            A = new int[row,col];
            for (int i = 0;i < row; i++)
            {
                for (int j = 0;j < col; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            B = new int[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"B[{i},{j}] = ");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ma tran C = A+B la : ");
            int[,] C = new int[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    C[i,j] = A[i,j] + B[i,j];
                    Console.Write($"{C[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void BT22()
        {
            int rowA, colA, colB;
            int[,] A;
            int[,] B;

            Console.Write("Nhap so hang cua A : ");
            rowA = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cua A (la so hang B): ");
            colA = int.Parse(Console.ReadLine());
            A = new int[rowA, colA];
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colA; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Nhap so cot cua B : ");
            colB = int.Parse(Console.ReadLine());
            B = new int[colA, colB];
            for (int i = 0; i < colA; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    Console.Write($"B[{i},{j}] = ");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ma tran A nhan B la : ");
            int[,]C = new int[rowA,colB];
            for (int i = 0;i < rowA; i++)
            {
                for(int j = 0;j < colB; j++)
                {
                    for (int k = 0; k <  colA; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                    Console.Write($"{C[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            BT22();

            Console.ReadKey();
        }
    }
}
