using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursach
{
    public static class GlobalData
    { 
        public static int LoggedInUserId { get; set; }
        public static AuthorizationForm AuthorizationForm { get; set; }
        public static RegistrationForm RegistrationForm  = new RegistrationForm();
    }
}
