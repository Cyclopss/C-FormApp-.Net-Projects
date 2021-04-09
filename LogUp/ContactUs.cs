using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace LogUp
{
    public partial class ContactUs : Form
    {

        public ContactUs()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login ff = new Login();
            this.Hide();
            ff.ShowDialog();
            this.Close();
        }

        

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Smpt details
                //Google: smpt server: smpt.gmail.com; ssl required
                //Yahoo: smpt server: smpt.gmail.yahoo.com; ssl required
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = 25;
                clientDetails.Host = "smpt-mail.outlook.com";
                clientDetails.EnableSsl = true;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(sendmailTbox.Text.Trim(), sendpasswordTbox.Text.Trim());

                //Message Details
                MailMessage mDetails = new MailMessage();
                mDetails.From = new MailAddress(sendmailTbox.Text.Trim());
                mDetails.To.Add("cyclopss.dev@gmail.com");

                //Message body
                mDetails.Subject = subjectTbox.Text.Trim();
                mDetails.IsBodyHtml = sslCbox.Checked;
                mDetails.Body = messageTbox.Text.Trim();

                clientDetails.Send(mDetails);
                MessageBox.Show("Your mail has been sent.");
                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
       

        private void smptTbox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
