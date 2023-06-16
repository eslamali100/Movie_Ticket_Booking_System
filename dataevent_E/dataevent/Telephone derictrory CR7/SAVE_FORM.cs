using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Final_project_in_Event
{
    public partial class SAVE_FORM : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-P3FR6Q2\\SQLEXPRESS;database=contacts;integrated security=true");
      //  SqlConnection connection = new SqlConnection("server=DESKTOP-P3FR6Q2\\SQLEXPRESS;database=contacts;integrated security=true");

        public SAVE_FORM()
        {
            InitializeComponent();
        }

        private void SAVE_FORM_Load(object sender, EventArgs e)
        {

        }

        private void button_NO_Click(object sender, EventArgs e)
        {
            information_form information_Form = new information_form();
            information_Form.Close();
            this.Close();
        }

        private void button_YES_Click(object sender, EventArgs e)
        {
            string sql2 = "select categoryid from categoriesss where categoryname= @categoryname";
            SqlCommand sqlcmd2 = new SqlCommand(sql2, con);
            sqlcmd2.Parameters.AddWithValue("@categoryname", information_form.varcategory);
            int result;
            con.Open();
            sqlcmd2.ExecuteNonQuery();
            result = (int)sqlcmd2.ExecuteScalar();
            con.Close();


            string sql = "insert into contactphonebookk  values(@fullname,@phonenumber,@email,@address,@category,@categoryid)";
            SqlCommand sqlcmd = new SqlCommand(sql, con);
            sqlcmd.Parameters.AddWithValue("@fullname", information_form.varname);
            sqlcmd.Parameters.AddWithValue("@phonenumber", information_form.varnumber);
        
            sqlcmd.Parameters.AddWithValue("@email", information_form.varemail);
            sqlcmd.Parameters.AddWithValue("@address", information_form.varaddress);
            sqlcmd.Parameters.AddWithValue("@category", information_form.varcategory);
            sqlcmd.Parameters.AddWithValue("@categoryid", result);

         
           
            con.Open();
            sqlcmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data added successfully");
 
            this.Close();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SAVE_FORM_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(335, 141);
            
        }
    }
}
