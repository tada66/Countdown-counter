/*
 * Created by SharpDevelop.
 * User: tada
 * Date: 15.7.2019
 * Time: 15:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace counter
{
	partial class generating
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label l_generating;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button b_yes;
		private System.Windows.Forms.ErrorProvider Error;
		private System.Windows.Forms.Button b_no;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generating));
            this.l_generating = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.b_yes = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.b_no = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // l_generating
            // 
            this.l_generating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_generating.Location = new System.Drawing.Point(12, 13);
            this.l_generating.Name = "l_generating";
            this.l_generating.Size = new System.Drawing.Size(562, 106);
            this.l_generating.TabIndex = 0;
            this.l_generating.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 91);
            this.progressBar1.Maximum = 170;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(655, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 10;
            this.progressBar1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Files needed for Countdown timer have not yet been generated. Generate now?";
            // 
            // b_yes
            // 
            this.b_yes.Location = new System.Drawing.Point(480, 8);
            this.b_yes.Name = "b_yes";
            this.b_yes.Size = new System.Drawing.Size(75, 23);
            this.b_yes.TabIndex = 4;
            this.b_yes.Text = "Yes";
            this.b_yes.UseVisualStyleBackColor = true;
            this.b_yes.Click += new System.EventHandler(this.Button1Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            this.Error.Icon = ((System.Drawing.Icon)(resources.GetObject("Error.Icon")));
            // 
            // b_no
            // 
            this.b_no.Location = new System.Drawing.Point(399, 8);
            this.b_no.Name = "b_no";
            this.b_no.Size = new System.Drawing.Size(75, 23);
            this.b_no.TabIndex = 5;
            this.b_no.Text = "No";
            this.b_no.UseVisualStyleBackColor = true;
            this.b_no.Click += new System.EventHandler(this.B_noClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // generating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_no);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.b_yes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_generating);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "generating";
            this.Text = "Generating";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label label2;
    }
}
