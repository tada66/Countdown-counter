﻿/*
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
	/// Description of settings.
	/// </summary>
	public partial class settings : Form
	{
		public settings()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			info.SetError(ch_smooth, "Can improve performance on a slow computer");
			info.SetError(ch_bgimage, "Can improve performance on a slow computer");
			info.SetError(ch_contaftercrash, "If the app gets closed, after reopening it will continue from where it stopped");
			using(StreamReader sr = new StreamReader("Counter/settings.xml"))
			{
				string smooth = sr.ReadLine();
				if(smooth == "True")
					ch_smooth.Checked = true;
				string bgimage = sr.ReadLine();
				if(bgimage == "True")
					ch_bgimage.Checked = true;
				
			}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void B_cancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void B_saveClick(object sender, EventArgs e)
		{
			using(StreamWriter sw = new StreamWriter("Counter/settings.xml"))
			{
				sw.WriteLine(ch_smooth.Checked);
				sw.WriteLine(ch_bgimage.Checked);
				
			}
			Application.Restart();
		}
		void Ch_smoothCheckedChanged(object sender, EventArgs e)
		{
			ErrorNigga.SetError(ch_smooth, "Does NOT yet work");
		}
		
	}
}
