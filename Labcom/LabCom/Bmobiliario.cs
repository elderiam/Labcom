using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCom
{
	public partial class Bmobiliario : Form
	{
		public Bmobiliario()
		{
			InitializeComponent();
		}

		public CMobiliario MobiliarioSeleccionado { get; set; }

		private void Bmobiliario_Load(object sender, EventArgs e)
		{

		}

		private void Buscar_Click(object sender, EventArgs e)
		{
			dgvBuscar.DataSource = MobiliarioMetodos.Buscar(txtPiso.Text, txtSalon.Text);
		}

		private void Aceptar_Click(object sender, EventArgs e)
		{
			if (dgvBuscar.SelectedRows.Count == 1)
			{
				int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
				MobiliarioSeleccionado = MobiliarioMetodos.ObtenerMobiliario(id);

				this.Close();
			}
			else
			{
				MessageBox.Show("Debe de seleccionar un elemento");
			}
		}

		private void Excel_Click(object sender, EventArgs e)
		{
			Bmaquina.exportaraexcel(dgvBuscar);
		}

		private void btnMostrar_Click(object sender, EventArgs e)
		{
			dgvBuscar.DataSource = MobiliarioMetodos.MostrarTodo();
		}

		private void Filtrado_Click(object sender, EventArgs e)
		{
			Bpisos filtradoMobi = new Bpisos();
			filtradoMobi.Show();
		}

		private void Salir_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
