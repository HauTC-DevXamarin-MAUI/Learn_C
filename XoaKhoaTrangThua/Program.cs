using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoaKhoaTrangThua
{
    class Program
    {
        // "   hau dep trai   qua di  " =>"hau dep trai qua di"
        static void Main(string[] args)
        {
            string s = " Hau  Dep       Choai     Qua DI   Thoi   ";
            //Console.WriteLine("Chuoi hien tai la: {0}", s);
            //XoaKhoangTrangThua(s);
            InXuongDong(s);
            Console.ReadLine();
        }
        static void XoaKhoangTrangThua(string s)
        {
            string s1 = s.Trim();
            
            for (int i = 0;i < s1.Length; i++)
            {
                if (s1[i].Equals(' '))
                {
                    if (s1[i + 1].Equals(' '))
                    {
                        s1 = s1.Remove(i,1);
                        i --;
                    }
                }
            }
            Console.WriteLine("Chuoi s khi Xoa khoan trang: {0}\n ",s1);
            int x;
            
        }
        static void InXuongDong(string s)
        {
            int x, y, i;
            x = Console.CursorLeft;
            y = Console.CursorTop;
            i = y;

            foreach (char item in s)
            {
                Console.SetCursorPosition(x,i);
                Console.Write(item);
                if (item.Equals(' '))
                {
                    i =y;
                }
                else
                {
                    i++;
                }
                x++;
            }
        }
    }
}
