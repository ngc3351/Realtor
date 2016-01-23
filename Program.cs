using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Realtor.Dialogs;

namespace Realtor
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

            //Realtor.Services.Utils.Deserialize<ObjSale>(File.ReadAllText("C:/656ED0B.xml"));
            //return;
            DbRun.Run();
            Application.Run(new MainForm());
            DbRun.Stop();
        }
    }

}