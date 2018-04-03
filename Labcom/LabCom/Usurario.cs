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
	public partial class Usurario : Form
	{
		public Usurario()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Rmaquina rmaquina = new Rmaquina();
			rmaquina.Show();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Rimp rimp = new Rimp();
			rimp.Show();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			this.Hide();
			form1.Show();
		}
	}
}
