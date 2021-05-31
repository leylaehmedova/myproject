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
    public partial class frmlogin : Form
    {
   

        public frmlogin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-K5NS6649\\SQLEXPRESS; Initial Catalog=Users; Integrated Security=TRUE");
        SqlConnection connect = new SqlConnection();
        int chance = 3;
        bool isThere;
        private void button2_Click(object sender, EventArgs e)

        {
          
            string Username = Txtbusern.Text;
            string Password = Txtbpass.Text;

            connection.Open();
            SqlCommand command = new SqlCommand("Select *from dbo.Register", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (Username == reader["username"].ToString().TrimEnd() && Password == reader["password"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;

                }
            }
            if (isThere)
            {
                MessageBox.Show("Login Succesful!");
                new frmEnDec().Show();
                this.Hide();
              

            }
            else
            {
                chance--;
                MessageBox.Show("Invalid Credentials, Please Re-Enter.Your left chances=" + chance);
                if (chance == 0)
                {
                    Application.Exit();
                }

            }
           
        }

           
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblUser_Click(object sender, EventArgs e)
        {

        }

        private void Btnregher_Click(object sender, EventArgs e)
        {
            new REGISTERFORM().Show();
            this.Hide();
            

            
        }

        private void LblUsern_Click(object sender, EventArgs e)
        {

        }

        private void Txtbpass_TextChanged(object sender, EventArgs e)
        {
             

        }

        private void Txtbusern_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Checkrem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txtbusern_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Txtbpass_Click(object sender, EventArgs e)
        {
            Txtbpass.Clear();
        }

        private void Txtbusern_Click(object sender, EventArgs e)
        {
            Txtbusern.Clear();
        }

        private void linkfrgt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           new frmEnDec().Show();
            this.Hide();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SendCode sc = new SendCode();
            this.Hide();
            sc.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)

            {
                Txtbpass.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                
            }
            else
            {
                Txtbpass.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            ResetPassword frm = new ResetPassword();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
