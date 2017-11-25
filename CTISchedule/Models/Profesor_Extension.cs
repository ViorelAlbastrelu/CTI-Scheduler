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
			Titlu = req.Titlu;
		}
	}

	public class ProfesorList
	{
		public int Id { get; set; }
		public string Nume { get; set; }
	}
}
