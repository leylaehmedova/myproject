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
    public partial class frmReverse : Form
    {
        public frmReverse()
        {
            InitializeComponent();
        }
        string state = "0";
        string encrypt = "";
        private void frmMD5_Load(object sender, EventArgs e)
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
            state = "1";
            string endec = "";
            for (int i = textBox1.Text.Length - 1; i >= 0; i--)
            {
                endec = endec + textBox1.Text[i].ToString();
                textBox2.Text = endec;
               
            } 
            listBox1.Items.Add(encrypt = "Reverse --" + textBox1.Text + "=" + textBox2.Text);

            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            new frmEnDec().Show();
            this.Hide();
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmReverse_Load(object sender, EventArgs e)
        {

        }
        private void btnClean4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You can copy by clicking on the reversed text!\n To copy data from the list, simply click on it.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());
                label5.Text = "Status: Copied from the list!";
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
                    label5.Text = "status: Text successfully Reversed.\nReversed text copied to clipboard";
                    Clipboard.SetText(textBox2.Text);
                }

            }
            catch (Exception)
            {

            }
        }
    }
}
