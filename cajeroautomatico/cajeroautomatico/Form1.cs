/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 30/09/2022
 * Time: 04:13 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;



namespace cajeroautomatico
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		private int c1000;
        private int x;		
        private int c200;
        private int c100;
        private int c500;
       
        private string mostrar1;
        private string mostrar2;
        private string mostrar3;
        private string mostrar4;
		private int saldocuenta=0;
	    private int carga;
        private string mostrar5;
       
	   
	    private int modif;
	    private int modif2;
	    private int deposito;
        private int y;
	    private int ext;
	   
	   
	     public Form1()
	       {
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
	     	}
	 	
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
			this.carga = Convert.ToInt32(textBox1.Text);
			
			
			}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			this.modif = carga + saldocuenta;
			this.saldocuenta= this.modif;
			textBox3.Text = Convert.ToString(this.modif);
			this.modif= Convert.ToInt32(textBox3.Text);
		}
		
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
		    
		}
		
		
		
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			this.modif2 = Convert.ToInt32(textBox2.Text);
		}
		
		void Button3Click(object sender, EventArgs e)
			{
			this.ext= this.modif - this.modif2;
			this.saldocuenta= this.ext;
			textBox3.Text = Convert.ToString(this.saldocuenta);
		}
	
		
			
		
		void Button4Click(object sender, EventArgs e)
		{
			this.y = Convert.ToInt32(textBox4.Text);
			this.deposito= y + this.saldocuenta;
			textBox3.Text= Convert.ToString(this.deposito);
			this.saldocuenta= Convert.ToInt32(textBox3.Text);
						
		}
			void Button5Click(object sender, EventArgs e)
		{
         this.x= Convert.ToInt32(this.saldocuenta);
				
			while(x>=1000){
            x=x-1000;
            c1000++;
            }
			this.mostrar1 =Convert.ToString(this.c1000);
			textBox5.Text= this.mostrar1;
			
            while(x>=500){
            x=x-500;
            c500++;
            }
			this.mostrar2 =Convert.ToString(this.c500);
			textBox6.Text= this.mostrar2;
            while(x>=200){
            x=x-200;
            c200++;
             }
            this.mostrar3 =Convert.ToString(this.c200);
			textBox7.Text= this.mostrar3;
            while(x>=100){
            x=x-100;
            c100++;
            }
           this.mostrar4 =Convert.ToString(this.c100);
			textBox8.Text= this.mostrar4;
			}	
		
		void Button2Click(object sender, EventArgs e)	
		{
			this.mostrar5= Convert.ToString(this.saldocuenta);
			MessageBox.Show("Su saldo es "+ this.mostrar5);
		}
		
	
		
		
	}}
		
		
	