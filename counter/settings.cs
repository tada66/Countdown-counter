/*
 * Created by SharpDevelop.
 * User: tada
 * Date: 15.7.2019
 * Time: 14:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;	
using System.Windows.Forms;

namespace counter
{
	/// <summary>
	/// Settings
	/// </summary>
	public partial class settings : Form
	{
		public settings()
		{
            InitializeComponent();
            c_ding.Visible = false;
            using (StreamReader sr = new StreamReader("Counter/settings.xml"))
            {
                if (sr.ReadLine() == "True")
                    ch_bgimage.Checked = true;

                if (sr.ReadLine() == "True")
                    ch_contaftercrash.Checked = true;

                string color = sr.ReadLine();
                c_color.Text = color;

                if (sr.ReadLine() == "True")
                {
                    ch_playsound.Checked = true;
                    c_ding.Visible = true;
                }
            }
            info.SetError(ch_bgimage, "Can improve performance on a slow computer");        //Show info messages next to check marks 
			info.SetError(ch_contaftercrash, "If the app gets closed, after reopening it will continue from where it stopped");
            info.SetError(c_color, "Color will get changed only if background image is turned off");
            using (StreamReader sr = new StreamReader("Counter/settings.xml"))
			{
				string smooth = sr.ReadLine();
				string bgimage = sr.ReadLine();
				if(bgimage == "True")
					ch_bgimage.Checked = true;      // Set checkmark for background image to be the same as previous sesion 
				
			}
		}
		void B_cancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void B_saveClick(object sender, EventArgs e)
		{
            if (ch_playsound.Checked == true && c_ding.Text == "")
                Error.SetError(c_ding, "You need to pick a sound effect");
            else
            {
                using (StreamWriter sw = new StreamWriter("Counter/settings.xml"))
                {
                    sw.WriteLine(ch_bgimage.Checked);
                    sw.WriteLine(ch_contaftercrash.Checked);    //Write value to settings.xml
                    sw.WriteLine(c_color.Text);
                    sw.WriteLine(ch_playsound.Checked);
                    sw.WriteLine("Counter/" + c_ding.Text + ".wav");
                }
                Application.Restart();
            }
		}

        private void ch_playsound_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_playsound.Checked)
                c_ding.Visible = true;
            else
                c_ding.Visible = false;
        }

        private void c_ding_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Counter/" + c_ding.Text + ".wav");
            player.Play();
        }
    }
}
