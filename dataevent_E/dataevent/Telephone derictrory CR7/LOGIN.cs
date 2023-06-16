using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project_in_Event
{
    public partial class LOGIN : Form
    {
        public static int varExit=0;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "ELDOON" && txt_Password.Text == "CR7_GOAL")
            {
                this.Close();
            }
            else
            { txt_Username.Text = ""; txt_Password.Text = ""; }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            varExit = 1;
            this.Close();
           
        }

        private void LOGIN_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(400, 233);
        }
    }
}
