using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certamen2.Curso
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadEnabledAsignaturas();
            LoadCursos();
        }
        private void LoadEnabledAsignaturas()
        {
            cmBox_Asignatura.Items.Clear();

            var enabledSubjects = Listados.listaAsignaturas
                                  .Where(a => Listados.listaSemestres
                                        .Any(s => s.nombre_ == a.semestre_ && s.estado_ == "HABILITADO"))
                                  .ToList();

            foreach (var asignatura in enabledSubjects)
            {
                cmBox_Asignatura.Items.Add(asignatura.nombre_);
            }
        }

        private void LoadCursos()
        {
            dataGridView1.Rows.Clear();
            foreach (var curso in Listados.listaCursos)
            {
                dataGridView1.Rows.Add(curso.ID_curso_, curso.asignatura_, curso.seccion_);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string selectedAsignatura = cmBox_Asignatura.SelectedItem?.ToString();
            string seccion = txt_Seccion.Text;

            if (string.IsNullOrWhiteSpace(selectedAsignatura) || string.IsNullOrWhiteSpace(seccion))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            var existingCourse = Listados.listaCursos
                                    .FirstOrDefault(c => c.asignatura_ == selectedAsignatura && c.seccion_ == seccion);

            if (existingCourse != null)
            {
                MessageBox.Show("Ya existe una sección con este nombre para la asignatura seleccionada.");
                return;
            }

            int newId = Listados.listaCursos.Count > 0 ? Listados.listaCursos.Max(c => c.ID_curso_) + 1 : 1;

            Listados.listaCursos.Add(new DatosCursos()
            {
                ID_curso_ = newId, 
                asignatura_ = selectedAsignatura,
                seccion_ = seccion
            });

            MessageBox.Show("Curso guardado correctamente.");

            LimpiarCampos();
            LoadCursos();
        }

        private void LimpiarCampos()
        {
            cmBox_Asignatura.SelectedIndex = -1;
            txt_Seccion.Text = "";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Form1());
        }

        private void semestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Semestre.Form2());
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Asignatura.Form3());
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Notas.Form5());
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
