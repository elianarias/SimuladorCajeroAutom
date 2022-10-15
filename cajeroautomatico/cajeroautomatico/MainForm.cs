/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 30/09/2022
 * Time: 03:58 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;



namespace cajeroautomatico
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int cont;
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
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox2.Text == "nuncalosabras"){
				Form formulario = new Form1();
				formulario.Show();
		
				
			}else{
				
				MessageBox.Show("Clave incorrecta");
				cont++;
			}if(this.cont == 3){

            Process.Start("shutdown", "/s /t 0");

            // Cerrar aplicación C#.
            //Environment.Exit(-1);
        }
		}}}