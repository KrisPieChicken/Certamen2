using Certamen2.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Certamen2.Semestre
{
    public partial class Form2 : Form
    {
        int idTemporal = 0;  

        public Form2()
        {
            InitializeComponent();
            LoadSemestres();
        }
        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Form1());
        }
        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Asignatura.Form3());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt_nombre = this.txt_nombre.Text;
            string txt_ano = this.txt_ano.Text;

            if (string.IsNullOrWhiteSpace(txt_nombre) ||
                string.IsNullOrWhiteSpace(txt_ano))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                string estado = chkBox_habilitado.Checked ? "HABILITADO" : "DESHABILITADO";

                if (idTemporal == 0)
                {
                    Listados.listaSemestres.Add(new DatosSemetres()
                    {
                        ID_semestre_ = Listados.ID_Semestres++,
                        nombre_ = txt_nombre,
                        ano_ = txt_ano,
                        estado_ = estado 
                    });

                    MessageBox.Show("Semestre guardado");
                }
                else
                {
                    var semestreToUpdate = Listados.listaSemestres.FirstOrDefault(s => s.ID_semestre_ == idTemporal);

                    if (semestreToUpdate != null)
                    {
                        semestreToUpdate.nombre_ = txt_nombre;
                        semestreToUpdate.ano_ = txt_ano;
                        semestreToUpdate.estado_ = estado; 

                        MessageBox.Show("Semestre actualizado");
                    }

                    idTemporal = 0;
                }
                LoadSemestres();
                LimpiartextFields();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LimpiartextFields();
            idTemporal = 0; 
        }

        public void LimpiartextFields()
        {
            txt_nombre.Text = "";
            txt_ano.Text = "";            
            chkBox_habilitado.Checked = false;
        }

        private void LoadSemestres()
        {
            dataGridView1.Rows.Clear();
            foreach (var semestre in Listados.listaSemestres)
            {
                dataGridView1.Rows.Add(semestre.ID_semestre_, semestre.nombre_, semestre.ano_, semestre.estado_);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (e.RowIndex != -1)
                {
                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    string nombre = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string ano = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string estado = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                    idTemporal = id;
                    txt_nombre.Text = nombre;
                    txt_ano.Text = ano;

                    chkBox_habilitado.Checked = estado == "HABILITADO"; 
                }
            }
        }

        private void txt_ano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ingresoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Form4());
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigacionControl.Abrir(this, new Notas.Form5());
        }
    }
}
