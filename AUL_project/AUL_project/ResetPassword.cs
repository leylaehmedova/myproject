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
using System.IO;
using System.Net;
using System.Security.Cryptography;
namespace AUL_project
{
    public partial class ResetPassword : Form
    {
        string username = SendCode.to;
        public ResetPassword()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResetpass.Text == txtResetVerify.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-K5NS6649\\SQLEXPRESS; Initial Catalog=Users; Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("update Register set password = '" + txtResetpass.Text + "', retype_password = '" + txtResetVerify.Text + "' where username = '" + txtusername.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Reset successfully");
                new frmlogin().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

         
            //int chance = 3;
            //bool isThere;
            {
                //if (this.Height == 312)
                //{
                //    this.Height = 572;

                //}
                //else
                //{
                //    this.Height = this.Height + 260;

                //}
                string Username = txtusername.Text;
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-K5NS6649\\SQLEXPRESS; Initial Catalog=Users; Integrated Security=True");
                SqlConnection connect = new SqlConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("select *from dbo.Register where username='" + txtusername.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (Username == dr["username"].ToString().TrimEnd())
                    {
                        MessageBox.Show("Success");
                       
                        this.Height = 430;
                         break;
                    }
                    else if(Username != dr["username"].ToString().TrimEnd())
                    { 
                        MessageBox.Show("Username is wrong");
                        this.Height = 312;

                    }
                    con.Close();
                    dr.Close();

                }
            }
        }
    }
}
