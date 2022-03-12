using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LeagueCleaner
{
    public partial class Form2 : Form
    {
        private Point lastPoint;
        public Form2()
        {
            InitializeComponent();
        }

        private string localRiotGames = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
        string riotGames = "Riot Games";
        private string data;
        static readonly string ProgramData = @"C:\ProgramData\Riot Games";
        string temp = Environment.GetEnvironmentVariable("TEMP");
        private string dirName;
        private string dirPath;
        private bool truePath;



        private void Form2_Shown (object sender, EventArgs e)
        {

        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Settings");
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Injector");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuLabel5.Text = DateTime.Now.ToLongDateString();
            bunifuLabel9.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {


        }

        private void bunifuIconButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://.lol/");
        }

        private void bunifuIconButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/");
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuLabel30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t./");
        }

        private void bunifuLabel32_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://.lol/");
        }

        private void bunifuButton10_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {


        }

        private void bunifuLabel52_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuIconButton8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/");
        }

        private void bunifuIconButton9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://.lol/");
        }



        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            // if league of legends path true
            if (truePath == true)
            {
                //close lol game
                string lolGame = "League of Legends";
                Process[] processX = Process.GetProcessesByName(lolGame);

                foreach (Process prs in processX)
                {
                    if (prs.ProcessName == lolGame)
                    {
                        prs.Kill();
                        break;
                    }
                }

                //close lol client
                string lol = "LeagueClient";
                Process[] process = Process.GetProcessesByName(lol);

                foreach (Process prs in process)
                {
                    if (prs.ProcessName == lol)
                    {
                        prs.Kill();
                        break;
                    }
                }
                // close lol login screen
                string riotClient = "RiotClientServices";
                Process[] riot = Process.GetProcessesByName(riotClient);

                foreach (Process prs in riot)
                {
                    if (prs.ProcessName == riotClient)
                    {
                        prs.Kill();
                        break;
                    }
                }

                Thread.Sleep(1000);
                //delete temp folder
                try
                {
                    if (Directory.Exists(temp))
                    {
                        Directory.Delete(temp, true);
                        MessageBox.Show("Temp logs deleted!", "Success");
                    }
                    else if (!Directory.Exists(temp))
                    {
                        MessageBox.Show("Temp not found!", "Error");
                    }
                }
                catch (Exception exception)
                {


                }

                //delete program/data/riotgames machine.cfg 
                try
                {
                    string machine = "machine.cfg";
                    if (File.Exists(Path.Combine(ProgramData, machine)))
                    {
                        // If file found, delete it    
                        File.Delete(Path.Combine(ProgramData, machine));
                        MessageBox.Show("Machine.cfg deleted!");
                    }

                    else if (!File.Exists(Path.Combine(ProgramData, machine)))
                    {
                        MessageBox.Show("Machine.cfg not found!", "Success");

                    }
                }
                catch (Exception exception)
                {

                }

                //delete appdata/local/riotgames folder
                data = Path.Combine(localRiotGames, riotGames);
                try
                {
                    if (Directory.Exists(data))
                    {
                        Directory.Delete(data, true);
                        MessageBox.Show("Appdata logs deleted!", "Success");
                    }
                    else if (!Directory.Exists(data))
                    {
                        MessageBox.Show("Appdata/RiotGames not found!", "Success");
                    }
                }
                catch (Exception exception)
                {

                }

                // delete lol config 
                try
                {
                    string config = "Config";
                    string configdir = Path.Combine(dirPath, config);
                    if (Directory.Exists(configdir))
                    {
                        Directory.Delete(configdir, true);
                        MessageBox.Show("Configs deleted!", "Success");
                    }
                    else if (!Directory.Exists(configdir))
                    {
                        MessageBox.Show("Configs not found!", "Success");
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show("For delete Config u need to close LoLClient.exe");

                }


                // delete lol logs
                try
                {
                    string logs = "Logs";
                    string logsdir = Path.Combine(dirPath, logs);
                    if (Directory.Exists(logsdir))
                    {
                        Directory.Delete(logsdir, true);
                        MessageBox.Show("Logs deleted!", "Success");
                    }
                    else if (!Directory.Exists(logsdir))
                    {
                        MessageBox.Show("Logs not found!", "Success");
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show("For delete logs u need to close LoLClient.exe");
                    Application.Exit();
                }

                MessageBox.Show("All logs successfuly deleted! i hope you dont get ban xD");
                bunifuLabel6.Text = "logs cleared successfully";

            }

            // first need to select directory
            if (truePath == false)
            {
                MessageBox.Show("Select a League of Legends directory!", "Error");
            }
        }

        private void bunifuButton4_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog x = new FolderBrowserDialog();
            x.ShowDialog();
            dirPath = x.SelectedPath;

            if (x.SelectedPath.Contains("Riot Games\\League of Legends") ||
                x.SelectedPath.Contains("Riot Games\\lol") || x.SelectedPath.Contains("League of Legends") ||
                x.SelectedPath.Contains("lol"))
            {
                MessageBox.Show("True directory", "Success");
                truePath = true;
            }

            else
            {
                MessageBox.Show("Wrong directory!", "Error");
                truePath = false;
            }
        }

        private void bunifuIconButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/wCatly");
        }

        private void bunifuIconButton7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/xfD4BbuWCy");
        }

        private void bunifuIconButton10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/wcatxd");
        }

        private void bunifuIconButton11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wcat.wtf/");
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
