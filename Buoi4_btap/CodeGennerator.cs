using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_btap
{
    class CodeGennerator
    {
        const int LenghtOfCode = 7;

        //ds code tao ra
        static List<String> GenneratedCode = new List<string>();

        public static string GennerateCode()
        {
            string result = "";
            while (true)
            {
                string code = "";
                //sinh so co 7 ki tu
                Random rand = new Random();
                for (int i = 0; i < LenghtOfCode; i++)
                {
                    code += rand.Next(0,10 );
                }
                // neu code ton tai thi sinh code moi
                if (!GenneratedCode.Contains(code) && code.Length == LenghtOfCode) // neu khong chua doan code trtong DS code va ki tu = 7
                {
                    GenneratedCode.Add(code);
                    result =code;
                    break;

                }
            }
            return result;
        }
    }
}
