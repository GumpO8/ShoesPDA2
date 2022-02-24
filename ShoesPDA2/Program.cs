using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using ShoesPDA2.Forms;

namespace ShoesPDA2
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new frmMain());
            //Application.Run(new frmTest());
        }
    }
}