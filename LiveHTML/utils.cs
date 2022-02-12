using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LiveHTML
{
    class utils
    {
        public static int ButtonPress { get; set; }
        public static string RetStr { get; set; }

        public static string FixPath(string S)
        {
            if (S.EndsWith("\\"))
                return S;
            return S + "\\";
        }

        public static void StartWeb(string Url)
        {
            Process p = new Process();
            p.StartInfo.FileName = Url;
            p.Start();
        }
    }
}
