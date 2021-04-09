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

namespace LogUp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {
        }

        private void newaccountBtn_Click(object sender, EventArgs e)
        {
            SignUp sf = new SignUp();
            this.Hide();
            sf.ShowDialog();
            this.Close();
        }

        private void passwordTbox_TextChanged(object sender, EventArgs e)
        { 
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\" + Environment.UserName + @"\source\repos\LogUp\bin\Debug\Data";
            string firstvalue = File.ReadLines(file).First();
            string secondvalue = File.ReadLines(file).Last();



            if (firstvalue == usernameTbox.Text && secondvalue == passwordTbox.Text)
            {
                MessageBox.Show("Welcome" + firstvalue);
            }
            else
            {
                errorLbl.Visible = true;
            }
        }

        private void contactusBtn_Click(object sender, EventArgs e)
        {
            ContactUs tf = new ContactUs();
            this.Hide();
            tf.ShowDialog();
            this.Close();
        }
    }
}
