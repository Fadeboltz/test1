using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Registration: Form
    {
        private string username, password, name, email, phone, gender, bg, dob, department, adress;

        private void button1_Click(object sender, EventArgs e)
        {
            connect();
            /*username = textBoxuname.Text;
            password = textBoxpass.Text;
            name = textBoxname.Text;
            email = textBoxemail.Text;
            phone = textBoxphone.Text;
            gender = " ";
            if (radioButtonmale.Checked)
            {
                gender = "Male";
            }
            else if (radioButtonfemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Not Selected";
            }
            bg = comboBoxbg.Text;
            dob = dateTimePickerdob.Text;
            department = comboBoxdepartment.Text;
            adress = textBoxadress.Text;
            MessageBox.Show("Username: " + username + "\nPassword: " + password + "\nName" + name + "\nEmail: " + email + "\nContact No: " + phone + "\nGender: " + gender + "\nBlood Group: " + bg + "\nDate of Birth: " + dob + "\nDepartment: " + department + "\nAdress: " + adress);*/
        }

        public Registration()
        {
            InitializeComponent();
        }
        private void connect()
        {

            string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Doctor;Integrated Security=True;";
            //Data Source = DESKTOP - OCNS2DA\SQLEXPRESS; Initial Catalog = MUMSDb; Integrated Security = True
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            //int id = 102;
            //float sal = 55000.0f;
            //string query = "INSERT INTO DOCTOR VALUES(101,'Rashed','ahammodr74@gmail.com','Cardiology')";
           // string query1 = "INSERT INTO DOCTOR VALUES(102,'Ibrahim','ibrahim07@gmail.com','Orthopredic')";
            string query2 = "INSERT INTO DOCTOR VALUES(102,'Ibrahim','ibrahim07@gmail.com','Orthopredic')";
            // string query = "INSERT INTO TEACHER VALUES(" + id + ",'" + txtName.Text + "'," + sal + ",'" + comboBox1.Text + "')";
            SqlCommand cmd = new SqlCommand(query2, conn);
            cmd.ExecuteNonQuery();
            //Console.WriteLine("Connection Successful!");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            


        }
    }
}

