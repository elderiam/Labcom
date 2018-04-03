using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace LabCom
{
	public class EquipoMetodos //Esta clase es donde creo los metodos de agregar,editar,eliminar y buscar
	{
		public static int Agregar(Equipo pEquipo)
		{
			int retorno = 0;

			try
			{
				MySqlCommand comando = new MySqlCommand(string.Format("Insert into inventario (Laboratorio, Equipo, Modelo, NumSe, NumUnitec, ip, Nodo) values ('{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
																	 pEquipo.Salon, pEquipo.Maquina, pEquipo.Modelo, pEquipo.Num_Se, pEquipo.NumUnitec, pEquipo.Dir_Ip, pEquipo.Nodo), BdConnect.ObtenerConexion());

				retorno = comando.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				e.GetBaseException();
			}

			return retorno;
		}

		public static List<Equipo> Buscar(string pSalon, string pEquipo)
		{
			List<Equipo> _lista = new List<Equipo>();

			try
			{
				MySqlCommand _comando = new MySqlCommand(String.Format(
				"SELECT id_invent, Laboratorio, Equipo, Modelo, NumSe, NumUnitec, Ip, Nodo FROM inventario where Laboratorio = '{0}' or Equipo = '{1}'", pSalon, pEquipo), BdConnect.ObtenerConexion());
				MySqlDataReader _reader = _comando.ExecuteReader();
				while (_reader.Read())
				{
					Equipo equipo = new Equipo();
					equipo.Id = _reader.GetInt32(0);
					equipo.Salon = _reader.GetString(1);
					equipo.Maquina = _reader.GetString(2);
					equipo.Modelo = _reader.GetString(3);
					equipo.Num_Se = _reader.GetString(4);
					equipo.NumUnitec = _reader.GetString(5);
					equipo.Dir_Ip = _reader.GetString(6);
					equipo.Nodo = _reader.GetString(7);

					_lista.Add(equipo);
				}
			}
			catch (Exception e)
			{
				e.GetBaseException();
			}

			return _lista;
		}

		public static List<Equipo> BuscarFiltrado(string pSalon1, string pSalon2)
		{
			List<Equipo> _lista = new List<Equipo>();

			try
			{
				MySqlCommand _comando = new MySqlCommand(String.Format(
				"SELECT id_invent, Laboratorio, Equipo, Modelo, NumSe, NumUnitec, Ip, Nodo FROM inventario where Laboratorio = '{0}' or Laboratorio = '{1}'", pSalon1, pSalon2), BdConnect.ObtenerConexion());
				MySqlDataReader _reader = _comando.ExecuteReader();
				while (_reader.Read())
				{
					Equipo equipo = new Equipo();
					equipo.Id = _reader.GetInt32(0);
					equipo.Salon = _reader.GetString(1);
					equipo.Maquina = _reader.GetString(2);
					equipo.Modelo = _reader.GetString(3);
					equipo.Num_Se = _reader.GetString(4);
					equipo.NumUnitec = _reader.GetString(5);
					equipo.Dir_Ip = _reader.GetString(6);
					equipo.Nodo = _reader.GetString(7);

					_lista.Add(equipo);
				}
			}
			catch (Exception e)
			{
				e.GetBaseException();
			}

			return _lista;
		}

		public static List<Equipo> BuscarIp(string pIp)
		{
			List<Equipo> _lista = new List<Equipo>();

			try
			{
				MySqlCommand _comando = new MySqlCommand(String.Format(
				"SELECT id_invent, Laboratorio, Equipo, Modelo, NumSe, NumUnitec, Ip, Nodo FROM inventario where Ip = '{0}'", pIp), BdConnect.ObtenerConexion());
				MySqlDataReader _reader = _comando.ExecuteReader();
				while (_reader.Read())
				{
					Equipo equipo = new Equipo();
					equipo.Id = _reader.GetInt32(0);
					equipo.Salon = _reader.GetString(1);
					equipo.Maquina = _reader.GetString(2);
					equipo.Modelo = _reader.GetString(3);
					equipo.Num_Se = _reader.GetString(4);
					equipo.NumUnitec = _reader.GetString(5);
					equipo.Dir_Ip = _reader.GetString(6);
					equipo.Nodo = _reader.GetString(7);

					_lista.Add(equipo);
				}
			}
			catch (Exception e)
			{
				e.GetBaseException();
			}

			return _lista;
		}

		public static List<Equipo> MostrarTodo()
		{
				List<Equipo> _lista = new List<Equipo>();
				MySqlCommand _comando = new MySqlCommand(String.Format("select * from inventario"), BdConnect.ObtenerConexion());
				MySqlDataReader _reader = _comando.ExecuteReader();

				while (_reader.Read())
				{
					Equipo equipo = new Equipo();
					equipo.Id = _reader.GetInt32(0);
					equipo.Salon = _reader.GetString(1);
					equipo.Maquina = _reader.GetString(2);
					equipo.Modelo = _reader.GetString(3);
					equipo.Num_Se = _reader.GetString(4);
					equipo.NumUnitec = _reader.GetString(5);
					equipo.Dir_Ip = _reader.GetString(6);
					equipo.Nodo = _reader.GetString(7);

					_lista.Add(equipo);
				}
			return _lista;
		}

		public static Equipo ObtenerEquipo(int pId)
		{
			Equipo equipo = new Equipo();
			MySqlConnection conexion = BdConnect.ObtenerConexion();

			MySqlCommand _comando = new MySqlCommand(String.Format(
					"SELECT id_invent, Laboratorio, Equipo, Modelo, NumSe, NumUnitec, ip, Nodo FROM inventario where id_invent = '{0}'", pId), conexion);
			MySqlDataReader _reader = _comando.ExecuteReader();
			while (_reader.Read())
			{
				equipo.Id = _reader.GetInt32(0);
				equipo.Salon = _reader.GetString(1);
				equipo.Maquina = _reader.GetString(2);
				equipo.Modelo = _reader.GetString(3);
				equipo.Num_Se = _reader.GetString(4);
				equipo.NumUnitec = _reader.GetString(5);
				equipo.Dir_Ip = _reader.GetString(6);
				equipo.Nodo = _reader.GetString(7);

			}

			conexion.Close();
			return equipo;
		}

		public  static int Actualizar(Equipo pEquipo)
		{
			int retorno = 0;
			MySqlConnection conexion = BdConnect.ObtenerConexion();

			try
			{
				MySqlCommand comando = new MySqlCommand(string.Format("UPDATE inventario SET Laboratorio = '{0}', Equipo = '{1}', Modelo = '{2}', NumSe = '{3}', NumUnitec = '{4}', ip = '{5}', Nodo = '{6}' where id_invent={7}",
																	  pEquipo.Salon, pEquipo.Maquina, pEquipo.Modelo, pEquipo.Num_Se, pEquipo.NumUnitec, pEquipo.Dir_Ip, pEquipo.Nodo, pEquipo.Id), conexion);

				retorno = comando.ExecuteNonQuery();
				conexion.Close();
			}catch(MySqlException e)
			{
				e.GetBaseException();
			}

			return retorno;
		}

		public static int Eliminar(int pId)
		{
			int retorno = 0;
			MySqlConnection conexion = BdConnect.ObtenerConexion();

			MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM inventario where id_invent={0}", pId), conexion);
			retorno = comando.ExecuteNonQuery();
			conexion.Close();

			return retorno;
		}


	}
}
