/*
 * Creado por SharpDevelop.
 * Usuario: HP
 * Fecha: 26/10/2026
 * Hora: 18:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraSharpDevolep
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
		
		void BtnSumaClick(object sender, EventArgs e)
		{
			double num1, num2, suma;
			num1 = Convert.ToDouble(txtCaja1.Text);
			num2 = Convert.ToDouble(txtCaja2.Text);
			suma = num1 + num2;
			lblRespuesta.Text = txtCaja1.Text +" + " +txtCaja2.Text +" = "+Convert.ToString(suma);
			
		}
		
		void BtnRestarClick(object sender, EventArgs e)
		{
			double num1, num2, resta;
			num1 = Convert.ToDouble(txtCaja1.Text);
			num2 = Convert.ToDouble(txtCaja2.Text);
			resta = num1 - num2;
			lblRespuesta.Text = txtCaja1.Text +" - " +txtCaja2.Text +" = "+Convert.ToString(resta);
						
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			double num1, num2, dividir;
			num1 = Convert.ToDouble(txtCaja1.Text);
			num2 = Convert.ToDouble(txtCaja2.Text);
			dividir = num1 / num2;
			lblRespuesta.Text = txtCaja1.Text +" / " +txtCaja2.Text +" = "+Convert.ToString(dividir);			
		}
		
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			double num1, num2, multi;
			num1 = Convert.ToDouble(txtCaja1.Text);
			num2 = Convert.ToDouble(txtCaja2.Text);
			multi = num1 * num2;
			lblRespuesta.Text = txtCaja1.Text +" X " +txtCaja2.Text +" = "+Convert.ToString(multi);			
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtCaja1.Text="";
			txtCaja2.Text="";
			lblRespuesta.Text="";			
		}
		
		void BtnModuloClick(object sender, EventArgs e)
		{
			double num1, num2, modulo;
			num1 = Convert.ToDouble(txtCaja1.Text);
			num2 = Convert.ToDouble(txtCaja2.Text);
			
			if(num2 != 0)
			{
				modulo = num1 % num2;
				lblRespuesta.Text = txtCaja1.Text +" % " +txtCaja2.Text +" = "+Convert.ToString(modulo);	
			}
			else
			{
				MessageBox.Show("No se puede dividir entre 0");
			}
		}
	}
}
