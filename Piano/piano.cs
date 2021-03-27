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

namespace Piano
{
    public partial class piano : Form
    {
        public piano()
        {
            InitializeComponent();
        }

        private void piano_Load(object sender, EventArgs e)
        {

        }

        private void Cbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\C.wav");
            chicken.Play();
        }

        private void Csbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\C_s.wav");
            chicken.Play();
        }

        private void Dbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\D.wav");
            chicken.Play();
        }

        private void Dsbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\D_s.wav");
            chicken.Play();
        }

        private void Ebtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\E.wav");
            chicken.Play();
        }

        private void Fbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\F.wav");
            chicken.Play();
        }

        private void Fsbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\F_s.wav");
            chicken.Play();
        }

        private void Gbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\G.wav");
            chicken.Play();
        }

        private void Gsbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\G_s.wav");
            chicken.Play();
        }

        private void Abtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\A.wav");
            chicken.Play();
        }

        private void Bbbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\Bb.wav");
            chicken.Play();
        }

        private void Bbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\B.wav");
            chicken.Play();
        }

        private void C1btn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\C1.wav");
            chicken.Play();
        }

        private void C1sbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\C_s1.wav");
            chicken.Play();
        }

        private void D1btn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\D1.wav");
            chicken.Play();
        }

        private void D1sbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\D_s1.wav");
            chicken.Play();
        }

        private void E1btn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\E1.wav");
            chicken.Play();
        }

        private void F1btn_Click(object sender, EventArgs e)
        {
            SoundPlayer chicken = new SoundPlayer(@"C:\Users\Nihad\source\repos\Piano\Resources\F1.wav");
            chicken.Play();
        }
    }
}
