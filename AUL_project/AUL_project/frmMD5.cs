using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Security.Cryptography;
namespace AUL_project

{
    public partial class frmMD5 : Form
    {
        public frmMD5()
        {
            InitializeComponent();
        }
        string encrypt = "";
        string state = "0";
        private void frmMD5_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (StreamReader folder_read = File.OpenText("data.txt"))
            {
                string line;
                while((line = folder_read.ReadLine())!= null)
                {
                    listBox1.Items.Add(line);
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void save()
        {
            const string position = "data.txt";
            System.IO.StreamWriter save = new System.IO.StreamWriter(position);
            foreach(var item in listBox1.Items)
            {
                save.WriteLine(item);
            }
            save.Close();
        }
       
        public static string encryption(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder stbuild = new StringBuilder();
        for(int i=0; i < result.Length; i++)
            {
                stbuild.Append(result[i].ToString("x2"));
            }
            return stbuild.ToString();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnendec_Click(object sender, EventArgs e)
        {
            
            state = "1";
            txtbres.Text = encryption(txtbtxt.Text);
            listBox1.Items.Add(encrypt = "md5 --" + txtbtxt.Text + "=" + txtbres.Text);
            //label3.Text = "Status: Text successfully Encrypted!";
            save();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtbtxt.Clear();
            txtbres.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmEnDec().Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You can copy by clicking on the encrypted text!\n To copy data from the list, simply click on it.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());
                label3.Text = "Status: Copied from the list!";
            }
            catch(Exception)
            {
                
            }
        }

        private void txtbres_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (state == "1")
                {
                    label3.Text = "Status: Text successfully Encrypted! \nEncrypted text copied to clipboard";
                    Clipboard.SetText(txtbres.Text);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
