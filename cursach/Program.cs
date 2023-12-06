using System;
using System.Windows.Forms;

namespace cursach
{
    internal static class Program
    {
     
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
