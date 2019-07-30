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
				Form generate = new generating();
				generate.Show();
				
			}
			if(File.Exists("Counter/settings.xml") == true)
			{
				using(StreamReader sr = new StreamReader("Counter/settings.xml"))
				{
					string smooth = sr.ReadLine();
					if(smooth == "True")
					{
						
					}	
					string bgimage = sr.ReadLine();
					if(bgimage == "True")
						this.BackgroundImage = null;
				}
			}
		}
		void B_startClick(object sender, EventArgs e)
		{
			int cas = Decimal.ToInt32(n_cas.Value) + decimal.ToInt32(n_casmin.Value) * 60;
			if(cas == 0)
			{
				MessageBox.Show("The time cannon be 0", "Error", 
   					MessageBoxButtons.OK, MessageBoxIcon.Error);
				Error.SetError(n_cas, "Your aer teh stupode");
			}
			else
			{
				progressBar1.Value = 0;
				progressBar1.Maximum = cas * rychlost_progbar;
				using(StreamWriter sw = new StreamWriter("Counter/CountDown.txt"))
				{
					sw.Write(cas);
				}
				timer1.Enabled = true;
				timer2.Enabled = true;
			}
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			//progressBar1.Value += 1;
			using(StreamReader sr = new StreamReader("Counter/CountDown.txt"))
			{
				string aa = sr.ReadLine();
				int max = progressBar1.Maximum / rychlost_progbar;
				l_setfor.Text = max + "s";
			}
			using(StreamWriter sw = new StreamWriter("Counter/CountDown.txt"))
			{
				int setfor = progressBar1.Maximum / rychlost_progbar;
				TimeSpan span = new TimeSpan(0, 0, 0, setfor, 0); //Converts seconds to the good shit
				l_setfor.Text = span.ToString();
				
				int remaining = progressBar1.Maximum / rychlost_progbar - progressBar1.Value / rychlost_progbar;
				TimeSpan spanrem = new TimeSpan(0, 0, 0, remaining, 0); //Converts seconds to the good shit
				l_remaining.Text = spanrem.ToString();
				
				string text_before = t_before.Text;
				string text_after = t_after.Text;
				string output = text_before + "" + spanrem.ToString() + "" + text_after;
				l_output.Text = output;
				sw.Write(output);
			}
			if(progressBar1.Value == progressBar1.Maximum)
			{
				timer1.Enabled = false;
				timer2.Enabled = false;
			}
		}
		void Timer2Tick(object sender, EventArgs e)
		{
			progressBar1.Value += 1;
			if(progressBar1.Value == progressBar1.Maximum)
			{
				timer1.Enabled = false;
				timer2.Enabled = false;
			}
		}
		void B_settingsClick(object sender, EventArgs e)
		{
			Form sett = new settings();
			sett.Show();
		}
	}
}
