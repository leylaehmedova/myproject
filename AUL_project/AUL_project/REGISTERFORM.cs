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

namespace AUL_project
{
    public partial class REGISTERFORM : Form
    {

        public REGISTERFORM()
        {
            InitializeComponent();

        }
        static string constring = "Data Source=LAPTOP-K5NS6649\\SQLEXPRESS;Initial Catalog = Users; Integrated Security=True";

        SqlConnection connect = new SqlConnection(constring);


        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void REGISTERFORM_Load(object sender, EventArgs e)
        {



        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void txtpassw_TextChanged(object sender, EventArgs e)
        {

            txtpassw.PasswordChar = '*';
        }

        private void txtbcon_TextChanged(object sender, EventArgs e)
        {

            txtbcon.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmlogin().Show();
            this.Hide();


        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string register = "Insert into dbo.Register (first_name,last_name,username,email,password,retype_password,gender) values('" + txtbfirst.Text + "', '" + txtblast.Text + "','" + txtbuser.Text + "','" + txtbemail.Text + "','" + txtpassw.Text + "','" + txtbcon.Text + "','" + RBfml.Text + "')";
                SqlCommand command = new SqlCommand(register, connect);
                command.Parameters.AddWithValue("@first_name", txtbfirst.Text);
                command.Parameters.AddWithValue("@last_name", txtblast.Text);
                command.Parameters.AddWithValue("@username", txtbuser.Text);
                command.Parameters.AddWithValue("@email", txtbemail.Text);
                command.Parameters.AddWithValue("@password", txtpassw.Text);
                command.Parameters.AddWithValue("@retype_password", txtbcon.Text);
                if (RBfml.Checked)
                    command.Parameters.AddWithValue("@gender", "Female");
                else
                    command.Parameters.AddWithValue("@gender", "Male");

                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("SUCCESSFULLY REGISTERED");
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured" + error.Message);
            }


        }

        private void txtbfirst_Click(object sender, EventArgs e)
        {
            txtbfirst.Clear();
        }

        private void txtblast_Click(object sender, EventArgs e)
        {
            txtblast.Clear();
        }

        private void txtbuser_Click(object sender, EventArgs e)
        {
            txtbuser.Clear();
        }

        private void txtbemail_Click(object sender, EventArgs e)
        {
            txtbemail.Clear();
        }

        private void txtpassw_Click(object sender, EventArgs e)
        {
            txtpassw.Clear();
        }

        private void txtbcon_Click(object sender, EventArgs e)
        {
            txtbcon.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmlogin().Show();
            this.Hide();

        }

        private void txtblast_TextChanged(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)

            {
                txtpassw.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;

            }
            else
            {
                txtpassw.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)

            {
                txtbcon.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;

            }
            else
            {
                txtbcon.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
            }
        }
    }
}
