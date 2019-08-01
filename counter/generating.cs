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

namespace counter
{
	/// <summary>
	/// Generates everything
	/// </summary>
	public partial class generating : Form
	{
		public generating()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			l_generating.Visible = false;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if(progressBar1.Value == 10)
			{
				string folderName = @"";
				string pathString = System.IO.Path.Combine(folderName, "Counter");
				System.IO.Directory.CreateDirectory(pathString);                    //Generate the folder "Counter"
				l_generating.Text = "Generating countdown text file...";
			}
			if(progressBar1.Value == 60)
			{   
				using(StreamWriter sw = new StreamWriter("Counter/countdown.txt"));     //Generate countdown.txt 
				l_generating.Text = "Generating settings...";           
			}
			if(progressBar1.Value == 110)
			{
				using(StreamWriter sw = new StreamWriter("Counter/settings.xml"));
				l_generating.Text = "Files generated succesfully. You can close this window now.";  //Generate settings.xml and shut timer off
				progressBar1.Value = progressBar1.Value + 10;
				timer1.Enabled = false;
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
