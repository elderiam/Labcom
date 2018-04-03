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
	public partial class RegMaquina : Form
	{
		public RegMaquina()
		{
			InitializeComponent();
		}
		public Equipo equipoActual { get; set; }

		private void button2_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(txtSalon.Text) || string.IsNullOrWhiteSpace(txtEquipo.Text) ||
			   string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtNumSe.Text) ||
			   string.IsNullOrWhiteSpace(txtNumUni.Text) || string.IsNullOrWhiteSpace(txtIP.Text) ||
			   string.IsNullOrWhiteSpace(txtNodo.Text))

				MessageBox.Show("Hay uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			else
			{
					Equipo equipo = new Equipo();
					equipo.Salon = txtSalon.Text.Trim();//Trim() = quita los caracteres en blanco a la der o izq
					equipo.Maquina = txtEquipo.Text.Trim();
					equipo.Modelo = txtModelo.Text.Trim();
					equipo.Num_Se = txtNumSe.Text.Trim();
				    equipo.NumUnitec = txtNumUni.Text.Trim();
					equipo.Dir_Ip = txtIP.Text.Trim();
					equipo.Nodo = txtNodo.Text.Trim();

					int resultado = EquipoMetodos.Agregar(equipo);

				
						if (resultado > 0)
						{
							MessageBox.Show("Maquina Registrada!!", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
							Limpiar();
							Deshabilitar();
						}else
						{
						MessageBox.Show("No se guardo la maquina", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Bmaquina bmaquina = new Bmaquina();
			bmaquina.ShowDialog();

			if(bmaquina.EquipoSeleccionado != null)
			{
				equipoActual = bmaquina.EquipoSeleccionado;
				txtSalon.Text = bmaquina.EquipoSeleccionado.Salon;
				txtEquipo.Text = bmaquina.EquipoSeleccionado.Maquina;
				txtModelo.Text = bmaquina.EquipoSeleccionado.Modelo;
				txtNumSe.Text = bmaquina.EquipoSeleccionado.Num_Se;
				txtNumUni.Text = bmaquina.EquipoSeleccionado.NumUnitec;
				txtIP.Text = bmaquina.EquipoSeleccionado.Dir_Ip;
				txtNodo.Text = bmaquina.EquipoSeleccionado.Nodo;

				btnActualizar.Enabled = true;
				btnEliminar.Enabled = true;
				Habilitar();
				btnGuardar.Enabled = false;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(txtSalon.Text) || string.IsNullOrWhiteSpace(txtEquipo.Text) ||
			   string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtNumSe.Text) ||
			   string.IsNullOrWhiteSpace(txtNumUni.Text) || string.IsNullOrWhiteSpace(txtIP.Text) ||
			   string.IsNullOrWhiteSpace(txtNodo.Text))

				MessageBox.Show("Hay uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			else
			{

				Equipo pEquipo = new Equipo();
				pEquipo.Salon = txtSalon.Text.Trim();//Trim() = quita los caracteres en blanco a la der o izq
				pEquipo.Maquina = txtEquipo.Text.Trim();
				pEquipo.Modelo = txtModelo.Text.Trim();
				pEquipo.Num_Se = txtNumSe.Text.Trim();
				pEquipo.NumUnitec = txtNumUni.Text.Trim();
				pEquipo.Dir_Ip = txtIP.Text.Trim();
				pEquipo.Nodo = txtNodo.Text.Trim();
				pEquipo.Id = equipoActual.Id;

				if (EquipoMetodos.Actualizar(pEquipo) > 0)
				{
					MessageBox.Show("Los datos de las maquinas se actualiaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Limpiar();
					Deshabilitar();
				}
				else
				{
					MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

				}
			}
		}

		private void Eliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Estas seguro que deseas eliminar el Equipo Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if(EquipoMetodos.Eliminar(equipoActual.Id) > 0)
				{
					MessageBox.Show("Equipo Eliminado Correctamente!!", "Equipo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Limpiar();
					Deshabilitar();
				}
				else
				{
					MessageBox.Show("No se pudo eliminar el Equipo", "Equipo No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			}
		}


		void Limpiar()
		{
			txtSalon.Clear();
			txtEquipo.Clear();
			txtModelo.Clear();
			txtNumSe.Clear();
			txtNumUni.Clear();
			txtIP.Clear();
			txtNodo.Clear();
		}

		void Habilitar()
		{
			txtSalon.Enabled = true;
			txtEquipo.Enabled = true;
			txtModelo.Enabled = true;
			txtNumSe.Enabled = true;
			txtNumUni.Enabled = true;
			txtIP.Enabled = true;
			txtNodo.Enabled = true;
			btnGuardar.Enabled = true;
			btnCancelar.Enabled = true;
			
		}
		void Deshabilitar()
		{
			txtSalon.Enabled = false;
			txtEquipo.Enabled = false;
			txtModelo.Enabled = false;
			txtNumSe.Enabled = false;
			txtNumUni.Enabled = false;
			txtIP.Enabled = false;
			txtNodo.Enabled = false;
			btnGuardar.Enabled = false;
			btnEliminar.Enabled = false;
			btnActualizar.Enabled = false;
			btnCancelar.Enabled = false;

			btnNuevo.Enabled = true;
		}

		private void Nuevo_Click(object sender, EventArgs e)
		{
			Limpiar();
			Habilitar();
		}

		private void RegMaquina_Load(object sender, EventArgs e)
		{
			Deshabilitar();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Limpiar();
			Deshabilitar();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Administrador administrador = new Administrador();
			this.Hide();
			administrador.Show();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void txtNumUni_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}
	}
}
