using CmlLib.Core;
using CmlLib.Core.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientIntegration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private static string versiyon;
        private static int ram2;
        private static int width2;
        private static int height2;

        string templocation = "c:\\temp\\";
        string mclocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".luzia/versions/Rod Client");


        private void Form2_Load(object sender, EventArgs e)
        {
            path();
            username.Text = Form1.user;
            if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".luzia/versions/Rod Client")) == false)
            {
                status.Text = "Client is not downloaded.";
                clientdownloaded = false;
            }
            else
            {
                status.Text = "It's downloaded but you can download it again.";
                clientdownloaded = true;
            }
            if (clientdownloaded == true)
            {
                version.Items.Add("Rod Client");
            }
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        bool clientdownloaded;

        private void downloadclient_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".luzia/versions/Rod Client")) == false)
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".luzia/versions/Rod Client"));
            }
            else
            {
                status.Text = "It is downloaded but you can download it again.";
            }
            WebClient downloader = new WebClient();
            status.Text = "Downloading client.";
            this.Update();
            downloader.DownloadFile("https://cdn.luziaa.xyz/link/github/Rod_Client.zip", templocation + "Rod_Client.zip");

            status.Text = "Extracting Files..";
            Shell32.Shell sc = new Shell32.Shell();
            Directory.CreateDirectory(@"C:\Temp\Rod Client");
            Shell32.Folder output = sc.NameSpace(@"C:\Temp\Rod Client");
            Shell32.Folder input = sc.NameSpace(templocation + "Rod_Client.zip");
            output.CopyHere(input.Items(), 256);

            status.Text = "Moving files..";
            new Microsoft.VisualBasic.Devices.Computer().FileSystem.CopyDirectory("C:\\temp\\Rod Client", mclocation, true);
            status.Text = "Downloaded Successfully.";
            version.Items.Add("Rod Client");
            clientdownloaded = true;
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            playbutton.Text = "DOWNLOADING";
            playbutton.Enabled = false;
            Thread thread = new Thread(() => Launch());
            thread.IsBackground = true;
            thread.Start();
        }

        private void path()
        {
            MinecraftPath path = new MinecraftPath(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".luzia"));
            var launcher = new CMLauncher(path);
        }

        private void Launch()
        {
            MinecraftPath path = new MinecraftPath(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".luzia"));
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = ram2,
                Session = MSession.GetOfflineSession(Form1.user),
                //ServerIp = "mc.luziaa.xyz",
                ScreenWidth = width2,
                ScreenHeight = height2,
            };
            versiyon = version.SelectedItem.ToString();
            var process = launcher.CreateProcess(versiyon, launchOption);
            playbutton.Text = "LAUNCHING";
            process.Start();
            Hide();

            while (true)
            {
                Process[] pname = Process.GetProcessesByName("javaw");
                if (pname.Length > 0)
                {

                }
                else
                {
                    this.Show();
                    playbutton.Enabled = true;
                    playbutton.Text = "PLAY";
                    break;
                }

            }
        }

        private void height_SelectedIndexChanged(object sender, EventArgs e)
        {
            height2 = Convert.ToInt32(height.SelectedItem);
        }

        private void width_SelectedIndexChanged(object sender, EventArgs e)
        {
            width2 = Convert.ToInt32(width.SelectedItem);
        }

        private void ram_SelectedIndexChanged(object sender, EventArgs e)
        {
            ram2 = Convert.ToInt32(ram.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
