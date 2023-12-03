using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursach.controls
{
    public partial class VoteItem : UserControl
    {

        public string title;
        public string description;
        public VoteItem(string title,string description)
        {
            InitializeComponent();
            titleLabel.Text = title;    
            descriptionLabel.Text = description; 
            
            this.title = title; 
            this.description = description;
        }
    }
}
