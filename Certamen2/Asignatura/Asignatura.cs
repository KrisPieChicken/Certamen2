using Certamen2.Semestre;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Certamen2.Asignatura
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadEnabledSemesters();
            LoadAsignaturas(); 
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Form1());
        }

        private void semestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Form2());
        }

        private void LoadEnabledSemesters()
        {
            cmBox_Asig.Items.Clear();

            var enabledSemesters = Listados.listaSemestres.Where(s => s.estado_ == "HABILITADO").ToList();

            foreach (var semestre in enabledSemesters)
            {
                cmBox_Asig.Items.Add(semestre.nombre_);
            }
        }

        private void LimpiarCampos()
        {
            txt_Nombre_Asig.Text = "";
            cmBox_Asig.SelectedIndex = -1;
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string subjectName = txt_Nombre_Asig.Text;
            string selectedSemester = cmBox_Asig.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(subjectName) || string.IsNullOrWhiteSpace(selectedSemester))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            Listados.listaAsignaturas.Add(new DatosAsignatura()
            {
                ID_asignatura_ = Listados.ID_Asignaturas++,
                nombre_ = subjectName,
                semestre_ = selectedSemester 
            });

            MessageBox.Show("Asignatura guardada correctamente."); 
            LimpiarCampos();
            LoadAsignaturas();
        }

        private void LoadAsignaturas()
        {
            dataGridView1.Rows.Clear();
            foreach (var asignatura in Listados.listaAsignaturas)
            {
                dataGridView1.Rows.Add(asignatura.ID_asignatura_, asignatura.nombre_, asignatura.semestre_);
            }
        }

        private void ingresoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Curso.Form4());
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Notas.Form5());
        }
    }
}
