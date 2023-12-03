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
        public VoteItem(string title,string descripiton)
        {
            InitializeComponent();
            titleLabel.Text = title;    
            descriptionLabel.Text = descripiton;    
        }
    }
}
