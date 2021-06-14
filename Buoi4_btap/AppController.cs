using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_btap
{
    class AppController
    {
        //QL bai hat
        SongManager songMN = new SongManager();

        enum SMS
        { DK,TK,BH};
//
        private string usercommand;

        public string Usercommand
        {
            get { return usercommand; }
            set { usercommand = value; }
        }
      //
        //
        public void GetCommand(string command)
        {
            Usercommand = command;

        }

    //
        public string SentCommand()
        {
            // lay ra tu dau ttien de biet se lam thao tac gi

            //vd: tk all
            //=> tetmp[0] = tk
            //=> tetmp[1] = all
            string[] temp = new string[2];
            if (!Usercommand.Contains(' '))
            {
                //abc
                //=>stemp[0]=abc
                //=>stemp[1]=""
                temp[0] = Usercommand.ToUpper();
                temp[1] = "";
            }
            else
            {

                temp[0] = Usercommand.Substring(0, Usercommand.IndexOf(' '));
                temp[1] = Usercommand.Substring(Usercommand.IndexOf(' ') + 1);//bvcbvc bvfsg/ +1 vi lui 1 kitu khoantrang
            }
                string cmd = temp[0].ToUpper();
                if (cmd.Equals("BH"))
                {
                    if (temp[1] != null)
                    {
                        return BH(temp[1].ToUpper());
                    }
                }
                else if (cmd.Equals("DK"))
                {
                    if (temp[1] != null)
                    {
                        return DK(temp[1].ToUpper());
                    }
                }
                else if (cmd.Equals("TK"))
                {
                    if (temp[1] != null)
                    {
                        return TK(temp[1].ToUpper());
                    }
                }
            
                return WrongCommand();
            
        }
        string WrongCommand()
        {
            return "Sai cu phap, nhap lai di may! ";
        }

        string DK(string command)
        {
            if (command.ToUpper().Equals("VIP"))
            {
                return "ban da dk goi VIP Imuzik thanh cong roi do";
            }
            else if (command.ToUpper().Equals("IMUZIK") || command.ToUpper().Equals(""))
            {
                return "ban da dk goi Imuzik thanh cong roi do";
            }
           
            return "Ban nhap sai roi";
        }
        string TK(string command)
        {
            if (command.ToUpper().Equals("ALL"))
            {
                return songMN.ShowListSong();
            }
            else
            {
                Song newSong = songMN.GetSong(command);
                return songMN.ShowSong(newSong);

            }
            return "ten bh k ton tai";
        }
        string BH(string command)
        {

            Song newSong = songMN.GetSong(command);
            if (newSong != null)
            {
                return "Bai Hat: " + newSong.Name + " - " + newSong.Singer + " \nDa dk thanh cong!";
            }

            return "ma bh k ton tai";
        }


    }
}
