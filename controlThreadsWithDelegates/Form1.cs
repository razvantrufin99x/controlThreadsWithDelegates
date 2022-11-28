using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace controlThreadsWithDelegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void changemytextdelegate(Control ctrl, string text);
        
        private void Form1_Load(object sender, EventArgs e)
        {
            controlButonDelegate1.c = label1;
            controlButonDelegate2.c = label2;
            controlButonDelegate3.c = label3;
            controlButonDelegate4.c = label4;
            controlButonDelegate5.c = label5;
            controlButonDelegate6.c = label6;

        }


        public static void changemaytext(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                changemytextdelegate del = new changemytextdelegate(changemaytext);
                ctrl.Invoke(del, ctrl, text);
            }
            else
            {
                ctrl.Text = text;
            }
        }


    }
}
