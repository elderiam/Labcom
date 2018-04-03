using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LabCom
{
	public class BdConnect
	{
		public static MySqlConnection ObtenerConexion()
		{
				MySqlConnection connection = new MySqlConnection("Server = localhost; Database = labcom; Uid = root; Pwd =;");
				connection.Open();
				return connection;
		}
	}
}
