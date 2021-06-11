using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_btap
{
    class Song
    {
        #region propertites
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string singer;

        public string Singer
        {
            get { return singer; }
            set { singer = value; }
        }
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        #endregion
        #region constructor
        public Song()
        { }
        public Song(string name, string singer)
        {
            this.name = name;
            this.singer = singer;
            //tu sinh code
            code = CodeGennerator.GennerateCode();
        }

        #endregion


    }
}
