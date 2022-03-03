/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 03/03/2022
 * Time: 20:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugaspert4_1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.tBnama = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tBnim = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tBkelas = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tBMatkul = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nama";
			// 
			// tBnama
			// 
			this.tBnama.Location = new System.Drawing.Point(166, 27);
			this.tBnama.Name = "tBnama";
			this.tBnama.Size = new System.Drawing.Size(100, 20);
			this.tBnama.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(29, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "NIM";
			// 
			// tBnim
			// 
			this.tBnim.Location = new System.Drawing.Point(166, 69);
			this.tBnim.Name = "tBnim";
			this.tBnim.Size = new System.Drawing.Size(100, 20);
			this.tBnim.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(29, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Kelas";
			// 
			// tBkelas
			// 
			this.tBkelas.Location = new System.Drawing.Point(166, 122);
			this.tBkelas.Name = "tBkelas";
			this.tBkelas.Size = new System.Drawing.Size(100, 20);
			this.tBkelas.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(29, 175);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Matkul";
			// 
			// tBMatkul
			// 
			this.tBMatkul.Location = new System.Drawing.Point(166, 175);
			this.tBMatkul.Name = "tBMatkul";
			this.tBMatkul.Size = new System.Drawing.Size(100, 20);
			this.tBMatkul.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(313, 207);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "klik saya";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tBMatkul);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tBkelas);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tBnim);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tBnama);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Tugaspert4_1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tBMatkul;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tBkelas;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tBnim;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tBnama;
		private System.Windows.Forms.Label label1;
	}
}
