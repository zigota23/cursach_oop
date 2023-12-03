using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursach
{
    internal class Vote
    {
        public Guid id {  get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public Vote(Guid id,string title, string description) { 
            this.id = id;
            this.title = title;
            this.description = description;
        }
    }
}
