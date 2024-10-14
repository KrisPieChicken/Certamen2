namespace Certamen2.Notas
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.cmBox_Alumno = new System.Windows.Forms.ComboBox();
            this.cmBox_Asig = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nota1 = new System.Windows.Forms.TextBox();
            this.txt_Nota2 = new System.Windows.Forms.TextBox();
            this.txt_Nota3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.alumnoNombre_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoApellido_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Nota3);
            this.panel1.Controls.Add(this.txt_Nota2);
            this.panel1.Controls.Add(this.txt_Nota1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Guardar);
            this.panel1.Controls.Add(this.cmBox_Alumno);
            this.panel1.Controls.Add(this.cmBox_Asig);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 100);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nota 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Asignatura";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(536, 41);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click_1);
            // 
            // cmBox_Alumno
            // 
            this.cmBox_Alumno.FormattingEnabled = true;
            this.cmBox_Alumno.Location = new System.Drawing.Point(177, 41);
            this.cmBox_Alumno.Name = "cmBox_Alumno";
            this.cmBox_Alumno.Size = new System.Drawing.Size(121, 21);
            this.cmBox_Alumno.TabIndex = 1;
            // 
            // cmBox_Asig
            // 
            this.cmBox_Asig.FormattingEnabled = true;
            this.cmBox_Asig.Location = new System.Drawing.Point(26, 41);
            this.cmBox_Asig.Name = "cmBox_Asig";
            this.cmBox_Asig.Size = new System.Drawing.Size(121, 21);
            this.cmBox_Asig.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.semestreToolStripMenuItem,
            this.asignaturaToolStripMenuItem,
            this.ingresoCursoToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.principalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // semestreToolStripMenuItem
            // 
            this.semestreToolStripMenuItem.Name = "semestreToolStripMenuItem";
            this.semestreToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.semestreToolStripMenuItem.Text = "Semestre";
            this.semestreToolStripMenuItem.Click += new System.EventHandler(this.semestreToolStripMenuItem_Click);
            // 
            // asignaturaToolStripMenuItem
            // 
            this.asignaturaToolStripMenuItem.Name = "asignaturaToolStripMenuItem";
            this.asignaturaToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.asignaturaToolStripMenuItem.Text = "Asignatura";
            this.asignaturaToolStripMenuItem.Click += new System.EventHandler(this.asignaturaToolStripMenuItem_Click);
            // 
            // ingresoCursoToolStripMenuItem
            // 
            this.ingresoCursoToolStripMenuItem.Name = "ingresoCursoToolStripMenuItem";
            this.ingresoCursoToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.ingresoCursoToolStripMenuItem.Text = "Ingreso Curso";
            this.ingresoCursoToolStripMenuItem.Click += new System.EventHandler(this.ingresoCursoToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alumnoNombre_,
            this.alumnoApellido_,
            this.nota1_,
            this.nota2_,
            this.nota3_});
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(684, 253);
            this.dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingresar Notas";
            // 
            // txt_Nota1
            // 
            this.txt_Nota1.Location = new System.Drawing.Point(330, 42);
            this.txt_Nota1.Name = "txt_Nota1";
            this.txt_Nota1.Size = new System.Drawing.Size(41, 20);
            this.txt_Nota1.TabIndex = 9;
            // 
            // txt_Nota2
            // 
            this.txt_Nota2.Location = new System.Drawing.Point(393, 42);
            this.txt_Nota2.Name = "txt_Nota2";
            this.txt_Nota2.Size = new System.Drawing.Size(42, 20);
            this.txt_Nota2.TabIndex = 10;
            // 
            // txt_Nota3
            // 
            this.txt_Nota3.Location = new System.Drawing.Point(456, 42);
            this.txt_Nota3.Name = "txt_Nota3";
            this.txt_Nota3.Size = new System.Drawing.Size(41, 20);
            this.txt_Nota3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nota 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(456, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nota 3";
            // 
            // alumnoNombre_
            // 
            this.alumnoNombre_.HeaderText = "Nombre";
            this.alumnoNombre_.Name = "alumnoNombre_";
            // 
            // alumnoApellido_
            // 
            this.alumnoApellido_.HeaderText = "Apellido";
            this.alumnoApellido_.Name = "alumnoApellido_";
            // 
            // nota1_
            // 
            this.nota1_.HeaderText = "Nota1";
            this.nota1_.Name = "nota1_";
            // 
            // nota2_
            // 
            this.nota2_.HeaderText = "Nota2";
            this.nota2_.Name = "nota2_";
            // 
            // nota3_
            // 
            this.nota3_.HeaderText = "Nota3";
            this.nota3_.Name = "nota3_";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.ComboBox cmBox_Alumno;
        private System.Windows.Forms.ComboBox cmBox_Asig;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Nota3;
        private System.Windows.Forms.TextBox txt_Nota2;
        private System.Windows.Forms.TextBox txt_Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnoNombre_;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnoApellido_;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1_;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2_;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3_;
    }
}