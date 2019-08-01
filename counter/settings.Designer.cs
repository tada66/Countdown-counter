/*
 * Created by SharpDevelop.
 * User: tada
 * Date: 15.7.2019
 * Time: 14:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace counter
{
	partial class settings
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ErrorProvider info;
		private System.Windows.Forms.CheckBox ch_bgimage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button b_cancel;
		private System.Windows.Forms.Button b_save;
		private System.Windows.Forms.ErrorProvider ErrorNigga;
		private System.Windows.Forms.CheckBox ch_contaftercrash;
		private System.Windows.Forms.Label label3;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.info = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ch_bgimage = new System.Windows.Forms.CheckBox();
            this.b_save = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.ErrorNigga = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ch_contaftercrash = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.c_color = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNigga)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.ContainerControl = this;
            this.info.Icon = ((System.Drawing.Icon)(resources.GetObject("info.Icon")));
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Disable background image:\r\n";
            // 
            // ch_bgimage
            // 
            this.ch_bgimage.Location = new System.Drawing.Point(177, 30);
            this.ch_bgimage.Name = "ch_bgimage";
            this.ch_bgimage.Size = new System.Drawing.Size(17, 24);
            this.ch_bgimage.TabIndex = 1;
            this.ch_bgimage.UseVisualStyleBackColor = true;
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(149, 204);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(123, 45);
            this.b_save.TabIndex = 2;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.B_saveClick);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(12, 204);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(123, 45);
            this.b_cancel.TabIndex = 2;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.B_cancelClick);
            // 
            // ErrorNigga
            // 
            this.ErrorNigga.ContainerControl = this;
            this.ErrorNigga.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorNigga.Icon")));
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Continue after a crash:";
            // 
            // ch_contaftercrash
            // 
            this.ch_contaftercrash.Location = new System.Drawing.Point(149, 8);
            this.ch_contaftercrash.Name = "ch_contaftercrash";
            this.ch_contaftercrash.Size = new System.Drawing.Size(17, 24);
            this.ch_contaftercrash.TabIndex = 3;
            this.ch_contaftercrash.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Background color:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Beep when end";
            // 
            // c_color
            // 
            this.c_color.FormattingEnabled = true;
            this.c_color.Items.AddRange(new object[] {
            "White",
            "Light grey",
            "Dark grey",
            "Red",
            "Green",
            "Blue"});
            this.c_color.Location = new System.Drawing.Point(129, 55);
            this.c_color.Name = "c_color";
            this.c_color.Size = new System.Drawing.Size(121, 21);
            this.c_color.TabIndex = 6;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.c_color);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ch_contaftercrash);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.ch_bgimage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settings";
            this.Text = "settings";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNigga)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox c_color;
    }
}
