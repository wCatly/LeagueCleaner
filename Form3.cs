using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueCleaner
{
    public partial class Form3 : Form
    {
        private Point lastPoint;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel3.Width += 3;

            if (panel3.Width >= 599)
            {
                timer1.Stop();
                Form fm3 = new Form2();
                fm3.Show();
                this.Hide();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuIconButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://eclipse.lol/");
        }

        private void bunifuIconButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/Riot_Eclipse");
        }

        private void buton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/wCatly");
        }

        private void buton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/xfD4BbuWCy");
        }

        private void buton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/wcatxd");
        }

        private void buton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wcat.wtf/");
        }
    }
}
