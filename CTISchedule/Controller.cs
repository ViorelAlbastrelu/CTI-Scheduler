﻿using CTISchedule.Models;
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

        /*
         *  Disciplina */

        public Disciplina AddUpdateDisciplina(Disciplina req)
        {
            Disciplina disciplina;
            if(req.Id != 0)
            {
                disciplina = _context.Disciplinas.Find(req.Id);
                disciplina.Nume = req.Nume;
                disciplina.Credite = req.Credite;
                disciplina.An = req.An;
            }
            else
            {
                disciplina = _context.Disciplinas.Add(new Disciplina()
                {
                    An = req.An,
                    Credite = req.Credite,
                    Nume = req.Nume
                });
            }
            _context.SaveChanges();
            return disciplina;
        }

        public void DeleteDisciplina(int idDisciplina)
        {
            var disciplina = _context.Disciplinas.Find(idDisciplina);
            if (disciplina != null) _context.Disciplinas.Remove(disciplina);
            _context.SaveChanges();
        }
	}
}
