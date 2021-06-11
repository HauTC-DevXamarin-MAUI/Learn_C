using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Else_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //maxBaSo();
            //luyThua_X_Y();
            //Money();
            //Menu();
            //SNT();
            //Mang();
            //MangVaGTLN();
            //ThucHienDeleteA();
            ThucHienInChuoi();
            //cau11();
            //MaHoa();
            Console.ReadLine();
        }


        #region viet ham tim max cua 3 so
        static float Max(float a, float b)
        {
            return a>b?a:b;
        }
        static void maxBaSo()
        {
            float a, b, c;
            Console.WriteLine("Nhap 3 so di em: ");
            Console.Write("Nhap a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = float.Parse(Console.ReadLine());

            float max = Max(a,Max(b,c));

            Console.WriteLine("So lon nhat trong {0}|{1}|{2} la: {3}",a,b,c,max);
        }
        #endregion

        #region Tinh x^y
        static long LuyThua(int x, int y)
        {
            //x^0 = 1
            //x^1 = x
            //x^2=x*x
            long result = 1;
            for (int i = 1; i <= y; i++)
            {
                result *= x; ;
            }
            return result;
        }
        static void luyThua_X_Y()
        {
            int x,y;
            Console.WriteLine("Nhap x va y");
            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = int.Parse(Console.ReadLine());

            long luyThua = LuyThua(x, y);

            Console.WriteLine("Luy thua {0}^{1} la: {2}",x,y,luyThua);
        }
        #endregion

        #region có 5 loại tiền 1000,2000,5000,10000,20000 , xuất ra có bao nhiêu cách để có đc số tiền N  từ 5 loại ttieenf trên
        static void Money()
        {
            
            long N;
            int M1 = 1000;
            int M2 = 2000;
            int M5 = 5000;
            int M10 = 10000;
            int M20 = 20000;
            Console.Write("Nhap so tien: ");
            N = long.Parse(Console.ReadLine());

            int count = 0;

            for(int i =0 ;i<= N/M1; i++){
                for (int j = 0; j <= N / M2; j++)
                {
                    for (int l = 0; l <= N / M5; l++)
                    {
                        for (int m = 0; m <= N / M10; m++)
                        {
                            for (int n = 0; n <= N / M20; n++)
                            {
                                if (i * M1 + j * M2 + l * M5 + m * M10 + n * M20 == N)
                                {
                                    count++;
                                    Console.WriteLine("Dung {0} to {1} || {2} to {3} || {4} to {5} ||{6} to {7}|| {8} to {9} de duoc {10}", i, M1, j, M2, l, M5, m, M10, n, M20, N);
                                }
                            }
                        }
                    }
                }
                            }
            Console.Write("co bao nhiu cach :{0} ",count);
        }
        #endregion

        #region lam menu
        static void Menu()
        {

            Console.WriteLine("\t\t\tMenu");
            Console.WriteLine("\t1.tim Max cua ba so");
            Console.WriteLine("\t2.Tinh x^y");
            Console.WriteLine("\t3. có 5 loại tiền 1000,2000,5000,10000,20000 , xuất ra có bao nhiêu cách để có đc số tiền N  từ 5 loại ttieenf trên");
            Console.WriteLine("\t4. Exit");
            Console.Write("Moi nhap lua chon cua ban: ");

            

            bool goSai = false;
            while (!goSai)
            {
                string usercmt = Console.ReadLine();
                switch (usercmt)
                {
                    case "1":
                        goSai = true;
                        maxBaSo();
                        Menu();
                        break;
                    case "2":
                        goSai = true;
                        luyThua_X_Y();
                        break;
                    case "3":
                        goSai = true;
                        Money();
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("go lai");
                        break;
                }
            }

        }
        #endregion

        #region dung Ham tim SNT < so nguyen N

        static bool isSNT(int a)
        {
            if (a < 2)
                return false;
            if (a == 2)
                return true;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void SNT()
        {
            int n;
            Console.Write("Nhap so N: ");
            n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (isSNT(i))
                {
                    Console.WriteLine("{0} la so nguye to",i);
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        #endregion

        #region Tao Mang tu 0 den 69

        static void KhoiTaoMang(int [,]a)
        {
            Random rand = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rand.Next(0,70);
                }
            }
        }
        static void XuattMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0,4}",a[i,j]);
                }
            }
        }
        static void Mang()
        {
            int[,] a=new int [20,20];
            KhoiTaoMang(a);
            XuattMang(a);
        }
        #endregion

        #region tao Mang thuc 20x20 , Xuatt Mang va gia tri lon nhat dong
        static void KhoiTaoMangNgauNhien(int[,] a)
        {
            Random rand = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rand.Next(0, 101);
                }
            }
        }
        static void XuattMangNgauNhien(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", a[i, j]);
                }
            }
        }
        static void TimSLNDong(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    max = a[i, j] > max ? a[i, j] : max;
                }
                Console.WriteLine("Max cua Dong {0} la: {1}",i,max);
            }
        }
        static void MangVaGTLN()
        {
            int [,]a = new int[20,20];
            KhoiTaoMangNgauNhien(a);
            XuattMangNgauNhien(a);
            Console.WriteLine("\n");
            TimSLNDong(a);

        }
        #endregion

        #region Viet ham bo 1 ky ttu 'a' trtong chuoi
        static void DeletetA (ref string a)
        {
            //C1
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == 'a')
                    {
                        a = a.Remove(j, 1);
                    }
                }
            }
        }
        static void ThucHienDeleteA()
        {
            string a = "";
            Console.WriteLine("Moi ban nhao chuoi: ");
            a = Console.ReadLine();
            DeletetA( ref a);
            Console.WriteLine(a);
        }
        #endregion

        #region nhap 1 chuoi, inc ac ttu moi chuoi trten tung dong
        static void InChuoiTrenTungDong(ref string a)
        {
            string[] newA = a.Split(' '); //catt chuoi dua tren khoang trang ' '
            a = "";
            foreach (string item in newA)
            {
                a += item + Environment.NewLine; // hoac  a += item + '\n';
            }
        }
        static void ThucHienInChuoi()
        {
            string a = "";
            Console.Write("CMoi ban nhap chuoi: ");
            a = Console.ReadLine();
            InChuoiTrenTungDong(ref a);
            Console.WriteLine("Chuoi moi la:\n {0}",a);
            
        }

        #endregion

        #region Cau 11. Viet ctrinh ktra chuoi co doi xung hay k
        static bool isKtraChuoiDoiXung(string a)
        {
            for (int i = 0; i <= a.Length/2; i++)
            {
                if (a[i] != a[a.Length - 1- i])
                    return false;
            }

            return true;
        }

        static void cau11()
        {
            string a;
            Console.Write("Hay nhap chuoi a: ");
            a=Console.ReadLine();
            if (isKtraChuoiDoiXung(a))
            {
                Console.WriteLine(a+ "\tLA chuoi doi xung");
            }
            else
                Console.WriteLine(a+ "\tKHONG la chuoi doi xung");
        }
        #endregion

        #region Cau 12. Ma Hoa 0->A .... 9 -> J
        static void MaHoa()
        {
            Console.Write("Nhap Chuoi Can Ma Hoa: ");
            string s = Console.ReadLine();
            //giai ma
            string chuoiDaGiaiMa = "";
            for (int i = 0; i < s.Length; i++)
            {
                chuoiDaGiaiMa += (char)((int)s[i]+17);// 65-48=17.. 65=A ,48=0
            }
            //XUat
            Console.WriteLine(chuoiDaGiaiMa);
        }
        #endregion
    }
}
