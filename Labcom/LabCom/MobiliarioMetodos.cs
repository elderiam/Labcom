using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace LabCom
{
	class MobiliarioMetodos
	{

		public static int Agregar(CMobiliario pMobiliario)
		{
			int retorno = 0;

			try
			{
				MySqlCommand comando = new MySqlCommand(string.Format("Insert into mobiliario (Piso, Salon, Silla, Mesa, Pizarron, Canon, Pantalla, Rack, Switch, Router, Restirador) values ('{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",
																	 pMobiliario.Piso, pMobiliario.Salon, pMobiliario.Silla, pMobiliario.Mesa, pMobiliario.Pizarron, pMobiliario.Canon, pMobiliario.Pantalla, pMobiliario.Rack, pMobiliario.Switch, pMobiliario.Router, pMobiliario.Restirador), BdConnect.ObtenerConexion());

				retorno = comando.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				e.GetBaseException();
			}

			return retorno;
		}

		public static List<CMobiliario> Buscar(string pPiso, string pSalon)
		{
			List<CMobiliario> _lista = new List<CMobiliario>();

			try
			{
				MySqlCommand _comando = new MySqlCommand(String.Format(
				"SELECT id_mobiliario, Piso, Salon, Silla, Mesa, Pizarron, Canon, Pantalla, Rack, Switch, Router, Restirador FROM mobiliario where Piso = '{0}' or Salon = '{1}'", pPiso, pSalon), BdConnect.ObtenerConexion());
				MySqlDataReader _reader = _comando.ExecuteReader();
				while (_reader.Read())
				{
					CMobiliario mobiliario = new CMobiliario();
					mobiliario.Id = _reader.GetInt32(0);
					mobiliario.Piso = _reader.GetString(1);
					mobiliario.Salon = _reader.GetString(2);
					mobiliario.Silla = _reader.GetString(3);
					mobiliario.Mesa = _reader.GetString(4);
					mobiliario.Pizarron = _reader.GetString(5);
					mobiliario.Canon = _reader.GetString(6);
					mobiliario.Pantalla = _reader.GetString(7);
					mobiliario.Rack = _reader.GetString(8);
					mobiliario.Switch = _reader.GetString(9);
					mobiliario.Router = _reader.GetString(10);
					mobiliario.Restirador = _reader.GetString(11);

					_lista.Add(mobiliario);
				}
			}
			catch (Exception e)
			{
				e.GetBaseException();
			}

			return _lista;
		}

		public static List<CMobiliario> BuscarPiso(string pPiso1, string pPiso2)
		{
			List<CMobiliario> _lista = new List<CMobiliario>();

			try
			{
				MySqlCommand _comando = new MySqlCommand(String.Format(
				"SELECT id_mobiliario, Piso, Salon, Silla, Mesa, Pizarron, Canon, Pantalla, Rack, Switch, Router, Restirador FROM mobiliario where Piso = '{0}' or Piso = '{1}'", pPiso1, pPiso2), BdConnect.ObtenerConexion());
				MySqlDataReader _reader = _comando.ExecuteReader();
				while (_reader.Read())
				{
					CMobiliario mobiliario = new CMobiliario();
					mobiliario.Id = _reader.GetInt32(0);
					mobiliario.Piso = _reader.GetString(1);
					mobiliario.Salon = _reader.GetString(2);
					mobiliario.Silla = _reader.GetString(3);
					mobiliario.Mesa = _reader.GetString(4);
					mobiliario.Pizarron = _reader.GetString(5);
					mobiliario.Canon = _reader.GetString(6);
					mobiliario.Pantalla = _reader.GetString(7);
					mobiliario.Rack = _reader.GetString(8);
					mobiliario.Switch = _reader.GetString(9);
					mobiliario.Router = _reader.GetString(10);
					mobiliario.Restirador = _reader.GetString(11);

					_lista.Add(mobiliario);
				}
			}
			catch (Exception e)
			{
				e.GetBaseException();
			}

			return _lista;
		}

		public static List<CMobiliario> MostrarTodo()
		{
			List<CMobiliario> _lista = new List<CMobiliario>();
			MySqlCommand _comando = new MySqlCommand(String.Format("select * from mobiliario"), BdConnect.ObtenerConexion());
			MySqlDataReader _reader = _comando.ExecuteReader();

			while (_reader.Read())
			{
				CMobiliario mobiliario = new CMobiliario();
				mobiliario.Id = _reader.GetInt32(0);
				mobiliario.Piso = _reader.GetString(1);
				mobiliario.Salon = _reader.GetString(2);
				mobiliario.Silla = _reader.GetString(3);
				mobiliario.Mesa = _reader.GetString(4);
				mobiliario.Pizarron = _reader.GetString(5);
				mobiliario.Canon = _reader.GetString(6);
				mobiliario.Pantalla = _reader.GetString(7);
				mobiliario.Rack = _reader.GetString(8);
				mobiliario.Switch = _reader.GetString(9);
				mobiliario.Router = _reader.GetString(10);
				mobiliario.Restirador = _reader.GetString(11);

				_lista.Add(mobiliario);
			}
			return _lista;
		}

		public static CMobiliario ObtenerMobiliario(int pId)
		{
			CMobiliario mobiliario = new CMobiliario();
			MySqlConnection conexion = BdConnect.ObtenerConexion();

			MySqlCommand _comando = new MySqlCommand(String.Format(
					"SELECT id_mobiliario, Piso, Salon, Silla, Mesa, Pizarron, Canon, Pantalla, Rack, Switch, Router, Restirador FROM mobiliario where id_mobiliario = '{0}'", pId), conexion);
			MySqlDataReader _reader = _comando.ExecuteReader();
			while (_reader.Read())
			{
				mobiliario.Id = _reader.GetInt32(0);
				mobiliario.Piso = _reader.GetString(1);
				mobiliario.Salon = _reader.GetString(2);
				mobiliario.Silla = _reader.GetString(3);
				mobiliario.Mesa = _reader.GetString(4);
				mobiliario.Pizarron = _reader.GetString(5);
				mobiliario.Canon = _reader.GetString(6);
				mobiliario.Pantalla = _reader.GetString(7);
				mobiliario.Rack = _reader.GetString(8);
				mobiliario.Switch = _reader.GetString(9);
				mobiliario.Router = _reader.GetString(10);
				mobiliario.Restirador = _reader.GetString(11);

			}

			conexion.Close();
			return mobiliario;
		}

		public static int Actualizar(CMobiliario pMobiliario)
		{
			int retorno = 0;
			MySqlConnection conexion = BdConnect.ObtenerConexion();

			try
			{
				MySqlCommand comando = new MySqlCommand(string.Format("UPDATE mobiliario SET Piso = '{0}', Salon = '{1}', Silla = '{2}', Mesa = '{3}', Pizarron = '{4}', Canon = '{5}', Pantalla = '{6}', Rack = '{7}', Switch = '{8}', Router = '{9}', Restirador = '{10}' where id_mobiliario={11}",
																	  pMobiliario.Piso, pMobiliario.Salon, pMobiliario.Silla, pMobiliario.Mesa, pMobiliario.Pizarron, pMobiliario.Canon, pMobiliario.Pantalla, pMobiliario.Rack, pMobiliario.Switch, pMobiliario.Router, pMobiliario.Restirador, pMobiliario.Id), conexion);
				retorno = comando.ExecuteNonQuery();
				conexion.Close();
			}
			catch (MySqlException e)
			{
				e.GetBaseException();
			}

			return retorno;
		}

		public static int Eliminar(int pId)
		{
			int retorno = 0;
			MySqlConnection conexion = BdConnect.ObtenerConexion();

			MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM mobiliario where id_mobiliario={0}", pId), conexion);
			retorno = comando.ExecuteNonQuery();
			conexion.Close();

			return retorno;
		}



	}
}
