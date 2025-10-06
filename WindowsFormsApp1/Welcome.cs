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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Welcome: Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        /*private void connect()
        {

            string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Doctor;Integrated Security=True;";
            //Data Source = DESKTOP - OCNS2DA\SQLEXPRESS; Initial Catalog = MUMSDb; Integrated Security = True
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            //int id = 102;
            //float sal = 55000.0f;
            string query = "INSERT INTO DCTOR VALUES('SADIA','CS')";
            // string query = "INSERT INTO TEACHER VALUES(" + id + ",'" + txtName.Text + "'," + sal + ",'" + comboBox1.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            //Console.WriteLine("Connection Successful!");

        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdpt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();


        }
        private void clear()
        {
            txtID.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            txtdpt.Text = "";
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
        private void ShowInfo()
        {
            string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Doctor;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM DOCTOR";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void Show_Click(object sender, EventArgs e)
        {
            ShowInfo();
            /*string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Doctor;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM DOCTOR";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Doctor;Integrated Security=True;";
                //string connectionString="Data Source=DESKTOP-OCNS2DA\SQLEXPRESS;Initial Catalog=HUMSDb;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "delete from doctor where ID=" + txtID.Text;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                ShowInfo();
                clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Doctor;Integrated Security=True;";
                //string connectionString="Data Source=DESKTOP-OCNS2DA\SQLEXPRESS;Initial Catalog=HUMSDb;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query2 = "UPDATE DOCTOR SET NAME='" + txtname.Text + "',Email='" + txtemail.Text + "',Department='" + txtdpt.Text + "' WHERE ID=" + txtID.Text;
                SqlCommand cmd = new SqlCommand(query2, conn);
                cmd.ExecuteNonQuery();
                ShowInfo();
                clear();
            }
        }
    }
}
