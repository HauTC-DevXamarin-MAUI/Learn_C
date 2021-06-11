using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4_Struct_Enum_Class
{
    class Program
    {
        #region Struct
        //struct Books
        //{
        //    public string _Name;
        //    public string _Status;
        //    public bool _isMarried;

        //    public void _Books()
        //    {
        //        _Name = "Hau";
        //        _Status = "Dep Trai";
        //        _isMarried = false;
        //    }
        //};// struct k co protected
        #endregion
        static void Main(string[] args)
        {
            #region Struct
            ////Struct
            ////Books ohyeah;

            ////hyoeah._Name = "Hau";

            //Books ab =new Books();
            //ab._Books(); 

            //Console.WriteLine("{0}|{1}|{2}",ab._Name,ab._Status,ab._isMarried);
            //Console.ReadLine();
            #endregion
            //--------------------------------------------------
            #region Enum
            ////Enum
            //Console.WriteLine(DayOfWeek.thuba);
            //Console.WriteLine((int)DayOfWeek.thuba);
            //Console.ReadLine();
            #endregion
            //-----------------------------------------------------
            #region Class
            //Class
            Box box1 = new Box();
            Box box2 = new Box();
            double volume;

            box1.setLenght(6.5);
            box1.setBreadth(7);
            box1.setHeight(8);

            box2.setLenght(8);
            box2.setBreadth(9);
            box2.setHeight(8);

            volume = box1.getvolume();
            Console.WriteLine("Volume of box1 is: {0}", volume);


            volume = box2.getvolume();
            Console.WriteLine("Volume of box2 is: {0}", volume);
            Console.ReadLine();
            #endregion
            
        }
        #region Enum
        ////Enum
        ////Ton it dung luong
        ////la 1 kieu du lieu liet ke
        ////n giong nhu kieu du lieu Hang
        //enum DayOfWeek
        //{
        //    thuhai,
        //    thuba,
        //    thutu,
        //    thunam,
        //    thusau,
        //    t7,
        //    cn
        //};
        #endregion

        //----------------------------------[
        #region Class
        //Class
        class Box
        {
            private double lenght;
            private double breadth;
            private double heigth;

            public void setLenght(double len)
            {
                lenght = len;
            }
            public void setBreadth(double bre)
            {
                breadth = bre;
            }
            public void setHeight(double hei)
            {
                heigth = hei;
            }

            public double getvolume()
            {
                return lenght * breadth * heigth;
            }
        }
        #endregion
        


    }
}
