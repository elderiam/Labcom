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
	public partial class Mobiliario : Form
	{
		public Mobiliario()
		{
			InitializeComponent();
		}

		public CMobiliario mobiliarioActual { get; set; }

		private void Mobiliario_Load(object sender, EventArgs e)
		{
			Deshabilitar();
		}

		private void txtModelo_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtPiso.Text) || string.IsNullOrWhiteSpace(txtSalon.Text) /*||
			   string.IsNullOrWhiteSpace(txtSilla.Text) || string.IsNullOrWhiteSpace(txtMesa.Text) ||
			   string.IsNullOrWhiteSpace(txtPizarron.Text) || string.IsNullOrWhiteSpace(txtCañon.Text) ||
			   string.IsNullOrWhiteSpace(txtPantalla.Text) || string.IsNullOrWhiteSpace(txtRack.Text)||
			   string.IsNullOrWhiteSpace(txtSwitch.Text) || string.IsNullOrWhiteSpace(txtRouter.Text)||
			   string.IsNullOrWhiteSpace(txtRestirador.Text)*/)

				MessageBox.Show("Hay uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			else
			{
				CMobiliario mobiliario = new CMobiliario();
				mobiliario.Piso = txtPiso.Text.Trim(); //Trim() = quita los caracteres en blanco a la der o izq
				mobiliario.Salon = txtSalon.Text.Trim();
				mobiliario.Silla = txtSilla.Text.Trim();
				mobiliario.Mesa = txtMesa.Text.Trim();
				mobiliario.Pizarron = txtPizarron.Text.Trim();
				mobiliario.Canon = txtCañon.Text.Trim();
				mobiliario.Pantalla = txtPantalla.Text.Trim();
				mobiliario.Rack = txtRack.Text.Trim();
				mobiliario.Switch = txtSwitch.Text.Trim();
				mobiliario.Router = txtRouter.Text.Trim();
				mobiliario.Restirador = txtRestirador.Text.Trim();

				int resultado = MobiliarioMetodos.Agregar(mobiliario);


				if (resultado > 0)
				{
					MessageBox.Show("Mobiliario Registrado!!", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Limpiar();
					Deshabilitar();
				}
				else
				{
					MessageBox.Show("No se guardo el mobiliario", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtPiso.Text) || string.IsNullOrWhiteSpace(txtSalon.Text) /*||
				string.IsNullOrWhiteSpace(txtSilla.Text) || string.IsNullOrWhiteSpace(txtMesa.Text) ||
				string.IsNullOrWhiteSpace(txtPizarron.Text) || string.IsNullOrWhiteSpace(txtCañon.Text) ||
				string.IsNullOrWhiteSpace(txtPantalla.Text) || string.IsNullOrWhiteSpace(txtRack.Text) ||
				string.IsNullOrWhiteSpace(txtSwitch.Text) || string.IsNullOrWhiteSpace(txtRouter.Text) ||
				string.IsNullOrWhiteSpace(txtRestirador.Text)*/)

				MessageBox.Show("Hay uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			else
			{

				CMobiliario pmobiliario = new CMobiliario();
				pmobiliario.Piso = txtPiso.Text.Trim(); //Trim() = quita los caracteres en blanco a la der o izq
				pmobiliario.Salon = txtSalon.Text.Trim();
				pmobiliario.Silla = txtSilla.Text.Trim();
				pmobiliario.Mesa = txtMesa.Text.Trim();
				pmobiliario.Pizarron = txtPizarron.Text.Trim();
				pmobiliario.Canon = txtCañon.Text.Trim();
				pmobiliario.Pantalla = txtPantalla.Text.Trim();
				pmobiliario.Rack = txtRack.Text.Trim();
				pmobiliario.Switch = txtSwitch.Text.Trim();
				pmobiliario.Router = txtRouter.Text.Trim();
				pmobiliario.Restirador = txtRestirador.Text.Trim();
				pmobiliario.Id = mobiliarioActual.Id;

				if (MobiliarioMetodos.Actualizar(pmobiliario) > 0)
				{
					MessageBox.Show("El mobiliario se actualizo", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Limpiar();
					Deshabilitar();
				}
				else
				{
					MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

				}
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Estas seguro que deseas eliminar ", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (MobiliarioMetodos.Eliminar(mobiliarioActual.Id) > 0)
				{
					MessageBox.Show("Eliminado Correctamente!!", "Equipo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Limpiar();
					Deshabilitar();
				}
				else
				{
					MessageBox.Show("No se pudo eliminar", "Equipo No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Limpiar();
			Deshabilitar();
		}

		private void Salir_Click(object sender, EventArgs e)
		{
			Administrador administrador = new Administrador();
			this.Hide();
			administrador.Show();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			Bmobiliario bmobiliario = new Bmobiliario();
			bmobiliario.ShowDialog();
			if (bmobiliario.MobiliarioSeleccionado != null)
			{
				mobiliarioActual = bmobiliario.MobiliarioSeleccionado;
				txtPiso.Text = bmobiliario.MobiliarioSeleccionado.Piso;
				txtSalon.Text = bmobiliario.MobiliarioSeleccionado.Salon;
				txtSilla.Text = bmobiliario.MobiliarioSeleccionado.Silla;
				txtMesa.Text = bmobiliario.MobiliarioSeleccionado.Mesa;
				txtPizarron.Text = bmobiliario.MobiliarioSeleccionado.Pizarron;
				txtCañon.Text = bmobiliario.MobiliarioSeleccionado.Canon;
				txtPantalla.Text = bmobiliario.MobiliarioSeleccionado.Pantalla;
				txtRack.Text = bmobiliario.MobiliarioSeleccionado.Rack;
				txtSwitch.Text = bmobiliario.MobiliarioSeleccionado.Switch;
				txtRouter.Text = bmobiliario.MobiliarioSeleccionado.Router;
				txtRestirador.Text = bmobiliario.MobiliarioSeleccionado.Restirador;

				btnActualizar.Enabled = true;
				btnEliminar.Enabled = true;
				Habilitar();
				btnGuardar.Enabled = false;
			}
			
		}

		void Limpiar()
		{
			txtPiso.Clear();
			txtSalon.Clear();
			txtSilla.Clear();
			txtMesa.Clear();
			txtPizarron.Clear();
			txtCañon.Clear();
			txtPantalla.Clear();
			txtRack.Clear();
			txtSwitch.Clear();
			txtRouter.Clear();
			txtRestirador.Clear();
		}

		void Habilitar()
		{
			txtPiso.Enabled = true;
			txtSalon.Enabled = true;
			txtSilla.Enabled = true;
			txtMesa.Enabled = true;
			txtPizarron.Enabled = true;
			txtCañon.Enabled = true;
			txtPantalla.Enabled = true;
			txtRack.Enabled = true;
			txtSwitch.Enabled = true;
			txtRouter.Enabled = true;
			txtRestirador.Enabled = true;
			btnGuardar.Enabled = true;
			btnCancelar.Enabled = true;

		}
		void Deshabilitar()
		{
			txtPiso.Enabled = false;
			txtSalon.Enabled = false;
			txtSilla.Enabled = false;
			txtMesa.Enabled = false;
			txtPizarron.Enabled = false;
			txtCañon.Enabled = false;
			txtPantalla.Enabled = false;
			txtRack.Enabled = false;
			txtSwitch.Enabled = false;
			txtRouter.Enabled = false;
			txtRestirador.Enabled = false;
			btnGuardar.Enabled = false;
			btnEliminar.Enabled = false;
			btnActualizar.Enabled = false;
			btnCancelar.Enabled = false;

			btnNuevo.Enabled = true;
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			Limpiar();
			Habilitar();
		}
	}
}
