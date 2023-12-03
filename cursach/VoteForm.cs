using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursach
{
    public partial class VoteForm : Form
    {
        
        public VoteForm(Guid voteId,string title,string description)
        {
            InitializeComponent();
            titleLabel.Text = title;
            descriptionLabel.Text = description;
        }

    }
}
