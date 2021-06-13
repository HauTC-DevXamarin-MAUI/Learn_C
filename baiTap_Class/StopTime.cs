using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap_Class
{
    class StopTime
    {
        private int phut = 0;

        public int Phut
        {
            get { return phut; }
            set { phut = value; }
        }
        private int giay = 0;

        public int Giay
        {
            get { return giay; }
            set 
            {
                if (giay == 59)
                {
                    giay = 0;
                    phut++;
                    return;
                }
                giay = value;

            }
        }
        private bool isResume = true;

        //Constructor
        public StopTime()
        {
            Giay = 0;
            Phut = 0;
        }

        // 00:00
        public void ResetTime()
        {
            Phut = 0;
            Giay = 0;
            isResume = true;
        }
        //dem tgian
        public void CountTime()
        {
            if (!isResume)
                return;
            
            Giay++;
        }
        //if remuse => pasue <> remuse
        public void PauseTime()
        {
            isResume = !isResume;
            //=> = !isResume -> Count k chay
        }
        //Hien thi Tgian
        public void ShowTime(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Phut+" Phut "+Giay+" Giay ");
        }
    }
}
