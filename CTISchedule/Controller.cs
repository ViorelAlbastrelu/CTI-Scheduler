using CTISchedule.Models;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTISchedule
{
	public class Controller
	{
		
		private CTIScheduleDBEntities _context;
		public Controller(CTIScheduleDBEntities context)
		{
			_context = context;
		}

		/*
		 * Profesor */

		public Profesor AddUpdateProfesor(Profesor req)
		{
			Profesor profesor;
			if (req.Id != 0) {
				profesor = _context.Profesors.First(p => p.Id == req.Id);
				profesor.Nume = req.Nume;
				profesor.Prenume = req.Prenume;
				profesor.Email = req.Email;
				profesor.Titlu = req.Titlu;
			}
			else profesor = _context.Profesors.Add(new Profesor(req));
			
			_context.SaveChanges();
			return profesor;
		}

		public void DeleteProfesor(int profesorId)
		{
			var profesor =_context.Profesors.Find(profesorId);
			if(profesor != null) _context.Profesors.Remove(profesor); _context.SaveChanges();
		}

	}
}
