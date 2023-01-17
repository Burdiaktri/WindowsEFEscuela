using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public static class AbmAlumno
    {
        private static DBEscuelaContext context = new DBEscuelaContext();

        public static List<Alumno> SelectAll()
        {
            return context.Alumnos.ToList();
        }

        public static Alumno SelectById(int id)
        {
            return context.Alumnos.Find(id);
        }

        public static int Insert(Alumno alumno)
        {
            context.Alumnos.Add(alumno);
            return context.SaveChanges();

        }

        public static int Update(Alumno alumno)
        {
            Alumno alumnoInicial = context.Alumnos.Find(alumno.IdAlumno);

            alumnoInicial.Nombre = alumno.Nombre;
            alumnoInicial.Apellido = alumno.Apellido;
            alumnoInicial.FechaNacimiento = alumno.FechaNacimiento;
            alumnoInicial.ProfesorId = alumno.ProfesorId;

            return context.SaveChanges();
        }

        public static int Eliminar(Alumno alumno)
        {
            Alumno alumnoInicial = context.Alumnos.Find(alumno.IdAlumno);
            if(alumnoInicial != null)
            {
                context.Alumnos.Remove(alumnoInicial);
                return context.SaveChanges();
            }

            return 0;
            
        }
    }
}
