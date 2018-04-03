namespace LabCom
{
	partial class Bmaquina
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnIP = new System.Windows.Forms.Button();
			this.Filtrado = new System.Windows.Forms.Button();
			this.btnMostrar = new System.Windows.Forms.Button();
			this.Buscar = new System.Windows.Forms.Button();
			this.txtEquipo = new System.Windows.Forms.TextBox();
			this.txtSalon = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvBuscar = new System.Windows.Forms.DataGridView();
			this.Aceptar = new System.Windows.Forms.Button();
			this.Excel = new System.Windows.Forms.Button();
			this.Salir = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.btnIP);
			this.groupBox1.Controls.Add(this.Filtrado);
			this.groupBox1.Controls.Add(this.btnMostrar);
			this.groupBox1.Controls.Add(this.Buscar);
			this.groupBox1.Controls.Add(this.txtEquipo);
			this.groupBox1.Controls.Add(this.txtSalon);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(391, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(407, 133);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ingrese los Datos";
			// 
			// btnIP
			// 
			this.btnIP.Location = new System.Drawing.Point(328, 104);
			this.btnIP.Name = "btnIP";
			this.btnIP.Size = new System.Drawing.Size(75, 23);
			this.btnIP.TabIndex = 7;
			this.btnIP.Text = "IP";
			this.btnIP.UseVisualStyleBackColor = true;
			this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
			// 
			// Filtrado
			// 
			this.Filtrado.Location = new System.Drawing.Point(238, 104);
			this.Filtrado.Name = "Filtrado";
			this.Filtrado.Size = new System.Drawing.Size(75, 23);
			this.Filtrado.TabIndex = 6;
			this.Filtrado.Text = "Bsalones";
			this.Filtrado.UseVisualStyleBackColor = true;
			this.Filtrado.Click += new System.EventHandler(this.Filtrado_Click);
			// 
			// btnMostrar
			// 
			this.btnMostrar.Location = new System.Drawing.Point(121, 104);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(100, 23);
			this.btnMostrar.TabIndex = 5;
			this.btnMostrar.Text = "Mostrar Todos";
			this.btnMostrar.UseVisualStyleBackColor = true;
			this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
			// 
			// Buscar
			// 
			this.Buscar.Location = new System.Drawing.Point(19, 104);
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(75, 23);
			this.Buscar.TabIndex = 4;
			this.Buscar.Text = "Buscar";
			this.Buscar.UseVisualStyleBackColor = true;
			this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
			// 
			// txtEquipo
			// 
			this.txtEquipo.Location = new System.Drawing.Point(135, 63);
			this.txtEquipo.Name = "txtEquipo";
			this.txtEquipo.Size = new System.Drawing.Size(100, 20);
			this.txtEquipo.TabIndex = 3;
			// 
			// txtSalon
			// 
			this.txtSalon.Location = new System.Drawing.Point(135, 19);
			this.txtSalon.Name = "txtSalon";
			this.txtSalon.Size = new System.Drawing.Size(100, 20);
			this.txtSalon.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(85, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Equipo";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(85, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Salon";
			// 
			// dgvBuscar
			// 
			this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBuscar.Location = new System.Drawing.Point(250, 173);
			this.dgvBuscar.Name = "dgvBuscar";
			this.dgvBuscar.Size = new System.Drawing.Size(635, 194);
			this.dgvBuscar.TabIndex = 1;
			// 
			// Aceptar
			// 
			this.Aceptar.Location = new System.Drawing.Point(410, 390);
			this.Aceptar.Name = "Aceptar";
			this.Aceptar.Size = new System.Drawing.Size(75, 23);
			this.Aceptar.TabIndex = 5;
			this.Aceptar.Text = "Aceptar";
			this.Aceptar.UseVisualStyleBackColor = true;
			this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
			// 
			// Excel
			// 
			this.Excel.BackColor = System.Drawing.Color.LimeGreen;
			this.Excel.Location = new System.Drawing.Point(526, 390);
			this.Excel.Name = "Excel";
			this.Excel.Size = new System.Drawing.Size(123, 23);
			this.Excel.TabIndex = 6;
			this.Excel.Text = "Exportar a Excel";
			this.Excel.UseVisualStyleBackColor = false;
			this.Excel.Click += new System.EventHandler(this.Salir_Click);
			// 
			// Salir
			// 
			this.Salir.Location = new System.Drawing.Point(704, 390);
			this.Salir.Name = "Salir";
			this.Salir.Size = new System.Drawing.Size(75, 23);
			this.Salir.TabIndex = 7;
			this.Salir.Text = "Salir";
			this.Salir.UseVisualStyleBackColor = true;
			this.Salir.Click += new System.EventHandler(this.Salir_Click_1);
			// 
			// Bmaquina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::LabCom.Properties.Resources.regmaquina;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(897, 425);
			this.Controls.Add(this.Salir);
			this.Controls.Add(this.Aceptar);
			this.Controls.Add(this.Excel);
			this.Controls.Add(this.dgvBuscar);
			this.Controls.Add(this.groupBox1);
			this.Name = "Bmaquina";
			this.Text = "Bmaquina";
			this.Load += new System.EventHandler(this.Bmaquina_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button Buscar;
		private System.Windows.Forms.TextBox txtEquipo;
		private System.Windows.Forms.TextBox txtSalon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvBuscar;
		private System.Windows.Forms.Button Aceptar;
		private System.Windows.Forms.Button Excel;
		private System.Windows.Forms.Button Salir;
		private System.Windows.Forms.Button btnMostrar;
		private System.Windows.Forms.Button Filtrado;
		private System.Windows.Forms.Button btnIP;
	}
}