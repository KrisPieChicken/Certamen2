using Certamen2.Asignatura;
using Certamen2.Curso;
using Certamen2.Semestre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certamen2.Notas
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            LoadEnabledCourses();
            LoadStudents();
            LoadGradeNumbers();
            this.Shown += Siempre_Muestra;
        }
        private void Siempre_Muestra(object sender, EventArgs e)
        {
            LoadNotas(); 
        }
        private void LoadEnabledCourses()
        {
            cmBox_Asig.Items.Clear();
            var enabledCourses = Listados.listaAsignaturas
                .Where(a => Listados.listaSemestres.Any(s => s.nombre_ == a.semestre_ && s.estado_ == "HABILITADO"))
                .ToList();

            foreach (var course in enabledCourses)
            {
                cmBox_Asig.Items.Add(course.nombre_);
            }
        }

        private void LoadStudents()
        {
            cmBox_Alumno.Items.Clear();
            foreach (var student in Listados.listaAlumnos)
            {
                cmBox_Alumno.Items.Add($"{student.Nombre} {student.Apellido}");
            }
        }

        private void LoadGradeNumbers()
        {
            txt_Nota1.Clear();
            txt_Nota2.Clear();
            txt_Nota3.Clear();
        }

        private void LoadNotas()
        {
            dataGridView1.Rows.Clear();
            foreach (var nota in Listados.listaNotas)
            {
                var alumno = Listados.listaAlumnos.FirstOrDefault(a => a.Nombre == nota.alumnoNombre_ && a.Apellido == nota.alumnoApellido_);
                if (alumno != null)
                {
                    dataGridView1.Rows.Add(nota.alumnoNombre_, nota.alumnoApellido_, nota.nota1_, nota.nota2_, nota.nota3_);
                }
            }
        }
        private void LimpiarCampos()
        {
            cmBox_Asig.SelectedIndex = -1;
            cmBox_Alumno.SelectedIndex = -1;
            LoadGradeNumbers(); 
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Form1());
        }

        private void semestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Form2());
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Form3());
        }

        private void ingresoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Form4());
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {
            string selectedAsignatura = cmBox_Asig.SelectedItem?.ToString();
            string selectedAlumno = cmBox_Alumno.SelectedItem?.ToString();

            // Split student's full name to Name and Surname
            var alumnoSplit = selectedAlumno?.Split(' ');
            if (alumnoSplit.Length < 2)
            {
                MessageBox.Show("Debe seleccionar un alumno con nombre y apellido.");
                return;
            }
            string alumnoNombre = alumnoSplit[0];
            string alumnoApellido = alumnoSplit[1];

            if (!double.TryParse(txt_Nota1.Text, out double nota1)) nota1 = 0.0;
            if (!double.TryParse(txt_Nota2.Text, out double nota2)) nota2 = 0.0;
            if (!double.TryParse(txt_Nota3.Text, out double nota3)) nota3 = 0.0;

            if (string.IsNullOrWhiteSpace(selectedAsignatura) || string.IsNullOrWhiteSpace(selectedAlumno))
            {
                MessageBox.Show("Debe seleccionar Asignatura y Alumno, y completar las notas.");
                return;
            }

            var existingRecord = Listados.listaNotas.FirstOrDefault(n => n.asignatura_ == selectedAsignatura && n.alumnoNombre_ == alumnoNombre && n.alumnoApellido_ == alumnoApellido);

            if (existingRecord != null)
            {
                existingRecord.nota1_ = nota1;
                existingRecord.nota2_ = nota2;
                existingRecord.nota3_ = nota3;
                MessageBox.Show("Notas actualizadas correctamente.");
            }
            else
            {
                Listados.listaNotas.Add(new DatosNotas()
                {
                    ID_nota_ = Listados.ID_Notas++,
                    asignatura_ = selectedAsignatura,
                    alumnoNombre_ = alumnoNombre,
                    alumnoApellido_ = alumnoApellido,
                    nota1_ = nota1,
                    nota2_ = nota2,
                    nota3_ = nota3
                });
                MessageBox.Show("Notas guardadas correctamente.");
            }

            LoadNotas();
            LimpiarCampos();
        }
    }
}