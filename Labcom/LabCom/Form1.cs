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
using MySql.Data;

namespace LabCom
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
			IniciarConexion();
		}

		public void IniciarConexion()//Es el metodo de la conexion con la BD
		{
			try
			{
				BdConnect.ObtenerConexion();
				MessageBox.Show("Conectado a la BD");
			}
			catch (MySqlException)
			{
				MessageBox.Show("Ocurrio un error al conectarse con la BD");
			}

		}

		public void login(string usuario, string password)//Metodo de login
		{
			try
			{
				MySqlCommand b_usr = new MySqlCommand("select nombre, tipo_usr from usr where usuario = '"+usuario+"' and password = '"+password+"' ", BdConnect.ObtenerConexion());
				b_usr.Parameters.AddWithValue("usuario", usuario);
				b_usr.Parameters.AddWithValue("password", password);
				MySqlDataAdapter sda = new MySqlDataAdapter(b_usr);
				DataTable dt = new DataTable();
				sda.Fill(dt);

				if (dt.Rows.Count == 1)
				{
					this.Hide();
					if(dt.Rows[0][1].ToString() == "Admin")
					{
						new Administrador().Show();


					}else if(dt.Rows[0][1].ToString() == "Usuario")
					{
						new Usurario().Show();
					}
				}
				else
				{
					MessageBox.Show("Usuario y/o Contrasena Incorrecta");
				}
				
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				BdConnect.ObtenerConexion().Close();
			}




		}


		private void button1_Click(object sender, EventArgs e)
		{
			//Mandamos a llamar el metodo de login			
			login(this.txtUsuario.Text, this.txtPassword.Text);
			txtPassword.Focus();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void chkMostrar_CheckedChanged(object sender, EventArgs e)
		{
			if(chkMostrar.Checked == true)
			{
				if(txtPassword.PasswordChar == '*')
				{
					txtPassword.PasswordChar = '\0';
				}
			}
			else
			{
				txtPassword.PasswordChar = '*';
			}
		}
	}
}
