using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StartMenu
{
    public partial class shutdownmanager : Form
    {
        TimeSpan timeleft;

        public shutdownmanager()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            TextBoxValueCheck();
            bool isStarttable = true;

            try
            {
                timeleft = new TimeSpan(Convert.ToInt32(sethourTbox.Text), Convert.ToInt32(setminuteTbox.Text), Convert.ToInt32(setsecondTbox.Text));
            }
            catch(FormatException ex)
            {
                isStarttable = false;
                MessageBox.Show(ex.Message);
            }
            if(isStarttable == true)
            {
                shutdowntimer.Start();
                timerLbl.Text = timeleft.ToString(@"hh\:mm\:ss");
            }
        }
        
        private void TextBoxValueCheck()
        {
            if(sethourTbox.Text.Count() == 0)
            {
                sethourTbox.Text = "0";
            }
            if(setminuteTbox.Text.Count() == 0)
            {
                setminuteTbox.Text = "0";
            }
            if(setsecondTbox.Text.Count() == 0)
            {
                setsecondTbox.Text = "0";
            }
        }

        private void shutdowntimer_Tick(object sender, EventArgs e)
        {
            timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1));
            timerLbl.Text = timeleft.ToString(@"hh\:mm\:ss");

            if(timeleft.TotalSeconds <= 0)
            {
                shutdowntimer.Stop();
                ProcessAction();
            }
        }

        private void ProcessAction()
        {
            if(shutdownRbtn.Checked == true)
            {
                Process.Start("shutdown", "/s");
            }
            else if(restartRbtn.Checked == true)
            {
                Process.Start("shutdown", "/r");
            }
            else if(powersaveRbtn.Checked == true)
            {
                Process.Start("rundll32.exe", "powrprof.dll,SetSuspendState");
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            shutdowntimer.Stop();
            timerLbl.Text = "00:00:00";
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            startMenu ff = new startMenu();
            this.Hide();
            ff.ShowDialog();
            this.Close();
        }
    }
}
