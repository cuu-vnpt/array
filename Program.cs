using System;
namespace Array
{
    class Array
    {
        public static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n, sum =0; 

            Console.Write("\nTim tong cac phan tu mang trong C#: \n");
            Console.Write("----------------------------------- \n");

            Console.Write("Nhap so phan tu vao trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang: \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: " , i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.Write("Tong cac phan tu trong mang la: {0}\n\n", sum);
        }
    }
}