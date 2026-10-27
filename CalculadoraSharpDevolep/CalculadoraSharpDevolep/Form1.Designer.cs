/*
 * Creado por SharpDevelop.
 * Usuario: HP
 * Fecha: 26/10/2026
 * Hora: 19:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CalculadoraSharpDevolep
{
	partial class Form1
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
			this.lbllA = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.lblC = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblX1 = new System.Windows.Forms.Label();
			this.lblX2 = new System.Windows.Forms.Label();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbllA
			// 
			this.lbllA.Location = new System.Drawing.Point(21, 18);
			this.lbllA.Name = "lbllA";
			this.lbllA.Size = new System.Drawing.Size(122, 42);
			this.lbllA.TabIndex = 0;
			this.lbllA.Text = "A:";
			// 
			// lblB
			// 
			this.lblB.Location = new System.Drawing.Point(21, 67);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(126, 44);
			this.lblB.TabIndex = 1;
			this.lblB.Text = "B:";
			// 
			// lblC
			// 
			this.lblC.Location = new System.Drawing.Point(21, 123);
			this.lblC.Name = "lblC";
			this.lblC.Size = new System.Drawing.Size(126, 35);
			this.lblC.TabIndex = 2;
			this.lblC.Text = "C:";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(287, 18);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(175, 20);
			this.txtA.TabIndex = 3;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(287, 67);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(174, 20);
			this.txtB.TabIndex = 4;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(287, 120);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(174, 20);
			this.txtC.TabIndex = 5;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(310, 365);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(171, 44);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblX1
			// 
			this.lblX1.Location = new System.Drawing.Point(12, 172);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(118, 34);
			this.lblX1.TabIndex = 7;
			this.lblX1.Text = "X1=";
			// 
			// lblX2
			// 
			this.lblX2.Location = new System.Drawing.Point(12, 228);
			this.lblX2.Name = "lblX2";
			this.lblX2.Size = new System.Drawing.Size(118, 34);
			this.lblX2.TabIndex = 8;
			this.lblX2.Text = "X2=";
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(12, 365);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(162, 46);
			this.btnRegresar.TabIndex = 9;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 423);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.lblX2);
			this.Controls.Add(this.lblX1);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.lblC);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lbllA);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Label lblX2;
		private System.Windows.Forms.Label lblX1;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Label lblC;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.Label lbllA;
	}
}
