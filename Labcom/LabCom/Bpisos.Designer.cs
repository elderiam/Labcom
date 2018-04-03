namespace LabCom
{
	partial class Bpisos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnExcel = new System.Windows.Forms.Button();
			this.dgvFiltrado = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.BtnBuscar = new System.Windows.Forms.Button();
			this.txtPiso2 = new System.Windows.Forms.TextBox();
			this.txtPiso1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvFiltrado)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(514, 92);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 11;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnExcel
			// 
			this.btnExcel.BackColor = System.Drawing.Color.LimeGreen;
			this.btnExcel.Location = new System.Drawing.Point(494, 36);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(108, 23);
			this.btnExcel.TabIndex = 10;
			this.btnExcel.Text = "Exportar a Excel";
			this.btnExcel.UseVisualStyleBackColor = false;
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// dgvFiltrado
			// 
			this.dgvFiltrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFiltrado.Location = new System.Drawing.Point(11, 168);
			this.dgvFiltrado.Name = "dgvFiltrado";
			this.dgvFiltrado.Size = new System.Drawing.Size(644, 226);
			this.dgvFiltrado.TabIndex = 9;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.BtnBuscar);
			this.groupBox2.Controls.Add(this.txtPiso2);
			this.groupBox2.Controls.Add(this.txtPiso1);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(207, 14);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(239, 133);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ingrese los Datos";
			// 
			// BtnBuscar
			// 
			this.BtnBuscar.Location = new System.Drawing.Point(96, 104);
			this.BtnBuscar.Name = "BtnBuscar";
			this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
			this.BtnBuscar.TabIndex = 4;
			this.BtnBuscar.Text = "Buscar";
			this.BtnBuscar.UseVisualStyleBackColor = true;
			this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
			// 
			// txtPiso2
			// 
			this.txtPiso2.Location = new System.Drawing.Point(96, 63);
			this.txtPiso2.Name = "txtPiso2";
			this.txtPiso2.Size = new System.Drawing.Size(100, 20);
			this.txtPiso2.TabIndex = 3;
			// 
			// txtPiso1
			// 
			this.txtPiso1.Location = new System.Drawing.Point(96, 22);
			this.txtPiso1.Name = "txtPiso1";
			this.txtPiso1.Size = new System.Drawing.Size(100, 20);
			this.txtPiso1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Piso2";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Piso1";
			// 
			// Bpisos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LabCom.Properties.Resources.regmaquina;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(667, 406);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.dgvFiltrado);
			this.Controls.Add(this.groupBox2);
			this.Name = "Bpisos";
			this.Text = "BusquedaPisos";
			((System.ComponentModel.ISupportInitialize)(this.dgvFiltrado)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.DataGridView dgvFiltrado;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button BtnBuscar;
		private System.Windows.Forms.TextBox txtPiso2;
		private System.Windows.Forms.TextBox txtPiso1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}