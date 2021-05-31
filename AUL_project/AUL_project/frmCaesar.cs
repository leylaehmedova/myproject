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
    public partial class frmCaesar : Form
    {
        public frmCaesar()
        {
            InitializeComponent();
        }
        string encrypt = "";
        string state = "0";
        private void frmCesar_Load(object sender, EventArgs e)
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
        private void btnEnc1_Click(object sender, EventArgs e)
        {
            state = "1";
            string input = textBox1.Text;
            int key = Convert.ToInt32(textBox3.Text);
            char[] alphabet = { 'a', 'b', 'c', 'ç', 'd', 'e', 'ə', 'f', 'g', 'ğ', 'h', 'x', 'ı', 'i', 'j', 'k', 'q', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'w','y', 'z' };
            char[] alphabet2 = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'Ə', 'F', 'G', 'Ğ', 'H', 'X', 'I', 'İ', 'J', 'K', 'Q', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'W', 'Y', 'Z' };
            char[] alphabet3 = { ' ','.', '!', '?', '_', '-', ';', ':', ',', '/', '|', '@', '#', '$', '%', '^', '*', '(', ')', '+', '=', '[', ']', '{', '}', '<', '>', '~', '"', '`', ' ',' ', '\\' };
            string encyrpt = "";
            if (key >= 33)
            {
                key = key % 33;
            }
            for (int j = 0; j < input.Length; j++)
            {
                for (int Z = 0; Z < alphabet2.Length; Z++)
                {
                    if (input[j] == alphabet3[Z])
                    {
                        int mod = Z;
                        encyrpt += alphabet3[mod];
                        textBox2.Text = encyrpt;
                        if (input[j] == ' ')
                        {
                            break;
                        }
                    }
                   else if (input[j] == alphabet2[Z])
                    {
                        int count = Z + key;

                        if (count >= alphabet2.Length)
                        {
                            int mod = count - alphabet2.Length;
                            encyrpt += alphabet2[mod];
                            textBox2.Text = encyrpt;
                        }
                        else encyrpt += alphabet2[Z + key];
                        textBox2.Text = encyrpt;
                    }
                    else if (input[j] == alphabet[Z])
                    {
                        int count = Z + key;

                        if (count >= alphabet.Length)
                        {
                            int mod = count - alphabet.Length;
                            encyrpt += alphabet[mod];
                            textBox2.Text = encyrpt;
                        }
                        else encyrpt += alphabet[Z + key];
                        textBox2.Text = encyrpt;
                    }

                }

            }
            listBox1.Items.Add(encrypt = "Caesar --" + textBox1.Text + " key=" + textBox3.Text + " " + textBox2.Text + "[En]");
            
        }
        private void btnClean1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void btnDec1_Click(object sender, EventArgs e)
        {
            state = "2";
            string input = textBox1.Text;
            int key = Convert.ToInt32(textBox3.Text);
            char[] alphabet = { 'a', 'b', 'c', 'ç', 'd', 'e', 'ə', 'f', 'g', 'ğ', 'h', 'x', 'ı', 'i', 'j', 'k', 'q', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v','w', 'y', 'z' };
            char[] alphabet2 = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'Ə', 'F', 'G', 'Ğ', 'H', 'X', 'I', 'İ', 'J', 'K', 'Q', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V','W', 'Y', 'Z' };
            char[] alphabet3 = { ' ', '.', '!', '?', '_', '-', ';', ':', ',', '/', '|', '@', '#', '$', '%', '^', '*', '(', ')', '+', '=', '[', ']', '{', '}', '<', '>', '~', '"', '`', ' ',' ', '\\' };
            string encyrpt = "";
            if (key >= 33)
            {
                key = key % 33;
            }
            for (int j = 0; j < input.Length; j++)
            {
                for (int Z = 0; Z < alphabet2.Length; Z++)
                {
                    if (input[j] == alphabet3[Z])
                    {
                        int mod = Z;
                        encyrpt += alphabet3[mod];
                        textBox2.Text = encyrpt;
                        if (input[j] == ' ')
                        {
                            break;
                        }
                    }
                    else if (input[j] == alphabet2[Z])
                    {
                        int count = Z - key;

                        if (count < 0)
                        {
                            int mod = count + alphabet2.Length;
                            encyrpt += alphabet2[mod];
                            textBox2.Text = encyrpt;
                        }
                        else encyrpt += alphabet2[Z - key];
                        textBox2.Text = encyrpt;
                    }
                    else if (input[j] == alphabet[Z])
                    {
                        int count = Z - key;
                        if (count < 0)
                        {
                            int mod = count + alphabet2.Length;
                            encyrpt += alphabet[mod];
                            textBox2.Text = encyrpt;
                        }
                        else encyrpt += alphabet[Z - key];
                        textBox2.Text = encyrpt;
                    }
                }
            }
            listBox1.Items.Add(encrypt = "Caesar --" + textBox1.Text + " key=" + textBox3.Text + " " + textBox2.Text +  "[Dec]");
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MessageBox.Show("You can copy by clicking on the text!\n To copy data from the list, simply click on it.");
        }

        private void frmCaesar_Load(object sender, EventArgs e)
        {

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


