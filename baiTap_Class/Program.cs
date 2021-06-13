using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace baiTap_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            ////C2
            //StopTimeDate stopTWatch = new StopTimeDate();
            //stopTWatch.Start();
            //while (true)
            //{
            //    Thread.Sleep(1000);
            //    stopTWatch.Count();
            //    stopTWatch.Show(10,35);
            //}

            //C1
            StopTime stopWatch = new StopTime();
            int count = 0;
            int sleepTime = 100 ;
            int showTime = 1000;
            while (true)
            {
                Thread.Sleep(sleepTime);

                if (Console.KeyAvailable)
                {
                   
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key.Equals(ConsoleKey.R))
                    {
                        
                        stopWatch.ResetTime();

                    }
                    if (key.Key.Equals(ConsoleKey.Spacebar))
                    { 
                        stopWatch.PauseTime();
                    }

                }
                if (count % showTime == 0)
                {      
                    stopWatch.CountTime();
                    stopWatch.ShowTime(35, 15);
                }
                count += sleepTime;
            }


            
            Console.ReadLine();
        }
    }
}
