using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;

namespace LabCom
{
	public partial class Bmaquina : Form
	{
		public Bmaquina()
		{
			InitializeComponent();
		}

		public static void exportaraexcel(DataGridView tabla)
		{
			Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

			excel.Application.Workbooks.Add(true);

			int IndiceColumna = 0;

			foreach (DataGridViewColumn col in tabla.Columns)//Columnas
			{
				IndiceColumna++;
				excel.Cells[1, IndiceColumna] = col.Name;
			}

			int IndiceFila = 0;

			foreach (DataGridViewRow row in tabla.Rows)//Filas
			{
				IndiceFila++;
				IndiceColumna = 0;

					foreach(DataGridViewColumn col in tabla.Columns)
				{
					IndiceColumna++;
					excel.Cells[IndiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
				}

			}
			excel.Visible = true;
		}


		public Equipo EquipoSeleccionado { get; set; }

		private void Buscar_Click(object sender, EventArgs e)
		{
			dgvBuscar.DataSource = EquipoMetodos.Buscar(txtSalon.Text, txtEquipo.Text);
		}

		private void Aceptar_Click(object sender, EventArgs e)
		{
				if (dgvBuscar.SelectedRows.Count == 1)
				{
					int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
					EquipoSeleccionado = EquipoMetodos.ObtenerEquipo(id);

					this.Close();
				}
				else
				{
					MessageBox.Show("Debe de seleccionar un elemento");
				}

		}

		private void Bmaquina_Load(object sender, EventArgs e)
		{

		}

		private void Salir_Click(object sender, EventArgs e) //Excel
		{
			exportaraexcel(dgvBuscar);

		}

		private void Salir_Click_1(object sender, EventArgs e)
		{
			RegMaquina regMaquina = new RegMaquina();
			this.Hide();
		}

		private void btnMostrar_Click(object sender, EventArgs e)
		{
			dgvBuscar.DataSource = EquipoMetodos.MostrarTodo();
		}

		private void Filtrado_Click(object sender, EventArgs e)
		{
			Bsalones filtrado = new Bsalones();
			filtrado.Show();


		}

		private void btnIP_Click(object sender, EventArgs e)
		{
			BusqIP busqIP = new BusqIP();
			busqIP.Show();
		}
	}
}
