/*
 * Creado por SharpDevelop.
 * Usuario: HP
 * Fecha: 26/10/2026
 * Hora: 18:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CalculadoraSharpDevolep
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
			this.lblNumero1 = new System.Windows.Forms.Label();
			this.lblNumero2 = new System.Windows.Forms.Label();
			this.txtCaja1 = new System.Windows.Forms.TextBox();
			this.txtCaja2 = new System.Windows.Forms.TextBox();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnRestar = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNumero1
			// 
			this.lblNumero1.Location = new System.Drawing.Point(25, 21);
			this.lblNumero1.Name = "lblNumero1";
			this.lblNumero1.Size = new System.Drawing.Size(131, 44);
			this.lblNumero1.TabIndex = 0;
			this.lblNumero1.Text = "Numero 1:";
			// 
			// lblNumero2
			// 
			this.lblNumero2.Location = new System.Drawing.Point(21, 97);
			this.lblNumero2.Name = "lblNumero2";
			this.lblNumero2.Size = new System.Drawing.Size(135, 49);
			this.lblNumero2.TabIndex = 1;
			this.lblNumero2.Text = "Numero 2:";
			// 
			// txtCaja1
			// 
			this.txtCaja1.Location = new System.Drawing.Point(323, 21);
			this.txtCaja1.Name = "txtCaja1";
			this.txtCaja1.Size = new System.Drawing.Size(228, 20);
			this.txtCaja1.TabIndex = 2;
			// 
			// txtCaja2
			// 
			this.txtCaja2.Location = new System.Drawing.Point(323, 97);
			this.txtCaja2.Name = "txtCaja2";
			this.txtCaja2.Size = new System.Drawing.Size(228, 20);
			this.txtCaja2.TabIndex = 3;
			// 
			// btnSuma
			// 
			this.btnSuma.Location = new System.Drawing.Point(12, 187);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(158, 48);
			this.btnSuma.TabIndex = 4;
			this.btnSuma.Text = "Sumar";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// btnRestar
			// 
			this.btnRestar.Location = new System.Drawing.Point(206, 187);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(156, 48);
			this.btnRestar.TabIndex = 5;
			this.btnRestar.Text = "Restar";
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(397, 187);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(154, 48);
			this.btnDividir.TabIndex = 6;
			this.btnDividir.Text = "Dividir";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Location = new System.Drawing.Point(87, 259);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(157, 49);
			this.btnMultiplicar.TabIndex = 7;
			this.btnMultiplicar.Text = "Multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(323, 259);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(149, 49);
			this.btnLimpiar.TabIndex = 8;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(11, 360);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(568, 86);
			this.lblRespuesta.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 462);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.txtCaja2);
			this.Controls.Add(this.txtCaja1);
			this.Controls.Add(this.lblNumero2);
			this.Controls.Add(this.lblNumero1);
			this.Name = "MainForm";
			this.Text = "CalculadoraSharpDevolep";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnRestar;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.TextBox txtCaja2;
		private System.Windows.Forms.TextBox txtCaja1;
		private System.Windows.Forms.Label lblNumero2;
		private System.Windows.Forms.Label lblNumero1;
	}
}
