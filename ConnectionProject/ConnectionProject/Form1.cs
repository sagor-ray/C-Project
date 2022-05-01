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

namespace ConnectionProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            namet.Focus();
        }
        public string connectionString = "Data Source=DESKTOP-UG8RNRM\\SQLEXPRESS;Initial Catalog=connectionProject;Integrated Security=True";

        private void addb_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if(con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into StudentTable(Name,ID)values('" + namet.Text.ToString() + "','" +idt.Text.ToString()+"')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added!!!");
            }
        }

        private void clearb_Click(object sender, EventArgs e)
        {
            namet.Text = "";
            idt.Text = "";
            namet.Focus();
        }
    }
}
