using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartMenu
{
    public partial class startMenu : Form
    {
        
        public startMenu()
        {
            InitializeComponent();
        }

        private void steamBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("steam");
            }
            catch (Exception) 
            {
               MessageBox.Show("Some features will come with a new update "); 
            }
        }

        private void netflixBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("netflix");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void eclipseBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void javaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");

        }

        private void acrobatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("acrord32");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void powerBtn_Click(object sender, EventArgs e)
        {
            if(powerPnl.Visible == true)
            {
                powerPnl.Visible = false;
            }
            else
            {
                powerPnl.Visible = true;
            }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {

        }

        private void userBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.userBtn, "Personal info");
        }

        private void documentsBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.documentsBtn, "Documents");
        }

        private void picturesBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.picturesBtn, "Pictures");
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {

            try
            {
                Process.Start("immersivecontrolpanel");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void settingsBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.settingsBtn, "Settings");
        }

        private void powerBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.powerBtn, "Power");
        }

        private void chromeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("chrome");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void mistoreBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("windowsstore");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void odriveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("skydrive");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void onoteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("onenote");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void ppointBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("powerpnt");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void vrecorderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("windowssoundrecorder");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void btnNetflix_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("netflix.app");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("windowslive");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void skypeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void vsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("visualstudio");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void edgeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void psBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void kaperskyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calendar");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void vscodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("visualstudiocode");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void dboxBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void ytBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void fexplorerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void adprBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void grooveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void vlcBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void aprimeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void adxdBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void btnPpoint_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("powerpnt");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void bingBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some features will come with a new update ");
        }

        private void rarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("winrar");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void btnOnote_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("onenote");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void btnChrome_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("chrome");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("excel");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void paintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("mspaint");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void wordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("winword");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("excel");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("winword");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update ");
            }
        }

        private void picturesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("photos");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update");
            }
            
        }

        private void documentsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer");
            }
            catch (Exception)
            {
                MessageBox.Show("Some features will come with a new update");
            }
        }

        

        private void tictactoeBtn_Click(object sender, EventArgs e)
        {
            tictactoe tf = new tictactoe();
            this.Hide();
            tf.ShowDialog();
            this.Close();
        }

        private void shutdownmanagerBtn_Click(object sender, EventArgs e)
        {
            shutdownmanager sf = new shutdownmanager();
            this.Hide();
            sf.ShowDialog();
            this.Close();
            
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s");
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r");
        }

        private void sleepBtn_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, false, true);
        }
    }
}
