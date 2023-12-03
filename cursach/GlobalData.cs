using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursach
{
    public static class GlobalData
    { 
        public static Guid LoggedInUserId { get; set; }
        public static AuthorizationForm AuthorizationForm { get; set; }
        public static RegistrationForm RegistrationForm  = new RegistrationForm();
        public static ProfileForm ProfileForm  = new ProfileForm();
        public static VoteAddForm VoteAddForm = new VoteAddForm();
        public static VoteForm VoteForm = new VoteForm();
        public static ContactForm ContactForm = new ContactForm();
        public static ForgotPassword ForgotPassword = new ForgotPassword();

    }
}
