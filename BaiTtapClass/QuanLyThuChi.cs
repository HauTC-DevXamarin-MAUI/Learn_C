using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTtapClass
{
    class QuanLyThuChi
    {
        private float tongTien;
        public float TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        private List<String> mucChiTieu;
        public List<String> MucChiTieu
        {
            get { return mucChiTieu; }
            set { mucChiTieu = value; }
        }


        private List<ThongTinChiTien> danhSachChi;
        private List<ThongTinChiTien> DanhSachChi
        {
            get { return danhSachChi; }
            set { danhSachChi = value; }
        }


        public QuanLyThuChi(float tien)
        {
            TongTien = tien;
            DanhSachChi =new List<ThongTinChiTien>();
            MucChiTieu = new List<string>() {"Di cho","Quy Den","Mua Sam","Da ga","Khac" };
        }

        class ThongTinChiTien
        {
            public string mucChiTieu;
            public string lyDo;
            public float soTienDaChi;
           

            public ThongTinChiTien(string mucChi, float tien, string lyDo)
            {
                this.mucChiTieu = mucChi;
                this.soTienDaChi = tien;
                this.lyDo = lyDo;
               
            }
        }
        // luon luon cong len
        public void CapNhatTongTien(float tien)
        {
            TongTien += tien;
        }
        //Xem So tien trong Tk
        public void XemSoTienTrongTK()
        {
            Console.WriteLine("Tai Khoan cua KH con: "+TongTien+" VND");
        }

        //Show ra cac khoan chi
        public void XemCacKhoanDaChi(string mucChiTieu1=null)
        {
            Console.WriteLine("Chi Cho:{0} ", mucChiTieu1 ?? null);
            foreach (ThongTinChiTien item in DanhSachChi)
            {
                if (item != null && (mucChiTieu1==null||(mucChiTieu1!=null&&item.mucChiTieu.Equals(mucChiTieu1)) ))
                {
                    Console.WriteLine("{0} | {1} | {2}",item.mucChiTieu,item.soTienDaChi,item.lyDo);
                }
            }
        }
        //public void XemCacKhoanDaChi()
        //{
        //    foreach (ThongTinChiTien item in DanhSachChi)
        //    {
        //        if (item != null)
        //        {
        //            Console.WriteLine("Chi: "+item.mucChiTieu+" - So Tien: "+item.soTienDaChi+" VND"+" - Voi Ly Do:"+item.lyDo);
        //        }
        //    }
        //}

     

        public void ChiTien(string mucChi,float soTienCanChi,string lyDo=null)
        {
            if (tongTien - soTienCanChi < 0)
            {
                Console.WriteLine("Khong the chi qua so tien con lai trog tk");
                return;
            }
            else
            {
                ThongTinChiTien newChi = new ThongTinChiTien(mucChi,soTienCanChi,lyDo);
                DanhSachChi.Add(newChi);

                tongTien -= soTienCanChi;

                Console.WriteLine("Da chi cho viec {0} thanh cong. So tien {1}. Ly do: {2}. ",mucChi,soTienCanChi,lyDo);
                XemSoTienTrongTK(); 

            }
        }

        //cap nhat so titen trong tk
        public void CapNhattSoTienTrongTTk()
        {
            float tienInt = 0;
            while (true)
            {
                Console.Write("nhap so tien can dua vao tk: ");
                string tien = Console.ReadLine();

                if (float.TryParse(tien, out tienInt))
                {
                    TongTien += tienInt;
                    XemSoTienTrongTK();
                    return;
                }
                else
                {
                    Console.WriteLine("So tien khong hop le, vui long nhap lai");
                } 
            }
            
        }
        //
        public void XemCacKhoanDaChiUserTheoMuc()
        {            
            
            XemCacKhoanDaChi(ShowMuc());
        }
        string ShowMuc()
        {
            //Xuat ra ds muc chi
            Console.WriteLine("Chon muc can xem: ");
            int j = 0;
            foreach (string item in MucChiTieu)
            {
                j++;
                Console.WriteLine(j + ". " + item);
            }
            Console.Write("nhap muc can xem: ");
            string userCommand = Console.ReadLine();
            int i;
            string mucluachon = "";

            if (Int32.TryParse(userCommand, out i) && i >= 0 && i < MucChiTieu.Count)
            {
                mucluachon = MucChiTieu[i - 1];
            }
            else
            {
                Console.WriteLine("Muc lua chon sai");
            }
            return mucluachon;
        }
        //
        public void ChiTienUser()
        {
            string mucChi = ShowMuc();
            Console.Write("So ttien can chi: ");
            string tien = Console.ReadLine();
            float soTien=0;
            if (!float.TryParse(tien, out soTien))
            {
                Console.WriteLine("nhap so tien sai");
                return;
            }
           
            Console.Write("ly do: ");
            string lyDo = Console.ReadLine();
            Console.Write("\n ");
            ChiTien(mucChi,soTien,lyDo);


        }

        //show menu
        public void ShowMenu()
        {
            string Menu = "\n\t Phan Mem QLThuChi"
                +Environment.NewLine
                +"1. Xem tong tien"
                + Environment.NewLine
                + "2. Cap Nhat so titen trong tk"
                + Environment.NewLine
                + "3. Xem cac khoan da chi"
                + Environment.NewLine
                + "4. Xem da chi theo muc"
                + Environment.NewLine
                + "5. chi tien"
                ;

            Console.WriteLine(Menu);
        }
        //User Command
        public void Usercommand()
        {
            Console.Write("\n moi ban nhap lua chon: ");
            string command = Console.ReadLine();
            Console.Clear();
            switch (command)
            {
                case"1":
                    XemSoTienTrongTK();
                    break;
                case "2":
                    CapNhattSoTienTrongTTk();
                    break;
                case "3":
                    XemCacKhoanDaChi();
                    break;
                case "4":
                    XemCacKhoanDaChiUserTheoMuc();
                    break;
                case "5":
                    ChiTienUser();
                    break;
                default:
                    Console.Write("Vui long nhap dung gia tri trong menu");
                    break;
            }
        }
    }
}
