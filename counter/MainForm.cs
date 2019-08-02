﻿/*
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
	/// The main app
	/// </summary>
	public partial class MainForm : Form
	{
		int rychlost_progbar = 100;
		public MainForm()
		{
			InitializeComponent();
            b_unlock.Visible = false;
			if(File.Exists("Counter/CountDown.txt") != true)
			{
				Form generate = new generating();                               //If files required for app to work are present open generate
				generate.Show();    
			}
            if(File.Exists("Counter/ding.wav") != true)
            {
                Form generate = new generating();                               //If files required for app to work are present open generate
                generate.Show();
            }
			if(File.Exists("Counter/settings.xml") == true)
			{
                using (StreamReader sr = new StreamReader("Counter/settings.xml"))
                {                                                                           //If they do exist continue and apply settings.xml
                    string bgimage = sr.ReadLine();
                    string contaftercrash = sr.ReadLine();
                    string bgcolor = sr.ReadLine();
                    string soundon = sr.ReadLine();
                    if (bgimage == "True")
                    {
                        this.BackgroundImage = null;
                        if (string.IsNullOrEmpty(bgcolor) != true)  // setting bg color for form 
                        {
                            if (bgcolor == "White")
                                this.BackColor = System.Drawing.Color.White;

                            else if (bgcolor == "Light grey")
                                this.BackColor = System.Drawing.Color.LightGray;

                            else if (bgcolor == "Red")
                                this.BackColor = System.Drawing.Color.Red;

                            else if (bgcolor == "Green")
                                this.BackColor = System.Drawing.Color.YellowGreen;

                            else if (bgcolor == "Blue")
                                this.BackColor = System.Drawing.Color.DodgerBlue;

                            else
                                this.BackColor = System.Drawing.Color.Silver;
                        }
                    }
                    if (contaftercrash == "True")
                    {
                        //TODO: Implement function continuing after crash
                    }
                }
			}
		}
		void B_startClick(object sender, EventArgs e)
		{
			int time = Decimal.ToInt32(n_time.Value) + decimal.ToInt32(n_timemin.Value) * 60;  //Converts minutes into seconds and puts it all into "time"
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

        private void b_lock_Click(object sender, EventArgs e)
        {
            b_lock.Visible = false;
            b_start.Enabled = false;        //When lock button is clicked disable b_start and show unlock button
            b_unlock.Visible = true;
        }

        private void b_unlock_Click(object sender, EventArgs e)
        {
            b_start.Enabled = true;
            b_lock.Visible = true;
            b_unlock.Visible = false;
        }
    }
}
