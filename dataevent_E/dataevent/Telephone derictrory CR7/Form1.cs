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
    public partial class frm_contact : Form
    {
        public frm_contact()
        {
            InitializeComponent();
        }
        private void unvis()
        {
            button_Add_Woc.Visible = false;
            button_Delete_Number_Woc.Visible = false;
        }
        private void vis()
        {
            button_Add_Woc.Visible = true;
            button_Delete_Number_Woc.Visible = true;
            
        }
        public static string varnumber2;
        private void frm_contact_Load(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();  
             
            lOGIN.ShowDialog();
            if(LOGIN.varExit==1)
            { this.Close(); }



            unvis();
        }

        private void button_EXIT_WOC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_NUMBER_TextChanged(object sender, EventArgs e)
        {
            if (txt_Number.Text=="")
            {
                unvis();
            }
            else
            {
                vis();
            }
        }

        private void button_ZERO_WOC_Click(object sender, EventArgs e)
        {
            txt_Number.Text = txt_Number.Text+"0";
        }

        private void button_7_WOC_Click(object sender, EventArgs e)
        {
            txt_Number.Text = txt_Number.Text+"7";
        }

        private void button_8_WOC_Click(object sender, EventArgs e)
        {
            txt_Number.Text = txt_Number.Text+"8";
        }

        private void button_9_WOC_Click(object sender, EventArgs e)
        {
            txt_Number.Text = txt_Number.Text+"9";
        }

        private void button_6_WOC_Click(object sender, EventArgs e)
        {
            txt_Number.Text = txt_Number.Text+"6";
        }

        private void button_5_WOC_Click(object sender, EventArgs e)
        {
            txt_Number.Text = txt_Number.Text+"5";
        }

        private void button_4_WOC_Click(object sender, EventArgs e)
        {
            txt_Number.Text = txt_Number.Text+"4";
        }

        private void button_1_WOC_Click(object sender, EventArgs e)
        {
            txt_Number.Text = txt_Number.Text+"1";
        }

        private void button_2_WOC_Click(object sender, EventArgs e)
        {
            txt_Number.Text = txt_Number.Text+"2";
        }

        private void button_3_WOC_Click(object sender, EventArgs e)
        {
            txt_Number.Text = txt_Number.Text+"3";
        }

        private void button_DELETE_NUMBER_WOC_Click(object sender, EventArgs e)
        {
            string s1 = "", s = txt_Number.Text;
            for (int i = 0; i<s.Length-1; i++) { s1+=s[i]; }
            txt_Number.Text=s1;
        }

        private void button_ADD_WOC_Click(object sender, EventArgs e)
        {

            try
            {
                if (int.Parse(txt_Number.Text)<1000000000)
                    MessageBox.Show(" this number is invalid phone number, please try again");
                else if (int.Parse(txt_Number.Text)>1599999999)
                    MessageBox.Show(" this number is invalid phone number, please try again");
                else
                {
                    varnumber2=txt_Number.Text;
                   // this.Hide();
                    information_form form2 = new information_form();
                    form2.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_Number.Text="";
                txt_Number.Focus();
            }
        }

        private void button_CONTACT_WOC_Click(object sender, EventArgs e)
        {
            Contacts_form contacts_Form = new Contacts_form();
            contacts_Form.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Contacts_form da = new Contacts_form();
            
         //   ( da.dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
         //      string.Format("phonenumber like '%" + listBox1.Text + "%'");
        }
    }
}
