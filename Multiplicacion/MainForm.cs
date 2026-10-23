/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 23/10/2026
 * Time: 07:34 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Multiplicacion
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
			double n,c,xd;
			n=Convert.ToDouble(txtNum1.Text);
			c=Convert.ToDouble(txtNum2.Text);
			xd= n*c;
			lblRe.Text=Convert.ToString(xd);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			txtNum1.Text="";
			txtNum2.Text="";
			lblRe.Text="";
		}
	}
}
