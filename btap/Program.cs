using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            KhoiTaoMang(a,n);
            ShowMang(a,n);
            DemSL_PTPhanBiet(a, n);
            
            Console.ReadLine();
        }
        public static void KhoiTaoMang(int []a, int n)
        {
            
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(0, 5);
            }
        }
        public static void ShowMang(int[] a,int n)
        {
            Console.WriteLine("Mang: ");
            //for (int i = 0; i < n; i++)
            //{
            //    if (n > 0) { Console.Write("{0,4}", a[i]); }
                
            //}
            foreach (int item in a)
            {
                if (item != null)
                {
                    Console.Write("{0,4}", item);
                }
            }
        }
        public static void DemSL_PTPhanBiet(int[] a,int n)
        {
            List<int> b = new List<int>();
            foreach (int item in a)
	        {
		        if(!b.Contains(item))
                {
                    b.Add(item);
                }
	        }
            Console.WriteLine("\nSo PT khac nhau cua mang: {0}",b.Count);
            Console.Write("Cac phan tu khac nhau cua mang la : ");
            foreach (int item in b)
            {
                Console.Write("{0,4}",item);
            }
        }
    }
}
