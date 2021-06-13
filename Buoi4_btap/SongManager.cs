using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_btap
{//quan ly ds bai hat va cac tthao tac trten bai hat
    class SongManager
    {
        //tao DS chua cac bai hat
        private List<Song> lstSong = new List<Song>();


        #region Method
        public string ShowListSong()
        {
            string result = "";
            foreach (Song item in lstSong)
            {
                result += ShowSong(item) + Environment.NewLine;
            }
            return result;
        }
        public string ShowSong(Song item)
        {
            if (item != null)
            {
                return item.Code + " - Bai Hat: " +item.Name +" - "+item.Singer;
                
            }
            return "k co bai hat";
        }

        public Song GetSong(int index)//index trong DS
        {
            if(index > lstSong.Count || index < 0 )
                return null;
            return lstSong[index];
        }
        public Song GetSong(string name)
        {
            foreach (Song item in lstSong)
            {
                if (item.Name.ToUpper().Equals(name) || item.Code.ToUpper().Equals(name) || item.Singer.ToUpper().Equals(name))
                {
                    return item;
                }
            } 
           
            return null;
        }

        public bool RemoveSong(int index)
        {
            try
            {

                //for (int i = index; i < lstSong.Count -1; i++)
                //{
                //    //lstSong[i] = lstSong[i + 1];

                //}

                lstSong.Remove(lstSong[index]);
                //lstSong.RemoveAt(index);
            }
            catch (Exception e)
            {
                return false;
            }
            //finally
            //{ 
            //    //dung hay sai cung thuc hien o day
            //}
            return true;
        }

        public bool InsertSong(string name, string singer)
        {
            try
            {
                lstSong.Add(new Song(name,singer));
            }
            catch (Exception e)
            {

                return false;
            }

            return true;
        }

        public void GennerateSong()
        {
            InsertSong("Noi Tinh Yeu Bat Dau","Bang Kieu");
            InsertSong("Co Chac Yeu La Day", "Son Tung MTP");
            InsertSong("Tinh Lo", "Le Quyen");
            InsertSong("Vang Trang Khoc", "Nhat Tinh Anh");
            InsertSong("Co Be Mua Dong", "Khong Nho");
            InsertSong("Ngay Mai Se Khac", "Hieu");
        }
        #endregion
        //Constructor
        public SongManager()
        {
            GennerateSong();
        }
    }
}
