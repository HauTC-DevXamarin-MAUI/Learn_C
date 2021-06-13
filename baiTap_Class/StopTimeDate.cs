using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap_Class
{
    class StopTimeDate
    {
        DateTime oldTime;
        DateTime newTime;
        TimeSpan currentTime;
        bool isResume = true;
        public StopTimeDate()
        {
            oldTime = DateTime.Now;
            newTime = DateTime.Now;
        }

        public void Start()
        {
            oldTime = DateTime.Now;
            Count();
        }
        public void Reset()
        {
            oldTime = DateTime.Now;
        }
        public void Pause()
        {
            isResume = !isResume;
        }
        public void Show(int x,int y)
        {
            Console.SetCursorPosition(35, 20);
            Console.WriteLine(currentTime.Minutes + " Phut " + " : "+currentTime.Seconds+" Giay " );
        }
        public void Count()
        {
            if (!isResume)
                return;
            newTime = DateTime.Now;
            
            currentTime=newTime-oldTime;
        }
    }
}
