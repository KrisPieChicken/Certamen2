namespace Certamen2.Curso
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txt_Seccion = new System.Windows.Forms.TextBox();
            this.cmBox_Asignatura = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_curso_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignatura_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccion_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.btn_Guardar);
            this.panel1.Controls.Add(this.txt_Seccion);
            this.panel1.Controls.Add(this.cmBox_Asignatura);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 146);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Asignatura";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(36, 97);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(82, 29);
            this.btn_Limpiar.TabIndex = 3;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(490, 97);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(84, 29);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_Seccion
            // 
            this.txt_Seccion.Location = new System.Drawing.Point(266, 48);
            this.txt_Seccion.Name = "txt_Seccion";
            this.txt_Seccion.Size = new System.Drawing.Size(129, 20);
            this.txt_Seccion.TabIndex = 1;
            // 
            // cmBox_Asignatura
            // 
            this.cmBox_Asignatura.FormattingEnabled = true;
            this.cmBox_Asignatura.Location = new System.Drawing.Point(36, 48);
            this.cmBox_Asignatura.Name = "cmBox_Asignatura";
            this.cmBox_Asignatura.Size = new System.Drawing.Size(179, 21);
            this.cmBox_Asignatura.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_curso_,
            this.asignatura_,
            this.seccion_});
            this.dataGridView1.Location = new System.Drawing.Point(13, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(621, 217);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID_curso_
            // 
            this.ID_curso_.HeaderText = "ID Curso";
            this.ID_curso_.Name = "ID_curso_";
            // 
            // asignatura_
            // 
            this.asignatura_.HeaderText = "Asignatura";
            this.asignatura_.Name = "asignatura_";
            // 
            // seccion_
            // 
            this.seccion_.HeaderText = "Seccion";
            this.seccion_.Name = "seccion_";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 33);
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
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.notasToolStripMenuItem.Text = "Notas";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingresar Curso";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_Seccion;
        private System.Windows.Forms.ComboBox cmBox_Asignatura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_curso_;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatura_;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccion_;
    }
}