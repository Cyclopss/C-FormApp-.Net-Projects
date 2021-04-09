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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Data\\" + usernameUpTox.Text + ".txt");
            sw.WriteLine(usernameUpTox.Text);
            sw.WriteLine(surnameUpTbox.Text);
            sw.WriteLine(nameUpTbox.Text);
            sw.WriteLine(passwordUpTbox.Text);
            sw.Close();
            Login ff = new Login();
            this.Hide();
            ff.ShowDialog();
            this.Close();
        }
    }
}
