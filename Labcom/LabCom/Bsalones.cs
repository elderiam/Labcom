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
	public partial class Bsalones : Form
	{
		public Bsalones()
		{
			InitializeComponent();
		}


		private void button3_Click(object sender, EventArgs e)
		{
			dgvFiltrado.DataSource = EquipoMetodos.BuscarFiltrado(txtSalon1.Text, txtSalon2.Text);
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Bmaquina bmaquina = new Bmaquina();
			this.Hide();
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			Bmaquina.exportaraexcel(dgvFiltrado);
		}
	}
}
