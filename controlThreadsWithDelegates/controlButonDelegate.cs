using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace controlThreadsWithDelegates
{
    public partial class controlButonDelegate : UserControl
    {
        public controlButonDelegate()
        {
            InitializeComponent();
        }
        public Form1 f;
        public Control c;
        private void controlButonDelegate_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.changemaytext(c, this.Name);
            }
            catch { }
        }

        private void controlButonDelegate_Load(object sender, EventArgs e)
        {
            try {
                f = (Form1)ParentForm;
            }
            catch { }
        }
    }
}
