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

        public void TruncateDB()
        {
            _context.Database.ExecuteSqlCommand("DELETE FROM  [DisciplinaProfesor]");
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('DisciplinaProfesor', RESEED, 0)");
            _context.Database.ExecuteSqlCommand("DELETE FROM  [DisciplinaActivitate]");
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('DisciplinaActivitate', RESEED, 0)");
            _context.Database.ExecuteSqlCommand("DELETE FROM  [Profesor]");
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Profesor', RESEED, 0)");
            _context.Database.ExecuteSqlCommand("DELETE FROM  [Disciplina]");
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Disciplina', RESEED, 0)");
            _context.Database.ExecuteSqlCommand("DELETE FROM  [Sala]");
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Sala', RESEED, 0)");
            _context.Database.ExecuteSqlCommand("DELETE FROM  [SubGrupa]");
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('SubGrupa', RESEED, 0)");
            _context.Database.ExecuteSqlCommand("DELETE FROM  [Grupa]");
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Grupa', RESEED, 0)");
            _context.Database.ExecuteSqlCommand("DELETE FROM  [Generatie]");
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Generatie', RESEED, 0)");
            _context.Database.ExecuteSqlCommand("DELETE FROM  [Zile]");
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Zile', RESEED, 0)");
            _context.Database.ExecuteSqlCommand("DELETE FROM  [Activitate]");
            _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Activitate', RESEED, 0)");

            Zile[] zile = new Zile[]
            {
                new Zile() { Nume = "Luni"},
                new Zile() { Nume = "Marti" },
                new Zile() { Nume = "Miercuri" },
                new Zile() { Nume = "Joi" },
                new Zile() { Nume = "Vineri" },
            };

            Activitate[] activitate = new Activitate[]
            {
                new Activitate() { Nume = "Curs" },
                new Activitate() { Nume = "Seminar" },
                new Activitate() { Nume = "Laborator" },
                new Activitate() { Nume = "Proiect" }
            };

            Generatie[] generatie = new Generatie[]
            {
                new Generatie()
                {
                    AnStart = DateTime.Now.Year,
                    AnStop = DateTime.Now.Year+1,
                    AnStudiu = 1
                },
                new Generatie()
                {
                    AnStart = DateTime.Now.Year,
                    AnStop = DateTime.Now.Year+1,
                    AnStudiu = 2
                },
                new Generatie()
                {
                    AnStart = DateTime.Now.Year,
                    AnStop = DateTime.Now.Year+1,
                    AnStudiu = 3
                },
                new Generatie()
                {
                    AnStart = DateTime.Now.Year,
                    AnStop = DateTime.Now.Year+1,
                    AnStudiu = 4
                },
            };

            _context.Ziles.AddRange(zile);
            _context.Activitates.AddRange(activitate);
            _context.Generaties.AddRange(generatie);

            _context.SaveChanges();
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

        public DisciplinaActivitate AddDisciplinaActivitate(DisciplinaActivitate req)
        {
            var disciplinaActivitate = _context.DisciplinaActivitates.Add(req);
            _context.SaveChanges();
            return disciplinaActivitate;
        }

        /*
         * Sali
         */

        public Sala AddSala(Sala req)
        {
            var sala = _context.Salas.Add(req);

            //Sala sala;
            //sala = _context.Salas.Add(new Sala()
            //    {
          
            //        Nume = req.Nume,
            //        Capacitate = req.Capacitate,
            //        Activitate = req.Activitate,
                    
            //});
          
            _context.SaveChanges();
            return sala;
        }


        public void DeleteSala(int idSala)
        {
            var sala = _context.Disciplinas.Find(idSala);
            if (sala != null) _context.Disciplinas.Remove(sala);
            _context.SaveChanges();
        }

        /*
         * EOF Sali
         */


        /*
         * Generatie/Grupa/Subgrupa
         */

        public Grupa AddGrupa(Grupa req)
        {
            var grupa = _context.Grupas.Add(req);
            _context.SaveChanges();
            return grupa;
        }

        public Grupa CheckIfExists(string name)
        {
            var grupa = _context.Grupas.FirstOrDefault(x => x.Nume.Equals(name));
            return grupa;
        }

        public SubGrupa AddSubGrupa(SubGrupa req)
        {
            var subGrupa = _context.SubGrupas.Add(req);
            _context.SaveChanges();
            return subGrupa;
        }

    }
}
