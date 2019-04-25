using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManager
{
    public partial class accountform : Form
    {
        public accountform()
        {
            InitializeComponent();
        }

        private void Accountform_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            account aform = new account();
            aform.BringToFront();
            
        }
    }
}
