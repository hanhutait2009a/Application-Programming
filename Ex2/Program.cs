using System;

namespace Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str1; 
            string chuoi_con; 
            Console.Write("\nTim vi tri chuoi con trong C#:\n");
            Console.Write("---------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str1 = Console.ReadLine();

            Console.Write("Nhap chuoi con can tim kiem: ");
            chuoi_con = Console.ReadLine();
            int vi_tri = str1.IndexOf(chuoi_con);
            if (vi_tri < 0)
                Console.WriteLine("Khong tim thay chuoi con trong chuoi da cho!\n");
            else
                Console.WriteLine("Tim thay chuoi con '{0}' trong chuoi '{1}' tai vi tri {2}",
                    chuoi_con, str1, vi_tri); 

            Console.ReadKey();
        }
    }
}