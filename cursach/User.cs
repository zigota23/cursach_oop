using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursach
{
    internal class User
    {
       string email { get; set; }
       string firstName { get; set; }
       string lastName { get; set; }
       int createdQuestions {  get; set; }
       int answeredQuestions {  get; set; }
        public User(string email, string firstName, string lastName, int createdQuestions, int answeredQuestions) {
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.createdQuestions = createdQuestions;
            this.answeredQuestions = answeredQuestions;
        }
    }
}
