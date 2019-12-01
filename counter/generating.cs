/*
 * Created by SharpDevelop.
 * User: tada
 * Date: 15.7.2019
 * Time: 15:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace counter
{
	/// <summary>
	/// Generates everything
	/// </summary>
	public partial class generating : Form
	{
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public generating()
		{
			InitializeComponent();
			l_generating.Visible = false;

        }
        void Timer1Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 10)
            {
                string folderName = @"";
                string pathString = System.IO.Path.Combine(folderName, "Counter");
                System.IO.Directory.CreateDirectory(pathString);                    //Generate the folder "Counter"
                l_generating.Text = "Generating a countdown text file...";
            }
            if (progressBar1.Value == 60)
            {
                using (StreamWriter sw = new StreamWriter("Counter/countdown.txt"));     //Generate countdown.txt 
                l_generating.Text = "Generating the settings...";
            }
            if (progressBar1.Value == 110)
            {
                using (StreamWriter sw = new StreamWriter("Counter/settings.xml"));
                l_generating.Text = "Downloading sound effects";  //Generate settings.xml
            }
            if (progressBar1.Value == 160)
            {
                using (var client = new WebClient())
                {
                    if (CheckForInternetConnection())
                    {
                        client.DownloadFile("http://tada66.wz.cz/ding.wav", "Counter/ding1.wav");
                        client.DownloadFile("http://tada66.wz.cz/ding2.wav", "Counter/ding2.wav");      //Download sound effects
                        client.DownloadFile("http://tada66.wz.cz/ding3.wav", "Counter/ding3.wav");
                        client.DownloadFile("http://tada66.wz.cz/ding4.wav", "Counter/ding4.wav");
                        l_generating.Text = "Files have beenated succesfully. You can close this window now.";  //shut timer off
                        progressBar1.Value = progressBar1.Value + 10;
                        timer1.Enabled = false;
                    }
                    else
                    {
                        l_generating.Text = "No internet";  //shut timer off
                        progressBar1.Value = progressBar1.Value + 10;
                        timer1.Enabled = false;
                        MessageBox.Show("Internet is not avaliable", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
			if(progressBar1.Value != progressBar1.Maximum)
				progressBar1.Value = progressBar1.Value + 50;       //After generating something increase pbar by 50 in order for other stuff to be generated
		}
		void Button1Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			progressBar1.Visible = true;
			label1.Visible = false;
			b_yes.Visible = false;
			l_generating.Visible = true;                //After clicking generate do all kinds of shit
			l_generating.Text = "Generating folder...";
			b_no.Visible = false;
		}
		void B_noClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}