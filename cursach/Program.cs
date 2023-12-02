using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursach
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            DataBase.CreateTables();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AuthorizationForm form = new AuthorizationForm();
            GlobalData.AuthorizationForm = form;

            Application.Run(GlobalData.AuthorizationForm);
        }
    }
}
