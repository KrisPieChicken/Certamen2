using Certamen2.Semestre;
using Certamen2.Asignatura;
using Certamen2.Curso;
using Certamen2.Notas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certamen2
{
    internal class Listados
    {
        static public List<DatosSemetres> listaSemestres = new List<DatosSemetres>();
        static public List<DatosAlumnos> listaAlumnos = new List<DatosAlumnos>();
        static public List<DatosAsignatura> listaAsignaturas = new List<DatosAsignatura>();
        static public List<DatosCursos> listaCursos = new List<DatosCursos>();
        static public List<DatosNotas> listaNotas = new List<DatosNotas>();

        static public int ID_Semestres = 1;
        static public int ID_Alumnos = 1;
        static public int ID_Asignaturas = 1;
        static public int ID_Cursos = 1;
        static public int ID_Notas = 1;


    }
}
