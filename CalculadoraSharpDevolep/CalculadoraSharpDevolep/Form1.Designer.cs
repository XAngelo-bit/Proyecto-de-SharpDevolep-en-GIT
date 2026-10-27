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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbllA
			// 
			this.lbllA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbllA.Location = new System.Drawing.Point(26, 272);
			this.lbllA.Name = "lbllA";
			this.lbllA.Size = new System.Drawing.Size(122, 42);
			this.lbllA.TabIndex = 0;
			this.lbllA.Text = "A:";
			// 
			// lblB
			// 
			this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblB.Location = new System.Drawing.Point(26, 333);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(126, 44);
			this.lblB.TabIndex = 1;
			this.lblB.Text = "B:";
			// 
			// lblC
			// 
			this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblC.Location = new System.Drawing.Point(26, 389);
			this.lblC.Name = "lblC";
			this.lblC.Size = new System.Drawing.Size(126, 35);
			this.lblC.TabIndex = 2;
			this.lblC.Text = "C:";
			// 
			// txtA
			// 
			this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtA.Location = new System.Drawing.Point(273, 272);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(175, 24);
			this.txtA.TabIndex = 3;
			// 
			// txtB
			// 
			this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtB.Location = new System.Drawing.Point(273, 333);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(174, 24);
			this.txtB.TabIndex = 4;
			// 
			// txtC
			// 
			this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtC.Location = new System.Drawing.Point(273, 400);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(174, 24);
			this.txtC.TabIndex = 5;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(592, 475);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(171, 44);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblX1
			// 
			this.lblX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX1.Location = new System.Drawing.Point(559, 262);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(204, 34);
			this.lblX1.TabIndex = 7;
			this.lblX1.Text = "X1=";
			// 
			// lblX2
			// 
			this.lblX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX2.Location = new System.Drawing.Point(559, 323);
			this.lblX2.Name = "lblX2";
			this.lblX2.Size = new System.Drawing.Size(204, 34);
			this.lblX2.TabIndex = 8;
			this.lblX2.Text = "X2=";
			// 
			// btnRegresar
			// 
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(385, 473);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(162, 46);
			this.btnRegresar.TabIndex = 9;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(258, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(257, 224);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(789, 531);
			this.Controls.Add(this.pictureBox1);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
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
