/*
 * Creado por SharpDevelop.
 * Usuario: HP
 * Fecha: 26/10/2026
 * Hora: 19:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraSharpDevolep
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
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
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double a, b, c, discriminante, x1, x2;

    a = Convert.ToDouble(txtA.Text);
    b = Convert.ToDouble(txtB.Text);
    c = Convert.ToDouble(txtC.Text);

    if (a == 0)
    {
        MessageBox.Show("El valor de a no puede ser 0");
    }
    else
    {
        discriminante = b * b - 4 * a * c;

        if (discriminante < 0)
        {
            MessageBox.Show("No hay soluciones reales");
        }
        else
        {
            x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

            lblX1.Text = "x1 = " + Convert.ToString(x1);
            lblX2.Text = "x2 = " + Convert.ToString(x2);
        }
    }
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
