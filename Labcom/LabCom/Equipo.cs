using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCom
{
	public class Equipo //Esta clase es identidad, solo son constructores
	{
		public int Id { get; set; }
		public string Salon { get; set; }
		public string Maquina { get; set; }
		public string Modelo { get; set; }
		public string Num_Se { get; set; }
		public string NumUnitec { get; set; }
		public string Dir_Ip { get; set; }
		public string Nodo { get; set; }
		
		public Equipo() { }

		public Equipo(int pId, string pSalon, string pMaquina, string pModelo, string pNum_Se, string pNumUnitec, string pDir_Ip, string pNodo)
		{
			this.Id = pId;
			this.Salon = pSalon;
			this.Maquina = pMaquina;
			this.Modelo = pModelo;
			this.Num_Se = pNum_Se;
			this.NumUnitec = pNumUnitec;
			this.Dir_Ip = pDir_Ip;
			this.Nodo = pNodo;

		}
	}
}
