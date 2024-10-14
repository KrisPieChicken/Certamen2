namespace Certamen2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Alumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_guardar_alumnos = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(16, 64);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(173, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(218, 64);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(157, 20);
            this.txt_apellido.TabIndex = 1;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(422, 64);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_matricula.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Alumnos,
            this.Nombre,
            this.Apellido,
            this.Matricula});
            this.dataGridView1.Location = new System.Drawing.Point(45, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(636, 222);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID_Alumnos
            // 
            this.ID_Alumnos.HeaderText = "ID Alumnos";
            this.ID_Alumnos.Name = "ID_Alumnos";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(16, 45);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(60, 17);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(218, 45);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(60, 17);
            this.lbl_apellido.TabIndex = 5;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.Location = new System.Drawing.Point(422, 45);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(66, 17);
            this.lbl_matricula.TabIndex = 6;
            this.lbl_matricula.Text = "Matrícula";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_apellido);
            this.panel1.Controls.Add(this.btn_guardar_alumnos);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.lbl_matricula);
            this.panel1.Controls.Add(this.txt_apellido);
            this.panel1.Controls.Add(this.txt_matricula);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Location = new System.Drawing.Point(46, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 139);
            this.panel1.TabIndex = 8;
            // 
            // btn_guardar_alumnos
            // 
            this.btn_guardar_alumnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_alumnos.Location = new System.Drawing.Point(508, 106);
            this.btn_guardar_alumnos.Name = "btn_guardar_alumnos";
            this.btn_guardar_alumnos.Size = new System.Drawing.Size(124, 30);
            this.btn_guardar_alumnos.TabIndex = 9;
            this.btn_guardar_alumnos.Text = "Guardar";
            this.btn_guardar_alumnos.UseVisualStyleBackColor = true;
            this.btn_guardar_alumnos.Click += new System.EventHandler(this.btn_guardar_alumnos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 33);
            this.menuStrip1.TabIndex = 10;
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
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Alumnos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_guardar_alumnos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Alumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
    }
}

