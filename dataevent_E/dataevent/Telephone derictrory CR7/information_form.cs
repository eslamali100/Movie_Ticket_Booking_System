using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final_project_in_Event
{
    public partial class information_form : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-P3FR6Q2\\SQLEXPRESS;database=contacts;integrated security=true");
        public information_form()
        {
            InitializeComponent();
        }
        public static string varnumber;
        public static string varname;
        public static string varemail;
        public static string varaddress;
        public static string varcategory;
        //public static string varcategoryname;
        //public static string varcatname;
        // public static int varcatnum;

        private void information_form_Load(object sender, EventArgs e)
        {
            txt_Number.Text = frm_contact.varnumber2;

         
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_CLEAR_Click(object sender, EventArgs e)
        {
            txt_Number.Clear();
            txt_Name.Clear();   
            txt_Address.Clear();
            txt_Email.Clear();
        }

        private void button_SAVE_Click(object sender, EventArgs e)
        {
            varname = txt_Name.Text;
            varnumber = txt_Number.Text;
            varemail=txt_Email.Text;
            varaddress = txt_Address.Text;
            varcategory=listbox_Category.SelectedItem.ToString();
            //varcategoryname=listbox_CATEGORY.SelectedItem.ToString();
          
            
            this.Hide();
            SAVE_FORM sAVE_FORM = new SAVE_FORM();
            _=sAVE_FORM.ShowDialog();

        }

        private void listbox_CATEGORY_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            


        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
           // string s = "select categoryname from categoriesss ";
          //  SqlCommand cmd = new SqlCommand(s, con);

           // SqlDataAdapter da = new SqlDataAdapter();
           // da.SelectCommand = cmd;
           // DataTable dt = new DataTable();
          //  da.Fill(dt);
          //  listbox_CATEGORY.DataSource = dt;
          //  listbox_CATEGORY.DisplayMember = "categoryname";
          
        }
    }
}
