using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certamen2.Semestre
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt_nombre = this.txt_nombre.Text;
            string txt_ano = this.txt_ano.Text;
            string cmBox = this.cmBox.Text;

            if (string.IsNullOrWhiteSpace(txt_nombre) ||
                string.IsNullOrWhiteSpace(txt_ano) ||
                string.IsNullOrWhiteSpace(cmBox))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                Listados.listaSemestres.Add(new DatosSemetres()
                {
                    ID_semestre_ = Listados.ID_Semestres++,
                    nombre_ = txt_nombre,
                    ano_ = txt_ano,
                    estado_ = cmBox
                });

                dataGridView1.Rows.Clear();
                foreach (var semestre in Listados.listaSemestres)
                {
                    dataGridView1.Rows.Add
                     (  semestre.ID_semestre_,
                        semestre.nombre_,
                        semestre.ano_,
                        semestre.estado_
                     );
                }
                MessageBox.Show("Semestre guardado");
            }
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clean text fields
            txt_nombre.Text = "";
            txt_ano.Text = "";
            cmBox.Text = "";

        }
    }
}
