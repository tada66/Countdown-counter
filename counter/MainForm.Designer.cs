/*
 * Created by SharpDevelop.
 * User: tada
 * Date: 13.7.2019
 * Time: 22:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace counter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button b_start;
		private System.Windows.Forms.NumericUpDown n_time;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label l_setfor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label l_remaining;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox t_before;
		private System.Windows.Forms.TextBox t_after;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.ErrorProvider Error;
		private System.Windows.Forms.Label l_output;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button b_settings;
		private System.Windows.Forms.NumericUpDown n_timemin;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.b_start = new System.Windows.Forms.Button();
            this.n_time = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.l_setfor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_remaining = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_before = new System.Windows.Forms.TextBox();
            this.t_after = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.l_output = new System.Windows.Forms.Label();
            this.b_settings = new System.Windows.Forms.Button();
            this.n_timemin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.b_lock = new System.Windows.Forms.Button();
            this.b_unlock = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.t_endtext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.n_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_timemin)).BeginInit();
            this.SuspendLayout();
            // 
            // b_start
            // 
            this.b_start.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_start.Location = new System.Drawing.Point(388, 243);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(223, 91);
            this.b_start.TabIndex = 0;
            this.b_start.Text = "Start the Countdown";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.B_startClick);
            // 
            // n_time
            // 
            this.n_time.Location = new System.Drawing.Point(421, 9);
            this.n_time.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.n_time.Name = "n_time";
            this.n_time.Size = new System.Drawing.Size(114, 20);
            this.n_time.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 340);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(538, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // l_setfor
            // 
            this.l_setfor.BackColor = System.Drawing.Color.Transparent;
            this.l_setfor.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_setfor.ForeColor = System.Drawing.Color.White;
            this.l_setfor.Location = new System.Drawing.Point(242, 243);
            this.l_setfor.Name = "l_setfor";
            this.l_setfor.Size = new System.Drawing.Size(313, 23);
            this.l_setfor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Countdown length:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Countdown has been set for";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Time remaining";
            // 
            // l_remaining
            // 
            this.l_remaining.BackColor = System.Drawing.Color.Transparent;
            this.l_remaining.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_remaining.ForeColor = System.Drawing.Color.White;
            this.l_remaining.Location = new System.Drawing.Point(242, 266);
            this.l_remaining.Name = "l_remaining";
            this.l_remaining.Size = new System.Drawing.Size(313, 23);
            this.l_remaining.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Message before time:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Message after time:";
            // 
            // t_before
            // 
            this.t_before.Location = new System.Drawing.Point(195, 45);
            this.t_before.Name = "t_before";
            this.t_before.Size = new System.Drawing.Size(407, 20);
            this.t_before.TabIndex = 6;
            // 
            // t_after
            // 
            this.t_after.Location = new System.Drawing.Point(195, 71);
            this.t_after.Name = "t_after";
            this.t_after.Size = new System.Drawing.Size(407, 20);
            this.t_after.TabIndex = 6;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            this.Error.Icon = ((System.Drawing.Icon)(resources.GetObject("Error.Icon")));
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Live output:";
            // 
            // l_output
            // 
            this.l_output.BackColor = System.Drawing.Color.Transparent;
            this.l_output.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_output.ForeColor = System.Drawing.Color.Black;
            this.l_output.Location = new System.Drawing.Point(112, 122);
            this.l_output.Name = "l_output";
            this.l_output.Size = new System.Drawing.Size(282, 23);
            this.l_output.TabIndex = 4;
            // 
            // b_settings
            // 
            this.b_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_settings.BackgroundImage")));
            this.b_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_settings.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_settings.Location = new System.Drawing.Point(587, 340);
            this.b_settings.Name = "b_settings";
            this.b_settings.Size = new System.Drawing.Size(24, 23);
            this.b_settings.TabIndex = 7;
            this.b_settings.UseVisualStyleBackColor = true;
            this.b_settings.Click += new System.EventHandler(this.B_settingsClick);
            // 
            // n_timemin
            // 
            this.n_timemin.Location = new System.Drawing.Point(195, 9);
            this.n_timemin.Name = "n_timemin";
            this.n_timemin.Size = new System.Drawing.Size(136, 20);
            this.n_timemin.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(329, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(532, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Seconds";
            // 
            // b_lock
            // 
            this.b_lock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_lock.BackgroundImage")));
            this.b_lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_lock.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_lock.Location = new System.Drawing.Point(557, 340);
            this.b_lock.Name = "b_lock";
            this.b_lock.Size = new System.Drawing.Size(24, 23);
            this.b_lock.TabIndex = 9;
            this.b_lock.UseVisualStyleBackColor = true;
            this.b_lock.Click += new System.EventHandler(this.b_lock_Click);
            // 
            // b_unlock
            // 
            this.b_unlock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_unlock.BackgroundImage")));
            this.b_unlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_unlock.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_unlock.Location = new System.Drawing.Point(557, 340);
            this.b_unlock.Name = "b_unlock";
            this.b_unlock.Size = new System.Drawing.Size(24, 23);
            this.b_unlock.TabIndex = 10;
            this.b_unlock.UseVisualStyleBackColor = true;
            this.b_unlock.Click += new System.EventHandler(this.b_unlock_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Endtext:";
            // 
            // t_endtext
            // 
            this.t_endtext.Location = new System.Drawing.Point(195, 97);
            this.t_endtext.Name = "t_endtext";
            this.t_endtext.Size = new System.Drawing.Size(407, 20);
            this.t_endtext.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(623, 375);
            this.Controls.Add(this.b_unlock);
            this.Controls.Add(this.b_lock);
            this.Controls.Add(this.n_timemin);
            this.Controls.Add(this.b_settings);
            this.Controls.Add(this.t_endtext);
            this.Controls.Add(this.t_after);
            this.Controls.Add(this.t_before);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.n_time);
            this.Controls.Add(this.l_output);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_remaining);
            this.Controls.Add(this.l_setfor);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CountDown timer";
            ((System.ComponentModel.ISupportInitialize)(this.n_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_timemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button b_unlock;
        private System.Windows.Forms.Button b_lock;
        private System.Windows.Forms.TextBox t_endtext;
        private System.Windows.Forms.Label label9;
    }
}
