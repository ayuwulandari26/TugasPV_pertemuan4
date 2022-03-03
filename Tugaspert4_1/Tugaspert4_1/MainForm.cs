/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 03/03/2022
 * Time: 20:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugaspert4_1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("nama : " + this.tBnama.Text  + " nim : " + this.tBnim.Text  + " Kelas : " + this.tBkelas.Text  + " Mata Kuliah : " + this.tBMatkul.Text);
		}
	}
}
