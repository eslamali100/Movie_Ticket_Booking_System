using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_project_in_Event
{
    
    public partial class Contacts_form : Form
    {
        
        SqlConnection con = new SqlConnection("server=DESKTOP-P3FR6Q2\\SQLEXPRESS;database=contacts;integrated security=true");
        public Contacts_form()
        {
            InitializeComponent();
            SqlDataAdapter ad = new SqlDataAdapter("select contactid,fullname,phonenumber,email,address,category from contactphonebookk", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void exit_BUTTON_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Contacts_form_Load(object sender, EventArgs e)
        {

        }

        private void delete_BUTTON_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from contactphonebookk where contactid ='" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delte successfully..!");
            SqlDataAdapter ad = new SqlDataAdapter("select *  from contactphonebookk", con);
             DataTable dt = new DataTable();
             ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void search_BUTTON_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_DATA_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
               string.Format("fullname like '%" + txt_Data.Text + "%'"); 

        }

        private void updata_BUTTON_Click(object sender, EventArgs e)
        {
         for(int i = 0;i<=dataGridView1.Rows.Count-1;i++)
            {
                SqlCommand ccc = new SqlCommand("Update contactphonebookk set fullname=@fullname,phonenumber=@phonenumber,email=@email,address=@address,category=@category where contactid=@contactid ", con);
                ccc.Parameters.AddWithValue("@fullname", dataGridView1.Rows[i].Cells[1].Value);
                ccc.Parameters.AddWithValue("@phonenumber", dataGridView1.Rows[i].Cells[2].Value);
                ccc.Parameters.AddWithValue("@email", dataGridView1.Rows[i].Cells[3].Value);
                ccc.Parameters.AddWithValue("@address", dataGridView1.Rows[i].Cells[4].Value);
                ccc.Parameters.AddWithValue("@category", dataGridView1.Rows[i].Cells[5].Value);
                ccc.Parameters.AddWithValue("contactid", dataGridView1.Rows[i].Cells[0].Value);
                con.Open();
                 ccc.ExecuteNonQuery();
                 con.Close();

               
            }
            MessageBox.Show("DATA UPDATED SUCCESSFULLY..!");


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //int x=int.Parse(txt_category.txt)
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
             string.Format("category like '%" + txt_Category.Text + "%'");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
