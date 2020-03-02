using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NgoHao =  System.Windows.Forms;

namespace Chapter1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NgoHao.Application.EnableVisualStyles();
            NgoHao.Application.SetCompatibleTextRenderingDefault(false);
            NgoHao.Application.Run(new Form1());
        }
    }
}
