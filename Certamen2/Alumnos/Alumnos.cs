
using Certamen2.Asignatura;
using Certamen2.Semestre;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SemestreForm = Certamen2.Semestre;


namespace Certamen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txt_matricula.KeyPress += new KeyPressEventHandler(this.txt_matricula_KeyPress);
            LoadAlumnos();
        }

        private void btn_guardar_alumnos_Click(object sender, EventArgs e)
        {
            string txt_Nombre = txt_nombre.Text;
            string txt_Apellido = txt_apellido.Text;
            string txt_Matricula = txt_matricula.Text;

            if (string.IsNullOrWhiteSpace(txt_Nombre) ||
                string.IsNullOrWhiteSpace(txt_Apellido) ||
                string.IsNullOrWhiteSpace(txt_Matricula))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                Listados.listaAlumnos.Add(new DatosAlumnos()
                {
                    ID_Alumno = Listados.ID_Alumnos++,
                    Nombre = txt_Nombre,
                    Apellido = txt_Apellido,
                    Matricula = txt_Matricula
                });

                dataGridView1.Rows.Clear();
                foreach (var alumno in Listados.listaAlumnos)
                {
                    dataGridView1.Rows.Add
                    (
                        alumno.ID_Alumno,
                        alumno.Nombre,
                        alumno.Apellido,
                        alumno.Matricula
                    );
                }

                MessageBox.Show("Alumno guardado");
            }
        }

        private void txt_matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void semestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new SemestreForm.Form2());
        }
        private void LoadAlumnos()
        {
            dataGridView1.Rows.Clear(); 
            foreach (var alumno in Listados.listaAlumnos)
            {
                dataGridView1.Rows.Add(alumno.ID_Alumno, alumno.Nombre, alumno.Apellido, alumno.Matricula);
            }
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Form3());
        }

        private void ingresoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Curso.Form4());
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Notas.Form5());
        }
    }
}
