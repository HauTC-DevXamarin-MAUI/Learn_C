using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_btap
{
    class Program
    {
        static AppController app = new AppController();
        static void Main(string[] args)
        {

            //app.ShowListSong();
            //Menu();
            while (true)
            UserCommand();
            Console.ReadLine();
        }

        static void UserCommand()
        {
            Console.WriteLine("Moi ban nhap: ");
            string command = Console.ReadLine();
             // ng dung gui yeuc au cho he thong
            app.GetCommand(command);

            //He thong tra ve thong bao
            string systemMassage = app.SentCommand();

            //Xuatt ra thong bao
            Console.WriteLine(systemMassage);
        }
    }
}
