﻿using System;
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
        public static RegistrationForm ProfileForm  = new RegistrationForm();
        public static RegistrationForm VoteAddForm= new RegistrationForm();
        public static RegistrationForm VoteForm= new RegistrationForm();
        public static RegistrationForm ContactFrom = new RegistrationForm();


    }
}
