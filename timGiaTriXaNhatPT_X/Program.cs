using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timGiaTriXaNhatPT_X
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] a = new int[6];
            KhoiTaoMang(a);
            XuatMang(a);
            
            while (true)
            {
                Console.Write("\nNhap gia tri can tim X: ");
                 int x = int.Parse(Console.ReadLine());
                 isX(a,x);
            }

            Console.ReadLine();
        }
        //Mang: 1 2 3 6 9
        public static void KhoiTaoMang(int[] a)
        
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Moi ban nhap phan tu thu {0}: ", i+1);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void XuatMang(int[] a)
        {
            Console.WriteLine("Mang: ");
            foreach (int item in a)
            {
                if (item != null)
                {
                    Console.Write("{0,4}", item);
                }
            }
        }
        public static void isX(int []a, int x)
        {
            int count = a.Length -1;

            if (!a.Contains(x))
            {
                Console.WriteLine("khong Ton Tai X");
                return;
            }
            //0 1 2 3 4 5 (6)
            // 0 1 2 3 4 (5)
            else
            {
                
            }
            
        }
        
    }
}
