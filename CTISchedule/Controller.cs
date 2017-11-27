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

		public List<ProfesorList> UpdateProfesorDisciplina(int profesorId, int anStudiu)
		{
			var q = from p in _context.Profesors
					join pd in _context.DisciplinaProfesors
					on p.Id equals pd.Id_Profesor
					join d in _context.Disciplinas
					on pd.Id_Disciplina equals d.Id
					where p.Id == profesorId
					where d.An == anStudiu
					select new ProfesorList()
					{
						Id = d.Id,
						Nume = d.Nume
					};
			return q.ToList();
		}

		public void LinkDisciplinaProfesor(int profesorId, int disciplinaId)
		{
			DisciplinaProfesor disciplinaProfesor = new DisciplinaProfesor()
			{
				Id_Disciplina = disciplinaId,
				Id_Profesor = profesorId
			};
			var checkIfExists = _context.DisciplinaProfesors.Where(x => x.Id_Disciplina == disciplinaId && x.Id_Profesor == profesorId).FirstOrDefault();
			if (checkIfExists == null)
			{
				_context.DisciplinaProfesors.Add(disciplinaProfesor);
				_context.SaveChanges();
			}
		}

		public void DeleteLinkDisciplinaProfesor(int profesorId, int disciplinaId)
		{
			_context.DisciplinaProfesors.Remove(_context.DisciplinaProfesors.Where(
				x => x.Id_Profesor.Equals(profesorId) && x.Id_Disciplina.Equals(disciplinaId)
				).First());
			_context.SaveChanges();
		}

		public List<DisciplinaList> GetAvailableProfeosrDisciplinas(int profesorId, int anStudiu)
		{
			var linkedDisciplinas = from dp in _context.DisciplinaProfesors
						join d in _context.Disciplinas
						on dp.Id_Disciplina equals d.Id
						where dp.Id_Profesor == profesorId
						select d.Id;
			var query = from d in _context.Disciplinas
						where !linkedDisciplinas.Contains(d.Id)
						where d.An == anStudiu
						select new DisciplinaList()
						{
							Id = d.Id,
							Nume = d.Nume
						};
			return query.ToList();
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
                disciplina.NumeScurt = req.NumeScurt;
                disciplina.An = req.An;
                disciplina.Semestru = req.Semestru;
            }
            else
            {
                disciplina = _context.Disciplinas.Add(new Disciplina()
                {
                    An = req.An,
                    Nume = req.Nume,
                    NumeScurt = req.NumeScurt,
                    Semestru = req.Semestru
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
