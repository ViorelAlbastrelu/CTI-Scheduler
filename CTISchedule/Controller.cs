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

		public bool AddProfesor(ProfesorReq req)
		{
			_context.Profesors.Add(new Profesor(req));
			if (_context.SaveChanges() > 0)
			{
				return true;
			}
			else return false;
		}
	}
}
