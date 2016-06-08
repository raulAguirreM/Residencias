namespace ProyectoIngenieria
{
    partial class modAlumno
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_empresa = new System.Windows.Forms.TextBox();
            this.tb_proyecto = new System.Windows.Forms.TextBox();
            this.tb_correo = new System.Windows.Forms.TextBox();
            this.tb_materno = new System.Windows.Forms.TextBox();
            this.tb_paterno = new System.Windows.Forms.TextBox();
            this.mtb_tel = new System.Windows.Forms.MaskedTextBox();
            this.cb_carrera = new System.Windows.Forms.ComboBox();
            this.ktb_matr = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "ELIMINAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 261);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // tb_empresa
            // 
            this.tb_empresa.Location = new System.Drawing.Point(188, 334);
            this.tb_empresa.Name = "tb_empresa";
            this.tb_empresa.Size = new System.Drawing.Size(100, 20);
            this.tb_empresa.TabIndex = 29;
            // 
            // tb_proyecto
            // 
            this.tb_proyecto.Location = new System.Drawing.Point(188, 292);
            this.tb_proyecto.Name = "tb_proyecto";
            this.tb_proyecto.Size = new System.Drawing.Size(100, 20);
            this.tb_proyecto.TabIndex = 27;
            // 
            // tb_correo
            // 
            this.tb_correo.Location = new System.Drawing.Point(188, 259);
            this.tb_correo.Name = "tb_correo";
            this.tb_correo.Size = new System.Drawing.Size(100, 20);
            this.tb_correo.TabIndex = 25;
            // 
            // tb_materno
            // 
            this.tb_materno.Location = new System.Drawing.Point(188, 147);
            this.tb_materno.Name = "tb_materno";
            this.tb_materno.Size = new System.Drawing.Size(100, 20);
            this.tb_materno.TabIndex = 20;
            // 
            // tb_paterno
            // 
            this.tb_paterno.Location = new System.Drawing.Point(188, 113);
            this.tb_paterno.Name = "tb_paterno";
            this.tb_paterno.Size = new System.Drawing.Size(100, 20);
            this.tb_paterno.TabIndex = 17;
            // 
            // mtb_tel
            // 
            this.mtb_tel.Location = new System.Drawing.Point(188, 223);
            this.mtb_tel.Mask = "9999999999";
            this.mtb_tel.Name = "mtb_tel";
            this.mtb_tel.Size = new System.Drawing.Size(100, 20);
            this.mtb_tel.TabIndex = 23;
            // 
            // cb_carrera
            // 
            this.cb_carrera.FormattingEnabled = true;
            this.cb_carrera.Items.AddRange(new object[] {
            "Sistemas",
            "Industrial ",
            "Gestion"});
            this.cb_carrera.Location = new System.Drawing.Point(188, 186);
            this.cb_carrera.Name = "cb_carrera";
            this.cb_carrera.Size = new System.Drawing.Size(121, 21);
            this.cb_carrera.TabIndex = 22;
            // 
            // ktb_matr
            // 
            this.ktb_matr.Location = new System.Drawing.Point(188, 34);
            this.ktb_matr.Mask = "999999999";
            this.ktb_matr.Name = "ktb_matr";
            this.ktb_matr.Size = new System.Drawing.Size(100, 20);
            this.ktb_matr.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "EMPRESA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "CORREO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "NOMBRE PROYECTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "TELEFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "CARRERA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "MATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "PATERNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "NOMBRE";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(188, 72);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_nombre.TabIndex = 16;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(580, 322);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(86, 28);
            this.btn_aceptar.TabIndex = 14;
            this.btn_aceptar.Text = "ACTUALIZAR";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "MATRICULA";
            // 
            // modAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_empresa);
            this.Controls.Add(this.tb_proyecto);
            this.Controls.Add(this.tb_correo);
            this.Controls.Add(this.tb_materno);
            this.Controls.Add(this.tb_paterno);
            this.Controls.Add(this.mtb_tel);
            this.Controls.Add(this.cb_carrera);
            this.Controls.Add(this.ktb_matr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label1);
            this.Name = "modAlumno";
            this.Text = "modAlumno";
            this.Load += new System.EventHandler(this.modAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_empresa;
        private System.Windows.Forms.TextBox tb_proyecto;
        private System.Windows.Forms.TextBox tb_correo;
        private System.Windows.Forms.TextBox tb_materno;
        private System.Windows.Forms.TextBox tb_paterno;
        private System.Windows.Forms.MaskedTextBox mtb_tel;
        private System.Windows.Forms.ComboBox cb_carrera;
        private System.Windows.Forms.MaskedTextBox ktb_matr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label1;
    }
}