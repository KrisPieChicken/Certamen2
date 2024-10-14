namespace Certamen2.Asignatura
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBox_Asig = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre_Asig = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestre_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.datosSemetresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.datosSemetresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datosSemetresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosSemetresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosSemetresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosSemetresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmBox_Asig);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Nombre_Asig);
            this.panel1.Location = new System.Drawing.Point(22, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 124);
            this.panel1.TabIndex = 0;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(426, 81);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(121, 23);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Semestre";
            // 
            // cmBox_Asig
            // 
            this.cmBox_Asig.FormattingEnabled = true;
            this.cmBox_Asig.Location = new System.Drawing.Point(283, 44);
            this.cmBox_Asig.Name = "cmBox_Asig";
            this.cmBox_Asig.Size = new System.Drawing.Size(166, 21);
            this.cmBox_Asig.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txt_Nombre_Asig
            // 
            this.txt_Nombre_Asig.Location = new System.Drawing.Point(42, 45);
            this.txt_Nombre_Asig.Name = "txt_Nombre_Asig";
            this.txt_Nombre_Asig.Size = new System.Drawing.Size(165, 20);
            this.txt_Nombre_Asig.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 33);
            this.menuStrip1.TabIndex = 11;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Asignatura,
            this.nombre_,
            this.semestre_});
            this.dataGridView1.Location = new System.Drawing.Point(22, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(570, 220);
            this.dataGridView1.TabIndex = 12;
            // 
            // ID_Asignatura
            // 
            this.ID_Asignatura.HeaderText = "ID Asignatura";
            this.ID_Asignatura.Name = "ID_Asignatura";
            // 
            // nombre_
            // 
            this.nombre_.HeaderText = "Nombre";
            this.nombre_.Name = "nombre_";
            // 
            // semestre_
            // 
            this.semestre_.HeaderText = "Semestre";
            this.semestre_.Name = "semestre_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "ASIGNATURA";
            // 
            // datosSemetresBindingSource2
            // 
            this.datosSemetresBindingSource2.DataSource = typeof(Certamen2.Semestre.DatosSemetres);
            // 
            // datosSemetresBindingSource1
            // 
            this.datosSemetresBindingSource1.DataSource = typeof(Certamen2.Semestre.DatosSemetres);
            // 
            // datosSemetresBindingSource
            // 
            this.datosSemetresBindingSource.DataSource = typeof(Certamen2.Semestre.DatosSemetres);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignatura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosSemetresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosSemetresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosSemetresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmBox_Asig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre_Asig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.BindingSource datosSemetresBindingSource;
        private System.Windows.Forms.BindingSource datosSemetresBindingSource1;
        private System.Windows.Forms.BindingSource datosSemetresBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestre_;
    }
}