using System;
using System.Drawing;
using System.Windows.Forms;

namespace LeagueCleaner
{
    public partial class Form1 : Form
    {
        private Point lastPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)//here how to move loader 
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)//here how to move loader 
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)//here how to move loader 
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)//here how to move loader 
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl3.Text = DateTime.Now.ToLongDateString();
            lbl4.Text = DateTime.Now.ToLongTimeString();
        }

        private void bunifuIconButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/wCatly");
        }

        private void bunifuIconButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/xfD4BbuWCy");
        }

        private void bunifuIconButton8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/wcatxd");
        }

        private void bunifuIconButton9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wcat.wtf/");
        }

        private void bunifuIconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
