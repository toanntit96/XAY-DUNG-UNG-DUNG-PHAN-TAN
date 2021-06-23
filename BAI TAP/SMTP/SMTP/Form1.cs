using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SMTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                 MailMessage mail = new MailMessage();
                 SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                 mail.From = new MailAddress(txtUser.Text);
                 mail.To.Add(txtTo.Text);
                 mail.Subject = txtSub.Text;
                 mail.Body = txtBody.Text;
                 SmtpServer.Port = 587;
                 SmtpServer.Credentials = new System.Net.NetworkCredential(txtUser.Text, txtPass.Text);
                 SmtpServer.EnableSsl = true;
                 SmtpServer.Send(mail);
                 MessageBox.Show("mail Send");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
