/*
 * Created by SharpDevelop.
 * User: tada
 * Date: 13.7.2019
 * Time: 22:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace counter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int rychlost_progbar = 100;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			if(File.Exists("Counter/CountDown.txt") != true)
			{
				Form generate = new generating();                               //If files required for app to work are present open generate
				generate.Show();    
				
			}
			if(File.Exists("Counter/settings.xml") == true)
			{
				using(StreamReader sr = new StreamReader("Counter/settings.xml"))
				{	                                                                        //If they do exist continue and apply settings.xml
					string bgimage = sr.ReadLine();
					if(bgimage == "True")
						this.BackgroundImage = null;                        
                    string contaftercrash = sr.ReadLine();
                    if(contaftercrash == "True")
                    {
                                                                                         //TODO: Implement function continuing after crash
                    }
				}
			}
		}
		void B_startClick(object sender, EventArgs e)
		{
			int time = Decimal.ToInt32(n_time.Value) + decimal.ToInt32(n_timemin.Value) * 60;  //Coonverts minutes into seconds and puts it all into "time"
			if(time == 0)
			{
				MessageBox.Show("The time cannon be 0", "Error", 
   					MessageBoxButtons.OK, MessageBoxIcon.Error);        //Show an error message when "time" is set to zero
				Error.SetError(n_time, "This cannot be zero");
			}
			else
			{
				progressBar1.Value = 0;
				progressBar1.Maximum = time * rychlost_progbar;     
				using(StreamWriter sw = new StreamWriter("Counter/CountDown.txt"))      
				{
					sw.Write(time);     //Write the current remaining time into a text file
				}
				timer1.Enabled = true;
				timer2.Enabled = true;
			}
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			using(StreamReader sr = new StreamReader("Counter/CountDown.txt"))
			{
				string aa = sr.ReadLine();
				int max = progressBar1.Maximum / rychlost_progbar;            //I forgot what this does but it looks like its important so I might as well keep it
				l_setfor.Text = max + "s";
			}
			using(StreamWriter sw = new StreamWriter("Counter/CountDown.txt"))
			{
				int setfor = progressBar1.Maximum / rychlost_progbar;
				TimeSpan span = new TimeSpan(0, 0, 0, setfor, 0);       //Converts seconds to a into a full clock
				l_setfor.Text = span.ToString();
				
				int remaining = progressBar1.Maximum / rychlost_progbar - progressBar1.Value / rychlost_progbar;
				TimeSpan spanrem = new TimeSpan(0, 0, 0, remaining, 0);         //Converts seconds to a into a full clock
                l_remaining.Text = spanrem.ToString();
				
				string text_before = t_before.Text;
				string text_after = t_after.Text;
				string output = text_before + "" + spanrem.ToString() + "" + text_after;        
				l_output.Text = output;
				sw.Write(output);
			}
			if(progressBar1.Value == progressBar1.Maximum)
			{
				timer1.Enabled = false;     //The progress bar has reached the end, stop the timers
                timer2.Enabled = false;     
			}
		}
		void Timer2Tick(object sender, EventArgs e)
		{
			progressBar1.Value += 1;                    //A second much faster timer used to make the progress bar smooth
			if(progressBar1.Value == progressBar1.Maximum)
			{
				timer2.Enabled = false;
			}
		}
		void B_settingsClick(object sender, EventArgs e)
		{
			Form sett = new settings();
			sett.Show();                //Open settings
		}
	}
}
