using System;

namespace cursach
{
    public static class GlobalData
    { 
        public static Guid LoggedInUserId { get; set; }
        public static AuthorizationForm AuthorizationForm { get; set; }
        public static RegistrationForm RegistrationForm  = new RegistrationForm();
        public static MainApp MainApp  = new MainApp();



        public static void LogOut()
        {
            LoggedInUserId = Guid.Empty;
            MainApp.Hide();
            AuthorizationForm.Show();
        }

    }
}
