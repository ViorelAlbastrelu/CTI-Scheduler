using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTISchedule.Models
{
	public partial class Profesor
	{
		public Profesor(Profesor req)
		{
			Nume = req.Nume;
			Prenume = req.Prenume;
			Titlu = req.Titlu;
			Email = req.Email;
		}
	}

}
