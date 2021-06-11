using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lern_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word");

            Console.Write("moi nhap : ");
            string newStrting;
            newStrting = Console.ReadLine();
            Console.Write(newStrting);

            int a;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\n so a la :{0}", a);
            

            Console.ReadLine();
        }
    }
}
