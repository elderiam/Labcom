namespace LabCom
{
	partial class Bsalones
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.txtSalon2 = new System.Windows.Forms.TextBox();
			this.txtSalon1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvFiltrado = new System.Windows.Forms.DataGridView();
			this.btnExcel = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFiltrado)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.txtSalon2);
			this.groupBox2.Controls.Add(this.txtSalon1);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(245, 21);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(239, 133);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ingrese los Datos";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(96, 104);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Buscar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// txtSalon2
			// 
			this.txtSalon2.Location = new System.Drawing.Point(96, 63);
			this.txtSalon2.Name = "txtSalon2";
			this.txtSalon2.Size = new System.Drawing.Size(100, 20);
			this.txtSalon2.TabIndex = 3;
			// 
			// txtSalon1
			// 
			this.txtSalon1.Location = new System.Drawing.Point(96, 22);
			this.txtSalon1.Name = "txtSalon1";
			this.txtSalon1.Size = new System.Drawing.Size(100, 20);
			this.txtSalon1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Salon2";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Salon1";
			// 
			// dgvFiltrado
			// 
			this.dgvFiltrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFiltrado.Location = new System.Drawing.Point(49, 175);
			this.dgvFiltrado.Name = "dgvFiltrado";
			this.dgvFiltrado.Size = new System.Drawing.Size(644, 226);
			this.dgvFiltrado.TabIndex = 5;
			// 
			// btnExcel
			// 
			this.btnExcel.BackColor = System.Drawing.Color.LimeGreen;
			this.btnExcel.Location = new System.Drawing.Point(532, 43);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(108, 23);
			this.btnExcel.TabIndex = 6;
			this.btnExcel.Text = "Exportar a Excel";
			this.btnExcel.UseVisualStyleBackColor = false;
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(552, 99);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// Bsalones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LabCom.Properties.Resources.regmaquina;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(705, 424);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.dgvFiltrado);
			this.Controls.Add(this.groupBox2);
			this.Name = "Bsalones";
			this.Text = "BusquedaSalones";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFiltrado)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox txtSalon2;
		private System.Windows.Forms.TextBox txtSalon1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvFiltrado;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.Button btnSalir;
	}
}