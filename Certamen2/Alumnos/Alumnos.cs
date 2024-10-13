
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
        }

        /// <summary>
        /// Método que se ejecuta al hacer clic en el botón "Guardar Alumnos".
        /// Obtiene los valores de los campos de texto y verifica si están vacíos.
        /// Si alguno de los campos está vacío, muestra un mensaje de error.
        /// Si todos los campos están completos, llama al método GuardarAlumno para guardar el alumno.
        /// Luego, limpia los campos de texto y muestra un mensaje de éxito.
        /// </summary>
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

    
        /// <summary>
        /// Método que se ejecuta al presionar una tecla en el campo de texto "txt_matricula".
        /// Verifica si la tecla presionada es un dígito o un carácter de control.
        /// Si no es un dígito ni un carácter de control, se bloquea la entrada de la tecla.
        /// </summary>
        private void txt_matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void semestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
