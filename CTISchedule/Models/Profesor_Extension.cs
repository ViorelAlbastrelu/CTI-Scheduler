using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTISchedule.Models
{
	public partial class Profesor
	{
		public Profesor() { }
		public Profesor(ProfesorReq req)
		{
			Nume = req.Nume;
			Prenume = req.Prenume;
			Titlu = req.Titlu;
			Email = req.Email;
		}
	}

	public class ProfesorReq {
		public string Nume { get; set; }
		public string Prenume { get; set; }
		public string Email { get; set; }
		public string Titlu { get; set; }
	}
}
