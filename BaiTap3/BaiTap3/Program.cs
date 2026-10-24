using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.Write("Nhap phan tu " + i.ToString() + " :"); mang[i] = int.Parse(Console.ReadLine());
            }
            int tong = 0;
            for(int i=0; i<n; i++)
            {
                tong += mang[i];
            }
            Console.Write("Tong cua mang la: " + tong.ToString());

            int max = mang[0];
            int min = mang[0];

            for(int i=1; i<n; i++)
            {
                if (mang[i] > max) max = mang[i];
                if (mang[i] < min) min = mang[i];
            }
            Console.WriteLine();
            Console.WriteLine("So nguyen lon nhat trong mang la: " + max);
            Console.WriteLine("So nguyen nho nhat trong mang la: " + min);
        }
    }
}
