using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTtapClass
{
    class Program
    {
        static void Main(string[] args)
        {
            AppQuanLyThuChi();
            Console.ReadLine();
        }
        static void AppQuanLyThuChi()
        {
            QuanLyThuChi app = new QuanLyThuChi(1000000);
            while (true)
            {
                
                app.ShowMenu();
                app.Usercommand();
            }

        }
    }
}
