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
    public partial class frmBase64 : Form
    {
        public frmBase64()
        {
            InitializeComponent();
        }
        string encrypt = "";
        string state = "0";
        private void frmBase64_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (StreamReader folder_read = File.OpenText("data.txt"))
            {
                string line;
                while ((line = folder_read.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            new frmEnDec().Show();
            this.Hide();
           
        }
        private void save()
        {
            const string position = "data.txt";
            System.IO.StreamWriter save = new System.IO.StreamWriter(position);
            foreach (var item in listBox1.Items)
            {
                save.WriteLine(item);
            }
            save.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void brnEnc3_Click(object sender, EventArgs e)
        {
            state = "1";
            string basetext = textBox1.Text;
            byte[] basecipher = ASCIIEncoding.ASCII.GetBytes(basetext);
            string result = Convert.ToBase64String(basecipher);
            textBox2.Text = result;
            listBox1.Items.Add(encrypt = "Base64 --" + textBox1.Text + "=" + textBox2.Text+"[En]");
           
        }

        private void btnDec3_Click(object sender, EventArgs e)
        {
            state = "2";
            string basetext2 = textBox1.Text;
            byte[] basecipher2 = Convert.FromBase64String(basetext2);
            string result2 = ASCIIEncoding.ASCII.GetString(basecipher2);
            textBox2.Text = result2;
            listBox1.Items.Add(encrypt = "Base64 --" + textBox1.Text + "=" + textBox2.Text + "[Dec]");
           

        }

        private void btnClean3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You can copy by clicking on the text!\n To copy data from the list, simply click on it.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());
                label6.Text = "Status: Copied from the list!";
            }
            catch (Exception)
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (state == "1")
                {
                    label6.Text = "status: Text successfully encrypted.\nEncrypted text copied to clipboard";

                }
                else if (state == "2")
                {
                    label6.Text = "status: Text successfully decrypted.\nDecrypted text copied to clipboard";

                }
            
           Clipboard.SetText(textBox2.Text);
            }
            catch (Exception)
            {

            }
        }
    }
}
