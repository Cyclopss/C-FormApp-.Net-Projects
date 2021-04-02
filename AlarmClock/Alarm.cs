using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ClockAlarm
{
    public partial class Alarm : Form
    {
        SoundPlayer startp = new SoundPlayer("AlarmStart.wav");
        SoundPlayer stopp = new SoundPlayer("Alarmstopped.wav");
        public Alarm()
        {
            InitializeComponent();
        }
        string hAlarm, mAlarm, sAlarm;

        private void alarmTimer_Tick(object sender, EventArgs e)
        {
            cAlrmLbl.Text = DateTime.Now.ToString("HH : mm : ss");
            Soundplayer();
        }

        private void hAlrmTbox_TextChanged(object sender, EventArgs e)
        {
            errorLbl.Visible = true;
        }

        private void mAlarmTbox_TextChanged(object sender, EventArgs e)
        {
            errorLbl.Visible = true;
        }

        private void sAlrmTbox_TextChanged(object sender, EventArgs e)
        {
            errorLbl.Visible = true;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            hAlarm = hAlrmTbox.Text;
            mAlarm = mAlarmTbox.Text;
            sAlarm = sAlrmTbox.Text;
            stopp.Stop();
        }
        void Soundplayer()
        {
            if (hAlarm == DateTime.Now.Hour.ToString() && mAlarm == DateTime.Now.Minute.ToString() && sAlarm == DateTime.Now.Second.ToString())
            {
                startp.Play();
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            startp.Stop();
            stopp.Play();
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            ClockDigital ff = new ClockDigital();
            ff.Show();
            this.Close();
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            alarmTimer.Start();
        }
    }
}
