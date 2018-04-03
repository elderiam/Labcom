using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCom
{
	public class CMobiliario
	{

		public int Id { get; set; }
		public string Piso { get; set; }
		public string Salon { get; set; }
		public string Silla { get; set; }
		public string Mesa { get; set; }
		public string Pizarron { get; set; }
		public string Canon { get; set; }
		public string Pantalla { get; set; }
		public string Rack { get; set; }
		public string Switch { get; set; }
		public string Router { get; set; }
		public string Restirador { get; set; }

		public CMobiliario() { }

		public CMobiliario(int pId, string pPiso, string pSalon, string pSilla, string pMesa, string pPizarron, string pCanon, string pPantalla, string pRack, string pSwitch, string pRouter, string pRestirador)
		{
			this.Id = pId;
			this.Piso = pPiso;
			this.Salon = pSalon;
			this.Silla = pSilla;
			this.Mesa = pMesa;
			this.Pizarron = pPizarron;
			this.Canon = pCanon;
			this.Pantalla = pPantalla;
			this.Rack = pRack;
			this.Switch = pSwitch;
			this.Router = pRouter;
			this.Restirador = pRestirador;
		}
	}
}
