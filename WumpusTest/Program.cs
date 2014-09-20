using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest2010
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
            /*Application.Run(new Form1());     //just for testing
            Application.Run(new Form2());
            Application.Run(new Form3());
            Application.Run(new Form4());*/
            MasterForm master = new MasterForm();
            Application.Run(master);
            Application.Run(new zGameForm(master.getCaveFromMasterForm()));
        }
    }
}
