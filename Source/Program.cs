//NetToggle
//Michael Adams, unquietwiki.com, Oct 3, 2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NetToggle
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
