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
	public partial class BusqIP : Form
	{
		public BusqIP()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			dgvFiltrado.DataSource = EquipoMetodos.BuscarIp(txtIP.Text);
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			Bmaquina.exportaraexcel(dgvFiltrado);
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			//Bmaquina bmaquina = new Bmaquina();
			this.Hide();
			//bmaquina.Show();
		}
	}
}
