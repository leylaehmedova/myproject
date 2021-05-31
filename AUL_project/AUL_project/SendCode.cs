using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace AUL_project
{
    public partial class SendCode : Form
    {
        string randomCode;
        public static string to;
        public SendCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "mrsnobody27@gmail.com";
            pass = "hmgtohldjydoeetu";
            messageBody = "Your recovery code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code sent successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerify.Text).ToString())
            {
                to = txtEmail.Text;
                ResetPassword rp = new ResetPassword();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Wrong code");
            }

        }
    } 
}    

